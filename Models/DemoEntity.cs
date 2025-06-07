using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    public class DemoEntity:DbContext
    {
        public DbSet<Employee> Employees { get; set; }  
        public DbSet<Department> Departments { get; set; }
        public DemoEntity():base()
        {

        }
        public DemoEntity(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //options
            optionsBuilder.UseSqlServer();
            // Configure the database connection string here
            optionsBuilder.UseSqlServer("Server=localhost;Database=DemoDB;Trusted_Connection=True;");
        }
    }
}
