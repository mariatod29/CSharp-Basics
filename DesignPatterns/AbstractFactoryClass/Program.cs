using System;
using AbstractFactoryChairs;

namespace AbstractFactoryChairs
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1) Classic");
                Console.WriteLine("2) Contemporary");
                Console.WriteLine("3) Scandinavian");
                Console.WriteLine("Please select your furniture style:");
                int.TryParse(Console.ReadLine(), out style);
            } while (style == 0 || style > 3);

            IFurnitureFactory Factory = null;
            switch (style)
            {
                case 1:
                    Factory = new ClassicFurnitureFactory();
                    break;
                case 2:
                    Factory = new ContemporaryCabinet();
                    break;
                case 3:
                    Factory = new ScandinavianFurnitureFactory();
                    break;
            }
            do
            {

            }
        }
    }
}