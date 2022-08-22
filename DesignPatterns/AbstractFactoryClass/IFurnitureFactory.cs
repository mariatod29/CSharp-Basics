using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryChairs
{
    public interface IFurnitureFactory
    {
        IFurniture CreateCabinet();
        IFurniture CreateChair();
        IFurniture CreateDiningTable();
    }
}
