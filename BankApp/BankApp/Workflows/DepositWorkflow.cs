using BLL;
using Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Workflows
{
   public class DepositWorkflow
    {
        public void Execute()
        {
            Console.Clear();

            AccountManager acctMgr = Factory.Create();
            Console.WriteLine("Enter an account number: ");
            string acctNum = Console.ReadLine();

            Console.Write("Enter a deposit amount");
            decimal amt = decimal.Parse(Console.ReadLine());

            AccountDepositResponse response = acctMgr.Deposit(acctNum, amt);

            if (response.Success)
            {
                Console.WriteLine("Deposit completed!");
                Console.WriteLine($"Account Number : {response.Acct.AccountNumber}");
                Console.WriteLine($"Old balance: {response.OldBalance:c}");
                Console.WriteLine($"Deposit amount: { response.Amount:c}");
                Console.WriteLine($"New balance: {response.Acct.Balance:c}");
            }
            else
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(response.Message);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
