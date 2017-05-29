using NUnit.Framework;

namespace Fix23Test
{
    /*
     * Given an int array length 3, if there is a 2 in the array immediately followed by a 3, set the 3 element to 0. Return the changed array. 

Fix23({1, 2, 3}) ->{1, 2, 0}
Fix23({2, 3, 5}) -> {2, 0, 5}
Fix23({1, 2, 1}) -> {1, 2, 1}
     */
    public class Class1
    {
        public int[] Fix23(int[] num)
        {
            for(int i = 0; i < num.Length - 1; i++)
            {
                if(num[i] == 2 && num[i + 1] == 3)
                {
                    num[i + 1] = 0;
                }
            }
            return num;
        }
    }
    
    [TestFixture]
    public class Test
    {
        private Class1 _arrays = new Class1();

        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 0 })]
        [TestCase(new[] { 2, 3, 5 }, new[] { 2, 0, 5 })]
        [TestCase(new[] { 1, 2, 1 }, new[] { 1, 2, 1 })]
        public void Fix23Test(int[] nums, int[] expected)
        {
            var actual = _arrays.Fix23(nums);
            Assert.AreEqual(expected, actual);
        }

    }
}
