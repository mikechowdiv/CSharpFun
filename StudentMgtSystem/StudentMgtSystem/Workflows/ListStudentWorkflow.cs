using StudentMgtSystem.Data;
using StudentMgtSystem.Helpers;
using StudentMgtSystem.Models;
using System;
using System.Collections.Generic;

namespace StudentMgtSystem.Workflows
{
    public class ListStudentWorkflow
    {
        public void Execute()
        {
            //1. get a list of students from the repo. 2. print out the students.
            StudentRepo repo = new StudentRepo(Settings.FilePath);
            List<Student> students = repo.List();

            Console.Clear();
            Console.WriteLine("Student List");
            Console.WriteLine(ConsoleIO.SeparatorBar);

            string line = "{0,-20} {1,-15} {2,5}";
            Console.WriteLine(line, "Name", "Major", "GPA");
            Console.WriteLine(ConsoleIO.SeparatorBar);

            foreach(var items in students)
            {
                Console.WriteLine(line, items.LastName + ", " + items.FirstName, items.Major, items.GPA);
            }

            Console.WriteLine();
            Console.WriteLine(ConsoleIO.SeparatorBar);
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
