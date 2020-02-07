using Lab1.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    class RAM : ElectronicСomponent
    {
        private RAMTypes rAMTypes;

        public RAM(RAMTypes rAMTypes, int usingPover) : base(usingPover)
        {
            this.rAMTypes = rAMTypes;
        }

         public RAMTypes RAMTypes { get => rAMTypes; set => rAMTypes = value; }
    }
}
