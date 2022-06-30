//Write a program that reads a string from the console (20 characters 
//maximum) and if shorter complements it right with "*" to 20 characters.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Exercise7
{
    public static void Main()
    {
        try
        {
            Console.Write("Insert a string with maximum 20 chars: ");
            string str = Console.ReadLine();

            if (str.Length < 20)
            {
                str = new string(str.PadRight(20, '*').ToString().ToArray());
            }
            else throw new ArgumentException("The maximal length of the input is 20 characters.");
            Console.WriteLine(str);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}