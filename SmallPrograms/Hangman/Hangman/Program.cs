using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        //create a game similar to Hangman in which a player guesses letters to try to replicate a hidden word. 
        //store at least 8 words in an array and randomly select one to be the hidden word.
        //Initially display the hidden word using asterisks to represent each letter.
        //Allow the user to guess letters to replace the asterisks in the hidden word until the user completes the entire word.
        //if the user guesses a letter that is not in the hidden word, display an appropriate message. 
        //if the user guesses a letter that appears multiple times in the hidden word, make sure that each correct letter is placed.

        static void Main(string[] args)
        {
            //get random word stuff
            string[] words = { "jump", "programming", "river", "google", "display" };

            Random _rng = new Random();
            int randomIndex = _rng.Next(0, 5);

            string selectedWord = words[randomIndex];

            string hiddenWord = "";

            for (int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord += "*";
            }

            //guessing stuff

            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word: {0}", hiddenWord);
                Console.Write("Guess a letter >> ");
                char letter = char.Parse(Console.ReadLine());
                bool containLetter = false;

                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == letter)
                    {
                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containLetter = true;
                    }
                }

                if (containLetter == true)
                {
                    Console.WriteLine("yes {0} is in the word", letter);
                }
                else
                {
                    Console.WriteLine("sorry {0} is not in the word", letter);
                }
            }
            Console.WriteLine("you win.  The word was {0}", selectedWord);
        }
    }
}
