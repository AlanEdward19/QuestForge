using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Application.Races.Create;
using QuestForge.CharacterService.Application.Races.Delete;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromServices] IHandler<CreateRaceCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateRaceCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        [HttpPatch]
        public async Task<IActionResult> Patch()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromServices] IHandler<DeleteRaceCommand, DatabaseOperationViewModel> handler,
            [FromQuery] DeleteRaceCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }
    }
}
