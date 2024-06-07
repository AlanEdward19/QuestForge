using Microsoft.Extensions.DependencyInjection;
using QuestForge.CharacterService.Application.Backgrounds.Create;
using QuestForge.CharacterService.Application.Backgrounds.Delete;
using QuestForge.CharacterService.Application.Backgrounds.Get;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Create;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Delete;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Get;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Update;
using QuestForge.CharacterService.Application.Backgrounds.Update;
using QuestForge.CharacterService.Application.Characters.Create;
using QuestForge.CharacterService.Application.Characters.Delete;
using QuestForge.CharacterService.Application.Characters.Get;
using QuestForge.CharacterService.Application.Characters.Items.AddItem;
using QuestForge.CharacterService.Application.Characters.Items.RemoveItem;
using QuestForge.CharacterService.Application.Characters.Items.TradeItem;
using QuestForge.CharacterService.Application.Classes.Create;
using QuestForge.CharacterService.Application.Classes.Delete;
using QuestForge.CharacterService.Application.Classes.Get;
using QuestForge.CharacterService.Application.Common.Features.Create;
using QuestForge.CharacterService.Application.Common.Features.Delete;
using QuestForge.CharacterService.Application.Common.Features.Get;
using QuestForge.CharacterService.Application.Common.Features.Update;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Application.Items.Armors.Create;
using QuestForge.CharacterService.Application.Items.Armors.Update;
using QuestForge.CharacterService.Application.Items.Common.Get;
using QuestForge.CharacterService.Application.Items.Common.List;
using QuestForge.CharacterService.Application.Items.Others.Create;
using QuestForge.CharacterService.Application.Items.Others.Delete;
using QuestForge.CharacterService.Application.Items.Others.Update;
using QuestForge.CharacterService.Application.Items.Potions.Create;
using QuestForge.CharacterService.Application.Items.Potions.Update;
using QuestForge.CharacterService.Application.Items.Shop;
using QuestForge.CharacterService.Application.Items.Weapons.Create;
using QuestForge.CharacterService.Application.Items.Weapons.Update;
using QuestForge.CharacterService.Application.Races.Create;
using QuestForge.CharacterService.Application.Races.Delete;
using QuestForge.CharacterService.Core.Backgrounds.Aggregates;
using QuestForge.CharacterService.Core.Backgrounds.Entities;
using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Items.Entities;
using QuestForge.CharacterService.Core.Races.Entities;
using Class = QuestForge.CharacterService.Core.Classes.Entities.Class;

namespace QuestForge.CharacterService.Application;

public static class ApplicationModule
{
    public static IServiceCollection ConfigureApplication(this IServiceCollection services)
    {
        services
            .ConfigureHandlers();


        return services;
    }

    private static IServiceCollection ConfigureHandlers(this IServiceCollection services)
    {
        services

            #region Characters

            .AddScoped<IHandler<CreateCharacterCommand, DatabaseOperationViewModel>, CreateCharacterCommandHandler>()
            .AddScoped<IHandler<GetCharacterQuery, CharacterAggregateRoot>, GetCharacterQueryHandler>()
            .AddScoped<IHandler<DeleteCharacterCommand, DatabaseOperationViewModel>, DeleteCharacterCommandHandler>()

            #region Items

            .AddScoped<IHandler<AddCharacterItemCommand, DatabaseOperationViewModel>, AddCharacterItemCommandHandler>()
            .AddScoped<IHandler<DeleteCharacterItemCommand, DatabaseOperationViewModel>, DeleteCharacterItemCommandHandler>()
            .AddScoped<IHandler<TradeItemCommand, DatabaseOperationViewModel>, TradeItemCommandHandler>()
            
            #endregion

            #endregion

            #region Classes

            .AddScoped<IHandler<CreateClassCommand, DatabaseOperationViewModel>, CreateClassCommandHandler>()
            .AddScoped<IHandler<GetClassQuery, Class>, GetClassQueryHandler>()
            .AddScoped<IHandler<DeleteClassCommand, DatabaseOperationViewModel>, DeleteClassCommandHandler>()

            #endregion

            #region Races

            .AddScoped<IHandler<CreateRaceCommand, DatabaseOperationViewModel>, CreateRaceCommandHandler>()
            .AddScoped<IHandler<DeleteRaceCommand, DatabaseOperationViewModel>, DeleteRaceCommandHandler>()

            #endregion

            #region Items

            #region Others

            .AddScoped<IHandler<CreateItemCommand, DatabaseOperationViewModel>, CreateItemCommandHandler>()
            .AddScoped<IHandler<GetItemQuery, Item>, GetItemQueryHandler>()
            .AddScoped<IHandler<ListItemQuery, IEnumerable<Item>>, ListItemQueryHandler>()
            .AddScoped<IHandler<DeleteItemCommand, DatabaseOperationViewModel>, DeleteItemCommandHandler>()
            .AddScoped<IHandler<UpdateItemCommand, DatabaseOperationViewModel>, UpdateItemCommandHandler>()

            #endregion

            #region Armors

            .AddScoped<IHandler<CreateArmorCommand, DatabaseOperationViewModel>, CreateArmorCommandHandler>()
            .AddScoped<IHandler<UpdateArmorCommand, DatabaseOperationViewModel>, UpdateArmorCommandHandler>()

            #endregion

            #region Potions

            .AddScoped<IHandler<CreatePotionCommand, DatabaseOperationViewModel>, CreatePotionCommandHandler>()
            .AddScoped<IHandler<UpdatePotionCommand, DatabaseOperationViewModel>, UpdatePotionCommandHandler>()

            #endregion

            #region Weapons

            .AddScoped<IHandler<CreateWeaponCommand, DatabaseOperationViewModel>, CreateWeaponCommandHandler>()
            .AddScoped<IHandler<UpdateWeaponCommand, DatabaseOperationViewModel>, UpdateWeaponCommandHandler>()

            #endregion

            #endregion

            #region Features

            .AddScoped<IHandler<CreateFeatureCommand, DatabaseOperationViewModel>, CreateFeatureCommandHandler>()
            .AddScoped<IHandler<GetFeatureQuery, Feature>, GetFeatureQueryHandler>()
            .AddScoped<IHandler<UpdateFeatureCommand, DatabaseOperationViewModel>, UpdateFeatureCommandHandler>()
            .AddScoped<IHandler<DeleteFeatureCommand, DatabaseOperationViewModel>, DeleteFeatureCommandHandler>()

            #endregion

            #region Traits

            .AddScoped<IHandler<CreateTraitCommand, DatabaseOperationViewModel>, CreateTraitCommandHandler>()
            .AddScoped<IHandler<GetTraitQuery, Trait>, GetTraitQueryHandler>()
            .AddScoped<IHandler<UpdateTraitCommand, DatabaseOperationViewModel>, UpdateTraitCommandHandler>()
            .AddScoped<IHandler<DeleteTraitCommand, DatabaseOperationViewModel>, DeleteTraitCommandHandler>()

            #endregion

            #region Backgrounds

            .AddScoped<IHandler<CreateBackgroundCommand, DatabaseOperationViewModel>, CreateBackgroundCommandHandler>()
            .AddScoped<IHandler<GetBackgroundQuery, BackgroundAggregateRoot>, GetBackgroundQueryHandler>()
            .AddScoped<IHandler<UpdateBackgroundCommand, DatabaseOperationViewModel>, UpdateBackgroundCommandHandler>()
            .AddScoped<IHandler<DeleteBackgroundCommand, DatabaseOperationViewModel>, DeleteBackgroundCommandHandler>()

            #endregion

            #region Shops

            .AddScoped<IHandler<GenerateShopQuery, IEnumerable<Item>>, GenerateShopQueryHandler>()

            #endregion

            ;

        return services;
    }
}