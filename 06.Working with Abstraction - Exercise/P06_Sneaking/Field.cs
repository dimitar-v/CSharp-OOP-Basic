using System;
using System.Text;

namespace P06_Sneaking
{
    public class Field
    {
        public char[][] Board { get; set; }
        
        public Field(int rows, Func<string> read)
        {
            Board = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                var input = read().ToCharArray();
                Board[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    Board[row][col] = input[col];
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < Board.Length; row++)
            {
                for (int col = 0; col < Board[row].Length; col++)
                {
                    sb.Append(Board[row][col]);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        internal char GetChar(int row, int col)
            => Board[row][col];

        public int GetRows()
            => Board.Length;

        public int GetCols(int row)
            => Board[row].Length;

        public void SetChar(int row, int col, char ch)
            => Board[row][col] = ch;
    }
}
