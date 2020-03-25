using Lab1.dto;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.db
{
    class MotherboardRepository : IRepository<MotherboardDto>
    {
        private MyDbContext myDbContext;

        public MotherboardRepository(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        List<MotherboardDto> IRepository<MotherboardDto>.findAll()
        {
            //List<MotherboardDto> motherboards = new List<MotherboardDto>();
            //motherboards.Add(new MotherboardDto(30, MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, null, null));
            //motherboards.Add(new MotherboardDto(130, MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, null, null));
            //motherboards.Add(new MotherboardDto(30, MotherboardTypes.BIG, RAMTypes.SMOLLE, CPUTypes.BIG, null, null));

            //myDbContext.motherboardDtos.AddRange(motherboards);
            //myDbContext.SaveChanges();
            return myDbContext.motherboardDtos.ToList();
        }
    }
}
