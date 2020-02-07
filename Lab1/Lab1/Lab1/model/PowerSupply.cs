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

        public int Volume { get => volume; set => volume = value; }
    }
}
