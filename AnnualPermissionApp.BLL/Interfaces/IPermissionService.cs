using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.BLL.Interfaces
{
    public interface IPermissionService : IGenericService<Permission>
    {
        Task<List<Permission>> GetPermissionsWEmployeesAsync();
    }
}