using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExecise
{
    class Program
    {
        static void Main(string[] args)
        {
            //collect a list of numbers
            string input;
            int output;

            List<int> numbers = new List<int>();

            do
            {
                Console.WriteLine("enter a number (Q to quit): ");
                input = Console.ReadLine();

                if(int.TryParse(input, out output))
                {
                    numbers.Add(output);
                }

            } while (input != "Q");

            Console.WriteLine("The numbers entered were: {0}", string.Join(",", numbers));

            int sum = 0;
            for(int i = 0; i < numbers.Count; i++) //in a list instead of using Lenght we use Count
            {
                sum += numbers[i];

            }

            Console.WriteLine("The sum of the numbers entered is : {0}", sum);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
