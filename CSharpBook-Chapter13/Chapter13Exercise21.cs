using System;
using System.Linq;
using System.Text;

class Exercise21
{
    public static void PalindromeCheck()
    {
        string str = Console.ReadLine();
        string reversed;
        char[] ch = str.ToCharArray();
        Array.Reverse(ch);
        reversed = new string(ch);
        bool check = str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        if (check == true)
        {
            Console.Write("{0} is a Palindrome!", str);
        }
        else
        {
            Console.Write("{0} is not a Palindrome!", str);
        }
        Console.WriteLine();
    }
}