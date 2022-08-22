using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMobiles
{
    public class OnePlus : IBuildMobile
    {
        public MobileRequirements specifications = new MobileRequirements();

        public void BuildDisplayResolution()
        {
            specifications.SetDisplayResolution("3168 * 1440");
        }

        public void BuildProcessor()
        {
            specifications.SetProcessor("Qualcomm Spandragon 865");
        }

        public void BuildRAM()
        {
            specifications.SetRAM(8);
        }

        public void BuildROM()
        {
            specifications.SetROM(128);
        }

        public MobileRequirements GetMobileRequirements()
        {
            return this.specifications;
        }
        
        public void BuildModelName()
        {
            specifications.SetModelName("One Plus 8 Pro");
        }
    }
}
