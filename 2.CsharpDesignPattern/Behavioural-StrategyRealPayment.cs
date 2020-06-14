using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Credit Card");
        }
    }
    public class DebitCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Debit Card");
        }
    }
    public class CashPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
        }
    }
    public class PaymentContext
    {
        private IPaymentStrategy PaymentStrategy;
        // The user will set the PaymentStrategy by 
        // calling this method at runtime
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this.PaymentStrategy = strategy;
        }
        public void Pay(double amount)
        {
            PaymentStrategy.Pay(amount);
        }
    }
    class StrategyRealTimePayment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Payment Type : CreditCard or DebitCard or Cash");
            string PaymentType = Console.ReadLine();
            Console.WriteLine("Payment type is : " + PaymentType);
            Console.WriteLine("\nPlease enter Amount to Pay : ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Amount is : " + Amount);
            PaymentContext context = new PaymentContext();

            if ("CreditCard".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if ("DebitCard".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if ("Cash".Equals(PaymentType, StringComparison.InvariantCultureIgnoreCase))
            {
                context.SetPaymentStrategy(new CashPaymentStrategy());
            }
            context.Pay(Amount);
            Console.ReadKey();
        }
    }
}
