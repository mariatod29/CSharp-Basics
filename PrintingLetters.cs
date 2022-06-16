using System;
class PrintingLetter
{
    static void Main()
    {
        Console.Write("Enter a person's name: ");
        string person = Console.ReadLine();

        Console.Write("Enter a book's name: ");
        string book = Console.ReadLine();

        string from = "Authors team";

        Console.WriteLine("$    Dear {0}", person);
        Console.Write($"We are pleased to inform " + "you that \"{1}\" is the best Bulgarian book. {2}" + "The authors of the book wish you good luck {0}!{2}", person, book, Environment.NewLine);
        Console.WriteLine("  Yours,");
        Console.WriteLine($"  {from}");
    }