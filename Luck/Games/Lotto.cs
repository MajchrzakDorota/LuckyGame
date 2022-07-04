using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luck
{
    public class Lotto
    {
        

        public  static void drawNumbers()
        {
            List<int> luckyNumbers = new List<int>();
            Random random = new Random();

           while(luckyNumbers.Count < 6)
            {
               int number = random.Next(1, 50);
                if (luckyNumbers.Contains(number))
                {
                    random.Next(1, 50);
                    luckyNumbers.Add(number);
                }
               luckyNumbers.Add(number);
            }
            Console.WriteLine("You're lucky numbers: ");

            luckyNumbers.Sort();
            foreach (int number in luckyNumbers)
            {
                Console.Write(number + " ");
            }
        }

    }

    
}
