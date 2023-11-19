namespace Arukone.Model
{
    public class Board
    {
        public Field[,] Fields { get; set; }

        public int Size { get; private set; }

        public Board(int size)
        {
            Fields = new Field[size, size];
            Size = size;
        }

    }
}