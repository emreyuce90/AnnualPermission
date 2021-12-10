using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.BLL.Concrete
{
    public class PermissionManager : GenericManager<Permission>, IPermissionService
    {
        private readonly IGenericDal<Permission> _genericDal;
        private readonly IPermissionDal _permissionDal;
        public PermissionManager(IGenericDal<Permission> genericDal,IPermissionDal permissionDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _permissionDal = permissionDal;
        }

        public async Task<List<Permission>> GetPermissionsWEmployeesAsync()
        {
          return await _permissionDal.GetPermissionsWEmployeesAsync();
        }
    }
}