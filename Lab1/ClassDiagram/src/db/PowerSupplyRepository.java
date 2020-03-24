package db;

    class PowerSupplyRepository implements IRepository<PowerSupplyDto>
    {
      

        List<PowerSupplyDto> IRepository<PowerSupplyDto>.findAll()
        {
            List<PowerSupplyDto>  powerSupplies = new List<PowerSupplyDto>();
            powerSupplies.Add(new PowerSupplyDto(300, -2));
            powerSupplies.Add(new PowerSupplyDto(300, 2));
            return powerSupplies;
        }
    }
