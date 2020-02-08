using Lab1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    class ComputerBuilder
    {
        private BindingList<SystemUnit> systemUnits;
        private BindingList<Motherboard>  motherboards;
        private BindingList<CPU> cPUs;
        private BindingList<RAM> rAMs;
        private BindingList<PowerSupply> powerSupplies;
        private SystemUnit componResult;

        internal BindingList<SystemUnit> SystemUnits { get => systemUnits; set => systemUnits = value; }
        internal BindingList<Motherboard> Motherboards { get => motherboards; set => motherboards = value; }
        public BindingList<CPU> CPUs { get => cPUs; set => cPUs = value; }
        internal BindingList<RAM> RAMs { get => rAMs; set => rAMs = value; }
        internal BindingList<PowerSupply> PowerSupplies { get => powerSupplies; set => powerSupplies = value; }
        internal SystemUnit ComponResult { get => componResult; set => componResult = value; }

        public ComputerBuilder()
        {
            //заполнить списки
            systemUnits = new BindingList<SystemUnit>();//спросить про ИДЕЕ!!!
            systemUnits.Add(new SystemUnit(MotherboardTypes.BIG,1000,"BIG"));
            systemUnits.Add(new SystemUnit(MotherboardTypes.BIG, 100, "BIG100"));
            systemUnits.Add(new SystemUnit(MotherboardTypes.BIG, 500, "BIG"));

            motherboards = new BindingList<Motherboard>();
            motherboards.Add(new Motherboard(MotherboardTypes.BIG,RAMTypes.BIG,CPUTypes.BIG,30));
            motherboards.Add(new Motherboard(MotherboardTypes.BIG, RAMTypes.BIG, CPUTypes.BIG, 130));
            motherboards.Add(new Motherboard(MotherboardTypes.BIG, RAMTypes.SMOLLE, CPUTypes.BIG, 30));

            cPUs = new BindingList<CPU>();
            cPUs.Add(new CPU(CPUTypes.SMOLLE, 200));
            cPUs.Add(new CPU(CPUTypes.BIG, 300));

            rAMs = new BindingList<RAM>();
            rAMs.Add(new RAM(RAMTypes.SMOLLE,100));
            rAMs.Add(new RAM(RAMTypes.BIG, 100));

            powerSupplies = new BindingList<PowerSupply>();
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
            componResult.Motherboard.Cpu = cPUs[id];
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
