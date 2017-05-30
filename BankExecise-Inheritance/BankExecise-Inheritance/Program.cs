using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExecise_Inheritance
{
    //After defining the classes in this hiearchy, write an app that creates objects of each class and tests their methods.
    //Add interest to the SavingAccount object by first invoking its CalculateInterest method, then passing the returned interest
    // to the object's Credit method.
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalCredit = 0.0M;
            SavingAccount sa = new SavingAccount(1000.25M, 0.1M);

            Console.WriteLine("Beginning balance is {0:C}", sa.Balance);

            totalCredit = sa.CalculatedInterest();
            Console.WriteLine("Total interest: {0:C}", totalCredit);

            sa.Credit(totalCredit); //adds credit to balance
            Console.WriteLine("Ending balance is: {0:C}", sa.Balance);

            Console.WriteLine();

            //Checking account has a fee for every transaction
            CheckingAccount ca = new CheckingAccount(1000.25M, 5.50M);
            Console.WriteLine("Beginning balance is {0:C}", ca.Balance);
            ca.Credit(55.25M); //this adds to the account (-fee)
            ca.Debit(925.55M); //taken from the account (-fee)
            Console.WriteLine("Ending Balance is {0:C}", ca.Balance);

            Console.ReadLine();
        }
    }
}
