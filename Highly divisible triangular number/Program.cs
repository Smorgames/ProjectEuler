using System;
using System.Collections.Generic;

namespace Highly_divisible_triangular_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangularNumber = 1;

            while (AmountOfNumberFactors(GetTriangularNumber(triangularNumber)) < 60)
            {
                Console.WriteLine($"{GetTriangularNumber(triangularNumber)} has {AmountOfNumberFactors(GetTriangularNumber(triangularNumber))} factors");
                triangularNumber++;
            }

            Console.WriteLine(GetTriangularNumber(triangularNumber));
        }

        private static int GetTriangularNumber(int triangularLimit)
        {
            int triangularNumber = 0;

            for (int i = 1; i <= triangularLimit; i++)
                triangularNumber += i;

            return triangularNumber;
        }

        private static int AmountOfNumberFactors(int number)
        {
            List<int> factors = new List<int>();

            int factor = 1;
            int mirrorFactor = number;

            while (factor <= mirrorFactor)
            {
                if (IsNumberMultiples(number, factor))
                {
                    mirrorFactor = number / factor;
                    factors.Add(factor);
                    factors.Add(mirrorFactor);
                }

                factor++;
            }

            return factors.Count - 2;
        }

        private static bool IsNumberMultiples(int number, int divider)
        {
            if (number / divider == number / (float)divider)
                return true;
            else
                return false;
        }
    }
}
