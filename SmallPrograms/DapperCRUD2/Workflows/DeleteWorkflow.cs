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
    public class DeleteWorkflow
    {
        public static IContactsRepo contactsRepository = new ContactsRepo();

        public void Exe()
        {
            Console.Clear();

            ListWorkflow lwf = new ListWorkflow();
            lwf.Exe();

            Console.WriteLine(ConsoleIO.SeparationBar);

            Console.WriteLine("Select ID to remove");

            int id = Convert.ToInt32(Console.ReadLine());
            contactsRepository.Delete(id);
            Contacts removedContact = contactsRepository.GetById(3);

            if (removedContact == null)
            {
                Console.WriteLine("Record already removed...");
            }

            lwf.Exe();
        }
    }
}
