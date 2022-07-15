using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ReplaceSubstring
{
    public static void Main()
    {
        string line = String.Empty;
        string inputFile = @"startFile.txt";
        string outputFile = @"finishFile.txt";

        Console.WriteLine("Insert the substring:");
        string substring = Console.ReadLine().ToLower();
        Console.WriteLine("Insert the replacement:");
        string replacement = Console.ReadLine().ToLower();

        StreamReader reader;
        StreamWriter writer;

        reader = new StreamReader(inputFile, Encoding.UTF8);

        writer = new StreamWriter(outputFile, true, Encoding.UTF8);
        using (reader)
        {
            using (writer)
            {
                line = reader.ReadLine().ToLower();
                while (line != null)
                {
                    writer.WriteLine(line.Replace(substring, replacement));
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("The substring was succesfully replaced");
    }
}
}