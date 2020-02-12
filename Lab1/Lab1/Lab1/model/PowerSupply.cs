using Lab1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    class PowerSupply : ElectronicСomponent
    {
        private int volume;

        public PowerSupply(int volume, int usingPover) : base(usingPover)
        {
            this.volume = volume;
        }

        public PowerSupply(PowerSupplyDao power): base(power.UsingPover)
        {
            this.volume = power.Volume;
        }

        public int Volume { get => volume; set => volume = value; }
    }
}
