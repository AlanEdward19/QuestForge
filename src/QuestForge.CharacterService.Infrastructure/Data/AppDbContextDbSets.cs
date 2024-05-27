using Microsoft.EntityFrameworkCore;

namespace QuestForge.CharacterService.Infrastructure.Data;

public partial class AppDbContext
{
    public DbSet<CharacterDataModel> Characters { get; set; }
    public DbSet<ClassDataModel> Classes { get; set; }
    public DbSet<RaceDataModel> Races { get; set; }
}