namespace Sum
{
    /*
     * Given an array of ints, return the sum of all the elements. 

Sum({1, 2, 3}) -> 6
Sum({5, 11, 2}) -> 18
Sum({7, 0, 0}) -> 7
     */
    public class Class1
    {
        public int Sum(int[] num)
        {
            int result = 0;
            for(int i = 0; i < num.Length; i++)
            {
                result += num[i];
            }
            return result;
        }
    }
}
