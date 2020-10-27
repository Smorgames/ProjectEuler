using System;
using System.Collections.Generic;

namespace Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600851475143L;

            Console.WriteLine(LargestPrimeFactorLong(number));
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

        private static int LargestPrimeFactorLong(long number)
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
                number = (long)(number / divider);
            }

            return primeFactors[primeFactors.Count - 1];
        }
    }
}
