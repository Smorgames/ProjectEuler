using System;
using System.Collections.Generic;

namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine()); // input number
            long multiplyResult = 1L;

            List<int>[] factorsPrimeFactors = new List<int>[number - 1]; // create massive of int lists for factors of number

            for (int i = 2; i <= number; i++) // calculate the factorial
                multiplyResult *= i;

            for (int i = 0; i < number - 1; i++) // for each factor we find the number of prime factors
                factorsPrimeFactors[i] = NumberOfPrimeFactors(i + 2);

            for (int i = 0; i < factorsPrimeFactors.Length; i++)
            {
                Console.Write($"{i + 2}: ");

                foreach (int factor in factorsPrimeFactors[i])
                {
                    Console.Write($"{factor} ");
                }

                Console.Write("\n");
            } // output to the console prime factors of each factorial's factors

            List<int> primeFactors = NumberOfPrimeFactors(multiplyResult);
            List<int> notRepitPrimeFactors = NumberOfNotRepitPrimeFactors(primeFactors);

            int result = SmallestMultiple(factorsPrimeFactors, notRepitPrimeFactors);

            Console.WriteLine(result);
        }

        private static int SmallestMultiple(List<int>[] factorsPrimeFactors, List<int> notRepitPrimeFactors)
        {
            int result = 1;

            for (int i = 0; i < notRepitPrimeFactors.Count; i++)
            {
                int maxAmountOfPrimeFactors = 0; // for each not repit prime factor create variable 

                foreach (List<int> factor in factorsPrimeFactors)
                {
                    int interMaxAmountOfPrimeFactors = 0; // for each factor in factorial variable create intermediate value 

                    for (int j = 0; j < factor.Count; j++)
                        if (factor[j] == notRepitPrimeFactors[i])
                            interMaxAmountOfPrimeFactors++;

                    if (interMaxAmountOfPrimeFactors > maxAmountOfPrimeFactors)
                        maxAmountOfPrimeFactors = interMaxAmountOfPrimeFactors;
                }

                result *= (int)MathF.Pow(notRepitPrimeFactors[i], maxAmountOfPrimeFactors);
            }

            return result;
        }

        private static List<int> NumberOfPrimeFactors(long number)
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

            return primeFactors;
        }

        private static List<int> NumberOfNotRepitPrimeFactors(List<int> primeFactors)
        {
            List<int> notRepitPrimeFactors = new List<int>();

            for (int i = 0; i < primeFactors.Count; i++)
            {
                bool hasRepitableFactor = false;

                foreach (int factor in notRepitPrimeFactors)
                {
                    if (primeFactors[i] == factor)
                        hasRepitableFactor = true;
                }

                if (!hasRepitableFactor)
                    notRepitPrimeFactors.Add(primeFactors[i]);
            }

            return notRepitPrimeFactors;
        }

        private static bool IsFactor(long needNumber, double divider)
        {
            return needNumber / divider - needNumber / (int)divider == 0;
        }

        #region Utilities
        private static void WriteMessege(object messege)
        {
            string stringMessege = messege.ToString();
            Console.WriteLine(stringMessege);
        }

        private static void WriteMessege(object messege, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            WriteMessege(messege);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
    }
}