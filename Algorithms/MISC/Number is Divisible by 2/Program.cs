using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_is_Divisible_by_2
{
    class Program
    {
        //Any whole number that ends in 0, 2, 4, 6, or 8 will be divisible by 2.
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number: ");
            n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("entered number is divisible by 2");
            }
            else
            {
                Console.WriteLine("entered number is not divisible by 2");
            }
            Console.ReadLine();
        }
    }
}
