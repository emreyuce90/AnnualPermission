using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.BLL.Interfaces
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        Task<List<AppUser>> GetEmployeesWithPermissions(int id);
        Task<int> PermissionRightThisYear(int id);
        Task<int> PermissionRightLastYear(int id);

        Task<List<AppUser>> GetEmployeeListsBySearchString(string searchString);
    }
}
