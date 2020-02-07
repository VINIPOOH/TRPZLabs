using Lab1.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    class Motherboard : ElectronicСomponent
    {
        private RAMTypes rAMType;
        private CPUTypes cPUTypes;
        private CPU cpu;
        private RAM ram;

        public Motherboard(RAMTypes rAMType, CPUTypes cPUTypes, CPU cpu, RAM ram)
        {
            this.rAMType = rAMType;
            this.cPUTypes = cPUTypes;
            this.cpu = cpu;
            this.ram = ram;
        }
    }
}
