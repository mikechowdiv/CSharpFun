using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageGrade
{
    //write a program that allows a teacher to enter in an amount of students.For each student ask the teacher to enter
        // in their name and final score for the class.
        // When the teacher is done entering the data, print the highest grade in the class and the average grade in the class.
    class Program
    {
        static void Main(string[] args)
        {
            //get the numbers of students
            Console.WriteLine("enter the number of students in your class: ");
            int amountOfStudents = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";

            //keep track of their names and grades in arrays
            string[] studentNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents];

            //check the highest and average grades
            for (int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine("enter student # {0}'s name: ", i + 1);
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("enter student # {0}'s grade ", i + 1);
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;

                averageGrade += grade;
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                    highestGradeName = studentNames[i];
                }
            }

            averageGrade /= amountOfStudents;
            Console.WriteLine("the average grade of the class is {0}", averageGrade);
            Console.WriteLine("the highest grade of the class is {0} by {1}", highestGrade, highestGradeName);
        }
    }
}
