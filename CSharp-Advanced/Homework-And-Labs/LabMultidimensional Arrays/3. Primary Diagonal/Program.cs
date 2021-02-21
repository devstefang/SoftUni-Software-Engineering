using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(sizes, sizes);
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
               
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                    break;
                }
            }
            Console.WriteLine(sum);


        }

        static  int[,] ReadMatrix(int rows, int cols)
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
