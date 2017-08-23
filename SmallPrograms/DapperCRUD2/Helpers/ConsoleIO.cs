using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class ConsoleIO
    {
        public const string SeparationBar = "------------------------------------------------------------";

        public static string GetRequiredStringFromUser(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must enter valid text...");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else
                {
                    return input;
                }
            }
        }

        public static string GetYesNoFromUser(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt + "(Y/N)");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must enter Y/N");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else
                {
                    if (input != "Y" && input != "N")
                    {
                        Console.WriteLine("You must enter Y/N");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }
                    return input;
                }
            }
        }
    }
}
