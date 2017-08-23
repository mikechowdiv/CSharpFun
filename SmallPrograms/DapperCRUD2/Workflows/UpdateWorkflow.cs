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
    public class UpdateWorkflow
    {
        public static IContactsRepo contactsRepository = new ContactsRepo();

        public void Exe()
        {
            int id;
            int ch;
            string Name;

            Console.WriteLine(ConsoleIO.SeparationBar);

            ListWorkflow lwf = new ListWorkflow();
            lwf.Exe();

            Console.WriteLine("Which ID do you want to edit?");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the one you want to edit: ");
            Console.WriteLine("1. First Name: ");
            Console.WriteLine("2. Last Name: ");
            Console.WriteLine("3. Company: ");
            Console.WriteLine("4. Title: ");
            ch = Convert.ToInt32(Console.ReadLine());

            Contacts contacts = contactsRepository.GetById(id);
            Name = null;

            switch (ch)
            {
                case 1:
                    Console.WriteLine("First Name: ");
                    string fname = Console.ReadLine();
                    contacts.FirstName = fname;
                    Name = "FirstName";
                    contactsRepository.Update(contacts, Name);
                    GetByID(id);
                    break;

                case 2:
                    Console.WriteLine("Last Name: ");
                    string lname = Console.ReadLine();
                    contacts.LastName = lname;
                    Name = "LastName";
                    contactsRepository.Update(contacts, Name);
                    GetByID(id);
                    break;

                case 3:
                    Console.WriteLine("Company: ");
                    string company = Console.ReadLine();
                    contacts.Company = company;
                    Name = "Company";
                    contactsRepository.Update(contacts, Name);
                    GetByID(id);
                    break;

                case 4:
                    Console.WriteLine("Title: ");
                    string title = Console.ReadLine();
                    contacts.Title = title;
                    Name = "Title";
                    contactsRepository.Update(contacts, Name);
                    GetByID(id);
                    break;

                default:
                    Console.WriteLine("Please make a selection: ");
                    break;
            }
        }

        public void GetByID(int id)
        {
            Console.WriteLine(ConsoleIO.SeparationBar);
            Contacts contact2 = contactsRepository.GetById(id);
            if (contact2 != null)
            {
                Console.WriteLine(contact2.Id + " " + contact2.FirstName + " " + contact2.LastName + " " + contact2.Company + " " + contact2.Title);
            }
        }
    }
}
