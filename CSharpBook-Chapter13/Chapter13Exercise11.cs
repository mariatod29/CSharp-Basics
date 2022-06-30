//A string is given, composed of several "forbidden" words separated by 
//commas.Also a text is given, containing those words. Write a program 
//that replaces the forbidden words with asterisks. Sample text:
//Microsoft announced its next generation C# compiler today. 
//It uses advanced parser and special optimizer for the 
//Microsoft CLR.
//Sample string containing the forbidden words: "C#,CLR,Microsoft".
//Sample result:
//*********announced its next generation ** compiler today. 
//It uses advanced parser and special optimizer for the 
//********* ***.


using System;
using System.IO;
using System.Linq;

class Exercise11
{
    public static void Main()
    {
        Console.WriteLine("Insert the text. \nUse ENTER, CTRL+Z, ENTER to confirm that the input finished!");
        byte[] inputBuffer = new byte[2048];
        Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
        Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
        string text = Console.In.ReadToEnd();
        Console.WriteLine("Insert the list of forbidden words, separated by ',' ");
        string forbiddenList = Console.ReadLine();
        string[] forbiddenStrings = forbiddenList.Split(',');
        foreach (var item in forbiddenStrings)
        {
            text = new string(text.Replace(item, String.Empty.PadRight(item.Length, '*')).ToString().ToArray());
        }
        Console.WriteLine(text);
    }
}