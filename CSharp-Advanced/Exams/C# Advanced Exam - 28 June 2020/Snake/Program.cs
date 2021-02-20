using System;
using System.IO;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int foodQuantity = 0;
            char[,] matrix = ReadMatrix(n, n);
            int startRow = -1;
            int startCol = -1;
            bool isFound = false;
            bool isOutOfBoundaries = false;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currElement = matrix[row, col];
                    if (currElement == 'S')
                    {
                        startRow = row;
                        startCol = col;
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            string input = Console.ReadLine();
            while (foodQuantity <= 10)
            {

                matrix[startRow, startCol] = '.';
                startRow = MoveRow(startRow, input);
                startCol = MoveCol(startCol, input);
                if (!IsPositionValid(startRow,startCol,n,n))
                {
                    isOutOfBoundaries = true;
                    break;
                }
                if (matrix[startRow,startCol] == 'B')
                {
                    matrix[startRow, startCol] = '.';
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            char currElement = matrix[row, col];
                            if (currElement == 'B' && row != startRow && col != startCol)
                            {
                                startRow = row;
                                startCol = col;
                            }
                        }
                    }

                }
                if (matrix[startRow,startCol] == '*')
                {
                    foodQuantity++;
                }
                matrix[startRow, startCol] = 'S';
                if (foodQuantity == 10)
                {
                    break;
                }
                input = Console.ReadLine();
                
            }
            if (isOutOfBoundaries)
            {
                Console.WriteLine("Game over!");
            }
            if (foodQuantity >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }
        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }
        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }
        static char[,] ReadMatrix(int rows, int cols)
        {
            // CHANGE from char to needed variable!!
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            return matrix;
        }
    }
}
