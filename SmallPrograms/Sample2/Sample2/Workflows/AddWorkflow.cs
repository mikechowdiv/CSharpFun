using Sample2.Data;
using Sample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2.Workflows
{
    public class AddWorkflow
    {
        public static IRepo empRepository = new EmpRepo();

        public void Exe()
        {
            Console.Clear();
            Console.WriteLine("Add Employee");
            Console.WriteLine("");

            Console.Write("Name");
            string nameInput = Console.ReadLine();
            Console.Write("Phone");
            string phoneInput = Console.ReadLine();

            Employee emp1 = new Employee
            {
                Name = nameInput,
                PhoneNumber = phoneInput
            };

            empRepository.Add(emp1);

            ListWorkflow LWF = new ListWorkflow();
            LWF.Exe();
        }
    }
}
