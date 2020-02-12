using Lab1.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    class SystemUnit
    {
        private MotherboardTypes motherboardTypes;
        private int maxPoverSupplyVolume;
        private Motherboard motherboard;
        private PowerSupply powerSupply;
        private String name;

        public SystemUnit(SystemUnitDao systemUnitDao)
        {
            this.motherboardTypes = systemUnitDao.MotherboardTypes;
            this.maxPoverSupplyVolume = systemUnitDao.MaxPoverSupplyVolume;
            if (systemUnitDao.Motherboard == null)
            {
                this.motherboard = null;
            }
            else
            {
                this.motherboard = new Motherboard(systemUnitDao.Motherboard);
            }
            if (systemUnitDao.PowerSupply == null)
            {
                this.powerSupply = null;
            }
            else
            {
                this.powerSupply = new PowerSupply(systemUnitDao.PowerSupply);
            }
            this.name = systemUnitDao.Name;
        }

        public MotherboardTypes MotherboardTypes { get => motherboardTypes; set => motherboardTypes = value; }
        public int MaxPoverSupplyVolume { get => maxPoverSupplyVolume; set => maxPoverSupplyVolume = value; }
        internal Motherboard Motherboard { get => motherboard; set => motherboard = value; }
        internal PowerSupply PowerSupply { get => powerSupply; set => powerSupply = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            String toRetutn="название корпуса"+name+" "+ "maxPoverSupplyVolume"+ maxPoverSupplyVolume+ "motherboardTypes"+ motherboardTypes;
            if (motherboard == null)
            {
                toRetutn += "motherboard" + "null";
            }
            else
            {
                toRetutn += "motherboard" + motherboard.ToString();
            }
            if (powerSupply == null)
            {
                toRetutn += "powerSupply" + "null";
            }
            else
            {
                toRetutn += "powerSupply" + powerSupply.ToString();
            }
            return toRetutn;
        }

        public SystemUnit(MotherboardTypes motherboardTypes, int maxPoverSupplyVolume, string name)
        {
            MotherboardTypes = motherboardTypes;
            MaxPoverSupplyVolume = maxPoverSupplyVolume;
            Name = name;
        }

        public bool isComponCorrect()
        {
            if (motherboard == null||powerSupply==null)
            {
                
                return false;
            }
            if (motherboard.isComponCorrect() && motherboard.MotherboardTypes.Equals(motherboardTypes)
                && powerSupply.Volume<maxPoverSupplyVolume && isEnoughPower())
            {
                
                return true;
            }
            else
            {
                
                return false;
            }    
        }

        private bool isEnoughPower()
        {
            if (powerSupply.UsingPover + motherboard.countPowerOfMatherbordAndComponents() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
