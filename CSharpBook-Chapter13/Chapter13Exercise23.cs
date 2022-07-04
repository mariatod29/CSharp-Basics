using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
class Exercise23
{
    static void Main(String[] args)
    {
        Console.WriteLine("Insert a string: ");
        string str = Console.ReadLine();
        Regex word = new Regex(@"\b\w+\b");
        MatchCollection words = word.Matches(str);

        List<string> distinctWords = words.OfType<Match>().Select(m => m.Value).ToList().Distinct(StringComparer.CurrentCultureIgnoreCase).ToList();
        distinctWords.ForEach(m => Console.WriteLine("The word \"{0}\" repeats {1,3} times.", m, Regex.Matches(str, @"\b" + m + @"\b").Count));
    }
}