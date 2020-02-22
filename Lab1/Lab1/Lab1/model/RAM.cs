using Lab1.dto;

namespace Lab1Code.model
{
    class RAM
    {
        private RAMDto ramDtoAdaptee;

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
    }
}
