using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.DAL.Interfaces
{
    public interface IPermissionDal : IGenericDal<Permission>
    {
        Task<List<Permission>> GetPermissionsWEmployeesAsync();
    }
}
