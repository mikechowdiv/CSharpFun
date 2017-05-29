using System;

namespace HigherWins
{
    /*
     * Given an array of ints, figure out which is larger between the first and last elements in the array, 
     * and set all the other elements to be that value. Return the changed array. 

HigherWins({1, 2, 3}) -> {3, 3, 3}
HigherWins({11, 5, 9}) -> {11, 11, 11}
HigherWins({2, 11, 3}) -> {3, 3, 3}
     */
    public class Class1
    {
        public int[] HighWins(int[] num)
        {
            int max = Math.Max(num[0], num[num.Length - 1]);
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = max;
            }
            return num;
        }
    }
}
