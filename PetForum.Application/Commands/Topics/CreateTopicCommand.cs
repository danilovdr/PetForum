using MediatR;
using PetForum.Application.Responses.Topics;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetForum.Application.Commands.Topics
{
    public class CreateTopicCommand : IRequest<TopicResponse>
    {
    }
}
