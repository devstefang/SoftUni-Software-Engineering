using System;
using System.IO;

namespace _2.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(n, n);
            int startRow = 0;
            int startCol = 0;
            int pillarRow = 0;
            int pillarCol = 0;
            int pillarCount = 0;
            int money = 0;
            bool outOfMatrix = false;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    char currElement = matrix[row, col];
                    if (currElement == 'S')
                    {
                        startRow = row;
                        startCol = col;

                    }
                     if (currElement == 'O')
                     {
                        pillarCount++;
                        if (pillarCount > 1)
                        {
                            break;
                        }
                        pillarRow = row;
                        pillarCol = col;
                        
                    }
                }
            }
            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                bool enoughMoney = false;
                bool isOut = startRow == 0 && commands == "up" || startRow == n-1 && commands == "down"
                    || startCol == 0 && commands == "left" || startCol == n - 1 && commands == "right";
                matrix[startRow, startCol] = '-';
                if (isOut)
                {
                    outOfMatrix = true;
                    break;
                }
                if (commands == "up")
                {
                    startRow--;
                }
                else if (commands == "down")
                {
                    startRow++;
                }
                else if (commands == "left")
                {
                    startCol--;
                }
                else if (commands == "right")
                {
                    startCol++;
                }
                
                if (matrix[startRow, startCol] == 'O' )
                {
                    matrix[startRow, startCol] = '-';
                    if (startRow != pillarRow && startCol != pillarCol)
                    {
                        startRow = pillarRow;
                        startCol = pillarCol;
                        matrix[pillarRow, pillarCol] = 'S';
                    }
                    else
                    {
                        for (int row = 0; row < n; row++)
                        {
                            for (int col = 0; col < n; col++)
                            {
                                char element = matrix[row, col];
                                if (element == 'O' && row != pillarRow && col != pillarCol )
                                {
                                    startRow = row;
                                    startCol = col;
                                    matrix[startRow, startCol] = 'S';
                                }
                            }
                        }
                    }

                }
                char currElement = matrix[startRow, startCol];
                if (char.IsDigit(currElement))
                {
                    money += int.Parse(currElement.ToString());
                }
                if (money >= 50)
                {
                    enoughMoney = true;
                    matrix[startRow, startCol] = 'S';
                    break;
                }
                matrix[startRow, startCol] = 'S';
            }
            if (outOfMatrix)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            else if (money >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {money}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    char current = matrix[row, col];
                    Console.Write(current);
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
