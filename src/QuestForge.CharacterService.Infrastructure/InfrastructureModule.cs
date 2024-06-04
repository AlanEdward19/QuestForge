using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Infrastructure.Repositories;

namespace QuestForge.CharacterService.Infrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .ConfigureDatabase(configuration)
            .ConfigureRepositories();

        return services;
    }

    private static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddDbContext(configuration.GetConnectionString("MainDatabase")!);

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }

    private static IServiceCollection ConfigureRepositories(this IServiceCollection services)
    {
        services
            .AddScoped<IRepository<CharacterDataModel>, CharacterRepository>()
            .AddScoped<IRepository<ClassDataModel>, ClassRepository>()
            .AddScoped<IRepository<ItemDataModel>, ItemRepository>()
            .AddScoped<IRepository<RaceDataModel>, RaceRepository>()
            .AddScoped<IRepository<FeatureDataModel>, FeatureRepository>();

        return services;
    }

    public static IApplicationBuilder UpdateMigrations(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();

        var context = serviceScope?.ServiceProvider.GetRequiredService<AppDbContext>();

        if (context != null)
        {
            try
            {
                var pendingMigrations = context.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        return app;
    }
}