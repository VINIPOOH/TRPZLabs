package db;

import java.util.List;

public class SysteUnitRepository implements IRepository<SystemUnitDto>
    {
        @Override
        public List<SystemUnitDto> findAll() {
            List<SystemUnitDto> systemUnits = new List<SystemUnitDto>();//спросить про ИДЕЕ!!!
            systemUnits.Add(new SystemUnitDto(MotherboardTypes.BIG,1000,null,null,"BIG"));
            systemUnits.Add(new SystemUnitDto(MotherboardTypes.BIG, 100, null, null, "BIG"));
            systemUnits.Add(new SystemUnitDto(MotherboardTypes.BIG, 100, null, null, "BIG"));
            return systemUnits;
        }
    }

