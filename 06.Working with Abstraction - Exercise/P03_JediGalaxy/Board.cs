namespace P03_JediGalaxy
{
    class Board
    {
        private int[,] matrix;

        public Board(int row, int col)
        {
            Matrix = new int[row, col];
            Initialise();
        }

        public int[,] Matrix { get => matrix; set => matrix = value; }

        private void Initialise()
        {
            int value = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }

        public bool IsInside(int row, int col)
            => row >= 0 && row < Matrix.GetLength(0) && col >= 0 && col < Matrix.GetLength(1);
    }
}
