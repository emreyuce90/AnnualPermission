using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.BLL.Concrete
{
    public class PermissionManager : GenericManager<Permission>, IPermissionService
    {
        private readonly IGenericDal<Permission> _genericDal;
        public PermissionManager(IGenericDal<Permission> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}