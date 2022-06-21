using System;

class Exercise4
{
    public void Ex4()
    {
        int count = 1;
        int tempCount = 1;
        int number = 0;

        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter {0} element: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1]) {
                tempCount++;
            }
            else
            {
                tempCount = 1;
            }

            if (tempCount > count)
            {
                count = tempCount;
                number = array[i];
            }
        }
        for (int i = 0; i < count; i++)
        {
            Console.Write("{0} ", number);
        }
    }
}