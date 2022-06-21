using System;

class Exercise11
{
    public void Ex11()
    {
        int sum = 0, start = 0, end = 0;
        bool foundSum = false;

        Console.Write("Enter S: ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];

        for(int i = 0; i < length; i++)
        {
            Console.Write("Enter {0} element: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < length - 1; i++)
        {
            sum = arr[i];

            for(int j = i + 1; j < length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    start = i;
                    end = j;
                    foundSum = true;
                    break;
                }
            }
        if (foundSum)
            {
                break;
            }
        }
        if (foundSum)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
        else
        {
            Console.WriteLine("No sum found.");
        }
    }
}
