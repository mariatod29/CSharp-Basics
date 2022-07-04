using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

class Exercise16
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Insert the text and confirm with ENTER, CTRL+Z, ENTER");
        byte[] inputBuffer = new byte[2048];
        Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
        Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
        string html = Console.In.ReadToEnd();

        html = html.Replace("< ahref=\"", "[URL=");
        html = html.Replace("\">", "]");
        html = html.Replace("</a>", "[/URL]");
        Console.WriteLine(html);
    }
}