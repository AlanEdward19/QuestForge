using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestForge.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class featuresToRaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RaceFeatureDataModel");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("00f6d778-7757-4991-acaa-859b30c2460c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("01882559-e5d6-40c3-937f-994a278a0b1e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("01959080-31b1-406c-a2d5-fd1a1e3fda4e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("03a1e722-9a09-484c-911c-2943edef9f88"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("046d99eb-fd88-41fe-8f6b-9b9c94594c50"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("055ffb45-b2d8-4fb1-bc6d-dc2f37b88549"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0602d824-00ff-4eea-aee0-07501bb6bdff"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("076bb1cb-042f-48af-b813-03fa40c96108"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0cc096b4-a03a-41ef-8758-12e4e2e49f68"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0d6b8b1b-ebd4-4655-934f-aee9d3016833"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0e20d4d9-aa3c-49b4-8944-bc62f60f6faa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10587427-a7a7-44a5-97fc-82d754e31ea0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12b874e5-c346-46ef-b560-be6d067a19ee"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("138f53fc-2f35-4834-9f01-6d5655f5f573"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14073eaf-95de-40e1-9d59-0d2584eb7254"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1460d49e-1cc7-4f24-89de-52cac95aef84"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14ed58a6-2121-4ea6-a100-52eb63dfb9a1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("175a3e70-f6fc-4c6b-afc4-f6848194bbe7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1e077453-02bb-49dd-9341-58bfd1293ec2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1e45ade7-76fc-4fec-9a3e-b3ed0def333b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1fa403ae-2f70-4b5d-bb70-f99317a07aa7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20f19250-8350-474b-9c32-c43f3e0f2ebb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2139b1ac-4bb6-473e-9a84-a87e87746a7f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("23eb83bd-4043-469c-8c2b-8b65e71e8dba"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("24ec348d-57c5-4c4d-9222-025218db0227"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("26ea1c28-1e34-4fe5-aafd-119f34c0fe89"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("274886fa-819d-4df0-b1bc-bfcaebe5ef8f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2a7ad63d-a0c0-42dc-b064-c37ae5bc8444"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2bc7580f-7559-452b-bd34-06ee1770be69"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2c2d65ad-1560-4b1e-9735-cd202adb5783"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2dc46ee2-5e0e-4f72-859d-a0c68c0007ad"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2ed7fa36-6d0d-4fa7-9724-18c17700e59c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31101347-8f19-4e8a-8acd-5e2c0dc8389d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("360ef6ee-6588-457c-94d0-d5c5aced0b77"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("36e21fa8-9e67-4862-a68b-44bb8454d627"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("37f9f959-61d3-4bc5-be8a-4a28b7e31b77"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3a24cac5-65dd-4ce4-bb83-2db037dd9656"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3a746a24-64e2-4c29-8e09-68d61ebb41cf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c233656-8ff4-4056-a147-fb05c0728123"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c4d9c4c-492d-489f-855b-094977c4e7eb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3cf8cd21-f6ce-4819-852d-d20d37602d1c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3f22efab-3493-4270-bde5-764f16b1f76c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4166a0d8-613a-46d9-bf15-244ee5cbb2de"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("421db311-ff48-4dd3-bedb-18e93200c384"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4226f6a7-cab1-4021-86e9-65f3eb0c3c72"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("42cdacf3-01b3-4e03-99c1-969b808c9d6a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("44c79383-278e-4ccd-b33b-a3c16cafed6e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45049f49-a84a-463e-b32d-1ee2d99e4fff"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("456c2b6d-01cc-47ca-9238-e69c438f4042"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45869d7c-b113-4650-b648-eed5c2f7d8a0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45fc1c65-5310-47d5-8fd4-bd14c75b3f6e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("47930686-b2c9-4181-b03a-fc60348017b2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("47a2abd2-1e6f-4623-a5af-ef4977524ef7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("49f04253-791e-4465-8a7b-0443f9dc2bb0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4ae9d8b8-12b9-471c-bc22-e7ea93b9116d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4f56af9b-620e-4c9b-9741-2cb0e42c7343"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("508c01b7-e5bb-463f-8cee-cc9dfba32ad6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50aa8de0-b280-4076-9b3c-3fb14ee800b0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50e98276-a416-42a0-a23c-6e33b8a9e23d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("520f2d45-adf2-4cb2-b93e-2e666fa4fc37"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("534e9c58-93b5-48b5-a074-fd1b03d11b8b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("54807a01-3a3a-4cd3-881f-1ce7b6458220"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("56c5b084-a2f8-40e0-b12c-16062b8b5c0a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("58be8a21-7894-4406-a4f1-2b4ab37c9526"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("593c795a-80f0-4721-869a-0661412eb20a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("59bf21b1-ee33-4ca5-b830-fd32ff25dc75"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("59ffbe75-497d-4248-b7db-ddc89652eb20"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5a16ba32-78df-42e5-ac46-ac57dc8f9f15"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5a5d7ef1-fd94-46d7-b1ef-c9dfd7ed6e41"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5c9b27d4-b189-4c5d-99a5-8c7bfaaaa853"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5e3c17f5-35b5-47a9-af5f-dd26a3f65bfa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5eb38ef4-77b3-442a-910d-98e70fa68ccd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("60a547f4-71b4-4896-b8b4-5a7df63dcf0d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61be492d-71e7-4b12-9577-b9040fa5ec49"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("65eb0821-9d4b-4554-a3a4-5d6c4561f3a7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("662cc1c8-88ed-4ae0-b8d5-a434051d0fb8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("682e87e0-bc78-4a7b-b326-384bf26e781a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6b5cd019-54eb-44da-a742-4195b9d9b9d5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6bea205d-2be8-482a-8e19-554a64c9188e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6c30c5c3-6096-4a6c-8e94-310f97843ed3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6c7590d8-e322-44fc-b5ad-dd426a6fc3e8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6dede6a2-e63e-4e33-9fce-8ffd9463ef21"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6e2f66b5-88bf-48b7-ac40-810838f8930d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6e895443-a914-4712-b7c1-7fc4c337974d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("72d10473-fe32-47b5-9e21-97014cea87f7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7363abea-591c-42ef-a3e5-ebe7329d0ad7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("74dba396-12e2-490d-a403-c983137fc57f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7532c694-e851-433e-b25b-f8af8f6f4502"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("78d70db3-7052-48a2-a147-e086bfdb979a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("78f1f70c-4a27-494d-8797-201f264a9a5b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("79ff1c93-a470-422d-9f55-7b5a4c2b9c4d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7c6d5c99-a3e5-4609-a834-7f952eeebe36"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7c84aa87-ba0f-47c9-82c2-9b377bd06d70"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7cbf840f-73ce-497c-828e-07e8eb26b4d5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7cd4f57e-f2f0-488f-864e-04b7b392407e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7d5c388a-88c6-4690-92bc-f46429449aa4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7f138259-3220-489b-8e02-57fda6e9b62c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("807a776a-cb59-4b74-92d1-1fec6f23dd9f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("87fb2374-d426-4dc8-805a-c54248ee2e96"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8943325b-609a-4bce-b148-c02b14b0fcb4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8e250bab-c16c-4ba4-b4e1-5728406ae955"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("902666a1-9bbd-4f5c-8b42-bda14dab2151"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("99eb631a-10f1-48ea-9c37-61d9c9ae9e89"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("99f526df-d624-4d67-b199-7eddd4d2defe"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9b5beb53-7c9c-4c2a-b3c3-3b0b5d0317aa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9bad4afe-bae4-4947-8372-e5f7ff43b2c3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9cee8e4b-c9f0-42ca-a4f7-4b52b252b3f2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9e6dbaf6-9c0f-48b0-a82b-a8354fb1181f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9f2d4cc7-cfda-4fee-b803-93019b3998f6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a2d78b98-2afb-42ed-867a-abfceede1d9b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a634ad7a-4a15-447b-af85-4a37015c2d3e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a69e3d43-0d10-41c6-8a33-c1c9d3050cd0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a97a841e-3900-460f-8733-d74e2be019cc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aa0edd26-4b22-468d-9d47-110c2e7da2f1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ab269215-ad3a-4d70-92d3-1f387b26639b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ac9b62d6-c266-42b4-95bf-ad134afaea13"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ad710d5a-b009-4a6a-9be1-b062e0a10ee0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b23c1e55-3751-42ff-8f21-470f38a7b563"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b2d41526-a4fb-434e-874b-2a690c81f210"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b510a294-d629-4b7c-a75b-25c8a07913c6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ba12b933-d5ba-40c5-a34b-7ec02f2e59ab"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bb02cef3-9ac3-4a1e-93d6-50d2aa112690"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bd792e3c-b635-4ba5-942e-6af2e5b01547"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bdca51d6-11e7-4e19-9e1d-e782499f7147"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c099cd18-794c-4aba-8973-046926922e1f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c5ea42cb-7e96-4237-b857-ad8963e036f1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c7928a78-bd3a-4792-bed3-a2c9bc18f2f3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c88193f3-db52-458a-8e58-db174a149c67"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c9eb2b1f-985a-4478-a091-84967495d6af"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cbb9d0c2-9a00-4b33-913e-2aa7a91e9843"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ccad6f6f-7e74-482a-986e-aeed04d23fa0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cd3fff0d-89ea-40f0-a7e2-7804cd1dfb61"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ce2e3766-b56d-4234-b94f-4c269e734bde"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cfc93afe-fae4-4f84-9543-68f8a4cf166b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d0b73ca7-6919-40cf-86a3-f4b8962bb13b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d14c7c35-7e39-48d8-97fe-942219e79c68"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d15dd58c-b22b-498b-a1f6-82906e50e3d2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d424d75f-1f92-423f-a759-e0fc6d295210"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d4b414c0-dce4-4aab-9740-acc08aa73a25"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d56e5fcc-ef79-4f10-93a5-4f0b10c438be"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d5a8c0db-484a-426c-bcaf-4e5fd1b1d185"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d655786f-da58-4e64-8beb-e6ac0b122bd0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d65f5cf5-ccf2-47aa-be2f-1411e195bc4e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d6b62bfd-ff1a-4950-bc61-174e85ca37cc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d81b3997-47b4-4e18-9e24-c3e09f7c3078"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d856391a-2685-4e5f-a6e4-4c9b32a6ffc2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("de39935d-6eb2-443f-9f99-fe7837ad8422"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("debc4597-787d-44b6-85f3-6c652316c05a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e0deca51-8729-4e2d-9ed6-a37c1e3770c7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e0f0887c-91d6-40ed-b94b-0968e5b09536"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e4a34d06-ac49-4966-98a7-6f96c1205b9c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e615fa85-3ddf-42cc-8c59-2f78bcf32b1c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e6c7aa56-7013-42c2-83f8-13d02e7722dd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e6d81a09-425e-49ab-843c-f4cc1c4608a6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e75b4610-4953-48e7-8ab7-aa1ec7a7788b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e99a2181-57f1-4949-bcaf-9e50f49b0437"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ed4e940b-1126-4243-919c-44f7af59094d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ef82e63d-edfb-45d4-8aa8-0b5b81e2e2b4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f0083c0a-27e3-4194-ad2a-b57049635b9c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f0b712b5-6090-474f-a1ab-3b3ab90d2b1c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f151cb53-27d4-41ed-99f3-65f7e982a07f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f178fddb-ce3c-4cf3-bc23-2fb7a27d164d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f4e23d24-a0e1-431c-9bea-ded6cf8a345c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f6b83ac7-cbc8-4aae-ba9b-fe6aaff2ff6a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f6e7ed97-e58d-42a3-968f-7a631710154c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f95ccaec-299b-47f0-b3ad-55465b2edb69"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f9e423bb-dd51-449c-b08c-734f4b14876d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("faa76359-0e78-49fc-9587-e55a857dff19"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fc24b9fd-8e2f-405c-9608-2c0419e8b5ff"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fcd4580d-746b-443e-bfff-9fa703cfab59"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fe1cd1ff-2aee-41d8-be21-a4d0754413db"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("feb534fb-ef5d-4b40-a623-a8f070ed4ccb"));

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

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04f03ec0-8b0d-4e39-bf86-bc9a425adba0"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8631), "Você possui resistência ao tipo \r\nde dano associado ao seu ancestral dracônico.", "Resistência a Dano", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8631) },
                    { new Guid("17b86e57-7f01-4eae-9ec2-d1473bb8a616"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8567), "Acostumado à vida subterrânea, \r\nvocê tem uma visão superior no escuro e na penumbra. \r\nVocê enxerga na penumbra a até 18 metros como se fosse \r\nluz plena, e no escuro como se fosse na penumbra. Você \r\nnão pode discernir cores no escuro, apenas tons de cinza.", "Visão no Escuro", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8567) },
                    { new Guid("1a6715ec-32d6-4108-a68c-eaa763206713"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8634), "Você conhece o truque ilusão \r\nmenor. Inteligência é a sua habilidade usada para \r\nconjurá-la.", "Ilusionista Nato", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8634) },
                    { new Guid("219afa42-b814-43e3-bc1a-5dbd5ac0c936"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8640), "Quando você é reduzido a \r\n0 pontos de vida mas não é completamente morto, você \r\npode voltar para 1 ponto de vida. Você não pode usar essa \r\ncaracterística novamente até completar um descanso \r\nlongo.", "Resistência Implacável", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8640) },
                    { new Guid("2609fa7b-6c5a-4fd3-9530-71faeafc52ca"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8641), "Quando você atinge um ataque \r\ncrítico com uma arma corpo-a-corpo, você pode rolar um \r\ndos dados de dano da arma mais uma vez e adicioná-lo ao \r\ndano extra causado pelo acerto crítico.", "Ataques Selvagens", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8641) },
                    { new Guid("297cd41b-0c4d-479c-8f94-f67496f85f32"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8624), "Você possui \r\ndesvantagem nas jogadas de ataque e testes de Sabedoria \r\n(Percepção) relacionados a visão quando você, o alvo do \r\nseu ataque, ou qualquer coisa que você está tentando \r\nperceber, esteja sob luz solar direta.", "Sensibilidade à Luz Solar", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8624) },
                    { new Guid("2b52ceec-6d22-40b1-bfb5-bfa549392957"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8637), "Você possui proficiência com \r\nferramentas de artesão (ferramentas de engenhoqueiro). \r\nUsando essas ferramentas, você pode gastar 1 hora e 10 \r\npo em materiais para construir um mecanismo Miúdo (CA \r\n5, 1 pv). O mecanismo para de funcionar após 24 horas (a \r\nnão ser que você gaste 1 hora reparando-o para manter o \r\nmecanismo funcionando), ou quando você usa sua ação \r\npara desmantelá-lo; nesse momento, você pode recuperar \r\no material usado para criá-lo. Você pode ter até três\r\n desses mecanismos ativos ao mesmo tempo.", "Engenhoqueiro", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8637) },
                    { new Guid("4702e61d-c8ae-4979-8f71-0f93c57c9328"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8629), "Você pode mover-se através do \r\nespaço de qualquer criatura que for de um tamanho maior \r\nque o seu.", "Agilidade Halfling", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8629) },
                    { new Guid("54632644-40bf-40fe-94fa-40267b9a051f"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8633), "Você possui vantagem em todos \r\nos testes de resistência de Inteligência, Sabedoria e \r\nCarisma contra magia.", "Esperteza Gnômica", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8633) },
                    { new Guid("58dac1dd-a546-48e1-ba93-5dd6d08b7a6a"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8619), "Você tem proficiência na perícia \r\nPercepção.", "Sentidos Aguçados", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8619) },
                    { new Guid("594a683d-c494-4329-8df6-14e6524610a8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8618), "Sempre que você \r\nrealizar um teste de Inteligência (História) relacionado à \r\norigem de um trabalho em pedra, você é considerado \r\nproficiente na perícia História e adiciona o dobro do seu \r\nbônus de proficiência ao teste, ao invés do seu bônus de \r\nproficiência normal.", "Especialização em Rochas", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8618) },
                    { new Guid("6637c1e8-873b-4386-b489-2c89b838e0f4"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8630), "Você pode usar uma ação para \r\nexalar energia destrutiva. Seu ancestral dracônico \r\ndetermina o tamanho, formado e tipo de dano que você \r\nexpele. \r\nQuando você usa sua arma de sopro, cada criatura na \r\nárea exalada deve realizar um teste de resistência, o tipo \r\ndo teste é determinado pelo seu ancestral dracônico. A CD \r\ndo teste de resistência é 8 + seu modificador de \r\nConstituição + seu bônus de proficiência. Uma criatura \r\nsofre 2d6 de dano num fracasso e metade desse dano num \r\nsucesso. O dano aumenta para 3d6 no 6° nível, 4d6 no 11° \r\nnível e 5d6 no 16° nível. \r\nDepois de usar sua arma de sopro, você não poderá \r\nutilizá-la novamente até completar um descanso curto ou \r\nlongo.", "Arma de Sopro", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8630) },
                    { new Guid("7cdb3838-08a7-46bb-9bec-7562381c58bf"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8623), "Você pode tentar se esconder \r\nmesmo quando você está apenas levemente obscurecido  \r\npor folhagem, chuva forte, neve caindo, névoa ou outro \r\nfenômeno natural.", "Máscara da Natureza", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8623) },
                    { new Guid("9ab8f148-ea37-4f26-987a-36674c780da3"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8636), "Toda vez que você fizer \r\num teste de Inteligência (História) relacionado a itens \r\nmágicos, objetos alquímicos ou mecanismos tecnológicos, \r\nvocê pode adicionar o dobro do seu bônus de proficiência, \r\nao invés de qualquer bônus de proficiência que você \r\nnormalmente use.", "Conhecimento de Artífice", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8636) },
                    { new Guid("bee56e65-d360-4e6e-afb3-b3ac6d19a288"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8625), "Quando você obtiver um 1 natural em uma \r\njogada de ataque, teste de habilidade ou teste de \r\nresistência, você pode jogar de novo o dado e deve utilizar \r\no novo resultado.", "Sortudo", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8625) },
                    { new Guid("c5e749f7-e028-4e0f-a774-91d6ff12f57f"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8621), "Elfos não precisam dormir. Ao invés disso, \r\neles meditam profundamente, permanecendo \r\nsemiconscientes, durante 4 horas por dia. (A palavra em \r\nidioma comum para tal meditação é \"transe\".) Enquanto \r\nmedita, um elfo é capaz de sonhar de certo modo. Esses \r\nsonhos na verdade são exercícios mentais que se tornam \r\nreflexos através de anos de prática. Depois de descansar \r\ndessa forma, você ganha os mesmos benefícios que um \r\nhumano depois de 8 horas de sono. ", "Transe", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8621) },
                    { new Guid("cbc8457d-e65f-4549-b41a-b321bf841370"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8620), "Você tem vantagem nos testes de \r\nresistência para resistir a ser enfeitiçado e magias não \r\npodem colocá-lo para dormir.", "Ancestral Feérico", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8620) },
                    { new Guid("d2af847b-74dd-4833-bf9e-d7d491b2d665"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8614), " Você possui vantagem em testes de \r\nresistência contra venenos e resistência contra dano de \r\nveneno.", "Resiliência Anã", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8614) },
                    { new Guid("d2e3d3fd-e7a4-4626-96f3-13ee15fff9b9"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8635), "Através de sons e \r\ngestos, você pode comunicar ideias simples para Bestas \r\npequenas ou menores. Gnomos da floresta amam os \r\nanimais e normalmente possuem esquilos, doninhas, \r\ncoelhos, toupeiras, pica-paus e outras criaturas como \r\namados animais de estimação.", "Falar com Bestas Pequenas", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8635) },
                    { new Guid("da4186d0-d6e2-485d-b775-888ba6272efc"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8626), "Você tem vantagem em testes de resistência \r\ncontra ficar amedrontado. ", "Bravura", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8626) },
                    { new Guid("da48c8dd-9e84-40da-b0d8-0fc2b0a9a535"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8643), "Você possui resistência a dano \r\nde fogo.", "Resistência Infernal", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8643) },
                    { new Guid("e51fca2c-6b05-4875-ae81-ebf197a1e89f"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8644), "Você conhece o truque \r\ntaumaturgia. Quando você atingir o 3° nível, você poderá \r\nconjurar a magia repreensão infernal como uma magia de \r\n2° nível. Quando você atingir o 5° nível, você também \r\npoderá conjurar a magia escuridão. Você precisa terminar \r\num descanso longo para poder usar as magias desse traço \r\nnovamente. Sua habilidade de conjuração para essas \r\nmagias é Carisma.", "Legado Infernal", new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8644) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("0085ca09-91ae-4dcc-84e1-b22c45ae1daf"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8235), 0, "Um kit de escalada inclui pítons \r\nespeciais, botas com solas pontiagudas, luvas e um cinto. \r\nVocê pode usar o kit de escalada como uma ação para \r\n\"ancorar-se\". Quando faz isso, você não pode cair mais de \r\n7,5 metros a partir do ponto onde se ancorou, e não pode \r\nsubir mais de 7,5 metros de distância desse ponto, sem \r\ndesfazer a âncora.", 4, "Kit de escalada", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8235), 25.0, 6.0 },
                    { new Guid("00a4471c-6054-4a5b-ab83-2866a28e2a97"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8480), 0, "", 4, "Ferramentas de Costureiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8480), 1.0, 2.5 },
                    { new Guid("04d92efe-f109-42b0-8327-1fec1ab33022"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8257), 0, "", 4, "Zarabatana (50)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8257), 1.0, 0.5 },
                    { new Guid("053350ea-0f95-4e2a-903d-018201d3bc49"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8214), 0, "", 4, "Cajado", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8214), 5.0, 2.0 },
                    { new Guid("06108c66-96a4-4556-b8a3-649c265ca952"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8153), 0, " Você pode usar um aríete portátil \r\npara quebrar portas. Ao fazer isso, você ganha um bônus \r\nde +4 no teste de Força. Outra criatura pode ajudá-lo a \r\nusar o aríete, o que concede vantagem no teste.", 4, "Ariete portátil", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8153), 4.0, 17.5 },
                    { new Guid("08ada2bd-3a3e-431f-a6a9-14e17738b660"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8227), 2, "", 4, "Frasco", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8227), 2.0, 1.0 },
                    { new Guid("0ae2a0b0-31df-4746-a887-eb8b1847458c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8266), 0, "Usar um pé de cabra concede vantagem \r\nnos testes de Força onde uma alavanca possa ser \r\naplicada.", 4, "Pé de cabra", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8266), 2.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("1213b69d-6630-443e-8a72-62298581defb"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7893), 0, 1, "Armas Marciais à Distância", 1, 8, 0, "Arco Longo", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7893), 50.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("127120af-f168-4f21-9ce9-dd3217827947"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8519), 0, "Essa bolsa de cosméticos, tintura de \r\ncabelo e pequenos adereços permite criar disfarces que \r\nmudam sua aparência física. Proficiência com este kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar um disfarce \r\nvisual.", 4, "Kit de Disfarce", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8519), 25.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("1271b866-a69e-40d7-87eb-4eff897bae5e"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7827), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Maça", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7827), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("13242980-af9a-4ac8-948e-b5729592a4fb"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8159), 0, "Trata-se de uma pequena \r\nbalança, pratos e um sortimento adequado de pesos de até \r\n1 kg. Com ela, você pode medir o peso exato de pequenos \r\nobjetos, como metais preciosos brutos ou bens comerciais, \r\npara ajudar a determinar seu valor.", 4, "Balança de mercador", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8159), 5.0, 1.5 },
                    { new Guid("144b3764-4771-43f8-80a6-87e4c69b3d32"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8265), 1, "", 4, "Parafina", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8265), 5.0, 0.0 },
                    { new Guid("14546ecb-cbba-4b2a-afc2-1d65b9266ebe"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8273), 2, "", 4, "Piton", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8273), 5.0, 0.0 },
                    { new Guid("14dbb03a-ed23-40b5-88a5-35c23b46ff7e"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8492), 0, "", 4, "Ferramentas de Pintor", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8492), 10.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("14f37b8c-090f-4874-a880-21e8c1c71719"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7857), 0, 1, "Armas Simples à Distância", 1, 8, 0, "Besta Leve", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7857), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("15061d71-2bb0-45a4-8595-7503847898d5"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8301), 0, "", 4, "Sino", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8301), 1.0, 0.0 },
                    { new Guid("1949eebf-4a66-4a1b-adc7-08c54069b72e"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8199), 1, "", 4, "Cobertor de inverno", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8199), 5.0, 1.5 },
                    { new Guid("19f747a4-93f7-4b43-83e0-05814b192d1a"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8271), 0, "", 4, "Picareta de minerador", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8271), 2.0, 5.0 },
                    { new Guid("1b0f283e-a641-4ffe-97d5-bfef5c941c3c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8477), 0, "", 4, "Ferramentas de Carpinteiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8477), 8.0, 3.0 },
                    { new Guid("1c647663-17ac-4281-8c99-495a35dec086"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8156), 0, "Quando você usa sua ação para \r\narmá-la, essa armadilha forma um anel de aço com \r\ndentes serrilhados. Eles se fecham quando uma criatura \r\npisa sobre uma placa de pressão no seu centro. A \r\narmadilha é fixada por uma pesada corrente em um \r\nobjeto fixo e imóvel, como uma árvore ou um cravo \r\nenterrado no chão. Uma criatura que pisar na placa de \r\npressão deve ser bem sucedida em um teste de resistência \r\nde Destreza CD 13 ou sofrerá 1d4 de dano perfurante e \r\npara de se mover. Daí em diante, até que a criatura se \r\nliberte da armadilha, seu movimento é limitado ao \r\ncomprimento da corrente (tipicamente 1 metro de \r\ncomprimento). A criatura presa pode usar sua ação para \r\nfazer um teste de Força CD 13 e se libertar, ou outra \r\ncriatura no alcance pode fazer o teste para libertá-la. \r\nCada fracasso no teste causa 1 de dano perfurante à \r\ncriatura presa.", 4, "Armadilha de caça", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8156), 5.0, 12.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("1e4300d3-8162-4caa-86a3-76e3f6f6706c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7871), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Espada Longa", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7871), 15.0, 1.5 },
                    { new Guid("1f34d850-7e10-4208-b824-275f51d42645"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7883), 0, 2, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Malho", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7883), 10.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("1f6a0d02-faf1-42fb-bcda-a4294bfbfac1"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8139), 0, "", 4, "Ábaco", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8139), 2.0, 1.0 },
                    { new Guid("22d3c6c1-5fc0-4b74-84b3-cc25ba9fa37e"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8223), 0, "", 4, "Ramo de visco", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8223), 1.0, 0.0 },
                    { new Guid("2477852b-e3c9-456d-9fc8-ab8b20388559"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8305), 2, "", 4, "Vara (3 metros)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8305), 5.0, 3.5 },
                    { new Guid("25f43e90-52af-4149-b311-abc9260edf96"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8283), 1, "", 4, "Roupas comuns", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8283), 5.0, 1.5 },
                    { new Guid("2698f2ac-21f3-4686-803d-cefa6d615d72"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8237), 1, "Uma lâmpada lança luz plena em um raio \r\nde 4,5 metros e penumbra por mais 9 metros. Uma vez \r\nacesa, a lâmpada queima por 6 horas usando um frasco de \r\nóleo (500 ml).", 4, "Lâmpada", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8237), 5.0, 0.5 },
                    { new Guid("2866b23f-1e03-4a04-9331-f771bb230c84"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8149), 0, "", 4, "Ampulheta", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8149), 25.0, 0.5 },
                    { new Guid("29efa47c-2fb0-4f44-84fe-6d966a37ac1b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8241), 0, "Uma lanterna furta-fogo \r\nlança luz plena em um cone de 18 metros e penumbra por \r\nmais 18 metros. Uma vez acesa, ela queima por 6 horas \r\nusando um frasco de óleo (500 ml).", 4, "Lanterna furta-fogo", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8241), 10.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2b00dde7-23da-4782-adea-0ea8980f12d1"), 2, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8457), 0, "Esse líquido pegajoso e adesivo\r\ninflama em contado com o ar. Usando uma ação, você\r\npode arremessar esse frasco a até 6 metros de distância,\r\nquebrando-o com o impacto. Você deve realizar um ataque\r\nà distância contra uma criatura ou objeto, tratando o fogo\r\nalquímico como uma arma improvisada. Em um sucesso,\r\no alvo sofre 1d4 de dano de fogo no início de cada um de\r\nseus turnos. Uma criatura pode terminar esse dano\r\nusando sua ação e fazendo um teste de Destreza CD 10\r\npara apagar as chamas.", 4, 2, 0, 2, "Fogo alquímico (frasco)", 2, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8457), 50.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("2b1e5de6-e8a2-4427-94a4-dcbcbe331205"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8527), 1, "", 4, "Conjunto de Dados", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8527), 1.0, 0.0 },
                    { new Guid("2b24ad74-1ee5-4c45-81b9-04950f51626a"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8482), 0, "", 4, "Ferramentas de Entalhador", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8482), 1.0, 2.5 },
                    { new Guid("2cb4ec40-998d-4384-b64c-498f909d5274"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8298), 0, "", 4, "Sinete", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8298), 5.0, 0.0 },
                    { new Guid("305841f9-605a-4ef3-8c1c-e1fbb29f72cd"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8274), 0, "Esse estojo \r\ncilíndrico de couro pode armazenar até 10 folhas de papel \r\nenroladas ou 5 folhas de pergaminhos enroladas.", 4, "Porta mapas ou pergaminhos", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8274), 1.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("306bfcdd-1785-430c-9064-af2b5badae7d"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7896), 0, 1, "Armas Marciais à Distância", 1, 10, 0, "Besta Pesada", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7896), 50.0, 4.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("35e43c0b-eb41-4f39-b8a8-51f7433e2585"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8145), 0, " Essas algemas de metal podem prender \r\numa criatura Pequena ou Média. Escapar das algemas \r\nexige sucesso em um teste de Destreza CD 20. Quebrá-las \r\nexige um teste de Força CD 20 bem sucedido. Cada \r\nconjunto de algemas vem com uma chave. Sem a chave, \r\numa criatura proficiente com ferramentas de ladrão pode \r\nabrir a fechadura das algemas com um sucesso em um \r\nteste de Destreza CD 15. As algemas têm 15 pontos de \r\nvida. ", 4, "Algemas", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8145), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("38f3f2b6-7e4f-4bf6-a798-0b8332a347cc"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7805), 0, 1, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Adaga", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7805), 2.0, 0.5 },
                    { new Guid("3b85732f-a8cf-4bb9-b310-c693d8f1e2d8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7851), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Machadinha", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7851), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3c5395e3-1cc9-405e-a162-f131d1111fd6"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8258), 1, "Geralmente vem em um frasco de argila que \r\ncontém 500 ml. Usando uma ação, você pode espirrar o \r\nóleo desse frasco em uma criatura a até 1,5 metro de você\r\nou arremessar a até 6 metros, quebrando-o com o \r\nimpacto. Você deve realizar um ataque à distância contra \r\numa criatura ou objeto, tratando o óleo como uma arma \r\nimprovisada. Com um sucesso, o alvo é coberto de óleo. Se \r\no alvo sofrer qualquer dano flamejante antes do óleo secar\r\n (depois de 1 minuto), a criatura sofre 5 de dano \r\nflamejante adicional pela queima do óleo. Você também \r\npode derramar um frasco de óleo no chão para cobrir uma \r\nárea de um quadrado de 1,5 metro de lado, desde que a \r\nsuperfície esteja nivelada. Se aceso, o óleo queima por 2 \r\nrodadas e causa 5 de dano flamejante a qualquer criatura \r\nque entrar na área ou terminar seu turno dentro da área. \r\nUma criatura pode sofrer esse dano apenas uma vez por \r\nturno.", 4, "Óleo (frasco)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8258), 1.0, 0.5 },
                    { new Guid("3ea15176-c5ae-4130-af25-9d51bd2944de"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8514), 0, "", 4, "Tambor", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8514), 6.0, 1.5 },
                    { new Guid("3eef1f95-8132-4d35-9a81-dd01a621b2f7"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8189), 0, "Trata-se de uma pequena \r\nbolsa de couro à prova d'água que pode ser fixada em um \r\ncinto. Ela possui compartimentos para armazenar todos \r\nos componentes materiais e outros itens especiais que \r\nvocê precisa para lançar suas magias, exceto os \r\ncomponentes que possuem um custo específico (conforme \r\nindicado na descrição da magia).", 4, "Bolsa de componentes", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8189), 25.0, 1.5 },
                    { new Guid("3f153a79-3d68-4668-8619-fee4bf7c1386"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8231), 2, "", 4, "Giz (1 peça)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8231), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3f1cdcf8-0c5a-48dc-b037-2d7f04ff91de"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7891), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Tridente", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7891), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3fc62b80-a9c8-455a-b0c4-2255633bfdd9"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8277), 0, "Esse estojo de madeira pode \r\narmazenar até 20 virotes de besta.", 4, "Porta virotes", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8277), 1.0, 0.5 },
                    { new Guid("3fcc68a0-dc03-41c1-a402-67dd77cc2495"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8162), 0, "", 4, "Barril", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8162), 2.0, 35.0 },
                    { new Guid("40aead84-0476-4bb5-956e-e9f660a81d3a"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8511), 0, "", 4, "Lira", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8511), 30.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("40c55e8f-94ae-4fb3-b714-5c5d66f95e44"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7859), 1, 2, "Armas Simples à Distância", 1, 4, 0, "Funda", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7859), 1.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("43a7fa34-b45a-4a1f-8c01-9ee4f55bec37"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8213), 0, "", 4, "Bastão", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8213), 10.0, 1.0 },
                    { new Guid("43ff6ff8-2580-4a70-abf5-532a9bc91e1f"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8148), 0, "Uma aljava pode guardar até 20 flechas.", 4, "Aljava", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8148), 1.0, 0.5 },
                    { new Guid("45291e43-05a9-4d29-968e-a39f3910cda8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8508), 0, "", 4, "Gaita de Foles", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8508), 30.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("45ff2178-e8fa-4885-9ba8-bab48dfc098b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7858), 2, 1, "Armas Simples à Distância", 1, 4, 0, "Dardo", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7858), 5.0, 0.10000000000000001 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4684506d-3696-4023-b84d-24a7c742e2b8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8261), 0, "", 4, "Panela de ferro", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8261), 2.0, 5.0 },
                    { new Guid("470ab7d8-c49d-4668-a490-6ec976e5880a"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8295), 0, "", 4, "Emblema", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8295), 5.0, 0.0 },
                    { new Guid("49607dc1-41bd-4237-bd90-f5bc244b8567"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8196), 1, "", 4, "Cantil", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8196), 2.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4978f9a2-6b7a-4e57-9fc9-b324418bb8e4"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7854), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Porrete", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7854), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4b6c1636-738e-4c33-81df-7c12dc396212"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8296), 0, "", 4, "Relicário", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8296), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4bf27e21-77ff-4ee1-8d0c-d9b27f72b6f8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7874), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 12, 0, "Lança de Montaria", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7874), 10.0, 3.5 },
                    { new Guid("4c651992-6b6d-4ced-ab0e-15bcb850253f"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7861), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Alabarda", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7861), 20.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4daf8fa2-e608-406c-9881-01164a47e5c4"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8493), 0, "", 4, "Ferramentas de Sapateiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8493), 5.0, 2.5 },
                    { new Guid("4efd8577-afdd-4d5c-a437-d2e877d87ee5"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8484), 0, "", 4, "Ferramentas de Ferreiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8484), 20.0, 4.0 },
                    { new Guid("4f7125ab-6f7e-4309-aabb-3578e2f604c7"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8163), 0, "", 4, "Baú", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8163), 5.0, 12.5 },
                    { new Guid("4fa47498-8806-4f2b-8621-68dafacfb1ad"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8304), 0, "", 4, "Tinta (frasco de 30ml)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8304), 10.0, 0.0 },
                    { new Guid("50a0aa40-602d-46b0-b779-d36e18349646"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8256), 0, "", 4, "Virotes (20)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8256), 1.0, 0.75 },
                    { new Guid("566ae036-aab5-4a0f-8ffc-a2c78fbc8bfb"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8517), 0, "", 4, "Violino", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8517), 30.0, 3.0 },
                    { new Guid("582fe041-0932-4da2-ac80-2d4421bf2062"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8250), 0, "", 4, "Mochila", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8250), 2.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("58e77803-a577-4ecf-b950-79a3e505e61b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7826), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Foice Curta", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7826), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("593638ee-b592-4ca4-b6d5-749a834ca6e8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8302), 0, "Um abrigo simples e portátil que acomoda \r\nduas pessoas.", 4, "Tenda para duas pessoas", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8302), 2.0, 10.0 },
                    { new Guid("5b4e9f22-0e73-4097-82ad-4a46f27f56a7"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8208), 0, "Usando uma ação, você pode \r\ndespejar essas minúsculas esferas de metal para cobrir a \r\nárea de um quadrado de 3 metros de lado. A criatura que \r\nse mover dentro da área deve ser bem sucedida em um \r\nteste de resistência de Destreza CD 10 para não cair no \r\nchão. Uma criatura que mover pela área usando metade \r\ndo seu deslocamento não precisa fazer o teste de \r\nresistência.", 4, "Esferas (sacola com 1.000)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8208), 1.0, 1.0 },
                    { new Guid("61a3a3e7-a0b2-4ec3-a258-b3125d33ffbc"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8212), 0, "A fechadura vem com chave. Sem a \r\nchave, uma criatura proficiente com ferramentas de \r\nladrão pode abrir a fechadura com um sucesso em um \r\nteste de Destreza CD 15. O Mestre pode decidir que \r\nfechaduras melhores estão disponíveis por preços mais \r\nelevados.", 4, "Fechadura", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8212), 10.0, 0.5 },
                    { new Guid("63f60cc6-57e8-4563-aa98-79e9c6a683e4"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8530), 0, "O kit de venenos inclui os frascos, \r\nprodutos químicos e outros equipamentos necessários \r\npara a criação de venenos. Proficiência com esse kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar ou utilizar \r\nvenenos.", 4, "Kit de Venenos", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8530), 50.0, 1.0 },
                    { new Guid("64c59f25-4650-44df-aa19-11c565b0b026"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8253), 2, "", 4, "Balas de Funda (20)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8253), 4.0, 0.75 },
                    { new Guid("66733c0d-3f40-4501-b21d-cc1effbc29cd"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8515), 0, "", 4, "Trombeta", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8515), 3.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("671b7959-d539-4ebf-be92-fea56dd4b251"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7884), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Mangual", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7884), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("674cf6d5-a15f-4ad4-83cb-390b8d24a407"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8282), 0, "Um conjunto de roldanas com um \r\ncabo entre elas e um gancho para fixar aos objetos, a \r\nroldana e polia permitem içar até quatro vezes o peso que \r\nvocê ergueria normalmente.", 4, "Roldana e polia", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8282), 1.0, 2.5 },
                    { new Guid("67ec09ac-e8c1-4339-baba-bd2cafbf883c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8144), 0, "Usando uma ação, você pode espalhar o \r\nconteúdo desse frasco em uma criatura a até 1,5 metro de \r\nvocê ou arremessar a até 6 metros, quebrando o frasco \r\ncom o impacto. Em ambos os casos, você deve realizar um \r\nataque à distância contra uma criatura alvo, tratando a \r\nágua benta como uma arma improvisada. Se o alvo for um \r\ncorruptor ou morto-vivo, ele sofre 2d6 de dano radiante. ", 4, "Água benta (frasco)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8144), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("692c0c02-b1d9-4bd4-92c2-01820c85b743"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7868), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Espada Curta", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7868), 10.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("6def038f-39bc-4016-8193-57b9d0a4f3a8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8281), 0, "", 4, "Robes", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8281), 1.0, 2.0 },
                    { new Guid("6f0c36b0-8bed-4c28-b1d9-d92045cae421"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8502), 0, "Esse conjunto de instrumentos é usado para navegação no mar. \r\nProficiência com as ferramentas de navegador permite \r\ntraçar um curso de navio e seguir cartas de navegação. \r\nAlém disso, essas ferramentas permitem que você \r\nadicione seu bônus de proficiência para qualquer teste de \r\nhabilidade que fizer para não se perder no mar. ", 4, "Ferramentas de navegação", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8502), 25.0, 1.0 },
                    { new Guid("6f6b62a6-0b5f-4d8f-9d1b-444e882540fd"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8478), 0, "", 4, "Ferramentas de Cartógrafo", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8478), 15.0, 3.0 },
                    { new Guid("70e5661a-8592-4908-8d51-4cc604ff6017"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8501), 0, "", 4, "Utensílios de Cozinheiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8501), 1.0, 4.0 },
                    { new Guid("743896b2-01ac-426a-a4ba-b2856e3c1eb9"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8307), 2, "Por uma hora, a vela emana luz plena em um \r\nraio de 1,5 metro e penumbra por mais 1,5 metro.", 4, "Vela", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8307), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("76bd11ff-e272-44c6-93db-afd38707e51e"), 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8454), 0, "Você pode usar o veneno contido\r\nnesse vidro para cobrir a lâmina de uma arma cortante ou\r\nperfurante ou até três peças de munição. Aplicar o veneno\r\nleva uma ação. Uma criatura atingida pela arma ou\r\nmunição envenenada deve obter sucesso em um teste de\r\nresistência de Constituição CD 10 ou sofrerá 1d4 de dano\r\nde veneno. Uma vez aplicado, o veneno retém sua\r\npotência durante 1 minuto antes de secar.", 4, 1, 1, 2, "Veneno básico (frasco)", 2, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8454), 100.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("79fce410-832c-4075-b72b-01f8bff76b0b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8141), 0, "", 4, "Ácido (vidro)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8141), 25.0, 0.5 },
                    { new Guid("7e5b58ab-ebe5-4b77-8d37-02b50c455e7c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8291), 2, "", 4, "Saco", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8291), 1.0, 0.25 },
                    { new Guid("7fb1b808-87b5-4f9b-a12a-8c5702f61e81"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8489), 0, "", 4, "Ferramentas de Oleiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8489), 10.0, 1.5 },
                    { new Guid("82de15a3-9d92-4ef1-b434-cb9c50451c22"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8262), 1, "", 4, "Papel (uma folha)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8262), 2.0, 0.0 },
                    { new Guid("8377d224-f319-4baa-a0a0-1ac74fae789c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8269), 0, "", 4, "Perfume (frasco)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8269), 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("84c0e313-c9c3-43bf-91e7-80aecfd3a527"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7886), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Martelo de Guerra", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7886), 15.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("855c982c-9b15-4277-91e8-0ee63d27ac46"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8203), 0, "Uma corrente possui 10 pontos de vida e \r\npode ser arrebentada com um teste de Força CD 20 bem \r\nsucedido.", 4, "Corrente (3 metros)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8203), 5.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("868d12d4-a9f9-4a36-aacc-5c9a925d36ce"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7865), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Cimitarra", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7865), 25.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8767dc7d-5ed6-47d8-ade1-cee8a9f3a4b3"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8268), 2, "", 4, "Pedra de amolar", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8268), 1.0, 0.0 },
                    { new Guid("891186db-ad9e-4fda-9d3b-a9b5fbe0eeb5"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8284), 0, "", 4, "Roupas de viajante", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8284), 2.0, 2.0 },
                    { new Guid("89ab20cc-04f3-48e5-a865-f00e2515885b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8246), 0, "", 4, "Manto", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8246), 1.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("8b507914-28fd-4922-943a-f20f5c4bdb7f"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7866), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 4, 0, "Chicote", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7866), 2.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8bb4fb47-1131-42eb-98fd-a5559fbda674"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8254), 0, "", 4, "Flechas (20)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8254), 1.0, 0.5 },
                    { new Guid("8c460f0c-21f9-40d9-bf89-ac97a492e03f"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8488), 0, "", 4, "Ferramentas de Joalheiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8488), 25.0, 1.0 },
                    { new Guid("8cf8683f-600b-4280-bbdb-1017c4b29ac2"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8160), 2, "", 4, "Balde", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8160), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("8dae73d5-42d7-42ba-a43a-75950471d9be"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7875), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Lança Longa", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7875), 5.0, 4.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("8e0722df-16e8-4163-aeed-b43379498caa"), 2, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8452), 0, "Um personagem que beber o líquido\r\nvermelho mágico deste frasco recupera 2d4+2 pontos de\r\nvida. Beber ou administrar uma poção exige uma ação.", 4, 2, 0, 2, "Poção de Cura", 2, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8452), 50.0, 0.25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("8fb84dcd-0c00-4146-9a0c-6ec682ceb429"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8200), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de cânhamo (15 metros)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8200), 1.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("90ceb97d-bdf7-44f8-abd0-62205966e1a6"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7887), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Picareta de Guerra", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7887), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9143ef16-d6ed-430d-81fd-7d3b3f0b5450"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8220), 0, "", 4, "Varinha", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8220), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("91bf092d-f10d-4f77-ad36-0001da888d74"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7822), 1, 1, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Azagaia", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7822), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("929d1758-7996-4b63-a250-ded31cc2a797"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8525), 1, "", 4, "Baralho de Cartas", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8525), 5.0, 0.0 },
                    { new Guid("94359bd0-8973-4fa0-bc81-91cb6ebaac35"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8485), 0, "", 4, "Ferramentas de Funileiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8485), 50.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("943fda5e-1a15-4473-91d2-7ec9296cac5b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7825), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 8, 0, "Clava Grande", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7825), 2.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("94d18b9f-fc86-4a07-8c75-df3f51f7de2b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8490), 0, "", 4, "Ferramentas de Pedreiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8490), 10.0, 4.0 },
                    { new Guid("955419e4-4bad-4b1f-81fb-1d40f46dbdbb"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8217), 0, "", 4, "Cristal", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8217), 10.0, 0.5 },
                    { new Guid("98edef22-62f5-472d-a5a8-b8ffe9a56172"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8528), 0, "", 4, "Jogo dos Três Dragões", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8528), 5.0, 0.0 },
                    { new Guid("9bbea499-ce1f-499a-bbd5-5353745edd3f"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8236), 0, "Esse kit é uma bolsa de \r\ncouro contendo ataduras, pomadas e talas. O kit possui \r\nmaterial suficiente para dez usos. Usando uma ação, você \r\npode gastar um uso do kit para estabilizar uma criatura \r\nque tenha 0 pontos de vida, sem a necessidade de realizar \r\num teste de Sabedoria (Medicina).", 4, "Kit de primeiros-socorros", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8236), 5.0, 1.5 },
                    { new Guid("9db48961-7e20-413e-a5ad-e5404bd758e8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8278), 0, "", 4, "Pregos de ferro (10)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8278), 1.0, 2.5 },
                    { new Guid("a11e372a-40e9-44b9-a769-187ef60bb5b4"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8290), 2, "", 4, "Sabão", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8290), 2.0, 0.0 },
                    { new Guid("a1fa0a49-e16f-4c99-9ba6-f085e7093014"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8289), 0, "", 4, "Roupas finas", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8289), 15.0, 3.0 },
                    { new Guid("a3d61ef3-9c33-4f87-8a86-c4289fbac92b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8201), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de seda (15 metros)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8201), 10.0, 2.5 },
                    { new Guid("a530553e-1df5-4b08-ba4b-2db4c9a5f5ff"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8151), 0, "Uma criatura que beber o líquido desse \r\nvidro tem vantagem em testes de resistência contra \r\nvenenos por 1 hora. O antídoto não confere nenhum \r\nbenefício para mortos-vivos ou constructos. ", 4, "Antídoto (vidro)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8151), 50.0, 0.0 },
                    { new Guid("a71d33ec-e494-4bd3-95b3-1272e6a7a41d"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8194), 2, "", 4, "Caneca", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8194), 2.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a88119d8-5ae1-4fe5-8f2a-d7e73b8445c8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7888), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Rapieira", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7888), 25.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a98fd70e-c64d-480c-8a3e-5bd21c69c2db"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8233), 2, "", 4, "Jarra", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8233), 4.0, 2.0 },
                    { new Guid("aa35976c-a5d5-4c77-8205-b6c5164ed9bb"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8270), 1, "", 4, "Pergaminho (uma folha)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8270), 1.0, 0.0 },
                    { new Guid("ad1dd3d6-baa7-4614-82ed-046f9014dffe"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8195), 2, "", 4, "Caneta tinteiro", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8195), 2.0, 0.0 },
                    { new Guid("af8ba852-8bd3-4cbd-94ac-e36b43859354"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8238), 0, "Uma lanterna coberta lança luz \r\nplena em um raio de 9 metros e penumbra por mais 9 \r\nmetros. Uma vez acesa, ela queima por 6 horas usando \r\num frasco de óleo (500 ml). Usando uma ação, você pode \r\nabaixar a cobertura, reduzindo a claridade para \r\npenumbra em um raio de 1,5 metro.", 4, "Lanterna coberta", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8238), 5.0, 1.0 },
                    { new Guid("b06234d3-0795-42b0-9630-7f6f1c818c9e"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8210), 0, "", 4, "Espelho de aço", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8210), 5.0, 0.25 },
                    { new Guid("b16bab33-ad18-4240-8fe2-c1481c0336e7"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8503), 0, "Esse conjunto de ferramentas inclui uma pequena pasta, um conjunto de \r\nchaves mestras, um pequeno espelho montado em uma \r\nalça de metal, um conjunto de tesouras de lâminas \r\nestreitas e um par de alicates. Proficiência com essas \r\nferramentas permite adicionar o bônus de proficiência \r\npara quaisquer testes de habilidade que você fizer para \r\ndesarmar armadilhas ou abrir fechaduras.", 4, "Ferramentas de ladrão", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8503), 25.0, 0.5 },
                    { new Guid("b45b4ce5-e200-4916-8208-c6edf1ef3e8d"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8244), 0, "Um livro pode conter poesia, relatos históricos, \r\ninformações relativas a um campo particular de \r\nsabedoria, diagramas e notas sobre engenhocas gnômicas, \r\nou qualquer outra coisa que possa ser representada \r\nusando texto ou imagens.", 4, "Livro", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8244), 25.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b4709877-7b4b-4c11-9448-680560c9eb5e"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7852), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Martelo Leve", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7852), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b4b24a9d-3b46-42c8-b00d-6910292748d8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8225), 0, "", 4, "Varinha de teixo", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8225), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b4ce9d30-a81b-480f-9ed4-3a9957dd3afe"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7881), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Machado de Batalha", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7881), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("be3ee376-da0d-45f1-84f6-719a0961803d"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8507), 0, "", 4, "Flauta de Pã", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8507), 12.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c2b27cd3-c365-48ef-aa8f-87dd37001357"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7870), 0, 0, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Espada Grande", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7870), 50.0, 3.0 },
                    { new Guid("c3fdc386-ebc7-4244-8af9-248491562052"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7880), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Machado Grande", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7880), 30.0, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c492b5af-7395-4dd3-91bd-5e0f1d76af13"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8211), 0, "Usando uma ação, você pode espalhar um \r\núnico saco de estrepes para cobrir a área de um quadrado \r\nde 1,5 metro de lado. Qualquer criatura que entrar na \r\nárea deve ser bem sucedida em um teste de resistência de \r\nDestreza CD 15. Se falhar, para de se mover e sofre 1 de \r\ndano perfurante. Até que a criatura recupere pelo menos \r\n1 ponto de vida, seu deslocamento de caminhada é \r\nreduzido em 3 metros. Uma criatura que se mover pela \r\nárea usando metade do seu deslocamento não precisa \r\nfazer o teste de resistência.", 4, "Estrepes (bolsa com 20)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8211), 1.0, 1.0 },
                    { new Guid("c55b8f0e-981e-4577-ad53-dd5be4553180"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8224), 0, "", 4, "Totem", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8224), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c578fba2-9d94-4033-a734-c18deceeec87"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7897), 0, 1, "Armas Marciais à Distância", 0, 1, 0, "Rede", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7897), 1.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c5f94e55-b293-4b3d-b244-6ae5246538e3"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8243), 0, "Essa lente permite ver pequenos \r\nobjetos mais de perto. Ela também é útil como um \r\nsubstituto da pederneira e isqueiro para acender fogo. \r\nUsar uma lupa para acender fogo necessita de luz tão \r\nbrilhante como a luz do sol para focar, um pavio e cerca \r\nde 5 minutos. Uma lente de aumento concede vantagem \r\nem qualquer teste de habilidade feito para avaliar ou \r\ninspecionar um item que é pequeno ou muito detalhado.", 4, "Lente de aumento", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8243), 100.0, 0.0 },
                    { new Guid("c9b7da9e-73a9-4a37-8a62-d1c9b250edc1"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8494), 0, "", 4, "Ferramentas de Vidreiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8494), 30.0, 2.5 },
                    { new Guid("ca098543-86d8-41f5-ac2a-206feb288307"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8505), 0, "", 4, "Alaúde", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8505), 35.0, 1.0 },
                    { new Guid("ca833173-bf06-4a1e-8e30-dfdf188c0b1c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8198), 1, "", 4, "Cesto", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8198), 4.0, 1.0 },
                    { new Guid("cafd6dcd-d74f-426c-88d2-fe6a96dd317a"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8248), 0, "", 4, "Marreta", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8248), 2.0, 5.0 },
                    { new Guid("cca38e16-3845-47f5-a80a-d5297eed79f3"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8520), 0, "Essa pequena caixa contém uma \r\nvariedade de papéis e pergaminhos, canetas e tintas, \r\nselos e lacres, folha de ouro e prata, e outros suprimentos \r\nnecessários para criar falsificações convincentes de \r\ndocumentos físicos. Proficiência com esse kit permite \r\nadicionar o bônus de proficiência para quaisquer testes de \r\nhabilidade que você fizer para criar uma falsificação de \r\num documento físico.", 4, "Kit de Falsificação", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8520), 15.0, 2.5 },
                    { new Guid("ccdb0892-f52e-4647-bc8c-a41090195462"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8260), 0, "", 4, "Pá", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8260), 2.0, 2.5 },
                    { new Guid("cd362ef6-dab1-4571-8706-31abdd5d78f1"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8286), 0, "", 4, "Roupas de entretenimento", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8286), 5.0, 2.0 },
                    { new Guid("ce835ea2-9cec-4265-94fe-da47b40ecf7e"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8147), 0, "Uma bolsa de pano ou couro que pode \r\narmazenar até 20 munições de funda ou 50 munições de \r\nzarabatana, entre outras coisas. Para armazenar \r\ncomponentes de magia, veja bolsa de componentes, \r\ntambém descrita nessa seção.", 4, "Algibeira", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8147), 5.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("cfc37d93-5b6c-4f91-877d-e3f0fd707b90"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7894), 0, 1, "Armas Marciais à Distância", 1, 6, 0, "Besta de Mão", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7894), 75.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("cfd06111-b1e3-483e-93f0-ac5b23ccf06f"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8513), 0, "", 4, "Oboé", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8513), 2.0, 0.5 },
                    { new Guid("d2574e9d-349b-4458-beee-12e040209858"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8497), 0, "", 4, "Suprimentos de Cervejeiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8497), 20.0, 4.5 },
                    { new Guid("d40d4921-327b-4f3e-add5-dfc1f5ebba1c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8245), 0, "Objetos vistos através de uma luneta são \r\nampliados até o dobro do seu tamanho.", 4, "Luneta", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8245), 1000.0, 0.5 },
                    { new Guid("d5283eef-13ca-4b7c-9e6a-c8f9b5eb78f7"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8206), 0, "Este kit inclui uma vara \r\nde pesca de madeira, linha de seda, boias de cortiça, \r\nanzóis de aço, chumbadas, iscas e redes de pesca.", 4, "Equipamento de pescaria", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8206), 1.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d90035a9-3079-4e83-b10c-a2bbcb659a92"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7878), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Maça Estrela", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7878), 15.0, 2.0 },
                    { new Guid("dac59d66-4235-449d-8967-db12c22e923b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7872), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Glaive", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7872), 20.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("dd6bf325-e277-4a69-865c-4e266e7f3259"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8303), 2, "A tocha queima por 1 hora, fornecendo luz \r\nplena em um raio de 6 metros e penumbra por mais 6 \r\nmetros. Se você realizar um ataque corpo-a-corpo com \r\numa tocha acesa e acertar, causa 1 de dano flamejante.", 4, "Tocha", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8303), 1.0, 0.5 },
                    { new Guid("ddb4c703-be48-402e-bf2e-b9bd3bb7e781"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8249), 0, "", 4, "Martelo", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8249), 1.0, 1.5 },
                    { new Guid("dea302be-5402-45de-9a80-d28b1314a6bf"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8524), 0, "Esse kit contém uma variedade \r\nde instrumentos, como alicates, almofariz e pilão, e bolsas \r\ne frascos utilizados pelos herbalistas para criar remédios \r\ne poções. Proficiência com este kit permite adicionar o \r\nbônus de proficiência para quaisquer testes de habilidade \r\nque você fizer para identificar ou aplicar ervas. Além \r\ndisso, a proficiência com esse kit é necessária para criar \r\nantídotos e poções de cura.", 4, "Kit de Herbalismo", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8524), 5.0, 1.5 },
                    { new Guid("e0d81445-5761-4c5a-97c7-cfa8f4c6bc0d"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8230), 0, "", 4, "Garrafa de vidro", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8230), 1.0, 1.0 },
                    { new Guid("e1623d0b-a4b1-47e4-9069-12eab2b5ffa5"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8222), 0, "", 4, "Cajado de madeira", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8222), 5.0, 2.0 },
                    { new Guid("e342801d-bcb3-4286-b0f6-8cb76659ead6"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8279), 1, "Consistem em alimentos desidratados adequados para viagens longas, \r\nincluindo carne seca, frutas secas, bolachas e nozes. ", 4, "Rações de viagem (1 dia)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8279), 5.0, 1.0 },
                    { new Guid("e4cff163-c060-48ea-9e9d-c782a14b0831"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8495), 0, "", 4, "Suprimentos de Alquimista", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8495), 50.0, 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e5694dd9-3d2c-4b05-b245-9f9aee4edcb9"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7898), 0, 1, "Armas Marciais à Distância", 1, 1, 0, "Zarabatana", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7898), 10.0, 0.5 },
                    { new Guid("e7d501eb-e6b2-404c-bafc-4bca9cc7b0d4"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7823), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Bordão", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7823), 2.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e83f970a-78df-46b7-acbe-72ea307da79a"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8506), 0, "", 4, "Flauta", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8506), 2.0, 0.5 },
                    { new Guid("e9f6d06d-998f-460c-b77d-c37e291c9352"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8529), 0, "", 4, "Xadrez do Dragão", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8529), 1.0, 0.25 },
                    { new Guid("ebdab4f6-3813-4d09-be21-379283bde9e8"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8207), 1, "", 4, "Escada (3 metros)", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8207), 1.0, 12.5 },
                    { new Guid("eee57a08-7391-4897-91b1-93d0ef87a363"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8152), 0, "", 4, "Apito de advertência", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8152), 25.0, 0.5 },
                    { new Guid("f2f29607-1ace-4ce2-a057-ad3a5cecb6ba"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8232), 0, "Essencial para os magos, um grimório é \r\num volume encadernado em couro com 100 páginas de \r\npergaminhos em branco, adequado para armazenar \r\nmagias.", 4, "Grimório", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8232), 50.0, 1.5 },
                    { new Guid("f40f7e7a-7266-4a92-8bdd-3a8e29b8d7ac"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8500), 0, "", 4, "Suprimentos de Caligrafia", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8500), 10.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f452c775-506c-4d30-ace6-582c0df4acd1"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7855), 0, 1, "Armas Simples à Distância", 1, 6, 0, "Arco Curto", 0, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(7855), 25.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("f697b78a-bbe1-456a-8686-2db7cf241e2e"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8294), 0, "", 4, "Amuleto", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8294), 5.0, 0.5 },
                    { new Guid("f72675a8-5888-497a-88a7-c064e884892c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8481), 0, "", 4, "Ferramentas de Coureiro", 3, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8481), 5.0, 2.5 },
                    { new Guid("f7da37b1-c2d8-43f1-894d-6539ced76704"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8158), 0, "", 4, "Arpéu", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8158), 2.0, 2.0 },
                    { new Guid("f8a2e7ad-72a9-4940-8f31-2557b80f06de"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8219), 0, "", 4, "Orbe", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8219), 20.0, 1.5 },
                    { new Guid("f8e5cdfc-f788-4a33-a969-54ea4911957c"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8190), 1, "Esse pequeno recipiente detém uma \r\npederneira, isqueiro e um pavio (um pano geralmente \r\nseco embebido em óleo) usado para acender uma fogueira. \r\nUsá-lo para acender uma tocha – ou qualquer outra coisa \r\nexposta a um combustível abundante – leva uma ação. \r\nAcender qualquer outro fogo leva 1 minuto.", 4, "Caixa de Fogo", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8190), 5.0, 0.5 },
                    { new Guid("fa97c9f5-1688-40d9-9646-c31351302a7b"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8518), 0, "", 4, "Xilofone", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8518), 25.0, 5.0 },
                    { new Guid("fe9048a6-a3a6-4c10-a88c-d493723cfdfd"), new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8292), 0, "", 4, "Saco de dormir", 4, new DateTime(2024, 6, 4, 11, 13, 56, 539, DateTimeKind.Local).AddTicks(8292), 1.0, 3.5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureDataModelRaceDataModel_RacesId",
                table: "FeatureDataModelRaceDataModel",
                column: "RacesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureDataModelRaceDataModel");

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("04f03ec0-8b0d-4e39-bf86-bc9a425adba0"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("17b86e57-7f01-4eae-9ec2-d1473bb8a616"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("1a6715ec-32d6-4108-a68c-eaa763206713"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("219afa42-b814-43e3-bc1a-5dbd5ac0c936"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("2609fa7b-6c5a-4fd3-9530-71faeafc52ca"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("297cd41b-0c4d-479c-8f94-f67496f85f32"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("2b52ceec-6d22-40b1-bfb5-bfa549392957"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("4702e61d-c8ae-4979-8f71-0f93c57c9328"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("54632644-40bf-40fe-94fa-40267b9a051f"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("58dac1dd-a546-48e1-ba93-5dd6d08b7a6a"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("594a683d-c494-4329-8df6-14e6524610a8"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("6637c1e8-873b-4386-b489-2c89b838e0f4"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("7cdb3838-08a7-46bb-9bec-7562381c58bf"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("9ab8f148-ea37-4f26-987a-36674c780da3"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("bee56e65-d360-4e6e-afb3-b3ac6d19a288"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("c5e749f7-e028-4e0f-a774-91d6ff12f57f"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("cbc8457d-e65f-4549-b41a-b321bf841370"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("d2af847b-74dd-4833-bf9e-d7d491b2d665"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("d2e3d3fd-e7a4-4626-96f3-13ee15fff9b9"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("da4186d0-d6e2-485d-b775-888ba6272efc"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("da48c8dd-9e84-40da-b0d8-0fc2b0a9a535"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("e51fca2c-6b05-4875-ae81-ebf197a1e89f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0085ca09-91ae-4dcc-84e1-b22c45ae1daf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("00a4471c-6054-4a5b-ab83-2866a28e2a97"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("04d92efe-f109-42b0-8327-1fec1ab33022"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("053350ea-0f95-4e2a-903d-018201d3bc49"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("06108c66-96a4-4556-b8a3-649c265ca952"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("08ada2bd-3a3e-431f-a6a9-14e17738b660"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0ae2a0b0-31df-4746-a887-eb8b1847458c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1213b69d-6630-443e-8a72-62298581defb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("127120af-f168-4f21-9ce9-dd3217827947"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1271b866-a69e-40d7-87eb-4eff897bae5e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13242980-af9a-4ac8-948e-b5729592a4fb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("144b3764-4771-43f8-80a6-87e4c69b3d32"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14546ecb-cbba-4b2a-afc2-1d65b9266ebe"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14dbb03a-ed23-40b5-88a5-35c23b46ff7e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("14f37b8c-090f-4874-a880-21e8c1c71719"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("15061d71-2bb0-45a4-8595-7503847898d5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1949eebf-4a66-4a1b-adc7-08c54069b72e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19f747a4-93f7-4b43-83e0-05814b192d1a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1b0f283e-a641-4ffe-97d5-bfef5c941c3c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1c647663-17ac-4281-8c99-495a35dec086"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1e4300d3-8162-4caa-86a3-76e3f6f6706c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1f34d850-7e10-4208-b824-275f51d42645"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1f6a0d02-faf1-42fb-bcda-a4294bfbfac1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("22d3c6c1-5fc0-4b74-84b3-cc25ba9fa37e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2477852b-e3c9-456d-9fc8-ab8b20388559"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("25f43e90-52af-4149-b311-abc9260edf96"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2698f2ac-21f3-4686-803d-cefa6d615d72"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2866b23f-1e03-4a04-9331-f771bb230c84"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("29efa47c-2fb0-4f44-84fe-6d966a37ac1b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2b00dde7-23da-4782-adea-0ea8980f12d1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2b1e5de6-e8a2-4427-94a4-dcbcbe331205"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2b24ad74-1ee5-4c45-81b9-04950f51626a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2cb4ec40-998d-4384-b64c-498f909d5274"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("305841f9-605a-4ef3-8c1c-e1fbb29f72cd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("306bfcdd-1785-430c-9064-af2b5badae7d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("35e43c0b-eb41-4f39-b8a8-51f7433e2585"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("38f3f2b6-7e4f-4bf6-a798-0b8332a347cc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3b85732f-a8cf-4bb9-b310-c693d8f1e2d8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c5395e3-1cc9-405e-a162-f131d1111fd6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3ea15176-c5ae-4130-af25-9d51bd2944de"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3eef1f95-8132-4d35-9a81-dd01a621b2f7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3f153a79-3d68-4668-8619-fee4bf7c1386"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3f1cdcf8-0c5a-48dc-b037-2d7f04ff91de"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3fc62b80-a9c8-455a-b0c4-2255633bfdd9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3fcc68a0-dc03-41c1-a402-67dd77cc2495"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40aead84-0476-4bb5-956e-e9f660a81d3a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40c55e8f-94ae-4fb3-b714-5c5d66f95e44"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("43a7fa34-b45a-4a1f-8c01-9ee4f55bec37"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("43ff6ff8-2580-4a70-abf5-532a9bc91e1f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45291e43-05a9-4d29-968e-a39f3910cda8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45ff2178-e8fa-4885-9ba8-bab48dfc098b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4684506d-3696-4023-b84d-24a7c742e2b8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("470ab7d8-c49d-4668-a490-6ec976e5880a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("49607dc1-41bd-4237-bd90-f5bc244b8567"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4978f9a2-6b7a-4e57-9fc9-b324418bb8e4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4b6c1636-738e-4c33-81df-7c12dc396212"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4bf27e21-77ff-4ee1-8d0c-d9b27f72b6f8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4c651992-6b6d-4ced-ab0e-15bcb850253f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4daf8fa2-e608-406c-9881-01164a47e5c4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4efd8577-afdd-4d5c-a437-d2e877d87ee5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4f7125ab-6f7e-4309-aabb-3578e2f604c7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4fa47498-8806-4f2b-8621-68dafacfb1ad"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("50a0aa40-602d-46b0-b779-d36e18349646"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("566ae036-aab5-4a0f-8ffc-a2c78fbc8bfb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("582fe041-0932-4da2-ac80-2d4421bf2062"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("58e77803-a577-4ecf-b950-79a3e505e61b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("593638ee-b592-4ca4-b6d5-749a834ca6e8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5b4e9f22-0e73-4097-82ad-4a46f27f56a7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61a3a3e7-a0b2-4ec3-a258-b3125d33ffbc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("63f60cc6-57e8-4563-aa98-79e9c6a683e4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("64c59f25-4650-44df-aa19-11c565b0b026"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("66733c0d-3f40-4501-b21d-cc1effbc29cd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("671b7959-d539-4ebf-be92-fea56dd4b251"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("674cf6d5-a15f-4ad4-83cb-390b8d24a407"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("67ec09ac-e8c1-4339-baba-bd2cafbf883c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("692c0c02-b1d9-4bd4-92c2-01820c85b743"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6def038f-39bc-4016-8193-57b9d0a4f3a8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6f0c36b0-8bed-4c28-b1d9-d92045cae421"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6f6b62a6-0b5f-4d8f-9d1b-444e882540fd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("70e5661a-8592-4908-8d51-4cc604ff6017"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("743896b2-01ac-426a-a4ba-b2856e3c1eb9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("76bd11ff-e272-44c6-93db-afd38707e51e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("79fce410-832c-4075-b72b-01f8bff76b0b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7e5b58ab-ebe5-4b77-8d37-02b50c455e7c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7fb1b808-87b5-4f9b-a12a-8c5702f61e81"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("82de15a3-9d92-4ef1-b434-cb9c50451c22"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8377d224-f319-4baa-a0a0-1ac74fae789c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("84c0e313-c9c3-43bf-91e7-80aecfd3a527"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("855c982c-9b15-4277-91e8-0ee63d27ac46"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("868d12d4-a9f9-4a36-aacc-5c9a925d36ce"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8767dc7d-5ed6-47d8-ade1-cee8a9f3a4b3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("891186db-ad9e-4fda-9d3b-a9b5fbe0eeb5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("89ab20cc-04f3-48e5-a865-f00e2515885b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8b507914-28fd-4922-943a-f20f5c4bdb7f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8bb4fb47-1131-42eb-98fd-a5559fbda674"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8c460f0c-21f9-40d9-bf89-ac97a492e03f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8cf8683f-600b-4280-bbdb-1017c4b29ac2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8dae73d5-42d7-42ba-a43a-75950471d9be"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8e0722df-16e8-4163-aeed-b43379498caa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8fb84dcd-0c00-4146-9a0c-6ec682ceb429"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("90ceb97d-bdf7-44f8-abd0-62205966e1a6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9143ef16-d6ed-430d-81fd-7d3b3f0b5450"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("91bf092d-f10d-4f77-ad36-0001da888d74"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("929d1758-7996-4b63-a250-ded31cc2a797"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("94359bd0-8973-4fa0-bc81-91cb6ebaac35"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("943fda5e-1a15-4473-91d2-7ec9296cac5b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("94d18b9f-fc86-4a07-8c75-df3f51f7de2b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("955419e4-4bad-4b1f-81fb-1d40f46dbdbb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("98edef22-62f5-472d-a5a8-b8ffe9a56172"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9bbea499-ce1f-499a-bbd5-5353745edd3f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9db48961-7e20-413e-a5ad-e5404bd758e8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a11e372a-40e9-44b9-a769-187ef60bb5b4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a1fa0a49-e16f-4c99-9ba6-f085e7093014"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a3d61ef3-9c33-4f87-8a86-c4289fbac92b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a530553e-1df5-4b08-ba4b-2db4c9a5f5ff"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a71d33ec-e494-4bd3-95b3-1272e6a7a41d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a88119d8-5ae1-4fe5-8f2a-d7e73b8445c8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a98fd70e-c64d-480c-8a3e-5bd21c69c2db"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aa35976c-a5d5-4c77-8205-b6c5164ed9bb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ad1dd3d6-baa7-4614-82ed-046f9014dffe"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("af8ba852-8bd3-4cbd-94ac-e36b43859354"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b06234d3-0795-42b0-9630-7f6f1c818c9e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b16bab33-ad18-4240-8fe2-c1481c0336e7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b45b4ce5-e200-4916-8208-c6edf1ef3e8d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b4709877-7b4b-4c11-9448-680560c9eb5e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b4b24a9d-3b46-42c8-b00d-6910292748d8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b4ce9d30-a81b-480f-9ed4-3a9957dd3afe"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("be3ee376-da0d-45f1-84f6-719a0961803d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c2b27cd3-c365-48ef-aa8f-87dd37001357"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c3fdc386-ebc7-4244-8af9-248491562052"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c492b5af-7395-4dd3-91bd-5e0f1d76af13"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c55b8f0e-981e-4577-ad53-dd5be4553180"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c578fba2-9d94-4033-a734-c18deceeec87"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c5f94e55-b293-4b3d-b244-6ae5246538e3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c9b7da9e-73a9-4a37-8a62-d1c9b250edc1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ca098543-86d8-41f5-ac2a-206feb288307"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ca833173-bf06-4a1e-8e30-dfdf188c0b1c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cafd6dcd-d74f-426c-88d2-fe6a96dd317a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cca38e16-3845-47f5-a80a-d5297eed79f3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ccdb0892-f52e-4647-bc8c-a41090195462"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cd362ef6-dab1-4571-8706-31abdd5d78f1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ce835ea2-9cec-4265-94fe-da47b40ecf7e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cfc37d93-5b6c-4f91-877d-e3f0fd707b90"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cfd06111-b1e3-483e-93f0-ac5b23ccf06f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d2574e9d-349b-4458-beee-12e040209858"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d40d4921-327b-4f3e-add5-dfc1f5ebba1c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d5283eef-13ca-4b7c-9e6a-c8f9b5eb78f7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d90035a9-3079-4e83-b10c-a2bbcb659a92"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dac59d66-4235-449d-8967-db12c22e923b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dd6bf325-e277-4a69-865c-4e266e7f3259"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ddb4c703-be48-402e-bf2e-b9bd3bb7e781"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dea302be-5402-45de-9a80-d28b1314a6bf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e0d81445-5761-4c5a-97c7-cfa8f4c6bc0d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e1623d0b-a4b1-47e4-9069-12eab2b5ffa5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e342801d-bcb3-4286-b0f6-8cb76659ead6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e4cff163-c060-48ea-9e9d-c782a14b0831"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e5694dd9-3d2c-4b05-b245-9f9aee4edcb9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e7d501eb-e6b2-404c-bafc-4bca9cc7b0d4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e83f970a-78df-46b7-acbe-72ea307da79a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e9f6d06d-998f-460c-b77d-c37e291c9352"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ebdab4f6-3813-4d09-be21-379283bde9e8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("eee57a08-7391-4897-91b1-93d0ef87a363"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f2f29607-1ace-4ce2-a057-ad3a5cecb6ba"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f40f7e7a-7266-4a92-8bdd-3a8e29b8d7ac"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f452c775-506c-4d30-ace6-582c0df4acd1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f697b78a-bbe1-456a-8686-2db7cf241e2e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f72675a8-5888-497a-88a7-c064e884892c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f7da37b1-c2d8-43f1-894d-6539ced76704"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f8a2e7ad-72a9-4940-8f31-2557b80f06de"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f8e5cdfc-f788-4a33-a969-54ea4911957c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fa97c9f5-1688-40d9-9646-c31351302a7b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fe9048a6-a3a6-4c10-a88c-d493723cfdfd"));

            migrationBuilder.CreateTable(
                name: "RaceFeatureDataModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceFeatureDataModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceFeatureDataModel_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceFeatureDataModel_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("00f6d778-7757-4991-acaa-859b30c2460c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4492), 2, "", 4, "Vara (3 metros)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4492), 5.0, 3.5 },
                    { new Guid("01882559-e5d6-40c3-937f-994a278a0b1e"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4402), 1, "Uma lâmpada lança luz plena em um raio \r\nde 4,5 metros e penumbra por mais 9 metros. Uma vez \r\nacesa, a lâmpada queima por 6 horas usando um frasco de \r\nóleo (500 ml).", 4, "Lâmpada", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4402), 5.0, 0.5 },
                    { new Guid("01959080-31b1-406c-a2d5-fd1a1e3fda4e"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4494), 2, "Por uma hora, a vela emana luz plena em um \r\nraio de 1,5 metro e penumbra por mais 1,5 metro.", 4, "Vela", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4494), 1.0, 0.0 },
                    { new Guid("03a1e722-9a09-484c-911c-2943edef9f88"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4374), 0, "", 4, "Cristal", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4374), 10.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("046d99eb-fd88-41fe-8f6b-9b9c94594c50"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3925), 0, 0, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Espada Grande", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3925), 50.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("055ffb45-b2d8-4fb1-bc6d-dc2f37b88549"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4263), 0, "", 4, "Ábaco", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4263), 2.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("0602d824-00ff-4eea-aee0-07501bb6bdff"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3902), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Martelo Leve", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3902), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("076bb1cb-042f-48af-b813-03fa40c96108"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4278), 0, "Uma criatura que beber o líquido desse \r\nvidro tem vantagem em testes de resistência contra \r\nvenenos por 1 hora. O antídoto não confere nenhum \r\nbenefício para mortos-vivos ou constructos. ", 4, "Antídoto (vidro)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4278), 50.0, 0.0 },
                    { new Guid("0cc096b4-a03a-41ef-8758-12e4e2e49f68"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4705), 0, "Essa pequena caixa contém uma \r\nvariedade de papéis e pergaminhos, canetas e tintas, \r\nselos e lacres, folha de ouro e prata, e outros suprimentos \r\nnecessários para criar falsificações convincentes de \r\ndocumentos físicos. Proficiência com esse kit permite \r\nadicionar o bônus de proficiência para quaisquer testes de \r\nhabilidade que você fizer para criar uma falsificação de \r\num documento físico.", 4, "Kit de Falsificação", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4705), 15.0, 2.5 },
                    { new Guid("0d6b8b1b-ebd4-4655-934f-aee9d3016833"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4717), 0, "O kit de venenos inclui os frascos, \r\nprodutos químicos e outros equipamentos necessários \r\npara a criação de venenos. Proficiência com esse kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar ou utilizar \r\nvenenos.", 4, "Kit de Venenos", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4717), 50.0, 1.0 },
                    { new Guid("0e20d4d9-aa3c-49b4-8944-bc62f60f6faa"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4442), 2, "", 4, "Pedra de amolar", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4442), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("10587427-a7a7-44a5-97fc-82d754e31ea0"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3900), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Machadinha", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3900), 5.0, 1.0 },
                    { new Guid("12b874e5-c346-46ef-b560-be6d067a19ee"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3914), 1, 2, "Armas Simples à Distância", 1, 4, 0, "Funda", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3914), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("138f53fc-2f35-4834-9f01-6d5655f5f573"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4430), 1, "Geralmente vem em um frasco de argila que \r\ncontém 500 ml. Usando uma ação, você pode espirrar o \r\nóleo desse frasco em uma criatura a até 1,5 metro de você\r\nou arremessar a até 6 metros, quebrando-o com o \r\nimpacto. Você deve realizar um ataque à distância contra \r\numa criatura ou objeto, tratando o óleo como uma arma \r\nimprovisada. Com um sucesso, o alvo é coberto de óleo. Se \r\no alvo sofrer qualquer dano flamejante antes do óleo secar\r\n (depois de 1 minuto), a criatura sofre 5 de dano \r\nflamejante adicional pela queima do óleo. Você também \r\npode derramar um frasco de óleo no chão para cobrir uma \r\nárea de um quadrado de 1,5 metro de lado, desde que a \r\nsuperfície esteja nivelada. Se aceso, o óleo queima por 2 \r\nrodadas e causa 5 de dano flamejante a qualquer criatura \r\nque entrar na área ou terminar seu turno dentro da área. \r\nUma criatura pode sofrer esse dano apenas uma vez por \r\nturno.", 4, "Óleo (frasco)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4430), 1.0, 0.5 },
                    { new Guid("14073eaf-95de-40e1-9d59-0d2584eb7254"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4376), 0, "", 4, "Orbe", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4376), 20.0, 1.5 },
                    { new Guid("1460d49e-1cc7-4f24-89de-52cac95aef84"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4696), 0, "", 4, "Tambor", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4696), 6.0, 1.5 },
                    { new Guid("14ed58a6-2121-4ea6-a100-52eb63dfb9a1"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4423), 0, "", 4, "Flechas (20)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4423), 1.0, 0.5 },
                    { new Guid("175a3e70-f6fc-4c6b-afc4-f6848194bbe7"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4483), 0, "", 4, "Sino", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4483), 1.0, 0.0 },
                    { new Guid("1e077453-02bb-49dd-9341-58bfd1293ec2"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4298), 2, "", 4, "Caneca", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4298), 2.0, 0.5 },
                    { new Guid("1e45ade7-76fc-4fec-9a3e-b3ed0def333b"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4649), 0, "", 4, "Ferramentas de Cartógrafo", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4649), 15.0, 3.0 },
                    { new Guid("1fa403ae-2f70-4b5d-bb70-f99317a07aa7"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4449), 2, "", 4, "Piton", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4449), 5.0, 0.0 },
                    { new Guid("20f19250-8350-474b-9c32-c43f3e0f2ebb"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4481), 0, "", 4, "Sinete", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4481), 5.0, 0.0 },
                    { new Guid("2139b1ac-4bb6-473e-9a84-a87e87746a7f"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4698), 0, "", 4, "Trombeta", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4698), 3.0, 1.0 },
                    { new Guid("23eb83bd-4043-469c-8c2b-8b65e71e8dba"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4307), 1, "", 4, "Cobertor de inverno", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4307), 5.0, 1.5 },
                    { new Guid("24ec348d-57c5-4c4d-9222-025218db0227"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4411), 0, "Um livro pode conter poesia, relatos históricos, \r\ninformações relativas a um campo particular de \r\nsabedoria, diagramas e notas sobre engenhocas gnômicas, \r\nou qualquer outra coisa que possa ser representada \r\nusando texto ou imagens.", 4, "Livro", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4411), 25.0, 2.5 },
                    { new Guid("26ea1c28-1e34-4fe5-aafd-119f34c0fe89"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4445), 1, "", 4, "Pergaminho (uma folha)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4445), 1.0, 0.0 },
                    { new Guid("274886fa-819d-4df0-b1bc-bfcaebe5ef8f"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4404), 0, "Uma lanterna coberta lança luz \r\nplena em um raio de 9 metros e penumbra por mais 9 \r\nmetros. Uma vez acesa, ela queima por 6 horas usando \r\num frasco de óleo (500 ml). Usando uma ação, você pode \r\nabaixar a cobertura, reduzindo a claridade para \r\npenumbra em um raio de 1,5 metro.", 4, "Lanterna coberta", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4404), 5.0, 1.0 },
                    { new Guid("2a7ad63d-a0c0-42dc-b064-c37ae5bc8444"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4283), 0, "Quando você usa sua ação para \r\narmá-la, essa armadilha forma um anel de aço com \r\ndentes serrilhados. Eles se fecham quando uma criatura \r\npisa sobre uma placa de pressão no seu centro. A \r\narmadilha é fixada por uma pesada corrente em um \r\nobjeto fixo e imóvel, como uma árvore ou um cravo \r\nenterrado no chão. Uma criatura que pisar na placa de \r\npressão deve ser bem sucedida em um teste de resistência \r\nde Destreza CD 13 ou sofrerá 1d4 de dano perfurante e \r\npara de se mover. Daí em diante, até que a criatura se \r\nliberte da armadilha, seu movimento é limitado ao \r\ncomprimento da corrente (tipicamente 1 metro de \r\ncomprimento). A criatura presa pode usar sua ação para \r\nfazer um teste de Força CD 13 e se libertar, ou outra \r\ncriatura no alcance pode fazer o teste para libertá-la. \r\nCada fracasso no teste causa 1 de dano perfurante à \r\ncriatura presa.", 4, "Armadilha de caça", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4283), 5.0, 12.5 },
                    { new Guid("2bc7580f-7559-452b-bd34-06ee1770be69"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4447), 0, "", 4, "Picareta de minerador", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4447), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2c2d65ad-1560-4b1e-9735-cd202adb5783"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3949), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Martelo de Guerra", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3949), 15.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("2dc46ee2-5e0e-4f72-859d-a0c68c0007ad"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4387), 0, "", 4, "Varinha de teixo", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4387), 10.0, 0.5 },
                    { new Guid("2ed7fa36-6d0d-4fa7-9724-18c17700e59c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4682), 0, "Esse conjunto de ferramentas inclui uma pequena pasta, um conjunto de \r\nchaves mestras, um pequeno espelho montado em uma \r\nalça de metal, um conjunto de tesouras de lâminas \r\nestreitas e um par de alicates. Proficiência com essas \r\nferramentas permite adicionar o bônus de proficiência \r\npara quaisquer testes de habilidade que você fizer para \r\ndesarmar armadilhas ou abrir fechaduras.", 4, "Ferramentas de ladrão", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4682), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("31101347-8f19-4e8a-8acd-5e2c0dc8389d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3956), 0, 1, "Armas Marciais à Distância", 1, 8, 0, "Arco Longo", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3956), 50.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("360ef6ee-6588-457c-94d0-d5c5aced0b77"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4300), 2, "", 4, "Caneta tinteiro", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4300), 2.0, 0.0 },
                    { new Guid("36e21fa8-9e67-4862-a68b-44bb8454d627"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4413), 0, "Objetos vistos através de uma luneta são \r\nampliados até o dobro do seu tamanho.", 4, "Luneta", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4413), 1000.0, 0.5 },
                    { new Guid("37f9f959-61d3-4bc5-be8a-4a28b7e31b77"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4464), 0, "", 4, "Roupas de viajante", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4464), 2.0, 2.0 },
                    { new Guid("3a24cac5-65dd-4ce4-bb83-2db037dd9656"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4490), 0, "", 4, "Tinta (frasco de 30ml)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4490), 10.0, 0.0 },
                    { new Guid("3a746a24-64e2-4c29-8e09-68d61ebb41cf"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4303), 1, "", 4, "Cantil", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4303), 2.0, 2.5 },
                    { new Guid("3c233656-8ff4-4056-a147-fb05c0728123"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4267), 0, "Usando uma ação, você pode espalhar o \r\nconteúdo desse frasco em uma criatura a até 1,5 metro de \r\nvocê ou arremessar a até 6 metros, quebrando o frasco \r\ncom o impacto. Em ambos os casos, você deve realizar um \r\nataque à distância contra uma criatura alvo, tratando a \r\nágua benta como uma arma improvisada. Se o alvo for um \r\ncorruptor ou morto-vivo, ele sofre 2d6 de dano radiante. ", 4, "Água benta (frasco)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4267), 25.0, 0.5 },
                    { new Guid("3c4d9c4c-492d-489f-855b-094977c4e7eb"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4708), 1, "", 4, "Baralho de Cartas", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4708), 5.0, 0.0 },
                    { new Guid("3cf8cd21-f6ce-4819-852d-d20d37602d1c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4700), 0, "", 4, "Violino", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4700), 30.0, 3.0 },
                    { new Guid("3f22efab-3493-4270-bde5-764f16b1f76c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4665), 0, "", 4, "Ferramentas de Pedreiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4665), 10.0, 4.0 },
                    { new Guid("4166a0d8-613a-46d9-bf15-244ee5cbb2de"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4437), 1, "", 4, "Parafina", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4437), 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("421db311-ff48-4dd3-bedb-18e93200c384"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3966), 0, 1, "Armas Marciais à Distância", 1, 1, 0, "Zarabatana", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3966), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4226f6a7-cab1-4021-86e9-65f3eb0c3c72"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4401), 0, "Esse kit é uma bolsa de \r\ncouro contendo ataduras, pomadas e talas. O kit possui \r\nmaterial suficiente para dez usos. Usando uma ação, você \r\npode gastar um uso do kit para estabilizar uma criatura \r\nque tenha 0 pontos de vida, sem a necessidade de realizar \r\num teste de Sabedoria (Medicina).", 4, "Kit de primeiros-socorros", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4401), 5.0, 1.5 },
                    { new Guid("42cdacf3-01b3-4e03-99c1-969b808c9d6a"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4428), 0, "", 4, "Zarabatana (50)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4428), 1.0, 0.5 },
                    { new Guid("44c79383-278e-4ccd-b33b-a3c16cafed6e"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4478), 0, "", 4, "Emblema", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4478), 5.0, 0.0 },
                    { new Guid("45049f49-a84a-463e-b32d-1ee2d99e4fff"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4373), 0, "", 4, "Cajado", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4373), 5.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("456c2b6d-01cc-47ca-9238-e69c438f4042"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3929), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Glaive", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3929), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("45869d7c-b113-4650-b648-eed5c2f7d8a0"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4706), 0, "Esse kit contém uma variedade \r\nde instrumentos, como alicates, almofariz e pilão, e bolsas \r\ne frascos utilizados pelos herbalistas para criar remédios \r\ne poções. Proficiência com este kit permite adicionar o \r\nbônus de proficiência para quaisquer testes de habilidade \r\nque você fizer para identificar ou aplicar ervas. Além \r\ndisso, a proficiência com esse kit é necessária para criar \r\nantídotos e poções de cura.", 4, "Kit de Herbalismo", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4706), 5.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("45fc1c65-5310-47d5-8fd4-bd14c75b3f6e"), 2, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4614), 0, "Um personagem que beber o líquido\r\nvermelho mágico deste frasco recupera 2d4+2 pontos de\r\nvida. Beber ou administrar uma poção exige uma ação.", 4, 2, 0, 2, "Poção de Cura", 2, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4614), 50.0, 0.25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("47930686-b2c9-4181-b03a-fc60348017b2"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4666), 0, "", 4, "Ferramentas de Pintor", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4666), 10.0, 2.5 },
                    { new Guid("47a2abd2-1e6f-4623-a5af-ef4977524ef7"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4369), 0, "A fechadura vem com chave. Sem a \r\nchave, uma criatura proficiente com ferramentas de \r\nladrão pode abrir a fechadura com um sucesso em um \r\nteste de Destreza CD 15. O Mestre pode decidir que \r\nfechaduras melhores estão disponíveis por preços mais \r\nelevados.", 4, "Fechadura", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4369), 10.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("49f04253-791e-4465-8a7b-0443f9dc2bb0"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3893), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Bordão", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3893), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4ae9d8b8-12b9-471c-bc22-e7ea93b9116d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4485), 0, "Um abrigo simples e portátil que acomoda \r\nduas pessoas.", 4, "Tenda para duas pessoas", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4485), 2.0, 10.0 },
                    { new Guid("4f56af9b-620e-4c9b-9741-2cb0e42c7343"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4713), 0, "", 4, "Jogo dos Três Dragões", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4713), 5.0, 0.0 },
                    { new Guid("508c01b7-e5bb-463f-8cee-cc9dfba32ad6"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4463), 1, "", 4, "Roupas comuns", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4463), 5.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("50aa8de0-b280-4076-9b3c-3fb14ee800b0"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3938), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Maça Estrela", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3938), 15.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("50e98276-a416-42a0-a23c-6e33b8a9e23d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4715), 0, "", 4, "Xadrez do Dragão", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4715), 1.0, 0.25 },
                    { new Guid("520f2d45-adf2-4cb2-b93e-2e666fa4fc37"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4450), 0, "Esse estojo \r\ncilíndrico de couro pode armazenar até 10 folhas de papel \r\nenroladas ou 5 folhas de pergaminhos enroladas.", 4, "Porta mapas ou pergaminhos", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4450), 1.0, 0.5 },
                    { new Guid("534e9c58-93b5-48b5-a074-fd1b03d11b8b"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4311), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de seda (15 metros)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4311), 10.0, 2.5 },
                    { new Guid("54807a01-3a3a-4cd3-881f-1ce7b6458220"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4712), 1, "", 4, "Conjunto de Dados", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4712), 1.0, 0.0 },
                    { new Guid("56c5b084-a2f8-40e0-b12c-16062b8b5c0a"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4435), 1, "", 4, "Papel (uma folha)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4435), 2.0, 0.0 },
                    { new Guid("58be8a21-7894-4406-a4f1-2b4ab37c9526"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4680), 0, "Esse conjunto de instrumentos é usado para navegação no mar. \r\nProficiência com as ferramentas de navegador permite \r\ntraçar um curso de navio e seguir cartas de navegação. \r\nAlém disso, essas ferramentas permitem que você \r\nadicione seu bônus de proficiência para qualquer teste de \r\nhabilidade que fizer para não se perder no mar. ", 4, "Ferramentas de navegação", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4680), 25.0, 1.0 },
                    { new Guid("593c795a-80f0-4721-869a-0661412eb20a"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4475), 0, "", 4, "Saco de dormir", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4475), 1.0, 3.5 },
                    { new Guid("59bf21b1-ee33-4ca5-b830-fd32ff25dc75"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4363), 0, "Usando uma ação, você pode \r\ndespejar essas minúsculas esferas de metal para cobrir a \r\nárea de um quadrado de 3 metros de lado. A criatura que \r\nse mover dentro da área deve ser bem sucedida em um \r\nteste de resistência de Destreza CD 10 para não cair no \r\nchão. Uma criatura que mover pela área usando metade \r\ndo seu deslocamento não precisa fazer o teste de \r\nresistência.", 4, "Esferas (sacola com 1.000)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4363), 1.0, 1.0 },
                    { new Guid("59ffbe75-497d-4248-b7db-ddc89652eb20"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4653), 0, "", 4, "Ferramentas de Coureiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4653), 5.0, 2.5 },
                    { new Guid("5a16ba32-78df-42e5-ac46-ac57dc8f9f15"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4645), 0, "", 4, "Ferramentas de Carpinteiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4645), 8.0, 3.0 },
                    { new Guid("5a5d7ef1-fd94-46d7-b1ef-c9dfd7ed6e41"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4380), 0, "", 4, "Varinha", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4380), 10.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5c9b27d4-b189-4c5d-99a5-8c7bfaaaa853"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3962), 0, 1, "Armas Marciais à Distância", 1, 10, 0, "Besta Pesada", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3962), 50.0, 4.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5e3c17f5-35b5-47a9-af5f-dd26a3f65bfa"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4480), 0, "", 4, "Relicário", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4480), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5eb38ef4-77b3-442a-910d-98e70fa68ccd"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3943), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Machado de Batalha", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3943), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("60a547f4-71b4-4896-b8b4-5a7df63dcf0d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4444), 0, "", 4, "Perfume (frasco)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4444), 5.0, 0.0 },
                    { new Guid("61be492d-71e7-4b12-9577-b9040fa5ec49"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4274), 0, "Uma aljava pode guardar até 20 flechas.", 4, "Aljava", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4274), 1.0, 0.5 },
                    { new Guid("65eb0821-9d4b-4554-a3a4-5d6c4561f3a7"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4371), 0, "", 4, "Bastão", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4371), 10.0, 1.0 },
                    { new Guid("662cc1c8-88ed-4ae0-b8d5-a434051d0fb8"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4654), 0, "", 4, "Ferramentas de Entalhador", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4654), 1.0, 2.5 },
                    { new Guid("682e87e0-bc78-4a7b-b326-384bf26e781a"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4390), 0, "", 4, "Garrafa de vidro", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4390), 1.0, 1.0 },
                    { new Guid("6b5cd019-54eb-44da-a742-4195b9d9b9d5"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4273), 0, "Uma bolsa de pano ou couro que pode \r\narmazenar até 20 munições de funda ou 50 munições de \r\nzarabatana, entre outras coisas. Para armazenar \r\ncomponentes de magia, veja bolsa de componentes, \r\ntambém descrita nessa seção.", 4, "Algibeira", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4273), 5.0, 0.5 },
                    { new Guid("6bea205d-2be8-482a-8e19-554a64c9188e"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4421), 2, "", 4, "Balas de Funda (20)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4421), 4.0, 0.75 },
                    { new Guid("6c30c5c3-6096-4a6c-8e94-310f97843ed3"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4418), 0, "", 4, "Martelo", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4418), 1.0, 1.5 },
                    { new Guid("6c7590d8-e322-44fc-b5ad-dd426a6fc3e8"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4291), 0, "", 4, "Barril", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4291), 2.0, 35.0 },
                    { new Guid("6dede6a2-e63e-4e33-9fce-8ffd9463ef21"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4399), 0, "Um kit de escalada inclui pítons \r\nespeciais, botas com solas pontiagudas, luvas e um cinto. \r\nVocê pode usar o kit de escalada como uma ação para \r\n\"ancorar-se\". Quando faz isso, você não pode cair mais de \r\n7,5 metros a partir do ponto onde se ancorou, e não pode \r\nsubir mais de 7,5 metros de distância desse ponto, sem \r\ndesfazer a âncora.", 4, "Kit de escalada", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4399), 25.0, 6.0 },
                    { new Guid("6e2f66b5-88bf-48b7-ac40-810838f8930d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4433), 0, "", 4, "Panela de ferro", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4433), 2.0, 5.0 },
                    { new Guid("6e895443-a914-4712-b7c1-7fc4c337974d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4659), 0, "", 4, "Ferramentas de Joalheiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4659), 25.0, 1.0 },
                    { new Guid("72d10473-fe32-47b5-9e21-97014cea87f7"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4668), 0, "", 4, "Ferramentas de Sapateiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4668), 5.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7363abea-591c-42ef-a3e5-ebe7329d0ad7"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3934), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 12, 0, "Lança de Montaria", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3934), 10.0, 3.5 },
                    { new Guid("74dba396-12e2-490d-a403-c983137fc57f"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3895), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 8, 0, "Clava Grande", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3895), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7532c694-e851-433e-b25b-f8af8f6f4502"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4415), 0, "", 4, "Manto", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4415), 1.0, 2.0 },
                    { new Guid("78d70db3-7052-48a2-a147-e086bfdb979a"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4690), 0, "", 4, "Lira", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4690), 30.0, 1.0 },
                    { new Guid("78f1f70c-4a27-494d-8797-201f264a9a5b"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4701), 0, "", 4, "Xilofone", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4701), 25.0, 5.0 },
                    { new Guid("79ff1c93-a470-422d-9f55-7b5a4c2b9c4d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4269), 0, " Essas algemas de metal podem prender \r\numa criatura Pequena ou Média. Escapar das algemas \r\nexige sucesso em um teste de Destreza CD 20. Quebrá-las \r\nexige um teste de Força CD 20 bem sucedido. Cada \r\nconjunto de algemas vem com uma chave. Sem a chave, \r\numa criatura proficiente com ferramentas de ladrão pode \r\nabrir a fechadura das algemas com um sucesso em um \r\nteste de Destreza CD 15. As algemas têm 15 pontos de \r\nvida. ", 4, "Algemas", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4269), 2.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7c6d5c99-a3e5-4609-a834-7f952eeebe36"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3912), 2, 1, "Armas Simples à Distância", 1, 4, 0, "Dardo", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3912), 5.0, 0.10000000000000001 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7c84aa87-ba0f-47c9-82c2-9b377bd06d70"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4293), 0, "", 4, "Baú", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4293), 5.0, 12.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7cbf840f-73ce-497c-828e-07e8eb26b4d5"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3916), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Alabarda", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3916), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7cd4f57e-f2f0-488f-864e-04b7b392407e"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4290), 2, "", 4, "Balde", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4290), 5.0, 1.0 },
                    { new Guid("7d5c388a-88c6-4690-92bc-f46429449aa4"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4673), 0, "", 4, "Suprimentos de Cervejeiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4673), 20.0, 4.5 },
                    { new Guid("7f138259-3220-489b-8e02-57fda6e9b62c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4689), 0, "", 4, "Gaita de Foles", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4689), 30.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("807a776a-cb59-4b74-92d1-1fec6f23dd9f"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3920), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 4, 0, "Chicote", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3920), 2.0, 1.5 },
                    { new Guid("87fb2374-d426-4dc8-805a-c54248ee2e96"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3918), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Cimitarra", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3918), 25.0, 1.5 },
                    { new Guid("8943325b-609a-4bce-b148-c02b14b0fcb4"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3899), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Maça", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3899), 5.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8e250bab-c16c-4ba4-b4e1-5728406ae955"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4296), 1, "Esse pequeno recipiente detém uma \r\npederneira, isqueiro e um pavio (um pano geralmente \r\nseco embebido em óleo) usado para acender uma fogueira. \r\nUsá-lo para acender uma tocha – ou qualquer outra coisa \r\nexposta a um combustível abundante – leva uma ação. \r\nAcender qualquer outro fogo leva 1 minuto.", 4, "Caixa de Fogo", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4296), 5.0, 0.5 },
                    { new Guid("902666a1-9bbd-4f5c-8b42-bda14dab2151"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4454), 0, "", 4, "Pregos de ferro (10)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4454), 1.0, 2.5 },
                    { new Guid("99eb631a-10f1-48ea-9c37-61d9c9ae9e89"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4458), 1, "Consistem em alimentos desidratados adequados para viagens longas, \r\nincluindo carne seca, frutas secas, bolachas e nozes. ", 4, "Rações de viagem (1 dia)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4458), 5.0, 1.0 },
                    { new Guid("99f526df-d624-4d67-b199-7eddd4d2defe"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4672), 0, "", 4, "Suprimentos de Alquimista", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4672), 50.0, 4.0 },
                    { new Guid("9b5beb53-7c9c-4c2a-b3c3-3b0b5d0317aa"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4288), 0, "Trata-se de uma pequena \r\nbalança, pratos e um sortimento adequado de pesos de até \r\n1 kg. Com ela, você pode medir o peso exato de pequenos \r\nobjetos, como metais preciosos brutos ou bens comerciais, \r\npara ajudar a determinar seu valor.", 4, "Balança de mercador", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4288), 5.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9bad4afe-bae4-4947-8372-e5f7ff43b2c3"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3960), 0, 1, "Armas Marciais à Distância", 1, 6, 0, "Besta de Mão", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3960), 75.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("9cee8e4b-c9f0-42ca-a4f7-4b52b252b3f2"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4383), 0, "", 4, "Ramo de visco", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4383), 1.0, 0.0 },
                    { new Guid("9e6dbaf6-9c0f-48b0-a82b-a8354fb1181f"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4416), 0, "", 4, "Marreta", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4416), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("9f2d4cc7-cfda-4fee-b803-93019b3998f6"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3964), 0, 1, "Armas Marciais à Distância", 0, 1, 0, "Rede", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3964), 1.0, 1.5 },
                    { new Guid("a2d78b98-2afb-42ed-867a-abfceede1d9b"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3951), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Picareta de Guerra", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3951), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a634ad7a-4a15-447b-af85-4a37015c2d3e"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4670), 0, "", 4, "Ferramentas de Vidreiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4670), 30.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a69e3d43-0d10-41c6-8a33-c1c9d3050cd0"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3910), 0, 1, "Armas Simples à Distância", 1, 8, 0, "Besta Leve", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3910), 25.0, 2.5 },
                    { new Guid("a97a841e-3900-460f-8733-d74e2be019cc"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3906), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Porrete", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3906), 1.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("aa0edd26-4b22-468d-9d47-110c2e7da2f1"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4432), 0, "", 4, "Pá", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4432), 2.0, 2.5 },
                    { new Guid("ab269215-ad3a-4d70-92d3-1f387b26639b"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4687), 0, "", 4, "Flauta de Pã", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4687), 12.0, 1.0 },
                    { new Guid("ac9b62d6-c266-42b4-95bf-ad134afaea13"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4309), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de cânhamo (15 metros)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4309), 1.0, 5.0 },
                    { new Guid("ad710d5a-b009-4a6a-9be1-b062e0a10ee0"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4452), 0, "Esse estojo de madeira pode \r\narmazenar até 20 virotes de besta.", 4, "Porta virotes", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4452), 1.0, 0.5 },
                    { new Guid("b23c1e55-3751-42ff-8f21-470f38a7b563"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4392), 2, "", 4, "Giz (1 peça)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4392), 1.0, 0.0 },
                    { new Guid("b2d41526-a4fb-434e-874b-2a690c81f210"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4305), 1, "", 4, "Cesto", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4305), 4.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("b510a294-d629-4b7c-a75b-25c8a07913c6"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3908), 0, 1, "Armas Simples à Distância", 1, 6, 0, "Arco Curto", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3908), 25.0, 1.0 },
                    { new Guid("ba12b933-d5ba-40c5-a34b-7ec02f2e59ab"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3953), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Rapieira", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3953), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("bb02cef3-9ac3-4a1e-93d6-50d2aa112690"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4426), 0, "", 4, "Virotes (20)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4426), 1.0, 0.75 },
                    { new Guid("bd792e3c-b635-4ba5-942e-6af2e5b01547"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4656), 0, "", 4, "Ferramentas de Ferreiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4656), 20.0, 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("bdca51d6-11e7-4e19-9e1d-e782499f7147"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3954), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Tridente", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3954), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c099cd18-794c-4aba-8973-046926922e1f"), 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4617), 0, "Você pode usar o veneno contido\r\nnesse vidro para cobrir a lâmina de uma arma cortante ou\r\nperfurante ou até três peças de munição. Aplicar o veneno\r\nleva uma ação. Uma criatura atingida pela arma ou\r\nmunição envenenada deve obter sucesso em um teste de\r\nresistência de Constituição CD 10 ou sofrerá 1d4 de dano\r\nde veneno. Uma vez aplicado, o veneno retém sua\r\npotência durante 1 minuto antes de secar.", 4, 1, 1, 2, "Veneno básico (frasco)", 2, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4617), 100.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c5ea42cb-7e96-4237-b857-ad8963e036f1"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4284), 0, "", 4, "Arpéu", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4284), 2.0, 2.0 },
                    { new Guid("c7928a78-bd3a-4792-bed3-a2c9bc18f2f3"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4406), 0, "Uma lanterna furta-fogo \r\nlança luz plena em um cone de 18 metros e penumbra por \r\nmais 18 metros. Uma vez acesa, ela queima por 6 horas \r\nusando um frasco de óleo (500 ml).", 4, "Lanterna furta-fogo", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4406), 10.0, 1.0 },
                    { new Guid("c88193f3-db52-458a-8e58-db174a149c67"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4661), 0, "", 4, "Ferramentas de Oleiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4661), 10.0, 1.5 },
                    { new Guid("c9eb2b1f-985a-4478-a091-84967495d6af"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4675), 0, "", 4, "Suprimentos de Caligrafia", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4675), 10.0, 2.5 },
                    { new Guid("cbb9d0c2-9a00-4b33-913e-2aa7a91e9843"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4382), 0, "", 4, "Cajado de madeira", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4382), 5.0, 2.0 },
                    { new Guid("ccad6f6f-7e74-482a-986e-aeed04d23fa0"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4388), 2, "", 4, "Frasco", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4388), 2.0, 1.0 },
                    { new Guid("cd3fff0d-89ea-40f0-a7e2-7804cd1dfb61"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4477), 0, "", 4, "Amuleto", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4477), 5.0, 0.5 },
                    { new Guid("ce2e3766-b56d-4234-b94f-4c269e734bde"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4385), 0, "", 4, "Totem", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4385), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("cfc93afe-fae4-4f84-9543-68f8a4cf166b"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3923), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Espada Curta", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3923), 10.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d0b73ca7-6919-40cf-86a3-f4b8962bb13b"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4279), 0, "", 4, "Apito de advertência", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4279), 25.0, 0.5 },
                    { new Guid("d14c7c35-7e39-48d8-97fe-942219e79c68"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4359), 1, "", 4, "Escada (3 metros)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4359), 1.0, 12.5 },
                    { new Guid("d15dd58c-b22b-498b-a1f6-82906e50e3d2"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4395), 0, "Essencial para os magos, um grimório é \r\num volume encadernado em couro com 100 páginas de \r\npergaminhos em branco, adequado para armazenar \r\nmagias.", 4, "Grimório", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4395), 50.0, 1.5 },
                    { new Guid("d424d75f-1f92-423f-a759-e0fc6d295210"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4651), 0, "", 4, "Ferramentas de Costureiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4651), 1.0, 2.5 },
                    { new Guid("d4b414c0-dce4-4aab-9740-acc08aa73a25"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4281), 0, " Você pode usar um aríete portátil \r\npara quebrar portas. Ao fazer isso, você ganha um bônus \r\nde +4 no teste de Força. Outra criatura pode ajudá-lo a \r\nusar o aríete, o que concede vantagem no teste.", 4, "Ariete portátil", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4281), 4.0, 17.5 },
                    { new Guid("d56e5fcc-ef79-4f10-93a5-4f0b10c438be"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4265), 0, "", 4, "Ácido (vidro)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4265), 25.0, 0.5 },
                    { new Guid("d5a8c0db-484a-426c-bcaf-4e5fd1b1d185"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4295), 0, "Trata-se de uma pequena \r\nbolsa de couro à prova d'água que pode ser fixada em um \r\ncinto. Ela possui compartimentos para armazenar todos \r\nos componentes materiais e outros itens especiais que \r\nvocê precisa para lançar suas magias, exceto os \r\ncomponentes que possuem um custo específico (conforme \r\nindicado na descrição da magia).", 4, "Bolsa de componentes", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4295), 25.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d655786f-da58-4e64-8beb-e6ac0b122bd0"), 2, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4619), 0, "Esse líquido pegajoso e adesivo\r\ninflama em contado com o ar. Usando uma ação, você\r\npode arremessar esse frasco a até 6 metros de distância,\r\nquebrando-o com o impacto. Você deve realizar um ataque\r\nà distância contra uma criatura ou objeto, tratando o fogo\r\nalquímico como uma arma improvisada. Em um sucesso,\r\no alvo sofre 1d4 de dano de fogo no início de cada um de\r\nseus turnos. Uma criatura pode terminar esse dano\r\nusando sua ação e fazendo um teste de Destreza CD 10\r\npara apagar as chamas.", 4, 2, 0, 2, "Fogo alquímico (frasco)", 2, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4619), 50.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d65f5cf5-ccf2-47aa-be2f-1411e195bc4e"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4397), 2, "", 4, "Jarra", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4397), 4.0, 2.0 },
                    { new Guid("d6b62bfd-ff1a-4950-bc61-174e85ca37cc"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4461), 0, "Um conjunto de roldanas com um \r\ncabo entre elas e um gancho para fixar aos objetos, a \r\nroldana e polia permitem içar até quatro vezes o peso que \r\nvocê ergueria normalmente.", 4, "Roldana e polia", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4461), 1.0, 2.5 },
                    { new Guid("d81b3997-47b4-4e18-9e24-c3e09f7c3078"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4489), 2, "A tocha queima por 1 hora, fornecendo luz \r\nplena em um raio de 6 metros e penumbra por mais 6 \r\nmetros. Se você realizar um ataque corpo-a-corpo com \r\numa tocha acesa e acertar, causa 1 de dano flamejante.", 4, "Tocha", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4489), 1.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d856391a-2685-4e5f-a6e4-4c9b32a6ffc2"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3756), 0, 1, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Adaga", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3756), 2.0, 0.5 },
                    { new Guid("de39935d-6eb2-443f-9f99-fe7837ad8422"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3945), 0, 2, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Malho", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3945), 10.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("debc4597-787d-44b6-85f3-6c652316c05a"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4685), 0, "", 4, "Flauta", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4685), 2.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e0deca51-8729-4e2d-9ed6-a37c1e3770c7"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3897), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Foice Curta", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3897), 1.0, 1.0 },
                    { new Guid("e0f0887c-91d6-40ed-b94b-0968e5b09536"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3939), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Machado Grande", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3939), 30.0, 3.5 },
                    { new Guid("e4a34d06-ac49-4966-98a7-6f96c1205b9c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3936), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Lança Longa", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3936), 5.0, 4.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e615fa85-3ddf-42cc-8c59-2f78bcf32b1c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4367), 0, "Usando uma ação, você pode espalhar um \r\núnico saco de estrepes para cobrir a área de um quadrado \r\nde 1,5 metro de lado. Qualquer criatura que entrar na \r\nárea deve ser bem sucedida em um teste de resistência de \r\nDestreza CD 15. Se falhar, para de se mover e sofre 1 de \r\ndano perfurante. Até que a criatura recupere pelo menos \r\n1 ponto de vida, seu deslocamento de caminhada é \r\nreduzido em 3 metros. Uma criatura que se mover pela \r\nárea usando metade do seu deslocamento não precisa \r\nfazer o teste de resistência.", 4, "Estrepes (bolsa com 20)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4367), 1.0, 1.0 },
                    { new Guid("e6c7aa56-7013-42c2-83f8-13d02e7722dd"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4276), 0, "", 4, "Ampulheta", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4276), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e6d81a09-425e-49ab-843c-f4cc1c4608a6"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3927), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Espada Longa", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3927), 15.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e75b4610-4953-48e7-8ab7-aa1ec7a7788b"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4408), 0, "Essa lente permite ver pequenos \r\nobjetos mais de perto. Ela também é útil como um \r\nsubstituto da pederneira e isqueiro para acender fogo. \r\nUsar uma lupa para acender fogo necessita de luz tão \r\nbrilhante como a luz do sol para focar, um pavio e cerca \r\nde 5 minutos. Uma lente de aumento concede vantagem \r\nem qualquer teste de habilidade feito para avaliar ou \r\ninspecionar um item que é pequeno ou muito detalhado.", 4, "Lente de aumento", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4408), 100.0, 0.0 },
                    { new Guid("e99a2181-57f1-4949-bcaf-9e50f49b0437"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4657), 0, "", 4, "Ferramentas de Funileiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4657), 50.0, 5.0 },
                    { new Guid("ed4e940b-1126-4243-919c-44f7af59094d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4313), 0, "Uma corrente possui 10 pontos de vida e \r\npode ser arrebentada com um teste de Força CD 20 bem \r\nsucedido.", 4, "Corrente (3 metros)", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4313), 5.0, 5.0 },
                    { new Guid("ef82e63d-edfb-45d4-8aa8-0b5b81e2e2b4"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4473), 2, "", 4, "Saco", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4473), 1.0, 0.25 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f0083c0a-27e3-4194-ad2a-b57049635b9c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3947), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Mangual", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3947), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("f0b712b5-6090-474f-a1ab-3b3ab90d2b1c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4692), 0, "", 4, "Oboé", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4692), 2.0, 0.5 },
                    { new Guid("f151cb53-27d4-41ed-99f3-65f7e982a07f"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4676), 0, "", 4, "Utensílios de Cozinheiro", 3, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4676), 1.0, 4.0 },
                    { new Guid("f178fddb-ce3c-4cf3-bc23-2fb7a27d164d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4459), 0, "", 4, "Robes", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4459), 1.0, 2.0 },
                    { new Guid("f4e23d24-a0e1-431c-9bea-ded6cf8a345c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4366), 0, "", 4, "Espelho de aço", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4366), 5.0, 0.25 },
                    { new Guid("f6b83ac7-cbc8-4aae-ba9b-fe6aaff2ff6a"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4703), 0, "Essa bolsa de cosméticos, tintura de \r\ncabelo e pequenos adereços permite criar disfarces que \r\nmudam sua aparência física. Proficiência com este kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar um disfarce \r\nvisual.", 4, "Kit de Disfarce", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4703), 25.0, 1.5 },
                    { new Guid("f6e7ed97-e58d-42a3-968f-7a631710154c"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4419), 0, "", 4, "Mochila", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4419), 2.0, 2.5 },
                    { new Guid("f95ccaec-299b-47f0-b3ad-55465b2edb69"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4684), 0, "", 4, "Alaúde", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4684), 35.0, 1.0 },
                    { new Guid("f9e423bb-dd51-449c-b08c-734f4b14876d"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4466), 0, "", 4, "Roupas de entretenimento", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4466), 5.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("faa76359-0e78-49fc-9587-e55a857dff19"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3891), 1, 1, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Azagaia", 0, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(3891), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("fc24b9fd-8e2f-405c-9608-2c0419e8b5ff"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4438), 0, "Usar um pé de cabra concede vantagem \r\nnos testes de Força onde uma alavanca possa ser \r\naplicada.", 4, "Pé de cabra", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4438), 2.0, 2.5 },
                    { new Guid("fcd4580d-746b-443e-bfff-9fa703cfab59"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4468), 0, "", 4, "Roupas finas", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4468), 15.0, 3.0 },
                    { new Guid("fe1cd1ff-2aee-41d8-be21-a4d0754413db"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4315), 0, "Este kit inclui uma vara \r\nde pesca de madeira, linha de seda, boias de cortiça, \r\nanzóis de aço, chumbadas, iscas e redes de pesca.", 4, "Equipamento de pescaria", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4315), 1.0, 2.0 },
                    { new Guid("feb534fb-ef5d-4b40-a623-a8f070ed4ccb"), new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4469), 2, "", 4, "Sabão", 4, new DateTime(2024, 6, 4, 10, 30, 35, 4, DateTimeKind.Local).AddTicks(4469), 2.0, 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RaceFeatureDataModel_FeatureId",
                table: "RaceFeatureDataModel",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceFeatureDataModel_RaceId",
                table: "RaceFeatureDataModel",
                column: "RaceId");
        }
    }
}
