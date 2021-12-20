
using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.Entities.Concrete;

namespace PermissionApp.AnnualPermissionApp.DAL.Interfaces
{
    public interface IEmployeeDal : IGenericDal<Employee>
    {
        Task<List<Employee>> GetEmployeesWithPermissions(int id);
        Task<int> PermissionRightThisYear(int id);
        Task<int> PermissionRightLastYear(int id);
        

    }
}