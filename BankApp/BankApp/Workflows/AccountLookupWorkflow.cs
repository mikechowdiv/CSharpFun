using BLL;
using Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Workflows
{
   public class AccountLookupWorkflow
    {
        public void Execute()
        {
            //load the Account Manager to lookup the data
            //Ask the Factory to fetch us an Account Manager object.
            AccountManager manager = Factory.Create();

            Console.Clear();
            Console.WriteLine("Lookup an account");
            Console.WriteLine("-----------------------------------------------");

            Console.Write("enter an account number: ");
            string accountNum = Console.ReadLine();

            AcctLookupResponse response = manager.LookupAcct(accountNum);

            if (response.Success)
            {
                ConsoleIO.DisplayAccountDetails(response.Account);              
            }
            else
            {
                Console.WriteLine("an error occurred: ");
                Console.WriteLine(response.Message);                
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
