using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Exercise26
{
    static void Main(String[] args)
    {
        Console.WriteLine("Insert the HTML text and push ENTER, CTRL+Z, ENTER");
        byte[] inputBuffer = new byte[2048];
        Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
        Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
        string html = Console.In.ReadToEnd();
        html = new string(html.Replace('\n', ' ').ToString().ToArray());
        html = new string(html.Replace('\r', ' ').ToString().ToArray());

        Regex rgxTitle = new Regex(@"(?<=<title>)\n*.*\n*(?=<\/title>)");
        string strTitle = rgxTitle.Match(html).ToString();
        Console.WriteLine(strTitle);

        Regex rgxBody = new Regex(@"(?<=<body>).*(?=<\/body>)");
        string completeBody = rgxBody.Match(html).ToString();
        Regex rgxNoTags = new Regex(@"(?<=>).*?(?=<)");
        MatchCollection matches = rgxNoTags.Matches(completeBody);

        foreach (var item in matches)
        {
            Console.WriteLine(item.ToString());
        }

    }
}