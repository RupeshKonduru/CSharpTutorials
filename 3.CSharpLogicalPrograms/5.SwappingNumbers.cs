using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class SwappingNumbers
    {
        public static void Main()
        {
            //Method 1
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");
            temp = number1; //temp=10
            number1 = number2; //number1=20      
            number2 = temp; //number2=10    
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");

            //Method 2
            Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");
            number1 = number1 * number2; //number1=200 (10*20)      
            number2 = number1 / number2; //number2=10 (200/20)      
            number1 = number1 / number2; //number1=20 (200/10)    
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");

            //Method 3
            Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");
            number1 = number1 + number2; //number1=30 (10+20)      
            number2 = number1 - number2; //number2=10 (30-20)      
            number1 = number1 - number2; //number1=20 (30-10)    
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");

            //Method 4
            string name1 = "Dotnet", name2 = "Tutorials";
            Console.WriteLine($"Before SWapping name1= {name1}, name2 = {name2}");
            // Step1: append 2nd string with the 1st string 
            name1 = name1 + name2;
            //Step2: store intial string name1 in string name2 
            name2 = name1.Substring(0, name1.Length - name2.Length);
            //Step3:  store initial string name2 in string name1 
            name1 = name1.Substring(name2.Length);

            Console.WriteLine($"After swapping name1= {name1}, name2 = {name2}");
            Console.ReadKey();
        }
    }
}
