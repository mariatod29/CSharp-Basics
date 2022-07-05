using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class DeleteOddLinesClass
{

    static void Main(string[] args)
    {
        string inputFile = @"deletingOddLines.txt";
        string outputFile = @"deletedLines.txt";
        string backupFile = @"backup.txt";
        StreamReader reader;
        StreamWriter writer;
        try
        {

            reader = new StreamReader(inputFile);
            using (reader)
            {
                writer = new StreamWriter(outputFile, false);
                using (writer)
                {
                    for (string line; (line = reader.ReadLine()) != null;)
                    {
                        writer.WriteLine(reader.ReadLine());
                    }
                }
            }
            File.Replace(outputFile, inputFile, backupFile);
            Console.WriteLine("The odd line are deleted");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occured during operation. " + ex.Message);
        }
    }
}
