using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            //cycle thru shapes and print the area
            foreach (Shape s in shapes)
            {
                //call the override method
                s.GetInfo();
                Console.WriteLine("{0} Area: {1:f2}", s.Name, s.Area());

                //check if an object is of a specific type
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This is not a circle");
                }

                //check the data type
                if (s is Circle)
                {
                    Console.WriteLine("This is not a rectangle");
                }

                Console.WriteLine();
            }
            //store any class as a base class and all the subclass methods even if they don't exist in the 
            //base class by casting
            object circ1 = new Circle(4);
            Circle circ2 = (Circle)circ1;

            Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
            Console.ReadLine();
        }
    }
}
