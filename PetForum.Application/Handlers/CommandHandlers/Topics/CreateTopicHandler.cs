using MediatR;
using PetForum.Application.Commands.Topics;
using PetForum.Application.Responses.Topics;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PetForum.Application.Handlers.CommandHandlers.Topics
{
    public class CreateTopicHandler : IRequestHandler<CreateTopicCommand, TopicResponse>
    {
        public Task<TopicResponse> Handle(CreateTopicCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
