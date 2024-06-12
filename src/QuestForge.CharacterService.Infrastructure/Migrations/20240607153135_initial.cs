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
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HitDie = table.Column<int>(type: "int", nullable: false),
                    CoinDice = table.Column<int>(type: "int", nullable: false),
                    CoinDiceAmount = table.Column<int>(type: "int", nullable: false),
                    CoinDiceMultiplier = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Backpacks_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
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
                name: "CharacterItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BackPackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterItems_Backpacks_BackPackId",
                        column: x => x.BackPackId,
                        principalTable: "Backpacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterItems_Items_ItemId",
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
                    { new Guid("07f528a4-47e6-42d4-abf9-902b11fe1518"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1993), "Você pode usar uma ação para \r\nexalar energia destrutiva. Seu ancestral dracônico \r\ndetermina o tamanho, formado e tipo de dano que você \r\nexpele. \r\nQuando você usa sua arma de sopro, cada criatura na \r\nárea exalada deve realizar um teste de resistência, o tipo \r\ndo teste é determinado pelo seu ancestral dracônico. A CD \r\ndo teste de resistência é 8 + seu modificador de \r\nConstituição + seu bônus de proficiência. Uma criatura \r\nsofre 2d6 de dano num fracasso e metade desse dano num \r\nsucesso. O dano aumenta para 3d6 no 6° nível, 4d6 no 11° \r\nnível e 5d6 no 16° nível. \r\nDepois de usar sua arma de sopro, você não poderá \r\nutilizá-la novamente até completar um descanso curto ou \r\nlongo.", "Arma de Sopro", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1993) },
                    { new Guid("08f19d65-4584-4574-8602-39650c7b79d0"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2002), "Toda vez que você fizer \r\num teste de Inteligência (História) relacionado a itens \r\nmágicos, objetos alquímicos ou mecanismos tecnológicos, \r\nvocê pode adicionar o dobro do seu bônus de proficiência, \r\nao invés de qualquer bônus de proficiência que você \r\nnormalmente use.", "Conhecimento de Artífice", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2002) },
                    { new Guid("10f9fc4f-beb9-49ab-82ba-bbbcc8983e2f"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1969), " Você possui vantagem em testes de \r\nresistência contra venenos e resistência contra dano de \r\nveneno.", "Resiliência Anã", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1969) },
                    { new Guid("155903cc-9459-4e28-b34b-c632b6cd59f2"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1999), "Você conhece o truque ilusão \r\nmenor. Inteligência é a sua habilidade usada para \r\nconjurá-la.", "Ilusionista Nato", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1999) },
                    { new Guid("185f416b-ce2c-4b5e-8a0f-3567dc6e21b4"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1967), "Acostumado à vida subterrânea, \r\nvocê tem uma visão superior no escuro e na penumbra. \r\nVocê enxerga na penumbra a até 18 metros como se fosse \r\nluz plena, e no escuro como se fosse na penumbra. Você \r\nnão pode discernir cores no escuro, apenas tons de cinza.", "Visão no Escuro", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1967) },
                    { new Guid("23931b4c-99c0-4b73-a71f-8b1d6534988e"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2007), "Você possui resistência a dano \r\nde fogo.", "Resistência Infernal", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2007) },
                    { new Guid("2d3085e4-fd94-47a0-8f09-94b52333c23d"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1989), "Quando você obtiver um 1 natural em uma \r\njogada de ataque, teste de habilidade ou teste de \r\nresistência, você pode jogar de novo o dado e deve utilizar \r\no novo resultado.", "Sortudo", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1989) },
                    { new Guid("3179d428-80cb-4be2-96f2-276d517174ee"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1988), "Você possui o truque globos de luz. \r\nQuando você alcança o 3° nível, você pode conjurar a \r\nmagia fogo das fadas. Quando você alcança o 5° nível, \r\nvocê pode conjurar escuridão. Você precisa terminar um \r\ndescanso longo para poder conjurar as magias desse traço \r\nnovamente. Carisma é sua habilidade chave para \r\nconjurar essas magias.", "Magia Drow", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1988) },
                    { new Guid("3485c8c7-d45d-49c7-b20a-c91cc1939e1b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2006), "Quando você atinge um ataque \r\ncrítico com uma arma corpo-a-corpo, você pode rolar um \r\ndos dados de dano da arma mais uma vez e adicioná-lo ao \r\ndano extra causado pelo acerto crítico.", "Ataques Selvagens", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2006) },
                    { new Guid("42e4a0b9-63d2-49d2-bed4-099db0216bd8"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1992), "Você pode mover-se através do \r\nespaço de qualquer criatura que for de um tamanho maior \r\nque o seu.", "Agilidade Halfling", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1992) },
                    { new Guid("44ca3249-d1d5-4974-a63e-f291e1af51fc"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2010), "Você conhece o truque \r\ntaumaturgia. Quando você atingir o 3° nível, você poderá \r\nconjurar a magia repreensão infernal como uma magia de \r\n2° nível. Quando você atingir o 5° nível, você também \r\npoderá conjurar a magia escuridão. Você precisa terminar \r\num descanso longo para poder usar as magias desse traço \r\nnovamente. Sua habilidade de conjuração para essas \r\nmagias é Carisma.", "Legado Infernal", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2010) },
                    { new Guid("5608aab1-843f-49a9-b4dd-2534913af728"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2000), "Através de sons e \r\ngestos, você pode comunicar ideias simples para Bestas \r\npequenas ou menores. Gnomos da floresta amam os \r\nanimais e normalmente possuem esquilos, doninhas, \r\ncoelhos, toupeiras, pica-paus e outras criaturas como \r\namados animais de estimação.", "Falar com Bestas Pequenas", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2000) },
                    { new Guid("5b1eb6ac-86e8-4b29-a335-393a2a8a7e25"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2003), "Você possui proficiência com \r\nferramentas de artesão (ferramentas de engenhoqueiro). \r\nUsando essas ferramentas, você pode gastar 1 hora e 10 \r\npo em materiais para construir um mecanismo Miúdo (CA \r\n5, 1 pv). O mecanismo para de funcionar após 24 horas (a \r\nnão ser que você gaste 1 hora reparando-o para manter o \r\nmecanismo funcionando), ou quando você usa sua ação \r\npara desmantelá-lo; nesse momento, você pode recuperar \r\no material usado para criá-lo. Você pode ter até três\r\n desses mecanismos ativos ao mesmo tempo.", "Engenhoqueiro", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2003) },
                    { new Guid("6c2af6e4-4932-4868-a2db-c3afd7c14504"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1998), "Você possui vantagem em todos \r\nos testes de resistência de Inteligência, Sabedoria e \r\nCarisma contra magia.", "Esperteza Gnômica", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1998) },
                    { new Guid("898a0a3e-27be-4ccd-9b6d-d6eeae4568aa"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1994), "Você possui resistência ao tipo \r\nde dano associado ao seu ancestral dracônico.", "Resistência a Dano", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1994) },
                    { new Guid("98bdb94c-c21e-41d1-899c-91de6b1ef683"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1970), "Sempre que você \r\nrealizar um teste de Inteligência (História) relacionado à \r\norigem de um trabalho em pedra, você é considerado \r\nproficiente na perícia História e adiciona o dobro do seu \r\nbônus de proficiência ao teste, ao invés do seu bônus de \r\nproficiência normal.", "Especialização em Rochas", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1970) },
                    { new Guid("aa8a5350-88df-4ee2-9a81-77a6bcf1bb7c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1974), "Elfos não precisam dormir. Ao invés disso, \r\neles meditam profundamente, permanecendo \r\nsemiconscientes, durante 4 horas por dia. (A palavra em \r\nidioma comum para tal meditação é \"transe\".) Enquanto \r\nmedita, um elfo é capaz de sonhar de certo modo. Esses \r\nsonhos na verdade são exercícios mentais que se tornam \r\nreflexos através de anos de prática. Depois de descansar \r\ndessa forma, você ganha os mesmos benefícios que um \r\nhumano depois de 8 horas de sono. ", "Transe", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1974) },
                    { new Guid("abbad15f-3bd1-4282-926e-504cc59cfeba"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1972), "Você tem proficiência na perícia \r\nPercepção.", "Sentidos Aguçados", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1972) },
                    { new Guid("c75e02b9-5694-4938-8222-1023720a637c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2004), "Quando você é reduzido a \r\n0 pontos de vida mas não é completamente morto, você \r\npode voltar para 1 ponto de vida. Você não pode usar essa \r\ncaracterística novamente até completar um descanso \r\nlongo.", "Resistência Implacável", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(2004) },
                    { new Guid("c8e10725-2ad5-48d3-b28c-8b6c8cf62fec"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1987), "Você possui \r\ndesvantagem nas jogadas de ataque e testes de Sabedoria \r\n(Percepção) relacionados a visão quando você, o alvo do \r\nseu ataque, ou qualquer coisa que você está tentando \r\nperceber, esteja sob luz solar direta.", "Sensibilidade à Luz Solar", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1987) },
                    { new Guid("f71a75d9-ed25-4034-a7da-9388a27d64b7"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1990), "Você tem vantagem em testes de resistência \r\ncontra ficar amedrontado. ", "Bravura", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1990) },
                    { new Guid("fa42a0ca-977a-4b30-ae3b-51df8333b493"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1985), "Você pode tentar se esconder \r\nmesmo quando você está apenas levemente obscurecido  \r\npor folhagem, chuva forte, neve caindo, névoa ou outro \r\nfenômeno natural.", "Máscara da Natureza", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1985) },
                    { new Guid("fef60d18-d268-448a-b1a0-6385952e5ace"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1973), "Você tem vantagem nos testes de \r\nresistência para resistir a ser enfeitiçado e magias não \r\npodem colocá-lo para dormir.", "Ancestral Feérico", new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1973) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("01cba176-3d71-46f5-8544-9d0157843bf6"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1620), 0, "", 4, "Mochila", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1620), 2.0, 2.5 },
                    { new Guid("021458cc-8ff3-49ba-b325-bdb071b68531"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1659), 0, "", 4, "Roupas de entretenimento", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1659), 5.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("0234ff68-eba0-46d8-9d9d-a5e8fb116380"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1439), 0, 0, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Espada Grande", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1439), 50.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("03aeb0c8-a799-4d8c-b1ba-8ee7a3bd221a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1536), 0, "Quando você usa sua ação para \r\narmá-la, essa armadilha forma um anel de aço com \r\ndentes serrilhados. Eles se fecham quando uma criatura \r\npisa sobre uma placa de pressão no seu centro. A \r\narmadilha é fixada por uma pesada corrente em um \r\nobjeto fixo e imóvel, como uma árvore ou um cravo \r\nenterrado no chão. Uma criatura que pisar na placa de \r\npressão deve ser bem sucedida em um teste de resistência \r\nde Destreza CD 13 ou sofrerá 1d4 de dano perfurante e \r\npara de se mover. Daí em diante, até que a criatura se \r\nliberte da armadilha, seu movimento é limitado ao \r\ncomprimento da corrente (tipicamente 1 metro de \r\ncomprimento). A criatura presa pode usar sua ação para \r\nfazer um teste de Força CD 13 e se libertar, ou outra \r\ncriatura no alcance pode fazer o teste para libertá-la. \r\nCada fracasso no teste causa 1 de dano perfurante à \r\ncriatura presa.", 4, "Armadilha de caça", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1536), 5.0, 12.5 },
                    { new Guid("050d569c-658c-46c8-9f37-d85b7224b296"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1682), 2, "Por uma hora, a vela emana luz plena em um \r\nraio de 1,5 metro e penumbra por mais 1,5 metro.", 4, "Vela", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1682), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("052ac2b7-0b29-4a2d-a118-9fa7c2a8af7d"), 12, 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(981), 0, "Feita de couro resistente, mas flexível, é reforçada com rebites ou cravos.", 1, 0, 0, 1, "Couro Batido", false, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(981), 45.0, 6.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("06e19983-f18d-4683-9c89-052d78c18e51"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1892), 0, "Inclui uma mochila, um livro de\r\nestudo, um vidro de tinta, uma caneta tinteiro, 10 folhas de\r\npergaminho, um saquinho de areia e uma pequena faca.", 4, "Pacote de Estudioso", 5, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1892), 40.0, 0.0 },
                    { new Guid("0851556a-9bd5-49f8-9ff9-dfe7c0eff5fd"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1574), 0, "", 4, "Cajado", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1574), 5.0, 2.0 },
                    { new Guid("092a2364-0c32-4bf9-8707-b0dc83c8f9a7"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1571), 0, "A fechadura vem com chave. Sem a \r\nchave, uma criatura proficiente com ferramentas de \r\nladrão pode abrir a fechadura com um sucesso em um \r\nteste de Destreza CD 15. O Mestre pode decidir que \r\nfechaduras melhores estão disponíveis por preços mais \r\nelevados.", 4, "Fechadura", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1571), 10.0, 0.5 },
                    { new Guid("0be1f991-a36f-4d3a-8156-61b2c0b6be5a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1930), 1, "Preparada com ingredientes de boa qualidade, bem elaborada e saborosa. A refeição é servida em um ambiente confortável e bem cuidado, proporcionando uma experiência prazerosa e nutritiva. Inclui pratos variados e bem apresentados.", 4, "Confortável (refeição diária)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1930), 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("0cf5fb02-1aab-4ba4-9e7b-49a43ec9df97"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1416), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Maça", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1416), 5.0, 2.0 },
                    { new Guid("0f27a8cc-b5a0-40ba-9a98-d4a45cc0ae86"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1454), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Mangual", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1454), 10.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("106f48da-259d-4032-8ba0-1044c7a37468"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1562), 0, "Este kit inclui uma vara \r\nde pesca de madeira, linha de seda, boias de cortiça, \r\nanzóis de aço, chumbadas, iscas e redes de pesca.", 4, "Equipamento de pescaria", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1562), 1.0, 2.0 },
                    { new Guid("12e7fdab-8296-46e8-a2f4-cecd1cf6f157"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1580), 0, "", 4, "Varinha", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1580), 10.0, 0.5 },
                    { new Guid("146eaf7e-3a3a-4b33-82e8-729f82ea82ce"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1926), 2, "Consiste em restos mal preparados, muitas vezes estragados ou contaminados. A comida pode causar doenças. Sem qualquer prazer ou nutrição adequada. Consumida em um ambiente sujo e insalubre, com a constante presença de insetos e roedores.", 4, "Esquálida (refeição diária)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1926), 3.0, 0.0 },
                    { new Guid("150f1718-2a0a-4a28-be0e-53f2693b9d80"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1663), 2, "", 4, "Sabão", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1663), 2.0, 0.0 },
                    { new Guid("169bbf56-2cf2-48c2-9b2e-95060a384582"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1831), 0, "", 4, "Oboé", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1831), 2.0, 0.5 },
                    { new Guid("1a4a3830-1875-4099-aca6-71c767d83cdd"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1807), 0, "", 4, "Ferramentas de Pedreiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1807), 10.0, 4.0 },
                    { new Guid("1c30babd-e35a-4c33-90b8-0f233eacb179"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1822), 0, "", 4, "Alaúde", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1822), 35.0, 1.0 },
                    { new Guid("1d1954ef-052d-46e4-9a40-4f39430ae81a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1575), 0, "", 4, "Cristal", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1575), 10.0, 0.5 },
                    { new Guid("1df09394-d96e-4911-a296-94ff007ba9fd"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1676), 0, "Um abrigo simples e portátil que acomoda \r\nduas pessoas.", 4, "Tenda para duas pessoas", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1676), 2.0, 10.0 },
                    { new Guid("1ebac2a3-e392-4f8d-afee-508a2466461e"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1581), 0, "", 4, "Cajado de madeira", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1581), 5.0, 2.0 },
                    { new Guid("1f36e4c5-d930-4f74-aebe-d40db5465701"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1656), 1, "", 4, "Roupas comuns", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1656), 5.0, 1.5 },
                    { new Guid("1f49c692-104f-48b5-a242-7a3996d0b788"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1839), 0, "Essa pequena caixa contém uma \r\nvariedade de papéis e pergaminhos, canetas e tintas, \r\nselos e lacres, folha de ouro e prata, e outros suprimentos \r\nnecessários para criar falsificações convincentes de \r\ndocumentos físicos. Proficiência com esse kit permite \r\nadicionar o bônus de proficiência para quaisquer testes de \r\nhabilidade que você fizer para criar uma falsificação de \r\num documento físico.", 4, "Kit de Falsificação", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1839), 15.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("20a231c0-1b14-4502-9b4d-f3bbe394b5a1"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1432), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Cimitarra", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1432), 25.0, 1.5 },
                    { new Guid("21505036-95e2-4156-b0e4-cced60dfe66f"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1444), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 12, 0, "Lança de Montaria", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1444), 10.0, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("216dd3be-2026-4849-a238-b6faefbb41fd"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1811), 0, "", 4, "Ferramentas de Vidreiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1811), 30.0, 2.5 },
                    { new Guid("21aba942-e54c-40c1-b6bb-70bdfa8be875"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1925), 1, "", 4, "Queijo (pedaço)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1925), 2.0, 0.0 },
                    { new Guid("21ad198b-286e-4aed-a0ac-7558493173e3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1621), 2, "", 4, "Balas de Funda (20)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1621), 4.0, 0.75 },
                    { new Guid("21d9548d-35a1-42c3-b8c4-a36c080cf6d5"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1848), 0, "", 4, "Xadrez do Dragão", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1848), 1.0, 0.25 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("22420481-5297-47f3-bd82-cf572a89422c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1473), 0, 1, "Armas Marciais à Distância", 1, 6, 0, "Besta de Mão", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1473), 75.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2272f185-04c0-4f24-b30c-54514133db12"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1824), 0, "", 4, "Flauta", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1824), 2.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("22e09f7a-7579-4c4f-bee2-79cd079ec4a6"), 18, 2, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1013), 0, "Consiste em placas de metal moldadas para cobrir todo o corpo. Inclui luvas, botas de couro pesadas, um capacete com viseira e espessas camadas de enchimento por baixo da armadura. Fivelas e tiras de couro distribuem o peso ao longo do corpo.", 1, 0, 15, null, "Placas", true, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1013), 1500.0, 32.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("278d7349-17a0-4c0a-8bcf-ae5f2382119f"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1933), 0, "Caracterizada por uma experiência gastronômica de excelência, com pratos gourmet elaborados por chefs renomados. Os ingredientes são os melhores disponíveis, muitas vezes raros e caros. Servida em um ambiente opulento e sofisticado, com um serviço impecável. A refeição é uma celebração de sabor e luxo, frequentemente acompanhada de bebidas finas e uma apresentação artística.", 4, "Aristocrática (refeição diária)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1933), 2.0, 0.0 },
                    { new Guid("2a1bab8a-d9a3-4285-a9d8-ace3fa1038fb"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1672), 0, "", 4, "Sinete", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1672), 5.0, 0.0 },
                    { new Guid("2b194e10-e68b-4717-ae03-41e617e41321"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1647), 0, "Esse estojo de madeira pode \r\narmazenar até 20 virotes de besta.", 4, "Porta virotes", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1647), 1.0, 0.5 },
                    { new Guid("2b20d4c3-720e-4965-b32c-0d5b021e3b24"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1535), 0, " Você pode usar um aríete portátil \r\npara quebrar portas. Ao fazer isso, você ganha um bônus \r\nde +4 no teste de Força. Outra criatura pode ajudá-lo a \r\nusar o aríete, o que concede vantagem no teste.", 4, "Ariete portátil", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1535), 4.0, 17.5 },
                    { new Guid("2b43706e-3ae7-4bba-b9a9-2cec6f15124a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1825), 0, "", 4, "Flauta de Pã", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1825), 12.0, 1.0 },
                    { new Guid("2c20677d-c07d-414b-a85f-9849341128fb"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1554), 1, "", 4, "Cantil", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1554), 2.0, 2.5 },
                    { new Guid("2c2ed6d2-3575-4891-ba7f-5863e5360d20"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1600), 0, "Uma lanterna coberta lança luz \r\nplena em um raio de 9 metros e penumbra por mais 9 \r\nmetros. Uma vez acesa, ela queima por 6 horas usando \r\num frasco de óleo (500 ml). Usando uma ação, você pode \r\nabaixar a cobertura, reduzindo a claridade para \r\npenumbra em um raio de 1,5 metro.", 4, "Lanterna coberta", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1600), 5.0, 1.0 },
                    { new Guid("2c56a7f2-eb75-4b99-971e-2d8aca69ec1e"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1570), 0, "Usando uma ação, você pode espalhar um \r\núnico saco de estrepes para cobrir a área de um quadrado \r\nde 1,5 metro de lado. Qualquer criatura que entrar na \r\nárea deve ser bem sucedida em um teste de resistência de \r\nDestreza CD 15. Se falhar, para de se mover e sofre 1 de \r\ndano perfurante. Até que a criatura recupere pelo menos \r\n1 ponto de vida, seu deslocamento de caminhada é \r\nreduzido em 3 metros. Uma criatura que se mover pela \r\nárea usando metade do seu deslocamento não precisa \r\nfazer o teste de resistência.", 4, "Estrepes (bolsa com 20)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1570), 1.0, 1.0 },
                    { new Guid("2cdd1765-77f0-42bc-8024-cdce0f544bf3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1832), 0, "", 4, "Tambor", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1832), 6.0, 1.5 },
                    { new Guid("2d96cb25-7df9-49f8-b906-32a4fd958044"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1539), 0, "", 4, "Arpéu", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1539), 2.0, 2.0 },
                    { new Guid("2e974246-f515-41ed-aa1a-bfe01c25fa05"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1530), 0, "", 4, "Ampulheta", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1530), 25.0, 0.5 },
                    { new Guid("2f947f28-d83e-4994-8140-6d4f993a9f20"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1784), 0, "", 4, "Ferramentas de Carpinteiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1784), 8.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("30670922-06c1-4629-8341-5ea71d2613c6"), 14, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1005), 0, "Constituída por um peitoral de metal usado com couro flexível em seu interior. Embora ele deixe as pernas e braços do usuário relativamente desprotegidos, essa armadura fornece boa proteção para seus órgãos vitais, deixando quem a usa relativamente sem restrições.", 1, 2, 0, 1, "Peitoral", false, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1005), 400.0, 10.0 },
                    { new Guid("30a819cd-3b8f-47ae-9b64-3bbfa5d34130"), 11, 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(957), 0, "Consiste em camadas de panos acolchoados e batidos.", 1, 0, 0, 1, "Acolchoada", true, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(957), 5.0, 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("30f7fc5f-5b3c-4435-8adc-104f2bea2d69"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1790), 0, "", 4, "Ferramentas de Entalhador", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1790), 1.0, 2.5 },
                    { new Guid("3672f09f-2ce8-45de-8cca-2ec6c32ba5cf"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1826), 0, "", 4, "Gaita de Foles", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1826), 30.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("36884830-9fa6-430e-811f-18f07e663b2c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1472), 0, 1, "Armas Marciais à Distância", 1, 8, 0, "Arco Longo", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1472), 50.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("394ea2bb-b034-4f6d-9951-810b5bbd14fd"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1617), 0, "", 4, "Marreta", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1617), 2.0, 5.0 },
                    { new Guid("3a363220-6d59-490d-93a1-292b4f096245"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1545), 0, "", 4, "Baú", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1545), 5.0, 12.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3bb16564-4edd-43c1-9922-18ea388c39ad"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1431), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Alabarda", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1431), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3f35a312-31f3-4996-9e22-03c079485398"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1558), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de cânhamo (15 metros)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1558), 1.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3f4203e3-a0d8-4614-83f9-c315683c5e76"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1457), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Picareta de Guerra", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1457), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4509881d-ceae-4f0e-ba1b-aee6cbf5efda"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1597), 0, "Esse kit é uma bolsa de \r\ncouro contendo ataduras, pomadas e talas. O kit possui \r\nmaterial suficiente para dez usos. Usando uma ação, você \r\npode gastar um uso do kit para estabilizar uma criatura \r\nque tenha 0 pontos de vida, sem a necessidade de realizar \r\num teste de Sabedoria (Medicina).", 4, "Kit de primeiros-socorros", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1597), 5.0, 1.5 },
                    { new Guid("459096bc-45f1-48ef-b175-25373479d48d"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1644), 2, "", 4, "Piton", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1644), 5.0, 0.0 },
                    { new Guid("47023e6e-334e-4f84-aae4-9a306f292851"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1637), 0, "Usar um pé de cabra concede vantagem \r\nnos testes de Força onde uma alavanca possa ser \r\naplicada.", 4, "Pé de cabra", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1637), 2.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("476b8e36-042e-45ff-837c-79d87ed62408"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1422), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Martelo Leve", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1422), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("47febd39-a825-48f2-b891-2bf76e8e7ca9"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1639), 2, "", 4, "Pedra de amolar", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1639), 1.0, 0.0 },
                    { new Guid("48229987-61b0-4410-91d0-a4eb9eff4d03"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1665), 2, "", 4, "Saco", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1665), 1.0, 0.25 },
                    { new Guid("48b6aa6f-1198-4173-aaed-f2216674fb0d"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1652), 1, "Consistem em alimentos desidratados adequados para viagens longas, \r\nincluindo carne seca, frutas secas, bolachas e nozes. ", 4, "Rações de viagem (1 dia)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1652), 5.0, 1.0 },
                    { new Guid("49bd54dc-dbcf-46b2-9f7f-e39d0a9d3e6c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1633), 1, "", 4, "Papel (uma folha)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1633), 2.0, 0.0 },
                    { new Guid("4aa8512e-fbdc-49f9-ae46-f536161099d1"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1792), 0, "", 4, "Ferramentas de Ferreiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1792), 20.0, 4.0 },
                    { new Guid("4b5fdd4e-dcf3-46ec-b7ec-cc4ea8771d99"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1599), 1, "Uma lâmpada lança luz plena em um raio \r\nde 4,5 metros e penumbra por mais 9 metros. Uma vez \r\nacesa, a lâmpada queima por 6 horas usando um frasco de \r\nóleo (500 ml).", 4, "Lâmpada", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1599), 5.0, 0.5 },
                    { new Guid("4c0ccb0b-8b21-454d-b0e4-f4cd42770fab"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1549), 2, "", 4, "Caneca", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1549), 2.0, 0.5 },
                    { new Guid("4c23d931-77b4-484c-ae8b-102a913a2fe2"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1798), 0, "", 4, "Ferramentas de Oleiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1798), 10.0, 1.5 },
                    { new Guid("4c6c030e-a0c1-41b8-8fe2-f5bebcc4dcd3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1532), 0, "Uma criatura que beber o líquido desse \r\nvidro tem vantagem em testes de resistência contra \r\nvenenos por 1 hora. O antídoto não confere nenhum \r\nbenefício para mortos-vivos ou constructos. ", 4, "Antídoto (vidro)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1532), 50.0, 0.0 },
                    { new Guid("4d3f4b4f-b6d7-4102-8513-87f81cbc8daf"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1835), 0, "", 4, "Violino", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1835), 30.0, 3.0 },
                    { new Guid("4d4db9c7-f54d-4be2-a4d0-ca4301620eea"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1919), 2, "", 4, "Cerveja (caneca)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1919), 4.0, 0.0 },
                    { new Guid("4e704309-4036-4c9d-9fe6-154bbc70cd63"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1812), 0, "", 4, "Suprimentos de Alquimista", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1812), 50.0, 4.0 },
                    { new Guid("4f4e5553-4da6-4f9d-a0fd-64f31f27de6b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1559), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de seda (15 metros)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1559), 10.0, 2.5 },
                    { new Guid("4fcb6e38-d80a-42b1-b19a-4883e58a8e12"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1650), 0, "", 4, "Pregos de ferro (10)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1650), 1.0, 2.5 },
                    { new Guid("51a7c4ed-b20e-4dc2-a52b-378a2c066261"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1627), 0, "", 4, "Zarabatana (50)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1627), 1.0, 0.5 },
                    { new Guid("51dc02fd-cb1c-498b-a67f-6103233b2203"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1584), 0, "", 4, "Totem", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1584), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5210c673-f8f7-4b9c-9515-50fc786b3e4c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1426), 0, 1, "Armas Simples à Distância", 1, 8, 0, "Besta Leve", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1426), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("523ed820-a9e4-4b0e-816c-de0da37c2e2f"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1655), 0, "Um conjunto de roldanas com um \r\ncabo entre elas e um gancho para fixar aos objetos, a \r\nroldana e polia permitem içar até quatro vezes o peso que \r\nvocê ergueria normalmente.", 4, "Roldana e polia", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1655), 1.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5376d6c6-22e1-46e1-b40d-b6923b1bfc4a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1423), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Porrete", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1423), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5497ff23-4ae2-4b77-a231-0e7157b42dbd"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1918), 1, "", 4, "Cerveja (galão)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1918), 2.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5630485e-f338-46ee-be8b-7bceda0ad881"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1451), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Machado de Batalha", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1451), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("567bbb48-6188-4b4e-84a6-0df9b1d43f4f"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1938), 0, "", 4, "Vinho Fino (garrafa)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1938), 10.0, 0.0 },
                    { new Guid("56feccdd-9a4e-42c8-a5c5-131c5f0268f2"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1556), 1, "", 4, "Cobertor de inverno", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1556), 5.0, 1.5 },
                    { new Guid("589318ba-e0ee-477f-9d2c-8c1e6d0d1508"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1634), 1, "", 4, "Parafina", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1634), 5.0, 0.0 },
                    { new Guid("59be8cbe-69f5-45db-80f0-2f1967ea3887"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1837), 0, "", 4, "Xilofone", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1837), 25.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5a00819c-e6d7-44b0-9bcf-2a4a14a66230"), 2, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1762), 0, "Esse líquido pegajoso e adesivo\r\ninflama em contado com o ar. Usando uma ação, você\r\npode arremessar esse frasco a até 6 metros de distância,\r\nquebrando-o com o impacto. Você deve realizar um ataque\r\nà distância contra uma criatura ou objeto, tratando o fogo\r\nalquímico como uma arma improvisada. Em um sucesso,\r\no alvo sofre 1d4 de dano de fogo no início de cada um de\r\nseus turnos. Uma criatura pode terminar esse dano\r\nusando sua ação e fazendo um teste de Destreza CD 10\r\npara apagar as chamas.", 4, 2, 0, 2, "Fogo alquímico (frasco)", 2, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1762), 50.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("5ac8bcaf-bff6-4e88-81e1-2e617c9398f9"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1528), 0, "Uma bolsa de pano ou couro que pode \r\narmazenar até 20 munições de funda ou 50 munições de \r\nzarabatana, entre outras coisas. Para armazenar \r\ncomponentes de magia, veja bolsa de componentes, \r\ntambém descrita nessa seção.", 4, "Algibeira", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1528), 5.0, 0.5 },
                    { new Guid("5cb7e51c-2f40-48b2-b409-70325851e215"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1609), 0, "", 4, "Manto", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1609), 1.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5da86696-6845-48a3-ad44-cc8b55594861"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1446), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Maça Estrela", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1446), 15.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("6128a731-aca4-4a18-bd8a-653020cf755b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1667), 0, "", 4, "Amuleto", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1667), 5.0, 0.5 },
                    { new Guid("6158c51e-00bf-43f6-9ea5-ea7a116368e6"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1618), 0, "", 4, "Martelo", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1618), 1.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6174c728-2af2-4a52-bf53-2d42e16939f0"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1425), 0, 1, "Armas Simples à Distância", 1, 6, 0, "Arco Curto", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1425), 25.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("63dfdea0-ecaf-468c-a0a6-bce98347298a"), 14, 2, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1008), 0, "Feita de couro com pesados anéis presos a ela. Os anéis ajudam a reforçar a armadura contra golpes de espadas e machados. A cota de anéis é inferior à cota de malha e geralmente é vestida apenas por aqueles que não podem pagar por uma armadura melhor.", 1, 0, 0, null, "Cota de anéis", true, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1008), 30.0, 20.0 },
                    { new Guid("67cffff9-bdf0-461b-99fe-b3e02b58a891"), 17, 2, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1012), 0, "Feita de tiras verticais de metal, rebitadas a um suporte de couro, usadas sobre um preenchimento de pano. Cotas de malha flexíveis protegem as articulações.", 1, 0, 15, null, "Cota de malha", true, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1012), 200.0, 30.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("68291365-965c-4346-b655-e8f6ca9d0635"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1567), 0, "Usando uma ação, você pode \r\ndespejar essas minúsculas esferas de metal para cobrir a \r\nárea de um quadrado de 3 metros de lado. A criatura que \r\nse mover dentro da área deve ser bem sucedida em um \r\nteste de resistência de Destreza CD 10 para não cair no \r\nchão. Uma criatura que mover pela área usando metade \r\ndo seu deslocamento não precisa fazer o teste de \r\nresistência.", 4, "Esferas (sacola com 1.000)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1567), 1.0, 1.0 },
                    { new Guid("689bfefa-e1dd-414c-a77b-413a33f41f21"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1587), 2, "", 4, "Frasco", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1587), 2.0, 1.0 },
                    { new Guid("6904245e-dff5-43f4-a663-49b29ef56950"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1679), 0, "", 4, "Tinta (frasco de 30ml)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1679), 10.0, 0.0 },
                    { new Guid("6ab69f21-3736-4533-bdaf-cf9f1f3a139f"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1795), 0, "", 4, "Ferramentas de Joalheiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1795), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6ccbd83a-598b-43a4-9e54-fe619d8bb261"), 13, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1001), 0, "Feito de anéis de metal intercalados, um camisão de cota de malha é usado entre as camadas de roupa. Essa armadura oferece proteção modesta para a parte superior do corpo de quem a usa e permite que o som dos anéis de metal, friccionados uns contra os outros, sejam amortecidos pelas camadas exteriores.", 1, 2, 0, 1, "Camisão de Malha", false, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1001), 30.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6eaef294-4078-4509-9a8f-88e747607651"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1456), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Martelo de Guerra", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1456), 15.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("6ebe6641-d3ff-4f89-bdc6-338c6f3ac51b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1631), 0, "", 4, "Panela de ferro", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1631), 2.0, 5.0 },
                    { new Guid("6fb4c6b9-d1fe-4b50-8bdb-be2f03f801f0"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1521), 0, "Usando uma ação, você pode despejar o \r\nconteúdo desse vidro em uma criatura a até 1,5 metro de \r\nvocê, ou arremessar o vidro a até 6 metros de distância, \r\nquebrando-o no impacto. Em ambos os casos, você deve \r\nrealizar um ataque à distância contra uma criatura ou \r\nobjeto, tratando o ácido como uma arma improvisada. Se \r\nacertar, o alvo sofre 2d6 de dano ácido.", 4, "Ácido (vidro)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1521), 25.0, 0.5 },
                    { new Guid("7083b393-4416-46bf-b0a8-d76c333577f3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1789), 0, "", 4, "Ferramentas de Coureiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1789), 5.0, 2.5 },
                    { new Guid("7090214a-6526-4c48-b4c3-ab33c604397f"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1588), 0, "", 4, "Garrafa de vidro", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1588), 1.0, 1.0 },
                    { new Guid("7caa2877-1960-4a80-a6c8-df1660cddf66"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1533), 0, "", 4, "Apito de advertência", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1533), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7d31d624-eaac-484d-aa32-c12f4b2b56ef"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1412), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Bordão", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1412), 2.0, 2.0 },
                    { new Guid("7d7eb17a-4aad-43d3-b23b-0b29bfbb191e"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1467), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Rapieira", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1467), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7e62d922-8784-44b4-bbbd-f93dca83fe5e"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1891), 0, "Inclui um baú, 2 caixas para\r\nmapas ou pergaminhos, um conjunto de roupas finas, um vidro de\r\ntinta, uma caneta tinteiro, uma lâmpada, 2 frascos de óleo, 5\r\nfolhas de papel, um vidro de perfume, parafina e sabão.", 4, "Pacote de Diplomata", 5, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1891), 39.0, 0.0 },
                    { new Guid("817f4834-b263-45c9-9305-92bd95fcab77"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1593), 0, "Essencial para os magos, um grimório é \r\num volume encadernado em couro com 100 páginas de \r\npergaminhos em branco, adequado para armazenar \r\nmagias.", 4, "Grimório", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1593), 50.0, 1.5 },
                    { new Guid("81f3f362-62a3-4680-af24-5cc381ce0c43"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1819), 0, "Esse conjunto de instrumentos é usado para navegação no mar. \r\nProficiência com as ferramentas de navegador permite \r\ntraçar um curso de navio e seguir cartas de navegação. \r\nAlém disso, essas ferramentas permitem que você \r\nadicione seu bônus de proficiência para qualquer teste de \r\nhabilidade que fizer para não se perder no mar. ", 4, "Ferramentas de navegação", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1819), 25.0, 1.0 },
                    { new Guid("83b4da7b-5ad1-40f2-a187-fd899f2df9e3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1653), 0, "", 4, "Robes", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1653), 1.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("8752b96d-db02-4e78-8624-da24935562ce"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1450), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Machado Grande", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1450), 30.0, 3.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8b16243f-68fd-422a-8aa0-a2502cd77861"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1669), 0, "", 4, "Emblema", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1669), 5.0, 0.0 },
                    { new Guid("8cd0c359-b1f5-4f09-a725-f5158f36b8e2"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1642), 1, "", 4, "Pergaminho (uma folha)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1642), 1.0, 0.0 },
                    { new Guid("8e183f08-baec-40a6-b183-6ca262d6d53c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1596), 0, "Um kit de escalada inclui pítons \r\nespeciais, botas com solas pontiagudas, luvas e um cinto. \r\nVocê pode usar o kit de escalada como uma ação para \r\n\"ancorar-se\". Quando faz isso, você não pode cair mais de \r\n7,5 metros a partir do ponto onde se ancorou, e não pode \r\nsubir mais de 7,5 metros de distância desse ponto, sem \r\ndesfazer a âncora.", 4, "Kit de escalada", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1596), 25.0, 6.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8eada2ed-822e-4e32-9c31-f741354613a2"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1410), 1, 1, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Azagaia", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1410), 5.0, 1.0 },
                    { new Guid("8f9f922e-3193-4d97-9d6b-9707430ad2bb"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1476), 0, 1, "Armas Marciais à Distância", 0, 1, 0, "Rede", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1476), 1.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8fcc6eb5-a296-4ebb-bce7-462c00d1c8c3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1885), 0, "Inclui uma mochila, um saco de\r\ndormir, duas fantasias, 5 velas, 5 dias de rações, um cantil e um kit\r\nde disfarce.", 4, "Pacote de Artista", 5, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1885), 40.0, 0.0 },
                    { new Guid("9404af37-1cfa-45e2-a192-8a0c7b84bf8a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1895), 0, "Inclui uma mochila, um\r\ncobertor, 10 velas, uma caixa de fogo, uma caixa de esmolas, 2\r\nblocos de incenso, um incensário, vestes, 2 dias de rações e um\r\ncantil.", 4, "Pacote de Sacerdote", 5, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1895), 19.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("96f5f049-acc0-4546-8031-fa9ed206f106"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1475), 0, 1, "Armas Marciais à Distância", 1, 10, 0, "Besta Pesada", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1475), 50.0, 4.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("9760bdeb-0b62-4909-8ddc-ef8b713606e2"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1927), 2, "Composta por ingredientes básicos e de qualidade questionável. A refeição é simples, sem variedade, suficiente para manter alguém vivo, mas insatisfatória e possivelmente desagradável. Frequentemente rústica e pouco apetitosas.", 4, "Pobre (refeição diária)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1927), 6.0, 0.0 },
                    { new Guid("976b9f9a-4a2b-4894-94bd-0975eb171874"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1583), 0, "", 4, "Ramo de visco", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1583), 1.0, 0.0 },
                    { new Guid("9816e2c0-f91e-4879-9a69-8c69184c191c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1565), 1, "", 4, "Escada (3 metros)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1565), 1.0, 12.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9e8fa08e-0a5b-45b9-a41a-a66584276f56"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1415), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Foice Curta", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1415), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a18923f3-d3fa-4b74-825d-e630d14baf5d"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1793), 0, "", 4, "Ferramentas de Funileiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1793), 50.0, 5.0 },
                    { new Guid("a1c5a6e2-3c22-4559-b3ac-e1bf3213cc4a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1626), 0, "", 4, "Virotes (20)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1626), 1.0, 0.75 },
                    { new Guid("a1fe2028-d92f-48e2-8ba6-da9f67f5e788"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1813), 0, "", 4, "Suprimentos de Cervejeiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1813), 20.0, 4.5 },
                    { new Guid("a2d2314e-e462-47c4-b1ed-8300b0bf01eb"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1678), 2, "A tocha queima por 1 hora, fornecendo luz \r\nplena em um raio de 6 metros e penumbra por mais 6 \r\nmetros. Se você realizar um ataque corpo-a-corpo com \r\numa tocha acesa e acertar, causa 1 de dano flamejante.", 4, "Tocha", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1678), 1.0, 0.5 },
                    { new Guid("a2d8b870-eb6e-482a-9645-99e963ecd63c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1815), 0, "", 4, "Suprimentos de Caligrafia", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1815), 10.0, 2.5 },
                    { new Guid("a3663bbc-b04f-4850-a1d9-0bd4bf88454b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1838), 0, "Essa bolsa de cosméticos, tintura de \r\ncabelo e pequenos adereços permite criar disfarces que \r\nmudam sua aparência física. Proficiência com este kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar um disfarce \r\nvisual.", 4, "Kit de Disfarce", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1838), 25.0, 1.5 },
                    { new Guid("a3817e7c-acef-4612-b42f-2d5af5331584"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1595), 2, "", 4, "Jarra", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1595), 4.0, 2.0 },
                    { new Guid("a3e105be-7781-42cd-b3ed-f4380c7f8dcd"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1628), 1, "Geralmente vem em um frasco de argila que \r\ncontém 500 ml. Usando uma ação, você pode espirrar o \r\nóleo desse frasco em uma criatura a até 1,5 metro de você\r\nou arremessar a até 6 metros, quebrando-o com o \r\nimpacto. Você deve realizar um ataque à distância contra \r\numa criatura ou objeto, tratando o óleo como uma arma \r\nimprovisada. Com um sucesso, o alvo é coberto de óleo. Se \r\no alvo sofrer qualquer dano flamejante antes do óleo secar\r\n (depois de 1 minuto), a criatura sofre 5 de dano \r\nflamejante adicional pela queima do óleo. Você também \r\npode derramar um frasco de óleo no chão para cobrir uma \r\nárea de um quadrado de 1,5 metro de lado, desde que a \r\nsuperfície esteja nivelada. Se aceso, o óleo queima por 2 \r\nrodadas e causa 5 de dano flamejante a qualquer criatura \r\nque entrar na área ou terminar seu turno dentro da área. \r\nUma criatura pode sofrer esse dano apenas uma vez por \r\nturno.", 4, "Óleo (frasco)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1628), 1.0, 0.5 },
                    { new Guid("a4a337a0-48a3-4932-b201-a9fae77eba83"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1592), 2, "", 4, "Giz (1 peça)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1592), 1.0, 0.0 },
                    { new Guid("a63514a6-c906-44ee-9ea9-3380763c7512"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1923), 2, "", 4, "Pão (pedaço)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1923), 2.0, 0.0 },
                    { new Guid("a63b4e72-0e40-4bdd-a93e-24754b5dbde8"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1834), 0, "", 4, "Trombeta", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1834), 3.0, 1.0 },
                    { new Guid("a7de4c7a-8d6f-42db-b78c-71b9e59fabfe"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1887), 0, "Inclui uma mochila, um pé de\r\ncabra, um martelo, 10 pítons, 10 tochas, uma caixa de fogo, 10\r\ndias de rações e um cantil. O kit também tem 15 metros de corda\r\nde cânhamo amarrada ao lado dele.", 4, "Pacote de Aventureiro", 5, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1887), 12.0, 0.0 },
                    { new Guid("a859770c-34ae-47bc-995e-e9100f7c3062"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1541), 0, "Trata-se de uma pequena \r\nbalança, pratos e um sortimento adequado de pesos de até \r\n1 kg. Com ela, você pode medir o peso exato de pequenos \r\nobjetos, como metais preciosos brutos ou bens comerciais, \r\npara ajudar a determinar seu valor.", 4, "Balança de mercador", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1541), 5.0, 1.5 },
                    { new Guid("a87fd305-d1b1-4e0d-82c1-fa26f634bb5c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1561), 0, "Uma corrente possui 10 pontos de vida e \r\npode ser arrebentada com um teste de Força CD 20 bem \r\nsucedido.", 4, "Corrente (3 metros)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1561), 5.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a9f28fa3-65df-4629-9191-2d5254a9b30f"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1442), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Glaive", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1442), 20.0, 3.0 },
                    { new Guid("aa943790-2fde-4dcc-8b77-d746638f8253"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1445), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Lança Longa", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1445), 5.0, 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("acb607bf-08dd-441b-98c9-2bc2141cf0e3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1666), 0, "", 4, "Saco de dormir", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1666), 1.0, 3.5 },
                    { new Guid("acbd158d-8c05-4331-9940-1f65ed982e7e"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1555), 1, "", 4, "Cesto", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1555), 4.0, 1.0 },
                    { new Guid("ace8bfed-834b-4b48-80e4-836421864e5b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1916), 1, "", 4, "Carne (pedaço)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1916), 3.0, 0.0 },
                    { new Guid("ad451c49-f2c2-47f7-be24-0b19b490b908"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1841), 0, "Esse kit contém uma variedade \r\nde instrumentos, como alicates, almofariz e pilão, e bolsas \r\ne frascos utilizados pelos herbalistas para criar remédios \r\ne poções. Proficiência com este kit permite adicionar o \r\nbônus de proficiência para quaisquer testes de habilidade \r\nque você fizer para identificar ou aplicar ervas. Além \r\ndisso, a proficiência com esse kit é necessária para criar \r\nantídotos e poções de cura.", 4, "Kit de Herbalismo", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1841), 5.0, 1.5 },
                    { new Guid("b30d2c39-cf0f-48ee-929f-c22c1994cbfb"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1886), 0, "Inclui uma mochila, um saco\r\ncom 1.000 esferas de metal, 3 metros de linha, um sino, 5 velas,\r\num pé de cabra, um martelo, 10 pítons, uma lanterna coberta, 2\r\nfrascos de óleo, 5 dias de rações, uma caixa de fogo e um cantil. O\r\nkit também possui 15 metros de corda de cânhamo amarrada ao\r\nlado dele.", 4, "Pacote de Assaltante", 5, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1886), 16.0, 0.0 },
                    { new Guid("b33d327b-d495-4a87-9336-f2060d54e762"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1552), 2, "", 4, "Caneta tinteiro", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1552), 2.0, 0.0 },
                    { new Guid("b38f7f8e-d131-4c68-9e7f-a52f97c3ae7e"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1821), 0, "Esse conjunto de ferramentas inclui uma pequena pasta, um conjunto de \r\nchaves mestras, um pequeno espelho montado em uma \r\nalça de metal, um conjunto de tesouras de lâminas \r\nestreitas e um par de alicates. Proficiência com essas \r\nferramentas permite adicionar o bônus de proficiência \r\npara quaisquer testes de habilidade que você fizer para \r\ndesarmar armadilhas ou abrir fechaduras.", 4, "Ferramentas de ladrão", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1821), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b726d3fc-fa20-4a8e-b89e-0ac96623cba4"), 0, 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1018), 0, "Feito de madeira ou metal e é usado com uma mão. Empunhar um escudo aumenta sua Classe de Armadura em 2. Você só pode se beneficiar de um escudo por vez.", 1, 2, 0, null, "Escudo", true, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1018), 10.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b7d1265e-c8d0-40e1-9d9d-b79c6889f984"), 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1761), 0, "Você pode usar o veneno contido\r\nnesse vidro para cobrir a lâmina de uma arma cortante ou\r\nperfurante ou até três peças de munição. Aplicar o veneno\r\nleva uma ação. Uma criatura atingida pela arma ou\r\nmunição envenenada deve obter sucesso em um teste de\r\nresistência de Constituição CD 10 ou sofrerá 1d4 de dano\r\nde veneno. Uma vez aplicado, o veneno retém sua\r\npotência durante 1 minuto antes de secar.", 4, 1, 1, 2, "Veneno básico (frasco)", 2, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1761), 100.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("b83fb215-d864-4382-9d75-179b17189ee0"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1572), 0, "", 4, "Bastão", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1572), 10.0, 1.0 },
                    { new Guid("bb289773-8663-444c-96a1-03598b530492"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1929), 1, "Inclui pratos simples e caseiros, preparados com ingredientes frescos, mas comuns. A refeição é nutritiva e satisfatória, servida em um ambiente limpo e acolhedor. Não há luxo, mas proporciona uma experiência agradável.", 4, "Modesta (refeição diária)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1929), 3.0, 0.0 },
                    { new Guid("bb9b40c3-87e9-4410-8400-c0fbd4709ee3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1932), 1, "Composta por pratos sofisticados e requintados, preparados com ingredientes de alta qualidade e muitas vezes exóticos. A refeição é servida em um ambiente elegante e refinado, acompanhada por um excelente serviço. Proporciona uma experiência culinária luxuosa e memorável.", 4, "Rica (refeição diária)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1932), 8.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("bc80d22b-5bb2-4d73-bbf8-754223e054ba"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1408), 0, 1, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Adaga", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1408), 2.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("be199af7-81ea-4167-bd96-20cf87601112"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1526), 0, " Essas algemas de metal podem prender \r\numa criatura Pequena ou Média. Escapar das algemas \r\nexige sucesso em um teste de Destreza CD 20. Quebrá-las \r\nexige um teste de Força CD 20 bem sucedido. Cada \r\nconjunto de algemas vem com uma chave. Sem a chave, \r\numa criatura proficiente com ferramentas de ladrão pode \r\nabrir a fechadura das algemas com um sucesso em um \r\nteste de Destreza CD 15. As algemas têm 15 pontos de \r\nvida. ", 4, "Algemas", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1526), 2.0, 2.0 },
                    { new Guid("c330dc09-6058-4b8b-bc5f-291f3ef39887"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1605), 0, "Essa lente permite ver pequenos \r\nobjetos mais de perto. Ela também é útil como um \r\nsubstituto da pederneira e isqueiro para acender fogo. \r\nUsar uma lupa para acender fogo necessita de luz tão \r\nbrilhante como a luz do sol para focar, um pavio e cerca \r\nde 5 minutos. Uma lente de aumento concede vantagem \r\nem qualquer teste de habilidade feito para avaliar ou \r\ninspecionar um item que é pequeno ou muito detalhado.", 4, "Lente de aumento", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1605), 100.0, 0.0 },
                    { new Guid("c3a4e049-6b4b-4ad8-b4af-f9d91be55559"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1542), 2, "", 4, "Balde", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1542), 5.0, 1.0 },
                    { new Guid("c44a0147-560a-4f33-8702-d028a922959b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1680), 2, "", 4, "Vara (3 metros)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1680), 5.0, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c54b0396-9341-43bd-ae81-c3343956eb3b"), 16, 2, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1010), 0, "Feita de anéis de metal entrelaçados, a cota de malha inclui uma camada de tecido acolchoado usada por baixo da malha de metal para evitar atrito e amortecer o impacto dos golpes. O conjunto inclui manoplas.", 1, 0, 13, null, "Cota de malha", true, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1010), 75.0, 27.5 },
                    { new Guid("c57e9bcf-4937-4f8b-8f0a-219ae566b079"), 14, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1003), 0, "Consiste em um casaco e calças (e talvez uma saia separada) de couro coberto com peças sobrepostas de metal, assim como as escamas de peixe. O conjunto inclui manoplas.", 1, 2, 0, 1, "Brunea", true, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1003), 50.0, 22.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c7725e4c-b77a-4ad3-aa8e-507550d8dce7"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1606), 0, "Um livro pode conter poesia, relatos históricos, \r\ninformações relativas a um campo particular de \r\nsabedoria, diagramas e notas sobre engenhocas gnômicas, \r\nou qualquer outra coisa que possa ser representada \r\nusando texto ou imagens.", 4, "Livro", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1606), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c7a2de0f-1238-4734-97c4-09bd3cbfafa1"), 11, 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(980), 0, "São feitos de couro que foi endurecido após ser fervido em óleo. O resto da armadura é feita de materiais mais macios e mais flexíveis.", 1, 0, 0, 1, "Couro", false, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(980), 10.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c8d61ee4-4db2-4919-9f7c-7a1b1409750b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1520), 0, "Instrumento de cálculo, formado por uma moldura com bastões ou arames paralelos, dispostos no sentido vertical, correspondentes cada um a uma posição digital (unidades, dezenas, etc.) e nos quais estão os elementos de contagem (fichas, bolas ou contas) que podem fazer-se deslizar livremente.", 4, "Ábaco", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1520), 2.0, 1.0 },
                    { new Guid("c92cc52b-dd1f-4d00-baa2-bc84b46b1fac"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1568), 0, "", 4, "Espelho de aço", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1568), 5.0, 0.25 },
                    { new Guid("c9c89d78-71fd-460f-8c13-64d3f5519211"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1850), 0, "O kit de venenos inclui os frascos, \r\nprodutos químicos e outros equipamentos necessários \r\npara a criação de venenos. Proficiência com esse kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar ou utilizar \r\nvenenos.", 4, "Kit de Venenos", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1850), 50.0, 1.0 },
                    { new Guid("cb10b5f5-d905-4496-a46d-a9017fbe00f4"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1818), 0, "", 4, "Utensílios de Cozinheiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1818), 1.0, 4.0 },
                    { new Guid("cece37e8-c03a-4697-a65d-8c73525a4eee"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1523), 0, "Usando uma ação, você pode espalhar o \r\nconteúdo desse frasco em uma criatura a até 1,5 metro de \r\nvocê ou arremessar a até 6 metros, quebrando o frasco \r\ncom o impacto. Em ambos os casos, você deve realizar um \r\nataque à distância contra uma criatura alvo, tratando a \r\nágua benta como uma arma improvisada. Se o alvo for um \r\ncorruptor ou morto-vivo, ele sofre 2d6 de dano radiante. ", 4, "Água benta (frasco)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1523), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d00a5dc3-9458-409f-8116-cabcdba79d21"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1453), 0, 2, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Malho", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1453), 10.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d0a6f8e1-7394-4709-b68f-6fcbdad38c94"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1602), 0, "Uma lanterna furta-fogo \r\nlança luz plena em um cone de 18 metros e penumbra por \r\nmais 18 metros. Uma vez acesa, ela queima por 6 horas \r\nusando um frasco de óleo (500 ml).", 4, "Lanterna furta-fogo", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1602), 10.0, 1.0 },
                    { new Guid("d18a9bef-db1e-413f-95d4-6701d55c78fd"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1844), 1, "", 4, "Baralho de Cartas", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1844), 5.0, 0.0 },
                    { new Guid("d216e629-8e91-4dd1-99bc-74eb65e2066a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1543), 0, "", 4, "Barril", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1543), 2.0, 35.0 },
                    { new Guid("d4570a25-94ae-4a65-aa02-c78bc2919a67"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1608), 0, "Objetos vistos através de uma luneta são \r\nampliados até o dobro do seu tamanho.", 4, "Luneta", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1608), 1000.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d4855750-5360-45e7-b48c-5ac0efaef223"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1418), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Machadinha", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1418), 5.0, 1.0 },
                    { new Guid("d59bb173-d0c6-44eb-8e7c-b0f4e87b5b53"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1437), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Espada Curta", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1437), 10.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d71383a8-bc11-4987-9902-f06e246459c5"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1546), 0, "Trata-se de uma pequena \r\nbolsa de couro à prova d'água que pode ser fixada em um \r\ncinto. Ela possui compartimentos para armazenar todos \r\nos componentes materiais e outros itens especiais que \r\nvocê precisa para lançar suas magias, exceto os \r\ncomponentes que possuem um custo específico (conforme \r\nindicado na descrição da magia).", 4, "Bolsa de componentes", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1546), 25.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d74436e9-469e-49a2-837e-a0abba3cdbd7"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1413), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 8, 0, "Clava Grande", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1413), 2.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d76b089f-386e-47dc-9747-06096ee71739"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1624), 0, "", 4, "Flechas (20)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1624), 1.0, 0.5 },
                    { new Guid("d7d3b77b-2d3e-4085-b41f-c85a3c34070a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1808), 0, "", 4, "Ferramentas de Pintor", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1808), 10.0, 2.5 },
                    { new Guid("d88844c9-0336-46f9-863b-4d3dbf13d0d4"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1657), 0, "", 4, "Roupas de viajante", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1657), 2.0, 2.0 },
                    { new Guid("dd06f284-c65f-41b6-bfc9-fbb07685e91b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1786), 0, "", 4, "Ferramentas de Cartógrafo", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1786), 15.0, 3.0 },
                    { new Guid("dd5d697f-6f9d-4d34-9f57-8a5074eb4c01"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1670), 0, "", 4, "Relicário", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1670), 5.0, 1.0 },
                    { new Guid("dec26fb9-2161-4c83-8ec5-10762a91542b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1915), 0, "", 4, "Banquete (por pessoa)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1915), 10.0, 0.0 },
                    { new Guid("e0b1fffb-2063-4e03-b03b-947f137c3396"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1660), 0, "", 4, "Roupas finas", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1660), 15.0, 3.0 },
                    { new Guid("e185f147-b0d0-4ca0-b6fc-cb43d46dfaf3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1936), 1, "", 4, "Vinho Comum (jarra)", 6, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1936), 2.0, 0.0 },
                    { new Guid("e2df6c3d-56f7-402e-9f03-50e53eceabdc"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1845), 1, "", 4, "Conjunto de Dados", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1845), 1.0, 0.0 },
                    { new Guid("e3e006cb-ba94-4cea-b553-75555897017c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1630), 0, "", 4, "Pá", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1630), 2.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e3f54ec8-3ebf-43b1-8e83-30f2b995ecee"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1428), 2, 1, "Armas Simples à Distância", 1, 4, 0, "Dardo", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1428), 5.0, 0.10000000000000001 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e64e5696-547c-40c7-a9e6-a622f68b3d02"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1529), 0, "Uma aljava pode guardar até 20 flechas.", 4, "Aljava", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1529), 1.0, 0.5 },
                    { new Guid("e6ac6644-8f6f-43af-a3f4-fd45a44a3e30"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1586), 0, "", 4, "Varinha de teixo", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1586), 10.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e732c93f-d8ec-40dd-9d0c-f6d57d0b1ae1"), 12, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(983), 0, "Armadura bruta consistindo de peles grossas. É comumente usada por tribos bárbaras, humanoides malignos e outros povos que não têm acesso às ferramentas e materiais necessários para criar uma armadura melhor.", 1, 2, 0, 1, "Gibão de Peles", false, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(983), 10.0, 6.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e7ec844d-a59b-4fed-b798-1914513f09e5"), 2, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1758), 0, "Um personagem que beber o líquido\r\nvermelho mágico deste frasco recupera 2d4+2 pontos de\r\nvida. Beber ou administrar uma poção exige uma ação.", 4, 2, 0, 2, "Poção de Cura", 2, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1758), 50.0, 0.25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e97f49aa-7ecf-416b-92ee-02dee6257374"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1436), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 4, 0, "Chicote", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1436), 2.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("eb51cf51-a9f5-48d2-89d6-e145cc69a58c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1809), 0, "", 4, "Ferramentas de Sapateiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1809), 5.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("eb87e2db-ae52-46fe-b785-d7f3a42b99f2"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1468), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Tridente", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1468), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("ef1036f4-6d95-49f0-9fdd-4da3803bbecb"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1646), 0, "Esse estojo \r\ncilíndrico de couro pode armazenar até 10 folhas de papel \r\nenroladas ou 5 folhas de pergaminhos enroladas.", 4, "Porta mapas ou pergaminhos", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1646), 1.0, 0.5 },
                    { new Guid("ef30fc71-7f03-4afd-bc2b-8615354b6f6c"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1673), 0, "", 4, "Sino", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1673), 1.0, 0.0 },
                    { new Guid("ef893b83-e903-4183-8f62-4b0ca0ee621e"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1643), 0, "", 4, "Picareta de minerador", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1643), 2.0, 5.0 },
                    { new Guid("f0965bc1-eb90-4d75-973b-826cd09adc94"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1894), 0, "Inclui uma mochila, um saco de\r\ndormir, um kit de refeição, uma caixa de fogo, 10 tochas, 10 dias\r\nde rações e um cantil. O kit também tem 15 metros de corda de\r\ncânhamo amarrada ao lado dele.", 4, "Pacote de Explorador", 5, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1894), 10.0, 0.0 },
                    { new Guid("f144c7a0-463b-4fef-b1d3-b9a7d7dfbf1b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1787), 0, "", 4, "Ferramentas de Costureiro", 3, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1787), 1.0, 2.5 },
                    { new Guid("f2a63379-4156-42e4-9b3f-b851687cd77a"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1578), 0, "", 4, "Orbe", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1578), 20.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f330c341-bf55-4542-9079-288701e603fc"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1429), 1, 2, "Armas Simples à Distância", 1, 4, 0, "Funda", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1429), 1.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f41ecce9-8852-475e-a8a4-db6b285da144"), 15, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1007), 0, "Composta de placas de metal moldadas que cobrem a maior parte do corpo. Ela não inclui proteção para as pernas além de caneleiras fixadas com tiras de couro.", 1, 2, 0, 1, "Meia-Armadura", true, 1, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1007), 750.0, 20.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f7deea2f-5acc-4e80-a22a-f98a49c586bb"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1478), 0, 1, "Armas Marciais à Distância", 1, 1, 0, "Zarabatana", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1478), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("f85f4ee6-f7e6-4c78-8e75-692b92ccce90"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1828), 0, "", 4, "Lira", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1828), 30.0, 1.0 },
                    { new Guid("fa099dfb-f1de-491c-a3ff-ae7bef3edda3"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1640), 0, "", 4, "Perfume (frasco)", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1640), 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("fc0f933b-6eda-40b1-b9c6-085d6c35851b"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1440), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Espada Longa", 0, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1440), 15.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("fd608bb1-6e85-4556-9c35-63ee89495cd0"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1548), 1, "Esse pequeno recipiente detém uma \r\npederneira, isqueiro e um pavio (um pano geralmente \r\nseco embebido em óleo) usado para acender uma fogueira. \r\nUsá-lo para acender uma tocha – ou qualquer outra coisa \r\nexposta a um combustível abundante – leva uma ação. \r\nAcender qualquer outro fogo leva 1 minuto.", 4, "Caixa de Fogo", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1548), 5.0, 0.5 },
                    { new Guid("fe28e8b5-164e-4117-909a-1cfe72cc0254"), new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1847), 0, "", 4, "Jogo dos Três Dragões", 4, new DateTime(2024, 6, 7, 12, 31, 32, 758, DateTimeKind.Local).AddTicks(1847), 5.0, 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundDataModelItemDataModel_ItemsId",
                table: "BackgroundDataModelItemDataModel",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Backpacks_CharacterId",
                table: "Backpacks",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbilityScoreDataModel_AbilityScoreId",
                table: "CharacterAbilityScoreDataModel",
                column: "AbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbilityScoreDataModel_CharacterId",
                table: "CharacterAbilityScoreDataModel",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItems_BackPackId",
                table: "CharacterItems",
                column: "BackPackId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItems_ItemId",
                table: "CharacterItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BackgroundId",
                table: "Characters",
                column: "BackgroundId");

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
                name: "CharacterItems");

            migrationBuilder.DropTable(
                name: "FeatureDataModelRaceDataModel");

            migrationBuilder.DropTable(
                name: "RaceAbilityScoreDataModel");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Backpacks");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "AbilityScoreValueObject");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Backgrounds");

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
