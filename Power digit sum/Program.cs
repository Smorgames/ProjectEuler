using System;
using System.Collections.Generic;

namespace Power_digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
        }

        private static void Multiply(List<int> number, int multiplyer)
        {
            for (int i = 0; i < number.Count; i++)
            {
                int result = number[i] * multiplyer;
                int over = result / 10;

                if (result / 10 != 0)
                    number[i + 1] = number[i + 1] + over;
            }
        }

        private 
    }
}
