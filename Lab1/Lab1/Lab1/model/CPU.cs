using Lab1.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    class CPU : ElectronicСomponent
    {
        private CPUTypes cpuTypes;

        public CPUTypes(CPUTypes cpuTypes)
        {
            this.cpuTypes = cpuTypes;
        }
    }
}
