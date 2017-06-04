using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass1
{
   abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        //a subclass to override this method so mark it as abstract. You can only make abstract methods in abstract classes
        public abstract double Area();
    }
}
