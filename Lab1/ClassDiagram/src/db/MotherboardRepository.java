package db;
    class MotherboardRepository implements IRepository<MotherboardDto>


        List<MotherboardDto> IRepository<MotherboardDto>.findAll()
        {
            List<MotherboardDto> motherboards = new List<MotherboardDto>();
            motherboards.Add(new MotherboardDto(30,MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, null,null));
            motherboards.Add(new MotherboardDto(130, MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, null, null));
            motherboards.Add(new MotherboardDto(30, MotherboardTypes.BIG, RAMTypes.SMOLLE, CPUTypes.BIG, null, null));
            return motherboards;
        }

}
