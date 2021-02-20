using System;
using System.IO;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(size, size);
            int startRow = 0;
            int startCol = 0;
            bool isWon = false;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    char currChar = matrix[row, col];
                    if (currChar == 'f')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            matrix[startRow, startCol] = '-';
            for ( int i = 0; i < commandsCount; i++)
            {
                 string command = Console.ReadLine();
                matrix[startRow, startCol] = '-';
                if (command == "up")
                {
                    if (startRow == 0)
                    {
                        startRow = size - 1;
                        goto ToContinue;
                    }
                    startRow--;
                }
                else if (command == "down")
                {
                    startRow++;
                    if (startRow == size)
                    {
                        startRow = 0;
                        goto ToContinue;
                    }
                    
                }
                else if (command == "left")
                {
                    if (startCol == 0)
                    {
                        startCol = size - 1;
                        goto ToContinue;
                    }
                    startCol--;
                }
                else if (command == "right")
                {
                    startCol++;
                    if (startCol == size)
                    {
                        startCol = 0;
                        goto ToContinue;
                    }
                    
                }
                ToContinue:
                if (matrix[startRow, startCol] == 'B')
                {
                    if (command == "up")
                    {
                        startRow--;
                        if (startRow <= 0)
                        {
                            startRow = size - 1;
                            goto ToContinueFurther;
                        }
                       
                    }
                    else if (command == "down")
                    {
                        startRow++;
                        if (startRow >= size)
                        {
                            startRow = 0;
                            goto ToContinueFurther;

                        }
                        
                    }
                    else if (command == "left")
                    {
                        startCol--;
                        if (startCol <= 0)
                        {
                            startCol = size - 1; 
                            goto ToContinueFurther;
                        }
                        
                    }
                    else if (command == "right")
                    {
                        startCol++;
                        if (startCol >= size)
                        {
                            startCol = 0;
                            goto ToContinueFurther;
                        }
                        
                    }
                }
                if (matrix[startRow,startCol] == 'T')
                {
                    if (command == "up")
                    {

                        startRow++;
                    }
                    else if (command == "down")
                    {
                        
                        startRow--;
                    }
                    else if (command == "left")
                    {
                        
                        startCol++;
                    }
                    else if (command == "right")
                    {
                        
                        startCol--;
                    }
                }
                ToContinueFurther:
                if (matrix[startRow, startCol] == 'F')
                {
                    isWon = true;
                    matrix[startRow, startCol] = 'f';
                    break;
                }
                matrix[startRow, startCol] = 'f';

            }
            if (isWon == true)
            {
                Console.WriteLine("Player won!");
            }
            else if (isWon == false)
            { 
                Console.WriteLine("Player lost!");
            }
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    char currElement = matrix[row, col];
                    Console.Write(currElement);
                }
                Console.WriteLine();
            }
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
