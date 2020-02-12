using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dao
{
    class CPUDao
    {
        private CPUTypes cpuTypes;
        private int usingPover;

        public CPUDao(CPUTypes cpuTypes, int usingPover)
        {
            this.cpuTypes = cpuTypes;
            this.usingPover = usingPover;
        }
    }
}
