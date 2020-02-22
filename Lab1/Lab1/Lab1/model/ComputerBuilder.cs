using Lab1.dto;
using Lab1.db;
using Lab1.model;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lab1Code.model
{
    class ComputerBuilder
    {
        private List<SystemUnit> systemUnits;
        private List<Motherboard>  motherboards;
        private List<CPU> cPUs;
        private List<RAM> rAMs;
        private List<PowerSupply> powerSupplies;
        private SystemUnit componResult;




        internal List<SystemUnitDto> SystemUnits()
        {
            return EntytyConverter.GetAdapteesFromAdapters<SystemUnitDto,SystemUnit>(systemUnits);
        }

        internal List<MotherboardDto> Motherboards()
        {
            return EntytyConverter.GetAdapteesFromAdapters<MotherboardDto,Motherboard>(motherboards);
        }

        public List<CPUDto> CPUs()
        {
            return EntytyConverter.GetAdapteesFromAdapters<CPUDto,CPU>(cPUs);
        }

        internal List<RAMDto> RAMs()
        {
            return EntytyConverter.GetAdapteesFromAdapters<RAMDto,RAM>(rAMs);
            
        }

        internal List<PowerSupplyDto> PowerSupplies()
        {
            return EntytyConverter.GetAdapteesFromAdapters<PowerSupplyDto,PowerSupply>(powerSupplies);
            
        }

        internal SystemUnitDto ComponResult()
        {
            return componResult.GetAdaptee();
        }
        
        

        public ComputerBuilder()
        {
            systemUnits = EntytyConverter.SetAdapteesInAdapters<SystemUnitDto, SystemUnit>(SysteUnitRepository.findAll());
           motherboards = EntytyConverter.SetAdapteesInAdapters<MotherboardDto,Motherboard>(MotherboardRepository.findAll());
            cPUs = EntytyConverter.SetAdapteesInAdapters<CPUDto, CPU>(CPURepository.findAll());
            rAMs = EntytyConverter.SetAdapteesInAdapters<RAMDto,RAM>(RAMRepository.findAll());
            powerSupplies = EntytyConverter.SetAdapteesInAdapters<PowerSupplyDto,PowerSupply>(PowerSupplyRepository.findAll());
            componResult = new SystemUnit(MotherboardTypes.BIG, 500, "DEFAULT");
        }
     

        public bool setChooseSystemUnit(int id)
        {
            
            componResult = systemUnits[id];
            return true;
        }
        
        public bool setChooseMotherboard(int id)
        {
            componResult.Motherboard = motherboards[id];
            return true;
        }
        
        public bool setChooseRAM(int id)
        {
            if (componResult.Motherboard == null)
            {
                return false;
            }
            componResult.Motherboard.Ram = new RAM(rAMs[id].RamDtoAdaptee);
            return true;

        }
        
        public bool setChooseCPU(int id)
        {
            if (componResult.Motherboard==null)
            {
                return false;
            }
            componResult.Motherboard.Cpu = new CPU(cPUs[id].CpuDtoAdaptee);
            return true;
        }
        
        public bool setChoosePowerSupply(int id)
        {
            componResult.PowerSupply = powerSupplies[id];
            return true;
        }


        public bool checkIsCanBeComponeSuchComputer()
        {
            return componResult.isComponCorrect();
        }

        
    }
}
