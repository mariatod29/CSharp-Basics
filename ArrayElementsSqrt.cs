using System;

class ArrayElSqrt { 
    public void ArraySqrt()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.Write("Output: ");
        for(int index = 0; index < array.Length; index += 2)
        {
            array[index] = array[index] * array[index];
            Console.Write(array[index] + " ");
        }
    }
}