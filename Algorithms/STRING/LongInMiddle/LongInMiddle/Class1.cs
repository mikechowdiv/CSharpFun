using NUnit.Framework;

namespace LongInMiddle
{
    /*
     * Given 2 strings, a and b, return a string of the form short+long+short, 
     * with the shorter string on the outside and the longer string on the inside. 
     * The strings will not be the same length, but they may be empty (length 0). 

LongInMiddle("Hello", "hi") -> "hiHellohi"
LongInMiddle("hi", "Hello") -> "hiHellohi"
LongInMiddle("aaa", "b") -> "baaab"
     */

    public class Class1
    {
        public string LongInMiddle(string a, string b)
        {
            if(a.Length > b.Length)
            {
                return b + a + b;
            }
            else
            {
                return a + b + a;
            }
        }
    }

    [TestFixture]
    public class Test
    {
        private Class1 _strings = new Class1();

        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void LongInMiddleTest(string s1, string s2, string expected)
        {
            var actual = _strings.LongInMiddle(s1, s2);
            Assert.AreEqual(expected, actual);
        }
    }
}
