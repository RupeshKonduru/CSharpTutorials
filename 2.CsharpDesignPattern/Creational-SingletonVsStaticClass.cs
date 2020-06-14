using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            // Convert argument to double for calculations.
            double celsius = Double.Parse(temperatureCelsius);
            // Convert Celsius to Fahrenheit.
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            // Convert argument to double for calculations.
            double fahrenheit = Double.Parse(temperatureFahrenheit);
            // Convert Fahrenheit to Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
    class SingletonVsStaticClass
    {
        static void Main()
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");
            Console.Write(":");
            string selection = Console.ReadLine();
            double F, C = 0;
            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the Celsius temperature: ");
                    F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;
                case "2":
                    Console.Write("Please enter the Fahrenheit temperature: ");
                    C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;
                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
