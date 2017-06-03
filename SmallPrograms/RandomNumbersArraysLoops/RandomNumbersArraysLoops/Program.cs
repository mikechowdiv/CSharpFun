using System;

namespace RandomNumbersArraysLoops
{
    class Program
    {
        public static int[] positiveNumbers;
        public static int[] negativeNumbers;
        public static int N = 0;
        static void Main(string[] args)
        {
            Console.Write("Please enter how many numbers are to be calculated: ");
            N = Convert.ToInt32(Console.ReadLine());

            positiveNumbers = new int[N];
            negativeNumbers = new int[N];

            //populate arrays with zeros
            PopulateWithZero();
            PopulateWithRandomNumbers();
            OutputPositive();
            OutputNegative();
            OutputSum();

        }

        private static void OutputSum()
        {
            Console.Write("Position sum of numbers: ");
            for(int i = 0; i < N; i++)
            {
                if(positiveNumbers[i] != 0 || negativeNumbers[i] != 0)
                {
                    Console.Write(positiveNumbers[i] + negativeNumbers[i] + ", ");
                }
            }
            Console.WriteLine("");
        }

        private static void OutputNegative()
        {
            Console.Write("Positive Numbers ({0} of them): ", N);
            foreach (var items in negativeNumbers)
                Console.Write(items + ", ");

            Console.WriteLine("");
        }

        private static void OutputPositive()
        {
            Console.Write("Positive Numbers ({0} of them): ", N);
            foreach (var items in positiveNumbers)
                Console.Write(items + ", ");

            Console.WriteLine("");
        }

        private static void PopulateWithRandomNumbers()
        {
            Random rng = new Random();
            int randomNum = 0;
            bool positiveNum = false;
            for(int i = 0; i < N; i++)
            {
                bool randomNotZero = false;
                while (!randomNotZero) // if random number is zero, get another number
                {
                    randomNum = rng.Next(-100, 101);
                    if (randomNum != 0)
                        randomNotZero = true;
                }
                positiveNum = (randomNum > 0) ? true : false;
                AddNumToArray(randomNum, positiveNum);
            }
        }

        private static void AddNumToArray(int numberToAdd, bool positiveNum)
        {
            for(int i = 0; i < N; i++)
            {
                if (positiveNum)
                {
                    if(positiveNumbers[i] == 0)
                    {
                        positiveNumbers[i] = numberToAdd;
                        return;
                    }
                }
                else
                {
                    if(negativeNumbers[i] == 0)
                    {
                        negativeNumbers[i] = numberToAdd;
                        return;
                    }
                }
            }
        }

        private static void PopulateWithZero()
        {
            for(int i = 0; i < N; i++)
            {
                positiveNumbers[i] = 0;
                negativeNumbers[i] = 0;
            }
        }
    }
}
