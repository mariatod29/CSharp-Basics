using System;

class Exercise3 {
    public void PrintNumbers(int intValue, float floatValue)
    {
        Console.WriteLine(intValue + "; " + floatValue);
    }

    public void PrintNumbers(float floatValue, int intValue)
    {
        Console.WriteLine(floatValue + "; " + intValue);
    }
}