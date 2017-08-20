using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu MM = new MainMenu();
            MM.SelectOption();
            Console.ReadLine();
        }
    }
}
