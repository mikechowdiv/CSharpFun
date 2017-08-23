using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflows;

namespace DapperCRUD2
{
    public class MainMenu
    {
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(ConsoleIO.SeparationBar);
            Console.WriteLine("1.  List Contacts");
            Console.WriteLine("2.  Add Contacts");
            Console.WriteLine("3.  Update Contacts");
            Console.WriteLine("4.  Delete Contacts");
            Console.WriteLine("");
            Console.WriteLine(ConsoleIO.SeparationBar);
            Console.WriteLine("Enter Choice: ");
        }

        private static bool ProcessChoice()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ListWorkflow listwf = new ListWorkflow();
                    listwf.Exe();
                    break;

                case "2":
                    AddWorkflow addwf = new AddWorkflow();
                    addwf.Exe();
                    break;

                case "3":
                    UpdateWorkflow UWF = new UpdateWorkflow();
                    UWF.Exe();
                    break;

                case "4":
                    DeleteWorkflow DWF = new DeleteWorkflow();
                    DWF.Exe();
                    break;

                default:
                    Console.WriteLine("This is not a valid choice. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
            return true;
        }
        
        public static void Show()
        {
            bool keepRun = true;
            while (keepRun)
            {
                DisplayMenu();
                keepRun = ProcessChoice();
            }
        }

    }
}
