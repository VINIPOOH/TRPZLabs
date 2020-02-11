using Lab1.dao;

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
