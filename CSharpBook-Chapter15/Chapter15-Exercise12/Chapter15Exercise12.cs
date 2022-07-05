using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class RemoveRepeatingWords
{
    public static void Main()
    {
        string inputFile = @"words.txt";
        string outputFile = @"text.txt";
        string backupFile = @"wordsBackup.txt";
        string listFile = @"listFile.txt";
        OutputRemoving(outputFile);
        try
        {
            StreamReader reader = new StreamReader(inputFile);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputFile, true);
                using (writer)
                {
                    for (string line; (line = reader.ReadLine()) != null;)
                    {
                        List<string> words = RemoveWords(listFile);
                        for (int wordsCount = 0; wordsCount < words.Count; wordsCount++)
                        {
                            line = NewLine(line, words[wordsCount]);
                        }
                        writer.WriteLine(line);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during deleting has occured: " + ex.Message);
        }
        ReplaceFiles(outputFile, inputFile, backupFile);
    }
    public static void OutputRemoving(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during file removing has occured!" + ex.Message);
        }
    }
    public static string NewLine(string chosenText, string chosenWord)
    {
        try
        {
            string newLine;
            newLine = Regex.Replace(chosenText, @"\b" + chosenWord + @"\b", "", RegexOptions.IgnoreCase);
            return newLine;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during correcting the word has occured: " + ex.Message);
        }
        return null;
    }
    public static void ReplaceFiles(string inputPath, string outputPath, string backupPath)
    {
        try
        {
            File.Replace(inputPath, outputPath, backupPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during replacing has occured!" + ex.Message);
        }
    }
    public static List<string> RemoveWords(string listFile)
    {
        try
        {
            List<string> words = new List<string>();
            StreamReader reader = new StreamReader(listFile);
            using (reader)
            {
                for (string line; (line = reader.ReadLine()) != null;) words.Add(line);
            }
            return words;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error has occured!" + ex.Message);
        }
        return null;
    }
}