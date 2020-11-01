using System;

namespace Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int topLimit = 2000000;

            //ShittyAlgorithmForPrimeSum(topLimit);

            SieveOfEratosthenes(topLimit);
        }

        private static bool IsNumberPrime(int number)
        {
            int factorAmount = 1;
            int divider = 2;

            if (!FastPrimeCheck(number, 2) || !FastPrimeCheck(number, 3) || !FastPrimeCheck(number, 5) || !FastPrimeCheck(number, 7) || !FastPrimeCheck(number, 11))
                return false;

            if (number == 2 || number == 3)
                return true;

            while (factorAmount == 1 && divider != number / 2)
            {
                if (number / divider == number / (float)divider)
                    factorAmount++;

                divider++;
            }

            if (factorAmount == 1)
                return true;
            else
                return false;
        }

        private static bool FastPrimeCheck(int number, int divider)
        {
            if (number % divider == 0 && number != divider)
                return false;
            else
                return true;
        }     

        private static void ShittyAlgorithmForPrimeSum(int topLimit)
        {
            ulong primeSum = 0;

            int primeCounter = 0;

            for (int i = 2; i < topLimit; i++)
            {
                if (IsNumberPrime(i))
                {
                    primeSum += (ulong)i;
                    primeCounter++;
                }
            }

            DisplayPrimeAmountAndPrimeSum(topLimit, primeCounter, primeSum);
        }

        private static void SieveOfEratosthenes(int topLimit)
        {
            int[] numbers = new int[topLimit - 1];
            int prime = 2;
            ulong primeSum = 0;
            int primeCounter = 0;

            for (int j = 0; j < numbers.Length; j++)
                numbers[j] = j + 2;

            while ((int)MathF.Pow(prime, 2) < topLimit)
            {
                int primeIndex = GetIndex(numbers, prime);

                for (int i = primeIndex + prime * (prime - 1); i < numbers.Length; i++)
                    if (numbers[i] % prime == 0)
                        numbers[i] = 0;

                int interprime = prime;
                int counter = GetIndex(numbers, prime) + 1;

                while (prime == interprime)
                {
                    if (numbers[counter] == 0)
                    {
                        counter++;
                        continue;
                    }

                    prime = numbers[counter];
                    break;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] != 0)
                {
                    primeCounter++;
                    primeSum += (ulong)numbers[i];
                }


            DisplayPrimeAmountAndPrimeSum(topLimit, primeCounter, primeSum, ConsoleColor.Red);
        }

        private static void DisplayPrimeAmountAndPrimeSum(int topLimit, int primeCounter, ulong primeSum)
        {
            Console.WriteLine($"Amount of primes less than {topLimit} = {primeCounter}");

            Console.WriteLine(primeSum);
        }

        private static void DisplayPrimeAmountAndPrimeSum(int topLimit, int primeCounter, ulong primeSum, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            DisplayPrimeAmountAndPrimeSum(topLimit, primeCounter, primeSum);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static int GetIndex(int[] numbers, int value)
        {
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == value)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private static void ColorMessege(string messege, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(messege);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}