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
        private BindingList<CPU> CPUs;
        private BindingList<RAMTypes> RAMs;
        private BindingList<PowerSupply> powerSupplies;
        private SystemUnit toReturn;

        internal BindingList<SystemUnit> SystemUnits { get => systemUnits; }
        internal BindingList<Motherboard> Motherboards { get => motherboards;  }
        internal BindingList<CPU> CPUs1 { get => CPUs;  }
        internal BindingList<RAMTypes> RAMs1 { get => RAMs;  }
        internal BindingList<PowerSupply> PowerSupplies { get => powerSupplies; }

        public ComputerBuilder()
        {
            //заполнить списки
        }

       

        public bool setChooseSystemUnit(int id)
        {

        }
        
        public bool setChooseMotherboard(int id)
        {

        }
        
        public bool setChooseRAM(int id)
        {

        }
        
        public bool setChooseCPU(int id)
        {

        }
        
        public bool setChoosePowerSupply(int id)
        {

        }


        public bool checkIsCanBeComponeSuchComputer()
        {

        }
    }
}
