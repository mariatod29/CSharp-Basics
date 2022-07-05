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
        Console.WriteLine("Insert the substring to be replaced:");
        string substring = Console.ReadLine().ToLower();
        Console.WriteLine("Insert the replacement substring:");
        string replacement = Console.ReadLine().ToLower();
        StreamReader reader;
        StreamWriter writer;
        try
        {
            reader = new StreamReader(inputFile, Encoding.GetEncoding("UTF-8"));

            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }
            writer = new StreamWriter(outputFile, true, Encoding.GetEncoding("UTF-8"));
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
        catch (Exception ex)
        {
            Console.WriteLine("An error during replacing has occured: " + ex.Message);
        }
    }
}