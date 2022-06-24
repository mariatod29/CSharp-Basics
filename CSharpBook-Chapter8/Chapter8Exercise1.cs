using System;

class Exercise1
{
    public static void PrintTotalAmountForBooks(decimal[] prices)
    {
        decimal totalAmount = 0;
        foreach (decimal singleBookPrice in prices)
        {
            totalAmount += singleBookPrice;
        }
        Console.WriteLine("The total amount of all books is: " + totalAmount);
    }
}