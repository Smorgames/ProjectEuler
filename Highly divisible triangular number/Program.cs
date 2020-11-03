using System;

namespace Highly_divisible_triangular_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 1;
            int amountOfDividers = 500;

            while (GetFactorsAmount(TriangularNumber(limit)) < amountOfDividers)
            {
                DisplayNumberAndFactorsAmount(limit, TriangularNumber(limit), GetFactorsAmount(TriangularNumber(limit)));
                limit++;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            DisplayNumberAndFactorsAmount(limit, TriangularNumber(limit), GetFactorsAmount(TriangularNumber(limit)));
            //Console.WriteLine(TriangularNumber(7918)); //31 351 320
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static int TriangularNumber(int triangularLimit)
        {
            return triangularLimit * (triangularLimit + 1) / 2;
        }

        private static bool IsNumberMultiples(int number, decimal divider)
        {
            if (number / (int)divider == number / divider)
                return true;
            else
                return false;
        }

        private static int GetFactorsAmount(int number)
        {
            int factor = 1;
            int mirrorFactor = number;

            int factorsAmount = 0;

            while (factor <= mirrorFactor)
            {
                if (IsNumberMultiples(number, factor))
                {
                    mirrorFactor = number / factor;
                    //Console.WriteLine($"{factor} and {mirrorFactor}");
                    if (factor == mirrorFactor)
                        factorsAmount++;
                    else
                        factorsAmount += 2;
                }
                factor++;
                mirrorFactor = number / factor;
            }

            return factorsAmount;
        }

        private static void DisplayNumberAndFactorsAmount(int index, int number, int factorsAmount)
        {
            Console.WriteLine($"{index}: {number} has {factorsAmount} factors");
        }
    }
}
