package dto;
    public class RAMDto
    {
        private int usingPover;
        private RAMTypes rAMTypes;

        public RAMDto( RAMTypes rAMTypes, int usingPover)
        {
            this.usingPover = usingPover;
            this.rAMTypes = rAMTypes;
        }

        public int UsingPover() { return 1; }
        public RAMTypes RAMTypes() { return null; }
    }

