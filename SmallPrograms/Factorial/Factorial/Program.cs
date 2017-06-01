using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    /*
     * The factorial of a non-negative integer n is written as n! and is defined as follows:
n! = n * (n – 1) * (n – 2) *… * 1 (for values of n greater than or equal to 1)
and n! = 1 (for n = 0)

For example, 5! = 5 * 4 * 3 * 2 * 1, which is 120. Write an app that reads a nonnegative integer and computes and displays its factorial.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, factorial = 0, counter = 0;

            Console.WriteLine("Please enter a positive integerL ");

            number = Convert.ToInt32(Console.ReadLine());

            factorial = number;
            counter = number - 1;

            while(counter > 0)
            {
                factorial *= counter;
                counter--;
            }

            Console.WriteLine("Factorial of {0:N0} is {1:N0}", number, factorial);
            Console.ReadLine();

        }
    }
}
