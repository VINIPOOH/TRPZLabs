package db;

import dto.PowerSupplyDto;

import java.util.LinkedList;
import java.util.List;

class PowerSupplyRepository
    {
        public static List<PowerSupplyDto> findAll()
        {
            List<PowerSupplyDto>  powerSupplies = new LinkedList<>();
            powerSupplies.add(new PowerSupplyDto(300, -2));
            powerSupplies.add(new PowerSupplyDto(300, 2));
            return powerSupplies;
        }
    }

