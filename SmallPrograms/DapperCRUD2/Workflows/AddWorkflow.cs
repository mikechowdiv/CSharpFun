using Data;
using Helpers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflows
{
    public class AddWorkflow
    {
        public static IContactsRepo contactsRepository = new ContactsRepo();

        public void Exe()
        {
            Console.Clear();
            Console.WriteLine(ConsoleIO.SeparationBar);
            Contacts contacts1 = new Contacts();

            contacts1.FirstName = ConsoleIO.GetRequiredStringFromUser("First Name: ");
            contacts1.LastName = ConsoleIO.GetRequiredStringFromUser("Last Name: ");
            contacts1.Company = ConsoleIO.GetRequiredStringFromUser("Company: ");
            contacts1.Title = ConsoleIO.GetRequiredStringFromUser("Title");

            Console.WriteLine();
            if (ConsoleIO.GetYesNoFromUser("Add the following info: ") == "Y")
            {
                contactsRepository.Add(contacts1);
                Console.WriteLine("Contact Added");
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Action Cancelled");
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
            }

            
            ListWorkflow lwf = new ListWorkflow();
            lwf.Exe();
           
        }
    }
}
