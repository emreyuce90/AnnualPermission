using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PermissionApp.AnnualPermissionApp.Entities.Interfaces;

namespace PermissionApp.AnnualPermissionApp.DAL.Interfaces
{
    public interface IGenericDal<T> where T: class,ITable,new()
    {
        Task AddAsync(T t);
        Task UpdateAsync(T t);
        Task DeleteAsync(T t);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> filter);
        Task<List<T>> GetAllAsync<Tkey>(Expression<Func<T,bool>> filter,Expression<Func<T,Tkey>> keySelector);


    }
}