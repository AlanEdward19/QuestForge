﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuestForge.CharacterService.Infrastructure.Data;

#nullable disable

namespace QuestForge.CharacterService.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.BackpackDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Backpacks");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.CharacterAbilityScoreDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AbilityScoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AbilityScoreId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterAbilityScoreDataModel");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.CharacterDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AppearanceDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackgroundDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BackpackId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<Guid>("LevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("RaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BackpackId");

                    b.HasIndex("ClassId");

                    b.HasIndex("LevelId");

                    b.HasIndex("RaceId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.ClassDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HitDie")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.ItemDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CurrencyType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ItemDataModel");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.LevelDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("int");

                    b.Property<int>("ExperiencePointsToNextLevel")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.PlayerItemDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BackpackDataModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsEquipped")
                        .HasColumnType("bit");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BackpackDataModelId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("ItemId");

                    b.ToTable("PlayerItemDataModel");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.RaceAbilityScoreDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AbilityScoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RaceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AbilityScoreId");

                    b.HasIndex("RaceId");

                    b.ToTable("RaceAbilityScoreDataModel");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.RaceDataModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.ValueObjects.AbilityScoreValueObject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AbilityScore")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AbilityScoreValueObject");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.CharacterAbilityScoreDataModel", b =>
                {
                    b.HasOne("QuestForge.CharacterService.Core.Common.ValueObjects.AbilityScoreValueObject", "AbilityScore")
                        .WithMany()
                        .HasForeignKey("AbilityScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestForge.CharacterService.Core.Common.DataModels.CharacterDataModel", "Character")
                        .WithMany("AbilityScores")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AbilityScore");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.CharacterDataModel", b =>
                {
                    b.HasOne("QuestForge.CharacterService.Core.Common.DataModels.BackpackDataModel", "Backpack")
                        .WithMany()
                        .HasForeignKey("BackpackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestForge.CharacterService.Core.Common.DataModels.ClassDataModel", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestForge.CharacterService.Core.Common.DataModels.LevelDataModel", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestForge.CharacterService.Core.Common.DataModels.RaceDataModel", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Backpack");

                    b.Navigation("Class");

                    b.Navigation("Level");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.PlayerItemDataModel", b =>
                {
                    b.HasOne("QuestForge.CharacterService.Core.Common.DataModels.BackpackDataModel", null)
                        .WithMany("Items")
                        .HasForeignKey("BackpackDataModelId");

                    b.HasOne("QuestForge.CharacterService.Core.Common.DataModels.CharacterDataModel", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestForge.CharacterService.Core.Common.DataModels.ItemDataModel", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.RaceAbilityScoreDataModel", b =>
                {
                    b.HasOne("QuestForge.CharacterService.Core.Common.ValueObjects.AbilityScoreValueObject", "AbilityScore")
                        .WithMany()
                        .HasForeignKey("AbilityScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuestForge.CharacterService.Core.Common.DataModels.RaceDataModel", "Race")
                        .WithMany("AbilityScoreIncrease")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AbilityScore");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.BackpackDataModel", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.CharacterDataModel", b =>
                {
                    b.Navigation("AbilityScores");
                });

            modelBuilder.Entity("QuestForge.CharacterService.Core.Common.DataModels.RaceDataModel", b =>
                {
                    b.Navigation("AbilityScoreIncrease");
                });
#pragma warning restore 612, 618
        }
    }
}
