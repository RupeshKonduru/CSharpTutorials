using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public interface IVendingMachineState
    {
        void SelectProductAndInsertMoney(int amount, String productName);
        void DispenseProduct();
    }
    public class NoMoneyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Vending Machine cannot dispense product because money is not inserted and product is not selected");
        }
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine(amount + "Rs has been inserted and " + productName + " has been selected");
        }
    }
    public class HasMoneyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Vending Machine  dispensed the product ");
        }
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine("Already Vending machine has money and product selected, So wait till it finish the current dispensing process");
        }
    }
    public class VendingMachine : IVendingMachineState
    {
        //Createing a variable to maintain the internal state
        public IVendingMachineState vendingMachineState { get; set; }
        //Initially the vending machine has NoMoneyState
        public VendingMachine()
        {
            vendingMachineState = new NoMoneyState();
        }

        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            vendingMachineState.SelectProductAndInsertMoney(amount, productName);
            // Money has been inserted so vending Machine internal state 
            // changed to 'hasMoneyState'
            if (vendingMachineState is NoMoneyState)
            {
                vendingMachineState = new HasMoneyState();
                Console.WriteLine("VendingMachine internal state has been moved to : "
                                + vendingMachineState.GetType().Name);
            }
        }
        public void DispenseProduct()
        {
            vendingMachineState.DispenseProduct();
            // Product has been dispensed so vending Machine changed the
            // internal state to 'NoMoneyState'
            if (vendingMachineState is HasMoneyState)
            {
                vendingMachineState = new NoMoneyState();
                Console.WriteLine("VendingMachine internal state has been moved to : "
                                + vendingMachineState.GetType().Name);
            }
        }
    }
    class StateRealTimeDesignPattern
    {
        static void Main(string[] args)
        {
            // Initially Vending Machine will be 'noMoneyState'
            VendingMachine vendingMachine = new VendingMachine();
            Console.WriteLine("Current VendingMachine State : "
                            + vendingMachine.vendingMachineState.GetType().Name + "\n");
            vendingMachine.DispenseProduct();
            vendingMachine.SelectProductAndInsertMoney(50, "Pepsi");
            // Money has been inserted so vending Machine internal state
            // changed to 'hasMoneyState'
            Console.WriteLine("\nCurrent VendingMachine State : "
                            + vendingMachine.vendingMachineState.GetType().Name + "\n");
            vendingMachine.SelectProductAndInsertMoney(50, "Fanta");
            vendingMachine.DispenseProduct();
            // Product has been dispensed so vending Machine internal state
            // changed to 'NoMoneyState'
            Console.WriteLine("\nCurrent VendingMachine State : "
                            + vendingMachine.vendingMachineState.GetType().Name);
            Console.Read();
        }
    }
}
