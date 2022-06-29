using System;
using System.Text;

class GettingUpper
{
    public static string ExtractCapitals(string str)
    {
        StringBuilder result = new StringBuilder();

        for(int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (char.IsUpper(ch))
            {
                result.Append(ch);
            }
        }
        return result.ToString();
    }
}