using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMobiles
{
    public interface IMobileRequirements
    {
        void SetModelName(string modelName);
        void SetProcessor(string processor);
        void SetDisplayResolution(string displayResolution);
        void SetRAM(int RAM);
        void SetROM(int ROM);
    }
}
