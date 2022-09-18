using PetForum.Core.Entities;
using PetForum.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetForum.Core.Repositories
{
    public interface IMessageRepository : IRepository<Message>
    {
        Task<IEnumerable<Message>> GetMessageByTopic(Topic topic);
    }
}
