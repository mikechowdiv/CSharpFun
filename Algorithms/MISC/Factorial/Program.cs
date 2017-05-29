using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    //The factors of a number are all those numbers that can divide evenly into the number with no remainder.
    class Program
    {
        static void Main(string[] args)
        {
            int num, x;
            Console.WriteLine("enter the number ");

            num = int.Parse(Console.ReadLine());
            Console.WriteLine("the factors are : ");

            for(x = 1; x <= num; x++)
            {
                if(num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
