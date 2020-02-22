using Lab1.dto;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.dto;

namespace Lab1.model
{
    class EntytyConverter
    {
        public static List<SystemUnit> SystemUnitDaoToSystemUnit(List<SystemUnitDto> systemUnitDaos)
        {
            List<SystemUnit> toReturn = new List<SystemUnit>();
            foreach (SystemUnitDto s in systemUnitDaos)
            {
                toReturn.Add(new SystemUnit(s));
            }
            return toReturn;
        }
        public static List<Motherboard> MotherboardDaoToMotherboard(List<MotherboardDto> motherboards)
        {
            List<Motherboard> toReturn = new List<Motherboard>();
            foreach (MotherboardDto s in motherboards)
            {
                toReturn.Add(new Motherboard(s));
            }
            return toReturn;
        }
        public static List<CPU> CPUDaoToCPU(List<CPUDto> systemUnitDaos)
        {
            List<CPU> toReturn = new List<CPU>();
            foreach (CPUDto s in systemUnitDaos)
            {
                toReturn.Add(new CPU(s));
            }
            return toReturn;
        }
        public static List<RAM> RAMUnitDaoToRAM(List<RAMDto> systemUnitDaos)
        {
            List<RAM> toReturn = new List<RAM>();
            foreach (RAMDto s in systemUnitDaos)
            {
                toReturn.Add(new RAM(s));
            }
            return toReturn;
        }
        public static List<PowerSupply> PowerSupplyDaoToPowerSupply(List<PowerSupplyDto> systemUnitDaos)
        {
            List<PowerSupply> toReturn = new List<PowerSupply>();
            foreach (PowerSupplyDto s in systemUnitDaos)
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
