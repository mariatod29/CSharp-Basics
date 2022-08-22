using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMobiles
{
    public interface IBuildMobile
    {
        void BuildModelName();
        void BuildProcessor();
        void BuildDisplayResolution();
        void BuildRAM();
        void BuildROM();
        MobileRequirements GetMobileRequirements();
    }
}
