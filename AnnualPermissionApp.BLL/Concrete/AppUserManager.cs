using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.BLL.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IGenericDal<AppUser> _genericDal;
        private readonly IAppUserDal _appuserDal;
        public AppUserManager(IGenericDal<AppUser> genericDal,IAppUserDal appuserDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _appuserDal = appuserDal;
        }

        public async Task<List<AppUser>> GetEmployeeListsBySearchString(string searchString)
        {
              return await _genericDal.GetAllAsync(I=> I.Name.ToLower().Contains(searchString.ToLower()) || I.Surname.ToLower().Contains(searchString.ToLower()));
        }

        public Task<List<AppUser>> GetEmployeesWithPermissions(int id)
        {
           return _appuserDal.GetEmployeesWithPermissions(id);
        }

        public async Task<int> PermissionRightLastYear(int id)
        {
             return await _appuserDal.PermissionRightLastYear(id);
        }

        public async Task<int> PermissionRightThisYear(int id)
        {
            return await _appuserDal.PermissionRightThisYear(id);
        }
    }
}