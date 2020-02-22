
using Lab1.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    public class CPU 
    {
        private CPUDto cpuDtoAdaptee;

        public CPU(CPUTypes cpuTypes, int usingPover)
        {
            this.cpuDtoAdaptee = new CPUDto(cpuTypes, usingPover);
        }

        public CPU(CPUDto cPuDto)
        {
            this.cpuDtoAdaptee = cPuDto;
        }

        public CPUDto CpuDtoAdaptee
        {
            get => cpuDtoAdaptee;
            set => cpuDtoAdaptee = value;
        }

        public CPUTypes CpuTypes
        {
            get => cpuDtoAdaptee.CpuTypes; 
            set => cpuDtoAdaptee.CpuTypes = value;
        }

        public int UsingPover
        {
            get => cpuDtoAdaptee.UsingPover;
            set => cpuDtoAdaptee.UsingPover = value;
        }
    }
}
