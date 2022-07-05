using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class XMLFileExtract
{
    public static void Main()
    {
        string xml = @"xml.txt";
        string output = @"xmlOutput.txt";
        StreamReader reader;
        StreamWriter writer;
        bool IsTagged = true;
        try
        {
            reader = new StreamReader(xml);
            using (reader)
            {
                writer = new StreamWriter(output, false);
                using (writer)
                {
                    StringBuilder build = new StringBuilder();
                    for (string line; (line = reader.ReadLine()) != null;)
                    {
                        string last = String.Empty;
                        foreach (var item in line.ToList())
                        {
                            if (item.ToString() == "<")
                            {
                                if (IsTagged == false && last != ">") build.AppendLine();
                                IsTagged = true;
                                last = item.ToString();
                                continue;
                            }
                            if (item.ToString() == ">")
                            {
                                IsTagged = false;
                                last = item.ToString();
                                continue;
                            }
                            if (IsTagged == false)
                            {
                                build.Append(item);
                            }
                            last = item.ToString();
                        }
                    }
                    writer.WriteLine(build.ToString());
                }

            }
            Console.WriteLine("The data was extracted.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An exception during the removing the tags has occured: " + ex.Message);
        }
    }
}