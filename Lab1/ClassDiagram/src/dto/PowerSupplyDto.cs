using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dto
{
    public class PowerSupplyDto
    {
        private int usingPover;
        private int volume;

        public PowerSupplyDto(int usingPover, int volume)
        {
            this.usingPover = usingPover;
            this.volume = volume;
        }

        public int UsingPover { get => usingPover; set => usingPover = value; }
        public int Volume { get => volume; set => volume = value; }
    }
}
