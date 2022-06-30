//Write a program that checks whether the parentheses are placed 
//correctly in an arithmetic expression. Example of expression with 
//correctly placed brackets: ((a + b) / 5 - d).Example of an incorrect 
//expression: )(a + b)).

using System;
using System.Text;

class Exercise3
{
    public static bool validParenthesis(string input)
    {
        int countLeft = 0;
        int countRight = 0;
        bool isValid = false;
        char[] arr = new char[input.Length];
        arr = input.ToCharArray();
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '(')
            {
                countLeft++;
            } else if (arr[i] == ')')
            {
                countRight++;
            }
            if (countLeft == countRight)
            {
               return isValid = true;
            }
        }
        return isValid = false;
    }
}