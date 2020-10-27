using System;

namespace Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSomeNumbers = Convert.ToInt32(Console.ReadLine());

            int squaresOfTheSum = SquaresOfTheSum(firstSomeNumbers);
            int sumOfTheSquares = SumOfTheSquares(firstSomeNumbers);

            Console.WriteLine($"Squares of the sum of first {firstSomeNumbers} numbers = {squaresOfTheSum}");
            Console.WriteLine($"Sum of the squares of first {firstSomeNumbers} numbers = {sumOfTheSquares}");
            Console.WriteLine($"Difference between squares of the sum and sum of the squares of first = {squaresOfTheSum - sumOfTheSquares}");
        }

        private static int SquaresOfTheSum(int firstSomeNumbers)
        {
            int squaresOfTheSum = 0;

            for (int i = 1; i <= firstSomeNumbers; i++)
                squaresOfTheSum += i;

            squaresOfTheSum = (int)MathF.Pow(squaresOfTheSum, 2);

            return squaresOfTheSum;
        }

        private static int SumOfTheSquares(int firstSomeNumbers)
        {
            int sumOfTheSquares = 0;

            for (int i = 1; i <= firstSomeNumbers; i++)
                sumOfTheSquares += (int)MathF.Pow(i, 2);

            return sumOfTheSquares;
        }
    }
}
