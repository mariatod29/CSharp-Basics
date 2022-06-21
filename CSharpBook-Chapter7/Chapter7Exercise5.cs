using System;

class Exercise5
{
    public void Ex5()
    {
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        int same = 1;
        int bestSame = 1;
        int bestStart = 0;
        int bestEnd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] + 1 == array[i + 1])
            {
                same++;

                if (same > bestSame)
                {
                    bestSame = same;
                    bestEnd = i + 1;
                    bestStart = bestEnd - bestSame + 1;
                }
            }
            else
            {
                same = 1;
            }
        }
        
        for (int j = bestStart; j < bestSame + bestStart; j++)
        {
            Console.Write("{0} ", array[j]);
        }
    }
}