using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestForge.CharacterService.Application.Classes.Create;
using QuestForge.CharacterService.Application.Classes.Delete;
using QuestForge.CharacterService.Application.Classes.Get;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Classes.Entities;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IHandler<GetClassQuery, Class> handler,
            [FromQuery] GetClassQuery query, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(query, cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromServices] IHandler<CreateClassCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateClassCommand command, CancellationToken cancellationToken)
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
        public async Task<IActionResult> Delete([FromServices] IHandler<DeleteClassCommand, DatabaseOperationViewModel> handler,
            [FromQuery] DeleteClassCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }
    }
}
