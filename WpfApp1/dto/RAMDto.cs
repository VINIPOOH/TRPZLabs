using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.dto
{
    public class RAMDto
    {
        private int usingPover;
        private RAMTypes rAMTypes;
        public int id { get; set; }

        public RAMDto()
        {
        }

        public RAMDto( RAMTypes rAMTypes, int usingPover)
        {
            this.usingPover = usingPover;
            this.rAMTypes = rAMTypes;
        }

        public int UsingPover { get => usingPover; set => usingPover = value; }
        public RAMTypes RAMTypes { get => rAMTypes; set => rAMTypes = value; }
    }
}
