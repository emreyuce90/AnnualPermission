using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories.DatabaseContext;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories
{
    public class EfPermissionRepository : EfGenericRepository<Permission>, IPermissionDal
    {
        private readonly PermissionAppContext _context;
        public EfPermissionRepository(PermissionAppContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Permission>> GetPermissionsWEmployeesAsync()
        {
            var permissions = await _context.Permissions.Include(I=>I.Employees).ToListAsync();
           return permissions;
        }
    }
}