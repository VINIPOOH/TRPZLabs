using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    public class ElectronicСomponent
    {
        private int usingPover;

        public ElectronicСomponent(int usingPover)
        {
            this.usingPover = usingPover;
        }

        public int UsingPover { get => usingPover; set => usingPover = value; }
    }
}
