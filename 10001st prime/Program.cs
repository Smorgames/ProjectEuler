using System;
using System.Collections.Generic;

namespace _10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number = 1;

            int needPrimeFactor = Convert.ToInt32(Console.ReadLine());
            //int needPrimeFactor = 10001;

            while (counter != needPrimeFactor)
            {
                number++;

                if (IsNumberMultiple(number, 2) || IsNumberMultiple(number, 3) || IsNumberMultiple(number, 5) || IsNumberMultiple(number, 7) || IsNumberMultiple(number, 11))
                    continue;

                if ( LargestPrimeFactorInt(number) == number)
                    counter++;
            }

            Console.WriteLine($"{counter} prime number = {number}");
        }

        private static bool IsNumberPrime(int number)
        {
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0 || number % 11 == 0)
                return false;

            int primeAmount = 0;

            for (int i = 2; i <= number; i++)
            {
                if (number / (int)i == number / (decimal)i)
                    primeAmount++;
            }

            if (primeAmount == 1)
                return true;
            else
                return false;
        }

        private static bool IsFactor(long needNumber, double divider)
        {
            return needNumber / divider - needNumber / (int)divider == 0;
        }

        private static int LargestPrimeFactorInt(int number)
        {
            List<int> primeFactors = new List<int>();

            while (number > 1)
            {
                double divider = 1;
                bool isFactor = false;

                while (!isFactor)
                {
                    divider++;
                    isFactor = IsFactor(number, divider);
                }

                primeFactors.Add((int)divider);
                number = (int)(number / divider);
            }

            return primeFactors[primeFactors.Count - 1];
        }

        private static bool IsNumberMultiple(int number, int divider)
        {
            return number % divider == 0 && number != divider;
        }
    }
}
