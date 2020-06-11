using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    class Structural_Facade
    {
        public class Product
        {
            public void GetProductDetails()
            {
                Console.WriteLine("Fetching the Product Details");
            }
        }
        public class Payment
        {
            public void MakePayment()
            {
                Console.WriteLine("Payment Done Successfully");
            }
        }
        public class Invoice
        {
            public void Sendinvoice()
            {
                Console.WriteLine("Invoice Send Successfully");
            }
        }
        public class Order
        {
            public void PlaceOrder()
            {
                Console.WriteLine("Place Order Started");
                Product product = new Product();
                product.GetProductDetails();
                Payment payment = new Payment();
                payment.MakePayment();
                Invoice invoice = new Invoice();
                invoice.Sendinvoice();
                Console.WriteLine("Order Placed Successfully");
            }
        }
        
    }
    class FacadeDesignPattern
    {
        static void Main(string[] args)
        {
            Structural_Facade.Order order = new Structural_Facade.Order();
            order.PlaceOrder();
            Console.Read();
        }
    }

}
