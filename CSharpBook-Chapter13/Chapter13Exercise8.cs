using System;

class Exercise8
{
    static void Main(String[] args)
    {
        Console.Write("Insert the string: ");
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)str[i]);
        }
        Console.WriteLine();
    }
}