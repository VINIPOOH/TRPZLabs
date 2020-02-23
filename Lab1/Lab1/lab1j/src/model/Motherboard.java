package model;

import dto.CPUTypes;
import dto.MotherboardDto;
import dto.MotherboardTypes;
import dto.RAMTypes;

class Motherboard implements IAdapter<MotherboardDto>
    {
        private MotherboardDto motherboardDtoAdaptee;

        public MotherboardTypes MotherboardTypes (){
            return null;}
        public RAMTypes RAMType (){
        return null; }
        public dto.CPUTypes CPUTypes() {
        return null;}
        public CPU Cpu()
        {
            return null; }

        public RAM Ram() { return null;}

        public Motherboard(MotherboardDto motherboardDto)
        {
            motherboardDtoAdaptee = motherboardDto;
        }

        public Motherboard(MotherboardTypes motherboardTypes, RAMTypes rAMType, CPUTypes cPUTypes, int usingPover)
        {


        }

        public MotherboardDto MotherboardDtoAdaptee()
        {
            return null;
        }

        public String ToString()
        {
            String toReturn = "";

            return toReturn;
        }

        public boolean isComponCorrect()
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

        public MotherboardDto GetAdaptee()
        {
            return motherboardDtoAdaptee;
        }

        public void SetAdaptee(MotherboardDto adaptee)
        {
            motherboardDtoAdaptee = adaptee;
        }

        public Motherboard()
        {
        }
    }

