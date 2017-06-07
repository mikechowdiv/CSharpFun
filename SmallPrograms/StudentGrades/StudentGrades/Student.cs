namespace StudentGrades
{
    public class Student
    {
        private int[] grades;
        public Student(int [] marks)
        {
            grades = marks;
        }

        public double GetAverage()
        {
            int sum = 0;
            foreach(int gr in this.grades)
            {
                sum += gr;
            }
            return sum / grades.Length;
        }
    }
}