using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridingExample
{
    class Employee
    {
        public void CalcTax(double pay)
        {
            if (pay > 100000) Console.WriteLine("Tax = " + (pay * .3));
            else Console.WriteLine("Tax = " + (pay * .2));
        }

        public virtual void CalcVacation(int grade)
        {
            if (grade > 5) Console.WriteLine("Vacation days = " + 10);
            else Console.WriteLine("Vacation days = " + 7);
        }
    }
}
