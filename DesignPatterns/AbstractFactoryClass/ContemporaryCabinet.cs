using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryChairs
{
    public class ContemporaryCabinet : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I am used for storing item");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I am a Contemporary cabinet");
        }
    }
}
