using System;

class Exercise7
{
    public void Ex7()
    {
        int sum = 0;
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K (K < N): ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter {0} element: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr,(a,b) => b.CompareTo(a));

        for(int i = 0; i < k; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Biggest sum is {0}", sum);
    }
}