using System;
using System.Text;
using System.IO;

class OddLines
{
    static void Main()
    {
        const string inputFile = "oddlines.txt";
        StreamReader reader = new StreamReader(inputFile);

        try
        {
            reader = new StreamReader(inputFile, Encoding.GetEncoding("UTF-8"));
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    reader.ReadLine();
                    line = reader.ReadLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An exception occured!" + ex.Message);
        }
    }
}