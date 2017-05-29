using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    public class Class1
    {
        //Given an array of ints length 3, return a new array with the elements in reverse order, so for example {1, 2, 3} becomes {3, 2, 1}. 
        public int[] Reverse(int[] num)
        {
            int[] result = new int[num.Length];
            for(int i = 0; i < num.Length; i++)
            {
                result[result.Length - i - 1] = num[i];
            }
            return result;
        }
    }
}
