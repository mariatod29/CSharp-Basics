using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class RoboFly : IFlyBehavior
    {
        public string Fly()
        {
            return "The rocket is activated!";
        }
    }
}
