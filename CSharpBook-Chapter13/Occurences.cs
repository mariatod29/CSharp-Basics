﻿using System;

class Occurences
{
    public void Occur()
    {
        string quote = "The main intent of the \"Intro C#\"" + " book is to introduce the C# programming to newbies.";
        string keyword = "C#";
        int index = quote.IndexOf(keyword);

        while(index != -1)
        {
            Console.WriteLine("{0} found at index: {1}", keyword, index);
            index = quote.IndexOf(keyword, index + keyword.Length);
        }
    }
}