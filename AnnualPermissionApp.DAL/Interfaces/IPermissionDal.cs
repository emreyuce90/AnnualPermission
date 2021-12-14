using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.DAL.Interfaces
{
    public interface IPermissionDal : IGenericDal<Permission>
    {
        Task<List<Permission>> GetPermissionsWEmployeesAsync();
        Task <int> CountThisYearPermissions(int id);

        Task<List<Permission>> GetPermissionsByEmployeeIdAsync(int id);
    }
}
