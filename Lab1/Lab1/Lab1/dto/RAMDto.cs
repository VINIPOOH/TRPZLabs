﻿using System;
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

        public RAMDto( RAMTypes rAMTypes, int usingPover)
        {
            this.usingPover = usingPover;
            this.rAMTypes = rAMTypes;
        }

        public int UsingPover { get => usingPover; set => usingPover = value; }
        internal RAMTypes RAMTypes { get => rAMTypes; set => rAMTypes = value; }
    }
}