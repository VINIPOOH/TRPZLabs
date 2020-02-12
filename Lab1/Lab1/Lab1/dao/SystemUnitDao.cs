using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dao
{
    public class SystemUnitDao
    {
        private MotherboardTypes motherboardTypes;
        private int maxPoverSupplyVolume;
        private MotherboardDao motherboard;
        private PowerSupplyDao powerSupply;
        private String name;

        public SystemUnitDao(MotherboardTypes motherboardTypes, int maxPoverSupplyVolume, MotherboardDao motherboard, PowerSupplyDao powerSupply, string name)
        {
            this.motherboardTypes = motherboardTypes;
            this.maxPoverSupplyVolume = maxPoverSupplyVolume;
            this.motherboard = motherboard;
            this.powerSupply = powerSupply;
            this.name = name;
        }

        public int MaxPoverSupplyVolume { get => maxPoverSupplyVolume; set => maxPoverSupplyVolume = value; }
        public string Name { get => name; set => name = value; }
        internal MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        internal MotherboardDao Motherboard { get => motherboard; set => motherboard = value; }
        internal PowerSupplyDao PowerSupply { get => powerSupply; set => powerSupply = value; }
    }
}
