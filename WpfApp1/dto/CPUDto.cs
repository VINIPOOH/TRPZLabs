using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dto
{
    public class CPUDto
    {
        private CPUTypes cpuTypes;
        private int usingPover;
        public int id { get; set; }

        public CPUDto()
        {
        }

        public CPUDto(CPUTypes cpuTypes, int usingPover)
        {
            this.cpuTypes = cpuTypes;
            this.usingPover = usingPover;
        }

        public CPUTypes CpuTypes { get => cpuTypes; set => cpuTypes = value; }

        public int UsingPover
        {
            get => usingPover;
            set => usingPover = value;
        }
    }
}
