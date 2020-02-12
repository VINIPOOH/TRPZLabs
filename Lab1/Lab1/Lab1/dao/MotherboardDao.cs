using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dao
{
    public class MotherboardDao
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

        public int UsingPover { get => usingPover; set => usingPover = value; }
        public CPUTypes CPUTypes { get => cPUTypes; set => cPUTypes = value; }
        
        internal MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        internal RAMTypes RAMType { get => rAMType; set => rAMType = value; }
        internal CPUDao Cpu { get => cpu; set => cpu = value; }
        internal RAMDao Ram { get => ram; set => ram = value; }
        
    }
}
