using PetForum.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace PetForum.Core.Repositories.Base
{
    public interface IRepository < T > where T : Entity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteByIdAsync(int id);
        Task Commit();
    }
}
