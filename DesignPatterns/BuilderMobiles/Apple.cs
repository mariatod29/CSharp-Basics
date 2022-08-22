using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMobiles
{
    public class Apple : IBuildMobile
    {
        public MobileRequirements Specifications = new MobileRequirements();

        public void BuildDisplayResolution()
        {
            Specifications.SetDisplayResolution("828 * 1792");
        }

        public void BuildProcessor()
        {
            Specifications.SetProcessor("Apple A13 Bionic");
        }

        public void BuildRAM()
        {
            Specifications.SetRAM(4);
        }

        public void BuildROM()
        {
            Specifications.SetROM(128);
        }

        public MobileRequirements GetMobileRequirements()
        {
            return this.Specifications;
        }

        public void BuildModelName()
        {
            Specifications.SetModelName("iPhone 11");
        }
    }
}
