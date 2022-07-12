using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LeapYear
{
    public static void Main(string[] args)
    {
        Console.Write("Give a year to be checked: ");
        DateTime date = DateTime.Parse("01.01." + Console.ReadLine());
        if (DateTime.IsLeapYear(date.Year))
        {
            Console.WriteLine("The year {0} is leap.", date.Year);
        }
        else
        {
            Console.WriteLine("The year {0} isn't leap.", date.Year);
        }
    }
}