using System;
using System.Collections.Generic;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter grade: ");
            List<int> values = new List<int>();
            string s;
            int mark;

            while (true)
            {
                s = Console.ReadLine();
                if(int.TryParse(s, out mark))
                {
                    values.Add(mark);
                }
                else if(s == "Q")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Student st = new Student(values.ToArray());
            Console.WriteLine("the average grade is: " + st.GetAverage());
        }
    }
}
