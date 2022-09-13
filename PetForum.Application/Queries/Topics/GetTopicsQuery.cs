using MediatR;
using PetForum.Application.Responses.Topics;
using System.Collections.Generic;

namespace PetForum.Application.Queries.Topics
{
    public class GetTopicsQuery : IRequest<IEnumerable<TopicResponse>>
    {
    }
}
