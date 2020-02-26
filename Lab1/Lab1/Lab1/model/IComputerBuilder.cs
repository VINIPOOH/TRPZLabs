using System.Collections.Generic;
using Lab1.dto;

namespace Lab1.model
{
    public interface IComputerBuilder
    {
        List<SystemUnitDto> SystemUnits();
        List<MotherboardDto> Motherboards();
        List<CPUDto> CPUs();
        List<RAMDto> RAMs();
        List<PowerSupplyDto> PowerSupplies();
        SystemUnitDto ComponResult();
        bool setChooseSystemUnit(int id);
        bool setChooseMotherboard(int id);
        bool setChooseRAM(int id);
        bool setChooseCPU(int id);
        bool setChoosePowerSupply(int id);
        bool checkIsCanBeComponeSuchComputer();
    }
}