using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class GooseHonk : IQuackBehavior
    {
        public string Quack()
        {
            return "Honk!";
        }
    }
}
