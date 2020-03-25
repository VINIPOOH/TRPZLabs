using Lab1.dto;
using Lab1.model;
using Lab1Code.model;
using Microsoft.EntityFrameworkCore;

namespace Lab1.db
{

    public class RepositoryFactory
    {
        private static MyDbContext dbContext = new MyDbContext();
        private static IRepository<SystemUnitDto> sysRepository = new SysteUnitRepository(dbContext);
        private static IRepository<MotherboardDto> motherRepository = new MotherboardRepository(dbContext);
        private static IRepository<CPUDto> cpuRepository = new CPURepository(dbContext);
        private static IRepository<RAMDto> ramRepository = new RAMRepository(dbContext);
        private static IRepository<PowerSupplyDto> powerSupliRepository = new PowerSupplyRepository(dbContext);

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