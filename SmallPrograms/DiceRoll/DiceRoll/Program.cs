using System;

namespace DiceRoll
{
    /*
     * Write an app to simulate the rolling of two dice. The app should use an object of class Random 
once to roll the first die and again to roll the second die. 

        The sum of the two values should then be calculated. 
Each die can show an integer value from 1 to 6, so the sum of the values will vary from 2 to 12, with 7 being the most 
frequent sum and 2 and 12 the least frequent sums. 

        Your app should roll the dice 36,000 times. Use a one-dimensional 
array to tally the number of times each possible sum appears. Display the results in tabular format. Determine whether 
the totals are reasonable (e.g.,there are six ways to roll a 7, so approximately one-sixth of the rolls should be 7).
     */

    class Program
    {
        static void Main(string[] args)
        {
            int[] sums = new int[13];
            int sum = 0;
            int die1 = 0;
            int die2 = 0;
            int[,] dieValues = new int[7, 7];

            Random rng = new Random();

            for(int i = 0; i < 36000; i++)
            {
                die1 = rng.Next(1, 7);
                die2 = rng.Next(1, 7);

                sum = die1 + die2;
                sums[sum] += 1;
                dieValues[die1, die2] += 1;
            }

            

            Console.WriteLine("    2     3     4      5      6      7      8      9      10     11     12");

            for(int i = 2; i <= 12; i++)
            {
                Console.Write("   {0:D4}", sums[i]);

            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("       1          2        3         4         5         6 ");
            Console.WriteLine("-------------------------------------------------------------------");

            for(int r = 1; r <= 6; r++)
            {
                Console.Write("   {0:N0}  |", r);
                for(int c = 1; c <= 6; c++)
                {
                    Console.Write("     {0:D4}", dieValues[r, c]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
