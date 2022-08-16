using System;

namespace Task3
{
    public class WalkThroughTheMatrix
    {
        public static void ChangeDirection(ref int dx, ref int dy)
        {
            int[] dirX = new int[8] { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = new int[8] { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;

            for (int i = 0; i < 8; i++)
            {
                if (dirX[i] == dx && dirY[i] == dy)
                {
                    currentDirection = i;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                dx = dirX[0];
                dy = dirY[0];
                return;
            }

            dx = dirX[currentDirection + 1];
            dy = dirY[currentDirection + 1];
        }
        public static bool CheckForTheNextDirection(int[,] matrix, int x, int y)
        {
            int[] dirX = new int[8] { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = new int[8] { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= matrix.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= matrix.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool FindFreeCell(int[,] matrix, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return true;
                    }
                }
            }
            return false;
        }

        public static void Main()
        {
            Console.Write("Enter a positive number: ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            int[,] matrix = new int[n, n];
            int k = 1;
            int i = 0;
            int j = 0;
            int dx = 1;
            int dy = 1;

            while (FindFreeCell(matrix, out i, out j))
            {

                while (true)
                {
                    matrix[i, j] = k;
                    if (!CheckForTheNextDirection(matrix, i, j))
                    {
                        break;
                    }

                    while (i + dx >= n || i + dx < 0 || j + dy >= n || j + dy < 0 || matrix[i + dx, j + dy] != 0)
                    {
                        ChangeDirection(ref dx, ref dy);
                    }
                    
                    i += dx;
                    j += dy;
                    k++;
                }
                dx = 1;
                dy = 1;
                k++;
            }

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write("{0,3}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
