using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.BLL.Interfaces;
using PermissionApp.AnnualPermissionApp.DAL.Interfaces;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.BLL.Concrete
{
    public class EmployeeManager : GenericManager<Employee>, IEmployeeService
    {
        private readonly IGenericDal<Employee> _genericDal;
        private readonly IEmployeeDal _employeeDal;
        public EmployeeManager(IGenericDal<Employee> genericDal,IEmployeeDal employeeDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _employeeDal = employeeDal;
        }

        public Task<List<Employee>> GetEmployeesWithPermissions(int id)
        {
            return _employeeDal.GetEmployeesWithPermissions(id);
        }
    }
}