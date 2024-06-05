using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Application.Items.Armors.Create;
using QuestForge.CharacterService.Application.Items.Armors.Update;
using QuestForge.CharacterService.Application.Items.Common.Get;
using QuestForge.CharacterService.Application.Items.Common.List;
using QuestForge.CharacterService.Application.Items.Others.Create;
using QuestForge.CharacterService.Application.Items.Others.Delete;
using QuestForge.CharacterService.Application.Items.Potions.Create;
using QuestForge.CharacterService.Application.Items.Potions.Update;
using QuestForge.CharacterService.Application.Items.Weapons.Create;
using QuestForge.CharacterService.Application.Items.Weapons.Update;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Items.Entities;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromServices] IHandler<GetItemQuery, Item> handler,
            [FromQuery] GetItemQuery query, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(query, cancellationToken));
        }

        [HttpGet("list")]
        public async Task<IActionResult> List([FromServices] IHandler<ListItemQuery, IEnumerable<Item>> handler,
            [FromQuery] ListItemQuery query, CancellationToken cancellationToken)
        {
            return Ok(await handler.Handle(query, cancellationToken));
        }

        #region Miscellaneous

        [HttpPost("Miscellaneous")]
        public async Task<IActionResult> CreateMiscellaneous(
            [FromServices] IHandler<CreateItemCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateItemCommand command, CancellationToken cancellationToken)
        {
            command.SetType(EItemType.Miscellaneous);
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        #endregion

        #region Food and Drinks

        [HttpPost("FoodDrink")]
        public async Task<IActionResult> CreateFoodAndDrinks(
            [FromServices] IHandler<CreateItemCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateItemCommand command, CancellationToken cancellationToken)
        {
            command.SetType(EItemType.FoodAndDrink);
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        #endregion

        #region Tools

        [HttpPost("Tools")]
        public async Task<IActionResult> CreateTools(
            [FromServices] IHandler<CreateItemCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateItemCommand command, CancellationToken cancellationToken)
        {
            command.SetType(EItemType.Tool);
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        #endregion

        #region Weapon

        [HttpPost("Weapon")]
        public async Task<IActionResult> CreateWeapon(
            [FromServices] IHandler<CreateWeaponCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateWeaponCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        [HttpPatch("Weapon")]
        public async Task<IActionResult> Patch([FromServices] IHandler<UpdateWeaponCommand, DatabaseOperationViewModel> handler,
            [FromBody] UpdateWeaponCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        #endregion

        #region Armor

        [HttpPost("Armor")]
        public async Task<IActionResult> CreateArmor(
            [FromServices] IHandler<CreateArmorCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreateArmorCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        [HttpPatch("Armor")]
        public async Task<IActionResult> Patch([FromServices] IHandler<UpdateArmorCommand, DatabaseOperationViewModel> handler,
            [FromBody] UpdateArmorCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        #endregion

        #region Potion

        [HttpPost("Potion")]
        public async Task<IActionResult> CreatePotion(
            [FromServices] IHandler<CreatePotionCommand, DatabaseOperationViewModel> handler,
            [FromBody] CreatePotionCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        [HttpPatch("Potion")]
        public async Task<IActionResult> Patch([FromServices] IHandler<UpdatePotionCommand, DatabaseOperationViewModel> handler,
            [FromBody] UpdatePotionCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }

        #endregion

        [HttpDelete]
        public async Task<IActionResult> Delete([FromServices] IHandler<DeleteItemCommand, DatabaseOperationViewModel> handler,
            [FromQuery] DeleteItemCommand command, CancellationToken cancellationToken)
        {
            var result = await handler.Handle(command, cancellationToken);
            return Ok(result);
        }
    }
}
