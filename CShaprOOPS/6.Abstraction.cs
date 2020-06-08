using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShaprOOPS
{
    class Abstraction
    {
        private string _CarName = "Honda City";
        private string _CarColur = "Black";
        public string CarName
        {
            set
            {
                _CarName = value;
            }
            get
            {
                return _CarName;
            }
        }
        public string CarColur
        {
            set
            {
                _CarColur = value;
            }
            get
            {
                return _CarColur;
            }
        }
        public void Steering()
        {
            Console.WriteLine("Streering of the Car");
        }
        
        public void Brakes()
        {
            Console.WriteLine("Brakes of the Car");
        }
        public void Gear()
        {
            Console.WriteLine("Gear of the Car");
        }
        private void CarEngine()
        {
            Console.WriteLine("Engine of the Car");
        }
        private void DiesalEngine()
        {
            Console.WriteLine("DiesalEngine of the Car");
        }
        
        private void Silencer()
        {
            Console.WriteLine("Silencer of the Car");
        }
        static void Main()
        {
            //Creating an instance of Car
            Abstraction CarObject = new Abstraction();
            //Accessing the Public Properties and methods
            string CarName = CarObject.CarName;
            string CarColur = CarObject.CarColur;
            CarObject.Brakes();
            CarObject.Gear();
            CarObject.Steering();
            //Try to access the private variables and methods
            //Compiler Error, 'Car._CarName' is inaccessible due to its protection level
            //CarObject._CarName;
            //Compiler Error, 'Car.CarEngine' is inaccessible due to its protection level
            CarObject.CarEngine();
            Console.ReadLine();           
        }
    }
}
