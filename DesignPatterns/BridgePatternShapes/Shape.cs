using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternShapes
{
    public abstract class Shape
    {
        protected DrawingImplementor implementor;

        public Shape(DrawingImplementor implementor)
        {
            this.implementor = implementor;
        }
        
        public void Draw()
        {
            implementor.Draw();
        }
    }
}
