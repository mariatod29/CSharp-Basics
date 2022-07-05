using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class ListOfNames
{
    public static void Main()
    {
        try
        {
            string inputFile = @"names1.txt";
            string outputFile = @"names2.txt";
            List<string> list = ReadFile(inputFile);
            list.Sort();
            WriteFile(outputFile, list);
            Console.WriteLine("The new list is ready.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during the execution has occured: " + ex.Message);
        }
    }
    static List<string> ReadFile(string path)
    {
        List<string> list = new List<string>();
        StreamReader reader;
        try
        {
            reader = new StreamReader(path, Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = reader.ReadLine();
                }
            }
            return list;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during the reading of the file has occured: " + ex.Message);
        }
        return null;
    }
    static void WriteFile(string path, List<string> list)
    {
        StreamWriter writer;
        try
        {
            writer = new StreamWriter(path, false, Encoding.GetEncoding("UTF-8"));
            using (writer)
            {
                foreach (var item in list)
                {
                    writer.WriteLine(item);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during the writing of the file has occured: " + ex.Message);
        }
    }
}