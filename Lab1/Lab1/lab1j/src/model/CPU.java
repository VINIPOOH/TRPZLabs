package model;

import dto.CPUDto;
import dto.CPUTypes;

public class CPU implements IAdapter<CPUDto>
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

        public CPUDto CpuDtoAdaptee()
        {
            return null;
        }

        public CPUTypes CpuTypes()
        {return null;
        }

        public int UsingPover()
        {
            return 1;
        }

        public CPUDto GetAdaptee()
        {
            return cpuDtoAdaptee;
        }

        public void SetAdaptee(CPUDto adaptee)
        {
            cpuDtoAdaptee=adaptee;
        }

        public CPU()
        {
        }
    }

