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
    public class EfPermissionRepository : EfGenericRepository<Permission>, IPermissionDal
    {
        private readonly PermissionAppContext _context;
        public EfPermissionRepository(PermissionAppContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CountThisYearPermissions(int id)
        {
            //Dilekçe başlangıç tarihi yılı içerisinde bulunduğumuz yıla eşit olmalı
            //bu bize 2021'in verilerini geri dönecek
            return await _context.Permissions.Where(I => I.StartDate.Year == DateTime.Now.Year && I.AppUserId == id).SumAsync(I => I.DaysCount);
        }

            public async Task<int> CountLastYearPermissions(int id)
        {
            //Dilekçe başlangıç tarihi yılı içerisinde bulunduğumuz yıla eşit olmalı
            //bu bize 2021'in verilerini geri dönecek
            return await _context.Permissions.Where(I => (I.StartDate.Year) == (DateTime.Now.Year-1) && (I.AppUserId == id)).SumAsync(I => I.DaysCount);
        }


        public async Task<List<Permission>> GetPermissionsByEmployeeIdAsync(int id)
        {
            return await _context.Permissions.Include(I => I.AppUser).Where(I => I.AppUserId == id).ToListAsync();
        }

        public async Task<List<Permission>> GetPermissionsWEmployeesAsync()
        {
            var permissions = await _context.Permissions.ToListAsync();
            return permissions;
        }
    }
}