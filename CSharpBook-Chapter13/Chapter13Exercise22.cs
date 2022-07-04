using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class Exercise22
{
    static void Main(String[] args)
    {
        Console.WriteLine("Insert a string: ");
        string str = Console.ReadLine().ToLower();
        List<char> distinctLetters = new List<char>();
        distinctLetters = str.Distinct().ToList();

        char letter;
        foreach (var item in distinctLetters)
        {
            letter = char.Parse(item.ToString());
            if (Char.IsLetter(letter))
            {
                Regex character = new Regex(letter.ToString(), RegexOptions.IgnoreCase);
                Console.WriteLine("The letter {0} is found {1,3} times.", letter, character.Matches(str).Count);
            }
        }
    }
}