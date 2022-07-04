using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luck
{
    public class LuckyDay
    {
        public static void drawDay()
        {
            List<string> days = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var random = new Random();

            var luckyDay = random.Next(days.Count);
            if(luckyDay == 0)
            {
                Console.WriteLine($"OMG! You're lucky day is {days[luckyDay]}!" +
                    $"If you don't like it and you want choose again press N!");
            }
            else
            {
                Console.WriteLine($"You're lucky day is {days[luckyDay]}!");
            }

            
        }
    }
}
