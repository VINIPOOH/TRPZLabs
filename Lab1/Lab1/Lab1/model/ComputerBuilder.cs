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
        private SystemUnit toReturn;

        internal BindingList<SystemUnit> SystemUnits { get => systemUnits; }
        internal BindingList<Motherboard> Motherboards { get => motherboards;  }
        internal BindingList<CPU> CPUs1 { get => cPUs;  }
        internal BindingList<RAM> RAMs1 { get => rAMs;  }
        internal BindingList<PowerSupply> PowerSupplies { get => powerSupplies; }

        public ComputerBuilder()
        {
            //заполнить списки
        }

       

        public bool setChooseSystemUnit(int id)
        {
            toReturn = systemUnits[id];
            return true;
        }
        
        public bool setChooseMotherboard(int id)
        {
            toReturn.Motherboard = motherboards[id];
            return true;
        }
        
        public bool setChooseRAM(int id)
        {
            toReturn.Motherboard.Ram = rAMs[id];
            return true;

        }
        
        public bool setChooseCPU(int id)
        {
            toReturn.Motherboard.Cpu = cPUs[id];
            return true;
        }
        
        public bool setChoosePowerSupply(int id)
        {
            toReturn.PowerSupply = powerSupplies[id];
            return true;
        }


        public bool checkIsCanBeComponeSuchComputer()
        {
            return toReturn.isComponCorrect();
        }
    }
}
