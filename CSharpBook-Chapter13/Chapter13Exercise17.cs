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
        try
        {
            Console.Write("Enter the first date: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.GetCultureInfo("bg-BG"));
            Console.Write("Enter the second date: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.GetCultureInfo("bg-BG"));
            int timeDiff = Math.Abs((secondDate - firstDate).Days);
            Console.WriteLine("Distance: {0} days", timeDiff);
        }
        catch (FormatException)
        {
            Console.WriteLine("String in format \"d.MM.yyyy\" expected.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception occured: " + ex.Message);

        }
    }
}