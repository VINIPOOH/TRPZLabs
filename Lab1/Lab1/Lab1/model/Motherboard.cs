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
        private MotherboardTypes motherboardTypes;
        private RAMTypes rAMType;
        private CPUTypes cPUTypes;
        private CPU cpu;
        private RAM ram;

        public MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        public RAMTypes RAMType { get => rAMType; set => rAMType = value; }
        public CPUTypes CPUTypes { get => cPUTypes; set => cPUTypes = value; }
        internal CPU Cpu { get => cpu; set => cpu = value; }
        internal RAM Ram { get => ram; set => ram = value; }

        public Motherboard(MotherboardTypes motherboardTypes, RAMTypes rAMType, CPUTypes cPUTypes, int usingPover) : base(usingPover)
        {
            this.motherboardTypes = motherboardTypes;
            this.rAMType = rAMType;
            this.cPUTypes = cPUTypes;
            
        }

        public override string ToString()
        {
            return cpu.ToString()+ram.ToString()+motherboardTypes+cPUTypes+rAMType;
        }

        public bool isComponCorrect()
        {
            if (cpu.CpuTypes.Equals(cPUTypes)&&ram.RAMTypes.Equals(rAMType))
            {
                return true;
            }else{
                return false;
            }

        }
        public int countPowerOfMatherbordAndComponents()
        {
            return this.UsingPover + cpu.UsingPover + ram.UsingPover;
        }
    }
}
