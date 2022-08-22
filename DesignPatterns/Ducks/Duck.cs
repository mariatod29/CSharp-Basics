using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public abstract class Duck
    {
        private readonly IQuackBehavior quack;
        private readonly IFlyBehavior fly;
        

        public IQuackBehavior QuackBehavior { get; protected set; }
        public IFlyBehavior FlyBehavior { get; protected set; }

        public Duck(IQuackBehavior quack, IFlyBehavior fly)
        {
            this.quack = quack;
            this.fly = fly;
        }
        public string Quack()
        {
            return this.quack.Quack();
        }
        public string Fly()
        {
            return this.fly.Fly();
        }
    }
}
