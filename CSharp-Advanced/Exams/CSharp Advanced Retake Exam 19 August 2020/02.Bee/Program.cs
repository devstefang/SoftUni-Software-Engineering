using System;
using System.IO;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(n, n);
            int startRow = 0;
            int startCol = 0;
            int pollinatedFlowersCount = 0;
            bool isOut = false;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    char currElement = matrix[row, col];
                    if (currElement == 'B')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            string command = Console.ReadLine();
            while (command != "End")
            {
                matrix[startRow, startCol] = '.';
                if (command == "up")
                {
                    if (startRow == 0)
                    {
                        isOut = true;
                        break;
                    }
                    startRow--;
                }
                else if (command == "down")
                {
                    if (startRow >= n-1)
                    {
                        isOut = true;
                        break;
                    }
                    startRow++;
                }
                else if (command == "left")
                {
                    if (startCol == 0)
                    {
                        isOut = true;
                        break;
                    }
                    startCol--;
                }
                else if (command == "right")
                {
                    if (startCol >= n-1)
                    {
                        isOut = true;
                        break;
                    }
                    startCol++;
                }
                
                if (matrix[startRow,startCol] == 'O')
                {
                    if (command == "up")
                    {
                        matrix[startRow, startCol] = '.';
                        startRow--;
                    }
                    else if (command == "down")
                    {
                        matrix[startRow, startCol] = '.';
                        startRow++;
                    }
                    else if (command == "left")
                    {
                        matrix[startRow, startCol] = '.';
                        startCol--;
                    }
                    else if (command == "right")
                    {
                        matrix[startRow, startCol] = '.';
                        startCol++;  
                    }
                    
                }
                if (matrix[startRow, startCol] == 'f')
                {
                    pollinatedFlowersCount++;
                }
                matrix[startRow, startCol] = 'B';


                command = Console.ReadLine();
            }
            if (isOut == true)
            {
                Console.WriteLine("The bee got lost!");
            }
            if (pollinatedFlowersCount >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowersCount} flowers!");
            }
            else if (pollinatedFlowersCount < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowersCount} flowers more");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
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
