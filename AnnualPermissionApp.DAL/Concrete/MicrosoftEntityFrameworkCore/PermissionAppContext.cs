using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories.DatabaseContext{
    public class PermissionAppContext:DbContext
    {
        private readonly IConfiguration  _configuraton;
        public PermissionAppContext(IConfiguration configuration)
        {
            _configuraton = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(_configuraton.GetConnectionString("db2"));           
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}