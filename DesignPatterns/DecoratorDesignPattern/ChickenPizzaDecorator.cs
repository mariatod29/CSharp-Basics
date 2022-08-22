using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return pizza.MakePizza() + AddChicken();
        }

        private string AddChicken()
        {
            return ", Chicken added";
        }
    }
}
