using System;
using DecoratorDesignPattern;

namespace DecoratorDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlainPizza plainPizza = new PlainPizza();
            string plainPizz = plainPizza.MakePizza();
            Console.WriteLine(plainPizz);

            PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizza);
            string chickenPizza = chickenPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");

            VeggiePizzaDecorator veggiePizzaDecorator = new VeggiePizzaDecorator(plainPizza);
            string veggiePizza = veggiePizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + veggiePizza + "' using VeggiePizzaDecorator");

            Console.Read();
        }
    }
}