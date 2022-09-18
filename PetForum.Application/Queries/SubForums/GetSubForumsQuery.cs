using MediatR;
using PetForum.Application.Responses.SubForums;
using System.Collections.Generic;

namespace PetForum.Application.Queries.SubForums
{
    public class GetSubForumsQuery : IRequest<IEnumerable<SubForumResponse>>
    {
    }
}
