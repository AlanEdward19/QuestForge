using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Classes.DataModels;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Races.DataModels;

namespace QuestForge.CharacterService.Infrastructure.Data;

public partial class AppDbContext
{
    public DbSet<BackgroundDataModel> Backgrounds { get; set; }
    public DbSet<TraitDataModel> Traits { get; set; }
    public DbSet<CharacterDataModel> Characters { get; set; }
    public DbSet<CharacterItemDataModel> CharacterItems { get; set; }
    public DbSet<CoinPurseDataModel> CoinPurses { get; set; }
    public DbSet<LevelDataModel> Levels { get; set; }
    public DbSet<BackpackDataModel> Backpacks { get; set; }
    public DbSet<ClassDataModel> Classes { get; set; }
    public DbSet<RaceDataModel> Races { get; set; }
    public DbSet<ItemDataModel> Items { get; set; }
    public DbSet<ArmorDataModel> Armors { get; set; }
    public DbSet<WeaponDataModel> Weapons { get; set; }
    public DbSet<PotionDataModel> Potions { get; set; }
    public DbSet<FeatureDataModel> Features { get; set; }
}