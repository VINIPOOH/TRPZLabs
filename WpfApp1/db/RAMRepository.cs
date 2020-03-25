using Lab1.dto;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.db
{
    class RAMRepository : IRepository<RAMDto>
    {
        private MyDbContext myDbContext;

        public RAMRepository(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        List<RAMDto> IRepository<RAMDto>.findAll()
        {
            //List<RAMDto> rAMs = new List<RAMDto>();
            //rAMs.Add(new RAMDto (RAMTypes.SMOLLE, 100));
            //rAMs.Add(new RAMDto(RAMTypes.BIG, 100));
            //myDbContext.rAMDtos.AddRange(rAMs);
            //myDbContext.SaveChanges();
            return myDbContext.rAMDtos.ToList();
        }
    }
}
