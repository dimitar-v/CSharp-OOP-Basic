using System;

namespace P06_Sneaking
{
    public class Sneaking
    {
        static Field room;
        static Player sam;
        public static void Main() // 90/100
        {
            int n = int.Parse(Console.ReadLine());
            room = new Field(n, Console.ReadLine);
            
            var moves = Console.ReadLine().ToCharArray();

            GetSamPosition();

            for (int i = 0; i < moves.Length; i++)
            {
                EnemiesMoves();
                
                Player enemy = GetEnemyPosition();
                
                if (IsSamDie(enemy))
                {
                    SamDie();
                    break;
                }

                MoveSam(moves[i]);

                enemy = GetEnemyPosition();

                if (IsSamDie(enemy))
                {
                    SamDie();
                    break;
                }

                if (enemy != null && room.GetChar(enemy.X, enemy.Y) == 'N' && sam.X == enemy.X)
                {
                    room.SetChar(enemy.X, enemy.Y, 'X');
                    Console.WriteLine("Nikoladze killed!");
                    Console.WriteLine(room.ToString());
                    break;
                }
            }
        }

        private static bool IsSamDie(Player enemy)
            => enemy != null 
                    &&
                    ((sam.Y<enemy.Y && room.GetChar(enemy.X, enemy.Y) == 'd') 
                    || (sam.Y > enemy.Y && room.GetChar(enemy.X, enemy.Y) == 'b'));


        private static Player GetEnemyPosition()
        {
            for (int j = 0; j < room.GetCols(sam.X); j++)
            {
                if (room.GetChar(sam.X, j) != '.' && room.GetChar(sam.X, j) != 'S')
                {
                    return new Player(sam.X, j);
                }
            }

            return null;
        }

        private static void SamDie()
        {
            room.SetChar(sam.X, sam.Y, 'X');
            Console.WriteLine($"Sam died at {sam.X}, {sam.Y}");
            Console.WriteLine(room.ToString());
        }

        private static void MoveSam(char move)
        {
            room.SetChar(sam.X, sam.Y, '.');
            switch (move)
            {
                case 'U':
                    sam.X--;
                    break;
                case 'D':
                    sam.X++;
                    break;
                case 'L':
                    sam.Y--;
                    break;
                case 'R':
                    sam.Y++;
                    break;
                default:
                    break;
            }
            room.SetChar(sam.X, sam.Y, 'S');
        }

        private static void GetSamPosition()
        {
            for (int row = 0; row < room.GetRows(); row++)
            {
                for (int col = 0; col < room.GetCols(row); col++)
                {
                    if (room.GetChar(row, col) == 'S')
                    {
                        sam = new Player(row, col);
                    }
                }
            }
        }

        public static void EnemiesMoves()
        {
            for (int row = 0; row < room.GetRows(); row++)
            {
                for (int col = 0; col < room.GetCols(row); col++)
                {
                    if (room.GetChar(row, col) == 'b')
                    {
                        if (CanMove('R', row, col))
                        {
                            room.SetChar(row, col, '.');
                            room.SetChar(row, col + 1 , 'b');
                            col++;
                        }
                        else
                        {
                            room.SetChar(row, col, 'd');
                        }
                    }
                    else if (room.GetChar(row, col) == 'd')
                    {
                        if (CanMove('L', row, col))
                        {
                            room.SetChar(row, col, '.');
                            room.SetChar(row, col - 1, 'd');
                        }
                        else
                        {
                            room.SetChar(row, col, 'b');
                        }
                    }
                }
            }
        }

        private static bool CanMove(char direction, int row, int col)
        {
            switch (direction)
            {
                case 'L': return col - 1 >= 0;
                case 'R': return col + 1 < room.GetCols(row);
                default: return false;
            }
        }
    }
}
