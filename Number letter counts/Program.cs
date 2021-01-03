using System;

namespace Number_letter_counts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lettersAmount = new int[1001];

            FillArray(lettersAmount);
            int letterSum = 0;
            int lastNumber = lettersAmount.Length;

            for (int i = 1; i < lastNumber; i++)
            {
                lettersAmount[i] = GetLetterAmount(i, lettersAmount);
                letterSum += lettersAmount[i];

                if (i == 100)
                    lettersAmount[i] = 7;
            }

            //int k = 900;
            //Console.WriteLine($"{k} has {lettersAmount[k]} letters");
            Console.WriteLine($"Letters amount from 1 to {lastNumber - 1} = {letterSum}");
        }

        private static int GetLetterAmount(int number, int[] lettersAmount)
        {
            if (number <= 19)
                return lettersAmount[number];

            if (number < 100)
            {
                int tens = number / 10;
                int units = number % 10;

                return lettersAmount[tens * 10] + lettersAmount[units];
            }

            if (number < 1000)
            {
                int hundreds = number / 100;
                int reminder = number % 100;

                if (number % 100 != 0)
                    return lettersAmount[hundreds] + lettersAmount[100] + lettersAmount[reminder] + 3;
                else
                    return lettersAmount[hundreds] + lettersAmount[100] + lettersAmount[reminder];
            }

            if (number == 1000)
                return 11;

            return 0;
        }

        private static void FillArray(int[] array)
        {
            array[1] = 3;
            array[2] = 3;
            array[3] = 5;
            array[4] = 4;
            array[5] = 4;
            array[6] = 3;
            array[7] = 5;
            array[8] = 5;
            array[9] = 4;
            array[10] = 3;
            array[11] = 6;
            array[12] = 6;
            array[13] = 8;
            array[14] = 8;
            array[15] = 7;
            array[16] = 7;
            array[17] = 9;
            array[18] = 8;
            array[19] = 8;
            array[20] = 6;
            array[30] = 6;
            array[40] = 5;
            array[50] = 5;
            array[60] = 5;
            array[70] = 7;
            array[80] = 6;
            array[90] = 6;
            array[100] = 7;          
        }
    }
}