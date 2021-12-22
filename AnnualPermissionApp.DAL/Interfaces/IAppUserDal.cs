using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.DAL.Interfaces
{
    public interface IAppUserDal:IGenericDal<AppUser>
    {
        Task<List<AppUser>> GetEmployeesWithPermissions(int id);
        Task<int> PermissionRightThisYear(int id);
        Task<int> PermissionRightLastYear(int id);
    }
}