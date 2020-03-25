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
        public int id { get; set; }

        public SystemUnitDto()
        {
        }

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
        public MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        internal MotherboardDto MotherboardDto { get => motherboardDtoDto; set => motherboardDtoDto = value; }
        internal PowerSupplyDto PowerSupplyDto { get => powerSupplyDtoDto; set => powerSupplyDtoDto = value; }

        public override string ToString()
        {
            String toRetutn="название корпуса"+Name +
                            " "+ "maxPoverSupplyVolume"+ MaxPoverSupplyVolume
                            + "motherboardTypes"+ MotherboardTypes;

            if (MotherboardDto==null)
            {
                toRetutn += "matplata  null";
            }
            else
            {
                toRetutn += MotherboardDto.ToString();
            }
            if (PowerSupplyDto==null)
            {
                toRetutn += "blokk pitania  null";
            }
            else
            {
                toRetutn += PowerSupplyDto.ToString();
            }
            
            return toRetutn;
        }
    }
}
