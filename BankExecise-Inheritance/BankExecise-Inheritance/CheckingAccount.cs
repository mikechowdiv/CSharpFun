using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExecise_Inheritance
{
    //CheckingAccount should inherit from base class Account and include a decimal instance
    //variable that represents the fee charged per transaction
   public class CheckingAccount : Account
    {
        private decimal _fee;
        //constructor should receive the initial balance, as well as a parameter indicating a fee amount.
        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {
            Fee = fee;
        }
        public decimal Fee
        {
            get { return _fee; }
            set
            {
                if (value > 0) _fee = value;
                else
                    throw new Exception("Fee cannot be less than zero");
            }
        }

        //Class CheckingAccount should redefine methods Credit and Debit so they subtract the fee from the account balance whenever either transaction is performed successfully.
        //CheckingAccount's versions of these methods should invoke the base-class Account version to perform the updates to an account balance.
        //CheckingAccount's Debit method should charge a fee only if the money is actually wrthdrawn (i.e. the debit amount does not exceed the account balance).

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance -= Fee;
                return true;
            }
            return false;
        }
    }
}
