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
    public class ListWorkflow
    {
        public static IContactsRepo contactsRepository = new ContactsRepo();

        public void Exe()
        {
            Console.WriteLine(ConsoleIO.SeparationBar);

            List<Contacts> contacts = contactsRepository.GetAll();
            foreach (var cont in contacts)
            {
                Console.WriteLine(cont.Id + " " + cont.FirstName + " " + cont.LastName + " " + cont.Company + " " + cont.Title);
            }
            Console.ReadLine();
        }
    }
}
