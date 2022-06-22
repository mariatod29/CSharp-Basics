using System;

class Exercise12c
{
    public void Ex12c()
    {
        Console.Write("Enter array size: ");
        int lenght = int.Parse(Console.ReadLine());

        int[,] arr = new int[lenght, lenght];
        arr[lenght - 1, 0] = 1;
        int counter = 1;

        for (int row = lenght - 2; row >= 0; row--)
        {
            arr[row, 0] = arr[row + 1,0 ] + counter;
            int newRow = row;

            for(int diagonal = 1; diagonal <= counter; diagonal++)
            {
                arr[newRow + 1, diagonal] = arr[newRow, diagonal - 1] + 1;
                newRow++;
            }
            counter++;
        }
        arr[0, lenght - 1] = lenght * lenght;
        int diagonalLenght = 2;
        int posX = 1;
        int posY = lenght - 1;
        int prevX = 0;
        int prevY = lenght - 1;

        for (int i = 1; i < counter - 1; i++)
        {
            for (int j = 1; j <= diagonalLenght; j++)
            {
                arr[posX, posY] = arr[prevX, prevY] - 1;
                prevX = posX;
                prevY = posY;
                posX--;
                posY--;
            }
            diagonalLenght++;
            posX = i + 1;
            posY = lenght - 1;
        }
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0, 4}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}