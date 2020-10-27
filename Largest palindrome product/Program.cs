using System;
using System.Collections.Generic;

namespace Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLimit = 999;
            int minLimit = 100;

            List<int> palindromeArray = new List<int>();

            for (int i = maxLimit; i >= minLimit; i--)
            {
                for (int j = maxLimit; j >= minLimit; j--)
                {
                    int result = i * j;

                    if (IsPalindrome(result))
                        palindromeArray.Add(result);
                }
            }

            palindromeArray.Sort();

            Console.WriteLine(palindromeArray[palindromeArray.Count - 1]);
        }

        private static bool IsPalindrome(int number)
        {
            string stringNumber = number.ToString();
            char[] literals = new char[stringNumber.Length];

            literals = stringNumber.ToCharArray();

            for (int i = 0; i < literals.Length; i++)
            {
                if (literals[i] != literals[literals.Length - (i + 1)])
                    return false;
            }

            return true;
        }
    }
}