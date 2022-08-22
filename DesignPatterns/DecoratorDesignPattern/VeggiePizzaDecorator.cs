using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class VeggiePizzaDecorator : PizzaDecorator
    {
        public VeggiePizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetables();
        }

        private string AddVegetables()
        {
            return ", Vegetables added";
        }
    }
}
