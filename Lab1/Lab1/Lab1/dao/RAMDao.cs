using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dao
{
    class RAMDao
    {
        private int usingPover;
        private RAMTypes rAMTypes;

        public RAMDao(int usingPover, RAMTypes rAMTypes)
        {
            this.usingPover = usingPover;
            this.rAMTypes = rAMTypes;
        }
    }
}
