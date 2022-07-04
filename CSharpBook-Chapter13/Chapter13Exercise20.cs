using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

class Exercise20
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Insert text and push ENTER, CTRL+Z, ENTER");
        byte[] inputBuffer = new byte[2048];
        Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
        Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
        string text = Console.In.ReadToEnd();

        Regex dates = new Regex(@"\b[0-9]{2}\.[0-9]{2}\.[\d]{4}\b", RegexOptions.IgnoreCase);

        MatchCollection matches = dates.Matches(text);
        foreach (var item in matches)
        {
            Console.WriteLine(DateTime.ParseExact(item.ToString(), "dd.MM.yyyy", CultureInfo.GetCultureInfo("bg-BG")).ToString("D", CultureInfo.GetCultureInfo("fr-CA")));
        }


    }
}