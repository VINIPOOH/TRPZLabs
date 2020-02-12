using Lab1.dao;
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

        internal List<SystemUnit> SystemUnits { get => systemUnits; set => systemUnits = value; }
        internal List<Motherboard> Motherboards { get => motherboards; set => motherboards = value; }
        public List<CPU> CPUs { get => cPUs; set => cPUs = value; }
        internal List<RAM> RAMs { get => rAMs; set => rAMs = value; }
        internal List<PowerSupply> PowerSupplies { get => powerSupplies; set => powerSupplies = value; }
        internal SystemUnit ComponResult { get => componResult; set => componResult = value; }

        public ComputerBuilder()
        {
            //заполнить списки

            systemUnits = EntytyConverter.SystemUnitDaoToSystemUnit(SysteUnitRepository.findAll());
            systemUnits.Add(new SystemUnit(MotherboardTypes.BIG,1000,"BIG"));
            systemUnits.Add(new SystemUnit(MotherboardTypes.BIG, 100, "BIG100"));
            systemUnits.Add(new SystemUnit(MotherboardTypes.BIG, 500, "BIG"));

            motherboards = new List<Motherboard>();
            motherboards.Add(new Motherboard(MotherboardTypes.BIG,RAMTypes.BIG,CPUTypes.BIG,30));
            motherboards.Add(new Motherboard(MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, 130));
            motherboards.Add(new Motherboard(MotherboardTypes.BIG, RAMTypes.SMOLLE, CPUTypes.BIG, 30));

            cPUs = new List<CPU>();
            cPUs.Add(new CPU(CPUTypes.SMOLLE, 200));
            cPUs.Add(new CPU(CPUTypes.BIG, 300));

            rAMs = new List<RAM>();
            rAMs.Add(new RAM(RAMTypes.SMOLLE,100));
            rAMs.Add(new RAM(RAMTypes.BIG, 100));

            powerSupplies = new List<PowerSupply>();
            powerSupplies.Add(new PowerSupply(300, -2));
            powerSupplies.Add(new PowerSupply(300, 2));

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
            componResult.Motherboard.Ram = rAMs[id];
            return true;

        }
        
        public bool setChooseCPU(int id)
        {
            if (componResult.Motherboard==null)
            {
                return false;
            }
            componResult.Motherboard.Cpu = cPUs[id];
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
