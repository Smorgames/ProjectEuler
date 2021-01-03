using System;
using System.Collections.Generic;

namespace Power_digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            number.Add(1);

            int power = 1000;

            while(power != 0)
            {
                Multiply(number, 2);
                power--;
            }

            Console.WriteLine(DigitSum(number));
        }

        private static void Multiply(List<int> number, int multiplyer)
        {
            int over = 0;

            for (int i = 0; i < number.Count; i++)
            {
                int result = number[i] * multiplyer + over;
                over = result / 10;

                if (over == 0)
                    number[i] = result;
                else
                    number[i] = result % 10;
            }

            if (over > 0)
                number.Add(over);
        }

        private static void PrintNumber(List<int> number)
        {
            for (int i = number.Count - 1; i >= 0; i--)
                Console.Write(number[i]);
        }

        private static int DigitSum(List<int> number)
        {
            int sum = 0;

            for (int i = 0; i < number.Count; i++)
            {
                sum += number[i];
            }

            return sum;
        }
    }
}