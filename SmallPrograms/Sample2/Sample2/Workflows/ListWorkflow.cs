using Sample2.Data;
using Sample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2.Workflows
{
    public class ListWorkflow
    {
        public void Exe()
        {
            EmpRepo repo = new EmpRepo();
            List<Employee> emps = repo.GetAll();

            Console.Clear();
            Console.WriteLine("Employee List");

            foreach (var items in emps)
            {
                Console.WriteLine(items.EmpId + " " + items.Name + " " + items.PhoneNumber);
            }

            Console.ReadKey();
        }
    }
}
