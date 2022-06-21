using System;

class Exercise3
{
    public void Ex3()
    {
        bool equalArrays = true;
        char[] firstArray = new char[5] { 'a', 'b', 'c', 'd', 'e' };
        char[] secondArray = new char[5] { 'f', 'g', 'h', 'i', 'g' };

        if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("Second Array is lexicographically first.");
        }
        else if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("First Array is lexicographically first.");
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("First array is lexicographically first");
                    equalArrays = false;
                    break;
                }

                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("Second array is lexicographically first");
                    equalArrays = false;
                    break;
                }

            }
        if (equalArrays)
            {
                Console.WriteLine("Arrays are lexicographically equal.");
            }
        }
    }
}