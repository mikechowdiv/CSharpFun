using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1: write the for loop which runs 100 times
            for(int j = 1; j < 100; j++)
            {
                //declare a simple string variable which will hold the status 
                string Output = "";

                //if it's "Fizz" then it shuold be divisble by 3
                if (j % 3 == 0) Output = "Fizz";

                //if it's "Buzz" it should be divible by 5          
                if (j % 5 == 0) Output += "Buzz";

                if (Output == "") Output = j.ToString();

                Console.WriteLine(Output);
            }
        }
    }
}
