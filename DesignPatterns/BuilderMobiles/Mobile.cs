using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMobiles
{
    public class Mobile
    {
        public IBuildMobile CellPhone;
        public Mobile(IBuildMobile cellPhone)
        {
            this.CellPhone = cellPhone;
        }

        public MobileRequirements GetMobile()
        {
            return CellPhone.GetMobileRequirements();
        }

        public void AssembleMobile()
        {
            this.CellPhone.BuildModelName();
            this.CellPhone.BuildDisplayResolution();
            this.CellPhone.BuildProcessor();
            this.CellPhone.BuildRAM();
            this.CellPhone.BuildROM();
        }
    }
}
