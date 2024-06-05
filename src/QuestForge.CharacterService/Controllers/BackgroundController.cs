using Microsoft.AspNetCore.Mvc;
using QuestForge.CharacterService.Application.Backgrounds.Create;
using QuestForge.CharacterService.Application.Backgrounds.Delete;
using QuestForge.CharacterService.Application.Backgrounds.Get;
using QuestForge.CharacterService.Application.Backgrounds.Update;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Backgrounds.Aggregates;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BackgroundController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IHandler<GetBackgroundQuery, BackgroundAggregateRoot> handler,
            [FromQuery] GetBackgroundQuery query, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(query, cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromServices] IHandler<CreateBackgroundCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateBackgroundCommand command, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(command, cancellationToken));
        }

        [HttpPatch]
        public async Task<IActionResult> Patch([FromServices] IHandler<UpdateBackgroundCommand, DatabaseOperationViewModel> handler,
            [FromBody] UpdateBackgroundCommand command, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(command, cancellationToken));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromServices] IHandler<DeleteBackgroundCommand, DatabaseOperationViewModel> handler,
            [FromQuery] DeleteBackgroundCommand command, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(command, cancellationToken));
        }
    }
}
