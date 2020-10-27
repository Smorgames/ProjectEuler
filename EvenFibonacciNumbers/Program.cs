using System;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLimit = 4000000;

            int firstFibonacciNumber = 1;
            int secondFibonacciNumber = 2;
            int nextFibonacciNumber = 0;
            int interNumber = 0;

            int predictNextFibonacciNumber = 0;

            int summ = 0;
            summ += secondFibonacciNumber;

            while (predictNextFibonacciNumber < maxLimit)
            {
                nextFibonacciNumber = firstFibonacciNumber + secondFibonacciNumber;
                firstFibonacciNumber = secondFibonacciNumber;

                interNumber = secondFibonacciNumber;

                secondFibonacciNumber = nextFibonacciNumber;

                if (nextFibonacciNumber % 2 == 0)
                    summ += nextFibonacciNumber;

                predictNextFibonacciNumber = nextFibonacciNumber + interNumber;
            }

            Console.WriteLine($"Sum of even Fibonacci numbers less than {maxLimit} = {summ}");
        }

        public static void DisplayPredictFibonacciNumber(int PredictNextFibonacciNumber)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(PredictNextFibonacciNumber.ToString());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
