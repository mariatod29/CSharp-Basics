using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Exercise24
{
    static void Main(String[] args)
    {
        Console.WriteLine("Insert a string: ");
        string str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            if (!char.IsLetter(str[i])) continue;
            else
            {
                if (i > 0)
                {
                    if (str[i] != str[i - 1])
                    {
                        Console.Write(str[i]);
                        continue;
                    }
                }
                else
                {
                    Console.Write(str[i]);
                }
            }
            Console.WriteLine();
        }
    }
}