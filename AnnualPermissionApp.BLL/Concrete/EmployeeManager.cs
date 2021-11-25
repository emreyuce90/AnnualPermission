using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.BLL.Concrete
{
    public class EmployeeManager : GenericManager<Employee>, IEmployeeService
    {
        private readonly IGenericDal<Employee> _genericDal;
        public EmployeeManager(IGenericDal<Employee> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}