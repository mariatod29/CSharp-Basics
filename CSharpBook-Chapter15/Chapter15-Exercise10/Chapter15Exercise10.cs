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
        bool IsTagged = true;

        StreamReader reader = new StreamReader(xml);
        using (reader)
        {
            StreamWriter writer = new StreamWriter(output, false);
            using (writer)
            {
                StringBuilder build = new StringBuilder();
                line = reader.ReadLine();
                for (string line; line != null;)
                {
                    string lastElement = String.Empty;
                    foreach (var tag in line.ToList())
                    {
                        if (tag.ToString() == "<")
                        {
                            if (IsTagged == false && lastElement != ">")
                            {
                                build.AppendLine();
                            }
                            lastElement = tag.ToString();
                            IsTagged = true;
                            continue;
                        }
                        if (tag.ToString() == ">")
                        {
                            lastElement = tag.ToString();
                            IsTagged = false;
                            continue;
                        }
                        if (IsTagged == false)
                        {
                            build.Append(item);
                        }
                        lastElement = tag.ToString();
                    }
                }
                writer.WriteLine(build.ToString());
            }

        }
        Console.WriteLine("The data was extracted.");
    }
}
}