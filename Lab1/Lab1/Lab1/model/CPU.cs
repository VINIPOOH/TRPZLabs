
using Lab1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    public class CPU : ElectronicСomponent
    {
        private CPUTypes cpuTypes;

        public CPU(CPUTypes cpuTypes, int usingPover) : base(usingPover)
        {
            this.cpuTypes = cpuTypes;
        }

        public CPUTypes CpuTypes { get => cpuTypes; set => cpuTypes = value; }
    }
}
