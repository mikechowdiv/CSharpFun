using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseKeyword
{
    class square
    {
        protected int somenumber = 10;
        public virtual double CaleArea(int length)
        {
            Console.WriteLine("Square area = " + (length * length));
            return (length * length);
        }
    }
}
