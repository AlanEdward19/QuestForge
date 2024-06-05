using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuestForge.CharacterService.Core.Characters.DataModels;

namespace QuestForge.CharacterService.Infrastructure.Configurations;

public class LevelConfiguration : IEntityTypeConfiguration<LevelDataModel>
{
    public void Configure(EntityTypeBuilder<LevelDataModel> builder)
    {
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Level).IsRequired();
        builder.Property(l => l.ExperiencePoints).IsRequired();
        builder.Property(l => l.ExperiencePointsToNextLevel).IsRequired();
    }
}