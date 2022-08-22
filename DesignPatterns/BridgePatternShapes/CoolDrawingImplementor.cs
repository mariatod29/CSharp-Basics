using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternShapes
{
    public class CoolDrawingImplementor : DrawingImplementor
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing is cool!");
        }
    }
}
