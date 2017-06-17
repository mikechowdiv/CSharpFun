using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintStudents(StudentRepository.SelectAll());
            //MethodSyntax1();
            //MethodSyntax2();
            //MethodSyntax3();
            MethodSyntax4();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void MethodSyntax1()
        {
            var student1 = StudentRepository.SelectAll();
            decimal average = student1.Average(s => s.GPA);

            //Scalar methods
            Console.WriteLine("The average GPA is: {0}", average);
            Console.WriteLine("The max GPA is: {0}", student1.Max(s => s.GPA));
        }

        static void MethodSyntax2()
        {
            var honorRoll = StudentRepository.SelectAll().Where(s => s.GPA > 3.5M);
            PrintStudents(honorRoll);
        }

        static void MethodSyntax3()
        {
            var orderByGPA = StudentRepository.SelectAll().OrderByDescending(s => s.GPA > 3.5M);
            PrintStudents(orderByGPA);
        }

        static void MethodSyntax4()
        {
            var orderByGPATop3 = StudentRepository.SelectAll().OrderByDescending(s => s.GPA).Take(3);
            PrintStudents(orderByGPATop3);
        }



        static void PrintStudents(IEnumerable<Student> students)
        {
            string headingFormat = "{0, -15} {1, -15} {2, -18} {3,4}";
            string lineFormat = "{0, -15} {1, -15} {2, -18} {3,4}";

            Console.WriteLine(headingFormat, "Last Name", "First Name", "Major", "GPA");
            Console.WriteLine("----------------------------------------------------------");

            foreach (var items in students)
            {
                Console.WriteLine(lineFormat, items.LastName, items.FirstName, items.Major, items.GPA);
            }
            Console.WriteLine("");
        }
    }
}
