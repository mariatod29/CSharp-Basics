using System;
using Ducks;
namespace Ducks
{
    public class Program
    {
        static void Main()
        {
            MallardDuck mallardDuck1 = new MallardDuck();
            Console.WriteLine(mallardDuck1.Fly());
            MallardDuck mallardDuck2 = new MallardDuck();
            Console.WriteLine(mallardDuck2.Quack());

            Goose goose1 = new Goose();
            Console.WriteLine(goose1.Quack());
            Goose goose2 = new Goose();
            Console.WriteLine(goose2.Fly());

            RubberDuck rubberDuck1 = new RubberDuck();
            Console.WriteLine(rubberDuck1.Quack());
            RubberDuck rubberDuck2 = new RubberDuck();
            Console.WriteLine(rubberDuck2.Fly());

            RocketDuck5000 firstRocketDuck5000 = new RocketDuck5000();
            Console.WriteLine(firstRocketDuck5000.Quack());
            RocketDuck5000 secondRocketDuck5000 = new RocketDuck5000();
            Console.WriteLine(secondRocketDuck5000.Fly());

        }
    }
}