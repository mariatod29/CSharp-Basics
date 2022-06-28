using System;
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
            using (StreamReader sr = new StreamReader(@"C:\Users\mtodorova\Desktop\text.txt"))
            {
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine("The specified path is invalid!");
        }
        catch (IOException e)
        {
            Console.WriteLine("Invalid syntax!");
        }
    }
}