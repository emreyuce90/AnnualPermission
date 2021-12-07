using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories.DatabaseContext;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories
{
    public class EfEmployeeRepository : EfGenericRepository<Employee>,IEmployeeDal
    {
        private readonly PermissionAppContext _context;
        public EfEmployeeRepository(PermissionAppContext context) : base(context)
        {
            _context = context;
        }

        public Task<List<Employee>> GetEmployeesWithPermissions(int id)
        {
           return _context.Employees.Where(I=>I.Id == id).Include(I=>I.Permissions).ToListAsync();
        }
    }
}