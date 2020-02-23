package db;

import dto.RAMDto;
import dto.RAMTypes;

import java.util.LinkedList;
import java.util.List;

class RAMRepository
    {
        public static List<RAMDto> findAll()
        {
            List<RAMDto> rAMs = new LinkedList<>();
            rAMs.add(new RAMDto (RAMTypes.SMOLLE, 100));
            rAMs.add(new RAMDto(RAMTypes.BIG, 100));
            return rAMs;
        }
    }

