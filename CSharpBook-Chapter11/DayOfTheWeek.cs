using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DayOfTheWeek
{
    public static void Main()
    {
        DateTime today = DateTime.Today;
        Console.WriteLine(today.DayOfWeek);
    }
}