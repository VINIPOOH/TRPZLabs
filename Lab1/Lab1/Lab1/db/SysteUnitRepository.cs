using Lab1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.db
{
    public class SysteUnitRepository
    {
        public static List<SystemUnitDao> findAll()
        {
            List<SystemUnitDao> systemUnits = new List<SystemUnitDao>();//спросить про ИДЕЕ!!!
            systemUnits.Add(new SystemUnitDao(MotherboardTypes.BIG,1000,null,null,"BIG"));
            systemUnits.Add(new SystemUnitDao(MotherboardTypes.BIG, 100, null, null, "BIG"));
            systemUnits.Add(new SystemUnitDao(MotherboardTypes.BIG, 100, null, null, "BIG"));
            return systemUnits;
        }
    }
}
