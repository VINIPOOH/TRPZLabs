using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    class SystemUnit : ElectronicСomponent
    {
        private MotherboardTypes motherboardTypes;
        private int maxPoverSupplyVolume;
        private Motherboard motherboard;
        private PowerSupply powerSupply;

        internal MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        public int MaxPoverSupplyVolume { get => maxPoverSupplyVolume; set => maxPoverSupplyVolume = value; }
        internal Motherboard Motherboard { get => motherboard; set => motherboard = value; }
        internal PowerSupply PowerSupply { get => powerSupply; set => powerSupply = value; }

        public SystemUnit(MotherboardTypes motherboardTypes, int maxPoverSupplyVolume, Motherboard motherboard, PowerSupply powerSupply, int usingPover) : base(usingPover)
        {
            this.motherboardTypes = motherboardTypes;
            this.maxPoverSupplyVolume = maxPoverSupplyVolume;
            this.motherboard = motherboard;
            this.powerSupply = powerSupply;
        }

        public bool isComponCorrect()
        {
            if (motherboard.isComponCorrect() && motherboard.MotherboardTypes.Equals(motherboardTypes)
                && powerSupply.Volume<maxPoverSupplyVolume && isEnoughPower())
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        private bool isEnoughPower()
        {
            if (powerSupply.UsingPover + motherboard.countPowerOfMatherbordAndComponents() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
