using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryChairs
{
    public class ScandinavianFurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateCabinet()
        {
            return new ScandinavianCabinet();
        }
        public IFurniture CreateChair()
        {
            return new ScandinavianChair();
        }
        public IFurniture CreateDiningTable()
        {
            return new ScandinavianDiningTable();
        }
    }
}
