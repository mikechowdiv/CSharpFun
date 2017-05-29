using System.Collections.Generic;

namespace TitleCase
{
    public class Execise
    {
        private List<string> lowerList = new List<string>
        {
            "a","the","to","at","in","with","and","but","or"
        };
        public string Case(string title)
        {
            var words = title.Split(' ');

            words[0] = Capitalize(words[0]);
            words[words.Length - 1] = Capitalize(words[words.Length - 1]);

            for(int i = 1; i < words.Length - 1; i++)
            {
                if (lowerList.Contains(words[i].ToLower()))
                    words[i] = LowerCase(words[i]);
                else
                {
                    words[i] = Capitalize(words[i]);
                }
            }
            return string.Join(" ", words);
        }

        public string Capitalize(string word)
        {
            word = LowerCase(word);
            word = char.ToUpper(word[0]) + word.Substring(1);
            return word;
        }

        public string LowerCase(string word)
        {
           return word.ToLower();
        }
    }
}
