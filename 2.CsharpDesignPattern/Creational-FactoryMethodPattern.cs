using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public abstract class CreditCardFactoryMethod
    {
        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }

    public class MoneyBackFactory : CreditCardFactoryMethod
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }
    public class PlatinumFactory : CreditCardFactoryMethod
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
    public class TitaniumFactory : CreditCardFactoryMethod
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }
    //class FactoryMethod
    //{
    //    static void Main(string[] args)
    //    {

    //        CreditCard creditCard = new PlatinumFactory().CreateProduct();
    //        if (creditCard != null)
    //        {
    //            Console.WriteLine("Card Type : " + creditCard.GetCardType());
    //            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    //            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
    //        }
    //        else
    //        {
    //            Console.Write("Invalid Card Type");
    //        }
    //        Console.WriteLine("--------------");
    //        creditCard = new MoneyBackFactory().CreateProduct();
    //        if (creditCard != null)
    //        {
    //            Console.WriteLine("Card Type : " + creditCard.GetCardType());
    //            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
    //            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
    //        }
    //        else
    //        {
    //            Console.Write("Invalid Card Type");
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
