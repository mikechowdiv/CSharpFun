using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str; 
            string RevStr = "";
            Console.Write("enter a string : ");
            Str = Console.ReadLine();

            for (int i = Str.Length - 1; i >= 0; i--)
            {
                RevStr = RevStr + Str[i];
            }

            Console.WriteLine("Reverse string is {0}", RevStr);
            Console.ReadLine();
        }        
    }
}
