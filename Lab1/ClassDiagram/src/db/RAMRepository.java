package db;

import java.util.List;

class RAMRepository implements IRepository<RAMDto>
    {


        @Override
        public List<RAMDto> findAll() {
            List<RAMDto> rAMs = new List<RAMDto>();
            rAMs.Add(new RAMDto (RAMTypes.SMOLLE, 100));
            rAMs.Add(new RAMDto(RAMTypes.BIG, 100));
            return rAMs;
        }
    }

