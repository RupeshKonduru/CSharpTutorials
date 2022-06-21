using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class PrintWeekDay
    {
        // Main Method 
        static void Main(string[] args)
        {
            int wday;

            //input wday number
            Console.Write("Enter weekday number (0-6): ");
            wday = Convert.ToInt32(Console.ReadLine());

            //validating using switch case
            switch (wday)
            {
                case 0:
                    Console.WriteLine("It's SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("It's MONDAY");
                    break;
                case 2:
                    Console.WriteLine("It's TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("It's WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("It's THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("It's FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("It's SATURDAY");
                    break;

                //if no case value is matched
                default:
                    Console.WriteLine("It's wrong input...");
                    break;
            }

            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
