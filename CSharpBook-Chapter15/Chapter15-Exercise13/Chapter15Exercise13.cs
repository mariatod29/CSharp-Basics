using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using RemoveWordsFromListOfWordsClass;

class RemoveRepeatingWords
{
    public static void Main()
    {
        string wordsFile = @"words.txt";
        string textFile = @"text.txt";
        string resultFile = @"result.txt";

        string[] words = RemoveWordsFromListOfWordsClass.TakeWords(wordsFile).ToArray();
        int[] keys = new int[words.Length];

        try
        {
            for (int i = 0; i < words.Length; i++)
            {
                StreamReader reader = new StreamReader(textFile);
                using (reader)
                {
                    int occurencesCount = 0;
                    for (string line; (line = reader.ReadLine()) != null;)
                    {
                        occurencesCount += MatchesCount(line, words[i]);
                    }
                    keys[i] = occurencesCount;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during reading has occured: " + ex.Message);
        }
        try
        {
            Array.Sort(keys, words);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during sorting has occurred: " + ex.Message);
        }
        RemoveWordsFromListOfWordsClass.RemoveOutput(resultFile);

        FileWrite(resultFile, words, keys);
    }
    static int MatchesCount(string input, string word)
    {
        try
        {
            Regex regex = new Regex(@"\b" + word + @"\b", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(input);
            return matches.Count;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during matching has occurred: " + ex.Message);
            throw;
        }
    }
    static void FileWrite(string path, string[] words, int[] keys)
    {
        try
        {
            StreamWriter writer = new StreamWriter(path, true);
            using (writer)
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine(string.Format("{0,-5} {1}", keys[i], words[i]));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error during writing the result: " + ex.Message);
        }
    }
}