using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = numbers[0];
            int cols = numbers[1];
            int[,] matrix = ReadMatrix(rows, cols);
            int sum = 0;
            int startIndexRow = 0;
            int startIndexCol = 0;
            for (int row = 0; row < matrix.GetLength(0)-2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int currElemets = matrix[row, col];
                    int currentSum = matrix[row,col] + matrix[row, col+1] + matrix[row, col+2]
                        + matrix[row+1,col] + matrix[row + 2, col] + matrix[row + 1, col+1] + matrix[row+ 1, col+2]
                        + matrix[row+ 2, col+ 1] + matrix[row + 2, col+2];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        startIndexRow = row;
                        startIndexCol = col;
                    }

                }
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"{matrix[startIndexRow, startIndexCol]} {matrix[startIndexRow, startIndexCol + 1]} {matrix[startIndexRow, startIndexCol + 2]}");
            Console.WriteLine($"{matrix[startIndexRow+1, startIndexCol]} {matrix[startIndexRow +1, startIndexCol + 1]} {matrix[startIndexRow+1, startIndexCol + 2]}");
            Console.WriteLine($"{matrix[startIndexRow+2, startIndexCol]} {matrix[startIndexRow +2, startIndexCol + 1]} {matrix[startIndexRow+2, startIndexCol + 2]}");





        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            return matrix;


        }
    }
}
