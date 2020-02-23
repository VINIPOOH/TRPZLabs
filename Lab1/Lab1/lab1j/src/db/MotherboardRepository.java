package db;

import dto.CPUTypes;
import dto.MotherboardDto;
import dto.MotherboardTypes;
import dto.RAMTypes;

import java.util.LinkedList;
import java.util.List;

class MotherboardRepository
    {
        public static List<MotherboardDto> findAll()
        {
            List<MotherboardDto> motherboards = new LinkedList<>();
            motherboards.add(new MotherboardDto(30, MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, null,null));
            motherboards.add(new MotherboardDto(130, MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, null, null));
            motherboards.add(new MotherboardDto(30, MotherboardTypes.BIG, RAMTypes.SMOLLE, CPUTypes.BIG, null, null));
            return motherboards;
        }
    }

