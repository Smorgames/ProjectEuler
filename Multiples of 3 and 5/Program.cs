using System;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[1000];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;

            int summ = 0;

            for (int i = 0; i < numbers.Length; i++)
                if ((numbers[i] % 3 == 0 && numbers[i] % 5 != 0) || (numbers[i] % 3 != 0 && numbers[i] % 5 == 0) || (numbers[i] % 3 == 0 && numbers[i] % 5 == 0))
                {
                    Console.WriteLine(numbers[i]);
                    summ += numbers[i];
                }

            Console.WriteLine($"Summ = {summ}");
        }
    }
}
