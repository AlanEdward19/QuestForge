using Microsoft.AspNetCore.Mvc;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Create;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Delete;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Get;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Update;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Backgrounds.Entities;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TraitController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IHandler<GetTraitQuery, Trait> handler,
            [FromQuery] GetTraitQuery query, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(query, cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromServices] IHandler<CreateTraitCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateTraitCommand command, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(command, cancellationToken));
        }

        [HttpPatch]
        public async Task<IActionResult> Patch([FromServices] IHandler<UpdateTraitCommand, DatabaseOperationViewModel> handler,
            [FromBody] UpdateTraitCommand command, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(command, cancellationToken));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromServices] IHandler<DeleteTraitCommand, DatabaseOperationViewModel> handler,
            [FromQuery] DeleteTraitCommand command, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(command, cancellationToken));
        }
    }
}
