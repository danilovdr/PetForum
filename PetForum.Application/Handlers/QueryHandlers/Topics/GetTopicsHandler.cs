using MediatR;
using PetForum.Application.Queries.Topics;
using PetForum.Application.Responses.Topics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PetForum.Application.Handlers.QueryHandlers.Topics
{
    public class GetTopicsHandler : IRequestHandler<GetTopicsQuery, IEnumerable<TopicResponse>>
    {
        public Task<IEnumerable<TopicResponse>> Handle(GetTopicsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Array.Empty<TopicResponse>().AsEnumerable<TopicResponse>());
        }
    }
}
