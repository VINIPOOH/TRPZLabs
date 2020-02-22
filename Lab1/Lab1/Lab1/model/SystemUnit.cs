using Lab1.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.dto;
using Lab1.model;

namespace Lab1Code.model
{
    class SystemUnit : IAdapter<SystemUnitDto>
    {
        private SystemUnitDto systemUnitDtoAdaptee;

        public SystemUnit(SystemUnitDto systemUnitDto)
        {
            systemUnitDtoAdaptee = systemUnitDto;
        }

        public MotherboardTypes MotherboardTypes { get => systemUnitDtoAdaptee.MotherboardTypes;
            set => systemUnitDtoAdaptee.MotherboardTypes = value; }
        public int MaxPoverSupplyVolume { get => systemUnitDtoAdaptee.MaxPoverSupplyVolume;
            set => systemUnitDtoAdaptee.MaxPoverSupplyVolume = value; }
        internal Motherboard Motherboard { 
            get => new Motherboard(systemUnitDtoAdaptee.MotherboardDto);
            set => systemUnitDtoAdaptee.MotherboardDto = value.MotherboardDtoAdaptee; }
        internal PowerSupply PowerSupply {
            get => new PowerSupply(systemUnitDtoAdaptee.PowerSupplyDto);
            set => systemUnitDtoAdaptee.PowerSupplyDto = value.PowerSupplyDtoAdaptee; }
        public string Name { get => systemUnitDtoAdaptee.Name;
            set => systemUnitDtoAdaptee.Name = value; }

        public override string ToString()
        {
            
            return systemUnitDtoAdaptee.ToString();
        }

        public SystemUnit(MotherboardTypes motherboardTypes, int maxPoverSupplyVolume, string name)
        {
            systemUnitDtoAdaptee = new SystemUnitDto(motherboardTypes, maxPoverSupplyVolume,null
                ,null,name);
        }

        public bool isComponCorrect()
        {
            if (systemUnitDtoAdaptee.MotherboardDto == null
                ||systemUnitDtoAdaptee.PowerSupplyDto==null)
            {
                
                return false;
            }

            Motherboard motherboardForChecing = new Motherboard(systemUnitDtoAdaptee.MotherboardDto);
            PowerSupply powerSupplyForChecing = new PowerSupply(systemUnitDtoAdaptee.PowerSupplyDto);
            if (motherboardForChecing.isComponCorrect() 
                && motherboardForChecing.MotherboardTypes.Equals(systemUnitDtoAdaptee.MotherboardTypes)
                && powerSupplyForChecing.Volume<systemUnitDtoAdaptee.MaxPoverSupplyVolume 
                && isEnoughPower())
            {
                return true;
            }else
            {
                
                return false;
            }    
        }

        private bool isEnoughPower()
        {
            Motherboard motherboardForChecing = new Motherboard(systemUnitDtoAdaptee.MotherboardDto);
            PowerSupply powerSupplyForChecing = new PowerSupply(systemUnitDtoAdaptee.PowerSupplyDto);

            if (powerSupplyForChecing.UsingPover + 
                motherboardForChecing.countPowerOfMatherbordAndComponents() >= 0)
            {
                return true;
            }else{
                return false;
            }

        }

        public SystemUnitDto GetAdaptee()
        {
            return systemUnitDtoAdaptee;
        }

        public void SetAdaptee(SystemUnitDto adaptee)
        {
            systemUnitDtoAdaptee = adaptee;
        }

        public SystemUnit()
        {
        }
    }
}
