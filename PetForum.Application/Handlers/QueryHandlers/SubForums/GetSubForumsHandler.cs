using MediatR;
using PetForum.Application.Queries.SubForums;
using PetForum.Application.Responses.SubForums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PetForum.Application.Handlers.QueryHandlers.SubForums
{
    public class GetSubForumsHandler : IRequestHandler<GetSubForumsQuery, IEnumerable<SubForumResponse>>
    {
        public Task<IEnumerable<SubForumResponse>> Handle(GetSubForumsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Array.Empty<SubForumResponse>().AsEnumerable<SubForumResponse>());
        }
    }
}
