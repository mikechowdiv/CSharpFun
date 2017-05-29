﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLast6
{
    public class Class1
    {
        /*
         Given an array of ints, return true if 6 appears as either the first or last element in the array. The array will be length 1 or more. 
FirstLast6({1, 2, 6}) -> true
FirstLast6({6, 1, 2, 3}) -> true
FirstLast6({13, 6, 1, 2, 3}) -> false
         */

        public bool FirstLast6(int[] num)
        {
            return num[0] == 6 || num[num.Length - 1] == 6;
        }
    }
}
