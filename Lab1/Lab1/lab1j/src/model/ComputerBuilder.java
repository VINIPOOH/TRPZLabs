package model;


import dto.*;

import java.util.List;

public class ComputerBuilder
    {
        private java.util.List<SystemUnit> systemUnits;
        private List<Motherboard>  motherboards;
        private java.util.List<CPU> cPUs;
        private List<RAM> rAMs;
        private List<PowerSupply> powerSupplies;
        private SystemUnit componResult;




        public List<dto.SystemUnitDto> SystemUnits()
        {
            return EntytyConverter.GetAdapteesFromAdapters<SystemUnitDto,SystemUnit>(systemUnits);
        }

        public List<MotherboardDto> Motherboards()
        {
            return EntytyConverter.GetAdapteesFromAdapters<MotherboardDto,Motherboard>(motherboards);
        }

        public List<CPUDto> CPUs()
        {
            return EntytyConverter.GetAdapteesFromAdapters<CPUDto,CPU>(cPUs);
        }

        public List<RAMDto> RAMs()
        {
            return EntytyConverter.GetAdapteesFromAdapters<RAMDto,RAM>(rAMs);
            
        }

        public List<PowerSupplyDto> PowerSupplies()
        {
            return EntytyConverter.GetAdapteesFromAdapters<PowerSupplyDto,PowerSupply>(powerSupplies);
            
        }

        public SystemUnitDto ComponResult()
        {
            return null;
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
     

        public boolean setChooseSystemUnit(int id)
        {

            componResult = systemUnits.get(id);
            return true;
        }
        
        public boolean setChooseMotherboard(int id)
        {

            return true;
        }
        
        public boolean setChooseRAM(int id)
        {

            return true;

        }
        
        public boolean setChooseCPU(int id)
        {

            return true;
        }
        
        public boolean setChoosePowerSupply(int id)
        {

            return true;
        }


        public boolean checkIsCanBeComponeSuchComputer()
        {
            return true;
        }

        
    }

