using System;

class Exercise13
{
    public void Ex13()
    {
        int row = 0, col = 0, sum = int.MinValue;

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        int[,] arr = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Arr [{0}][{1}]", i, j);
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int tempRow = 0; tempRow < arr.Length - 2; tempRow++)
        {
            for (int tempCol = 0; tempCol < arr.GetLength(0) - 2; tempCol++)
            {
                int tempSum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] +
                    arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2] +
                    arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];
               
                if (tempSum > sum)
                {
                    row = tempRow;
                    col = tempCol;
                    sum = tempSum;
                }
            }
        }
        Console.WriteLine("Result");
        Console.WriteLine("{0} {1} {2}", arr[row, col], arr[row, col + 1], arr[row, col + 2]);
        Console.WriteLine("{0} {1} {2}", arr[row + 1, col], arr[row + 1, col + 1], arr[row + 1, col + 2]);
        Console.WriteLine("{0} {1} {2}", arr[row + 2, col], arr[row + 2, col + 2], arr[row + 2, col + 2]);
        Console.WriteLine("The maximum sum is {0}.", sum);
    }
}
