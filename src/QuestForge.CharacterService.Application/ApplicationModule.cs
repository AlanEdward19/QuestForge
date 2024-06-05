using Microsoft.Extensions.DependencyInjection;
using QuestForge.CharacterService.Application.Characters.Create;
using QuestForge.CharacterService.Application.Characters.Delete;
using QuestForge.CharacterService.Application.Characters.Get;
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
using QuestForge.CharacterService.Application.Items.Create;
using QuestForge.CharacterService.Application.Items.Delete;
using QuestForge.CharacterService.Application.Items.Potions.Create;
using QuestForge.CharacterService.Application.Items.Potions.Update;
using QuestForge.CharacterService.Application.Items.Weapons.Create;
using QuestForge.CharacterService.Application.Items.Weapons.Update;
using QuestForge.CharacterService.Application.Races.Create;
using QuestForge.CharacterService.Application.Races.Delete;
using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Classes.Entities;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.Entities;

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
            .AddScoped<IHandler<CreateCharacterCommand, DatabaseOperationViewModel>, CreateCharacterCommandHandler>()
            .AddScoped<IHandler<GetCharacterQuery, CharacterAggregateRoot>, GetCharacterQueryHandler>()
            .AddScoped<IHandler<DeleteCharacterCommand, DatabaseOperationViewModel>, DeleteCharacterCommandHandler>()
            
            .AddScoped<IHandler<CreateClassCommand, DatabaseOperationViewModel>, CreateClassCommandHandler>()
            .AddScoped<IHandler<GetClassQuery, Class>, GetClassQueryHandler>()
            .AddScoped<IHandler<DeleteClassCommand, DatabaseOperationViewModel>, DeleteClassCommandHandler>()
            
            .AddScoped<IHandler<CreateRaceCommand, DatabaseOperationViewModel>, CreateRaceCommandHandler>()
            .AddScoped<IHandler<DeleteRaceCommand, DatabaseOperationViewModel>, DeleteRaceCommandHandler>()
            
            .AddScoped<IHandler<CreateItemCommand, DatabaseOperationViewModel>, CreateItemCommandHandler>()
            .AddScoped<IHandler<GetItemQuery, Item>, GetItemQueryHandler>()
            .AddScoped<IHandler<ListItemQuery, IEnumerable<Item>>, ListItemQueryHandler>()
            .AddScoped<IHandler<DeleteItemCommand, DatabaseOperationViewModel>, DeleteItemCommandHandler>()

            .AddScoped<IHandler<CreateArmorCommand, DatabaseOperationViewModel>, CreateArmorCommandHandler>()
            .AddScoped<IHandler<UpdateArmorCommand, DatabaseOperationViewModel>, UpdateArmorCommandHandler>()

            .AddScoped<IHandler<CreatePotionCommand, DatabaseOperationViewModel>, CreatePotionCommandHandler>()
            .AddScoped<IHandler<UpdatePotionCommand, DatabaseOperationViewModel>, UpdatePotionCommandHandler>()

            .AddScoped<IHandler<CreateWeaponCommand, DatabaseOperationViewModel>, CreateWeaponCommandHandler>()
            .AddScoped<IHandler<UpdateWeaponCommand, DatabaseOperationViewModel>, UpdateWeaponCommandHandler>()

            .AddScoped<IHandler<CreateFeatureCommand, DatabaseOperationViewModel>, CreateFeatureCommandHandler>()
            .AddScoped<IHandler<GetFeatureQuery, Feature>, GetFeatureQueryHandler>()
            .AddScoped<IHandler<UpdateFeatureCommand, DatabaseOperationViewModel>, UpdateFeatureCommandHandler>()
            .AddScoped<IHandler<DeleteFeatureCommand, DatabaseOperationViewModel>, DeleteFeatureCommandHandler>();
        
        return services;
    }
}