using Sample2.Data;
using Sample2.Models;
using Sample2.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    public class MainMenu
    {
        public static IRepo EmployeeRepo = new EmpRepo();    

        public void SelectOption()
        {
            Console.WriteLine(new string('*', 20));
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("For...");
            Console.WriteLine("Show Data Select 1");
            Console.WriteLine("Insert Data Select 2");
            Console.WriteLine("Update Data Select 3");
            Console.WriteLine("Delete Data Select 4");
            Console.WriteLine();
            Console.Write("Your Selection :  ");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    ListWorkflow listwf = new ListWorkflow();
                    listwf.Exe();
                    break;
                case 2:
                    AddWorkflow Addwf = new AddWorkflow();
                    Addwf.Exe();
                    break;
                case 3:
                    UpdateWorkflow UpdateWF = new UpdateWorkflow();
                    UpdateWF.Exe();
                    break;
                default:
                    break;
            }
            
        }

      
    }
}
