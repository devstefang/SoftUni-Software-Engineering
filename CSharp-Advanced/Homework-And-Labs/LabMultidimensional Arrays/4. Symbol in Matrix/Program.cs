using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //3
            //ABC
            //DEF
            //X!@
            //!
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(size, size);
            char specialChar = Console.ReadLine()[0];
            bool isFound = false;
            int rowFound = 0;
            int colFound = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == specialChar)
                    {
                        rowFound = row;
                        colFound = col;
                        isFound = true;
                    }
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{specialChar} does not occur in the matrix ");
            }
            else if (isFound == true)
            {
                Console.WriteLine($"({rowFound}, {colFound})");
            }

        }
    static  char[,] ReadMatrix(int rows, int cols)
        {
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
