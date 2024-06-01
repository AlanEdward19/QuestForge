using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Core.Common.ValueObjects;
using QuestForge.CharacterService.Infrastructure.Configurations;

namespace QuestForge.CharacterService.Infrastructure.Data;

public partial class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CharacterConfiguration());
        modelBuilder.ApplyConfiguration(new LevelConfiguration());
    }
}