using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public interface ITravelStrategy
    {
        void GotoAirport();
    }
    public class AutoTravelStrategy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Auto and will be charged Rs 600");
        }
    }
    public class TrainTravelStrategy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Train and will be charged Rs 200");
        }
    }
    public class TaxiTravelStrategy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Taxi and will be charged Rs 1000");
        }
    }
    public class BusTravelStrategy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by bus and will be charged Rs 300");
        }
    }
    public class TravelContext
    {
        private ITravelStrategy travelStrategy;
        // The Client will set what TravelStrategy to use by 
        // calling this method at runtime
        public void SetTravelStrategy(ITravelStrategy strategy)
        {
            this.travelStrategy = strategy;
        }
        public void gotoAirport()
        {
            travelStrategy.GotoAirport();
        }
    }
    class StrategyRealTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Travel Type : Auto or Bus or Train or Taxi");
            string travelType = Console.ReadLine();
            Console.WriteLine("Travel type is : " + travelType);
            TravelContext ctx = null;
            ctx = new TravelContext();
            if ("Bus".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetTravelStrategy(new BusTravelStrategy());
            }
            else if ("Train".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetTravelStrategy(new TrainTravelStrategy());
            }
            else if ("Taxi".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetTravelStrategy(new TaxiTravelStrategy());
            }
            else if ("Auto".Equals(travelType, StringComparison.InvariantCultureIgnoreCase))
            {
                ctx.SetTravelStrategy(new AutoTravelStrategy());
            }
            ctx.gotoAirport();

            Console.Read();
        }
    }
}
