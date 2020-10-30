using System;

namespace Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int topLimit = 2000000;

            int primeSum = 0;

            for (int i = 2; i < topLimit; i++)
            {
                if (IsNumberPrime(i))
                    primeSum += i;
            }

            Console.WriteLine(primeSum);
        }

        private static bool IsNumberPrime(int number)
        {
            int factorAmount = 1;
            int divider = number - 1;

            if (!FastPrimeCheck(number, 2) || !FastPrimeCheck(number, 3) || !FastPrimeCheck(number, 5) || !FastPrimeCheck(number, 7) || !FastPrimeCheck(number, 11))
                return false;

            while (factorAmount == 1 && divider != 1)
            {
                if (number / divider == number / (float)divider)
                    factorAmount++;

                divider--;
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
    }
}
