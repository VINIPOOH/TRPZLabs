﻿using Lab1.dto;
using Lab1.model;

namespace Lab1Code.model
{
    class RAM : IAdapter<RAMDto>
    {
        private RAMDto ramDtoAdaptee;

        public RAM()
        {
        }

        public RAMTypes RAMTypes { get => ramDtoAdaptee.RAMTypes;
            set => ramDtoAdaptee.RAMTypes = value; }

        public RAM(RAMDto rAmDto) 
        {
            ramDtoAdaptee= rAmDto;
        }

        public RAM(RAMTypes rAMTypes, int usingPover)
        {
            ramDtoAdaptee= new RAMDto(rAMTypes, usingPover);
        }

        public RAMDto RamDtoAdaptee
        {
            get => ramDtoAdaptee;
            set => ramDtoAdaptee = value;
        }

        public RAMDto GetAdaptee()
        {
            return ramDtoAdaptee;
        }

        public void SetAdaptee(RAMDto adaptee)
        {
            ramDtoAdaptee=adaptee;
        }
    }
}
