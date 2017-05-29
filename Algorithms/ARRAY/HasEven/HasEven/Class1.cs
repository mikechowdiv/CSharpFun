using NUnit.Framework;

namespace HasEven
{
    public class Class1
    {
        /*
         * Given an int array , return true if it contains an even number (HINT: Use Mod (%)). 

HasEven({2, 5}) -> true
HasEven({4, 3}) -> true
HasEven({7, 5}) -> false
         */
         public bool HasEven(int[] num)
        {
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0) return true;
            }
            return false;
        }
    }

    [TestFixture]
    public class Test
    {
        private Class1 _arrays = new Class1();

        [TestCase(new[] { 2, 5 }, true)]
        [TestCase(new[] { 4, 3 }, true)]
        [TestCase(new[] { 7, 5 }, false)]
        public void HasEvenTest(int[] nums, bool expected)
        {
            var actual = _arrays.HasEven(nums);
            Assert.AreEqual(expected, actual);
        }

    }
}
