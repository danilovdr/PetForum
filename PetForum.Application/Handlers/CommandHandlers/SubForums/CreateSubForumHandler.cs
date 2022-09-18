using MediatR;
using PetForum.Application.Commands.SubForums;
using PetForum.Application.Responses.SubForums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetForum.Application.Handlers.CommandHandlers.SubForums
{
    public class CreateSubForumHandler : IRequestHandler<CreateSubForumCommand, SubForumResponse>
    {
        public Task<SubForumResponse> Handle(CreateSubForumCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
