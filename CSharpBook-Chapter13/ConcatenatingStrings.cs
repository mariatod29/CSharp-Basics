﻿using System;
using System.Text;

class MainFunc
{
    public static void Main()
    {
        Console.WriteLine(DateTime.Now);

        StringBuilder sb = new StringBuilder();
        sb.Append("Numbers: ");

        for (int index = 1; index <= 200000; index++)
        {
            sb.Append(index);
        }
        Console.WriteLine(sb.ToString().Substring(0, 1024));
        Console.WriteLine(DateTime.Now);
    }
}