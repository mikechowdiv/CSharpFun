using NUnit.Framework;

namespace InsertWord
{
    /*
     * Given an "out" string length 4, such as "<<>>", and a word, return a new string where the word is in the middle of the out string, e.g. "<<word>>".

Hint: Substrings are your friend here 

InsertWord("<<>>", "Yay") -> "<<Yay>>"
InsertWord("<<>>", "WooHoo") -> "<<WooHoo>>"
InsertWord("[[]]", "word") -> "[[word]]"
     */
    public class Class1
    {
        public string InsertWord(string container, string word)
        {
            int mid = container.Length / 2;

            return container.Substring(0, mid) + word + container.Substring(mid);
        }
    }

    [TestFixture]
    public class Test
    {
        private Class1 _strings = new Class1();

        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWordTest(string container, string word, string expected)
        {
            var actual = _strings.InsertWord(container, word);
            Assert.AreEqual(expected, actual);
        }
    }
}
