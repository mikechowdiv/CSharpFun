using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateLeft
{
    public class Class1
    {
        /*
         * Given an array of ints, return an array with the elements "rotated left" so {1, 2, 3} yields {2, 3, 1}. 

RotateLeft({1, 2, 3}) -> {2, 3, 1}
RotateLeft({5, 11, 9}) -> {11, 9, 5}
RotateLeft({7, 0, 0}) -> {0, 0, 7}

         */
        public int[] RotateLeft(int[] num)
        {
            int[] result = new int[num.Length];
            result[result.Length - 1] = num[0];
            for(int i = 0; i < num.Length - 1; i++)
            {
                result[i] = num[i + 1];
            }
            return result;
        }
    }
}
