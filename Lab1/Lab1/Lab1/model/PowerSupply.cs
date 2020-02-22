using Lab1.dto;
using Lab1.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Code.model
{
    class PowerSupply 
    {
        
        private PowerSupplyDto powerSupplyDtoAdaptee;

        public PowerSupply( int usingPover, int volume)
        {
            powerSupplyDtoAdaptee=new PowerSupplyDto(usingPover,volume);
        }

        public PowerSupply(PowerSupplyDto power)
        {
            powerSupplyDtoAdaptee = power;
        }

        

        public PowerSupplyDto PowerSupplyDtoAdaptee
        {
            get => powerSupplyDtoAdaptee;
            set => powerSupplyDtoAdaptee = value;
        }
        public int Volume { get => powerSupplyDtoAdaptee.Volume;
            set => powerSupplyDtoAdaptee.Volume = value; }

        public int UsingPover
        {
            get => powerSupplyDtoAdaptee.UsingPover;
            set => powerSupplyDtoAdaptee.UsingPover = value;
        }
    }
}
