using System;

class Exercise4
{
    public static void PrintLine(int start, int end)
    {
        for(int i = start; i <= end; i++)
        {
            Console.Write(" " + i);
        }
        Console.WriteLine();
    }
}