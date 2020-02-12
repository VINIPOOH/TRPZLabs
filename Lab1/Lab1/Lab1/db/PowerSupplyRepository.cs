using Lab1.dao;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.db
{
    class PowerSupplyRepository
    {
        public static List<PowerSupplyDao> findAll()
        {
            List<PowerSupplyDao>  powerSupplies = new List<PowerSupplyDao>();
            powerSupplies.Add(new PowerSupplyDao(300, -2));
            powerSupplies.Add(new PowerSupplyDao(300, 2));
            return powerSupplies;
        }
    }
}
