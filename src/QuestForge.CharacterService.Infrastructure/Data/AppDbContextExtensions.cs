using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace QuestForge.CharacterService.Infrastructure.Data;

public static class AppDbContextExtensions
{
    public static void AddDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
    }
}