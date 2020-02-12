using Lab1.dao;

namespace Lab1Code.model
{
    class RAM : ElectronicСomponent
    {
        private RAMTypes rAMTypes;

        public RAMTypes RAMTypes { get => rAMTypes; set => rAMTypes = value; }

        public RAM(RAMDao rAMDao) : base(rAMDao.UsingPover)
        {
            this.rAMTypes = rAMDao.RAMTypes;
        }

        public RAM(RAMTypes rAMTypes, int usingPover) : base(usingPover)
        {
            this.rAMTypes = rAMTypes;
        }

        
    }
}
