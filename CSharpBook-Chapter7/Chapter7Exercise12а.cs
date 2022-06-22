using System;

class Exercise12а
{
    public void Ex12а()
    {
        Console.Write("Enter height: ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        int x = int.Parse(Console.ReadLine());

        int a = 0;

        for (int i = 1; i <= y; i++)
        {
            Console.Write("{0} ", i);

            a += i;
            
            for(int j = 1; j < x; j++)
            {
                a += y;
                Console.Write("{0} ", a);
            }
            a = 0;
            Console.WriteLine();
        }

    }
}