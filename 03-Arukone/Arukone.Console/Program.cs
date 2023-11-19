using Arukone.Model;
using System.Drawing;

namespace Arukone_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = BoardFactory.CreateBoard(8, 4);
            DrawBoard(board);
        }

        private static void DrawBoard(Board board)
        {
            for (int y = 0; y < board.Size; y++)
            {
                for (int x = 0; x < board.Size; x++)
                {
                    Console.Write($"{board.Fields[x, y].Value,-3}");
                }
                Console.WriteLine();
            }
        }
    }
}