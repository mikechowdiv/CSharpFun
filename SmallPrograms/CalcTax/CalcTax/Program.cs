using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTax
{
    //calculate the tax to be paid by a person earning $45000
    //10%   salary <= 8350
    //15%   8350 < salary <= 33950
    //25%   salary > 33950

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter salary: ");
            string input = Console.ReadLine();

            double salary = Convert.ToDouble(input);

            double tax;
            if (salary <= 8350)
                tax = 8350 * .1;
            else if (salary <= 33950)
                tax = (8350 * .1) + ((salary - 8350) * .15);
            else
                tax = (8350 * .1) + ((33950 - 8350) * .15) + ((salary - 33950) * .25);
            Console.WriteLine("Tax = " + tax);
        }
    }
}
