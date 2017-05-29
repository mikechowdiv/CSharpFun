using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RotateLeft2
{
    /*
     * Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end. 
     * The string length will be at least 2. 

Rotateleft2("Hello") -> "lloHe"
Rotateleft2("java") -> "vaja"
Rotateleft2("Hi") -> "Hi"
     */

    public class Class1
    {
        public string RotateLeft2(string str)
        {
            return str.Remove(0, 2) + str.Substring(0, 2);
        }
    }

    [TestFixture]
    public class Test
    {
        private Class1 _strings = new Class1();

        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void RotateLeft2Test(string s, string expected)
        {
            var actual = _strings.RotateLeft2(s);
            Assert.AreEqual(expected, actual);
        }
    }
}
