using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetForum.Application.Commands.Topics;
using PetForum.Application.Queries.Topics;
using PetForum.Application.Responses.Topics;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetForum.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TopicController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TopicController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<TopicResponse>> Get()
        {
            return await _mediator.Send(new GetTopicsQuery());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<TopicResponse>> CreateTopic([FromBody] CreateTopicCommand command)
        {
            var result = _mediator.Send(command);
            return Ok(result);
        }
    }
}
