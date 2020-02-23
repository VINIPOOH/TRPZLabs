package dto;
    public class SystemUnitDto
    {
        private MotherboardTypes motherboardTypes;
        private int maxPoverSupplyVolume;
        private MotherboardDto motherboardDtoDto;
        private PowerSupplyDto powerSupplyDtoDto;
        private String name;

        public SystemUnitDto(MotherboardTypes motherboardTypes, int maxPoverSupplyVolume, MotherboardDto motherboardDtoDto, PowerSupplyDto powerSupplyDtoDto, String name)
        {
            this.motherboardTypes = motherboardTypes;
            this.maxPoverSupplyVolume = maxPoverSupplyVolume;
            this.motherboardDtoDto = motherboardDtoDto;
            this.powerSupplyDtoDto = powerSupplyDtoDto;
            this.name = name;
        }

        public int MaxPoverSupplyVolume() {return 1; }
        public String Name (){ return null;}
        public MotherboardTypes MotherboardTypes (){ return null; }
        public MotherboardDto MotherboardDto (){ return null; }
        public PowerSupplyDto PowerSupplyDto (){ return null; }

        public String ToString()
        {
            String toRetutn="название корпуса"+name +
                            " "+ "maxPoverSupplyVolume"+ maxPoverSupplyVolume
                            + "motherboardTypes"+ motherboardTypes;

            if (motherboardDtoDto==null)
            {
                toRetutn += "matplata  null";
            }
            else
            {

            }
            if (powerSupplyDtoDto==null)
            {
                toRetutn += "blokk pitania  null";
            }
            else
            {

            }
            
            return toRetutn;
        }
    }

