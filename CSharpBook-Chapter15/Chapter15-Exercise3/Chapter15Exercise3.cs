using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class LineNumbers
{
    public static void Main()
    {
        string readFromFile = @"mergedfiles.txt";
        string writeIntoFile = @"numberedtxt.txt";
        StreamReader reader;
        StreamWriter writer, writerFirstLine;

        try
        {
            reader = new StreamReader(readFromFile, Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                writerFirstLine = new StreamWriter(writeIntoFile, false, Encoding.GetEncoding("UTF-8"));
                using (writerFirstLine)
                {
                    writerFirstLine.WriteLine(("1: " + reader.ReadLine()));
                }
                writer = new StreamWriter(writeIntoFile, true, Encoding.GetEncoding("UTF-8"));
                using (writer)
                {
                    string line = reader.ReadLine();
                    int i = 2;

                    while (line != null)
                    {
                        writer.WriteLine(String.Format("{0}: ", i) + line);
                        line = reader.ReadLine();
                        i++;
                    }
                }

            }
            Console.WriteLine("The lines are numbered.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error has occurred!", ex.Message);
        }
    }
}