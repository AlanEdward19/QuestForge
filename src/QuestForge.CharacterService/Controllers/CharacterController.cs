using Microsoft.AspNetCore.Mvc;
using QuestForge.CharacterService.Application.Characters.Create;
using QuestForge.CharacterService.Application.Characters.Delete;
using QuestForge.CharacterService.Application.Characters.Get;
using QuestForge.CharacterService.Application.Characters.Items.AddItem;
using QuestForge.CharacterService.Application.Characters.Items.RemoveItem;
using QuestForge.CharacterService.Application.Characters.Items.TradeItem;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IHandler<GetCharacterQuery, CharacterAggregateRoot> handler,
            [FromQuery] GetCharacterQuery query, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(query, cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Post(
            [FromServices] IHandler<CreateCharacterCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateCharacterCommand command, CancellationToken cancellationToken)
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
        public async Task<IActionResult> Delete([FromServices] IHandler<DeleteCharacterCommand, DatabaseOperationViewModel> handler,
            [FromQuery] DeleteCharacterCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }
        
        [HttpPost("giveItem")]
        public async Task<IActionResult> GiveItem([FromServices] IHandler<AddCharacterItemCommand, DatabaseOperationViewModel> handler,
            [FromBody] AddCharacterItemCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }
        
        [HttpPut("tradeItem")]
        public async Task<IActionResult> TradeItem([FromServices] IHandler<TradeItemCommand, DatabaseOperationViewModel> handler,
            [FromBody] TradeItemCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }
        
        [HttpDelete("removeItem")]
        public async Task<IActionResult> RemoveItem([FromServices] IHandler<DeleteCharacterItemCommand, DatabaseOperationViewModel> handler,
            [FromBody] DeleteCharacterItemCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }
    }
}