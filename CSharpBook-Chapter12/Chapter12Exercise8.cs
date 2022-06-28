using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainFunc
{
    static void ReadNumber(int start, int end)
    {
        int count = 1, number;

        do
        {
            Console.Write("Number {0}: ", count);
            number = int.Parse(Console.ReadLine());

            if (number >= end || number <= start)
            {
                Console.WriteLine("Wrong input!");
                break;
            }
            else
            {
                start = number;
            }
            count++;
        } while (count < 11);
    }

    static void Main()
    {
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine());

        if (end <= start + 10)
        {
            Console.WriteLine("Wrong input");
        }
        else
        {
            ReadNumber(start, end);
        }
    }
}