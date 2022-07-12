using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class NumbersInStringSum
{
    public static void Main()
    {
        Console.WriteLine("Insert a string with positive integers, separated by spaces:");
        string str = Console.ReadLine();
        int sumOfIntegers = 0;
        string[] arr = str.Split(" ");
        foreach(var integer in arr)
        {
            sumOfIntegers += int.Parse(integer);
        }
        Console.WriteLine("The sum of the integers is: {0}", sumOfIntegers);
    }
}