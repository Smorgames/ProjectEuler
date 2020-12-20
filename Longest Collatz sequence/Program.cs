using System;
using System.Collections.Generic;

namespace Longest_Collatz_sequence
{
    class Program
    {
        static void Main(string[] args)
        {            
            ulong numbersAmount = 10000000;
            ulong[] collatzNumbers = new ulong[numbersAmount];
            List<ulong> numbersOutOfRange = new List<ulong>();
            ulong firstLongestTerm = 0;

            FillCollatzArray(collatzNumbers);

            int longestCollatzSequence = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                int collatzSequenceLenght = CalculateCollatzTermsAmount(i, collatzNumbers, numbersAmount, numbersOutOfRange);

                if (collatzSequenceLenght > longestCollatzSequence)
                {
                    longestCollatzSequence = collatzSequenceLenght;
                    firstLongestTerm = (ulong)i;
                }
            }

            Console.WriteLine(longestCollatzSequence);

            for (int i = 0; i < numbersOutOfRange.Count; i++)
            {
                int collatzSequenceLenght = DisplayDataCollatzTerm(numbersOutOfRange[i]);

                if (collatzSequenceLenght > longestCollatzSequence)
                {
                    longestCollatzSequence = collatzSequenceLenght;
                    firstLongestTerm = numbersOutOfRange[i];
                }
            }

            Console.WriteLine($"Longest Collatz sequence = {longestCollatzSequence} first term = {firstLongestTerm}");
        }

        private static void FillCollatzArray(ulong[] array)
        {
            for (ulong i = 0; i < (ulong)array.Length; i++)
            {
                if (i % 2 == 0)
                    array[i] = i / 2;
                else
                    array[i] = 3 * i + 1;
            }
        }

        private static int CalculateCollatzTermsAmount(int collatzNumber, ulong[] array, ulong numberAmount, List<ulong> termsOutOfRange)
        {
            int termsAmount = 1;
            ulong i = (ulong)collatzNumber;
            ulong firstTerm = (ulong)collatzNumber;

            while (i != 1)
            {
                if (i * 3 + 1 > numberAmount && i % 2 != 0)
                {
                    Console.WriteLine($"First term was {firstTerm}. Term out of range = {i}");
                    termsOutOfRange.Add(firstTerm);
                    return 0;
                }

                i = array[i];
                termsAmount++;
            }

            return termsAmount;
        }

        private static ulong CalculateNextCollatzTerm(ulong number)
        {
            if (number % 2 == 0)
                return number / (ulong)2;
            else
                return (ulong)3 * number + 1;
        }

        private static int DisplayDataCollatzTerm(ulong term)
        {
            ulong number = term;
            int termAmount = 1;
            ulong maxTerm = number;
            ulong firstTerm = number;

            while (number != 1)
            {
                number = CalculateNextCollatzTerm(number);
                termAmount++;
                if (maxTerm < number)
                    maxTerm = number;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"If first term = {firstTerm}, then term amount = {termAmount} and maxTerm = {maxTerm}");
            Console.ForegroundColor = ConsoleColor.White;

            return termAmount;
        }
    }
}