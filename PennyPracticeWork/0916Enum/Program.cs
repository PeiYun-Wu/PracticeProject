using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0916Enum
{
    class Program
    {
        //列舉Enum
        static void Main(string[] args)
        {
            //使用列舉的值
            DaysOfWeek today = DaysOfWeek.Wednesday;
            Console.WriteLine("Today is " + today);
            Console.WriteLine();

            //轉換為int
            int dayNumber = (int)today;
            Console.WriteLine("Day number: " + dayNumber);
            Console.WriteLine();

            //假設使用者選擇2
            int userChoice = 2; 
            DaysOfWeek chosenDay = (DaysOfWeek)userChoice;
            Console.WriteLine("You chose " + chosenDay);
            Console.WriteLine();

            //全部舉出
            Console.WriteLine("Days of the week:");
            foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();

            //使用switch
            switch (today)
            {
                case DaysOfWeek.Sunday:
                    Console.WriteLine("It's a relaxing day.");
                    break;
                case DaysOfWeek.Monday:
                case DaysOfWeek.Wednesday:
                case DaysOfWeek.Friday:
                    Console.WriteLine("It's a workday.");
                    break;
                case DaysOfWeek.Tuesday:
                case DaysOfWeek.Thursday:
                    Console.WriteLine("It's a almost-weekend day.");
                    break;
                case DaysOfWeek.Saturday:
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }

            switch (userChoice)
            {
                case 0:
                    Console.WriteLine("It's a relaxing day.");
                    break;
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("It's a workday.");
                    break;
                case 2:
                case 4:
                    Console.WriteLine("It's a almost-weekend day.");
                    break;
                case 6:
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }
            Console.ReadKey();

        }
        public enum DaysOfWeek
        {
            //可不定義,default從0開始
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }
    }
}
