using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dto
{

    public class MotherboardDto
    {
        private int usingPover;
        private MotherboardTypes motherboardTypes;
        private RAMTypes rAMType;
        private CPUTypes cPUTypes;
        private CPUDto cpuDtoDto = null;
        private RAMDto ramDtoDto = null;
        public int id { get; set; }

        public MotherboardDto()
        {
        }

        public MotherboardDto(int usingPover, MotherboardTypes motherboardTypes, RAMTypes rAMType, CPUTypes cPUTypes, CPUDto cpuDtoDto, RAMDto ramDtoDto)
        {
            this.usingPover = usingPover;
            this.motherboardTypes = motherboardTypes;
            this.rAMType = rAMType;
            this.cPUTypes = cPUTypes;
            this.cpuDtoDto = cpuDtoDto;
            this.ramDtoDto = ramDtoDto;
        }

        public int UsingPover { get => usingPover; set => usingPover = value; }
        public CPUTypes CPUTypes { get => cPUTypes; set => cPUTypes = value; }
        
        public MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        public RAMTypes RAMType { get => rAMType; set => rAMType = value; }
        internal CPUDto CpuDto { get => cpuDtoDto; set => cpuDtoDto = value; }
        internal RAMDto RamDto { get => ramDtoDto; set => ramDtoDto = value; }
        
    }
}
