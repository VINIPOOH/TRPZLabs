using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dao
{
    public class CPUDao
    {
        private CPUTypes cpuTypes;
        private int usingPover;

        public CPUDao(CPUTypes cpuTypes, int usingPover)
        {
            this.cpuTypes = cpuTypes;
            this.usingPover = usingPover;
        }

        public CPUTypes CpuTypes { get => cpuTypes; set => cpuTypes = value; }
        public int UsingPover { get => usingPover; set => usingPover = value; }
    }
}
