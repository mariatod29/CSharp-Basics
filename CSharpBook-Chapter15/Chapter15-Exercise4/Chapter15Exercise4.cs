using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class LineCompare
{
    public static void Main()
    {
        string oddlines = @"oddlines.txt";
        string morelines = @"morelines.txt";
        StreamReader reader1, reader2;
        int different = 0;
        int equal = 0;

        try
        {
            reader1 = new StreamReader(oddlines, Encoding.GetEncoding("UTF-8"));
            reader2 = new StreamReader(morelines, Encoding.GetEncoding("UTF-8"));

            using (reader1)
            {
                using (reader2)
                {
                    while (true)
                    {
                        string line;
                        line = reader1.ReadLine();
                        if (line == null) break;
                        if (line.CompareTo(reader2.ReadLine()) == 0) equal++;
                        else different++;
                    }
                }
            }
            Console.WriteLine("There are {0} equal and {1} different lines.", equal, different);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error has occured!" + ex.Message);
        }
    }
}