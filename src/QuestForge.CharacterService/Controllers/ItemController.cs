using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Application.Items.Create;
using QuestForge.CharacterService.Application.Items.Delete;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromServices] IHandler<CreateItemCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateItemCommand command, CancellationToken cancellationToken)
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
        public async Task<IActionResult> Delete([FromServices] IHandler<DeleteItemCommand, DatabaseOperationViewModel> handler,
            [FromQuery] DeleteItemCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }
    }
}
