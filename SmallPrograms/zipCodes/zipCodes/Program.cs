using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zipCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program for a package delivery service. The program contains an array that holds the ten zip codes to
            //which the company delivers packages.  
            //Prompt a user to enter a zip code and display a message indicating whether the zip code is one to which the company delivers.

            string[] zipCodes = { "10001", "10002", "10003", "10004", "10005" };

            Console.WriteLine("Enter the zip code ");
            string code = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < zipCodes.Length; i++)
            {
                if (code == zipCodes[i])
                {
                    found = true;
                    break;
                }
            }

            if (found == true)
            {
                Console.WriteLine("We can ship to your location.");
            }
            else
            {
                Console.WriteLine("Sorry we cannot ship to your location");
            }
        }
    }
}
