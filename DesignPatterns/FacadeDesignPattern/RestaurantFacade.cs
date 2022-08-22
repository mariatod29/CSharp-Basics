using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class RestaurantFacade
    {
        private IPizza _PizzaProvider;
        private IBread _BreadProvider;
        public RestaurantFacade()
        {
            _PizzaProvider = new PizzaProvider();
            _BreadProvider = new BreadProvider();
        }

        public void GetNonVeggiePizza()
        {
            _PizzaProvider.GetNonVeggiePizza();
        }

        public void GetVeggiePizza()
        {
            _PizzaProvider.GetVeggiePizza();
        }

        public void GetGarlicBread()
        {
            _BreadProvider.GetGarlicBread();
        }

        public void GetCheesyGarlicBread()
        {
            _BreadProvider.GetCheesyGarlicBread();
        }
    }
}
