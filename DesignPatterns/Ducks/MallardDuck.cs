using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new BasicQuack(), new BasicFly())
        {

        }
    }
}
