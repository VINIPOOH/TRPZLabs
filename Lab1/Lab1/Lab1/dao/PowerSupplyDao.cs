using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dao
{
    class PowerSupplyDao
    {
        private int usingPover;
        private int volume;

        public PowerSupplyDao(int usingPover, int volume)
        {
            this.usingPover = usingPover;
            this.volume = volume;
        }
    }
}
