using Lab1.dto;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.db
{
    class CPURepository :IRepository<CPUDto>
    {
        List<CPUDto> IRepository<CPUDto>.findAll()
        {
            List<CPUDto> cPUs = new List<CPUDto>();
            cPUs.Add(new CPUDto(CPUTypes.SMOLLE, 200));
            cPUs.Add(new CPUDto(CPUTypes.BIG, 300));
            return cPUs;
        }
    }
}
