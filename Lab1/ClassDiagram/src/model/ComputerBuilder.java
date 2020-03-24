package model;

import db.RepositoryFactory;

class ComputerBuilder implements IComputerBuilder
    {
        private List<SystemUnit> systemUnits;
        private List<Motherboard>  motherboards;
        private List<CPU> cPUs;
        private List<RAM> rAMs;
        private List<PowerSupply> powerSupplies;
        private SystemUnit componResult;


        public List<SystemUnitDto> SystemUnits()
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
            return componResult.GetAdaptee();
        }
        
        

        public ComputerBuilder()
        {
            systemUnits = EntytyConverter.SetAdapteesInAdapters<SystemUnitDto, SystemUnit>(
                (RepositoryFactory.SysRepository).findAll());
           motherboards = EntytyConverter.SetAdapteesInAdapters<MotherboardDto,Motherboard>(
               (RepositoryFactory.MotherRepository).findAll());
            cPUs = EntytyConverter.SetAdapteesInAdapters<CPUDto, CPU>(
                (RepositoryFactory.CpuRepository).findAll());
            rAMs = EntytyConverter.SetAdapteesInAdapters<RAMDto,RAM>(
                (RepositoryFactory.RamRepository).findAll());
            powerSupplies = EntytyConverter.SetAdapteesInAdapters<PowerSupplyDto,PowerSupply>(
                (RepositoryFactory.PowerSupliRepository).findAll());
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

