using System.Data.Entity;

namespace OracleConnectionApp.Models
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HR");
        }
    }
}