using Lab1.dao;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.db
{
    class MotherboardRepository
    {
        public static List<MotherboardDao> findAll()
        {
            List<MotherboardDao> motherboards = new List<MotherboardDao>();
            motherboards.Add(new MotherboardDao(30,MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, null,null));
            motherboards.Add(new MotherboardDao(130, MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, null, null));
            motherboards.Add(new MotherboardDao(30, MotherboardTypes.BIG, RAMTypes.SMOLLE, CPUTypes.BIG, null, null));
            return motherboards;
        }
    }
}
