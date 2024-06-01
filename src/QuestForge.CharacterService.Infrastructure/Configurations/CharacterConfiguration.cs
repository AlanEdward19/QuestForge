using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Infrastructure.Configurations;

public class CharacterConfiguration : IEntityTypeConfiguration<CharacterDataModel>
{
    public void Configure(EntityTypeBuilder<CharacterDataModel> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
        
        builder.HasOne(c => c.Race)
            .WithMany()
            .HasForeignKey(c => c.RaceId);
        
        builder.HasOne(c => c.Class)
            .WithMany()
            .HasForeignKey(c => c.ClassId);
        
        builder.HasOne(c => c.Backpack)
            .WithMany()
            .HasForeignKey(c => c.BackpackId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(c => c.Level)
            .WithMany()
            .HasForeignKey(c => c.LevelId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}