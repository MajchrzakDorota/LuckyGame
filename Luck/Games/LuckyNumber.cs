using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luck
{
    public class LuckyNumber
    {
        public static void drawLuckyNumber()
        {
            var random = new Random();
            var luckyNumber = random.Next(1, 500);

            Console.WriteLine($"You're lucky number is: {luckyNumber}!");
        }
    }
}
