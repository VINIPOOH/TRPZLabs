package db;

    class CPURepository implements IRepository<CPUDto>
    {
        List<CPUDto> IRepository<CPUDto>.findAll()
        {
            List<CPUDto> cPUs = new List<CPUDto>();
            cPUs.Add(new CPUDto(CPUTypes.SMOLLE, 200));
            cPUs.Add(new CPUDto(CPUTypes.BIG, 300));
            return cPUs;
        }
    }

