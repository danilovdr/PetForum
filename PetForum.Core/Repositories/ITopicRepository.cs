using PetForum.Core.Entities;
using PetForum.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetForum.Core.Repositories
{
    public interface ITopicRepository : IRepository<Topic>
    {
        Task<IEnumerable<Topic>> GetTopicByName(string name);
    }
}
