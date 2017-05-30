using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExecise_Inheritance
{
    //Derived class SavingAccount should inherit the functionality of an Account, but also include a decimal instance variable
    //indicating the interest rate assigned to the Account.
    public class SavingAccount : Account
    {
        private decimal _interestRate;

        //SavingAccount's constructor should receive the initial balance as well as initial value for the interest rate.
        public SavingAccount(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value > 0) _interestRate = value;
                else
                {
                    throw new Exception("interest rate must be greate than zero");
                }
            }
        }

        //SavingAccount should provide public method
        //CalculateInterest that returns a decmial indicating the amount of interest earned by an account.
        //Method CalculatedInterest should determine this amount by multiplying the interest rate by the account balance.

        public decimal CalculatedInterest()
        {
            return Balance * InterestRate;

        }
    }
}
