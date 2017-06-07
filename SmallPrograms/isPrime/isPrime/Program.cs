using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(input));
        }

        private static bool isPrime(int input)
        {
            for(int i = 2; i < input; i++)
            {
                if(input % i == 0)
                {
                    return false;
                }
            }return true;
        }
    }
}
