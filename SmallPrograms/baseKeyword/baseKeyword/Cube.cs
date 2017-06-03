using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseKeyword
{
    class Cube : square
    {
        protected int somenumber = 20;

        public override double CaleArea(int length)
        {
            double volume = base.CaleArea(length) * 6;
            Console.WriteLine("Cube volume = " + volume);
            Console.WriteLine("Cube somenumber = " + somenumber);
            Console.WriteLine("Square somenumber = " + base.somenumber);
            return volume;
        }
    }
}
