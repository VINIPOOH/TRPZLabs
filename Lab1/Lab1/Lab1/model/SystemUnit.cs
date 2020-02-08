using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    class SystemUnit
    {
        private MotherboardTypes motherboardTypes;
        private int maxPoverSupplyVolume;
        private Motherboard motherboard;
        private PowerSupply powerSupply;
        private String name;

        public MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        public int MaxPoverSupplyVolume { get => maxPoverSupplyVolume; set => maxPoverSupplyVolume = value; }
        internal Motherboard Motherboard { get => motherboard; set => motherboard = value; }
        internal PowerSupply PowerSupply { get => powerSupply; set => powerSupply = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return base.ToString()+motherboardTypes+maxPoverSupplyVolume+motherboard+powerSupply+name;
        }

        public SystemUnit(MotherboardTypes motherboardTypes, int maxPoverSupplyVolume, string name)
        {
            MotherboardTypes = motherboardTypes;
            MaxPoverSupplyVolume = maxPoverSupplyVolume;
            Name = name;
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
