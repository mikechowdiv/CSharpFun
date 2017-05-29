using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MakeTags
{
    /*
     * The web is built with HTML strings like "<i>Yay</i>" which draws Yay as italic text. 
     * In this example, the "i" tag makes <i> and </i> which surround the word "Yay". Given tag and word strings, 
     * create the HTML string with tags around the word, e.g. "<i>Yay</i>". 

MakeTags("i", "Yay") -> "<i>Yay</i>"
MakeTags("i", "Hello") -> "<i>Hello</i>"
MakeTags("cite", "Yay") -> "<cite>Yay</cite>"
     */
    public class Class1
    {
        public string MakeTags(string tag, string content)
        {
            return $"<{tag}>{content}</{tag}>";
        }
    }
    [TestFixture]
    public class Test
    {
        private Class1 _strings = new Class1();

        [TestCase("i", "Yay", "<i>Yay</i>")]
        [TestCase("i", "Hello", "<i>Hello</i>")]
        [TestCase("cite", "Yay", "<cite>Yay</cite>")]
        public void MakeTagsTest(string tag, string content, string expected)
        {
            var actual = _strings.MakeTags(tag, content);
            Assert.AreEqual(expected, actual);
        }
    }
}
