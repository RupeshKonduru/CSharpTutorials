using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Miscelleneaous
{
    class Demo
    {
        

        //static void Main()
        //{
        //    Console.ReadKey();
        //}
    }
    public interface IAnimal
    {
        string Speak();

    }
    class Cat : IAnimal
    {
       public  string Speak()
        {
            return "Meow";
        }
    }
    class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
    public  abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);

        public static AnimalFactory GetAnimalFactory(string animalFactory)
        {
            if(animalFactory=="Sea")
            {
                return new SeaAnimalFactory();
            }
            else if (animalFactory == "Land")
            {
                return new LandAnimalFactory();
            }
            return null;
        }

    }

    class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType == "Cat")
            {
                return new Cat();
            }
            else
                return null;
        }
    }
    class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType == "Lion")
            {
                return new Lion();
            }
            else
                return null;
        }
    }
    class DemosAbstract
    {
        public static void Main()
        {
            var anmialFactory = AnimalFactory.GetAnimalFactory("sea");
            var getANmialType = anmialFactory.GetAnimal("cat");
            var speak = getANmialType.Speak();

            var getType = getANmialType.GetType();
        }
    }
}
