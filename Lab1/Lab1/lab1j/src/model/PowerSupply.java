package model;
    class PowerSupply implements IAdapter<PowerSupplyDto>
    {
        public PowerSupply()
        {
        }

        private PowerSupplyDto powerSupplyDtoAdaptee;

        public PowerSupply( int usingPover, int volume)
        {
            powerSupplyDtoAdaptee=new PowerSupplyDto(usingPover,volume);
        }

        public PowerSupply(PowerSupplyDto power)
        {
            powerSupplyDtoAdaptee = power;
        }

        

        public PowerSupplyDto PowerSupplyDtoAdaptee
        {
            get => powerSupplyDtoAdaptee;
            set => powerSupplyDtoAdaptee = value;
        }
        public int Volume { get => powerSupplyDtoAdaptee.Volume;
            set => powerSupplyDtoAdaptee.Volume = value; }

        public int UsingPover
        {
            get => powerSupplyDtoAdaptee.UsingPover;
            set => powerSupplyDtoAdaptee.UsingPover = value;
        }

        public PowerSupplyDto GetAdaptee()
        {
            return powerSupplyDtoAdaptee;
        }

        public void SetAdaptee(PowerSupplyDto adaptee)
        {
            powerSupplyDtoAdaptee = adaptee;
        }
    }

