using System;
using System.Collections.Generic;

namespace Maximum_path_sum_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = 
                "759564174782183587102004824765190123750334880277730763679965042806167092414126568340807033" +
                "41487233473237169429537144652543915297511470113328777317783968175791715238171491435850272948" +
                "6366046889536730731669874031046298272309709873933853600423";

            string numbers2 = "3742468593";
            int[] numbers2Int = new int[numbers2.Length];

            ParseArrayOneDigit(numbers2, numbers2Int);

            int treeHeight = Convert.ToInt32(Console.ReadLine());
            List<int>[] tree = new List<int>[treeHeight];

            for (int i = 0; i < tree.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    tree[j].Add(numbers2Int[i + j]);
                }
            }
        }

        private static void ParseArrayOneDigit(string stringArray, int[] array)
        {
            for (int i = 0; i < stringArray.Length; i++)
                array[i] = stringArray[i] - '0';
        }

        private static void ParseArrayTwoDigit(string stringArray, int[] array)
        {
            for (int i = 0; i < stringArray.Length; i += 2)
                array[i] = Convert.ToInt32(stringArray[i] + stringArray[i + 1]);
        }
    }
}