using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.CalcTax(120000);
            e1.CalcVacation(7);

            Console.WriteLine("----------------------------------------");

            PTEmployee pt = new PTEmployee();
            pt.CalcTax(120000);
            pt.CalcVacation(7);
            pt.PrintContractDetails();
        }
    }
}
