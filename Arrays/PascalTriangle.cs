﻿using System;

class PascalTriangle
{
    public void PascalTr()
    {
        const int height = 11;

        long[][] triangle = new long[height + 1][];

        for (int row = 0; row < height; row++)
        {
            triangle[row] = new long[row + 1];
        }
        triangle[0][0] = 1;

        for (int row = 0; row < height - 1; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                triangle[row + 1][col] += triangle[row][col];
                triangle[row + 1][col + 1] += triangle[row][col];
            }
        }
        for (int row = 0; row < height; row++)
        {
            Console.Write("".PadLeft((height - row) * 2));
            for (int col = 0; col <= row; col++)
            {
                Console.Write("{0,3} ", triangle[row][col]);
            }
            Console.WriteLine();
        }
    }
}