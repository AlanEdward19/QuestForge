using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestForge.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class itemTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bonus",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DamageType",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dice",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiceCount",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Effect",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemType",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeaponDataModel_Dice",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeaponDataModel_DiceCount",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("0277e7c4-4e7d-4d30-a5a1-f7df6afba5dd"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6767), 0, 1, "Armas Marciais à Distância", 1, 6, 0, "Besta de Mão", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6767), 75.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("03427064-a406-4fa9-a313-33347c60d562"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7019), 0, "", 4, "Varinha", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7019), 10.0, 0.5 },
                    { new Guid("03c22c88-602c-425f-a0ff-6fb8ea847e45"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7078), 1, "Consistem em alimentos desidratados adequados para viagens longas, \r\nincluindo carne seca, frutas secas, bolachas e nozes. ", 4, "Rações de viagem (1 dia)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7078), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("04138807-bbcd-439a-8ed9-e7ebba2fe2de"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6760), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Martelo de Guerra", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6760), 15.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("078ab8de-d826-4210-b3df-642ff1fd4723"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6936), 0, " Você pode usar um aríete portátil \r\npara quebrar portas. Ao fazer isso, você ganha um bônus \r\nde +4 no teste de Força. Outra criatura pode ajudá-lo a \r\nusar o aríete, o que concede vantagem no teste.", 4, "Ariete portátil", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6936), 4.0, 17.5 },
                    { new Guid("08e2ddf2-8433-4990-bf55-ec78ce20e773"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7099), 0, "", 4, "Sino", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7099), 1.0, 0.0 },
                    { new Guid("09a168e4-42f4-43ed-83e2-76ae0f82da06"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7083), 1, "", 4, "Roupas comuns", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7083), 5.0, 1.5 },
                    { new Guid("09b5bfe3-ec49-4537-b4fe-499b5cdaee52"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6943), 0, "", 4, "Barril", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6943), 2.0, 35.0 },
                    { new Guid("0b51c277-cdc8-498d-87c8-1684b8a92234"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6947), 0, "Trata-se de uma pequena \r\nbolsa de couro à prova d'água que pode ser fixada em um \r\ncinto. Ela possui compartimentos para armazenar todos \r\nos componentes materiais e outros itens especiais que \r\nvocê precisa para lançar suas magias, exceto os \r\ncomponentes que possuem um custo específico (conforme \r\nindicado na descrição da magia).", 4, "Bolsa de componentes", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6947), 25.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("0cc05728-c463-4f3e-b94f-f71cae899ef7"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6649), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 8, 0, "Clava Grande", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6649), 2.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("0f0f8e6f-1118-42d9-82e4-64dc745b603e"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7073), 2, "", 4, "Piton", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7073), 5.0, 0.0 },
                    { new Guid("0f60878e-6da1-4950-b207-6c7059b7d387"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6928), 0, "Uma bolsa de pano ou couro que pode \r\narmazenar até 20 munições de funda ou 50 munições de \r\nzarabatana, entre outras coisas. Para armazenar \r\ncomponentes de magia, veja bolsa de componentes, \r\ntambém descrita nessa seção.", 4, "Algibeira", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6928), 5.0, 0.5 },
                    { new Guid("123268ae-b0a6-4fce-9351-7b3f16928b07"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6959), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de seda (15 metros)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6959), 10.0, 2.5 },
                    { new Guid("12aa7328-fed0-469c-b294-49bf46766fdb"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7071), 0, "", 4, "Picareta de minerador", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7071), 2.0, 5.0 },
                    { new Guid("19cf59c6-b808-49ad-8fe7-f80629d5a550"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7092), 0, "", 4, "Amuleto", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7092), 5.0, 0.5 },
                    { new Guid("1a8cf1b2-c706-4f32-a6fc-6727f5a9e604"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7076), 0, "", 4, "Pregos de ferro (10)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7076), 1.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("1e894765-6905-42d7-a2e6-b3838654db62"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6727), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Porrete", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6727), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("21c5dac3-22cf-4cab-b951-41c2a7abdcde"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6929), 0, "Uma aljava pode guardar até 20 flechas.", 4, "Aljava", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6929), 1.0, 0.5 },
                    { new Guid("2543fb3e-1b2e-45eb-bdce-15c260c30414"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7018), 0, "", 4, "Orbe", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7018), 20.0, 1.5 },
                    { new Guid("28499fc7-e1f0-4546-863d-6c72f068f02a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7030), 2, "", 4, "Giz (1 peça)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7030), 1.0, 0.0 },
                    { new Guid("2b88259a-2c6d-45a0-a474-1065b1cfd267"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7060), 0, "", 4, "Pá", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7060), 2.0, 2.5 },
                    { new Guid("2db7575e-c44c-4b35-978a-529e9b1f603a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6939), 0, "", 4, "Arpéu", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6939), 2.0, 2.0 },
                    { new Guid("2e108f9f-1dfa-4c3c-bbe5-49078a0838c9"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7039), 0, " Uma lanterna coberta lança luz \r\nplena em um raio de 9 metros e penumbra por mais 9 \r\nmetros. Uma vez acesa, ela queima por 6 horas usando \r\num frasco de óleo (500 ml). Usando uma ação, você pode \r\nabaixar a cobertura, reduzindo a claridade para \r\npenumbra em um raio de 1,5 metro.", 4, "Lanterna coberta", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7039), 5.0, 1.0 },
                    { new Guid("2fedbc25-2ea6-4b16-a04e-7b481d4b8253"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7075), 0, "Esse estojo de madeira pode \r\narmazenar até 20 virotes de besta.", 4, "Porta virotes", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7075), 1.0, 0.5 },
                    { new Guid("301095a3-518f-4248-a695-934458a43a2d"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7065), 0, " Usar um pé de cabra concede vantagem \r\nnos testes de Força onde uma alavanca possa ser \r\naplicada.", 4, "Pé de cabra", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7065), 2.0, 2.5 },
                    { new Guid("3172374e-deb6-4690-b098-63f5fab0a40a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7068), 1, "", 4, "Pergaminho (uma folha)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7068), 1.0, 0.0 },
                    { new Guid("32e09c09-f3c6-49b9-9ac0-4c88d2e20f5d"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6946), 0, "", 4, "Baú", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6946), 5.0, 12.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("344f7e60-5049-4722-9bc4-a55d4efc443e"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6738), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Cimitarra", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6738), 25.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("377fb3b3-b8da-448d-9150-9a45ac997889"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7027), 2, "", 4, "Frasco", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7027), 2.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3e06c525-3bad-4901-84fd-59d159b6f18d"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6625), 0, 1, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Adaga", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6625), 2.0, 0.5 },
                    { new Guid("3e3a7cd1-4fcf-45e3-932e-3a25f0652088"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6763), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Rapieira", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6763), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3f1f72fa-4b87-46ea-b283-0140b8389f25"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7057), 1, " Geralmente vem em um frasco de argila que \r\ncontém 500 ml. Usando uma ação, você pode espirrar o \r\nóleo desse frasco em uma criatura a até 1,5 metro de você\r\nou arremessar a até 6 metros, quebrando-o com o \r\nimpacto. Você deve realizar um ataque à distância contra \r\numa criatura ou objeto, tratando o óleo como uma arma \r\nimprovisada. Com um sucesso, o alvo é coberto de óleo. Se \r\no alvo sofrer qualquer dano flamejante antes do óleo secar\r\n (depois de 1 minuto), a criatura sofre 5 de dano \r\nflamejante adicional pela queima do óleo. Você também \r\npode derramar um frasco de óleo no chão para cobrir uma \r\nárea de um quadrado de 1,5 metro de lado, desde que a \r\nsuperfície esteja nivelada. Se aceso, o óleo queima por 2 \r\nrodadas e causa 5 de dano flamejante a qualquer criatura \r\nque entrar na área ou terminar seu turno dentro da área. \r\nUma criatura pode sofrer esse dano apenas uma vez por \r\nturno. ", 4, "Óleo (frasco)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7057), 1.0, 0.5 },
                    { new Guid("41f7c8de-47aa-4e34-89f6-70b5cb366a0b"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7045), 0, "", 4, "Manto", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7045), 1.0, 2.0 },
                    { new Guid("42630c5a-4ad9-4eac-8397-1e3901636c47"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6962), 1, "", 4, "Escada (3 metros)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6962), 1.0, 12.5 },
                    { new Guid("43c56138-781c-4ec3-968a-57656ff436ad"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7096), 0, "", 4, "Relicário", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7096), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("47a6f006-530b-4854-bad2-b2c5c1ccfd1a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6638), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Bordão", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6638), 2.0, 2.0 },
                    { new Guid("47c01a6d-1d8c-4a0e-89ba-438db0944fa5"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6741), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Espada Curta", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6741), 10.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4e45df1b-db2f-4d8d-85dd-c810c79eaa5d"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7020), 0, "", 4, "Cajado de madeira", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7020), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4ea520ae-fc15-44a2-a598-194eeddab463"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6636), 1, 1, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Azagaia", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6636), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4eec8a7f-d305-40de-b279-adf5ba7945d7"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6952), 1, "", 4, "Cantil", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6952), 2.0, 2.5 },
                    { new Guid("4fac3eef-7cc0-4c42-9142-84261e009313"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7026), 0, "", 4, "Varinha de teixo", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7026), 10.0, 0.5 },
                    { new Guid("503bd998-0e16-47a3-a4b9-d4ec114f9daa"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6969), 0, "A fechadura vem com chave. Sem a \r\nchave, uma criatura proficiente com ferramentas de \r\nladrão pode abrir a fechadura com um sucesso em um \r\nteste de Destreza CD 15. O Mestre pode decidir que \r\nfechaduras melhores estão disponíveis por preços mais \r\nelevados.", 4, "Fechadura", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6969), 10.0, 0.5 },
                    { new Guid("52277a30-12a7-4894-b1be-a33056af6d1f"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7086), 0, "", 4, "Roupas de entretenimento", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7086), 5.0, 2.0 },
                    { new Guid("5287e13e-0d8c-4928-bf71-98e050f35bbd"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7049), 0, "", 4, "Martelo", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7049), 1.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("52e9189b-e3b5-4488-9e6d-e1c2e37b958f"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6744), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Espada Longa", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6744), 15.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("53a965d4-b688-43bd-8aab-377e52d6c6e7"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6927), 0, " Essas algemas de metal podem prender \r\numa criatura Pequena ou Média. Escapar das algemas \r\nexige sucesso em um teste de Destreza CD 20. Quebrá-las \r\nexige um teste de Força CD 20 bem sucedido. Cada \r\nconjunto de algemas vem com uma chave. Sem a chave, \r\numa criatura proficiente com ferramentas de ladrão pode \r\nabrir a fechadura das algemas com um sucesso em um \r\nteste de Destreza CD 15. As algemas têm 15 pontos de \r\nvida. ", 4, "Algemas", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6927), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("547cee8c-8cdf-4a96-a088-6679e3ea93f6"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6772), 0, 1, "Armas Marciais à Distância", 1, 1, 0, "Zarabatana", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6772), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("54942d63-f123-4e98-8ff7-dae973062027"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7095), 0, "", 4, "Emblema", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7095), 5.0, 0.0 },
                    { new Guid("556098ad-cc7c-4886-b6a2-e3c3bfa9318e"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6941), 2, "", 4, "Balde", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6941), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("55771b6c-cc4b-4dc4-a747-f4e6dac7badd"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6730), 0, 1, "Armas Simples à Distância", 1, 8, 0, "Besta Leve", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6730), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("55bf7aec-b014-498c-b4cb-b8e247bbc753"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7074), 0, " Esse estojo \r\ncilíndrico de couro pode armazenar até 10 folhas de papel \r\nenroladas ou 5 folhas de pergaminhos enroladas.", 4, "Porta mapas ou pergaminhos", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7074), 1.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("58da890f-626b-43a6-b4c6-2b5c58e7d4f3"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6757), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Mangual", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6757), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("58e1435c-d18a-4b7f-9958-b92db76d17ba"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7100), 0, "Um abrigo simples e portátil que acomoda \r\nduas pessoas. ", 4, "Tenda para duas pessoas", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7100), 2.0, 10.0 },
                    { new Guid("5db83178-8ed2-45a7-b90e-07e510e745ed"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7079), 0, "", 4, "Robes", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7079), 1.0, 2.0 },
                    { new Guid("5f146e18-1a09-4b5a-abe7-3f033545769a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7084), 0, "", 4, "Roupas de viajante", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7084), 2.0, 2.0 },
                    { new Guid("5fde0164-3e77-4994-a8d8-586d5ac06e7c"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6934), 0, "Uma criatura que beber o líquido desse \r\nvidro tem vantagem em testes de resistência contra \r\nvenenos por 1 hora. O antídoto não confere nenhum \r\nbenefício para mortos-vivos ou constructos. ", 4, "Antídoto (vidro)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6934), 50.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6045ff74-c0ad-45e4-a3c6-1f3da4d65c44"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6764), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Tridente", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6764), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("64b1bd6d-90d2-41ab-a73a-473776ebc182"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7052), 2, "", 4, "Balas de Funda (20)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7052), 4.0, 0.75 },
                    { new Guid("64e7441b-aba6-45ea-b7a7-1fa31d97266a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7025), 0, "", 4, "Totem", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7025), 1.0, 0.0 },
                    { new Guid("6eada44e-9175-4141-8ae3-1b89e2e7b14d"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7053), 0, "", 4, "Flechas (20)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7053), 1.0, 0.5 },
                    { new Guid("6fd256c2-c90c-4786-9740-c5f9b63052e3"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6961), 0, "Este kit inclui uma vara \r\nde pesca de madeira, linha de seda, boias de cortiça, \r\nanzóis de aço, chumbadas, iscas e redes de pesca.", 4, "Equipamento de pescaria", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6961), 1.0, 2.0 },
                    { new Guid("6ff389d6-e845-44f0-8d11-122e753b0efc"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6953), 1, "", 4, "Cesto", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6953), 4.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("72a7e5eb-90dc-4ac5-b8a5-a18b35bfba20"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6736), 1, 2, "Armas Simples à Distância", 1, 4, 0, "Funda", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6736), 1.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7590d063-5231-489f-83eb-0fc4e4733471"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7063), 1, "", 4, "Parafina", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7063), 5.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7aacd55e-9ea1-4b21-840e-b7f33b1012d6"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6751), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Maça Estrela", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6751), 15.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7d383c3a-ae6a-4d0d-8ad2-be752b65bf74"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7021), 0, "", 4, "Ramo de visco", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7021), 1.0, 0.0 },
                    { new Guid("842ba35a-a35c-4e85-b446-12a0db34c272"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7080), 0, "Um conjunto de roldanas com um \r\ncabo entre elas e um gancho para fixar aos objetos, a \r\nroldana e polia permitem içar até quatro vezes o peso que \r\nvocê ergueria normalmente.", 4, "Roldana e polia", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7080), 1.0, 2.5 },
                    { new Guid("844e85ab-c4e8-44e1-9ac4-3d5aca11e9a1"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6964), 0, "Usando uma ação, você pode \r\ndespejar essas minúsculas esferas de metal para cobrir a \r\nárea de um quadrado de 3 metros de lado. A criatura que \r\nse mover dentro da área deve ser bem sucedida em um \r\nteste de resistência de Destreza CD 10 para não cair no \r\nchão. Uma criatura que mover pela área usando metade \r\ndo seu deslocamento não precisa fazer o teste de \r\nresistência.", 4, "Esferas (sacola com 1.000)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6964), 1.0, 1.0 },
                    { new Guid("85c0d8d7-6f46-497a-97b5-6c5ecc96e95c"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7048), 0, "", 4, "Marreta", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7048), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("868d6b42-a2f9-4da3-a22f-aac1bd8a856d"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6768), 0, 1, "Armas Marciais à Distância", 1, 10, 0, "Besta Pesada", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6768), 50.0, 4.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("87643a7e-3141-4a92-8ffa-8beb73628063"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6948), 1, "Esse pequeno recipiente detém uma \r\npederneira, isqueiro e um pavio (um pano geralmente \r\nseco embebido em óleo) usado para acender uma fogueira. \r\nUsá-lo para acender uma tocha – ou qualquer outra coisa \r\nexposta a um combustível abundante – leva uma ação. \r\nAcender qualquer outro fogo leva 1 minuto.", 4, "Caixa de Fogo", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6948), 5.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8892a4f9-f4c1-418e-ad76-cb65cf2bf9dd"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6753), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Machado Grande", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6753), 30.0, 3.5 },
                    { new Guid("88fcabe1-d0e3-4550-a925-58b403eee5b3"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6725), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Machadinha", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6725), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("8e2f1e45-bd6d-4308-a3dd-e04b571fdef9"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7017), 0, "", 4, "Cristal", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7017), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("901d5acc-15b6-492e-af6d-8211611d73d6"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6747), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Glaive", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6747), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9387e58c-3fec-4dec-8b37-0df211ad5a79"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6923), 0, "", 4, "Ábaco", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6923), 2.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9648154a-658a-433a-93f1-e6bc9c8ab347"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6765), 0, 1, "Armas Marciais à Distância", 1, 8, 0, "Arco Longo", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6765), 50.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("99184c97-4462-46f4-9faa-72aabded05dd"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6925), 0, "Usando uma ação, você pode espalhar o \r\nconteúdo desse frasco em uma criatura a até 1,5 metro de \r\nvocê ou arremessar a até 6 metros, quebrando o frasco \r\ncom o impacto. Em ambos os casos, você deve realizar um \r\nataque à distância contra uma criatura alvo, tratando a \r\nágua benta como uma arma improvisada. Se o alvo for um \r\ncorruptor ou morto-vivo, ele sofre 2d6 de dano radiante. ", 4, "Água benta (frasco)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6925), 25.0, 0.5 },
                    { new Guid("9aff86ea-1aad-409c-b89f-798c6620699a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6935), 0, "", 4, "Apito de advertência", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6935), 25.0, 0.5 },
                    { new Guid("9c16dbd2-67cb-42b9-8fdb-0588a93715bb"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7089), 2, "", 4, "Saco", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7089), 1.0, 0.25 },
                    { new Guid("9db4b50b-e65b-4ca2-8b38-2975a93e51f1"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6965), 0, "", 4, "Espelho de aço", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6965), 5.0, 0.25 },
                    { new Guid("9dd7b551-7ad8-4708-86cf-edfdb2cf3eb6"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7091), 0, "", 4, "Saco de dormir", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7091), 1.0, 3.5 },
                    { new Guid("9f62152c-abb3-4a03-a1e1-73a11db5602a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7054), 0, "", 4, "Virotes (20)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7054), 1.0, 0.75 },
                    { new Guid("a3fed847-e2f2-4a3c-a426-ce71d991a55a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6940), 0, "Trata-se de uma pequena \r\nbalança, pratos e um sortimento adequado de pesos de até \r\n1 kg. Com ela, você pode medir o peso exato de pequenos \r\nobjetos, como metais preciosos brutos ou bens comerciais, \r\npara ajudar a determinar seu valor.", 4, "Balança de mercador", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6940), 5.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a4ab09f9-060a-4da2-8fce-3c825869a8b9"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6729), 0, 1, "Armas Simples à Distância", 1, 6, 0, "Arco Curto", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6729), 25.0, 1.0 },
                    { new Guid("a7f9be70-245b-43e4-8b44-e4ce93c4e14e"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6726), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Martelo Leve", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6726), 2.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a83a7f9f-5cfc-40df-90d9-ec7c1e4b9819"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7097), 0, "", 4, "Sinete", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7097), 5.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a84fe141-6213-4a6d-8aaf-2842d23af376"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6652), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Maça", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6652), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a9122f2c-89f2-4971-b56d-01cf5c5b8fde"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6930), 0, "", 4, "Ampulheta", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6930), 25.0, 0.5 },
                    { new Guid("a9eba1d1-e995-46ce-b888-afa84b26454e"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7067), 0, "", 4, "Perfume (frasco)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7067), 5.0, 0.0 },
                    { new Guid("ab9338f3-1402-4dbd-8087-44345091e71e"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6924), 0, "", 4, "Ácido (vidro)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6924), 25.0, 0.5 },
                    { new Guid("aca15e80-d193-49db-af80-f31cd0c5e225"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7087), 0, "", 4, "Roupas finas", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7087), 15.0, 3.0 },
                    { new Guid("adda4284-c4c9-44c9-b420-888c85699920"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6938), 0, "Quando você usa sua ação para \r\narmá-la, essa armadilha forma um anel de aço com \r\ndentes serrilhados. Eles se fecham quando uma criatura \r\npisa sobre uma placa de pressão no seu centro. A \r\narmadilha é fixada por uma pesada corrente em um \r\nobjeto fixo e imóvel, como uma árvore ou um cravo \r\nenterrado no chão. Uma criatura que pisar na placa de \r\npressão deve ser bem sucedida em um teste de resistência \r\nde Destreza CD 13 ou sofrerá 1d4 de dano perfurante e \r\npara de se mover. Daí em diante, até que a criatura se \r\nliberte da armadilha, seu movimento é limitado ao \r\ncomprimento da corrente (tipicamente 1 metro de \r\ncomprimento). A criatura presa pode usar sua ação para \r\nfazer um teste de Força CD 13 e se libertar, ou outra \r\ncriatura no alcance pode fazer o teste para libertá-la. \r\nCada fracasso no teste causa 1 de dano perfurante à \r\ncriatura presa.", 4, "Armadilha de caça", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6938), 5.0, 12.5 },
                    { new Guid("adda9bb7-9d48-4275-91c8-cf7900267954"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6951), 2, "", 4, "Caneta tinteiro", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6951), 2.0, 0.0 },
                    { new Guid("af91f9a5-a1bb-4972-858a-4fa71a0bc919"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7055), 0, "", 4, "Zarabatana (50)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7055), 1.0, 0.5 },
                    { new Guid("b2bab125-fd4e-41b0-8f21-4529482b1355"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7107), 2, "Por uma hora, a vela emana luz plena em um \r\nraio de 1,5 metro e penumbra por mais 1,5 metro.", 4, "Vela", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7107), 1.0, 0.0 },
                    { new Guid("b66dd1cc-1aff-45c4-81b2-4cf5362993b8"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7088), 2, "", 4, "Sabão", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7088), 2.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b94a2a43-11b1-46b8-95a3-eaf0bc4bed75"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6748), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 12, 0, "Lança de Montaria", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6748), 10.0, 3.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b9fb1940-7b57-4c32-98aa-ac78fa8efe81"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7062), 1, "", 4, "Papel (uma folha)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7062), 2.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("ba6d3503-c2b7-4f0b-b3eb-9bb62f7914b0"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6754), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Machado de Batalha", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6754), 10.0, 2.0 },
                    { new Guid("bdb49f56-c9f1-42cc-9bea-dfcf17eb55f4"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6769), 0, 1, "Armas Marciais à Distância", 0, 1, 0, "Rede", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6769), 1.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c1b5b000-845c-4746-b6eb-f31fa092c866"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7033), 0, " Um kit de escalada inclui pítons \r\nespeciais, botas com solas pontiagudas, luvas e um cinto. \r\nVocê pode usar o kit de escalada como uma ação para \r\n\"ancorar-se\". Quando faz isso, você não pode cair mais de \r\n7,5 metros a partir do ponto onde se ancorou, e não pode \r\nsubir mais de 7,5 metros de distância desse ponto, sem \r\ndesfazer a âncora.", 4, "Kit de escalada", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7033), 25.0, 6.0 },
                    { new Guid("c3736c19-648f-408d-9d16-a6c546403ce1"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7031), 0, "Essencial para os magos, um grimório é \r\num volume encadernado em couro com 100 páginas de \r\npergaminhos em branco, adequado para armazenar \r\nmagias.", 4, "Grimório", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7031), 50.0, 1.5 },
                    { new Guid("c4168258-c3e0-4aae-bfe4-37145809834a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7015), 0, "", 4, "Cajado", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7015), 5.0, 2.0 },
                    { new Guid("c70541c9-9107-4871-a813-c7e91b5bc161"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7101), 2, "A tocha queima por 1 hora, fornecendo luz \r\nplena em um raio de 6 metros e penumbra por mais 6 \r\nmetros. Se você realizar um ataque corpo-a-corpo com \r\numa tocha acesa e acertar, causa 1 de dano flamejante.", 4, "Tocha", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7101), 1.0, 0.5 },
                    { new Guid("c7107869-8deb-4991-97b7-3bf38e59989e"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7102), 0, "", 4, "Tinta (frasco de 30ml)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7102), 10.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c9510253-688b-4641-ac80-f10fd8f27cb4"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6742), 0, 0, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Espada Grande", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6742), 50.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("ca83d4fb-e172-481f-a4ea-c559f6e48d59"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7042), 0, " Um livro pode conter poesia, relatos históricos, \r\ninformações relativas a um campo particular de \r\nsabedoria, diagramas e notas sobre engenhocas gnômicas, \r\nou qualquer outra coisa que possa ser representada \r\nusando texto ou imagens. ", 4, "Livro", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7042), 25.0, 2.5 },
                    { new Guid("d09d7a78-652d-4bb9-aa69-55f5a87c632c"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6960), 0, "Uma corrente possui 10 pontos de vida e \r\npode ser arrebentada com um teste de Força CD 20 bem \r\nsucedido.", 4, "Corrente (3 metros)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6960), 5.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d13bdb5c-683a-475a-aa26-b428f17a0e68"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6737), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Alabarda", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6737), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d3febe8f-450e-41bf-a3cc-60e1c5669d2b"), 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7178), 0, "Você pode usar o veneno contido\r\nnesse vidro para cobrir a lâmina de uma arma cortante ou\r\nperfurante ou até três peças de munição. Aplicar o veneno\r\nleva uma ação. Uma criatura atingida pela arma ou\r\nmunição envenenada deve obter sucesso em um teste de\r\nresistência de Constituição CD 10 ou sofrerá 1d4 de dano\r\nde veneno. Uma vez aplicado, o veneno retém sua\r\npotência durante 1 minuto antes de secar.", 4, 1, 1, 2, "Veneno básico (frasco)", 2, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7178), 100.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d5ccd682-2e75-47e2-a878-06878d099a7e"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6966), 0, "Usando uma ação, você pode espalhar um \r\núnico saco de estrepes para cobrir a área de um quadrado \r\nde 1,5 metro de lado. Qualquer criatura que entrar na \r\nárea deve ser bem sucedida em um teste de resistência de \r\nDestreza CD 15. Se falhar, para de se mover e sofre 1 de \r\ndano perfurante. Até que a criatura recupere pelo menos \r\n1 ponto de vida, seu deslocamento de caminhada é \r\nreduzido em 3 metros. Uma criatura que se mover pela \r\nárea usando metade do seu deslocamento não precisa \r\nfazer o teste de resistência.", 4, "Estrepes (bolsa com 20)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6966), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d638a500-d88f-4add-9d0c-b57693931d0c"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6755), 0, 2, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Malho", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6755), 10.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d8e3eb44-fbb9-4cc5-9cb3-b9d0c3ff2601"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6954), 1, "", 4, "Cobertor de inverno", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6954), 5.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ddc3fa5a-fd9c-4243-b383-720ebfa931af"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6734), 2, 1, "Armas Simples à Distância", 1, 4, 0, "Dardo", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6734), 5.0, 0.10000000000000001 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e097406a-e0d8-4ca7-9e63-2e7470b5372f"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7028), 0, "", 4, "Garrafa de vidro", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7028), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e0e10f48-fa6c-40ca-b3fd-b3a0d30575d9"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6761), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Picareta de Guerra", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6761), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e1be4132-5e85-4a60-8af0-6adedab5ed7c"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6949), 2, "", 4, "Caneca", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6949), 2.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e2796930-07a5-4115-b8ed-db949e18b3c6"), 2, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7175), 0, "Um personagem que beber o líquido\r\nvermelho mágico deste frasco recupera 2d4+2 pontos de\r\nvida. Beber ou administrar uma poção exige uma ação.", 4, 2, 0, 2, "Poção de Cura", 2, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7175), 50.0, 0.25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e3d27a21-43b2-488a-9f0a-b75e0027e159"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7032), 2, "", 4, "Jarra", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7032), 4.0, 2.0 },
                    { new Guid("e4430076-4ef9-4bb5-a5c4-39af7709882a"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7050), 0, "", 4, "Mochila", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7050), 2.0, 2.5 },
                    { new Guid("e8f7c48b-f347-4f90-805c-9c6f2161b0f9"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7038), 1, "Uma lâmpada lança luz plena em um raio \r\nde 4,5 metros e penumbra por mais 9 metros. Uma vez \r\nacesa, a lâmpada queima por 6 horas usando um frasco de \r\nóleo (500 ml).", 4, "Lâmpada", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7038), 5.0, 0.5 },
                    { new Guid("ea32a029-8ae2-4d9f-9914-1f24abeed478"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7041), 0, " Essa lente permite ver pequenos \r\nobjetos mais de perto. Ela também é útil como um \r\nsubstituto da pederneira e isqueiro para acender fogo. \r\nUsar uma lupa para acender fogo necessita de luz tão \r\nbrilhante como a luz do sol para focar, um pavio e cerca \r\nde 5 minutos. Uma lente de aumento concede vantagem \r\nem qualquer teste de habilidade feito para avaliar ou \r\ninspecionar um item que é pequeno ou muito detalhado.", 4, "Lente de aumento", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7041), 100.0, 0.0 },
                    { new Guid("ec6e533d-92c7-4a15-aac8-0acb10e81de9"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7061), 0, "", 4, "Panela de ferro", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7061), 2.0, 5.0 },
                    { new Guid("edb33b94-0478-44ae-bf5b-5a11839ef9c6"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6970), 0, "", 4, "Bastão", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6970), 10.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ede8bd5b-f628-446f-a84b-164da767b736"), 2, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7222), 0, " Esse líquido pegajoso e adesivo\r\ninflama em contado com o ar. Usando uma ação, você\r\npode arremessar esse frasco a até 6 metros de distância,\r\nquebrando-o com o impacto. Você deve realizar um ataque\r\nà distância contra uma criatura ou objeto, tratando o fogo\r\nalquímico como uma arma improvisada. Em um sucesso,\r\no alvo sofre 1d4 de dano de fogo no início de cada um de\r\n seus turnos. Uma criatura pode terminar esse dano\r\nusando sua ação e fazendo um teste de Destreza CD 10\r\npara apagar as chamas.", 4, 2, 0, 2, "Fogo alquímico (frasco)", 2, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7222), 50.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("f2464f91-47bc-4a4d-ad79-994e639631c7"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6957), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de cânhamo (15 metros)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6957), 1.0, 5.0 },
                    { new Guid("f48775be-d3c7-48a1-8946-33d70a2d11c8"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7040), 0, " Uma lanterna furta-fogo \r\nlança luz plena em um cone de 18 metros e penumbra por \r\nmais 18 metros. Uma vez acesa, ela queima por 6 horas \r\nusando um frasco de óleo (500 ml).", 4, "Lanterna furta-fogo", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7040), 10.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("f6db1648-7e85-4bff-8884-fed1230eaf5c"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6750), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Lança Longa", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6750), 5.0, 4.0 },
                    { new Guid("f92ac1e9-a142-4700-aae5-4d88026627af"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6740), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 4, 0, "Chicote", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6740), 2.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("fb4aeed9-4f6d-4468-953a-41dd1df79c55"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7036), 0, " Esse kit é uma bolsa de \r\ncouro contendo ataduras, pomadas e talas. O kit possui \r\nmaterial suficiente para dez usos. Usando uma ação, você \r\npode gastar um uso do kit para estabilizar uma criatura \r\nque tenha 0 pontos de vida, sem a necessidade de realizar \r\num teste de Sabedoria (Medicina).", 4, "Kit de primeiros-socorros", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7036), 5.0, 1.5 },
                    { new Guid("fb94729c-9410-4b39-82f8-7970edb44809"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7044), 0, "Objetos vistos através de uma luneta são \r\nampliados até o dobro do seu tamanho.", 4, "Luneta", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7044), 1000.0, 0.5 },
                    { new Guid("fb987d8f-2457-42e9-b8e1-e0b9b60826e3"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7104), 2, "", 4, "Vara (3 metros)", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7104), 5.0, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("fd0aa2e7-a433-4a5d-907c-1cfe0b741767"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6650), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Foice Curta", 0, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(6650), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("fdb716b5-9ce1-4587-9096-69d3c8dd31e7"), new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7066), 2, "", 4, "Pedra de amolar", 4, new DateTime(2024, 6, 1, 17, 38, 15, 242, DateTimeKind.Local).AddTicks(7066), 1.0, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0277e7c4-4e7d-4d30-a5a1-f7df6afba5dd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("03427064-a406-4fa9-a313-33347c60d562"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("03c22c88-602c-425f-a0ff-6fb8ea847e45"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("04138807-bbcd-439a-8ed9-e7ebba2fe2de"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("078ab8de-d826-4210-b3df-642ff1fd4723"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("08e2ddf2-8433-4990-bf55-ec78ce20e773"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("09a168e4-42f4-43ed-83e2-76ae0f82da06"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("09b5bfe3-ec49-4537-b4fe-499b5cdaee52"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0b51c277-cdc8-498d-87c8-1684b8a92234"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0cc05728-c463-4f3e-b94f-f71cae899ef7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0f0f8e6f-1118-42d9-82e4-64dc745b603e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0f60878e-6da1-4950-b207-6c7059b7d387"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("123268ae-b0a6-4fce-9351-7b3f16928b07"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12aa7328-fed0-469c-b294-49bf46766fdb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19cf59c6-b808-49ad-8fe7-f80629d5a550"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1a8cf1b2-c706-4f32-a6fc-6727f5a9e604"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1e894765-6905-42d7-a2e6-b3838654db62"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21c5dac3-22cf-4cab-b951-41c2a7abdcde"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2543fb3e-1b2e-45eb-bdce-15c260c30414"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("28499fc7-e1f0-4546-863d-6c72f068f02a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2b88259a-2c6d-45a0-a474-1065b1cfd267"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2db7575e-c44c-4b35-978a-529e9b1f603a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2e108f9f-1dfa-4c3c-bbe5-49078a0838c9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2fedbc25-2ea6-4b16-a04e-7b481d4b8253"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("301095a3-518f-4248-a695-934458a43a2d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3172374e-deb6-4690-b098-63f5fab0a40a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("32e09c09-f3c6-49b9-9ac0-4c88d2e20f5d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("344f7e60-5049-4722-9bc4-a55d4efc443e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("377fb3b3-b8da-448d-9150-9a45ac997889"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3e06c525-3bad-4901-84fd-59d159b6f18d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3e3a7cd1-4fcf-45e3-932e-3a25f0652088"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3f1f72fa-4b87-46ea-b283-0140b8389f25"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("41f7c8de-47aa-4e34-89f6-70b5cb366a0b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("42630c5a-4ad9-4eac-8397-1e3901636c47"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("43c56138-781c-4ec3-968a-57656ff436ad"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("47a6f006-530b-4854-bad2-b2c5c1ccfd1a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("47c01a6d-1d8c-4a0e-89ba-438db0944fa5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4e45df1b-db2f-4d8d-85dd-c810c79eaa5d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4ea520ae-fc15-44a2-a598-194eeddab463"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4eec8a7f-d305-40de-b279-adf5ba7945d7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4fac3eef-7cc0-4c42-9142-84261e009313"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("503bd998-0e16-47a3-a4b9-d4ec114f9daa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("52277a30-12a7-4894-b1be-a33056af6d1f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5287e13e-0d8c-4928-bf71-98e050f35bbd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("52e9189b-e3b5-4488-9e6d-e1c2e37b958f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("53a965d4-b688-43bd-8aab-377e52d6c6e7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("547cee8c-8cdf-4a96-a088-6679e3ea93f6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("54942d63-f123-4e98-8ff7-dae973062027"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("556098ad-cc7c-4886-b6a2-e3c3bfa9318e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55771b6c-cc4b-4dc4-a747-f4e6dac7badd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55bf7aec-b014-498c-b4cb-b8e247bbc753"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("58da890f-626b-43a6-b4c6-2b5c58e7d4f3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("58e1435c-d18a-4b7f-9958-b92db76d17ba"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5db83178-8ed2-45a7-b90e-07e510e745ed"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5f146e18-1a09-4b5a-abe7-3f033545769a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5fde0164-3e77-4994-a8d8-586d5ac06e7c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6045ff74-c0ad-45e4-a3c6-1f3da4d65c44"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("64b1bd6d-90d2-41ab-a73a-473776ebc182"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("64e7441b-aba6-45ea-b7a7-1fa31d97266a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6eada44e-9175-4141-8ae3-1b89e2e7b14d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6fd256c2-c90c-4786-9740-c5f9b63052e3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6ff389d6-e845-44f0-8d11-122e753b0efc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("72a7e5eb-90dc-4ac5-b8a5-a18b35bfba20"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7590d063-5231-489f-83eb-0fc4e4733471"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7aacd55e-9ea1-4b21-840e-b7f33b1012d6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7d383c3a-ae6a-4d0d-8ad2-be752b65bf74"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("842ba35a-a35c-4e85-b446-12a0db34c272"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("844e85ab-c4e8-44e1-9ac4-3d5aca11e9a1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("85c0d8d7-6f46-497a-97b5-6c5ecc96e95c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("868d6b42-a2f9-4da3-a22f-aac1bd8a856d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("87643a7e-3141-4a92-8ffa-8beb73628063"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8892a4f9-f4c1-418e-ad76-cb65cf2bf9dd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("88fcabe1-d0e3-4550-a925-58b403eee5b3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8e2f1e45-bd6d-4308-a3dd-e04b571fdef9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("901d5acc-15b6-492e-af6d-8211611d73d6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9387e58c-3fec-4dec-8b37-0df211ad5a79"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9648154a-658a-433a-93f1-e6bc9c8ab347"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("99184c97-4462-46f4-9faa-72aabded05dd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9aff86ea-1aad-409c-b89f-798c6620699a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9c16dbd2-67cb-42b9-8fdb-0588a93715bb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9db4b50b-e65b-4ca2-8b38-2975a93e51f1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9dd7b551-7ad8-4708-86cf-edfdb2cf3eb6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9f62152c-abb3-4a03-a1e1-73a11db5602a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a3fed847-e2f2-4a3c-a426-ce71d991a55a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a4ab09f9-060a-4da2-8fce-3c825869a8b9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a7f9be70-245b-43e4-8b44-e4ce93c4e14e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a83a7f9f-5cfc-40df-90d9-ec7c1e4b9819"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a84fe141-6213-4a6d-8aaf-2842d23af376"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a9122f2c-89f2-4971-b56d-01cf5c5b8fde"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a9eba1d1-e995-46ce-b888-afa84b26454e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ab9338f3-1402-4dbd-8087-44345091e71e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aca15e80-d193-49db-af80-f31cd0c5e225"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("adda4284-c4c9-44c9-b420-888c85699920"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("adda9bb7-9d48-4275-91c8-cf7900267954"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("af91f9a5-a1bb-4972-858a-4fa71a0bc919"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b2bab125-fd4e-41b0-8f21-4529482b1355"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b66dd1cc-1aff-45c4-81b2-4cf5362993b8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b94a2a43-11b1-46b8-95a3-eaf0bc4bed75"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b9fb1940-7b57-4c32-98aa-ac78fa8efe81"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ba6d3503-c2b7-4f0b-b3eb-9bb62f7914b0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bdb49f56-c9f1-42cc-9bea-dfcf17eb55f4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c1b5b000-845c-4746-b6eb-f31fa092c866"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c3736c19-648f-408d-9d16-a6c546403ce1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c4168258-c3e0-4aae-bfe4-37145809834a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c70541c9-9107-4871-a813-c7e91b5bc161"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c7107869-8deb-4991-97b7-3bf38e59989e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c9510253-688b-4641-ac80-f10fd8f27cb4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ca83d4fb-e172-481f-a4ea-c559f6e48d59"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d09d7a78-652d-4bb9-aa69-55f5a87c632c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d13bdb5c-683a-475a-aa26-b428f17a0e68"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d3febe8f-450e-41bf-a3cc-60e1c5669d2b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d5ccd682-2e75-47e2-a878-06878d099a7e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d638a500-d88f-4add-9d0c-b57693931d0c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d8e3eb44-fbb9-4cc5-9cb3-b9d0c3ff2601"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ddc3fa5a-fd9c-4243-b383-720ebfa931af"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e097406a-e0d8-4ca7-9e63-2e7470b5372f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e0e10f48-fa6c-40ca-b3fd-b3a0d30575d9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e1be4132-5e85-4a60-8af0-6adedab5ed7c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e2796930-07a5-4115-b8ed-db949e18b3c6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e3d27a21-43b2-488a-9f0a-b75e0027e159"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e4430076-4ef9-4bb5-a5c4-39af7709882a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e8f7c48b-f347-4f90-805c-9c6f2161b0f9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ea32a029-8ae2-4d9f-9914-1f24abeed478"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ec6e533d-92c7-4a15-aac8-0acb10e81de9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("edb33b94-0478-44ae-bf5b-5a11839ef9c6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ede8bd5b-f628-446f-a84b-164da767b736"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f2464f91-47bc-4a4d-ad79-994e639631c7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f48775be-d3c7-48a1-8946-33d70a2d11c8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f6db1648-7e85-4bff-8884-fed1230eaf5c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f92ac1e9-a142-4700-aae5-4d88026627af"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fb4aeed9-4f6d-4468-953a-41dd1df79c55"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fb94729c-9410-4b39-82f8-7970edb44809"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fb987d8f-2457-42e9-b8e1-e0b9b60826e3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fd0aa2e7-a433-4a5d-907c-1cfe0b741767"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fdb716b5-9ce1-4587-9096-69d3c8dd31e7"));

            migrationBuilder.DropColumn(
                name: "Bonus",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DamageType",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Dice",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DiceCount",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Effect",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemType",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "WeaponDataModel_Dice",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "WeaponDataModel_DiceCount",
                table: "Items");
        }
    }
}
