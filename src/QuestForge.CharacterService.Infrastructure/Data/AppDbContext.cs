using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Infrastructure.Configurations;

namespace QuestForge.CharacterService.Infrastructure.Data;

public partial class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CharacterConfiguration());
        modelBuilder.ApplyConfiguration(new LevelConfiguration());
        //modelBuilder.ApplyConfiguration(new RaceConfiguration());
        //modelBuilder.ApplyConfiguration(new ClassConfiguration());
        // Add configurations for other entities if needed
    }
}