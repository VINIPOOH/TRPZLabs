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

        public Motherboard(MotherboardTypes motherboardTypes, RAMTypes rAMType, CPUTypes cPUTypes, CPU cpu, RAM ram, int usingPover) : base(usingPover)
        {
            this.motherboardTypes = motherboardTypes;
            this.rAMType = rAMType;
            this.cPUTypes = cPUTypes;
            this.cpu = cpu;
            this.ram = ram;
        }

        internal CPU Cpu { get => cpu; set => cpu = value; }
        internal RAM Ram { get => ram; set => ram = value; }
        internal MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }

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
