//Write a program, which creates an array of 20 elements of type integer
//and initializes each of the elements with a value equals to the index
//of the element multiplied by 5. Print the elements to the console.

using System;

class Exercise1
{
    public void Ex1()
    {
        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}