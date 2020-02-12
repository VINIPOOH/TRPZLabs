using Lab1.dao;
using System;

namespace Lab1Code.model
{
    class Motherboard : ElectronicСomponent
    {
        private MotherboardTypes motherboardTypes;
        private RAMTypes rAMType;
        private CPUTypes cPUTypes;
        private CPU cpu=null;
        private RAM ram=null;

        public MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        public RAMTypes RAMType { get => rAMType; set => rAMType = value; }
        public CPUTypes CPUTypes { get => cPUTypes; set => cPUTypes = value; }
        internal CPU Cpu { get => cpu; set => cpu = value; }
        internal RAM Ram { get => ram; set => ram = value; }

        public Motherboard(MotherboardDao motherboardDao): base(motherboardDao.UsingPover)
        {
            this.motherboardTypes = motherboardDao.MotherboardTypes;
            this.rAMType = motherboardDao.RAMType;
            this.cPUTypes = motherboardDao.CPUTypes;
            this.cpu = new CPU(motherboardDao.Cpu);
            this.ram = new RAM(motherboardDao.Ram);
        }

        public Motherboard(MotherboardTypes motherboardTypes, RAMTypes rAMType, CPUTypes cPUTypes, int usingPover) : base(usingPover)
        {
            this.motherboardTypes = motherboardTypes;
            this.rAMType = rAMType;
            this.cPUTypes = cPUTypes;
            
        }

        public override string ToString()
        {
            String toReturn = "";
            if (cpu == null)
            {
                toReturn += "cpu" + "null";
            }
            else
            {
                toReturn += "cpu" + cpu.ToString();
            }
            if (ram == null)
            {
                toReturn += "ram" + "null";
            }
            else
            {
                toReturn += "ram" + ram.ToString();
            }
            return toReturn;
        }

        public bool isComponCorrect()
        {
            if (cpu==null||ram==null)
            {
                
                return false;
            }
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
