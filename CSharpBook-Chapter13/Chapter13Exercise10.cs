//Write a program that extracts from a text all sentences that contain 
//a particular word. We accept that the sentences are separated from 
//each other by the character "." and the words are separated from one 
//another by a character which is not a letter. Sample text:
//We are living in a yellow submarine. We don't have anything 
//else. Inside the submarine is very tight. So we are drinking 
//all the day. We will move out of it in 5 days.
//Sample result:
//We are living in a yellow submarine.
//We will move out of it in 5 days.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class Exercise10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insert the text and use the following command one after the other:\n ENTER, CTRL+Z, ENTER ");
        byte[] inputBuffer = new byte[2048];
        Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
        Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
        string text = Console.In.ReadToEnd();

        Console.Write("Insert the string to be looked for: ");
        string match = Console.ReadLine();

        string[] sentences = text.Split('.');
        Regex regex = new Regex(@"\W" + match + @"\W", RegexOptions.IgnoreCase);
        foreach (var item in sentences)
        {
            if (regex.IsMatch(item)) Console.WriteLine(item.Trim() + ".");
        }
    }
}
