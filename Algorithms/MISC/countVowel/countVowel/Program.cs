using System;

namespace countVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            string str;
            Console.WriteLine("enter a string: ");
            str = Console.ReadLine();
            total = CountVowel(str);

            Console.WriteLine("Total vowwl: {0} ", total);
            Console.ReadLine();
        }

        private static int CountVowel(string str)
        {
            int count = 0;
            for(int i = 0; i < str.Length - 1; i++)
            {
                switch (str[i])
                {
                    case 'A':
                        count++;
                        break;
                    case 'a':
                        count++;
                        break;
                    case 'E':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'I':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'O':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'U':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
