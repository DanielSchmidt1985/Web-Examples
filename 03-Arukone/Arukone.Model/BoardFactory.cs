using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arukone.Model
{
    public class BoardFactory
    {
        public static Board CreateBoard(int size, int nums)
        {
            Board board = new Board(size);
            board.Fields = new Field[size, size];

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    Field field = new Field(x, y);
                    board.Fields[x, y] = field;
                }
            }

            foreach (Field field in board.Fields)
            {
                ConnectField(board, field);
            }

            Random random = new Random();
            for (int i = 0; i < nums; i++)
            {
                for (int n = 0; n < 2; n++)
                {
                    while (true)
                    {
                        int x = random.Next(0, board.Size - 1);
                        int y = random.Next(0, board.Size - 1);
                        Field field = board.Fields[x, y];
                        if (field.Value == 0)
                        {
                            field.Value = i + 1;
                            break;
                        }
                    } 
                }
            }

            return board;
        }

        public static void ConnectField(Board board, Field field)
        {
            if (field == null)
            {
                throw new ArgumentNullException("field");
            }
            if (board == null)
            {
                throw new ArgumentNullException("board");
            }
            if (field.X > 0)
            {
                field.W = board.Fields[field.X - 1, field.Y];
            }
            if (field.X < board.Size - 1)
            {
                field.E = board.Fields[field.X + 1, field.Y];
            }
            if (field.Y > 0)
            {
                field.N = board.Fields[field.X, field.Y - 1];
            }
            if (field.Y < board.Size - 1)
            {
                field.S = board.Fields[field.X, field.Y + 1];
            }
        }
    }
}
