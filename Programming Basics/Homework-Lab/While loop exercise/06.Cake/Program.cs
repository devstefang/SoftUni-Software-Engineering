using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int totalCakePieces = cakeLenght * cakeWidth;
            int piecesTaken = 0;
            string input = "";
            while (totalCakePieces >= piecesTaken)
            {
                piecesTaken = int.Parse(Console.ReadLine());

                piecesTaken += piecesTaken;
                int piecesLeft = totalCakePieces - piecesTaken;

                if (input == "STOP")
                {
                    input = Console.ReadLine();
                    Console.WriteLine($"{piecesLeft} pieces are left.");
                }
            }

        }
    }
}
