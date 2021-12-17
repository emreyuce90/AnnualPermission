using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.BLL.Interfaces
{
    public interface IEmployeeService : IGenericService<Employee>
    {
        Task<List<Employee>> GetEmployeesWithPermissions(int id);
        Task<int> PermissionRightThisYear(int id);
        Task<int> PermissionRightLastYear(int id);
    }
}