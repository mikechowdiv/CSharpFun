using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExecise_Inheritance
{
    public class Account
    {
        //one private instance variable of type decimal to represent the account balance
        private decimal _balance;

        //constructor that receivea an initial balance and uses it to initialize the instance variable with public property
        public Account(decimal balance)
        {
            Balance = balance;
        }

        //The property should validate the initial balance
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0) _balance = value;
                else
                    throw new Exception("Balance cannot be negative. ");
            }
        }

        //Method "Credit" should add amount to the current balance
        public virtual void Credit(decimal amount)
        {
            if (amount > 0) Balance += amount;
            else
                throw new Exception("Credit amount must be greater than zero");
        }

        //Method "Debit should withdraw money from the Account and ensure the debit amount does not exceed the Account's balance.
        //If it does, the balance should be left unchanged, and the method should display the message "Debit amount exceeded account balance".

        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if(Balance - amount >= 0)
            {
                Balance -= amount;
                OK = true;
            }
            else
            {
                Console.WriteLine("debit amount does not exceed the Account's balance");
                OK = false;
            }
            return OK;
        }
    }
}
