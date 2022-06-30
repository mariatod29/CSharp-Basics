//Write a program that reads a string, reverse it and prints it to the 
//console.For example: "introduction"  "noitcudortni".

using System;
using System.Text;

class Exercise1
{
    public void Main()
    {
        Console.Write("Write the string to be reversed: ");
        string str = Console.ReadLine();
        str = new string(str.Reverse().ToArray());
        Console.WriteLine("The reversed string: {0}", str);
    }
}