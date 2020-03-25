using Lab1.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.dto;

namespace Lab1.db
{
    public class SysteUnitRepository : IRepository<SystemUnitDto>
    {
        private MyDbContext myDbContext;

        public SysteUnitRepository(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }
        List<SystemUnitDto> IRepository<SystemUnitDto>.findAll()
        {
            //List<SystemUnitDto> systemUnits = new List<SystemUnitDto>();//спросить про ИДЕЕ!!!
            //systemUnits.Add(new SystemUnitDto(MotherboardTypes.BIG,1000,null,null,"BIG"));
            //systemUnits.Add(new SystemUnitDto(MotherboardTypes.BIG, 100, null, null, "BIG"));
            //systemUnits.Add(new SystemUnitDto(MotherboardTypes.BIG, 100, null, null, "BIG"));
            //myDbContext.systemUnitDtos.AddRange(systemUnits);
            //myDbContext.SaveChanges();
            return myDbContext.systemUnitDtos.ToList();
        }
    }
}
