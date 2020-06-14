using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public interface ATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
    public class DebitCardNotInsertedState : ATMState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("DebitCard Inserted");
        }
        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot eject the Debit CardNo, as no Debit Card in ATM Machine slot");
        }
        public void EnterPin()
        {
            Console.WriteLine("you cannot enter the pin, as No Debit Card in ATM Machine slot");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("you cannot withdraw money, as No Debit Card in ATM Machine slot");
        }
    }
    public class DebitCardInsertedState : ATMState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("You cannot insert the Debit Card, as the Debit card is already there ");
        }
        public void EjectDebitCard()
        {
            Console.WriteLine("Debit Card is ejected");
        }
        public void EnterPin()
        {
            Console.WriteLine("Pin number has been entered correctly");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("Money has been withdrawn");
        }
    }
    public class ATMMachine : ATMState
    {
        public ATMState atmMachineState { get; set; }
        public ATMMachine()
        {
            atmMachineState = new DebitCardNotInsertedState();
        }
        public void InsertDebitCard()
        {
            atmMachineState.InsertDebitCard();
            // Debit Card has been inserted so internal state of ATM Machine
            // has been changed to 'DebitCardNotInsertedState'

            if (atmMachineState is DebitCardNotInsertedState)
            {
                atmMachineState = new DebitCardInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + atmMachineState.GetType().Name);
            }
        }
        public void EjectDebitCard()
        {
            atmMachineState.EjectDebitCard();
            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to 'DebitCardNotInsertedState'

            if (atmMachineState is DebitCardInsertedState)
            {
                atmMachineState = new DebitCardNotInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + atmMachineState.GetType().Name);
            }
        }
        public void EnterPin()
        {
            atmMachineState.EnterPin();
        }
        public void WithdrawMoney()
        {
            atmMachineState.WithdrawMoney();
        }
    }
    class StateDesignPattern
    {
        static void Main(string[] args)
        {
            // Initially ATM Machine in DebitCardNotInsertedState
            ATMMachine atmMachine = new ATMMachine();
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.EjectDebitCard();
            atmMachine.InsertDebitCard();
            Console.WriteLine();
            // Debit Card has been inserted so internal state of ATM Machine
            // has been changed to DebitCardInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.InsertDebitCard();
            atmMachine.EjectDebitCard();
            Console.WriteLine("");
            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to DebitCardNotInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.Read();
        }
    }
}
