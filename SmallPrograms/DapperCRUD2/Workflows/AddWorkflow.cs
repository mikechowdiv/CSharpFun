using Data;
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
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Enter the FirstName, LastName , Company And Title Of Contacts");
            Console.Write("First Name : ");
            String fName = Console.ReadLine();
            Console.Write("Last Name : ");
            String lName = Console.ReadLine();
            Console.Write("Company Name : ");
            String company = Console.ReadLine();
            Console.Write("Title Name : ");
            String title = Console.ReadLine();
            //inserting
            Contacts contacts1 = new Contacts
            {
                FirstName = fName,
                LastName = lName,
                Company = company,
                Title = title
            };
            contactsRepository.Add(contacts1);

            ListWorkflow lwf = new ListWorkflow();
            lwf.Exe();
           
        }
    }
}
