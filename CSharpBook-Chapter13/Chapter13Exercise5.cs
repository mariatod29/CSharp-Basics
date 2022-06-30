//Write a program that detects how many times a substring is contained in 
//the text. For example, let’s look for the substring "in" in the text:
//We are living in a yellow submarine. We don't have anything 
//else. Inside the submarine is very tight. So we are drinking 
//all the day. We will move out of it in 5 days.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Exercise5
{
    static void Main()
    {
        string substring = string.Empty;
        string str = string.Empty;

        Console.WriteLine("Insert the text: ");
        str = Console.ReadLine();
        Console.Write("Insert the substring: ");
        substring = Console.ReadLine().ToLower();

        Regex regex = new Regex(@"" + substring + @"", RegexOptions.IgnoreCase);
        MatchCollection subMatches = regex.Matches(str);
        Console.WriteLine("The result is: {0}", subMatches.Count);

    }
}