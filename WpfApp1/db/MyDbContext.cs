using System;
using System.Collections.Generic;
using System.Text;
using Lab1.dto;
using Microsoft.EntityFrameworkCore;

namespace Lab1.db
{
    public class MyDbContext : DbContext
    {
        public DbSet<CPUDto> cPUDtos { get; set; }
        public DbSet<MotherboardDto> motherboardDtos { get; set; }
        public DbSet<PowerSupplyDto> powerSupplyDtos { get; set; }
        public DbSet<RAMDto> rAMDtos { get; set; }
        public DbSet<SystemUnitDto> systemUnitDtos { get; set; }

        public MyDbContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conectionString = "server=localhost;database=labdb;uid=root;pwd=root;";
            optionsBuilder.UseMySql(conectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
