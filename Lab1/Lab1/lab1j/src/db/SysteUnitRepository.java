package db;

import dto.MotherboardTypes;
import dto.SystemUnitDto;

import java.util.LinkedList;
import java.util.List;

public class SysteUnitRepository
    {
        public static List<SystemUnitDto> findAll()
        {
            List<SystemUnitDto> systemUnits = new LinkedList<>();//спросить про ИДЕЕ!!!
            systemUnits.add(new SystemUnitDto(MotherboardTypes.BIG,1000,null,null,"BIG"));
            systemUnits.add(new SystemUnitDto(MotherboardTypes.BIG, 100, null, null, "BIG"));
            systemUnits.add(new SystemUnitDto(MotherboardTypes.BIG, 100, null, null, "BIG"));
            return systemUnits;
        }
    }

