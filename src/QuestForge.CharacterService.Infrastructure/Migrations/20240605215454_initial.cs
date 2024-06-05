using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestForge.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbilityScoreValueObject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AbilityScore = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScoreValueObject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proficiencies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InitialWealth = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Backpacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backpacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HitDie = table.Column<int>(type: "int", nullable: false),
                    ArmorProficiencies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeaponProficiencies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToolProficiencies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SavingThrows = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillsProficiencies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoinPurses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gold = table.Column<int>(type: "int", nullable: false),
                    Silver = table.Column<int>(type: "int", nullable: false),
                    Copper = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinPurses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    CurrencyType = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: true),
                    ArmorType = table.Column<int>(type: "int", nullable: true),
                    Modifier = table.Column<int>(type: "int", nullable: true),
                    MaxModifier = table.Column<int>(type: "int", nullable: true),
                    MinStrength = table.Column<int>(type: "int", nullable: true),
                    StealthDisadvantage = table.Column<bool>(type: "bit", nullable: true),
                    Dice = table.Column<int>(type: "int", nullable: true),
                    DiceCount = table.Column<int>(type: "int", nullable: true),
                    Bonus = table.Column<int>(type: "int", nullable: true),
                    Effect = table.Column<int>(type: "int", nullable: true),
                    WeaponDataModel_Dice = table.Column<int>(type: "int", nullable: true),
                    DamageType = table.Column<int>(type: "int", nullable: true),
                    WeaponDataModel_DiceCount = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ExperiencePoints = table.Column<int>(type: "int", nullable: false),
                    ExperiencePointsToNextLevel = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Movement = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BackgroundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Traits_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundDataModelItemDataModel",
                columns: table => new
                {
                    BackgroundsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundDataModelItemDataModel", x => new { x.BackgroundsId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_BackgroundDataModelItemDataModel_Backgrounds_BackgroundsId",
                        column: x => x.BackgroundsId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundDataModelItemDataModel_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AppearanceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BackpackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoinPurseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BackgroundId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Backpacks_BackpackId",
                        column: x => x.BackpackId,
                        principalTable: "Backpacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_CoinPurses_CoinPurseId",
                        column: x => x.CoinPurseId,
                        principalTable: "CoinPurses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeatureDataModelRaceDataModel",
                columns: table => new
                {
                    FeaturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RacesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureDataModelRaceDataModel", x => new { x.FeaturesId, x.RacesId });
                    table.ForeignKey(
                        name: "FK_FeatureDataModelRaceDataModel_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureDataModelRaceDataModel_Races_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceAbilityScoreDataModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AbilityScoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceAbilityScoreDataModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceAbilityScoreDataModel_AbilityScoreValueObject_AbilityScoreId",
                        column: x => x.AbilityScoreId,
                        principalTable: "AbilityScoreValueObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceAbilityScoreDataModel_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAbilityScoreDataModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AbilityScoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAbilityScoreDataModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterAbilityScoreDataModel_AbilityScoreValueObject_AbilityScoreId",
                        column: x => x.AbilityScoreId,
                        principalTable: "AbilityScoreValueObject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterAbilityScoreDataModel_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerItemDataModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsEquipped = table.Column<bool>(type: "bit", nullable: false),
                    BackpackDataModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItemDataModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerItemDataModel_Backpacks_BackpackDataModelId",
                        column: x => x.BackpackDataModelId,
                        principalTable: "Backpacks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlayerItemDataModel_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerItemDataModel_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("088cb32e-6c9e-4faf-b4bb-4983eb4614e4"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7270), "Elfos não precisam dormir. Ao invés disso, \r\neles meditam profundamente, permanecendo \r\nsemiconscientes, durante 4 horas por dia. (A palavra em \r\nidioma comum para tal meditação é \"transe\".) Enquanto \r\nmedita, um elfo é capaz de sonhar de certo modo. Esses \r\nsonhos na verdade são exercícios mentais que se tornam \r\nreflexos através de anos de prática. Depois de descansar \r\ndessa forma, você ganha os mesmos benefícios que um \r\nhumano depois de 8 horas de sono. ", "Transe", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7270) },
                    { new Guid("0df7e234-e31e-4248-b248-4054904c123e"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7294), "Você conhece o truque \r\ntaumaturgia. Quando você atingir o 3° nível, você poderá \r\nconjurar a magia repreensão infernal como uma magia de \r\n2° nível. Quando você atingir o 5° nível, você também \r\npoderá conjurar a magia escuridão. Você precisa terminar \r\num descanso longo para poder usar as magias desse traço \r\nnovamente. Sua habilidade de conjuração para essas \r\nmagias é Carisma.", "Legado Infernal", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7294) },
                    { new Guid("29b9bc29-a691-4d37-bb38-dde1c986acdb"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7281), "Você possui resistência ao tipo \r\nde dano associado ao seu ancestral dracônico.", "Resistência a Dano", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7281) },
                    { new Guid("2b4106fc-b0a2-4101-a4b0-f74bb8fb9720"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7279), "Você pode mover-se através do \r\nespaço de qualquer criatura que for de um tamanho maior \r\nque o seu.", "Agilidade Halfling", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7279) },
                    { new Guid("2d00735d-2924-4da3-8040-6286e5d48bd3"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7274), "Você possui o truque globos de luz. \r\nQuando você alcança o 3° nível, você pode conjurar a \r\nmagia fogo das fadas. Quando você alcança o 5° nível, \r\nvocê pode conjurar escuridão. Você precisa terminar um \r\ndescanso longo para poder conjurar as magias desse traço \r\nnovamente. Carisma é sua habilidade chave para \r\nconjurar essas magias.", "Magia Drow", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7274) },
                    { new Guid("444df1b0-fdff-480e-817b-0edce6076758"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7283), "Você possui vantagem em todos \r\nos testes de resistência de Inteligência, Sabedoria e \r\nCarisma contra magia.", "Esperteza Gnômica", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7283) },
                    { new Guid("48a7edd4-9795-438b-b702-f185868fdcff"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7271), "Você pode tentar se esconder \r\nmesmo quando você está apenas levemente obscurecido  \r\npor folhagem, chuva forte, neve caindo, névoa ou outro \r\nfenômeno natural.", "Máscara da Natureza", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7271) },
                    { new Guid("57edabdc-f228-43a3-ac97-4fdbe92ce3b2"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7292), "Você possui resistência a dano \r\nde fogo.", "Resistência Infernal", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7292) },
                    { new Guid("5ea96e23-471b-420d-b61c-d017d775fc67"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7278), "Você tem vantagem em testes de resistência \r\ncontra ficar amedrontado. ", "Bravura", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7278) },
                    { new Guid("5fbaae9a-6a7e-44f3-bbb3-bbcc4b0cf166"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7272), "Você possui \r\ndesvantagem nas jogadas de ataque e testes de Sabedoria \r\n(Percepção) relacionados a visão quando você, o alvo do \r\nseu ataque, ou qualquer coisa que você está tentando \r\nperceber, esteja sob luz solar direta.", "Sensibilidade à Luz Solar", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7272) },
                    { new Guid("5fe3d2a6-96f3-4602-b689-e09c8cb8b4f6"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7267), "Você tem proficiência na perícia \r\nPercepção.", "Sentidos Aguçados", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7267) },
                    { new Guid("6099b4c2-2f16-4828-bcc1-18fc17b3f06a"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7284), "Você conhece o truque ilusão \r\nmenor. Inteligência é a sua habilidade usada para \r\nconjurá-la.", "Ilusionista Nato", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7284) },
                    { new Guid("636c31c4-ec8e-4d3d-b648-1bcacf190ed6"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7289), "Você possui proficiência com \r\nferramentas de artesão (ferramentas de engenhoqueiro). \r\nUsando essas ferramentas, você pode gastar 1 hora e 10 \r\npo em materiais para construir um mecanismo Miúdo (CA \r\n5, 1 pv). O mecanismo para de funcionar após 24 horas (a \r\nnão ser que você gaste 1 hora reparando-o para manter o \r\nmecanismo funcionando), ou quando você usa sua ação \r\npara desmantelá-lo; nesse momento, você pode recuperar \r\no material usado para criá-lo. Você pode ter até três\r\n desses mecanismos ativos ao mesmo tempo.", "Engenhoqueiro", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7289) },
                    { new Guid("6b85127e-346f-45c8-aa39-1d4f344ebdc1"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7266), "Sempre que você \r\nrealizar um teste de Inteligência (História) relacionado à \r\norigem de um trabalho em pedra, você é considerado \r\nproficiente na perícia História e adiciona o dobro do seu \r\nbônus de proficiência ao teste, ao invés do seu bônus de \r\nproficiência normal.", "Especialização em Rochas", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7266) },
                    { new Guid("88850d4d-ae1c-4691-8edc-68c57103ce7a"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7286), "Toda vez que você fizer \r\num teste de Inteligência (História) relacionado a itens \r\nmágicos, objetos alquímicos ou mecanismos tecnológicos, \r\nvocê pode adicionar o dobro do seu bônus de proficiência, \r\nao invés de qualquer bônus de proficiência que você \r\nnormalmente use.", "Conhecimento de Artífice", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7286) },
                    { new Guid("9e31e099-41fe-451d-8f7c-d460eda281d4"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7268), "Você tem vantagem nos testes de \r\nresistência para resistir a ser enfeitiçado e magias não \r\npodem colocá-lo para dormir.", "Ancestral Feérico", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7268) },
                    { new Guid("a018bbfb-3b98-483f-a8cf-654251a4175f"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7285), "Através de sons e \r\ngestos, você pode comunicar ideias simples para Bestas \r\npequenas ou menores. Gnomos da floresta amam os \r\nanimais e normalmente possuem esquilos, doninhas, \r\ncoelhos, toupeiras, pica-paus e outras criaturas como \r\namados animais de estimação.", "Falar com Bestas Pequenas", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7285) },
                    { new Guid("a4b3eab9-4141-48ce-ae6b-d337a746aab9"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7291), "Quando você atinge um ataque \r\ncrítico com uma arma corpo-a-corpo, você pode rolar um \r\ndos dados de dano da arma mais uma vez e adicioná-lo ao \r\ndano extra causado pelo acerto crítico.", "Ataques Selvagens", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7291) },
                    { new Guid("b69eaa74-b99d-4709-ac1c-ac3bf99f5cf8"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7261), "Acostumado à vida subterrânea, \r\nvocê tem uma visão superior no escuro e na penumbra. \r\nVocê enxerga na penumbra a até 18 metros como se fosse \r\nluz plena, e no escuro como se fosse na penumbra. Você \r\nnão pode discernir cores no escuro, apenas tons de cinza.", "Visão no Escuro", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7261) },
                    { new Guid("c9481a3a-a4e2-4450-b125-3b629cee77fc"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7280), "Você pode usar uma ação para \r\nexalar energia destrutiva. Seu ancestral dracônico \r\ndetermina o tamanho, formado e tipo de dano que você \r\nexpele. \r\nQuando você usa sua arma de sopro, cada criatura na \r\nárea exalada deve realizar um teste de resistência, o tipo \r\ndo teste é determinado pelo seu ancestral dracônico. A CD \r\ndo teste de resistência é 8 + seu modificador de \r\nConstituição + seu bônus de proficiência. Uma criatura \r\nsofre 2d6 de dano num fracasso e metade desse dano num \r\nsucesso. O dano aumenta para 3d6 no 6° nível, 4d6 no 11° \r\nnível e 5d6 no 16° nível. \r\nDepois de usar sua arma de sopro, você não poderá \r\nutilizá-la novamente até completar um descanso curto ou \r\nlongo.", "Arma de Sopro", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7280) },
                    { new Guid("c9fbc923-3afc-4acf-b110-03947840ce5e"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7263), " Você possui vantagem em testes de \r\nresistência contra venenos e resistência contra dano de \r\nveneno.", "Resiliência Anã", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7263) },
                    { new Guid("cbd00e56-1572-41fe-818e-ed950078d1c7"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7275), "Quando você obtiver um 1 natural em uma \r\njogada de ataque, teste de habilidade ou teste de \r\nresistência, você pode jogar de novo o dado e deve utilizar \r\no novo resultado.", "Sortudo", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7275) },
                    { new Guid("fdb650d8-7c62-4a61-b65d-f1816032c3b0"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7290), "Quando você é reduzido a \r\n0 pontos de vida mas não é completamente morto, você \r\npode voltar para 1 ponto de vida. Você não pode usar essa \r\ncaracterística novamente até completar um descanso \r\nlongo.", "Resistência Implacável", new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7290) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("01283b92-971d-4d37-becb-320b26b06040"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7107), 0, "", 4, "Utensílios de Cozinheiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7107), 1.0, 4.0 },
                    { new Guid("05214520-26fd-4bb9-bdca-bcbad81bd6e0"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6925), 2, "", 4, "Piton", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6925), 5.0, 0.0 },
                    { new Guid("06aad50f-24e6-40db-9090-3315dacb5f18"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7099), 0, "", 4, "Ferramentas de Sapateiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7099), 5.0, 2.5 },
                    { new Guid("07211498-e7cf-4ac8-90f8-5a476523ed1d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6919), 0, "", 4, "Perfume (frasco)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6919), 5.0, 0.0 },
                    { new Guid("0ae7a320-b863-445d-b39a-c438adce6931"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6917), 0, "Usar um pé de cabra concede vantagem \r\nnos testes de Força onde uma alavanca possa ser \r\naplicada.", 4, "Pé de cabra", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6917), 2.0, 2.5 },
                    { new Guid("0b5fa8dd-9bb5-490c-aec9-52682a26217c"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6918), 2, "", 4, "Pedra de amolar", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6918), 1.0, 0.0 },
                    { new Guid("0efa621f-38a4-4d17-9dc8-b0faa24ae1a8"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7173), 0, "Inclui um baú, 2 caixas para\r\nmapas ou pergaminhos, um conjunto de roupas finas, um vidro de\r\ntinta, uma caneta tinteiro, uma lâmpada, 2 frascos de óleo, 5\r\nfolhas de papel, um vidro de perfume, parafina e sabão.", 4, "Pacote de Diplomata", 5, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7173), 39.0, 0.0 },
                    { new Guid("1035c0f9-bb83-47fe-9fa6-a379f53dcea3"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6889), 1, "Uma lâmpada lança luz plena em um raio \r\nde 4,5 metros e penumbra por mais 9 metros. Uma vez \r\nacesa, a lâmpada queima por 6 horas usando um frasco de \r\nóleo (500 ml).", 4, "Lâmpada", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6889), 5.0, 0.5 },
                    { new Guid("10a8d746-a37e-4f75-901a-d2dfccaa6397"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7123), 0, "", 4, "Violino", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7123), 30.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("12de8c13-28fe-4d73-8628-089411876c9c"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6638), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Machadinha", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6638), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("140a7fc4-aa71-478a-8f33-117445eabdd5"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7128), 0, "Essa pequena caixa contém uma \r\nvariedade de papéis e pergaminhos, canetas e tintas, \r\nselos e lacres, folha de ouro e prata, e outros suprimentos \r\nnecessários para criar falsificações convincentes de \r\ndocumentos físicos. Proficiência com esse kit permite \r\nadicionar o bônus de proficiência para quaisquer testes de \r\nhabilidade que você fizer para criar uma falsificação de \r\num documento físico.", 4, "Kit de Falsificação", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7128), 15.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("1445a793-c9a8-44f4-a7a0-84071e841273"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6627), 0, 1, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Adaga", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6627), 2.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("1562fd78-710a-4088-9ac4-45211edf85e2"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7174), 0, "Inclui uma mochila, um livro de\r\nestudo, um vidro de tinta, uma caneta tinteiro, 10 folhas de\r\npergaminho, um saquinho de areia e uma pequena faca.", 4, "Pacote de Estudioso", 5, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7174), 40.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("16086556-3bdc-48a2-bb7a-c292e68fb614"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6634), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 8, 0, "Clava Grande", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6634), 2.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("19de1679-3454-40c7-95e8-6bc783b5e365"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7114), 0, "", 4, "Flauta", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7114), 2.0, 0.5 },
                    { new Guid("1b0973fa-485b-4d79-9e73-3c5384315e81"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7122), 0, "", 4, "Trombeta", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7122), 3.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("20436136-64da-475e-be07-e5e8be3f1518"), 0, 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6484), 0, "Feito de madeira ou metal e é usado com uma mão. Empunhar um escudo aumenta sua Classe de Armadura em 2. Você só pode se beneficiar de um escudo por vez.", 1, 2, 0, null, "Escudo", true, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6484), 10.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2303af49-9c36-4fe3-8fd0-1cd710c8e1ae"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6738), 0, 1, "Armas Marciais à Distância", 1, 6, 0, "Besta de Mão", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6738), 75.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("23311eef-86fd-4149-9eb7-b181c4125005"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6871), 0, "", 4, "Varinha", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6871), 10.0, 0.5 },
                    { new Guid("249bf2d6-11c4-4794-9775-20671816b7f5"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7093), 0, "", 4, "Ferramentas de Funileiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7093), 50.0, 5.0 },
                    { new Guid("24e3a9cd-3313-408b-a644-bdedf89cd43c"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7230), 1, "Preparada com ingredientes de boa qualidade, bem elaborada e saborosa. A refeição é servida em um ambiente confortável e bem cuidado, proporcionando uma experiência prazerosa e nutritiva. Inclui pratos variados e bem apresentados.", 4, "Confortável (refeição diária)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7230), 5.0, 0.0 },
                    { new Guid("2521682e-251e-429a-bb7d-13c029cc2d49"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6902), 0, "", 4, "Mochila", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6902), 2.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("25aa6ec4-ccc9-4419-a86f-8686829a8f77"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6706), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Espada Curta", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6706), 10.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("2601c8b5-f79d-4a5f-89a0-1d9afe92c425"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6818), 1, "", 4, "Cobertor de inverno", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6818), 5.0, 1.5 },
                    { new Guid("2b719b06-5b67-4b85-8a54-39c03ab9fe1b"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6872), 0, "", 4, "Cajado de madeira", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6872), 5.0, 2.0 },
                    { new Guid("2bcf7933-fe41-4b47-a3f9-c1088be95ed5"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6926), 0, "Esse estojo \r\ncilíndrico de couro pode armazenar até 10 folhas de papel \r\nenroladas ou 5 folhas de pergaminhos enroladas.", 4, "Porta mapas ou pergaminhos", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6926), 1.0, 0.5 },
                    { new Guid("2dbd97c4-f09b-4e9d-9c27-d7b292b46380"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7222), 2, "", 4, "Pão (pedaço)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7222), 2.0, 0.0 },
                    { new Guid("2eb94078-965b-4bce-a07b-5ff750c4bb96"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6870), 0, "", 4, "Orbe", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6870), 20.0, 1.5 },
                    { new Guid("3459ff52-89ff-4a7c-be1a-509f3aacf9e4"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7085), 0, "", 4, "Ferramentas de Cartógrafo", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7085), 15.0, 3.0 },
                    { new Guid("34996d8e-74d1-4de3-bfae-515d8f0c0875"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7086), 0, "", 4, "Ferramentas de Costureiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7086), 1.0, 2.5 },
                    { new Guid("35eecdf0-1d11-4a59-bbb1-a531704c0d3d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6943), 0, "", 4, "Saco de dormir", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6943), 1.0, 3.5 },
                    { new Guid("36710b83-e69b-4baf-b3d6-d9938b405de1"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7094), 0, "", 4, "Ferramentas de Joalheiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7094), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("369b3168-1156-46ce-b207-c4c79324a2f5"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6713), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Glaive", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6713), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3700c5e8-0535-4ed2-96eb-a7034bf3b39e"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7111), 0, "", 4, "Alaúde", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7111), 35.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3bc9e388-a9ac-43d6-8a24-3f138adabc96"), 16, 2, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6480), 0, "Feita de anéis de metal entrelaçados, a cota de malha inclui uma camada de tecido acolchoado usada por baixo da malha de metal para evitar atrito e amortecer o impacto dos golpes. O conjunto inclui manoplas.", 1, 0, 13, null, "Cota de malha", true, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6480), 75.0, 27.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3c13eab9-d392-4f31-ab5b-2f9220700cf2"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7092), 0, "", 4, "Ferramentas de Ferreiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7092), 20.0, 4.0 },
                    { new Guid("4128189a-f441-45c6-8512-6a5bb4dc4732"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6789), 0, "Usando uma ação, você pode espalhar o \r\nconteúdo desse frasco em uma criatura a até 1,5 metro de \r\nvocê ou arremessar a até 6 metros, quebrando o frasco \r\ncom o impacto. Em ambos os casos, você deve realizar um \r\nataque à distância contra uma criatura alvo, tratando a \r\nágua benta como uma arma improvisada. Se o alvo for um \r\ncorruptor ou morto-vivo, ele sofre 2d6 de dano radiante. ", 4, "Água benta (frasco)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6789), 25.0, 0.5 },
                    { new Guid("4140d8a0-3a11-437c-a486-999870998f9d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7225), 2, "Consiste em restos mal preparados, muitas vezes estragados ou contaminados. A comida pode causar doenças. Sem qualquer prazer ou nutrição adequada. Consumida em um ambiente sujo e insalubre, com a constante presença de insetos e roedores.", 4, "Esquálida (refeição diária)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7225), 3.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("41750b59-ed46-404a-9eb4-0334277af739"), 14, 2, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6478), 0, "Feita de couro com pesados anéis presos a ela. Os anéis ajudam a reforçar a armadura contra golpes de espadas e machados. A cota de anéis é inferior à cota de malha e geralmente é vestida apenas por aqueles que não podem pagar por uma armadura melhor.", 1, 0, 0, null, "Cota de anéis", true, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6478), 30.0, 20.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("425a2f1b-2e2a-4b26-a4ba-9747e09fa1f5"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7129), 0, "Esse kit contém uma variedade \r\nde instrumentos, como alicates, almofariz e pilão, e bolsas \r\ne frascos utilizados pelos herbalistas para criar remédios \r\ne poções. Proficiência com este kit permite adicionar o \r\nbônus de proficiência para quaisquer testes de habilidade \r\nque você fizer para identificar ou aplicar ervas. Além \r\ndisso, a proficiência com esse kit é necessária para criar \r\nantídotos e poções de cura.", 4, "Kit de Herbalismo", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7129), 5.0, 1.5 },
                    { new Guid("44ed5f78-2e9c-4300-8853-ba8425cce9d1"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6923), 0, "", 4, "Picareta de minerador", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6923), 2.0, 5.0 },
                    { new Guid("452266f7-e4c5-4905-90b4-afb1c08595d7"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7088), 0, "", 4, "Ferramentas de Coureiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7088), 5.0, 2.5 },
                    { new Guid("454c193e-ec96-4e25-a91d-00f28de5382c"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7133), 0, "", 4, "Jogo dos Três Dragões", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7133), 5.0, 0.0 },
                    { new Guid("45634ea4-b1ef-4467-a5fe-7dcc053bce32"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6913), 0, "", 4, "Panela de ferro", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6913), 2.0, 5.0 },
                    { new Guid("45efc1e3-1cd4-4abe-a371-25dc0b041dc7"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6793), 0, "Uma aljava pode guardar até 20 flechas.", 4, "Aljava", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6793), 1.0, 0.5 },
                    { new Guid("462ae913-ff34-4108-9b02-309e3dad44ac"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6905), 0, "", 4, "Flechas (20)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6905), 1.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4855b875-3e5a-4309-bcfa-28447791666f"), 12, 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6467), 0, "Feita de couro resistente, mas flexível, é reforçada com rebites ou cravos.", 1, 0, 0, 1, "Couro Batido", false, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6467), 45.0, 6.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("48de4a6c-67c2-498a-a36a-3531fce40e98"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6817), 1, "", 4, "Cesto", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6817), 4.0, 1.0 },
                    { new Guid("496bdecc-6f6b-4bca-b2f5-0a18e050f81d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6947), 0, "", 4, "Emblema", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6947), 5.0, 0.0 },
                    { new Guid("4a5973fa-a7c1-4a8a-89d4-2b6b3aac2f41"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6884), 2, "", 4, "Jarra", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6884), 4.0, 2.0 },
                    { new Guid("4aa16e06-37d9-4039-9bee-dd3f5ab84ab8"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7102), 0, "", 4, "Ferramentas de Vidreiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7102), 30.0, 2.5 },
                    { new Guid("4ab2dbd4-a7d8-4203-986c-1a86a2e50083"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6880), 0, "", 4, "Garrafa de vidro", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6880), 1.0, 1.0 },
                    { new Guid("4afcb9ea-5a26-474c-941d-72de31352bf3"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7169), 0, "Inclui uma mochila, um saco de\r\ndormir, duas fantasias, 5 velas, 5 dias de rações, um cantil e um kit\r\nde disfarce.", 4, "Pacote de Artista", 5, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7169), 40.0, 0.0 },
                    { new Guid("4bc07da8-ccc5-4d1d-b2cb-6452271ecc5d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7226), 2, "Composta por ingredientes básicos e de qualidade questionável. A refeição é simples, sem variedade, suficiente para manter alguém vivo, mas insatisfatória e possivelmente desagradável. Frequentemente rústica e pouco apetitosas.", 4, "Pobre (refeição diária)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7226), 6.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4e75783f-bf65-4865-9313-f0c8a6bde8bd"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6703), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Cimitarra", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6703), 25.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4ea554fa-6087-4d7a-8341-55f983862e23"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7118), 0, "", 4, "Lira", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7118), 30.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("51bd259c-b83d-42a7-83cd-574bda77676d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6631), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Bordão", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6631), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("51cf4936-0cd4-4aa3-90b6-0007adf69c30"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6794), 0, "", 4, "Ampulheta", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6794), 25.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("52d88c2f-8656-4e6a-b1aa-21748f42e96c"), 14, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6471), 0, "Consiste em um casaco e calças (e talvez uma saia separada) de couro coberto com peças sobrepostas de metal, assim como as escamas de peixe. O conjunto inclui manoplas.", 1, 2, 0, 1, "Brunea", true, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6471), 50.0, 22.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("546652fd-b2a7-44c6-9b5f-965890476051"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6897), 0, "", 4, "Manto", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6897), 1.0, 2.0 },
                    { new Guid("550b7efd-b8f3-43b4-83c3-00c0b8be5e51"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6896), 0, "Objetos vistos através de uma luneta são \r\nampliados até o dobro do seu tamanho.", 4, "Luneta", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6896), 1000.0, 0.5 },
                    { new Guid("56d32a83-2acb-4f4c-accd-a07260fe912f"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6826), 1, "", 4, "Escada (3 metros)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6826), 1.0, 12.5 },
                    { new Guid("56e5258b-9aad-4d46-8f05-0af506a90636"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6827), 0, "Usando uma ação, você pode \r\ndespejar essas minúsculas esferas de metal para cobrir a \r\nárea de um quadrado de 3 metros de lado. A criatura que \r\nse mover dentro da área deve ser bem sucedida em um \r\nteste de resistência de Destreza CD 10 para não cair no \r\nchão. Uma criatura que mover pela área usando metade \r\ndo seu deslocamento não precisa fazer o teste de \r\nresistência.", 4, "Esferas (sacola com 1.000)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6827), 1.0, 1.0 },
                    { new Guid("5750fca9-18f1-4622-b623-f2a7ec491394"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6949), 0, "", 4, "Sinete", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6949), 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("58cb68fc-aaf7-49dd-851f-9cb33e52f83b"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6697), 2, 1, "Armas Simples à Distância", 1, 4, 0, "Dardo", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6697), 5.0, 0.10000000000000001 },
                    { new Guid("59a756d6-4c9a-45e5-a0f5-dddf52a3255a"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6637), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Maça", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6637), 5.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("5a7ff249-01fb-4ea9-a859-edbf0bf5fefd"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7117), 0, "", 4, "Gaita de Foles", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7117), 30.0, 3.0 },
                    { new Guid("5b74e3af-dfb3-406a-b036-395fa79bea98"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7172), 0, "Inclui uma mochila, um pé de\r\ncabra, um martelo, 10 pítons, 10 tochas, uma caixa de fogo, 10\r\ndias de rações e um cantil. O kit também tem 15 metros de corda\r\nde cânhamo amarrada ao lado dele.", 4, "Pacote de Aventureiro", 5, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7172), 12.0, 0.0 },
                    { new Guid("5da0dae7-6b54-406d-a135-619b5a1cf6a1"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6879), 2, "", 4, "Frasco", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6879), 2.0, 1.0 },
                    { new Guid("6068dbcc-e2af-4dcb-b4eb-1b7584b5a572"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6927), 0, "Esse estojo de madeira pode \r\narmazenar até 20 virotes de besta.", 4, "Porta virotes", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6927), 1.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("617427cc-d7e0-4d37-98e2-aa3561e28785"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6709), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Espada Longa", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6709), 15.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("627d8214-0a63-4b10-9163-2bbda722d149"), 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7063), 0, "Você pode usar o veneno contido\r\nnesse vidro para cobrir a lâmina de uma arma cortante ou\r\nperfurante ou até três peças de munição. Aplicar o veneno\r\nleva uma ação. Uma criatura atingida pela arma ou\r\nmunição envenenada deve obter sucesso em um teste de\r\nresistência de Constituição CD 10 ou sofrerá 1d4 de dano\r\nde veneno. Uma vez aplicado, o veneno retém sua\r\npotência durante 1 minuto antes de secar.", 4, 1, 1, 2, "Veneno básico (frasco)", 2, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7063), 100.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("63c9741d-a63a-4392-ae73-deb0594ee9f1"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6731), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Picareta de Guerra", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6731), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("64e0d920-07ae-44cc-9226-b5531eeb0ba2"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6920), 1, "", 4, "Pergaminho (uma folha)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6920), 1.0, 0.0 },
                    { new Guid("658292e8-7fd9-425e-ac2b-dbfc12e8bc02"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6878), 0, "", 4, "Varinha de teixo", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6878), 10.0, 0.5 },
                    { new Guid("65bac53b-a1ac-4113-841a-7c592d50100e"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6787), 0, "Instrumento de cálculo, formado por uma moldura com bastões ou arames paralelos, dispostos no sentido vertical, correspondentes cada um a uma posição digital (unidades, dezenas, etc.) e nos quais estão os elementos de contagem (fichas, bolas ou contas) que podem fazer-se deslizar livremente.", 4, "Ábaco", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6787), 2.0, 1.0 },
                    { new Guid("66e35794-d1ee-4e51-8ecb-1df3e601b6bb"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7091), 0, "", 4, "Ferramentas de Entalhador", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7091), 1.0, 2.5 },
                    { new Guid("682598a5-4de3-46aa-89da-fa065d7d2a7e"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6893), 0, "Essa lente permite ver pequenos \r\nobjetos mais de perto. Ela também é útil como um \r\nsubstituto da pederneira e isqueiro para acender fogo. \r\nUsar uma lupa para acender fogo necessita de luz tão \r\nbrilhante como a luz do sol para focar, um pavio e cerca \r\nde 5 minutos. Uma lente de aumento concede vantagem \r\nem qualquer teste de habilidade feito para avaliar ou \r\ninspecionar um item que é pequeno ou muito detalhado.", 4, "Lente de aumento", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6893), 100.0, 0.0 },
                    { new Guid("6953debc-04d3-4533-8834-cb919560fa57"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7109), 0, "Esse conjunto de instrumentos é usado para navegação no mar. \r\nProficiência com as ferramentas de navegador permite \r\ntraçar um curso de navio e seguir cartas de navegação. \r\nAlém disso, essas ferramentas permitem que você \r\nadicione seu bônus de proficiência para qualquer teste de \r\nhabilidade que fizer para não se perder no mar. ", 4, "Ferramentas de navegação", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7109), 25.0, 1.0 },
                    { new Guid("6987d964-2a2e-42f0-b08e-6b0a601b9fa1"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7115), 0, "", 4, "Flauta de Pã", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7115), 12.0, 1.0 },
                    { new Guid("6a5b67e4-4fb7-44f2-93a7-318d135080bd"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6950), 0, "", 4, "Sino", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6950), 1.0, 0.0 },
                    { new Guid("6a7a608f-ab57-433c-b5b1-3b7191f3cbca"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6931), 0, "", 4, "Robes", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6931), 1.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6c3fdb12-7364-472a-bc14-f43fc756716b"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6736), 0, 1, "Armas Marciais à Distância", 1, 8, 0, "Arco Longo", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6736), 50.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("6fa02e05-1c07-4e03-a229-0876aa1df768"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7096), 0, "", 4, "Ferramentas de Oleiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7096), 10.0, 1.5 },
                    { new Guid("70e7f735-d6b1-428f-8246-39e283c65dcc"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6952), 0, "Um abrigo simples e portátil que acomoda \r\nduas pessoas.", 4, "Tenda para duas pessoas", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6952), 2.0, 10.0 },
                    { new Guid("7202ec46-ab40-4b7b-93be-565884eb87cf"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6883), 0, "Essencial para os magos, um grimório é \r\num volume encadernado em couro com 100 páginas de \r\npergaminhos em branco, adequado para armazenar \r\nmagias.", 4, "Grimório", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6883), 50.0, 1.5 },
                    { new Guid("7446e321-eabc-410e-aea2-9c0fbef6f086"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6867), 0, "", 4, "Cajado", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6867), 5.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("75d0c17d-088b-49b1-929b-418679488f40"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6725), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Mangual", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6725), 10.0, 2.0 },
                    { new Guid("75d13af3-7c6b-4587-b814-663350f0a7d1"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6635), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Foice Curta", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6635), 1.0, 1.0 },
                    { new Guid("7768fca7-c826-4872-bc7a-33d2cbfef16b"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6739), 0, 1, "Armas Marciais à Distância", 1, 10, 0, "Besta Pesada", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6739), 50.0, 4.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7778cbdc-baba-41d9-ad57-85bf4f0d4b99"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6904), 2, "", 4, "Balas de Funda (20)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6904), 4.0, 0.75 },
                    { new Guid("7872404a-e13c-4ee0-906c-1a82c17cac10"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6803), 0, "", 4, "Arpéu", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6803), 2.0, 2.0 },
                    { new Guid("7904cd18-0190-4061-9dc3-eb74436217a0"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6958), 2, "Por uma hora, a vela emana luz plena em um \r\nraio de 1,5 metro e penumbra por mais 1,5 metro.", 4, "Vela", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6958), 1.0, 0.0 },
                    { new Guid("7923ac36-3b4c-47aa-bf41-2d4894c790a4"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6811), 0, "Trata-se de uma pequena \r\nbolsa de couro à prova d'água que pode ser fixada em um \r\ncinto. Ela possui compartimentos para armazenar todos \r\nos componentes materiais e outros itens especiais que \r\nvocê precisa para lançar suas magias, exceto os \r\ncomponentes que possuem um custo específico (conforme \r\nindicado na descrição da magia).", 4, "Bolsa de componentes", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6811), 25.0, 1.5 },
                    { new Guid("7992ec96-d1f8-4b59-abf1-048cbd6f2a3d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7104), 0, "", 4, "Suprimentos de Alquimista", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7104), 50.0, 4.0 },
                    { new Guid("7a0f8513-3dc6-4cff-aecf-2da68d6f0042"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7134), 0, "", 4, "Xadrez do Dragão", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7134), 1.0, 0.25 },
                    { new Guid("7c38b899-54e7-4e71-8498-822b7e49ea7a"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6914), 1, "", 4, "Papel (uma folha)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6914), 2.0, 0.0 },
                    { new Guid("7e744f89-c0b8-431a-90e4-411cb7fd0177"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6953), 2, "A tocha queima por 1 hora, fornecendo luz \r\nplena em um raio de 6 metros e penumbra por mais 6 \r\nmetros. Se você realizar um ataque corpo-a-corpo com \r\numa tocha acesa e acertar, causa 1 de dano flamejante.", 4, "Tocha", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6953), 1.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7eeedcc6-9a15-460c-963b-c25e398e26a6"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6729), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Martelo de Guerra", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6729), 15.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("808a9d37-5657-4d99-bf24-bdaefad81b83"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6932), 0, "Um conjunto de roldanas com um \r\ncabo entre elas e um gancho para fixar aos objetos, a \r\nroldana e polia permitem içar até quatro vezes o peso que \r\nvocê ergueria normalmente.", 4, "Roldana e polia", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6932), 1.0, 2.5 },
                    { new Guid("80a04ce8-3904-4c26-a38a-b4c777938bd4"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7131), 1, "", 4, "Baralho de Cartas", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7131), 5.0, 0.0 },
                    { new Guid("8169077b-5fb2-431d-ac22-01de7d5f2812"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6941), 2, "", 4, "Saco", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6941), 1.0, 0.25 },
                    { new Guid("82c0a469-6e8a-416c-b740-04871f6661a3"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7110), 0, "Esse conjunto de ferramentas inclui uma pequena pasta, um conjunto de \r\nchaves mestras, um pequeno espelho montado em uma \r\nalça de metal, um conjunto de tesouras de lâminas \r\nestreitas e um par de alicates. Proficiência com essas \r\nferramentas permite adicionar o bônus de proficiência \r\npara quaisquer testes de habilidade que você fizer para \r\ndesarmar armadilhas ou abrir fechaduras.", 4, "Ferramentas de ladrão", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7110), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("82cbbd0d-dc31-40fe-9aa5-7f1de352f5a2"), 11, 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6452), 0, "Consiste em camadas de panos acolchoados e batidos.", 1, 0, 0, 1, "Acolchoada", true, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6452), 5.0, 4.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("86921ba5-78ef-4cd4-858e-a1019f929d91"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6876), 0, "", 4, "Totem", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6876), 1.0, 0.0 },
                    { new Guid("89155660-746e-4c0b-aa94-ce8fa142dedf"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6868), 0, "", 4, "Cristal", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6868), 10.0, 0.5 },
                    { new Guid("89d098d3-9fba-4216-8c0e-2a12841c6dbd"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6799), 0, "", 4, "Apito de advertência", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6799), 25.0, 0.5 },
                    { new Guid("8aaf7525-b91b-454d-a237-e3d3486a3dd2"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6955), 2, "", 4, "Vara (3 metros)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6955), 5.0, 3.5 },
                    { new Guid("8aecb552-f251-40cb-aa8f-c7da2c8a2dca"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7234), 1, "", 4, "Vinho Comum (jarra)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7234), 2.0, 0.0 },
                    { new Guid("8c93e1d8-522c-4955-a86b-c850e3eefaca"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6791), 0, " Essas algemas de metal podem prender \r\numa criatura Pequena ou Média. Escapar das algemas \r\nexige sucesso em um teste de Destreza CD 20. Quebrá-las \r\nexige um teste de Força CD 20 bem sucedido. Cada \r\nconjunto de algemas vem com uma chave. Sem a chave, \r\numa criatura proficiente com ferramentas de ladrão pode \r\nabrir a fechadura das algemas com um sucesso em um \r\nteste de Destreza CD 15. As algemas têm 15 pontos de \r\nvida. ", 4, "Algemas", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6791), 2.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("8ee16d25-a98f-40de-be1f-969708bb89c1"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6732), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Rapieira", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6732), 25.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8f5f389e-a26c-4752-9185-276ff59084bf"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7106), 0, "", 4, "Suprimentos de Caligrafia", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7106), 10.0, 2.5 },
                    { new Guid("90060195-4a81-416d-a0e4-1af7a093d156"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6873), 0, "", 4, "Ramo de visco", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6873), 1.0, 0.0 },
                    { new Guid("90becb39-90a9-4870-8ad8-c58bcbee808d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6892), 0, "Uma lanterna furta-fogo \r\nlança luz plena em um cone de 18 metros e penumbra por \r\nmais 18 metros. Uma vez acesa, ela queima por 6 horas \r\nusando um frasco de óleo (500 ml).", 4, "Lanterna furta-fogo", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6892), 10.0, 1.0 },
                    { new Guid("92cb4d9c-16f3-4532-a266-53518610a9e7"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7224), 1, "", 4, "Queijo (pedaço)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7224), 2.0, 0.0 },
                    { new Guid("9382ad48-3fd2-470d-8d03-d33351baa892"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6815), 2, "", 4, "Caneta tinteiro", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6815), 2.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("93b4d06b-aebb-41fc-abe6-e748deee8029"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6734), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Tridente", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6734), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("96486362-26b0-45e1-9657-4459d186e4c2"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6901), 0, "", 4, "Martelo", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6901), 1.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("96585393-81d7-4756-90b1-2e45788def36"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6693), 0, 1, "Armas Simples à Distância", 1, 8, 0, "Besta Leve", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6693), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("96ab6da1-a4c9-4055-8729-c515abcf5067"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7119), 0, "", 4, "Oboé", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7119), 2.0, 0.5 },
                    { new Guid("96ecea03-599a-4167-b425-7efdc086fde7"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6809), 0, "", 4, "Baú", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6809), 5.0, 12.5 },
                    { new Guid("97310a4d-5ef5-4194-a193-9841e4c66801"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6915), 1, "", 4, "Parafina", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6915), 5.0, 0.0 },
                    { new Guid("973a6728-a61d-48fe-992d-9397ef2639b1"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6909), 1, "Geralmente vem em um frasco de argila que \r\ncontém 500 ml. Usando uma ação, você pode espirrar o \r\nóleo desse frasco em uma criatura a até 1,5 metro de você\r\nou arremessar a até 6 metros, quebrando-o com o \r\nimpacto. Você deve realizar um ataque à distância contra \r\numa criatura ou objeto, tratando o óleo como uma arma \r\nimprovisada. Com um sucesso, o alvo é coberto de óleo. Se \r\no alvo sofrer qualquer dano flamejante antes do óleo secar\r\n (depois de 1 minuto), a criatura sofre 5 de dano \r\nflamejante adicional pela queima do óleo. Você também \r\npode derramar um frasco de óleo no chão para cobrir uma \r\nárea de um quadrado de 1,5 metro de lado, desde que a \r\nsuperfície esteja nivelada. Se aceso, o óleo queima por 2 \r\nrodadas e causa 5 de dano flamejante a qualquer criatura \r\nque entrar na área ou terminar seu turno dentro da área. \r\nUma criatura pode sofrer esse dano apenas uma vez por \r\nturno.", 4, "Óleo (frasco)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6909), 1.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9a366125-3ce5-4c5c-9015-36c6bcff512e"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6699), 1, 2, "Armas Simples à Distância", 1, 4, 0, "Funda", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6699), 1.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9a8b59ea-a551-480e-90b2-052f9fdf13d8"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6894), 0, "Um livro pode conter poesia, relatos históricos, \r\ninformações relativas a um campo particular de \r\nsabedoria, diagramas e notas sobre engenhocas gnômicas, \r\nou qualquer outra coisa que possa ser representada \r\nusando texto ou imagens.", 4, "Livro", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6894), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9b20b970-e3c9-4626-9494-067479647d80"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6704), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 4, 0, "Chicote", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6704), 2.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9b22c8eb-9d90-43b5-910e-49240762c0ad"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6940), 2, "", 4, "Sabão", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6940), 2.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9c382141-fc3b-4b3a-aeef-223aec7fdf44"), 2, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7064), 0, "Esse líquido pegajoso e adesivo\r\ninflama em contado com o ar. Usando uma ação, você\r\npode arremessar esse frasco a até 6 metros de distância,\r\nquebrando-o com o impacto. Você deve realizar um ataque\r\nà distância contra uma criatura ou objeto, tratando o fogo\r\nalquímico como uma arma improvisada. Em um sucesso,\r\no alvo sofre 1d4 de dano de fogo no início de cada um de\r\nseus turnos. Uma criatura pode terminar esse dano\r\nusando sua ação e fazendo um teste de Destreza CD 10\r\npara apagar as chamas.", 4, 2, 0, 2, "Fogo alquímico (frasco)", 2, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7064), 50.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9c835ca8-c05b-4998-b02e-1df9bb59dcc5"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7233), 0, "Caracterizada por uma experiência gastronômica de excelência, com pratos gourmet elaborados por chefs renomados. Os ingredientes são os melhores disponíveis, muitas vezes raros e caros. Servida em um ambiente opulento e sofisticado, com um serviço impecável. A refeição é uma celebração de sabor e luxo, frequentemente acompanhada de bebidas finas e uma apresentação artística.", 4, "Aristocrática (refeição diária)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7233), 2.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9d376923-f777-4b6a-83aa-fa747dfcec37"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6640), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Martelo Leve", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6640), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("9dade301-8693-4e61-9cd6-3f3f690dc279"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6891), 0, "Uma lanterna coberta lança luz \r\nplena em um raio de 9 metros e penumbra por mais 9 \r\nmetros. Uma vez acesa, ela queima por 6 horas usando \r\num frasco de óleo (500 ml). Usando uma ação, você pode \r\nabaixar a cobertura, reduzindo a claridade para \r\npenumbra em um raio de 1,5 metro.", 4, "Lanterna coberta", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6891), 5.0, 1.0 },
                    { new Guid("a25f3d88-e569-431f-a48e-9ec1bdf4bd23"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6939), 0, "", 4, "Roupas finas", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6939), 15.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a4b83e6f-4dae-4c0d-b1b3-c0b80ba79039"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6701), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Alabarda", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6701), 20.0, 3.0 },
                    { new Guid("a569c13e-9a74-4e6a-a541-6406ea4646b8"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6724), 0, 2, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Malho", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6724), 10.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a7962b61-829b-4343-8eea-09e049727fed"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7229), 1, "Inclui pratos simples e caseiros, preparados com ingredientes frescos, mas comuns. A refeição é nutritiva e satisfatória, servida em um ambiente limpo e acolhedor. Não há luxo, mas proporciona uma experiência agradável.", 4, "Modesta (refeição diária)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7229), 3.0, 0.0 },
                    { new Guid("a7d6229f-02a7-408d-bd92-c5ed237ad32e"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6948), 0, "", 4, "Relicário", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6948), 5.0, 1.0 },
                    { new Guid("a810f7ef-f015-4634-93c3-1d7ccc203bdb"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6788), 0, "Usando uma ação, você pode despejar o \r\nconteúdo desse vidro em uma criatura a até 1,5 metro de \r\nvocê, ou arremessar o vidro a até 6 metros de distância, \r\nquebrando-o no impacto. Em ambos os casos, você deve \r\nrealizar um ataque à distância contra uma criatura ou \r\nobjeto, tratando o ácido como uma arma improvisada. Se \r\nacertar, o alvo sofre 2d6 de dano ácido.", 4, "Ácido (vidro)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6788), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a8bf56fe-fdaa-49ad-9282-10471bd88af7"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6629), 1, 1, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Azagaia", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6629), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("aab500d1-ceb7-4cfd-9e7e-b860183c477d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6804), 0, "Trata-se de uma pequena \r\nbalança, pratos e um sortimento adequado de pesos de até \r\n1 kg. Com ela, você pode medir o peso exato de pequenos \r\nobjetos, como metais preciosos brutos ou bens comerciais, \r\npara ajudar a determinar seu valor.", 4, "Balança de mercador", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6804), 5.0, 1.5 },
                    { new Guid("aaf40360-8f5d-4658-8b6c-7b82159053c0"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6833), 0, "A fechadura vem com chave. Sem a \r\nchave, uma criatura proficiente com ferramentas de \r\nladrão pode abrir a fechadura com um sucesso em um \r\nteste de Destreza CD 15. O Mestre pode decidir que \r\nfechaduras melhores estão disponíveis por preços mais \r\nelevados.", 4, "Fechadura", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6833), 10.0, 0.5 },
                    { new Guid("ac2bf60c-b501-4616-9396-2c224f7245a7"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6930), 1, "Consistem em alimentos desidratados adequados para viagens longas, \r\nincluindo carne seca, frutas secas, bolachas e nozes. ", 4, "Rações de viagem (1 dia)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6930), 5.0, 1.0 },
                    { new Guid("ac7c5df7-0bdc-4252-88dc-c4ad6fe67dae"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7084), 0, "", 4, "Ferramentas de Carpinteiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7084), 8.0, 3.0 },
                    { new Guid("ad69486f-2a9c-410a-a944-c5411b64eb74"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6829), 0, "", 4, "Espelho de aço", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6829), 5.0, 0.25 },
                    { new Guid("adddc5e9-8482-4470-8bb2-8c206c6e4054"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6825), 0, "Este kit inclui uma vara \r\nde pesca de madeira, linha de seda, boias de cortiça, \r\nanzóis de aço, chumbadas, iscas e redes de pesca.", 4, "Equipamento de pescaria", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6825), 1.0, 2.0 },
                    { new Guid("ae1eee60-45a5-4eab-8d97-853c8916a3c9"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7126), 0, "", 4, "Xilofone", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7126), 25.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("aec2aad7-2feb-4f5b-a249-5ccbc0846faf"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6715), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 12, 0, "Lança de Montaria", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6715), 10.0, 3.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("af0e8073-877e-4f50-981b-c9d93fad9737"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7127), 0, "Essa bolsa de cosméticos, tintura de \r\ncabelo e pequenos adereços permite criar disfarces que \r\nmudam sua aparência física. Proficiência com este kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar um disfarce \r\nvisual.", 4, "Kit de Disfarce", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7127), 25.0, 1.5 },
                    { new Guid("af821ca8-9e69-49e8-a870-d648f5cbfb77"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6936), 0, "", 4, "Roupas de viajante", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6936), 2.0, 2.0 },
                    { new Guid("b09c8ff6-e6a4-42a0-9f7e-2b621b50b3e2"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6907), 0, "", 4, "Zarabatana (50)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6907), 1.0, 0.5 },
                    { new Guid("b66a7b55-fe2c-44a3-97fc-53d48a2a6dd3"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7177), 0, "Inclui uma mochila, um\r\ncobertor, 10 velas, uma caixa de fogo, uma caixa de esmolas, 2\r\nblocos de incenso, um incensário, vestes, 2 dias de rações e um\r\ncantil.", 4, "Pacote de Sacerdote", 5, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7177), 19.0, 0.0 },
                    { new Guid("b6791840-98f3-49d1-8f72-6ccadfb36ff5"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6888), 0, "Esse kit é uma bolsa de \r\ncouro contendo ataduras, pomadas e talas. O kit possui \r\nmaterial suficiente para dez usos. Usando uma ação, você \r\npode gastar um uso do kit para estabilizar uma criatura \r\nque tenha 0 pontos de vida, sem a necessidade de realizar \r\num teste de Sabedoria (Medicina).", 4, "Kit de primeiros-socorros", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6888), 5.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ba342e08-01b1-48e2-b20e-a2f2aead91b7"), 12, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6468), 0, "Armadura bruta consistindo de peles grossas. É comumente usada por tribos bárbaras, humanoides malignos e outros povos que não têm acesso às ferramentas e materiais necessários para criar uma armadura melhor.", 1, 2, 0, 1, "Gibão de Peles", false, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6468), 10.0, 6.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("bc3d3358-ed2b-442d-8aad-1862e3b21921"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7232), 1, "Composta por pratos sofisticados e requintados, preparados com ingredientes de alta qualidade e muitas vezes exóticos. A refeição é servida em um ambiente elegante e refinado, acompanhada por um excelente serviço. Proporciona uma experiência culinária luxuosa e memorável.", 4, "Rica (refeição diária)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7232), 8.0, 0.0 },
                    { new Guid("bc4c6664-e75c-4ce1-be35-f576567d72af"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6824), 0, "Uma corrente possui 10 pontos de vida e \r\npode ser arrebentada com um teste de Força CD 20 bem \r\nsucedido.", 4, "Corrente (3 metros)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6824), 5.0, 5.0 },
                    { new Guid("be135d5e-ff1d-41c6-bfdc-fb212ed8f67d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6866), 0, "", 4, "Bastão", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6866), 10.0, 1.0 },
                    { new Guid("bf9bd676-319f-4981-a535-ef05d08cb547"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7098), 0, "", 4, "Ferramentas de Pintor", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7098), 10.0, 2.5 },
                    { new Guid("c078b470-1b03-4878-8170-d1bb3e51b3df"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7220), 1, "", 4, "Cerveja (galão)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7220), 2.0, 0.0 },
                    { new Guid("c13a548f-cd37-4255-bd1e-0720b1e20ff5"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6805), 2, "", 4, "Balde", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6805), 5.0, 1.0 },
                    { new Guid("c383bd80-7f4b-4ecd-baee-ed44167579c3"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6813), 2, "", 4, "Caneca", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6813), 2.0, 0.5 },
                    { new Guid("c494bb75-4d22-425e-9ae5-54b13b1b760b"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7120), 0, "", 4, "Tambor", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7120), 6.0, 1.5 },
                    { new Guid("c7724de3-96d4-4f66-97f0-27049f5a7339"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6800), 0, " Você pode usar um aríete portátil \r\npara quebrar portas. Ao fazer isso, você ganha um bônus \r\nde +4 no teste de Força. Outra criatura pode ajudá-lo a \r\nusar o aríete, o que concede vantagem no teste.", 4, "Ariete portátil", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6800), 4.0, 17.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c7856b49-3f80-414c-8989-d943a2522efc"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6722), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Machado de Batalha", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6722), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c790c1fb-a9ff-41f7-89bd-11ae1dc7c8ea"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6792), 0, "Uma bolsa de pano ou couro que pode \r\narmazenar até 20 munições de funda ou 50 munições de \r\nzarabatana, entre outras coisas. Para armazenar \r\ncomponentes de magia, veja bolsa de componentes, \r\ntambém descrita nessa seção.", 4, "Algibeira", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6792), 5.0, 0.5 },
                    { new Guid("c870f1de-df88-45ec-920d-90f8b96d790d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7097), 0, "", 4, "Ferramentas de Pedreiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7097), 10.0, 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c9453e46-d630-4935-9748-920d78022f56"), 2, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7061), 0, "Um personagem que beber o líquido\r\nvermelho mágico deste frasco recupera 2d4+2 pontos de\r\nvida. Beber ou administrar uma poção exige uma ação.", 4, 2, 0, 2, "Poção de Cura", 2, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7061), 50.0, 0.25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("cb061eb1-fbb6-4055-98cb-35ff349a5cde"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6798), 0, "Uma criatura que beber o líquido desse \r\nvidro tem vantagem em testes de resistência contra \r\nvenenos por 1 hora. O antídoto não confere nenhum \r\nbenefício para mortos-vivos ou constructos. ", 4, "Antídoto (vidro)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6798), 50.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("cd1f1d9e-0d61-47d8-826b-98a382c64f42"), 14, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6473), 0, "Constituída por um peitoral de metal usado com couro flexível em seu interior. Embora ele deixe as pernas e braços do usuário relativamente desprotegidos, essa armadura fornece boa proteção para seus órgãos vitais, deixando quem a usa relativamente sem restrições.", 1, 2, 0, 1, "Peitoral", false, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6473), 400.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("cf6bf851-00da-4d1a-9d5a-415a73bc84de"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6801), 0, "Quando você usa sua ação para \r\narmá-la, essa armadilha forma um anel de aço com \r\ndentes serrilhados. Eles se fecham quando uma criatura \r\npisa sobre uma placa de pressão no seu centro. A \r\narmadilha é fixada por uma pesada corrente em um \r\nobjeto fixo e imóvel, como uma árvore ou um cravo \r\nenterrado no chão. Uma criatura que pisar na placa de \r\npressão deve ser bem sucedida em um teste de resistência \r\nde Destreza CD 13 ou sofrerá 1d4 de dano perfurante e \r\npara de se mover. Daí em diante, até que a criatura se \r\nliberte da armadilha, seu movimento é limitado ao \r\ncomprimento da corrente (tipicamente 1 metro de \r\ncomprimento). A criatura presa pode usar sua ação para \r\nfazer um teste de Força CD 13 e se libertar, ou outra \r\ncriatura no alcance pode fazer o teste para libertá-la. \r\nCada fracasso no teste causa 1 de dano perfurante à \r\ncriatura presa.", 4, "Armadilha de caça", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6801), 5.0, 12.5 },
                    { new Guid("d1b2c72e-108e-4711-96fc-3e7058149752"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6823), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de seda (15 metros)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6823), 10.0, 2.5 },
                    { new Guid("d2651cb9-366a-47f3-a5b2-d847c43ea566"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6912), 0, "", 4, "Pá", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6912), 2.0, 2.5 },
                    { new Guid("d29a3ead-1dab-42dd-9b19-327f5c2275c3"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6821), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de cânhamo (15 metros)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6821), 1.0, 5.0 },
                    { new Guid("d584521f-ad5c-4e65-8dcb-ea81a3320c40"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6830), 0, "Usando uma ação, você pode espalhar um \r\núnico saco de estrepes para cobrir a área de um quadrado \r\nde 1,5 metro de lado. Qualquer criatura que entrar na \r\nárea deve ser bem sucedida em um teste de resistência de \r\nDestreza CD 15. Se falhar, para de se mover e sofre 1 de \r\ndano perfurante. Até que a criatura recupere pelo menos \r\n1 ponto de vida, seu deslocamento de caminhada é \r\nreduzido em 3 metros. Uma criatura que se mover pela \r\nárea usando metade do seu deslocamento não precisa \r\nfazer o teste de resistência.", 4, "Estrepes (bolsa com 20)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6830), 1.0, 1.0 },
                    { new Guid("d70a9a2b-34c0-40c7-a1cf-12761aeb0ee3"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7170), 0, "Inclui uma mochila, um saco\r\ncom 1.000 esferas de metal, 3 metros de linha, um sino, 5 velas,\r\num pé de cabra, um martelo, 10 pítons, uma lanterna coberta, 2\r\nfrascos de óleo, 5 dias de rações, uma caixa de fogo e um cantil. O\r\nkit também possui 15 metros de corda de cânhamo amarrada ao\r\nlado dele.", 4, "Pacote de Assaltante", 5, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7170), 16.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d7adb39e-a297-46a6-ae7a-8ea691c3babc"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6719), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Maça Estrela", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6719), 15.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d91d4ece-caf9-4cec-9690-73bfb59321e0"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7217), 0, "", 4, "Banquete (por pessoa)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7217), 10.0, 0.0 },
                    { new Guid("d9c45c5a-2270-4371-a19a-441b1585144c"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6935), 1, "", 4, "Roupas comuns", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6935), 5.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d9cfc648-e722-47b3-8ecc-6910b246d9d6"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6717), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Lança Longa", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6717), 5.0, 4.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("da222b49-88d8-484f-b7ce-9ec13a0f05e5"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6954), 0, "", 4, "Tinta (frasco de 30ml)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6954), 10.0, 0.0 },
                    { new Guid("db2db549-45a9-4d12-ba46-a87d1ba9a01d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7137), 0, "O kit de venenos inclui os frascos, \r\nprodutos químicos e outros equipamentos necessários \r\npara a criação de venenos. Proficiência com esse kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar ou utilizar \r\nvenenos.", 4, "Kit de Venenos", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7137), 50.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("dc1712fe-f17d-4227-b782-0115dc3e6dda"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6641), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Porrete", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6641), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("dc4b6ee5-ff38-45d8-8ab0-df1e6e336d28"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7219), 1, "", 4, "Carne (pedaço)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7219), 3.0, 0.0 },
                    { new Guid("dd2f86bb-ee3b-4b64-8c69-862de08a355d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7235), 0, "", 4, "Vinho Fino (garrafa)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7235), 10.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("dfdb5ae1-984c-448d-9704-a428050c79c5"), 18, 2, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6483), 0, "Consiste em placas de metal moldadas para cobrir todo o corpo. Inclui luvas, botas de couro pesadas, um capacete com viseira e espessas camadas de enchimento por baixo da armadura. Fivelas e tiras de couro distribuem o peso ao longo do corpo.", 1, 0, 15, null, "Placas", true, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6483), 1500.0, 32.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e00c6a4e-d991-4e27-904c-3fd74eb15d3c"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6812), 1, "Esse pequeno recipiente detém uma \r\npederneira, isqueiro e um pavio (um pano geralmente \r\nseco embebido em óleo) usado para acender uma fogueira. \r\nUsá-lo para acender uma tocha – ou qualquer outra coisa \r\nexposta a um combustível abundante – leva uma ação. \r\nAcender qualquer outro fogo leva 1 minuto.", 4, "Caixa de Fogo", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6812), 5.0, 0.5 },
                    { new Guid("e033778f-efc3-4cb5-8a72-41cc8b3a888b"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6937), 0, "", 4, "Roupas de entretenimento", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6937), 5.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e1f98bda-1bc2-4c9e-8227-e6042a7e677b"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6708), 0, 0, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Espada Grande", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6708), 50.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e2b034e6-fbf4-40fc-8bd9-e6799a84e59e"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6816), 1, "", 4, "Cantil", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6816), 2.0, 2.5 },
                    { new Guid("e2bc81c0-a3f3-4237-bd9a-20067ef710c6"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6928), 0, "", 4, "Pregos de ferro (10)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6928), 1.0, 2.5 },
                    { new Guid("e687f606-e3e6-45db-a198-b91ff817de85"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7221), 2, "", 4, "Cerveja (caneca)", 6, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7221), 4.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ea257013-3865-4b5d-a642-b0129f17b55c"), 17, 2, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6481), 0, "Feita de tiras verticais de metal, rebitadas a um suporte de couro, usadas sobre um preenchimento de pano. Cotas de malha flexíveis protegem as articulações.", 1, 0, 15, null, "Cota de malha", true, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6481), 200.0, 30.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ec4cded7-cd95-4414-b75e-c48d9d53fedf"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7175), 0, "Inclui uma mochila, um saco de\r\ndormir, um kit de refeição, uma caixa de fogo, 10 tochas, 10 dias\r\nde rações e um cantil. O kit também tem 15 metros de corda de\r\ncânhamo amarrada ao lado dele.", 4, "Pacote de Explorador", 5, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7175), 10.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ed208a50-b2dd-48cc-b692-ad62b7ca0a8b"), 15, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6474), 0, "Composta de placas de metal moldadas que cobrem a maior parte do corpo. Ela não inclui proteção para as pernas além de caneleiras fixadas com tiras de couro.", 1, 2, 0, 1, "Meia-Armadura", true, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6474), 750.0, 20.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ed52d0d9-e32f-476f-9b28-019b24c61762"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6745), 0, 1, "Armas Marciais à Distância", 1, 1, 0, "Zarabatana", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6745), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ed909774-9b00-44ae-98ad-a8fc70a4f155"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6944), 0, "", 4, "Amuleto", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6944), 5.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("ee7eb6dd-b116-45fb-abb0-79fecda8abe7"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6720), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Machado Grande", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6720), 30.0, 3.5 },
                    { new Guid("eeab0529-4e9c-427a-a0a5-e2179af70dda"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6691), 0, 1, "Armas Simples à Distância", 1, 6, 0, "Arco Curto", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6691), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("eeaf03e0-7203-4ef5-a61f-0c3ac0fea5a9"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6906), 0, "", 4, "Virotes (20)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6906), 1.0, 0.75 },
                    { new Guid("eff3b102-3bc0-438f-9300-4110c38fbb03"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6900), 0, "", 4, "Marreta", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6900), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f0f4cd50-3ebb-4e04-84c6-c1f40718ec2a"), 11, 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6465), 0, "São feitos de couro que foi endurecido após ser fervido em óleo. O resto da armadura é feita de materiais mais macios e mais flexíveis.", 1, 0, 0, 1, "Couro", false, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6465), 10.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("f1751a1c-184a-474e-ad71-aed9de0c599d"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6807), 0, "", 4, "Barril", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6807), 2.0, 35.0 },
                    { new Guid("f42cfa45-ede6-45cb-a90d-436b5bb474e6"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6885), 0, "Um kit de escalada inclui pítons \r\nespeciais, botas com solas pontiagudas, luvas e um cinto. \r\nVocê pode usar o kit de escalada como uma ação para \r\n\"ancorar-se\". Quando faz isso, você não pode cair mais de \r\n7,5 metros a partir do ponto onde se ancorou, e não pode \r\nsubir mais de 7,5 metros de distância desse ponto, sem \r\ndesfazer a âncora.", 4, "Kit de escalada", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6885), 25.0, 6.0 },
                    { new Guid("f4ac6190-b32a-4383-b4ec-687b66fd9a4c"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6881), 2, "", 4, "Giz (1 peça)", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6881), 1.0, 0.0 },
                    { new Guid("f4d9b99f-ed9c-4e65-bf12-15db7e776f3f"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7105), 0, "", 4, "Suprimentos de Cervejeiro", 3, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7105), 20.0, 4.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f784bd8d-1e00-49ef-b6c8-a0e75349432a"), 13, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6470), 0, "Feito de anéis de metal intercalados, um camisão de cota de malha é usado entre as camadas de roupa. Essa armadura oferece proteção modesta para a parte superior do corpo de quem a usa e permite que o som dos anéis de metal, friccionados uns contra os outros, sejam amortecidos pelas camadas exteriores.", 1, 2, 0, 1, "Camisão de Malha", false, 1, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6470), 30.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f81998d5-6e73-41bd-a32c-9d70c4e2d8f8"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6741), 0, 1, "Armas Marciais à Distância", 0, 1, 0, "Rede", 0, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(6741), 1.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("fc931746-d48b-4b58-9c8e-8e24f1ab6110"), new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7132), 1, "", 4, "Conjunto de Dados", 4, new DateTime(2024, 6, 5, 18, 54, 53, 484, DateTimeKind.Local).AddTicks(7132), 1.0, 0.0 });

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundDataModelItemDataModel_ItemsId",
                table: "BackgroundDataModelItemDataModel",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbilityScoreDataModel_AbilityScoreId",
                table: "CharacterAbilityScoreDataModel",
                column: "AbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbilityScoreDataModel_CharacterId",
                table: "CharacterAbilityScoreDataModel",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BackgroundId",
                table: "Characters",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BackpackId",
                table: "Characters",
                column: "BackpackId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CoinPurseId",
                table: "Characters",
                column: "CoinPurseId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_LevelId",
                table: "Characters",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureDataModelRaceDataModel_RacesId",
                table: "FeatureDataModelRaceDataModel",
                column: "RacesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItemDataModel_BackpackDataModelId",
                table: "PlayerItemDataModel",
                column: "BackpackDataModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItemDataModel_CharacterId",
                table: "PlayerItemDataModel",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItemDataModel_ItemId",
                table: "PlayerItemDataModel",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceAbilityScoreDataModel_AbilityScoreId",
                table: "RaceAbilityScoreDataModel",
                column: "AbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceAbilityScoreDataModel_RaceId",
                table: "RaceAbilityScoreDataModel",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_BackgroundId",
                table: "Traits",
                column: "BackgroundId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackgroundDataModelItemDataModel");

            migrationBuilder.DropTable(
                name: "CharacterAbilityScoreDataModel");

            migrationBuilder.DropTable(
                name: "FeatureDataModelRaceDataModel");

            migrationBuilder.DropTable(
                name: "PlayerItemDataModel");

            migrationBuilder.DropTable(
                name: "RaceAbilityScoreDataModel");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "AbilityScoreValueObject");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "Backpacks");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "CoinPurses");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
