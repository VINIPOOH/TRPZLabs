package dto;

public class CPUDto
    {
        private CPUTypes cpuTypes;
        private int usingPover;

        public CPUDto(CPUTypes cpuTypes, int usingPover)
        {
            this.cpuTypes = cpuTypes;
            this.usingPover = usingPover;
        }

        public CPUTypes CpuTypes() { return null;}

        public int UsingPover()
        {
            return 1;
        }
    }

