//Write a program that encrypts a text by applying XOR (excluding or) 
//operation between the given source characters and given cipher code. 
//The encryption should be done by applying XOR between the first letter 
//of the text and the first letter of the code, the second letter of the text 
//and the second letter of the code, etc. until the last letter of the code,
//then goes back to the first letter of the code and the next letter of the 
//text. Print the result as a series of Unicode escape characters \xxxx.
//Sample source text: "Test".Sample cipher code: "ab".The result should 
//be the following: "\u0035\u0007\u0012\u0016".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Exercise9
{
    public static void Main()
    {
        Console.Write("Insert the string to be encoded: ");
        string text = Console.ReadLine();
        Console.WriteLine("Insert the key: ");
        string key = Console.ReadLine();
        string encoded = EncodeDecodeString(text, key);
        Console.WriteLine("The encoded string looks like: {0}", encoded);
        Console.WriteLine("The decoded string looks like: {0}", EncodeDecodeString(encoded, key));
    }

    private static string EncodeDecodeString(string str, string key)
    {
        string encoded;
        StringBuilder sb = new StringBuilder();
        int i, j;

        for (i = 0, j = 0; i < str.Length; i++, j++)
        {
            sb.Append((char)(str[i] ^ key[j]));
            if (j == key.Length - 1) j = -1;
        }
        encoded = sb.ToString();
        return encoded;
    }
}