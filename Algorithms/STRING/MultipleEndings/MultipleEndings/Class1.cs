using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MultipleEndings
{
    /*
     * Given a string, return a new string made of 3 copies of the last 2 chars of the original string. 
     * The string length will be at least 2. 

MultipleEndings("Hello") -> "lololo"
MultipleEndings("ab") -> "ababab"
MultipleEndings("Hi") -> "HiHiHi"
     */
    public class Class1
    {
        public string MultipleEndings(string str)
        {
            string lastTwo = str.Substring(str.Length - 2);
            return lastTwo + lastTwo + lastTwo;
        }
    }
    [TestFixture]
    public class Test
    {
        private Class1 _strings = new Class1();

        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void MultipleEndingsTest(string s, string expected)
        {
            var actual = _strings.MultipleEndings(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
