using Lab1.dao;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.model
{
    class EntytyConverter
    {
        public static List<SystemUnit> SystemUnitDaoToSystemUnit(List<SystemUnitDao> systemUnitDaos)
        {
            List<SystemUnit> toReturn = new List<SystemUnit>();
            foreach (SystemUnitDao s in systemUnitDaos)
            {
                toReturn.Add(new SystemUnit(s));
            }
            return toReturn;
        } 
    }
}
