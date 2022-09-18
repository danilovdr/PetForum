using PetForum.Core.Entities;
using PetForum.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetForum.Core.Repositories
{
    public interface ISubForumRepository : IRepository<SubForum>
    {
        Task<IEnumerable<SubForum>> GetSubForumByName(string name);
        Task<IEnumerable<SubForum>> GetSubForumByPartialName(string name);
    }
}
