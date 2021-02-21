using System;
using System.Linq;

namespace 2.  2X2 Squares in Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = numbers[0];
            int cols = numbers[1];
           char[,] matrix = ReadMatrix(rows, cols);
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char currElement = matrix[row, col];
                    char downElement = matrix[row + 1, col];
                    char rightElement = matrix[row, col + 1];
                    char diagonalElement = matrix[row + 1, col + 1];
                    if (currElement == downElement && currElement == rightElement && currElement == diagonalElement)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            return matrix;


        }
    }
}
