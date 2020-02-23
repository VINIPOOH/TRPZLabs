package db;

import dto.CPUDto;
import dto.CPUTypes;

import java.util.LinkedList;
import java.util.List;

class CPURepository
    {
        public static List<CPUDto> findAll()
        {
            List<CPUDto> cPUs = new LinkedList<>();
            cPUs.add(new CPUDto(CPUTypes.SMOLLE, 200));
            cPUs.add(new CPUDto(CPUTypes.BIG, 300));
            return cPUs;
        }
    }

