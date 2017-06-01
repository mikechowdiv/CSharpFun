using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestValue
{
    //Write an app that finds the smalles of several integers. Assume that the first value read specifies the number of values to input from the user.

    class Program
    {
        static void Main(string[] args)
        {
            
            int index = 0;
            int smallest = 0;
            int value = 0;

            Console.WriteLine("How many numbers will you enter?");
            index = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= index; i++)
            {
                Console.WriteLine("Please enter an integer: ");
                value = Convert.ToInt32(Console.ReadLine());

                if (i == 1) smallest = value;
                else
                {
                    if (value < smallest) smallest = value;
                } 
            }
            Console.WriteLine("The smallest number you entered was {0}", smallest);
            Console.ReadLine();
        }
    }
}
