using System;

class Examples
{
    public void Expressions()
    {
        int first = 5;
        int second = 3;

        if (first == second)
        {
            Console.WriteLine("These two numbers are equal.");
        }
        else
        {
            if (first > second)
            {
                Console.WriteLine("The first number is greater.");
            }
            else
            {
                Console.WriteLine("The second number is greater");
            }
        }
    }
    
}

