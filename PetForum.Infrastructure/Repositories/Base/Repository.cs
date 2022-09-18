using PetForum.Core.Entities.Base;
using PetForum.Core.Repositories.Base;
using PetForum.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetForum.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly PetForumContext _petForumContext;

        public Repository(PetForumContext petForumContext)
        {
            _petForumContext = petForumContext;
        }

        public Task AddAsync(T entity)
        {
            return _petForumContext.Set<T>().AddAsync(entity).AsTask();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Commit()
        {
            return _petForumContext.SaveChangesAsync();
        }
    }
}
