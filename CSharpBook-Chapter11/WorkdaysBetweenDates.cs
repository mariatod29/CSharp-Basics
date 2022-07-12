using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WorkdaysBetweenDates
{
    public static void Main()
    {
        List<DateTime> holidays = new List<DateTime>();
        Random randomCount = new Random();
        int holidaysCount = randomCount.Next(30, 80);
        for (int i  = 0; i < holidaysCount; i++)
        {
            holidays.Add(RandomDate());
        }
        holidays.Sort();

        Console.WriteLine("Holidays' list in the next 5 years:");
        foreach(DateTime date in holidays)
        {
            Console.WriteLine("{0,25} {1}", date, date.DayOfWeek);
        }
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        int weekendHolidays = 0;

        List<DateTime> allHolidays = new List<DateTime>();
        foreach(DateTime date in holidays)
        {
            if (date <= endDate && date > DateTime.Today)
            {
                allHolidays.Add(date);

                if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekendHolidays++;
                }
            }
        }
        int difference = endDate.Subtract(DateTime.Today).Days;
        int weeks = difference / 7;
        int daysOnTheWeekend = weeks * 2;
        for (int i = 1; i <= difference % 7; i++)
        {
            if (DateTime.Today.AddDays(difference - difference % 7 + i).DayOfWeek == DayOfWeek.Saturday ||
                DateTime.Today.AddDays(difference - difference % 7 + i).DayOfWeek == DayOfWeek.Sunday)
            {
                daysOnTheWeekend++;
            }
        }
        int allWorkdays = difference - allHolidays.Count + weekendHolidays - daysOnTheWeekend;
        Console.WriteLine("The workdays in this period are {0}. The day period is from {1:d} to {2:d}.",allWorkdays, DateTime.Today, endDate);
    }
    static Random random = new Random();
    static DateTime RandomDate()
    {
        DateTime end = new DateTime(2022, 03, 23);
        int interval = (end - DateTime.Today).Days;
        return DateTime.Today.AddDays(random.Next(interval));
    }
}