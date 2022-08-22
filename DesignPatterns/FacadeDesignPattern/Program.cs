using System;
using FacadeDesignPattern;

namespace FacadeDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVeggiePizza();
            facadeForClient.GetVeggiePizza();
            Console.WriteLine();
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }
    }
}