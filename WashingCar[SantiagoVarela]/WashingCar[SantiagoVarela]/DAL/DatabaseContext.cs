using Microsoft.EntityFrameworkCore;
using WashingCar_SantiagoVarela_.DAL.Entities;
namespace WashingCar_SantiagoVarela_.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDetail> VehicleDetails { get; set; }
    }
}
