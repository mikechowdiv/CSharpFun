using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Alex", 6);
            Employee e2 = new Employee("Lyan", 7);
            Employee e3 = new Employee("John", 3);
            Employee e4 = new Employee("Sara", 7);
            Employee e5 = new Employee("James", 4);

            Department d1 = new Department("Sales");
            d1.AddEmployee(e1);
            d1.AddEmployee(e2);
            d1.AddEmployee(e3);
            d1.describe();

            Console.WriteLine("-----------------------------------------");

            Department d2 = new Department("IT");
            d2.AddEmployee(e4);
            d2.AddEmployee(e5);
            d2.describe();
        }
    }
}
