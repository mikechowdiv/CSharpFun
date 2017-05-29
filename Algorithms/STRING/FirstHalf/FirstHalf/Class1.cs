using NUnit.Framework;

namespace FirstHalf
{
    /*
     * Given a string of even length, return the first half. So the string "WooHoo" yields "Woo". 

FirstHalf("WooHoo") -> "Woo"
FirstHalf("HelloThere") -> "Hello"
FirstHalf("abcdef") -> "abc"
     */
    public class Class1
    {
        public string FirstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }
    }

    [TestFixture]
    public class Test
    {
        private Class1 _strings = new Class1();

        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void FirstHalfTest(string s, string expected)
        {
            var actual = _strings.FirstHalf(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
