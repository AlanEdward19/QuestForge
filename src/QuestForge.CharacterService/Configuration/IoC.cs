using QuestForge.CharacterService.Application;
using QuestForge.CharacterService.Infrastructure;

namespace QuestForge.CharacterService.Configuration;

public static class IoC
{
    public static IServiceCollection ConfigureIoC(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .ConfigureInfrastructure(configuration)
            .ConfigureApplication();

        return services;
    }
}