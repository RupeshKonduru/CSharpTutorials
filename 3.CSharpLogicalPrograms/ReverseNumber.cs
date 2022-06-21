using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());
            int reminder, reverse = 0;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = number % 10;
                //multiply the sum with 10 and then add the reminder
                reverse = (reverse * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            Console.WriteLine($"The Reverse order is : {reverse}");

            Console.Write("Enter a String : ");
            string name = Console.ReadLine();
            //string reverse = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            Console.WriteLine($"The Reverse string is : {reverse}");

            Console.Write("Enter a String : ");
            //string name = Console.ReadLine();
            //string reverse = string.Empty;
            foreach (char c in name)
            {
                reverse = c + reverse;
            }

            Console.WriteLine($"The Reverse string is : {reverse}");

            Console.Write("Enter a String : ");
            //string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            //string reverse = new string(nameArray);

            Console.WriteLine($"The Reverse string is : {reverse}");

            Console.ReadKey();
        }
    }
}
