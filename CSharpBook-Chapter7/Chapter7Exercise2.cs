using System;

class Exercise2
{
    public void Ex2()
    {
        bool equalArrays = true;

        Console.Write("Enter length of the first array:");
        int length = int.Parse(Console.ReadLine());

        int[] firstArray = new int[length];

        for(int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("Enter element {0}: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter length of second array: ");

        if (length != int.Parse(Console.ReadLine()))
        {
            Console.WriteLine("Arrays have different lengths.");
        }
        else
        {
            int[] secondArray = new int[length];

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine("Arrays are different.");
                    equalArrays = false;
                    break;
                }
            }
            if (equalArrays)
            {
                Console.WriteLine("Arrays are the same.");
            }
        }

    }
}