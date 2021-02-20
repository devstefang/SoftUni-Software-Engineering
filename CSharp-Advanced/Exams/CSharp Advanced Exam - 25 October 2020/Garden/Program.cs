using System;
using System.IO;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            // n - n- row of input - 5 - 5-1
            int[] inputDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int row = inputDimensions[0];
            int col = inputDimensions[1];
            int[,] matrix = ReadMatrix(row, col);
            string input;
            
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] parsedInput = input.Split().Select(int.Parse).ToArray();
                int parsedRow = parsedInput[0];
                int parsedCol = parsedInput[1];
                bool isOut = parsedRow >= row || parsedCol >= col;
                if (isOut)
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                // up direction
                matrix[parsedRow, parsedCol] = 1;
                for (int rows = 0; rows < row - (row-parsedRow) ; rows++)
                {
                    int currentRow = parsedRow - (rows + 1);
                    matrix[currentRow, parsedCol]++;
                }
                // down
                for (int rows = 1; rows < row -  parsedRow; rows++)
                {
                    int currentRow = parsedRow + rows;
                    matrix[currentRow, parsedCol]++;
                }
                //right
                for (int cols = 1; cols < row - parsedCol; cols++)
                {
                    int currentCol = parsedCol + cols;
                    matrix[parsedRow, currentCol]++;
                }
                // left
                for (int cols = 1; cols <= row - (row - parsedRow); cols++)
                {
                    int currentCol = parsedCol - cols ;
                    matrix[parsedRow, currentCol]++;
                }
            }

            for (int rows = 0; rows < row ; rows++)
            {
                for (int cols = 0; cols < col; cols++)
                {
                    int current = matrix[rows, cols];
                    Console.Write($"{current} ");
                }
                Console.WriteLine();
            }
        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            // CHANGE from char to needed variable!!
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }
            return matrix;
        }
    }
}
