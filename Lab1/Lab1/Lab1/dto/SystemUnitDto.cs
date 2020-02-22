using System;


namespace Lab1.dto
{
    public class SystemUnitDto
    {
        private MotherboardTypes motherboardTypes;
        private int maxPoverSupplyVolume;
        private MotherboardDto motherboardDtoDto;
        private PowerSupplyDto powerSupplyDtoDto;
        private String name;

        public SystemUnitDto(MotherboardTypes motherboardTypes, int maxPoverSupplyVolume, MotherboardDto motherboardDtoDto, PowerSupplyDto powerSupplyDtoDto, string name)
        {
            this.motherboardTypes = motherboardTypes;
            this.maxPoverSupplyVolume = maxPoverSupplyVolume;
            this.motherboardDtoDto = motherboardDtoDto;
            this.powerSupplyDtoDto = powerSupplyDtoDto;
            this.name = name;
        }

        public int MaxPoverSupplyVolume { get => maxPoverSupplyVolume; set => maxPoverSupplyVolume = value; }
        public string Name { get => name; set => name = value; }
        internal MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        internal MotherboardDto MotherboardDto { get => motherboardDtoDto; set => motherboardDtoDto = value; }
        internal PowerSupplyDto PowerSupplyDto { get => powerSupplyDtoDto; set => powerSupplyDtoDto = value; }
    }
}
