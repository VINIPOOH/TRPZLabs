package dto;
    public class PowerSupplyDto
    {
        private int usingPover;
        private int volume;

        public PowerSupplyDto(int usingPover, int volume)
        {
            this.usingPover = usingPover;
            this.volume = volume;
        }

        public int UsingPover (){ return 1; }
        public int Volume() { return 1; }
    }

