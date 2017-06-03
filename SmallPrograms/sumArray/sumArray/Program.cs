using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumArray
{
    /*
     * Given an array of string
     * string[] str = {"3.45", "3.87", "87.98", "56.7"};
     * compute the sum of these numbers
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "3.45", "3.87", "87.98", "56.7" };
            double total = 0;

            foreach(string items in str)
            {
                total = total + Convert.ToDouble(items);
            }
            Console.WriteLine("Total = " + total);

        }
    }
}
