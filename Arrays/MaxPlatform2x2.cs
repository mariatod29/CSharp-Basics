using System;

class MaxPlatform2x2
{
    public void MaxPlatform()
    {
        int[,] matrix = { { 0, 2, 4, 0, 9, 5 }, { 7, 1, 3, 3, 2, 1 }, { 1, 3, 9, 8, 5, 6 }, { 4, 6, 7, 9, 1, 0 } };

        int bestSum = int.MinValue;
        int bestrow = 0;
        int bestcol = 0;

        for(int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestrow = row;
                    bestcol = col;
                }
            }
        }
        Console.WriteLine("The best platform is:");
        Console.WriteLine("  {0} {1}", matrix[bestrow, bestcol], matrix[bestrow, bestcol + 1]);
        Console.WriteLine("  {0} {1}", matrix[bestrow + 1, bestcol], matrix[bestrow + 1, bestcol + 1]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}