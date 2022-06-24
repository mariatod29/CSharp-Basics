using System;

class Exercise2
{
    public static long CalcSum(params int[] elements)
    {
        long sum = 0;
        foreach(int element in elements)
        {
            sum += element;
        }
        return sum;
    }
}