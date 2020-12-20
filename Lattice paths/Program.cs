using System;

namespace Lattice_paths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter tablet size: ");
            long tabletSize = Convert.ToInt64(Console.ReadLine());

            while (tabletSize < 0)
            {
                Console.Write("Enter tablet size > 0: ");
                tabletSize = Convert.ToInt64(Console.ReadLine());
            }

            long[,] tablet = new long[tabletSize,tabletSize];
            tablet[0, 0] = 1;

            for (int i = 0; i < tablet.GetLength(0); i++)
            {
                for (int j = 0; j < tablet.GetLength(1); j++)
                {
                    tablet[i, j] = CalculateNeighborPathSum(tablet, j, i);
                }
            }

            for (int i = 0; i < tablet.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < tablet.GetLength(1); j++)
                {
                    Console.Write($"({j};{i})={tablet[i,j]} ");
                }
            }
        }

        private static long CalculateNeighborPathSum(long[,] array, int x, int y)
        {
            long upperNeighborSum = 0;
            long leftNeighborSum = 0;

            if (x - 1 >= 0)
                leftNeighborSum = array[y, x - 1];

            if (y - 1 >= 0)
                upperNeighborSum = array[y - 1, x];

            if (x == 0 && y == 0)
                return 1;

            return leftNeighborSum + upperNeighborSum;
        }
    }
}
