using System;

class Chapter12Ex1
{
    public static void ReadFile(string filename)
    {
        try
        {
            TextReader reader = new StreamReader(filename);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine("The file '{0}' is not found.", filename);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.StackTrace);
        }
    }
}