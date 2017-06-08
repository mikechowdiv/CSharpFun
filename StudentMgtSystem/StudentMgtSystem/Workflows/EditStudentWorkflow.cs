using StudentMgtSystem.Data;
using StudentMgtSystem.Helpers;
using StudentMgtSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentMgtSystem.Workflows
{
    public class EditStudentWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Edit Student GPA");

            StudentRepo repo = new StudentRepo(Settings.FilePath);
            List<Student> students = repo.List();

            ConsoleIO.PrintPickList(students);
            Console.WriteLine();

            int index = ConsoleIO.GetStudentIndexFromUser("Which student you like to edit?", students.Count());
            index--;

            Console.WriteLine();
            
            //string.Format() allows for substitution strings just like Console.WriteLine(), but for variables and method parameters
            students[index].GPA = ConsoleIO.GetRequiredDecimalFromUser
                (string.Format("Enter the new GPA for {0} {1}", students[index].FirstName, students[index].LastName));

            repo.Edit(students[index], index);
            Console.WriteLine("GPA updated");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
