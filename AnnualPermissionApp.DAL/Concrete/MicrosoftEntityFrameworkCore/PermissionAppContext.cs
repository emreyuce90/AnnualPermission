
using AnnualPermissionApp.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories.DatabaseContext{
    public class PermissionAppContext:IdentityDbContext<AppUser,AppRole,int>
    {
        private readonly IConfiguration  _configuraton;
        public PermissionAppContext(IConfiguration configuration)
        {
            _configuraton = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(_configuraton.GetConnectionString("db3")); 
           base.OnConfiguring(optionsBuilder);
                   
        }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}