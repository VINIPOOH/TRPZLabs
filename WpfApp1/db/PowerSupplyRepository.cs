using Lab1.dto;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.db
{
    class PowerSupplyRepository : IRepository<PowerSupplyDto>
    {
        private MyDbContext myDbContext;

        public PowerSupplyRepository(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        List<PowerSupplyDto> IRepository<PowerSupplyDto>.findAll()
        {
            //List<PowerSupplyDto>  powerSupplies = new List<PowerSupplyDto>();
            //powerSupplies.Add(new PowerSupplyDto(300, -2));
            //powerSupplies.Add(new PowerSupplyDto(300, 2));
            //myDbContext.powerSupplyDtos.AddRange(powerSupplies);
            //myDbContext.SaveChanges();
            return myDbContext.powerSupplyDtos.ToList();
        }
    }
}
