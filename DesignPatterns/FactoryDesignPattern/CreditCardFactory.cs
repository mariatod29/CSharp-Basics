using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
