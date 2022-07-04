using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

class Exercise16
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a date and time: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.GetCultureInfo("bg-BG"));
        TimeSpan dateTimeDiff = new TimeSpan(6, 30, 0);
        Console.WriteLine((firstDate - dateTimeDiff).ToString("dd.MM.yyyy HH:mm:ss", CultureInfo.GetCultureInfo("bg-BG")));
    }
}