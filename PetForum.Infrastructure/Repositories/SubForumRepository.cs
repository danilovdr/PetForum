using Microsoft.EntityFrameworkCore;
using PetForum.Core.Entities;
using PetForum.Core.Repositories;
using PetForum.Infrastructure.Data;
using PetForum.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetForum.Infrastructure.Repositories
{
    public class SubForumRepository : Repository<SubForum>, ISubForumRepository
    {
        public SubForumRepository(PetForumContext petForumContext) : base(petForumContext)
        {
        }

        public async Task<IEnumerable<SubForum>> GetSubForumByName(string name)
        {
            return await _petForumContext.SubForums.Where(m => m.Name == name).ToListAsync();
        }

        public async Task<IEnumerable<SubForum>> GetSubForumByPartialName(string name)
        {
            return await _petForumContext.SubForums.Where(m => m.Name.Contains(name)).ToListAsync();
        }
    }
}
