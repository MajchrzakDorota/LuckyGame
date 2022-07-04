using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luck
{
    public class LuckyDate
    {
        public static void drawLuckyDate()
        {
            var random = new Random();
            var randomMonth = random.Next(1, 13);
            var randomDay = random.Next(1, 32);

            if(randomMonth == 2)
            {
                 randomDay = random.Next(1, 29);
            }


            Console.WriteLine($"You're lucky date is: {randomDay}/{randomMonth}");

        } 
    }
}
