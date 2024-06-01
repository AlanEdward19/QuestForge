using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Infrastructure.Data;

public partial class AppDbContext
{
    public DbSet<CharacterDataModel> Characters { get; set; }
    public DbSet<LevelDataModel> Levels { get; set; }
    public DbSet<BackpackDataModel> Backpacks { get; set; }
    public DbSet<ClassDataModel> Classes { get; set; }
    public DbSet<RaceDataModel> Races { get; set; }
    public DbSet<ItemDataModel> Items { get; set; }
}