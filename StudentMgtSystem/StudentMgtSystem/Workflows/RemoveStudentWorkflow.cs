using StudentMgtSystem.Data;
using StudentMgtSystem.Helpers;
using StudentMgtSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtSystem.Workflows
{
   public class RemoveStudentWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Remove Student");
            

            StudentRepo repo = new StudentRepo(Settings.FilePath);
            List<Student> students = repo.List();

            ConsoleIO.PrintPickList(students);
            Console.WriteLine();

            int index = ConsoleIO.GetStudentIndexFromUser("Which student you like to delete?", students.Count());
            index--;

            string answer = ConsoleIO.GetYesNoFromUser($"Please confirm to remove {students[index].FirstName} {students[index].LastName}");
            if(answer == "Y")
            {
                repo.Delete(index);
                Console.WriteLine("Student removed");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Remove Cancelled");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
