package dto;

import dto.CPUTypes;
import dto.MotherboardTypes;
import dto.RAMTypes;

public class MotherboardDto
    {
        private int usingPover;
        private dto.MotherboardTypes motherboardTypes;
        private dto.RAMTypes rAMType;
        private dto.CPUTypes cPUTypes;
        private CPUDto cpuDtoDto = null;
        private RAMDto ramDtoDto = null;

        public MotherboardDto(int usingPover, MotherboardTypes motherboardTypes, RAMTypes rAMType, CPUTypes cPUTypes, CPUDto cpuDtoDto, RAMDto ramDtoDto)
        {
            this.usingPover = usingPover;
            this.motherboardTypes = motherboardTypes;
            this.rAMType = rAMType;
            this.cPUTypes = cPUTypes;
            this.cpuDtoDto = cpuDtoDto;
            this.ramDtoDto = ramDtoDto;
        }

        public int UsingPover() {
            return 1;
    }
        public CPUTypes CPUTypes() {
            return null;
        }
        
        public MotherboardTypes MotherboardTypes (){
        return null;
    }
        public RAMTypes RAMType() { return null; }
        public CPUDto CpuDto() {return null; }
        public RAMDto RamDto() { return null; }
        
    }

