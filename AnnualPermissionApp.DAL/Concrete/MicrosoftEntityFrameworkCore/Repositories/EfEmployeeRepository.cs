using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories.DatabaseContext;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.DAL.Concrete.MicrosoftEntityFrameworkCore.Repositories
{
    public class EfEmployeeRepository : EfGenericRepository<Employee>, IEmployeeDal
    {
        private readonly PermissionAppContext _context;
        public EfEmployeeRepository(PermissionAppContext context) : base(context)
        {
            _context = context;
        }

 

        public Task<List<Employee>> GetEmployeesWithPermissions(int id)
        {
            return _context.Employees.Where(I => I.Id == id).Include(I => I.Permissions).ToListAsync();
        }

        public async Task<int> PermissionRightLastYear(int id)
        {
            var emp = await _context.Employees.Where(I => I.Id == id).FirstOrDefaultAsync();
            //2020 -2016 =5
            if ((DateTime.Now.Year - 1) - (emp.EnterDate.Year) <= 1)
            {
                return 0;
            }
            else if ((DateTime.Now.Year - 1) - (emp.EnterDate.Year) <= 5)
            {
                return 14;
            }
            else if ((DateTime.Now.Year - 1) - (emp.EnterDate.Year) > 5 && (DateTime.Now.Year - 1) - (emp.EnterDate.Year) < 15)
            {
                return 20;
            }
            else
            {
                return 26;
            }
        }

        //Bu yıl izin hakkı
        public async Task<int> PermissionRightThisYear(int id)
        {

            var emp = await _context.Employees.Where(I => I.Id == id).FirstOrDefaultAsync();
            //2021 -2016 =5
            if (DateTime.Now.Year - emp.EnterDate.Year <= 1)
            {
                return 0;
            }
            else if (DateTime.Now.Year - emp.EnterDate.Year <= 5)
            {
                return 14;
            }
            else if (DateTime.Now.Year - emp.EnterDate.Year > 5 && DateTime.Now.Year - emp.EnterDate.Year < 15)
            {
                return 20;
            }
            else
            {
                return 26;
            }
        }
    }
}