using Lab1.dto;
using System;

namespace Lab1Code.model
{
    class Motherboard
    {
        private MotherboardDto motherboardDtoAdaptee;

        public MotherboardTypes MotherboardTypes { get => motherboardDtoAdaptee.MotherboardTypes; 
            set => motherboardDtoAdaptee.MotherboardTypes = value; }
        public RAMTypes RAMType { get => motherboardDtoAdaptee.RAMType; set => motherboardDtoAdaptee.RAMType = value; }
        public CPUTypes CPUTypes { get => motherboardDtoAdaptee.CPUTypes; set => motherboardDtoAdaptee.CPUTypes = value; }
        internal CPU Cpu
        {
            get => new CPU(motherboardDtoAdaptee.CpuDto);
            set => motherboardDtoAdaptee.CpuDto = value.CpuDtoAdaptee; }
        internal RAM Ram { get => new RAM(motherboardDtoAdaptee.RamDto);
            set => motherboardDtoAdaptee.RamDto = value.RamDtoAdaptee; }

        public Motherboard(MotherboardDto motherboardDto)
        {
            motherboardDtoAdaptee = motherboardDto;
        }

        public Motherboard(MotherboardTypes motherboardTypes, RAMTypes rAMType, CPUTypes cPUTypes, int usingPover)
        {
            motherboardDtoAdaptee.MotherboardTypes = motherboardTypes;
            motherboardDtoAdaptee.RAMType = rAMType;
            motherboardDtoAdaptee.CPUTypes = cPUTypes;
            motherboardDtoAdaptee.UsingPover=usingPover;

        }

        public MotherboardDto MotherboardDtoAdaptee
        {
            get => motherboardDtoAdaptee;
            set => motherboardDtoAdaptee = value;
        }

        public override string ToString()
        {
            String toReturn = "";
            if (motherboardDtoAdaptee.CpuDto == null)
            {
                toReturn += "cpu" + "null";
            }
            else
            {
                toReturn += "cpu" + motherboardDtoAdaptee.CpuDto.ToString();
            }
            if (motherboardDtoAdaptee.RamDto == null)
            {
                toReturn += "ram" + "null";
            }
            else
            {
                toReturn += "ram" + motherboardDtoAdaptee.RamDto.ToString();
            }
            return toReturn;
        }

        public bool isComponCorrect()
        {
            if (motherboardDtoAdaptee.CpuDto==null||motherboardDtoAdaptee.RamDto==null)
            {
                
                return false;
            }
            if (motherboardDtoAdaptee.CpuDto.CpuTypes.Equals(motherboardDtoAdaptee.CPUTypes)
                &&motherboardDtoAdaptee.RamDto.RAMTypes.Equals(motherboardDtoAdaptee.RAMType))
            {
                
                return true;
            }else{
                return false;
            }
        }
        public int countPowerOfMatherbordAndComponents()
        {
            return motherboardDtoAdaptee.UsingPover + motherboardDtoAdaptee.CpuDto.UsingPover
                                                    + motherboardDtoAdaptee.RamDto.UsingPover;
        }
    }
}
