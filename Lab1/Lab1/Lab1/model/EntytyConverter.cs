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
        public static List<Motherboard> MotherboardDaoToMotherboard(List<MotherboardDao> motherboards)
        {
            List<Motherboard> toReturn = new List<Motherboard>();
            foreach (MotherboardDao s in motherboards)
            {
                toReturn.Add(new Motherboard(s));
            }
            return toReturn;
        }
        public static List<CPU> CPUDaoToCPU(List<CPUDao> systemUnitDaos)
        {
            List<CPU> toReturn = new List<CPU>();
            foreach (CPUDao s in systemUnitDaos)
            {
                toReturn.Add(new CPU(s));
            }
            return toReturn;
        }
        public static List<RAM> RAMUnitDaoToRAM(List<RAMDao> systemUnitDaos)
        {
            List<RAM> toReturn = new List<RAM>();
            foreach (RAMDao s in systemUnitDaos)
            {
                toReturn.Add(new RAM(s));
            }
            return toReturn;
        }
        public static List<PowerSupply> PowerSupplyDaoToPowerSupply(List<PowerSupplyDao> systemUnitDaos)
        {
            List<PowerSupply> toReturn = new List<PowerSupply>();
            foreach (PowerSupplyDao s in systemUnitDaos)
            {
                toReturn.Add(new PowerSupply(s));
            }
            return toReturn;
        }



        public static List<TypeInWhichConvert> SystemUnitDaoToSystemUnit<TypeInWhichConvert 
            , TypeFromWhichConvert>(List<TypeFromWhichConvert> typeFroms) where TypeFromWhichConvert: IConvertebelFromDao<TypeInWhichConvert, TypeFromWhichConvert>
        {

            List<TypeInWhichConvert> toReturn = new List<TypeInWhichConvert>();
            foreach (TypeFromWhichConvert s in typeFroms)
            {
              //  toReturn.Add((TypeFromWhichConvert));
            }
            return toReturn;
        }
    }
}
