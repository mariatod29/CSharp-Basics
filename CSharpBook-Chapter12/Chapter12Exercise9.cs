﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainFunc
{
    static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader("TestFile.txt"))
            {
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}