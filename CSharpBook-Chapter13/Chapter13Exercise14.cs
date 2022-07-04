using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Exercise14
{
    public static void stringReverse(string input)
    {
        string[] arr = input.Split(" ");
        StringBuilder sb = new StringBuilder();

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            sb.Append(arr[i]);
        }
        Console.WriteLine(sb.ToString());
    }
}