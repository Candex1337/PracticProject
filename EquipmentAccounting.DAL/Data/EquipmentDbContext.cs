using Microsoft.EntityFrameworkCore;
using System.Configuration;
using EquipmentAccounting.DAL.Entities;

namespace EquipmentAccounting.DAL.Data
{
    public class EquipmentDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<EquipmentStatus> EquipmentStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
