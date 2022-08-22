using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class PizzaProvider : IPizza
    {
        public void GetNonVeggiePizza()
        {
            GetNonVeggieToppings();
            Console.WriteLine("Getting Non Veggie Pizza");
        }

        public void GetVeggiePizza()
        {
            Console.WriteLine("Getting Veggie Pizza");
        }

        private void GetNonVeggieToppings()
        {
            Console.WriteLine("Getting Non Veggie Pizza Toppings");
        }
    }
}
