using Lab1.dto;
using Lab1.model;
using Lab1Code.model;

namespace Lab1.db
{
    public class RepositoryFactory
    {
        private static IRepository<SystemUnitDto> sysRepository = new SysteUnitRepository();
        private static IRepository<MotherboardDto> motherRepository = new MotherboardRepository();
        private static IRepository<CPUDto> cpuRepository = new CPURepository();
        private static IRepository<RAMDto> ramRepository = new RAMRepository();
        private static IRepository<PowerSupplyDto> powerSupliRepository = new PowerSupplyRepository();

        public static  IRepository<SystemUnitDto> SysRepository
        {
            get => sysRepository;
        }

        public  static IRepository<MotherboardDto> MotherRepository
        {
            get => motherRepository;
        }

        public static  IRepository<CPUDto> CpuRepository
        {
            get => cpuRepository;
        }

        public static  IRepository<RAMDto> RamRepository
        {
            get => ramRepository;
        }

        public static IRepository<PowerSupplyDto> PowerSupliRepository
        {
            get => powerSupliRepository;
        }
    }
    
}