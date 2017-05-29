using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPrime
{
    class Program
    {
        public static bool checkPrime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {

            Console.Write("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (checkPrime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");
        }
    }
}
