namespace SameFirstLast
{
    /*
     Given an array of ints, return true if the array is length 1 or more, and the first element and the last element are equal. 

SameFirstLast({1, 2, 3}) -> false
SameFirstLast({1, 2, 3, 1}) -> true
SameFirstLast({1, 2, 1}) -> true
     */
    public class Class1
    {
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length > 1 && numbers[0] == numbers[numbers.Length - 1]) return true;
            return false;
        }
    }
}
