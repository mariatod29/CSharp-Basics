using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ConcatenateTwoFiles
{
    static void Main()
    {
        string oddLinesFile = @"oddlines.txt";
        string moreLinesFile = @"morelines.txt";
        string concatenated = @"mergedfiles.txt";
        StreamReader reader1, reader2;
        StreamWriter writer;

        try
        {
            reader1 = new StreamReader(oddLinesFile, Encoding.GetEncoding("UTF-8"));
            reader2 = new StreamReader(moreLinesFile, Encoding.GetEncoding("UTF-8"));
            writer = new StreamWriter(concatenated, false, Encoding.GetEncoding("UTF-8"));

            using (reader1)
            {
                using (reader2)
                {
                    using (writer)
                    {
                        writer.WriteLine(reader1.ReadToEnd() + "\n" + reader2.ReadToEnd());
                    }
                }
            }
            Console.WriteLine("The files are merged.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error has occured!", ex.Message);
        }
    }
}