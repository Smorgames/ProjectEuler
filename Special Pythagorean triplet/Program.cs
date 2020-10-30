using System;
using System.Diagnostics;

namespace Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c = 0;

            int topLimit = 1000;

            for (int i = 1; i <= topLimit; i++)
            {
                for (int j = 1; j <= topLimit; j++)
                {
                    a = i;
                    b = j;
                    c = topLimit - a - b;

                    if (IsItPythagoreanTriplet(a, b, c) && a > b)
                    {
                        Console.WriteLine($"a = {a}, b = {b}, c = {c} and a * b * c = {a * b * c}");
                        Console.WriteLine($"a^2 + b^2 = {a * a + b * b}");
                        Console.WriteLine($"c^2 = {c * c}");
                        break;
                    }
                }
            }
        }

        private static bool IsItPythagoreanTriplet(int a, int b, int c)
        {
            if (a * a + b * b == c * c)
                return true;
            else
                return false;
        }
    }
}
