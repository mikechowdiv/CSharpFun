using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtSystem.Helpers
{
   public class ConsoleIO
    {
        public const string SeparatorBar = "-------------------------------------------------------------------";

        public const string StudentLineFormat = "{0,-20} {1,-15} {2,5}";

        public static void PrintHeader()
        {
            Console.WriteLine(SeparatorBar);
        
            Console.WriteLine(StudentLineFormat, "Name", "Major", "GPA");
            Console.WriteLine(SeparatorBar);
        }



        //when two code blocks are the same except for a few pieces of data, we can move the code block to a method
        //with parameters and not repeat ourselves.
        public static string GetRequiredStringFromUser(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must enter valid text");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    return input;
                }
            }
        }

        public static decimal GetRequiredDecimalFromUser(string prompt)
        {
            decimal output;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (!decimal.TryParse(input, out output))
                {
                    Console.WriteLine("You must enter a valid decimal");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    if(output < 0 || output > 4)
                    {
                        Console.WriteLine("GPA must be between 0 and 4");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }

                    return output;
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
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    if(input != "Y" && input != "N")
                    {
                        Console.WriteLine("You must enter Y/N");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    return input;
                }
            }
        }
    }
}
