using System;

class Exercise15
{
    static void Main(String[] args)
    {
        string dictPath = @"..\\..\\Dict.txt";
        IDictionary<string, string> dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        using (StreamReader sr = new StreamReader(dictPath, Encoding.GetEncoding("UTF-8")))
        {
            Regex key = new Regex(@".*(?=\s.{1}\s)", RegexOptions.IgnoreCase);
            Regex val = new Regex(@"(?=\s.{1}\s).*", RegexOptions.IgnoreCase);
            string line = sr.ReadLine();
            while (line != null)
            {
                dict.Add(key.Match(line).ToString(), val.Match(line).ToString());
                line = sr.ReadLine();
            }
        }
        string value;
        Console.Write("Insert the word to be translated: ");
        dict.TryGetValue(Console.ReadLine(), out value);
        Console.WriteLine(" - {0}", value);
    }
}
