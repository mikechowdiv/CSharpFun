﻿using StudentMgtSystem.Helpers;
using StudentMgtSystem.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtSystem
{
  public  class MainMenu
    {
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Student Management System");
            Console.WriteLine(ConsoleIO.SeparatorBar);
            Console.WriteLine("1. List Students");
            Console.WriteLine("2. Add Students");
            Console.WriteLine("3. Remove Students");
            Console.WriteLine("4. Edit Students GPA");
            Console.WriteLine("");
            Console.WriteLine("Q - Quit");
            Console.WriteLine(ConsoleIO.SeparatorBar);
            Console.WriteLine("");
            Console.WriteLine("Enter choice");
        }

        private static bool ProcessChoice()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ListStudentWorkflow listWorkflow = new ListStudentWorkflow();
                    listWorkflow.Execute();
                    break;
                case "2":
                    AddStudentWorkflow addWorkflow = new AddStudentWorkflow();
                    addWorkflow.Execute();
                    break;
                case "3":
                    RemoveStudentWorkflow removeWorkflow = new RemoveStudentWorkflow();
                    removeWorkflow.Execute();
                    break;
                case "4":
                    EditStudentWorkflow editWorkflow = new EditStudentWorkflow();
                    editWorkflow.Execute();
                    break;
                case "Q":
                    return false;
                default:
                    Console.WriteLine("That is not a valid choice. Press any key to continue...");
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
