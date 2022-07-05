using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordsStartingWithTest
{
    public static void Main()
    {
        string inputFile = @"wordsWithTest.txt";
        string outputFile = @"wordsWithTestOutput.txt";
        string backupFile = @"wordswithTestBackup.txt";
        Console.Write("Insert the prefix: ");
        string prefix = Console.ReadLine();
        StreamReader reader;
        StreamWriter writer;
        try
        {
            reader = new StreamReader(inputFile, Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                if (File.Exists(outputFile)) File.Delete(outputFile);
                writer = new StreamWriter(outputFile, true, Encoding.GetEncoding("UTF-8"));
                using (writer)
                {
                    for (string line; (line = reader.ReadLine()) != null;)
                    {
                        writer.WriteLine(Regex.Replace(line, @"\b" + prefix + @"[0-9a-zA-Z_-_]*", "", RegexOptions.IgnoreCase), true);
                    }
                }
            }
            File.Replace(outputFile, inputFile, backupFile);
            Console.WriteLine("The prefix is successfully removed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during deleting has occured: " + ex.Message);
        }
    }
}