using System;

class Exercise5
{
    public static double Power(double number, int power)
    {
        double result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
}