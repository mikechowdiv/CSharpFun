using NUnit.Framework;

namespace GetMiddle
{
    /*
     * Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle elements. 

GetMiddle({1, 2, 3}, {4, 5, 6}) -> {2, 5}
GetMiddle({7, 7, 7}, {3, 8, 0}) -> {7, 8}
GetMiddle({5, 2, 9}, {1, 4, 5}) -> {2, 4}
     */
    public class Class1
    {
        public int[] GetMid(int[] a, int[] b)
        {
            return new int[] { a[a.Length / 2], b[b.Length / 2] };
        }
    }


    [TestFixture]
    public class Test
    {
        private Class1 _arrays = new Class1();

        [TestCase(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 2, 5 })]
        [TestCase(new[] { 7, 7, 7 }, new[] { 3, 8, 0 }, new[] { 7, 8 })]
        [TestCase(new[] { 5, 2, 9 }, new[] { 1, 4, 5 }, new[] { 2, 4 })]
        public void GetMiddleTest(int[] a, int[] b, int[] expected)
        {
            var actual = _arrays.GetMid(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
