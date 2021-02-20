using System;
using System.IO;
using System.Linq;

namespace _2._Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());


            string[] rowAndCol = Console.ReadLine()
                .Split(",");
            string[,] matrix = ReadMatrix(fieldSize,fieldSize);

            int playerOneShipCount = 0;
            int playerTwoShipCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    string currElement = matrix[row, col];
                    if (currElement == "<")
                    {
                        playerOneShipCount++;
                    }
                    else if (currElement == ">")
                    {
                        playerTwoShipCount++;
                    }
                }
            }
            int CountFirstPlayer = playerOneShipCount;
            int CountSecondPlayer = playerTwoShipCount;
            for (int i = 0; i < rowAndCol.Length; i++)
            {

                if (playerOneShipCount <= 0 && playerTwoShipCount <= 0)
                {
                    break;
                }

                string[] coordinateInfo = rowAndCol[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(coordinateInfo[0]);
                int col = int.Parse(coordinateInfo[1]);

                if (IsValidCoordinates(row, col, fieldSize) == false)
                {
                    continue;
                }

                if (i % 2 == 0) 
                {
                    if (matrix[row, col] == ">")
                    {
                        matrix[row, col] = "X";
                        playerOneShipCount++;
                    }

                    if (matrix[row, col] == "#")
                    {
                        matrix = Mine(ref playerOneShipCount, ref playerTwoShipCount, row, col, matrix, fieldSize);
                    }
                }
                else 
                {
                    if (matrix[row, col] == "<")
                    {
                        matrix[row, col] = "X";
                        playerTwoShipCount++;
                    }

                    if (matrix[row, col] == "#")
                    {
                        matrix = Mine(ref playerOneShipCount, ref playerTwoShipCount, row, col, matrix, fieldSize);
                    }
                }
            }
            if (playerOneShipCount <= 0 || playerTwoShipCount <= 0)
            {
                if (playerOneShipCount > 0)
                {
                    int finalSum = CountSecondPlayer + (CountFirstPlayer - playerOneShipCount);
                    Console.WriteLine($"Player One has won the game! {finalSum} ships have been sunk in the battle.");
                }
                else
                {
                    int finalSUm = CountFirstPlayer + (CountSecondPlayer - playerTwoShipCount);
                    Console.WriteLine($"Player Two has won the game! {finalSUm} ships have been sunk in the battle.");
                }
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {playerOneShipCount} ships left. Player Two has {playerTwoShipCount} ships left.");
            }


        }
        static string[,] ReadMatrix(int rows, int cols)
        {
            // CHANGE from char to needed variable!!
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            return matrix;
        }
        static void HasAShip(ref int firstShips, ref int secondShips, string character)
        {
            if (character == "<")
            {
                firstShips--;
            }

            if (character == ">")
            {
                secondShips--;
            }
        }
        static bool IsValidCoordinates(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }
        static string[,] Mine(ref int playerOneShip,ref int playerTwoShip, int row, int col, string[,] matrix, int n)
        {
            int shipRow;
            int shipCol;

            if (IsValidCoordinates(row - 1, col, n)) //up
            {
                shipRow = row - 1;
                HasAShip(ref playerOneShip, ref playerTwoShip, matrix[shipRow, col]);
                matrix[shipRow, col] = "X";
            }

            if (IsValidCoordinates(row + 1, col, n)) //down
            {
                shipRow = row + 1;
                HasAShip(ref playerOneShip, ref playerTwoShip, matrix[shipRow, col]);
                matrix[shipRow, col] = "X";
            }

            if (IsValidCoordinates(row, col + 1, n)) //right
            {
                shipCol = col + 1;
                HasAShip(ref playerOneShip, ref playerTwoShip, matrix[row, shipCol]);
                matrix[row, shipCol] = "X";
            }

            if (IsValidCoordinates(row, col - 1, n)) //left
            {
                shipCol = col - 1;
                HasAShip(ref playerOneShip, ref playerTwoShip, matrix[row, shipCol]);
                matrix[row, shipCol] = "X";
            }

            if (IsValidCoordinates(row - 1, col - 1, n)) //leftUp
            {
                shipRow = row - 1;
                shipCol = col - 1;
                HasAShip(ref playerOneShip, ref playerTwoShip, matrix[shipRow, shipCol]);
                matrix[shipRow, shipCol] = "X";
            }

            if (IsValidCoordinates(row - 1, col + 1, n)) //rightUp
            {
                shipRow = row - 1;
                shipCol = col + 1;
                HasAShip(ref playerOneShip, ref playerTwoShip, matrix[shipRow, shipCol]);
                matrix[shipRow, shipCol] = "X";
            }

            if (IsValidCoordinates(row + 1, col - 1, n)) //downleft
            {
                shipRow = row + 1;
                shipCol = col - 1;
                HasAShip(ref playerOneShip, ref playerTwoShip, matrix[shipRow, shipCol]);
                matrix[shipRow, shipCol] = "X";
            }

            if (IsValidCoordinates(row + 1, col + 1, n)) //downRight
            {
                shipRow = row + 1;
                shipCol = col + 1;
                HasAShip(ref playerOneShip, ref playerTwoShip, matrix[shipRow, shipCol]);
                matrix[shipRow, shipCol] = "X";
            }

            

            return matrix;
        }
    }
}
