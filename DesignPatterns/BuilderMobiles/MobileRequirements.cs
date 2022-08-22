using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMobiles
{
    public class MobileRequirements : IMobileRequirements
    {
        public string ModelName { get; set; }
        public string Processor { get; set; }
        public string DisplayResolution { get; set; }
        public int RAM { get; set; }
        public int ROM { get; set; }

        public void SetDisplayResolution(string resolution)
        {
            this.DisplayResolution = resolution;
        }

        public void SetModelName(string modelName)
        {
            this.ModelName = modelName;
        }

        public void SetProcessor(string processor)
        {
            this.Processor = processor;
        }

        public void SetRAM(int RAM)
        {
            this.RAM = RAM;
        }

        public void SetROM (int ROM)
        {
            this.ROM = ROM;
        }
    }
}
