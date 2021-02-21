using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(sizes, sizes);
            int sum = 0;
            int sumToSubtract = 0;
            int maxCol = matrix.GetLength(1);
            for (int row = 0; row < matrix.GetLength(1); row++)
            {

                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                    break;
                }
            }
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = maxCol - 1; col >= 0; col--)
                {
                    sumToSubtract += matrix[row, col];
                    maxCol--;
                    break;
                }
            }
            int finalSum = sum - sumToSubtract;
            Console.WriteLine($"{Math.Abs(finalSum)}");


        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            return matrix;


        }
    }
}
