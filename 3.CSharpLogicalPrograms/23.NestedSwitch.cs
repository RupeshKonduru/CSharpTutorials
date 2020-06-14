using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class NestedSwitch
    {
        // Main Method 
        static void Main(string[] args)
        {
            int number;

            //input a number
            Console.Write("Enter a number (1-3): ");
            number = Convert.ToInt32(Console.ReadLine());

            //outer switch statement
            switch (number)
            {
                case 1:
                    //using another case 
                    //it will input R,G or B and print the color
                    char color;
                    Console.Write("Enter color value (R/G/B): ");
                    color = Console.ReadLine()[0];
                    //validating it using switch case
                    //inner switch
                    switch (color)
                    {
                        case 'R':
                        case 'r':
                            Console.WriteLine("You've choesn \"Red\" color");
                            break;
                        case 'G':
                        case 'g':
                            Console.WriteLine("You've choesn \"Green\" color");
                            break;
                        case 'B':
                        case 'b':
                            Console.WriteLine("You've choesn \"Blue\" color");
                            break;
                        default:
                            Console.WriteLine("Invalid color code");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Input is 2");
                    break;

                case 3:
                    Console.WriteLine("Input is 3");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }


            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
