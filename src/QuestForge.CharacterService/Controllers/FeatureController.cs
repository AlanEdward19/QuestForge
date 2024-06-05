using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestForge.CharacterService.Application.Classes.Create;
using QuestForge.CharacterService.Application.Classes.Delete;
using QuestForge.CharacterService.Application.Common.Features.Create;
using QuestForge.CharacterService.Application.Common.Features.Delete;
using QuestForge.CharacterService.Application.Common.Features.Get;
using QuestForge.CharacterService.Application.Common.Features.Update;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Races.Entities;

namespace QuestForge.CharacterService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IHandler<GetFeatureQuery, Feature> handler,
            [FromQuery] GetFeatureQuery query, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(query, cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromServices] IHandler<CreateFeatureCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateFeatureCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        [HttpPatch]
        public async Task<IActionResult> Patch([FromServices] IHandler<UpdateFeatureCommand, DatabaseOperationViewModel> handler,
            [FromBody] UpdateFeatureCommand command, [FromQuery] Guid id, CancellationToken cancellationToken)
        {
            command.SetId(id);
            var result = await handler.Handle(command, cancellationToken);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromServices] IHandler<DeleteFeatureCommand, DatabaseOperationViewModel> handler,
            [FromQuery] DeleteFeatureCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }
    }
}
