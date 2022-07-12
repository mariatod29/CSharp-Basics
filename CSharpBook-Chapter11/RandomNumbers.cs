using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RandomNumbers
{
    public static void Main()
    {
        Random numbers = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numbers.Next(100, 200));
        }
    }
}