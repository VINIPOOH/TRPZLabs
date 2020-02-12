using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dao
{
    class MotherboardDao
    {
        private int usingPover;
        private MotherboardTypes motherboardTypes;
        private RAMTypes rAMType;
        private CPUTypes cPUTypes;
        private CPUDao cpu = null;
        private RAMDao ram = null;

        public MotherboardDao(int usingPover, MotherboardTypes motherboardTypes, RAMTypes rAMType, CPUTypes cPUTypes, CPUDao cpu, RAMDao ram)
        {
            this.usingPover = usingPover;
            this.motherboardTypes = motherboardTypes;
            this.rAMType = rAMType;
            this.cPUTypes = cPUTypes;
            this.cpu = cpu;
            this.ram = ram;
        }
    }
}
