using System.Collections.Generic;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.Entities.Interfaces;

namespace PermissionApp.AnnualPermissionApp.BLL.Interfaces
{
    public interface IGenericService<T> where T : class, ITable, new()
    {
        Task AddAsync(T t);
        Task UpdateAsync(T t);
        Task DeleteAsync(T t);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        

    }
}
