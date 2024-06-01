using Microsoft.Extensions.DependencyInjection;
using QuestForge.CharacterService.Application.Characters.Create;
using QuestForge.CharacterService.Application.Characters.Delete;
using QuestForge.CharacterService.Application.Characters.Get;
using QuestForge.CharacterService.Application.Classes.Create;
using QuestForge.CharacterService.Application.Classes.Delete;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Application.Items.Create;
using QuestForge.CharacterService.Application.Items.Delete;
using QuestForge.CharacterService.Application.Races.Create;
using QuestForge.CharacterService.Application.Races.Delete;
using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

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
            .AddScoped<IHandler<DeleteClassCommand, DatabaseOperationViewModel>, DeleteClassCommandHandler>()
            
            .AddScoped<IHandler<CreateRaceCommand, DatabaseOperationViewModel>, CreateRaceCommandHandler>()
            .AddScoped<IHandler<DeleteRaceCommand, DatabaseOperationViewModel>, DeleteRaceCommandHandler>()
            
            .AddScoped<IHandler<CreateItemCommand, DatabaseOperationViewModel>, CreateItemCommandHandler>()
            .AddScoped<IHandler<DeleteItemCommand, DatabaseOperationViewModel>, DeleteItemCommandHandler>();
        
        return services;
    }
}