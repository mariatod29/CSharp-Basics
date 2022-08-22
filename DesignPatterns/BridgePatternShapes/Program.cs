using System;
using BridgePatternShapes;

namespace BridgePatternShapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hotImplementation = new HotDrawingImplementor();
            var coolImplementation = new CoolDrawingImplementor();

            var hotRectangle = new Rectangle(hotImplementation);
            var coolRectangle = new Rectangle(coolImplementation);

            hotRectangle.Draw();
            coolRectangle.Draw();

            Console.ReadKey(true);
        }
    }
}