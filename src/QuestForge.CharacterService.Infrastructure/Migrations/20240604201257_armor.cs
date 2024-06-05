using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestForge.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class armor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("1139181d-ac36-46c5-b007-0775fb2c9c36"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("28a640dc-d863-47cd-8237-2d918a3d4cd7"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("2f7a0e12-0da4-4932-964f-145a43cd393e"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("3f3e090b-fd87-485b-805e-1c6284385b65"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("544ce9fb-7cd8-4d52-8b69-2b0ba669463c"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("560f35ab-5d13-455d-8163-e955602e40bf"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("610e56c3-1579-4c11-b1cd-c28781977951"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("64791ab2-b629-492e-9cb6-fc070eae75e7"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("6544e546-0d43-4015-9c3e-a6d61fd83f08"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("6eabb5a3-e40f-4ffb-a414-229700082f44"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("7287e869-a012-4056-9ffc-65321e5821c4"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("7ea5ad4b-0d9d-4dbb-9303-9bfe6dab43ad"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("8d427440-fefb-451e-8dad-574f004799ed"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("8d8ab7d1-5680-42a8-8ecf-9d5b01fa2f62"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("8da63290-8c87-497c-90b4-8a10db3db983"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("912196ef-dec3-4e55-b5bb-7a97ad8a75fd"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("93f57ae4-300e-40d7-939b-1df18a48dc46"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("95910921-4d47-4d49-84c1-287d0b791dc7"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("accb920a-f216-495a-b916-cc3ec7b3556d"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("bf5cc6f7-7877-455f-a825-010a85d5fda0"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("cc03a689-65cf-4ce3-993f-528ee52b3a40"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("d25b1776-078d-48d4-942b-e8670eb0afaf"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("edaecd04-97c8-4fed-9fc4-07a1168d7d44"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("036c774e-8395-4e23-8051-a5dd14816594"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("04973af6-2387-446f-ba0c-13473fc73e63"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("05688ae4-34d3-4d00-8b30-bd0333eca4ed"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0715e156-b647-4cc4-8336-2638cf7e62ec"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0724afc0-c691-4ae8-a0ab-55d7c035d051"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("08376271-027c-46d1-9d22-bf6e71087203"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("09fca367-d13e-4d8c-b0e1-45594edcf01b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0f8b3bed-f0d9-4d21-a40b-4e9b0b08f35e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("103b1a9d-91cd-4ce0-bf84-34b4ef520170"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("104577e9-73af-4da0-97c1-09b0e9904965"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1077b791-0f98-4e6c-bee8-96ddeb0f2ace"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("10f3029b-4893-42de-b54f-68cf10114956"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("171aacfe-9c55-4d40-88ba-8be9601eb905"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("175a9c05-61cc-4dc3-af48-78efae242e72"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("18d5ca83-8a1e-49c0-9c5a-c71d065d2a30"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("19b4b60c-8564-44b9-ad0e-4fd6f76143d4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1a7ab600-59ab-4037-984c-c4686eab496f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1b0babb2-5737-417a-918f-a3935ad7202d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1b5352a6-d14a-42f3-af3e-93fdbcd6d453"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1d46c734-97da-4258-afef-2f8bdaafd1e8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2031f668-360a-4680-a317-31c0dbf8d508"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("20f39ed2-d8ac-433f-afd5-2f3d87cf45cd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("24c1bd99-55e3-4018-bbc4-e115b08dcdff"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("26130ea2-dd33-44e0-9d14-c435f355d5bd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("27e237ad-cb97-48ab-9edc-a7757498c7a2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("288c2d27-15bd-4c79-b6ca-3409e8d3a051"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2a309414-e5c4-4795-bad6-c6130fc8cc44"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2c251892-a0e6-428d-9754-4e7fa3565ba0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3251f23c-b581-4987-9d0f-a53422e56253"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3407ebb8-8174-44fc-846a-d83aa6a795fd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3546aa1a-12f4-44b9-b8bc-f49fa15a527e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("364cfb10-9512-4dd1-a16a-b03295d82208"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("36601da2-797c-49a5-935c-081513cc37aa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("370c9670-115a-4361-a9c6-4473fec55768"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("37e64586-b2a0-4f25-a19d-53ae14782af8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("39db57f3-58d5-4884-9777-b2651ec25338"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c1b3466-fc90-4835-a05e-83a13e711943"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3f6196f6-def6-4bd6-950d-d3433a8f0e39"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("41d48983-a930-4ac5-bbf1-03617770016b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("42cc2f62-8737-4d23-aec7-a0779367d66a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("44cfbeea-4888-41f8-869a-15c161997323"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45b78d6e-480f-4d54-bb58-50aa1e79db17"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45c33100-5b28-4946-ad35-5d4bc4a834c6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("46aa3fd4-16ff-4018-aebd-6acbc5308411"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4888f81e-08a7-4e24-9515-ba86d14a3678"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("49cda751-02be-4684-b7ed-cab4044eefd4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4dde91ef-4d66-4b66-9e02-47a890636a3a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4edad7ce-8c24-4fcc-9bd3-38bbaa924a54"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4fb73ee5-6251-4136-bb3f-a33866c186b4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("500a5fc9-f5dc-4b9b-a4ac-b18f61d1674d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("51ee0f05-0ac4-44fe-bba6-cda62696c594"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("525a5f65-8fec-441f-9286-7ff0bcf69349"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("53a853f4-5c70-4edb-bf2e-b4d7c0adec91"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5532d7d4-f59d-4378-95a0-9ab18320c2ec"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5567c39a-34c7-47bc-8028-a16b82a2488c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5b3e6848-b24a-4c01-b0e3-930cfdb1c97d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5c255920-86aa-412f-a15d-8c23f76b5460"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5daf5298-9e63-4197-b5ef-0aab78a4459e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5dbd6e5a-9399-49ec-a6b2-521bc490bb17"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5f279228-5a74-4c8d-aa5e-8751a98813c0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("61480f7c-9f5a-496d-a327-bde26ec9b538"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6497b3cc-9d9c-42c0-9333-8d99150b8d4d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("651c1e02-7afd-428e-af31-ca207915dccd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6526625a-9348-4923-9fe7-d750152893d6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6554bf77-d014-4e43-a564-eba2dd37f052"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6769c805-2c47-4342-a9a4-f4693a9fbe18"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("68c24708-bcaf-4341-b5e9-c80bca26bc61"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("68ee2d5f-52db-425e-bec0-92f2a5f93d04"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("69a767f2-93fe-46be-8742-d71024c80231"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6a436eed-e0ec-4504-8671-501c78b669fc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6c50f2de-91a1-4c4e-8be7-fa87f9e5065c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6f19d72e-a592-4b8e-8313-4a96554720ed"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("720eabf0-1b70-4e69-9e42-e52d964a6060"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("76a68ed1-b5a6-48f4-a2e8-9a287193dc5f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("776717a3-48c5-4964-8161-0e94c5aae4e9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7b10bf33-0316-4669-8333-1edfba3e87f3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7bb45d0c-5e76-4761-8900-6a0da857cd5c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7c226e41-5ab6-45ee-8229-3830b86d3549"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7c68471d-9908-412a-b9dd-b72ac88ae2aa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7c8a88d6-4461-48a6-ac40-3d76149ff70d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7e126980-5ff6-479e-8e22-60bcf05bc1bf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7f213931-d4a7-42e0-83cf-3d4ce154638f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7fa9a8db-3753-4a59-9f28-83fe969fc83c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7fe68072-257d-4585-b7a1-1ad8c1d7c092"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("80ac34a8-f47c-41ce-92a2-5d2fa7e11572"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("82504d35-ffec-4425-8cea-3898920c6500"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("827490f7-9953-46e1-962f-b8b68d4d88f8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8443322c-e184-4b92-8247-cd19fb2f5926"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("84f3a6fb-e48b-408c-b3b0-b1bf5749ff9d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8874fa9e-3c74-4869-a5fc-7920065afe2b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("88fa4d93-8089-4086-a218-800780c6e0a6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("89291fe1-6390-4502-99fc-b975e1ef2b2f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8949a2bc-938e-4363-aab7-af884ba2cc8d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8b09c64b-925f-4a0c-8434-d7a47ba7c9f0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8d52d12d-a350-402e-bfa4-409afdccf6ba"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8e16678f-50d3-458a-8c2a-d57046859399"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("91296344-06c9-4f16-84c6-6fdf65335bb6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("91a0c970-d8c5-4605-9c30-06a73470c0b8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("937b3ba5-030c-4908-8673-bb3fc32a9de0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("95706dec-c38f-46d7-b8e1-5cd54bb362a4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("98ca7137-1c31-4d87-83b8-de43767e5739"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9ad20669-1a0d-4060-b835-cf10ea25846e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9f028534-ae62-497e-9fed-1dd1e1eb6003"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a0991c64-53a8-4594-bfec-135558905499"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a2ba318f-8026-4571-9eb3-e7085b33691e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a416b65a-c603-4634-a9b9-f426062ad46a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a43d2ab2-a484-47f3-a4fa-81ad188deba2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a4d0dc47-8b1f-4961-b947-36ff7288efcc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a6589029-a7c2-4d79-8a4b-feb364240402"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a6877f0e-3a47-436a-bdaf-fb999665dd3e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aca6ee69-c57a-4bc5-bb86-91b0be4bf6bc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("acae45de-27bd-4970-b1f4-41b25e1de14d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aeb67f1b-a4da-40cb-8f98-a458c9f55b67"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("afd1d751-cfa0-4c90-8edb-0aa3e49bf593"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b22866dc-c0d1-4913-b044-1b62c4a48aa9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b396851e-f5c4-491c-b33c-4a2b9d259f59"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b6d2e2c1-f296-4840-9bee-57dc39699187"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b85fe3d6-cc1b-468f-82dd-972d20a7c4ae"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b96bb689-5341-4656-b177-e78bc3afb057"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b9b1b516-b07a-42ec-ad60-733dc6c45cfa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ba01b2f4-1873-4244-a74f-df095a89288d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bab64e08-fa5d-4ba7-acaa-cb4471582dfa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bb0c88d8-0c0e-44ae-89c5-5a41c8c2a91f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bbb475a4-3cd3-46d5-90ca-c0100b0feaa7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bcdd9291-adac-4efd-bfa5-a8dca28050b1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bdd2791a-1392-4b11-81fe-7e1aa34b0e82"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("be9e57e4-3bb6-4bf2-829e-697662e67f93"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bf96575e-55f9-49e6-9c05-12c0811473c3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bfbbd5d2-6472-4294-9916-599b62869543"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c0b7d5be-bfb5-4d9a-a789-0169adc88cc2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c0bcd7cb-aa7a-4c7f-ac6c-80470f85bf5d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c0cae5e7-808c-4182-b6c0-c1394d3ed62c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c150c17d-e9fa-41ad-8910-5d7a59b4af65"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c542607c-692a-4d0a-9300-725abd0209a1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c5abc616-93c2-41cc-810a-900397f5de07"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c6631b64-ab85-44bd-97da-e8278adeb9c3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c9416dab-0834-4223-8763-28f28c1a12df"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c97db69d-a821-4d7d-860e-11c70c71b63e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cbbdac3c-905c-445b-9fb1-da0d2a39e777"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ced0358b-0fc6-4b98-a3e7-02ef5a74eaf1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cf60dd0f-600f-4578-885d-168a76709900"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d0bca771-c707-4fac-a0ff-aa1637a03770"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d1ce6b5f-8c09-4490-9d49-20c9f38b65c8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d28a0b5e-4488-41a1-9179-fc5b90f0bf9c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d468b4f4-6a5d-465a-a9c1-bdba0c65f3cc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d578d5ef-e0aa-44d4-aa5f-da8e813af28d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d5c092a2-d1fa-45c6-a1b8-2b4b679db8a5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dd5833f5-0336-4d95-8b4d-9c32012d43a8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dddb1661-58d2-4a6c-bd15-baa000b3acaa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("de7172f8-a86d-4661-a294-3bb01d0c480b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e0433a6e-8d3c-4af2-9406-4e05691edb2c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e25c0638-5c54-48aa-8e47-ac88817fbd04"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e3f4c5c4-5045-4b47-891f-7900be1df418"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e6b6fb80-55be-44fe-9cfb-86d52b37beab"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e8a44153-fb86-4ba7-94e0-b1dd3993b159"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ea5f97c1-3409-4f2e-b347-5a548e408e4a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("eb409a79-81d4-47ed-b195-17e073f9e105"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ebdb080a-035b-4988-ae99-1d5b386de4ea"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ecd04814-070f-4e48-bf2b-aa1583ce3bbe"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("eefa3873-9f78-4674-a84f-8338eb0b3048"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ef8c0601-6a41-4486-97b3-e05985e08baf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("efb11127-78f5-4b4f-bdb9-3736d0645f7c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("eff648dc-56a5-4771-b8e9-6d279957646f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f165240a-53f4-4578-8e06-1612896e4175"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f327c959-b080-420e-a28e-9fbc7c0e707d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f3960bfb-a2f6-45d1-963c-a9998b53ad6a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f5f41fbc-9331-4565-8520-d7f80cbec9e5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f66b07bf-f62f-4ce5-aeda-3cb2492ddc32"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f9447469-b2bd-4625-9eb4-705773e3d55e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fad8349b-1275-4e48-8e33-a61e3e0c7ff4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fd4129ab-e30c-4372-884a-33f8ce3786ad"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fe390b3a-ef20-48d2-a5d2-fbfb9323ada4"));

            migrationBuilder.AddColumn<int>(
                name: "ArmorClass",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxModifier",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinStrength",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Modifier",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "StealthDisadvantage",
                table: "Items",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("123d422b-917b-4855-b01a-53a79bbfb2bc"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(987), "Sempre que você \r\nrealizar um teste de Inteligência (História) relacionado à \r\norigem de um trabalho em pedra, você é considerado \r\nproficiente na perícia História e adiciona o dobro do seu \r\nbônus de proficiência ao teste, ao invés do seu bônus de \r\nproficiência normal.", "Especialização em Rochas", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(987) },
                    { new Guid("20ec07c3-e22d-4864-9e3b-ee066d59d8fc"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1008), "Você possui vantagem em todos \r\nos testes de resistência de Inteligência, Sabedoria e \r\nCarisma contra magia.", "Esperteza Gnômica", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1008) },
                    { new Guid("214ce33e-c62a-4376-a254-a8941bd5a4cd"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1021), "Você conhece o truque \r\ntaumaturgia. Quando você atingir o 3° nível, você poderá \r\nconjurar a magia repreensão infernal como uma magia de \r\n2° nível. Quando você atingir o 5° nível, você também \r\npoderá conjurar a magia escuridão. Você precisa terminar \r\num descanso longo para poder usar as magias desse traço \r\nnovamente. Sua habilidade de conjuração para essas \r\nmagias é Carisma.", "Legado Infernal", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1021) },
                    { new Guid("2386bf94-1a8c-40d8-a364-5b3b1df90c2b"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(998), "Você possui \r\ndesvantagem nas jogadas de ataque e testes de Sabedoria \r\n(Percepção) relacionados a visão quando você, o alvo do \r\nseu ataque, ou qualquer coisa que você está tentando \r\nperceber, esteja sob luz solar direta.", "Sensibilidade à Luz Solar", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(998) },
                    { new Guid("25e7f7d4-ab1c-41b0-ab36-c91e751c63c3"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1017), "Quando você atinge um ataque \r\ncrítico com uma arma corpo-a-corpo, você pode rolar um \r\ndos dados de dano da arma mais uma vez e adicioná-lo ao \r\ndano extra causado pelo acerto crítico.", "Ataques Selvagens", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1017) },
                    { new Guid("2f91c8bf-2592-45e1-8bc0-41426181100b"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1004), "Você pode usar uma ação para \r\nexalar energia destrutiva. Seu ancestral dracônico \r\ndetermina o tamanho, formado e tipo de dano que você \r\nexpele. \r\nQuando você usa sua arma de sopro, cada criatura na \r\nárea exalada deve realizar um teste de resistência, o tipo \r\ndo teste é determinado pelo seu ancestral dracônico. A CD \r\ndo teste de resistência é 8 + seu modificador de \r\nConstituição + seu bônus de proficiência. Uma criatura \r\nsofre 2d6 de dano num fracasso e metade desse dano num \r\nsucesso. O dano aumenta para 3d6 no 6° nível, 4d6 no 11° \r\nnível e 5d6 no 16° nível. \r\nDepois de usar sua arma de sopro, você não poderá \r\nutilizá-la novamente até completar um descanso curto ou \r\nlongo.", "Arma de Sopro", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1004) },
                    { new Guid("2ffd0c6f-6d47-420b-a285-249a0422dfc4"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(986), " Você possui vantagem em testes de \r\nresistência contra venenos e resistência contra dano de \r\nveneno.", "Resiliência Anã", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(986) },
                    { new Guid("3949eb61-c04d-4141-ab38-b639f3fae0df"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1013), "Toda vez que você fizer \r\num teste de Inteligência (História) relacionado a itens \r\nmágicos, objetos alquímicos ou mecanismos tecnológicos, \r\nvocê pode adicionar o dobro do seu bônus de proficiência, \r\nao invés de qualquer bônus de proficiência que você \r\nnormalmente use.", "Conhecimento de Artífice", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1013) },
                    { new Guid("41326394-408d-4e9e-8d43-a2dd1a16e2f4"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1007), "Você possui resistência ao tipo \r\nde dano associado ao seu ancestral dracônico.", "Resistência a Dano", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1007) },
                    { new Guid("6310eb13-2bb5-4ee9-b98c-63c7ff8fc5ed"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(988), "Você tem proficiência na perícia \r\nPercepção.", "Sentidos Aguçados", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(988) },
                    { new Guid("7369eef0-70dc-493c-859f-4c03432f6721"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1016), "Quando você é reduzido a \r\n0 pontos de vida mas não é completamente morto, você \r\npode voltar para 1 ponto de vida. Você não pode usar essa \r\ncaracterística novamente até completar um descanso \r\nlongo.", "Resistência Implacável", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1016) },
                    { new Guid("8cc2332c-3c44-49c1-89e6-d3ce71de7451"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1012), "Através de sons e \r\ngestos, você pode comunicar ideias simples para Bestas \r\npequenas ou menores. Gnomos da floresta amam os \r\nanimais e normalmente possuem esquilos, doninhas, \r\ncoelhos, toupeiras, pica-paus e outras criaturas como \r\namados animais de estimação.", "Falar com Bestas Pequenas", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1012) },
                    { new Guid("9fe3f4eb-ee85-49c2-8081-a96c704cba5e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1001), "Você tem vantagem em testes de resistência \r\ncontra ficar amedrontado. ", "Bravura", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1001) },
                    { new Guid("a8699677-e958-4645-8718-6e85012236f5"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(993), "Elfos não precisam dormir. Ao invés disso, \r\neles meditam profundamente, permanecendo \r\nsemiconscientes, durante 4 horas por dia. (A palavra em \r\nidioma comum para tal meditação é \"transe\".) Enquanto \r\nmedita, um elfo é capaz de sonhar de certo modo. Esses \r\nsonhos na verdade são exercícios mentais que se tornam \r\nreflexos através de anos de prática. Depois de descansar \r\ndessa forma, você ganha os mesmos benefícios que um \r\nhumano depois de 8 horas de sono. ", "Transe", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(993) },
                    { new Guid("af629e9a-8659-4b1a-a6da-41f13def9bfd"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1014), "Você possui proficiência com \r\nferramentas de artesão (ferramentas de engenhoqueiro). \r\nUsando essas ferramentas, você pode gastar 1 hora e 10 \r\npo em materiais para construir um mecanismo Miúdo (CA \r\n5, 1 pv). O mecanismo para de funcionar após 24 horas (a \r\nnão ser que você gaste 1 hora reparando-o para manter o \r\nmecanismo funcionando), ou quando você usa sua ação \r\npara desmantelá-lo; nesse momento, você pode recuperar \r\no material usado para criá-lo. Você pode ter até três\r\n desses mecanismos ativos ao mesmo tempo.", "Engenhoqueiro", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1014) },
                    { new Guid("bb56c1c6-17c3-45f8-8370-28e7d3fbdb12"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(984), "Acostumado à vida subterrânea, \r\nvocê tem uma visão superior no escuro e na penumbra. \r\nVocê enxerga na penumbra a até 18 metros como se fosse \r\nluz plena, e no escuro como se fosse na penumbra. Você \r\nnão pode discernir cores no escuro, apenas tons de cinza.", "Visão no Escuro", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(984) },
                    { new Guid("cacec0bf-d587-4a79-8b96-ef44112fed0e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1020), "Você possui resistência a dano \r\nde fogo.", "Resistência Infernal", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1020) },
                    { new Guid("d076e38c-e9e8-4d98-b7dc-34587b095ee6"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1002), "Você pode mover-se através do \r\nespaço de qualquer criatura que for de um tamanho maior \r\nque o seu.", "Agilidade Halfling", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1002) },
                    { new Guid("d74ff7fa-6bdc-4fac-92b5-e689655b783d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1000), "Quando você obtiver um 1 natural em uma \r\njogada de ataque, teste de habilidade ou teste de \r\nresistência, você pode jogar de novo o dado e deve utilizar \r\no novo resultado.", "Sortudo", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1000) },
                    { new Guid("da4222f4-510c-4874-be70-6a1b32cec63a"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(994), "Você pode tentar se esconder \r\nmesmo quando você está apenas levemente obscurecido  \r\npor folhagem, chuva forte, neve caindo, névoa ou outro \r\nfenômeno natural.", "Máscara da Natureza", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(994) },
                    { new Guid("db574b85-9e05-42ef-b6d7-321467d6b88f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(990), "Você tem vantagem nos testes de \r\nresistência para resistir a ser enfeitiçado e magias não \r\npodem colocá-lo para dormir.", "Ancestral Feérico", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(990) },
                    { new Guid("e37aa725-9836-457c-8a1c-c4f7f589a9d9"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(999), "Você possui o truque globos de luz. \r\nQuando você alcança o 3° nível, você pode conjurar a \r\nmagia fogo das fadas. Quando você alcança o 5° nível, \r\nvocê pode conjurar escuridão. Você precisa terminar um \r\ndescanso longo para poder conjurar as magias desse traço \r\nnovamente. Carisma é sua habilidade chave para \r\nconjurar essas magias.", "Magia Drow", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(999) },
                    { new Guid("efc71688-bbd6-4c53-b071-485876afb08d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1011), "Você conhece o truque ilusão \r\nmenor. Inteligência é a sua habilidade usada para \r\nconjurá-la.", "Ilusionista Nato", new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(1011) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("007bb7dd-e4fb-4f5a-9a88-94baba2e1b6b"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(458), 0, 1, "Armas Marciais à Distância", 1, 1, 0, "Zarabatana", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(458), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("0113da7e-ea47-49f7-a459-5308c7de1d6f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(847), 0, "", 4, "Ferramentas de Carpinteiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(847), 8.0, 3.0 },
                    { new Guid("0382a7a6-2622-45ec-adda-2dd35afdf759"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(615), 0, "", 4, "Totem", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(615), 1.0, 0.0 },
                    { new Guid("072ee076-09ed-4029-b09d-fb643d5b1fb7"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(887), 0, "", 4, "Trombeta", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(887), 3.0, 1.0 },
                    { new Guid("07b5194c-d08a-4a88-a52d-ee08bbc01193"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(605), 0, "", 4, "Cajado", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(605), 5.0, 2.0 },
                    { new Guid("07c9376f-117d-45fe-8e81-91e3854456ab"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(666), 2, "", 4, "Piton", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(666), 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("0812e309-16dd-4dfe-878c-294e41a63ee5"), 2, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(819), 0, "Um personagem que beber o líquido\r\nvermelho mágico deste frasco recupera 2d4+2 pontos de\r\nvida. Beber ou administrar uma poção exige uma ação.", 4, 2, 0, 2, "Poção de Cura", 2, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(819), 50.0, 0.25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("0a2b07fd-e54d-46b5-b44d-7562902723cc"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(420), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Espada Curta", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(420), 10.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("0b1bc650-91c8-4e37-96c6-a041e09a4e19"), 14, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9979), 0, "Feita de couro com pesados anéis presos a ela. Os anéis ajudam a reforçar a armadura contra golpes de espadas e machados. A cota de anéis é inferior à cota de malha e geralmente é vestida apenas por aqueles que não podem pagar por uma armadura melhor.", 1, 0, 0, null, "Cota de anéis", true, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9979), 30.0, 20.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("0c5f4c08-bed8-447d-94e3-f05060817ff5"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(508), 0, "Usando uma ação, você pode espalhar o \r\nconteúdo desse frasco em uma criatura a até 1,5 metro de \r\nvocê ou arremessar a até 6 metros, quebrando o frasco \r\ncom o impacto. Em ambos os casos, você deve realizar um \r\nataque à distância contra uma criatura alvo, tratando a \r\nágua benta como uma arma improvisada. Se o alvo for um \r\ncorruptor ou morto-vivo, ele sofre 2d6 de dano radiante. ", 4, "Água benta (frasco)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(508), 25.0, 0.5 },
                    { new Guid("103ffa9d-260e-40f4-8905-6d9003b5bda8"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(888), 0, "", 4, "Violino", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(888), 30.0, 3.0 },
                    { new Guid("12bca794-5922-4aec-8226-6bac7aefa7eb"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(584), 2, "", 4, "Caneta tinteiro", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(584), 2.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("13cb958b-390d-4202-a11f-831cb2295841"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(413), 2, 1, "Armas Simples à Distância", 1, 4, 0, "Dardo", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(413), 5.0, 0.10000000000000001 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("142a100c-59a0-45e8-93e7-a61d1615615d"), 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(821), 0, "Você pode usar o veneno contido\r\nnesse vidro para cobrir a lâmina de uma arma cortante ou\r\nperfurante ou até três peças de munição. Aplicar o veneno\r\nleva uma ação. Uma criatura atingida pela arma ou\r\nmunição envenenada deve obter sucesso em um teste de\r\nresistência de Constituição CD 10 ou sofrerá 1d4 de dano\r\nde veneno. Uma vez aplicado, o veneno retém sua\r\npotência durante 1 minuto antes de secar.", 4, 1, 1, 2, "Veneno básico (frasco)", 2, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(821), 100.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("1682cd41-75ca-4ae9-bbe6-f48afb7f6c3e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(439), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Mangual", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(439), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("17b74aab-9e38-476c-928b-c56a9e1317de"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(879), 0, "", 4, "Flauta de Pã", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(879), 12.0, 1.0 },
                    { new Guid("18e15a4c-95cf-440d-b0f7-89b87246ac39"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(868), 0, "", 4, "Suprimentos de Alquimista", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(868), 50.0, 4.0 },
                    { new Guid("1a074912-a474-4667-a240-09d7a361fdaa"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(585), 1, "", 4, "Cantil", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(585), 2.0, 2.5 },
                    { new Guid("1a9da49f-bd66-49c0-99e8-414728754bc7"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(651), 1, "Geralmente vem em um frasco de argila que \r\ncontém 500 ml. Usando uma ação, você pode espirrar o \r\nóleo desse frasco em uma criatura a até 1,5 metro de você\r\nou arremessar a até 6 metros, quebrando-o com o \r\nimpacto. Você deve realizar um ataque à distância contra \r\numa criatura ou objeto, tratando o óleo como uma arma \r\nimprovisada. Com um sucesso, o alvo é coberto de óleo. Se \r\no alvo sofrer qualquer dano flamejante antes do óleo secar\r\n (depois de 1 minuto), a criatura sofre 5 de dano \r\nflamejante adicional pela queima do óleo. Você também \r\npode derramar um frasco de óleo no chão para cobrir uma \r\nárea de um quadrado de 1,5 metro de lado, desde que a \r\nsuperfície esteja nivelada. Se aceso, o óleo queima por 2 \r\nrodadas e causa 5 de dano flamejante a qualquer criatura \r\nque entrar na área ou terminar seu turno dentro da área. \r\nUma criatura pode sofrer esse dano apenas uma vez por \r\nturno.", 4, "Óleo (frasco)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(651), 1.0, 0.5 },
                    { new Guid("1b0a98b7-02a4-4bc7-b8d0-326fb7398321"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(625), 2, "", 4, "Jarra", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(625), 4.0, 2.0 },
                    { new Guid("1feadc9f-ade2-4217-8c54-aee21abc33f7"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(865), 0, "", 4, "Ferramentas de Sapateiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(865), 5.0, 2.5 },
                    { new Guid("21c4680d-43fb-46ba-a3aa-57f63144ca5b"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(647), 0, "", 4, "Virotes (20)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(647), 1.0, 0.75 },
                    { new Guid("2256ae0e-25e8-4693-9406-ce0487ea1372"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(698), 0, "", 4, "Tinta (frasco de 30ml)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(698), 10.0, 0.0 },
                    { new Guid("25354b60-d81b-47db-8ca8-24efab6ae614"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(633), 0, "Essa lente permite ver pequenos \r\nobjetos mais de perto. Ela também é útil como um \r\nsubstituto da pederneira e isqueiro para acender fogo. \r\nUsar uma lupa para acender fogo necessita de luz tão \r\nbrilhante como a luz do sol para focar, um pavio e cerca \r\nde 5 minutos. Uma lente de aumento concede vantagem \r\nem qualquer teste de habilidade feito para avaliar ou \r\ninspecionar um item que é pequeno ou muito detalhado.", 4, "Lente de aumento", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(633), 100.0, 0.0 },
                    { new Guid("26036e97-bf8c-4ef6-af9b-30171e08dd6d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(613), 0, "", 4, "Cajado de madeira", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(613), 5.0, 2.0 },
                    { new Guid("293cdf5b-0c8a-4470-844e-d56060579d34"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(632), 0, "Uma lanterna furta-fogo \r\nlança luz plena em um cone de 18 metros e penumbra por \r\nmais 18 metros. Uma vez acesa, ela queima por 6 horas \r\nusando um frasco de óleo (500 ml).", 4, "Lanterna furta-fogo", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(632), 10.0, 1.0 },
                    { new Guid("2a339aed-ac68-4f5e-a543-5f03ede845db"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(507), 0, "", 4, "Ácido (vidro)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(507), 25.0, 0.5 },
                    { new Guid("2b32fca3-6cd5-44df-8fff-00de578bdff5"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(869), 0, "", 4, "Suprimentos de Cervejeiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(869), 20.0, 4.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2c457a27-622d-44ea-b69d-f09deda4adab"), 16, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9981), 0, "Feita de anéis de metal entrelaçados, a cota de malha inclui uma camada de tecido acolchoado usada por baixo da malha de metal para evitar atrito e amortecer o impacto dos golpes. O conjunto inclui manoplas.", 1, 0, 13, null, "Cota de malha", true, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9981), 75.0, 27.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2d91d22c-8e50-41b2-a24c-c1a5c5994d14"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(446), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Rapieira", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(446), 25.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2da6ebc2-50ac-4f11-84c3-d5602f50413d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(634), 0, "Um livro pode conter poesia, relatos históricos, \r\ninformações relativas a um campo particular de \r\nsabedoria, diagramas e notas sobre engenhocas gnômicas, \r\nou qualquer outra coisa que possa ser representada \r\nusando texto ou imagens.", 4, "Livro", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(634), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2db0295a-722f-46de-b5aa-e652a82fa792"), 15, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9978), 0, "Composta de placas de metal moldadas que cobrem a maior parte do corpo. Ela não inclui proteção para as pernas além de caneleiras fixadas com tiras de couro.", 1, 2, 0, 1, "Meia-Armadura", true, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9978), 750.0, 20.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("2de96a0e-812b-4f42-9550-4af43499ea86"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(852), 0, "", 4, "Ferramentas de Costureiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(852), 1.0, 2.5 },
                    { new Guid("2e1d23a7-10ee-43d8-ad8c-83a7c2c71335"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(853), 0, "", 4, "Ferramentas de Coureiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(853), 5.0, 2.5 },
                    { new Guid("2ea1454a-4b07-4256-a22e-7665a338532f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(577), 0, "", 4, "Barril", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(577), 2.0, 35.0 },
                    { new Guid("2f6fe754-1ffc-4cec-a031-630fa0caef8e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(871), 0, "", 4, "Utensílios de Cozinheiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(871), 1.0, 4.0 },
                    { new Guid("2fb39876-a559-4bad-9628-9a2be04ce8eb"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(692), 0, "", 4, "Sino", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(692), 1.0, 0.0 },
                    { new Guid("30e0c2b8-fef9-4d16-bd62-40e2b6247994"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(641), 0, "", 4, "Martelo", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(641), 1.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3575a594-9b67-4ad7-9425-d3781ce12305"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(425), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Espada Longa", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(425), 15.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3a7bbbf8-eee2-45cf-a56c-074fd89922b5"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(619), 0, "", 4, "Garrafa de vidro", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(619), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3b6d8a28-bdca-48e4-9907-97289d498ace"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(423), 0, 0, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Espada Grande", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(423), 50.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3b98a9db-d972-4e55-a8f1-ea3b6b88ea6e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(674), 0, "", 4, "Robes", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(674), 1.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3c13ea34-c49c-4460-9305-bd117839aa85"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(403), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Maça", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(403), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3eb4a63f-6a4e-474f-ba78-57017947d08f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(595), 1, "", 4, "Escada (3 metros)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(595), 1.0, 12.5 },
                    { new Guid("3f85f1aa-b2f6-46a4-bacc-85e203fcba7f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(864), 0, "", 4, "Ferramentas de Pintor", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(864), 10.0, 2.5 },
                    { new Guid("400de40b-9e17-4c9f-a54d-103c7d5c4437"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(873), 0, "Esse conjunto de instrumentos é usado para navegação no mar. \r\nProficiência com as ferramentas de navegador permite \r\ntraçar um curso de navio e seguir cartas de navegação. \r\nAlém disso, essas ferramentas permitem que você \r\nadicione seu bônus de proficiência para qualquer teste de \r\nhabilidade que fizer para não se perder no mar. ", 4, "Ferramentas de navegação", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(873), 25.0, 1.0 },
                    { new Guid("445c7b9c-adb3-48ad-90d8-2414bf9aa2d0"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(899), 0, "", 4, "Jogo dos Três Dragões", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(899), 5.0, 0.0 },
                    { new Guid("457da730-f083-46b1-92f4-486150728a57"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(511), 0, " Essas algemas de metal podem prender \r\numa criatura Pequena ou Média. Escapar das algemas \r\nexige sucesso em um teste de Destreza CD 20. Quebrá-las \r\nexige um teste de Força CD 20 bem sucedido. Cada \r\nconjunto de algemas vem com uma chave. Sem a chave, \r\numa criatura proficiente com ferramentas de ladrão pode \r\nabrir a fechadura das algemas com um sucesso em um \r\nteste de Destreza CD 15. As algemas têm 15 pontos de \r\nvida. ", 4, "Algemas", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(511), 2.0, 2.0 },
                    { new Guid("4929a46f-d835-4e31-8f4e-af7f725669dd"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(691), 0, "", 4, "Sinete", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(691), 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4939f281-9f50-4fe4-8009-d834c0e74666"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(412), 0, 1, "Armas Simples à Distância", 1, 8, 0, "Besta Leve", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(412), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4a5b302a-33c1-427e-939d-728eb258751c"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(610), 0, "", 4, "Varinha", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(610), 10.0, 0.5 },
                    { new Guid("4ad3db25-0b6d-42cb-9504-600a111d02f8"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(637), 0, "Objetos vistos através de uma luneta são \r\nampliados até o dobro do seu tamanho.", 4, "Luneta", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(637), 1000.0, 0.5 },
                    { new Guid("5232401f-0e0f-4250-b24b-93115bcc5c32"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(653), 0, "", 4, "Pá", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(653), 2.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("52556a0e-a51a-4871-b89f-89af63652a5f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(453), 0, 1, "Armas Marciais à Distância", 1, 10, 0, "Besta Pesada", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(453), 50.0, 4.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("5597f835-7c27-4b64-b574-26c0e92f4e81"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(581), 1, "Esse pequeno recipiente detém uma \r\npederneira, isqueiro e um pavio (um pano geralmente \r\nseco embebido em óleo) usado para acender uma fogueira. \r\nUsá-lo para acender uma tocha – ou qualquer outra coisa \r\nexposta a um combustível abundante – leva uma ação. \r\nAcender qualquer outro fogo leva 1 minuto.", 4, "Caixa de Fogo", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(581), 5.0, 0.5 },
                    { new Guid("55a6720b-c1a3-40b0-8c97-e428e050dd4f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(606), 0, "", 4, "Cristal", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(606), 10.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5623044b-8aa1-4330-b875-cd22d6dde078"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(404), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Machadinha", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(404), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("564fe2a9-464e-4f33-af36-4e164d3345b0"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(669), 0, "", 4, "Pregos de ferro (10)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(669), 1.0, 2.5 },
                    { new Guid("573bf14d-1464-42a4-b14d-894daa78ff87"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(516), 0, "Uma aljava pode guardar até 20 flechas.", 4, "Aljava", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(516), 1.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5995001d-adad-45ad-9a92-93a52fd5f2d1"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(410), 0, 1, "Armas Simples à Distância", 1, 6, 0, "Arco Curto", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(410), 25.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5a3ded48-6b3d-48b7-89d1-cec17b888bb8"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(579), 0, "", 4, "Baú", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(579), 5.0, 12.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5bb0e2d8-837f-47cb-b5cc-5b9efe0937ea"), 14, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9975), 0, "Constituída por um peitoral de metal usado com couro flexível em seu interior. Embora ele deixe as pernas e braços do usuário relativamente desprotegidos, essa armadura fornece boa proteção para seus órgãos vitais, deixando quem a usa relativamente sem restrições.", 1, 2, 0, 1, "Peitoral", false, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9975), 400.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("5c58ba40-dd5c-4aaa-b249-aae359d84226"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(646), 0, "", 4, "Flechas (20)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(646), 1.0, 0.5 },
                    { new Guid("5debb34f-f7b8-4bec-b8eb-85ddf4b6cb1e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(640), 0, "", 4, "Marreta", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(640), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5e8b8162-5647-4e3f-a37e-fccd18972fe6"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(414), 1, 2, "Armas Simples à Distância", 1, 4, 0, "Funda", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(414), 1.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5eed7efe-0506-42fb-9476-ba8f0b07474d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(664), 0, "", 4, "Picareta de minerador", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(664), 2.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("65fa92f5-5822-4ffc-9bae-2f83653f760b"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(407), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Porrete", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(407), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("667a485b-073f-47b3-9639-54ee4e25d081"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(650), 0, "", 4, "Zarabatana (50)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(650), 1.0, 0.5 },
                    { new Guid("67dcf077-51c4-458b-8031-75d1b774deb9"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(645), 2, "", 4, "Balas de Funda (20)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(645), 4.0, 0.75 },
                    { new Guid("682eb383-94bc-4bff-8ad7-f8b74911f126"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(580), 0, "Trata-se de uma pequena \r\nbolsa de couro à prova d'água que pode ser fixada em um \r\ncinto. Ela possui compartimentos para armazenar todos \r\nos componentes materiais e outros itens especiais que \r\nvocê precisa para lançar suas magias, exceto os \r\ncomponentes que possuem um custo específico (conforme \r\nindicado na descrição da magia).", 4, "Bolsa de componentes", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(580), 25.0, 1.5 },
                    { new Guid("69f9a1ec-929a-43fd-9ff3-98e22dc818d9"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(593), 0, "Uma corrente possui 10 pontos de vida e \r\npode ser arrebentada com um teste de Força CD 20 bem \r\nsucedido.", 4, "Corrente (3 metros)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(593), 5.0, 5.0 },
                    { new Guid("6d1497f2-4985-41a6-89d3-5a23700828cb"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(890), 0, "", 4, "Xilofone", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(890), 25.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6dc6439a-2b34-4dde-b230-904c8c4130bb"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(397), 1, 1, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Azagaia", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(397), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("758104b1-bca9-415b-b208-bcd3aa9c6ac0"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(686), 0, "", 4, "Saco de dormir", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(686), 1.0, 3.5 },
                    { new Guid("77ee4739-3f88-402b-aff4-37a37ed8536f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(896), 1, "", 4, "Conjunto de Dados", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(896), 1.0, 0.0 },
                    { new Guid("79424bbb-f019-4a4e-a6aa-31717a37c686"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(882), 0, "", 4, "Lira", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(882), 30.0, 1.0 },
                    { new Guid("7c37f207-ec87-4e4a-85f8-d89f55699ce7"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(687), 0, "", 4, "Amuleto", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(687), 5.0, 0.5 },
                    { new Guid("7ce5c1f8-2f22-452c-88d1-7da24145887f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(856), 0, "", 4, "Ferramentas de Ferreiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(856), 20.0, 4.0 },
                    { new Guid("7db12ce6-e5cb-46f4-8618-75f40b163801"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(588), 1, "", 4, "Cesto", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(588), 4.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("82866c60-998f-4ea2-a2ce-4e72411c97f0"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(429), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 12, 0, "Lança de Montaria", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(429), 10.0, 3.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("840f36c6-7372-4bbe-9c9b-624b7e32489b"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(857), 0, "", 4, "Ferramentas de Funileiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(857), 50.0, 5.0 },
                    { new Guid("840f6513-5f92-486c-9955-88ce3e9134f0"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(878), 0, "", 4, "Flauta", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(878), 2.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("859f98ee-6b40-4a71-98bc-e0d374674203"), 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(49), 0, "Feito de madeira ou metal e é usado com uma mão. Empunhar um escudo aumenta sua Classe de Armadura em 2. Você só pode se beneficiar de um escudo por vez.", 1, 2, 0, null, "Escudo", true, 1, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(49), 10.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("85c2292c-7849-4750-af5c-7fa733f2242e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(432), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Maça Estrela", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(432), 15.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("86644323-6cae-49f8-ae42-ede3d28584c8"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(521), 0, " Você pode usar um aríete portátil \r\npara quebrar portas. Ao fazer isso, você ganha um bônus \r\nde +4 no teste de Força. Outra criatura pode ajudá-lo a \r\nusar o aríete, o que concede vantagem no teste.", 4, "Ariete portátil", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(521), 4.0, 17.5 },
                    { new Guid("8791d835-47bb-44b5-9755-5ef8fdc3443b"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(597), 0, "Usando uma ação, você pode \r\ndespejar essas minúsculas esferas de metal para cobrir a \r\nárea de um quadrado de 3 metros de lado. A criatura que \r\nse mover dentro da área deve ser bem sucedida em um \r\nteste de resistência de Destreza CD 10 para não cair no \r\nchão. Uma criatura que mover pela área usando metade \r\ndo seu deslocamento não precisa fazer o teste de \r\nresistência.", 4, "Esferas (sacola com 1.000)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(597), 1.0, 1.0 },
                    { new Guid("87c8514e-d6ec-4de6-b228-2e19041790f0"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(662), 0, "", 4, "Perfume (frasco)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(662), 5.0, 0.0 },
                    { new Guid("87e5356b-e551-4baf-841c-fec40897d117"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(590), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de cânhamo (15 metros)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(590), 1.0, 5.0 },
                    { new Guid("8824b78f-15da-40c4-82b9-7faf0c35eebc"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(582), 2, "", 4, "Caneca", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(582), 2.0, 0.5 },
                    { new Guid("883b4e16-4852-451a-8494-fe4a2bf2eb6c"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(858), 0, "", 4, "Ferramentas de Joalheiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(858), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("883f3820-48c4-4cdf-b2a8-a878d008dfce"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(416), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Alabarda", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(416), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8a16bdf1-da27-49ef-ab85-281cc685d00f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(523), 0, "", 4, "Arpéu", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(523), 2.0, 2.0 },
                    { new Guid("8caf5a14-dccb-48f9-91a7-6842c23192b3"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(656), 1, "", 4, "Parafina", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(656), 5.0, 0.0 },
                    { new Guid("8e4442d6-450c-4d9c-bba7-f8c08173c1ba"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(700), 2, "Por uma hora, a vela emana luz plena em um \r\nraio de 1,5 metro e penumbra por mais 1,5 metro.", 4, "Vela", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(700), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("91aa5e98-b9dc-4ed6-af73-92f0659a6fd5"), 11, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9932), 0, "Consiste em camadas de panos acolchoados e batidos.", 1, 0, 0, 1, "Acolchoada", true, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9932), 5.0, 4.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("91b2c8e5-4d57-4d02-8c57-cc014d5b339d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(642), 0, "", 4, "Mochila", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(642), 2.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("91c77b45-b31a-4bc3-831f-47cb09d5414f"), 2, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(823), 0, "Esse líquido pegajoso e adesivo\r\ninflama em contado com o ar. Usando uma ação, você\r\npode arremessar esse frasco a até 6 metros de distância,\r\nquebrando-o com o impacto. Você deve realizar um ataque\r\nà distância contra uma criatura ou objeto, tratando o fogo\r\nalquímico como uma arma improvisada. Em um sucesso,\r\no alvo sofre 1d4 de dano de fogo no início de cada um de\r\nseus turnos. Uma criatura pode terminar esse dano\r\nusando sua ação e fazendo um teste de Destreza CD 10\r\npara apagar as chamas.", 4, 2, 0, 2, "Fogo alquímico (frasco)", 2, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(823), 50.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("920879a1-442e-4e5c-95cc-b492948c58bf"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(881), 0, "", 4, "Gaita de Foles", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(881), 30.0, 3.0 },
                    { new Guid("929215f9-11f4-4022-a451-6b2aa3d1a12c"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(671), 1, "Consistem em alimentos desidratados adequados para viagens longas, \r\nincluindo carne seca, frutas secas, bolachas e nozes. ", 4, "Rações de viagem (1 dia)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(671), 5.0, 1.0 },
                    { new Guid("929d7b62-e9c1-4c28-8cc9-c56506c92a64"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(594), 0, "Este kit inclui uma vara \r\nde pesca de madeira, linha de seda, boias de cortiça, \r\nanzóis de aço, chumbadas, iscas e redes de pesca.", 4, "Equipamento de pescaria", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(594), 1.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("92f2b374-2efc-4842-a8d1-c40648c28e2f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(405), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Martelo Leve", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(405), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("93357900-e835-4b5b-9ece-bf4e5f901c8a"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(628), 0, "Esse kit é uma bolsa de \r\ncouro contendo ataduras, pomadas e talas. O kit possui \r\nmaterial suficiente para dez usos. Usando uma ação, você \r\npode gastar um uso do kit para estabilizar uma criatura \r\nque tenha 0 pontos de vida, sem a necessidade de realizar \r\num teste de Sabedoria (Medicina).", 4, "Kit de primeiros-socorros", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(628), 5.0, 1.5 },
                    { new Guid("95120eed-34ff-4b37-8141-908d98ff75ed"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(576), 2, "", 4, "Balde", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(576), 5.0, 1.0 },
                    { new Guid("95c8e236-49b4-4113-8169-1b512f5d3a86"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(519), 0, "", 4, "Apito de advertência", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(519), 25.0, 0.5 },
                    { new Guid("966c517c-fb35-40fa-87b2-36e2f33e70dd"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(522), 0, "Quando você usa sua ação para \r\narmá-la, essa armadilha forma um anel de aço com \r\ndentes serrilhados. Eles se fecham quando uma criatura \r\npisa sobre uma placa de pressão no seu centro. A \r\narmadilha é fixada por uma pesada corrente em um \r\nobjeto fixo e imóvel, como uma árvore ou um cravo \r\nenterrado no chão. Uma criatura que pisar na placa de \r\npressão deve ser bem sucedida em um teste de resistência \r\nde Destreza CD 13 ou sofrerá 1d4 de dano perfurante e \r\npara de se mover. Daí em diante, até que a criatura se \r\nliberte da armadilha, seu movimento é limitado ao \r\ncomprimento da corrente (tipicamente 1 metro de \r\ncomprimento). A criatura presa pode usar sua ação para \r\nfazer um teste de Força CD 13 e se libertar, ou outra \r\ncriatura no alcance pode fazer o teste para libertá-la. \r\nCada fracasso no teste causa 1 de dano perfurante à \r\ncriatura presa.", 4, "Armadilha de caça", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(522), 5.0, 12.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9b6570a1-c2eb-4637-a78e-eaf70206e144"), 13, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9958), 0, "Feito de anéis de metal intercalados, um camisão de cota de malha é usado entre as camadas de roupa. Essa armadura oferece proteção modesta para a parte superior do corpo de quem a usa e permite que o som dos anéis de metal, friccionados uns contra os outros, sejam amortecidos pelas camadas exteriores.", 1, 2, 0, 1, "Camisão de Malha", false, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9958), 30.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9bbab4d0-d1f6-4f0a-990f-655ae1e513ce"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(663), 1, "", 4, "Pergaminho (uma folha)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(663), 1.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("9bc41590-bfce-48b9-ba4a-a00e3d4957e3"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(400), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 8, 0, "Clava Grande", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(400), 2.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("9c10d599-b250-48f0-a344-f06180faff23"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(601), 0, "Usando uma ação, você pode espalhar um \r\núnico saco de estrepes para cobrir a área de um quadrado \r\nde 1,5 metro de lado. Qualquer criatura que entrar na \r\nárea deve ser bem sucedida em um teste de resistência de \r\nDestreza CD 15. Se falhar, para de se mover e sofre 1 de \r\ndano perfurante. Até que a criatura recupere pelo menos \r\n1 ponto de vida, seu deslocamento de caminhada é \r\nreduzido em 3 metros. Uma criatura que se mover pela \r\nárea usando metade do seu deslocamento não precisa \r\nfazer o teste de resistência.", 4, "Estrepes (bolsa com 20)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(601), 1.0, 1.0 },
                    { new Guid("9c56e9a8-003e-45a0-9c55-08154d9bffa2"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(618), 2, "", 4, "Frasco", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(618), 2.0, 1.0 },
                    { new Guid("9de83d1a-8475-411c-8a0e-b1389145bf51"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(622), 0, "Essencial para os magos, um grimório é \r\num volume encadernado em couro com 100 páginas de \r\npergaminhos em branco, adequado para armazenar \r\nmagias.", 4, "Grimório", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(622), 50.0, 1.5 },
                    { new Guid("9e9fc0f8-7ccb-4dd2-9423-8885308b0ec2"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(876), 0, "Esse conjunto de ferramentas inclui uma pequena pasta, um conjunto de \r\nchaves mestras, um pequeno espelho montado em uma \r\nalça de metal, um conjunto de tesouras de lâminas \r\nestreitas e um par de alicates. Proficiência com essas \r\nferramentas permite adicionar o bônus de proficiência \r\npara quaisquer testes de habilidade que você fizer para \r\ndesarmar armadilhas ou abrir fechaduras.", 4, "Ferramentas de ladrão", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(876), 25.0, 0.5 },
                    { new Guid("9ed04c90-7369-4e85-8015-18d8db9e0edb"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(668), 0, "Esse estojo de madeira pode \r\narmazenar até 20 virotes de besta.", 4, "Porta virotes", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(668), 1.0, 0.5 },
                    { new Guid("a037d51b-a10c-47f3-b0b4-3dd8d348a5f0"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(901), 0, "O kit de venenos inclui os frascos, \r\nprodutos químicos e outros equipamentos necessários \r\npara a criação de venenos. Proficiência com esse kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar ou utilizar \r\nvenenos.", 4, "Kit de Venenos", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(901), 50.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a35ad411-bc14-4ccb-9cce-598194acb077"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(401), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Foice Curta", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(401), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a3778367-f4f0-4395-a125-41844005cea1"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(699), 2, "", 4, "Vara (3 metros)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(699), 5.0, 3.5 },
                    { new Guid("a5e2c43e-d946-4a43-b6fd-61f3ceb38819"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(680), 0, "", 4, "Roupas finas", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(680), 15.0, 3.0 },
                    { new Guid("a62af4eb-b432-4e51-ab14-c6f2b4e39585"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(617), 0, "", 4, "Varinha de teixo", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(617), 10.0, 0.5 },
                    { new Guid("a7a6bb82-f314-4aa3-a850-1ba22a397751"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(512), 0, "Uma bolsa de pano ou couro que pode \r\narmazenar até 20 munições de funda ou 50 munições de \r\nzarabatana, entre outras coisas. Para armazenar \r\ncomponentes de magia, veja bolsa de componentes, \r\ntambém descrita nessa seção.", 4, "Algibeira", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(512), 5.0, 0.5 },
                    { new Guid("aa3c815f-fffa-49a5-a85a-16eef85e73ff"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(694), 0, "Um abrigo simples e portátil que acomoda \r\nduas pessoas.", 4, "Tenda para duas pessoas", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(694), 2.0, 10.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("aafe70ee-4e69-4c35-94f7-d1c58404083d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(433), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Machado Grande", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(433), 30.0, 3.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("ab684d8c-5721-4fb9-891d-9737b109f8e1"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(676), 1, "", 4, "Roupas comuns", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(676), 5.0, 1.5 },
                    { new Guid("abbfa805-d6ad-4112-a9ef-ff887f79f8ba"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(600), 0, "", 4, "Espelho de aço", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(600), 5.0, 0.25 },
                    { new Guid("adaad8c4-ef52-4b2e-b0ce-ecd66f89dc39"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(518), 0, "Uma criatura que beber o líquido desse \r\nvidro tem vantagem em testes de resistência contra \r\nvenenos por 1 hora. O antídoto não confere nenhum \r\nbenefício para mortos-vivos ou constructos. ", 4, "Antídoto (vidro)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(518), 50.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ade921a6-812f-4131-b7ea-247858470376"), 18, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(47), 0, "Consiste em placas de metal moldadas para cobrir todo o corpo. Inclui luvas, botas de couro pesadas, um capacete com viseira e espessas camadas de enchimento por baixo da armadura. Fivelas e tiras de couro distribuem o peso ao longo do corpo.", 1, 0, 15, null, "Placas", true, 1, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(47), 1500.0, 32.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("ae809f08-0208-4f96-bc1d-a812501f98af"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(682), 2, "", 4, "Sabão", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(682), 2.0, 0.0 },
                    { new Guid("b06c2c02-04fc-465b-ab51-b2ade0651eb6"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(877), 0, "", 4, "Alaúde", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(877), 35.0, 1.0 },
                    { new Guid("b0d39791-83fa-4e62-ac0b-bee49750cec1"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(895), 1, "", 4, "Baralho de Cartas", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(895), 5.0, 0.0 },
                    { new Guid("b175f2e0-8884-4313-bcee-af12f7be4bb3"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(891), 0, "Essa bolsa de cosméticos, tintura de \r\ncabelo e pequenos adereços permite criar disfarces que \r\nmudam sua aparência física. Proficiência com este kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar um disfarce \r\nvisual.", 4, "Kit de Disfarce", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(891), 25.0, 1.5 },
                    { new Guid("b1b44195-bdb0-4d0a-9182-443bd93094f5"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(517), 0, "", 4, "Ampulheta", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(517), 25.0, 0.5 },
                    { new Guid("b2fd7ed1-1df2-44f0-a90d-2bfd76d05856"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(654), 0, "", 4, "Panela de ferro", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(654), 2.0, 5.0 },
                    { new Guid("b31f6e31-1220-4184-a3b2-90a0b545333e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(667), 0, "Esse estojo \r\ncilíndrico de couro pode armazenar até 10 folhas de papel \r\nenroladas ou 5 folhas de pergaminhos enroladas.", 4, "Porta mapas ou pergaminhos", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(667), 1.0, 0.5 },
                    { new Guid("b36ab5c4-27e8-40fa-8581-f206c3953f5e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(854), 0, "", 4, "Ferramentas de Entalhador", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(854), 1.0, 2.5 },
                    { new Guid("b3f75483-ce9e-43cf-b490-d67110098919"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(659), 2, "", 4, "Pedra de amolar", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(659), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b57fb376-96b2-4b7f-b2e4-17bfeaddc7fa"), 12, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9957), 0, "Armadura bruta consistindo de peles grossas. É comumente usada por tribos bárbaras, humanoides malignos e outros povos que não têm acesso às ferramentas e materiais necessários para criar uma armadura melhor.", 1, 2, 0, 1, "Gibão de Peles", false, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9957), 10.0, 6.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("b7052b62-6f7a-4566-80a3-d44ece662c08"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(866), 0, "", 4, "Ferramentas de Vidreiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(866), 30.0, 2.5 },
                    { new Guid("b7dfa93b-e815-4e65-a6cb-eb1f05a5e6d6"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(870), 0, "", 4, "Suprimentos de Caligrafia", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(870), 10.0, 2.5 },
                    { new Guid("b975e9bd-b6c9-499d-ae81-62eeb0670f9d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(689), 0, "", 4, "Emblema", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(689), 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ba8bdec9-546a-4246-ad04-5361ed623c60"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(417), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Cimitarra", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(417), 25.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("bf96a44f-88b0-474a-9aa6-92930e521b9d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(627), 0, "Um kit de escalada inclui pítons \r\nespeciais, botas com solas pontiagudas, luvas e um cinto. \r\nVocê pode usar o kit de escalada como uma ação para \r\n\"ancorar-se\". Quando faz isso, você não pode cair mais de \r\n7,5 metros a partir do ponto onde se ancorou, e não pode \r\nsubir mais de 7,5 metros de distância desse ponto, sem \r\ndesfazer a âncora.", 4, "Kit de escalada", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(627), 25.0, 6.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("bfc6107e-4c67-4030-b00e-0376e7d69ca1"), 17, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(45), 0, "Feita de tiras verticais de metal, rebitadas a um suporte de couro, usadas sobre um preenchimento de pano. Cotas de malha flexíveis protegem as articulações.", 1, 0, 15, null, "Cota de malha", true, 1, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(45), 200.0, 30.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("bfe510c8-0e72-400c-a620-94bd17eadcba"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(449), 0, 1, "Armas Marciais à Distância", 1, 8, 0, "Arco Longo", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(449), 50.0, 1.0 },
                    { new Guid("c03bdedb-d477-4532-8108-953dd9895296"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(419), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 4, 0, "Chicote", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(419), 2.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c14db7b6-234e-4d24-bcd8-f74561deb93a"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(603), 0, "", 4, "Bastão", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(603), 10.0, 1.0 },
                    { new Guid("c2d06694-5ef0-473f-82c4-88482407228e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(614), 0, "", 4, "Ramo de visco", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(614), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c4e8bf6a-ea45-46b2-a048-cd2df9021675"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(450), 0, 1, "Armas Marciais à Distância", 1, 6, 0, "Besta de Mão", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(450), 75.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c5a48559-d740-4fb3-bff9-bccdcb2a7648"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(630), 0, "Uma lanterna coberta lança luz \r\nplena em um raio de 9 metros e penumbra por mais 9 \r\nmetros. Uma vez acesa, ela queima por 6 horas usando \r\num frasco de óleo (500 ml). Usando uma ação, você pode \r\nabaixar a cobertura, reduzindo a claridade para \r\npenumbra em um raio de 1,5 metro.", 4, "Lanterna coberta", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(630), 5.0, 1.0 },
                    { new Guid("c5b0ed03-2d23-4210-a114-c36dfe5d6fc4"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(621), 2, "", 4, "Giz (1 peça)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(621), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c5e809c3-cdc3-45fe-b2aa-961c53e58ded"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(445), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Picareta de Guerra", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(445), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c62534a4-0906-4d1b-b260-253ed2ae3cfe"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(589), 1, "", 4, "Cobertor de inverno", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(589), 5.0, 1.5 },
                    { new Guid("c8fc651a-ad6a-41e7-b7cf-1f3cd9607fb6"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(638), 0, "", 4, "Manto", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(638), 1.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ca9634d2-2c1f-4afe-8a33-77d693ce7172"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(427), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Glaive", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(427), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("cda5983e-4ce4-475c-9e6e-650ad8f4835b"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(679), 0, "", 4, "Roupas de entretenimento", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(679), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("cdac93ee-62b6-499f-9548-26fa991aab18"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(438), 0, 2, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Malho", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(438), 10.0, 5.0 },
                    { new Guid("ce74070f-5450-4679-b590-05118679bb66"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(455), 0, 1, "Armas Marciais à Distância", 0, 1, 0, "Rede", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(455), 1.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d0037342-0330-4e7d-8305-d0175881ff03"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(892), 0, "Essa pequena caixa contém uma \r\nvariedade de papéis e pergaminhos, canetas e tintas, \r\nselos e lacres, folha de ouro e prata, e outros suprimentos \r\nnecessários para criar falsificações convincentes de \r\ndocumentos físicos. Proficiência com esse kit permite \r\nadicionar o bônus de proficiência para quaisquer testes de \r\nhabilidade que você fizer para criar uma falsificação de \r\num documento físico.", 4, "Kit de Falsificação", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(892), 15.0, 2.5 },
                    { new Guid("d026d096-77eb-44f5-a506-692817a52fb2"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(655), 1, "", 4, "Papel (uma folha)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(655), 2.0, 0.0 },
                    { new Guid("d14effca-1e20-4765-99f9-d77447f3d6c5"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(683), 2, "", 4, "Saco", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(683), 1.0, 0.25 },
                    { new Guid("d3358bd4-0bb8-400c-8d4e-187b7a12cf08"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(900), 0, "", 4, "Xadrez do Dragão", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(900), 1.0, 0.25 },
                    { new Guid("d62b8c93-ee53-4c78-9b68-f33e401aabea"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(629), 1, "Uma lâmpada lança luz plena em um raio \r\nde 4,5 metros e penumbra por mais 9 metros. Uma vez \r\nacesa, a lâmpada queima por 6 horas usando um frasco de \r\nóleo (500 ml).", 4, "Lâmpada", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(629), 5.0, 0.5 },
                    { new Guid("d8742410-275b-4379-9844-8ee9307ac2f3"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(602), 0, "A fechadura vem com chave. Sem a \r\nchave, uma criatura proficiente com ferramentas de \r\nladrão pode abrir a fechadura com um sucesso em um \r\nteste de Destreza CD 15. O Mestre pode decidir que \r\nfechaduras melhores estão disponíveis por preços mais \r\nelevados.", 4, "Fechadura", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(602), 10.0, 0.5 },
                    { new Guid("d87d9abc-291f-481b-b6da-290e11babb8e"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(609), 0, "", 4, "Orbe", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(609), 20.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d9106b5d-7175-4ff5-9438-6e8565fd5e5d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(431), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Lança Longa", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(431), 5.0, 4.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("db6c64a7-0ed0-4838-952b-1b8cfb4caa79"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(592), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de seda (15 metros)", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(592), 10.0, 2.5 },
                    { new Guid("de3f107f-402d-49a9-ab37-e745ca9122dc"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(883), 0, "", 4, "Oboé", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(883), 2.0, 0.5 },
                    { new Guid("df4188b0-7fbd-4919-9274-81f54fb30fcf"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(849), 0, "", 4, "Ferramentas de Cartógrafo", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(849), 15.0, 3.0 },
                    { new Guid("df52fac0-07a3-473a-8b30-317c0c2f82cb"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(678), 0, "", 4, "Roupas de viajante", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(678), 2.0, 2.0 },
                    { new Guid("e1aa0e80-7806-4440-97d1-06272379d119"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(675), 0, "Um conjunto de roldanas com um \r\ncabo entre elas e um gancho para fixar aos objetos, a \r\nroldana e polia permitem içar até quatro vezes o peso que \r\nvocê ergueria normalmente.", 4, "Roldana e polia", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(675), 1.0, 2.5 },
                    { new Guid("e1e35595-e4b6-40fd-82af-4b1c89478214"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(690), 0, "", 4, "Relicário", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(690), 5.0, 1.0 },
                    { new Guid("e4d3d519-9786-4cad-873e-b301100eda83"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(861), 0, "", 4, "Ferramentas de Pedreiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(861), 10.0, 4.0 },
                    { new Guid("e59c5608-4de3-422a-a56f-9865c7358861"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(860), 0, "", 4, "Ferramentas de Oleiro", 3, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(860), 10.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e66dacb0-42f6-4200-a2ee-4e9820812051"), 14, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9960), 0, "Consiste em um casaco e calças (e talvez uma saia separada) de couro coberto com peças sobrepostas de metal, assim como as escamas de peixe. O conjunto inclui manoplas.", 1, 2, 0, 1, "Brunea", true, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9960), 50.0, 22.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e95c619e-3031-4d71-98fe-8f45bd15b38f"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(447), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Tridente", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(447), 5.0, 2.0 },
                    { new Guid("ebd32b99-844a-4a19-9275-cbbc98ee5fa5"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(398), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Bordão", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(398), 2.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ec442d28-7df7-4266-93d6-618cf2a89697"), 11, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9953), 0, "São feitos de couro que foi endurecido após ser fervido em óleo. O resto da armadura é feita de materiais mais macios e mais flexíveis.", 1, 0, 0, 1, "Couro", false, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9953), 10.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ed20c47d-1c9c-46a4-893f-6362ef78ff5a"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(392), 0, 1, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Adaga", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(392), 2.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ed33855e-9011-4645-83e1-e228f223ceb5"), 12, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9955), 0, "Feita de couro resistente, mas flexível, é reforçada com rebites ou cravos.", 1, 0, 0, 1, "Couro Batido", false, 1, new DateTime(2024, 6, 4, 17, 12, 55, 543, DateTimeKind.Local).AddTicks(9955), 45.0, 6.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("edb89b72-12ef-4737-bb6a-f4d27980dc4a"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(695), 2, "A tocha queima por 1 hora, fornecendo luz \r\nplena em um raio de 6 metros e penumbra por mais 6 \r\nmetros. Se você realizar um ataque corpo-a-corpo com \r\numa tocha acesa e acertar, causa 1 de dano flamejante.", 4, "Tocha", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(695), 1.0, 0.5 },
                    { new Guid("ee053af8-9f55-4ef3-85c3-474360bfcecd"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(884), 0, "", 4, "Tambor", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(884), 6.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f61d7046-5af9-4ccb-b5a3-5109d53313f1"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(435), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Machado de Batalha", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(435), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f7253926-749c-4884-869d-1ed89ff02098"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(658), 0, "Usar um pé de cabra concede vantagem \r\nnos testes de Força onde uma alavanca possa ser \r\naplicada.", 4, "Pé de cabra", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(658), 2.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f881f60c-6263-4a96-9088-43cc59a343b6"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(443), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Martelo de Guerra", 0, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(443), 15.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("faf89976-611c-4f07-bede-37af44aacbfc"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(573), 0, "Trata-se de uma pequena \r\nbalança, pratos e um sortimento adequado de pesos de até \r\n1 kg. Com ela, você pode medir o peso exato de pequenos \r\nobjetos, como metais preciosos brutos ou bens comerciais, \r\npara ajudar a determinar seu valor.", 4, "Balança de mercador", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(573), 5.0, 1.5 },
                    { new Guid("fcfafc24-26d4-4ca9-87c6-4c383406c999"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(505), 0, "", 4, "Ábaco", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(505), 2.0, 1.0 },
                    { new Guid("ff614220-8226-466e-8741-84f42796503d"), new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(893), 0, "Esse kit contém uma variedade \r\nde instrumentos, como alicates, almofariz e pilão, e bolsas \r\ne frascos utilizados pelos herbalistas para criar remédios \r\ne poções. Proficiência com este kit permite adicionar o \r\nbônus de proficiência para quaisquer testes de habilidade \r\nque você fizer para identificar ou aplicar ervas. Além \r\ndisso, a proficiência com esse kit é necessária para criar \r\nantídotos e poções de cura.", 4, "Kit de Herbalismo", 4, new DateTime(2024, 6, 4, 17, 12, 55, 544, DateTimeKind.Local).AddTicks(893), 5.0, 1.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("123d422b-917b-4855-b01a-53a79bbfb2bc"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("20ec07c3-e22d-4864-9e3b-ee066d59d8fc"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("214ce33e-c62a-4376-a254-a8941bd5a4cd"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("2386bf94-1a8c-40d8-a364-5b3b1df90c2b"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("25e7f7d4-ab1c-41b0-ab36-c91e751c63c3"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("2f91c8bf-2592-45e1-8bc0-41426181100b"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("2ffd0c6f-6d47-420b-a285-249a0422dfc4"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("3949eb61-c04d-4141-ab38-b639f3fae0df"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("41326394-408d-4e9e-8d43-a2dd1a16e2f4"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("6310eb13-2bb5-4ee9-b98c-63c7ff8fc5ed"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("7369eef0-70dc-493c-859f-4c03432f6721"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("8cc2332c-3c44-49c1-89e6-d3ce71de7451"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("9fe3f4eb-ee85-49c2-8081-a96c704cba5e"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("a8699677-e958-4645-8718-6e85012236f5"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("af629e9a-8659-4b1a-a6da-41f13def9bfd"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("bb56c1c6-17c3-45f8-8370-28e7d3fbdb12"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("cacec0bf-d587-4a79-8b96-ef44112fed0e"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("d076e38c-e9e8-4d98-b7dc-34587b095ee6"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("d74ff7fa-6bdc-4fac-92b5-e689655b783d"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("da4222f4-510c-4874-be70-6a1b32cec63a"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("db574b85-9e05-42ef-b6d7-321467d6b88f"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("e37aa725-9836-457c-8a1c-c4f7f589a9d9"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("efc71688-bbd6-4c53-b071-485876afb08d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("007bb7dd-e4fb-4f5a-9a88-94baba2e1b6b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0113da7e-ea47-49f7-a459-5308c7de1d6f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0382a7a6-2622-45ec-adda-2dd35afdf759"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("072ee076-09ed-4029-b09d-fb643d5b1fb7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("07b5194c-d08a-4a88-a52d-ee08bbc01193"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("07c9376f-117d-45fe-8e81-91e3854456ab"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0812e309-16dd-4dfe-878c-294e41a63ee5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0a2b07fd-e54d-46b5-b44d-7562902723cc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0b1bc650-91c8-4e37-96c6-a041e09a4e19"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0c5f4c08-bed8-447d-94e3-f05060817ff5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("103ffa9d-260e-40f4-8905-6d9003b5bda8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12bca794-5922-4aec-8226-6bac7aefa7eb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("13cb958b-390d-4202-a11f-831cb2295841"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("142a100c-59a0-45e8-93e7-a61d1615615d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1682cd41-75ca-4ae9-bbe6-f48afb7f6c3e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("17b74aab-9e38-476c-928b-c56a9e1317de"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("18e15a4c-95cf-440d-b0f7-89b87246ac39"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1a074912-a474-4667-a240-09d7a361fdaa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1a9da49f-bd66-49c0-99e8-414728754bc7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1b0a98b7-02a4-4bc7-b8d0-326fb7398321"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1feadc9f-ade2-4217-8c54-aee21abc33f7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("21c4680d-43fb-46ba-a3aa-57f63144ca5b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2256ae0e-25e8-4693-9406-ce0487ea1372"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("25354b60-d81b-47db-8ca8-24efab6ae614"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("26036e97-bf8c-4ef6-af9b-30171e08dd6d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("293cdf5b-0c8a-4470-844e-d56060579d34"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2a339aed-ac68-4f5e-a543-5f03ede845db"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2b32fca3-6cd5-44df-8fff-00de578bdff5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2c457a27-622d-44ea-b69d-f09deda4adab"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2d91d22c-8e50-41b2-a24c-c1a5c5994d14"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2da6ebc2-50ac-4f11-84c3-d5602f50413d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2db0295a-722f-46de-b5aa-e652a82fa792"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2de96a0e-812b-4f42-9550-4af43499ea86"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2e1d23a7-10ee-43d8-ad8c-83a7c2c71335"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2ea1454a-4b07-4256-a22e-7665a338532f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2f6fe754-1ffc-4cec-a031-630fa0caef8e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2fb39876-a559-4bad-9628-9a2be04ce8eb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30e0c2b8-fef9-4d16-bd62-40e2b6247994"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3575a594-9b67-4ad7-9425-d3781ce12305"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3a7bbbf8-eee2-45cf-a56c-074fd89922b5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3b6d8a28-bdca-48e4-9907-97289d498ace"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3b98a9db-d972-4e55-a8f1-ea3b6b88ea6e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c13ea34-c49c-4460-9305-bd117839aa85"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3eb4a63f-6a4e-474f-ba78-57017947d08f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3f85f1aa-b2f6-46a4-bacc-85e203fcba7f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("400de40b-9e17-4c9f-a54d-103c7d5c4437"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("445c7b9c-adb3-48ad-90d8-2414bf9aa2d0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("457da730-f083-46b1-92f4-486150728a57"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4929a46f-d835-4e31-8f4e-af7f725669dd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4939f281-9f50-4fe4-8009-d834c0e74666"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4a5b302a-33c1-427e-939d-728eb258751c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4ad3db25-0b6d-42cb-9504-600a111d02f8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5232401f-0e0f-4250-b24b-93115bcc5c32"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("52556a0e-a51a-4871-b89f-89af63652a5f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5597f835-7c27-4b64-b574-26c0e92f4e81"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55a6720b-c1a3-40b0-8c97-e428e050dd4f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5623044b-8aa1-4330-b875-cd22d6dde078"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("564fe2a9-464e-4f33-af36-4e164d3345b0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("573bf14d-1464-42a4-b14d-894daa78ff87"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5995001d-adad-45ad-9a92-93a52fd5f2d1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5a3ded48-6b3d-48b7-89d1-cec17b888bb8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5bb0e2d8-837f-47cb-b5cc-5b9efe0937ea"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5c58ba40-dd5c-4aaa-b249-aae359d84226"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5debb34f-f7b8-4bec-b8eb-85ddf4b6cb1e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5e8b8162-5647-4e3f-a37e-fccd18972fe6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5eed7efe-0506-42fb-9476-ba8f0b07474d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("65fa92f5-5822-4ffc-9bae-2f83653f760b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("667a485b-073f-47b3-9639-54ee4e25d081"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("67dcf077-51c4-458b-8031-75d1b774deb9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("682eb383-94bc-4bff-8ad7-f8b74911f126"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("69f9a1ec-929a-43fd-9ff3-98e22dc818d9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6d1497f2-4985-41a6-89d3-5a23700828cb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6dc6439a-2b34-4dde-b230-904c8c4130bb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("758104b1-bca9-415b-b208-bcd3aa9c6ac0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("77ee4739-3f88-402b-aff4-37a37ed8536f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("79424bbb-f019-4a4e-a6aa-31717a37c686"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7c37f207-ec87-4e4a-85f8-d89f55699ce7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7ce5c1f8-2f22-452c-88d1-7da24145887f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7db12ce6-e5cb-46f4-8618-75f40b163801"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("82866c60-998f-4ea2-a2ce-4e72411c97f0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("840f36c6-7372-4bbe-9c9b-624b7e32489b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("840f6513-5f92-486c-9955-88ce3e9134f0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("859f98ee-6b40-4a71-98bc-e0d374674203"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("85c2292c-7849-4750-af5c-7fa733f2242e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("86644323-6cae-49f8-ae42-ede3d28584c8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8791d835-47bb-44b5-9755-5ef8fdc3443b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("87c8514e-d6ec-4de6-b228-2e19041790f0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("87e5356b-e551-4baf-841c-fec40897d117"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8824b78f-15da-40c4-82b9-7faf0c35eebc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("883b4e16-4852-451a-8494-fe4a2bf2eb6c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("883f3820-48c4-4cdf-b2a8-a878d008dfce"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8a16bdf1-da27-49ef-ab85-281cc685d00f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8caf5a14-dccb-48f9-91a7-6842c23192b3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8e4442d6-450c-4d9c-bba7-f8c08173c1ba"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("91aa5e98-b9dc-4ed6-af73-92f0659a6fd5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("91b2c8e5-4d57-4d02-8c57-cc014d5b339d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("91c77b45-b31a-4bc3-831f-47cb09d5414f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("920879a1-442e-4e5c-95cc-b492948c58bf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("929215f9-11f4-4022-a451-6b2aa3d1a12c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("929d7b62-e9c1-4c28-8cc9-c56506c92a64"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("92f2b374-2efc-4842-a8d1-c40648c28e2f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("93357900-e835-4b5b-9ece-bf4e5f901c8a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("95120eed-34ff-4b37-8141-908d98ff75ed"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("95c8e236-49b4-4113-8169-1b512f5d3a86"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("966c517c-fb35-40fa-87b2-36e2f33e70dd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9b6570a1-c2eb-4637-a78e-eaf70206e144"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9bbab4d0-d1f6-4f0a-990f-655ae1e513ce"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9bc41590-bfce-48b9-ba4a-a00e3d4957e3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9c10d599-b250-48f0-a344-f06180faff23"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9c56e9a8-003e-45a0-9c55-08154d9bffa2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9de83d1a-8475-411c-8a0e-b1389145bf51"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9e9fc0f8-7ccb-4dd2-9423-8885308b0ec2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9ed04c90-7369-4e85-8015-18d8db9e0edb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a037d51b-a10c-47f3-b0b4-3dd8d348a5f0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a35ad411-bc14-4ccb-9cce-598194acb077"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a3778367-f4f0-4395-a125-41844005cea1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a5e2c43e-d946-4a43-b6fd-61f3ceb38819"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a62af4eb-b432-4e51-ab14-c6f2b4e39585"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a7a6bb82-f314-4aa3-a850-1ba22a397751"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aa3c815f-fffa-49a5-a85a-16eef85e73ff"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aafe70ee-4e69-4c35-94f7-d1c58404083d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ab684d8c-5721-4fb9-891d-9737b109f8e1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("abbfa805-d6ad-4112-a9ef-ff887f79f8ba"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("adaad8c4-ef52-4b2e-b0ce-ecd66f89dc39"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ade921a6-812f-4131-b7ea-247858470376"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ae809f08-0208-4f96-bc1d-a812501f98af"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b06c2c02-04fc-465b-ab51-b2ade0651eb6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b0d39791-83fa-4e62-ac0b-bee49750cec1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b175f2e0-8884-4313-bcee-af12f7be4bb3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b1b44195-bdb0-4d0a-9182-443bd93094f5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b2fd7ed1-1df2-44f0-a90d-2bfd76d05856"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b31f6e31-1220-4184-a3b2-90a0b545333e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b36ab5c4-27e8-40fa-8581-f206c3953f5e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b3f75483-ce9e-43cf-b490-d67110098919"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b57fb376-96b2-4b7f-b2e4-17bfeaddc7fa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b7052b62-6f7a-4566-80a3-d44ece662c08"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b7dfa93b-e815-4e65-a6cb-eb1f05a5e6d6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b975e9bd-b6c9-499d-ae81-62eeb0670f9d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ba8bdec9-546a-4246-ad04-5361ed623c60"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bf96a44f-88b0-474a-9aa6-92930e521b9d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bfc6107e-4c67-4030-b00e-0376e7d69ca1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bfe510c8-0e72-400c-a620-94bd17eadcba"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c03bdedb-d477-4532-8108-953dd9895296"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c14db7b6-234e-4d24-bcd8-f74561deb93a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c2d06694-5ef0-473f-82c4-88482407228e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c4e8bf6a-ea45-46b2-a048-cd2df9021675"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c5a48559-d740-4fb3-bff9-bccdcb2a7648"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c5b0ed03-2d23-4210-a114-c36dfe5d6fc4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c5e809c3-cdc3-45fe-b2aa-961c53e58ded"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c62534a4-0906-4d1b-b260-253ed2ae3cfe"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c8fc651a-ad6a-41e7-b7cf-1f3cd9607fb6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ca9634d2-2c1f-4afe-8a33-77d693ce7172"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cda5983e-4ce4-475c-9e6e-650ad8f4835b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cdac93ee-62b6-499f-9548-26fa991aab18"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ce74070f-5450-4679-b590-05118679bb66"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d0037342-0330-4e7d-8305-d0175881ff03"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d026d096-77eb-44f5-a506-692817a52fb2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d14effca-1e20-4765-99f9-d77447f3d6c5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d3358bd4-0bb8-400c-8d4e-187b7a12cf08"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d62b8c93-ee53-4c78-9b68-f33e401aabea"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d8742410-275b-4379-9844-8ee9307ac2f3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d87d9abc-291f-481b-b6da-290e11babb8e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d9106b5d-7175-4ff5-9438-6e8565fd5e5d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("db6c64a7-0ed0-4838-952b-1b8cfb4caa79"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("de3f107f-402d-49a9-ab37-e745ca9122dc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("df4188b0-7fbd-4919-9274-81f54fb30fcf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("df52fac0-07a3-473a-8b30-317c0c2f82cb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e1aa0e80-7806-4440-97d1-06272379d119"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e1e35595-e4b6-40fd-82af-4b1c89478214"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e4d3d519-9786-4cad-873e-b301100eda83"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e59c5608-4de3-422a-a56f-9865c7358861"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e66dacb0-42f6-4200-a2ee-4e9820812051"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e95c619e-3031-4d71-98fe-8f45bd15b38f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ebd32b99-844a-4a19-9275-cbbc98ee5fa5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ec442d28-7df7-4266-93d6-618cf2a89697"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ed20c47d-1c9c-46a4-893f-6362ef78ff5a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ed33855e-9011-4645-83e1-e228f223ceb5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("edb89b72-12ef-4737-bb6a-f4d27980dc4a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ee053af8-9f55-4ef3-85c3-474360bfcecd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f61d7046-5af9-4ccb-b5a3-5109d53313f1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f7253926-749c-4884-869d-1ed89ff02098"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f881f60c-6263-4a96-9088-43cc59a343b6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("faf89976-611c-4f07-bede-37af44aacbfc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fcfafc24-26d4-4ca9-87c6-4c383406c999"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ff614220-8226-466e-8741-84f42796503d"));

            migrationBuilder.DropColumn(
                name: "ArmorClass",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "MaxModifier",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "MinStrength",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Modifier",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "StealthDisadvantage",
                table: "Items");

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1139181d-ac36-46c5-b007-0775fb2c9c36"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(962), "Você possui proficiência com \r\nferramentas de artesão (ferramentas de engenhoqueiro). \r\nUsando essas ferramentas, você pode gastar 1 hora e 10 \r\npo em materiais para construir um mecanismo Miúdo (CA \r\n5, 1 pv). O mecanismo para de funcionar após 24 horas (a \r\nnão ser que você gaste 1 hora reparando-o para manter o \r\nmecanismo funcionando), ou quando você usa sua ação \r\npara desmantelá-lo; nesse momento, você pode recuperar \r\no material usado para criá-lo. Você pode ter até três\r\n desses mecanismos ativos ao mesmo tempo.", "Engenhoqueiro", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(962) },
                    { new Guid("28a640dc-d863-47cd-8237-2d918a3d4cd7"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(948), "Você possui \r\ndesvantagem nas jogadas de ataque e testes de Sabedoria \r\n(Percepção) relacionados a visão quando você, o alvo do \r\nseu ataque, ou qualquer coisa que você está tentando \r\nperceber, esteja sob luz solar direta.", "Sensibilidade à Luz Solar", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(948) },
                    { new Guid("2f7a0e12-0da4-4932-964f-145a43cd393e"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(949), "Você possui o truque globos de luz. \r\nQuando você alcança o 3° nível, você pode conjurar a \r\nmagia fogo das fadas. Quando você alcança o 5° nível, \r\nvocê pode conjurar escuridão. Você precisa terminar um \r\ndescanso longo para poder conjurar as magias desse traço \r\nnovamente. Carisma é sua habilidade chave para \r\nconjurar essas magias.", "Magia Drow", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(949) },
                    { new Guid("3f3e090b-fd87-485b-805e-1c6284385b65"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(945), "Elfos não precisam dormir. Ao invés disso, \r\neles meditam profundamente, permanecendo \r\nsemiconscientes, durante 4 horas por dia. (A palavra em \r\nidioma comum para tal meditação é \"transe\".) Enquanto \r\nmedita, um elfo é capaz de sonhar de certo modo. Esses \r\nsonhos na verdade são exercícios mentais que se tornam \r\nreflexos através de anos de prática. Depois de descansar \r\ndessa forma, você ganha os mesmos benefícios que um \r\nhumano depois de 8 horas de sono. ", "Transe", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(945) },
                    { new Guid("544ce9fb-7cd8-4d52-8b69-2b0ba669463c"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(963), "Quando você é reduzido a \r\n0 pontos de vida mas não é completamente morto, você \r\npode voltar para 1 ponto de vida. Você não pode usar essa \r\ncaracterística novamente até completar um descanso \r\nlongo.", "Resistência Implacável", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(963) },
                    { new Guid("560f35ab-5d13-455d-8163-e955602e40bf"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(966), "Quando você atinge um ataque \r\ncrítico com uma arma corpo-a-corpo, você pode rolar um \r\ndos dados de dano da arma mais uma vez e adicioná-lo ao \r\ndano extra causado pelo acerto crítico.", "Ataques Selvagens", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(966) },
                    { new Guid("610e56c3-1579-4c11-b1cd-c28781977951"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(959), "Você conhece o truque ilusão \r\nmenor. Inteligência é a sua habilidade usada para \r\nconjurá-la.", "Ilusionista Nato", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(959) },
                    { new Guid("64791ab2-b629-492e-9cb6-fc070eae75e7"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(952), "Você pode mover-se através do \r\nespaço de qualquer criatura que for de um tamanho maior \r\nque o seu.", "Agilidade Halfling", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(952) },
                    { new Guid("6544e546-0d43-4015-9c3e-a6d61fd83f08"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(939), " Você possui vantagem em testes de \r\nresistência contra venenos e resistência contra dano de \r\nveneno.", "Resiliência Anã", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(939) },
                    { new Guid("6eabb5a3-e40f-4ffb-a414-229700082f44"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(937), "Acostumado à vida subterrânea, \r\nvocê tem uma visão superior no escuro e na penumbra. \r\nVocê enxerga na penumbra a até 18 metros como se fosse \r\nluz plena, e no escuro como se fosse na penumbra. Você \r\nnão pode discernir cores no escuro, apenas tons de cinza.", "Visão no Escuro", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(937) },
                    { new Guid("7287e869-a012-4056-9ffc-65321e5821c4"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(967), "Você possui resistência a dano \r\nde fogo.", "Resistência Infernal", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(967) },
                    { new Guid("7ea5ad4b-0d9d-4dbb-9303-9bfe6dab43ad"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(941), "Você tem proficiência na perícia \r\nPercepção.", "Sentidos Aguçados", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(941) },
                    { new Guid("8d427440-fefb-451e-8dad-574f004799ed"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(950), "Quando você obtiver um 1 natural em uma \r\njogada de ataque, teste de habilidade ou teste de \r\nresistência, você pode jogar de novo o dado e deve utilizar \r\no novo resultado.", "Sortudo", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(950) },
                    { new Guid("8d8ab7d1-5680-42a8-8ecf-9d5b01fa2f62"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(940), "Sempre que você \r\nrealizar um teste de Inteligência (História) relacionado à \r\norigem de um trabalho em pedra, você é considerado \r\nproficiente na perícia História e adiciona o dobro do seu \r\nbônus de proficiência ao teste, ao invés do seu bônus de \r\nproficiência normal.", "Especialização em Rochas", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(940) },
                    { new Guid("8da63290-8c87-497c-90b4-8a10db3db983"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(960), "Através de sons e \r\ngestos, você pode comunicar ideias simples para Bestas \r\npequenas ou menores. Gnomos da floresta amam os \r\nanimais e normalmente possuem esquilos, doninhas, \r\ncoelhos, toupeiras, pica-paus e outras criaturas como \r\namados animais de estimação.", "Falar com Bestas Pequenas", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(960) },
                    { new Guid("912196ef-dec3-4e55-b5bb-7a97ad8a75fd"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(956), "Você possui resistência ao tipo \r\nde dano associado ao seu ancestral dracônico.", "Resistência a Dano", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(956) },
                    { new Guid("93f57ae4-300e-40d7-939b-1df18a48dc46"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(951), "Você tem vantagem em testes de resistência \r\ncontra ficar amedrontado. ", "Bravura", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(951) },
                    { new Guid("95910921-4d47-4d49-84c1-287d0b791dc7"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(955), "Você pode usar uma ação para \r\nexalar energia destrutiva. Seu ancestral dracônico \r\ndetermina o tamanho, formado e tipo de dano que você \r\nexpele. \r\nQuando você usa sua arma de sopro, cada criatura na \r\nárea exalada deve realizar um teste de resistência, o tipo \r\ndo teste é determinado pelo seu ancestral dracônico. A CD \r\ndo teste de resistência é 8 + seu modificador de \r\nConstituição + seu bônus de proficiência. Uma criatura \r\nsofre 2d6 de dano num fracasso e metade desse dano num \r\nsucesso. O dano aumenta para 3d6 no 6° nível, 4d6 no 11° \r\nnível e 5d6 no 16° nível. \r\nDepois de usar sua arma de sopro, você não poderá \r\nutilizá-la novamente até completar um descanso curto ou \r\nlongo.", "Arma de Sopro", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(955) },
                    { new Guid("accb920a-f216-495a-b916-cc3ec7b3556d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(968), "Você conhece o truque \r\ntaumaturgia. Quando você atingir o 3° nível, você poderá \r\nconjurar a magia repreensão infernal como uma magia de \r\n2° nível. Quando você atingir o 5° nível, você também \r\npoderá conjurar a magia escuridão. Você precisa terminar \r\num descanso longo para poder usar as magias desse traço \r\nnovamente. Sua habilidade de conjuração para essas \r\nmagias é Carisma.", "Legado Infernal", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(968) },
                    { new Guid("bf5cc6f7-7877-455f-a825-010a85d5fda0"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(961), "Toda vez que você fizer \r\num teste de Inteligência (História) relacionado a itens \r\nmágicos, objetos alquímicos ou mecanismos tecnológicos, \r\nvocê pode adicionar o dobro do seu bônus de proficiência, \r\nao invés de qualquer bônus de proficiência que você \r\nnormalmente use.", "Conhecimento de Artífice", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(961) },
                    { new Guid("cc03a689-65cf-4ce3-993f-528ee52b3a40"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(944), "Você tem vantagem nos testes de \r\nresistência para resistir a ser enfeitiçado e magias não \r\npodem colocá-lo para dormir.", "Ancestral Feérico", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(944) },
                    { new Guid("d25b1776-078d-48d4-942b-e8670eb0afaf"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(946), "Você pode tentar se esconder \r\nmesmo quando você está apenas levemente obscurecido  \r\npor folhagem, chuva forte, neve caindo, névoa ou outro \r\nfenômeno natural.", "Máscara da Natureza", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(946) },
                    { new Guid("edaecd04-97c8-4fed-9fc4-07a1168d7d44"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(958), "Você possui vantagem em todos \r\nos testes de resistência de Inteligência, Sabedoria e \r\nCarisma contra magia.", "Esperteza Gnômica", new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(958) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("036c774e-8395-4e23-8051-a5dd14816594"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(593), 1, "", 4, "Pergaminho (uma folha)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(593), 1.0, 0.0 },
                    { new Guid("04973af6-2387-446f-ba0c-13473fc73e63"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(899), 0, "O kit de venenos inclui os frascos, \r\nprodutos químicos e outros equipamentos necessários \r\npara a criação de venenos. Proficiência com esse kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar ou utilizar \r\nvenenos.", 4, "Kit de Venenos", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(899), 50.0, 1.0 },
                    { new Guid("05688ae4-34d3-4d00-8b30-bd0333eca4ed"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(464), 0, "", 4, "Totem", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(464), 1.0, 0.0 },
                    { new Guid("0715e156-b647-4cc4-8336-2638cf7e62ec"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(447), 0, "A fechadura vem com chave. Sem a \r\nchave, uma criatura proficiente com ferramentas de \r\nladrão pode abrir a fechadura com um sucesso em um \r\nteste de Destreza CD 15. O Mestre pode decidir que \r\nfechaduras melhores estão disponíveis por preços mais \r\nelevados.", 4, "Fechadura", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(447), 10.0, 0.5 },
                    { new Guid("0724afc0-c691-4ae8-a0ab-55d7c035d051"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(403), 0, "Quando você usa sua ação para \r\narmá-la, essa armadilha forma um anel de aço com \r\ndentes serrilhados. Eles se fecham quando uma criatura \r\npisa sobre uma placa de pressão no seu centro. A \r\narmadilha é fixada por uma pesada corrente em um \r\nobjeto fixo e imóvel, como uma árvore ou um cravo \r\nenterrado no chão. Uma criatura que pisar na placa de \r\npressão deve ser bem sucedida em um teste de resistência \r\nde Destreza CD 13 ou sofrerá 1d4 de dano perfurante e \r\npara de se mover. Daí em diante, até que a criatura se \r\nliberte da armadilha, seu movimento é limitado ao \r\ncomprimento da corrente (tipicamente 1 metro de \r\ncomprimento). A criatura presa pode usar sua ação para \r\nfazer um teste de Força CD 13 e se libertar, ou outra \r\ncriatura no alcance pode fazer o teste para libertá-la. \r\nCada fracasso no teste causa 1 de dano perfurante à \r\ncriatura presa.", 4, "Armadilha de caça", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(403), 5.0, 12.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("08376271-027c-46d1-9d22-bf6e71087203"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9939), 1, 1, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Azagaia", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9939), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("09fca367-d13e-4d8c-b0e1-45594edcf01b"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(876), 0, "", 4, "Flauta de Pã", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(876), 12.0, 1.0 },
                    { new Guid("0f8b3bed-f0d9-4d21-a40b-4e9b0b08f35e"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(896), 0, "", 4, "Jogo dos Três Dragões", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(896), 5.0, 0.0 },
                    { new Guid("103b1a9d-91cd-4ce0-bf84-34b4ef520170"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(575), 0, "", 4, "Zarabatana (50)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(575), 1.0, 0.5 },
                    { new Guid("104577e9-73af-4da0-97c1-09b0e9904965"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(405), 0, "", 4, "Arpéu", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(405), 2.0, 2.0 },
                    { new Guid("1077b791-0f98-4e6c-bee8-96ddeb0f2ace"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(638), 2, "", 4, "Vara (3 metros)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(638), 5.0, 3.5 },
                    { new Guid("10f3029b-4893-42de-b54f-68cf10114956"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(460), 0, "", 4, "Cajado de madeira", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(460), 5.0, 2.0 },
                    { new Guid("171aacfe-9c55-4d40-88ba-8be9601eb905"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(418), 1, "Esse pequeno recipiente detém uma \r\npederneira, isqueiro e um pavio (um pano geralmente \r\nseco embebido em óleo) usado para acender uma fogueira. \r\nUsá-lo para acender uma tocha – ou qualquer outra coisa \r\nexposta a um combustível abundante – leva uma ação. \r\nAcender qualquer outro fogo leva 1 minuto.", 4, "Caixa de Fogo", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(418), 5.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("175a9c05-61cc-4dc3-af48-78efae242e72"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9980), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Espada Longa", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9980), 15.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("18d5ca83-8a1e-49c0-9c5a-c71d065d2a30"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(382), 0, "", 4, "Ábaco", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(382), 2.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("19b4b60c-8564-44b9-ad0e-4fd6f76143d4"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(61), 0, 1, "Armas Marciais à Distância", 1, 8, 0, "Arco Longo", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(61), 50.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("1a7ab600-59ab-4037-984c-c4686eab496f"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(571), 0, "", 4, "Virotes (20)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(571), 1.0, 0.75 },
                    { new Guid("1b0babb2-5737-417a-918f-a3935ad7202d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(875), 0, "", 4, "Flauta", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(875), 2.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("1b5352a6-d14a-42f3-af3e-93fdbcd6d453"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9943), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 8, 0, "Clava Grande", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9943), 2.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("1d46c734-97da-4258-afef-2f8bdaafd1e8"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(867), 0, "", 4, "Suprimentos de Caligrafia", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(867), 10.0, 2.5 },
                    { new Guid("2031f668-360a-4680-a317-31c0dbf8d508"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(453), 0, "", 4, "Cristal", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(453), 10.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("20f39ed2-d8ac-433f-afd5-2f3d87cf45cd"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(48), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Machado Grande", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(48), 30.0, 3.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("24c1bd99-55e3-4018-bbc4-e115b08dcdff"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(400), 0, "", 4, "Apito de advertência", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(400), 25.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("26130ea2-dd33-44e0-9d14-c435f355d5bd"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9975), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Espada Curta", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9975), 10.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("27e237ad-cb97-48ab-9edc-a7757498c7a2"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(898), 0, "", 4, "Xadrez do Dragão", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(898), 1.0, 0.25 },
                    { new Guid("288c2d27-15bd-4c79-b6ca-3409e8d3a051"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(785), 0, "", 4, "Ferramentas de Pedreiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(785), 10.0, 4.0 },
                    { new Guid("2a309414-e5c4-4795-bad6-c6130fc8cc44"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(624), 0, "", 4, "Amuleto", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(624), 5.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2c251892-a0e6-428d-9754-4e7fa3565ba0"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9951), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Martelo Leve", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9951), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3251f23c-b581-4987-9d0f-a53422e56253"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(600), 0, "Esse estojo de madeira pode \r\narmazenar até 20 virotes de besta.", 4, "Porta virotes", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(600), 1.0, 0.5 },
                    { new Guid("3407ebb8-8174-44fc-846a-d83aa6a795fd"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(879), 0, "", 4, "Lira", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(879), 30.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3546aa1a-12f4-44b9-b8bc-f49fa15a527e"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9966), 1, 2, "Armas Simples à Distância", 1, 4, 0, "Funda", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9966), 1.0, 0.0 },
                    { new Guid("364cfb10-9512-4dd1-a16a-b03295d82208"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9941), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Bordão", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9941), 2.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("36601da2-797c-49a5-935c-081513cc37aa"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(887), 0, "", 4, "Xilofone", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(887), 25.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("370c9670-115a-4361-a9c6-4473fec55768"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9914), 0, 1, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Adaga", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9914), 2.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("37e64586-b2a0-4f25-a19d-53ae14782af8"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(770), 0, "", 4, "Ferramentas de Carpinteiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(770), 8.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("39db57f3-58d5-4884-9777-b2651ec25338"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(59), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Tridente", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(59), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3c1b3466-fc90-4835-a05e-83a13e711943"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(883), 0, "", 4, "Tambor", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(883), 6.0, 1.5 },
                    { new Guid("3f6196f6-def6-4bd6-950d-d3433a8f0e39"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(632), 0, "Um abrigo simples e portátil que acomoda \r\nduas pessoas.", 4, "Tenda para duas pessoas", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(632), 2.0, 10.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("41d48983-a930-4ac5-bbf1-03617770016b"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9945), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Foice Curta", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9945), 1.0, 1.0 },
                    { new Guid("42cc2f62-8737-4d23-aec7-a0779367d66a"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9949), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Machadinha", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9949), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("44cfbeea-4888-41f8-869a-15c161997323"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(476), 0, "Essencial para os magos, um grimório é \r\num volume encadernado em couro com 100 páginas de \r\npergaminhos em branco, adequado para armazenar \r\nmagias.", 4, "Grimório", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(476), 50.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("45b78d6e-480f-4d54-bb58-50aa1e79db17"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(65), 0, 1, "Armas Marciais à Distância", 1, 10, 0, "Besta Pesada", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(65), 50.0, 4.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("45c33100-5b28-4946-ad35-5d4bc4a834c6"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(397), 0, "", 4, "Ampulheta", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(397), 25.0, 0.5 },
                    { new Guid("46aa3fd4-16ff-4018-aebd-6acbc5308411"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(878), 0, "", 4, "Gaita de Foles", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(878), 30.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4888f81e-08a7-4e24-9515-ba86d14a3678"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(58), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Rapieira", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(58), 25.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("49cda751-02be-4684-b7ed-cab4044eefd4"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(888), 0, "Essa bolsa de cosméticos, tintura de \r\ncabelo e pequenos adereços permite criar disfarces que \r\nmudam sua aparência física. Proficiência com este kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar um disfarce \r\nvisual.", 4, "Kit de Disfarce", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(888), 25.0, 1.5 },
                    { new Guid("4dde91ef-4d66-4b66-9e02-47a890636a3a"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(889), 0, "Essa pequena caixa contém uma \r\nvariedade de papéis e pergaminhos, canetas e tintas, \r\nselos e lacres, folha de ouro e prata, e outros suprimentos \r\nnecessários para criar falsificações convincentes de \r\ndocumentos físicos. Proficiência com esse kit permite \r\nadicionar o bônus de proficiência para quaisquer testes de \r\nhabilidade que você fizer para criar uma falsificação de \r\num documento físico.", 4, "Kit de Falsificação", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(889), 15.0, 2.5 },
                    { new Guid("4edad7ce-8c24-4fcc-9bd3-38bbaa924a54"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(865), 0, "", 4, "Suprimentos de Cervejeiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(865), 20.0, 4.5 },
                    { new Guid("4fb73ee5-6251-4136-bb3f-a33866c186b4"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(444), 0, "", 4, "Espelho de aço", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(444), 5.0, 0.25 },
                    { new Guid("500a5fc9-f5dc-4b9b-a4ac-b18f61d1674d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(873), 0, "Esse conjunto de ferramentas inclui uma pequena pasta, um conjunto de \r\nchaves mestras, um pequeno espelho montado em uma \r\nalça de metal, um conjunto de tesouras de lâminas \r\nestreitas e um par de alicates. Proficiência com essas \r\nferramentas permite adicionar o bônus de proficiência \r\npara quaisquer testes de habilidade que você fizer para \r\ndesarmar armadilhas ou abrir fechaduras.", 4, "Ferramentas de ladrão", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(873), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("51ee0f05-0ac4-44fe-bba6-cda62696c594"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9947), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Maça", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9947), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("525a5f65-8fec-441f-9286-7ff0bcf69349"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(387), 0, "Usando uma ação, você pode espalhar o \r\nconteúdo desse frasco em uma criatura a até 1,5 metro de \r\nvocê ou arremessar a até 6 metros, quebrando o frasco \r\ncom o impacto. Em ambos os casos, você deve realizar um \r\nataque à distância contra uma criatura alvo, tratando a \r\nágua benta como uma arma improvisada. Se o alvo for um \r\ncorruptor ou morto-vivo, ele sofre 2d6 de dano radiante. ", 4, "Água benta (frasco)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(387), 25.0, 0.5 },
                    { new Guid("53a853f4-5c70-4edb-bf2e-b4d7c0adec91"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(449), 0, "", 4, "Bastão", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(449), 10.0, 1.0 },
                    { new Guid("5532d7d4-f59d-4378-95a0-9ab18320c2ec"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(585), 0, "Usar um pé de cabra concede vantagem \r\nnos testes de Força onde uma alavanca possa ser \r\naplicada.", 4, "Pé de cabra", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(585), 2.0, 2.5 },
                    { new Guid("5567c39a-34c7-47bc-8028-a16b82a2488c"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(467), 0, "", 4, "Varinha de teixo", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(467), 10.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5b3e6848-b24a-4c01-b0e3-930cfdb1c97d"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9968), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Alabarda", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9968), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("5c255920-86aa-412f-a15d-8c23f76b5460"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(886), 0, "", 4, "Violino", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(886), 30.0, 3.0 },
                    { new Guid("5daf5298-9e63-4197-b5ef-0aab78a4459e"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(436), 0, "Este kit inclui uma vara \r\nde pesca de madeira, linha de seda, boias de cortiça, \r\nanzóis de aço, chumbadas, iscas e redes de pesca.", 4, "Equipamento de pescaria", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(436), 1.0, 2.0 },
                    { new Guid("5dbd6e5a-9399-49ec-a6b2-521bc490bb17"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(564), 0, "", 4, "Mochila", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(564), 2.0, 2.5 },
                    { new Guid("5f279228-5a74-4c8d-aa5e-8751a98813c0"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(617), 2, "", 4, "Sabão", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(617), 2.0, 0.0 },
                    { new Guid("61480f7c-9f5a-496d-a327-bde26ec9b538"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(868), 0, "", 4, "Utensílios de Cozinheiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(868), 1.0, 4.0 },
                    { new Guid("6497b3cc-9d9c-42c0-9333-8d99150b8d4d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(478), 2, "", 4, "Jarra", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(478), 4.0, 2.0 },
                    { new Guid("651c1e02-7afd-428e-af31-ca207915dccd"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(429), 1, "", 4, "Cobertor de inverno", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(429), 5.0, 1.5 },
                    { new Guid("6526625a-9348-4923-9fe7-d750152893d6"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(774), 0, "", 4, "Ferramentas de Cartógrafo", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(774), 15.0, 3.0 },
                    { new Guid("6554bf77-d014-4e43-a564-eba2dd37f052"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(598), 0, "Esse estojo \r\ncilíndrico de couro pode armazenar até 10 folhas de papel \r\nenroladas ou 5 folhas de pergaminhos enroladas.", 4, "Porta mapas ou pergaminhos", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(598), 1.0, 0.5 },
                    { new Guid("6769c805-2c47-4342-a9a4-f4693a9fbe18"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(582), 1, "", 4, "Papel (uma folha)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(582), 2.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("68c24708-bcaf-4341-b5e9-c80bca26bc61"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9978), 0, 0, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Espada Grande", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9978), 50.0, 3.0 },
                    { new Guid("68ee2d5f-52db-425e-bec0-92f2a5f93d04"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9958), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Porrete", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9958), 1.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("69a767f2-93fe-46be-8742-d71024c80231"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(776), 0, "", 4, "Ferramentas de Coureiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(776), 5.0, 2.5 },
                    { new Guid("6a436eed-e0ec-4504-8671-501c78b669fc"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(621), 2, "", 4, "Saco", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(621), 1.0, 0.25 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6c50f2de-91a1-4c4e-8be7-fa87f9e5065c"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9971), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 4, 0, "Chicote", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9971), 2.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6f19d72e-a592-4b8e-8313-4a96554720ed"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(629), 0, "", 4, "Sinete", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(629), 5.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("720eabf0-1b70-4e69-9e42-e52d964a6060"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(46), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Maça Estrela", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(46), 15.0, 2.0 },
                    { new Guid("76a68ed1-b5a6-48f4-a2e8-9a287193dc5f"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9960), 0, 1, "Armas Simples à Distância", 1, 6, 0, "Arco Curto", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9960), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("776717a3-48c5-4964-8161-0e94c5aae4e9"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(409), 0, "Trata-se de uma pequena \r\nbalança, pratos e um sortimento adequado de pesos de até \r\n1 kg. Com ela, você pode medir o peso exato de pequenos \r\nobjetos, como metais preciosos brutos ou bens comerciais, \r\npara ajudar a determinar seu valor.", 4, "Balança de mercador", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(409), 5.0, 1.5 },
                    { new Guid("7b10bf33-0316-4669-8333-1edfba3e87f3"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(627), 0, "", 4, "Relicário", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(627), 5.0, 1.0 },
                    { new Guid("7bb45d0c-5e76-4761-8900-6a0da857cd5c"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(590), 2, "", 4, "Pedra de amolar", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(590), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7c226e41-5ab6-45ee-8229-3830b86d3549"), 2, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(747), 0, "Um personagem que beber o líquido\r\nvermelho mágico deste frasco recupera 2d4+2 pontos de\r\nvida. Beber ou administrar uma poção exige uma ação.", 4, 2, 0, 2, "Poção de Cura", 2, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(747), 50.0, 0.25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7c68471d-9908-412a-b9dd-b72ac88ae2aa"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(469), 2, "", 4, "Frasco", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(469), 2.0, 1.0 },
                    { new Guid("7c8a88d6-4461-48a6-ac40-3d76149ff70d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(640), 2, "Por uma hora, a vela emana luz plena em um \r\nraio de 1,5 metro e penumbra por mais 1,5 metro.", 4, "Vela", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(640), 1.0, 0.0 },
                    { new Guid("7e126980-5ff6-479e-8e22-60bcf05bc1bf"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(884), 0, "", 4, "Trombeta", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(884), 3.0, 1.0 },
                    { new Guid("7f213931-d4a7-42e0-83cf-3d4ce154638f"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(606), 1, "Consistem em alimentos desidratados adequados para viagens longas, \r\nincluindo carne seca, frutas secas, bolachas e nozes. ", 4, "Rações de viagem (1 dia)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(606), 5.0, 1.0 },
                    { new Guid("7fa9a8db-3753-4a59-9f28-83fe969fc83c"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(389), 0, " Essas algemas de metal podem prender \r\numa criatura Pequena ou Média. Escapar das algemas \r\nexige sucesso em um teste de Destreza CD 20. Quebrá-las \r\nexige um teste de Força CD 20 bem sucedido. Cada \r\nconjunto de algemas vem com uma chave. Sem a chave, \r\numa criatura proficiente com ferramentas de ladrão pode \r\nabrir a fechadura das algemas com um sucesso em um \r\nteste de Destreza CD 15. As algemas têm 15 pontos de \r\nvida. ", 4, "Algemas", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(389), 2.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7fe68072-257d-4585-b7a1-1ad8c1d7c092"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(52), 0, 2, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Malho", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(52), 10.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("80ac34a8-f47c-41ce-92a2-5d2fa7e11572"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(779), 0, "", 4, "Ferramentas de Ferreiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(779), 20.0, 4.0 },
                    { new Guid("82504d35-ffec-4425-8cea-3898920c6500"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(781), 0, "", 4, "Ferramentas de Joalheiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(781), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("827490f7-9953-46e1-962f-b8b68d4d88f8"), 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(749), 0, "Você pode usar o veneno contido\r\nnesse vidro para cobrir a lâmina de uma arma cortante ou\r\nperfurante ou até três peças de munição. Aplicar o veneno\r\nleva uma ação. Uma criatura atingida pela arma ou\r\nmunição envenenada deve obter sucesso em um teste de\r\nresistência de Constituição CD 10 ou sofrerá 1d4 de dano\r\nde veneno. Uma vez aplicado, o veneno retém sua\r\npotência durante 1 minuto antes de secar.", 4, 1, 1, 2, "Veneno básico (frasco)", 2, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(749), 100.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("8443322c-e184-4b92-8247-cd19fb2f5926"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(864), 0, "", 4, "Suprimentos de Alquimista", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(864), 50.0, 4.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("84f3a6fb-e48b-408c-b3b0-b1bf5749ff9d"), 2, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(750), 0, "Esse líquido pegajoso e adesivo\r\ninflama em contado com o ar. Usando uma ação, você\r\npode arremessar esse frasco a até 6 metros de distância,\r\nquebrando-o com o impacto. Você deve realizar um ataque\r\nà distância contra uma criatura ou objeto, tratando o fogo\r\nalquímico como uma arma improvisada. Em um sucesso,\r\no alvo sofre 1d4 de dano de fogo no início de cada um de\r\nseus turnos. Uma criatura pode terminar esse dano\r\nusando sua ação e fazendo um teste de Destreza CD 10\r\npara apagar as chamas.", 4, 2, 0, 2, "Fogo alquímico (frasco)", 2, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(750), 50.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8874fa9e-3c74-4869-a5fc-7920065afe2b"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(597), 2, "", 4, "Piton", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(597), 5.0, 0.0 },
                    { new Guid("88fa4d93-8089-4086-a218-800780c6e0a6"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(609), 0, "Um conjunto de roldanas com um \r\ncabo entre elas e um gancho para fixar aos objetos, a \r\nroldana e polia permitem içar até quatro vezes o peso que \r\nvocê ergueria normalmente.", 4, "Roldana e polia", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(609), 1.0, 2.5 },
                    { new Guid("89291fe1-6390-4502-99fc-b975e1ef2b2f"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(555), 0, "Um livro pode conter poesia, relatos históricos, \r\ninformações relativas a um campo particular de \r\nsabedoria, diagramas e notas sobre engenhocas gnômicas, \r\nou qualquer outra coisa que possa ser representada \r\nusando texto ou imagens.", 4, "Livro", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(555), 25.0, 2.5 },
                    { new Guid("8949a2bc-938e-4363-aab7-af884ba2cc8d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(458), 0, "", 4, "Varinha", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(458), 10.0, 0.5 },
                    { new Guid("8b09c64b-925f-4a0c-8434-d7a47ba7c9f0"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(895), 1, "", 4, "Conjunto de Dados", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(895), 1.0, 0.0 },
                    { new Guid("8d52d12d-a350-402e-bfa4-409afdccf6ba"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(438), 1, "", 4, "Escada (3 metros)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(438), 1.0, 12.5 },
                    { new Guid("8e16678f-50d3-458a-8c2a-d57046859399"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(880), 0, "", 4, "Oboé", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(880), 2.0, 0.5 },
                    { new Guid("91296344-06c9-4f16-84c6-6fdf65335bb6"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(608), 0, "", 4, "Robes", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(608), 1.0, 2.0 },
                    { new Guid("91a0c970-d8c5-4605-9c30-06a73470c0b8"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(395), 0, "Uma aljava pode guardar até 20 flechas.", 4, "Aljava", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(395), 1.0, 0.5 },
                    { new Guid("937b3ba5-030c-4908-8673-bb3fc32a9de0"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(616), 0, "", 4, "Roupas finas", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(616), 15.0, 3.0 },
                    { new Guid("95706dec-c38f-46d7-b8e1-5cd54bb362a4"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(591), 0, "", 4, "Perfume (frasco)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(591), 5.0, 0.0 },
                    { new Guid("98ca7137-1c31-4d87-83b8-de43767e5739"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(442), 0, "Usando uma ação, você pode \r\ndespejar essas minúsculas esferas de metal para cobrir a \r\nárea de um quadrado de 3 metros de lado. A criatura que \r\nse mover dentro da área deve ser bem sucedida em um \r\nteste de resistência de Destreza CD 10 para não cair no \r\nchão. Uma criatura que mover pela área usando metade \r\ndo seu deslocamento não precisa fazer o teste de \r\nresistência.", 4, "Esferas (sacola com 1.000)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(442), 1.0, 1.0 },
                    { new Guid("9ad20669-1a0d-4060-b835-cf10ea25846e"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(402), 0, " Você pode usar um aríete portátil \r\npara quebrar portas. Ao fazer isso, você ganha um bônus \r\nde +4 no teste de Força. Outra criatura pode ajudá-lo a \r\nusar o aríete, o que concede vantagem no teste.", 4, "Ariete portátil", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(402), 4.0, 17.5 },
                    { new Guid("9f028534-ae62-497e-9fed-1dd1e1eb6003"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(487), 0, "Uma lanterna coberta lança luz \r\nplena em um raio de 9 metros e penumbra por mais 9 \r\nmetros. Uma vez acesa, ela queima por 6 horas usando \r\num frasco de óleo (500 ml). Usando uma ação, você pode \r\nabaixar a cobertura, reduzindo a claridade para \r\npenumbra em um raio de 1,5 metro.", 4, "Lanterna coberta", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(487), 5.0, 1.0 },
                    { new Guid("a0991c64-53a8-4594-bfec-135558905499"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(622), 0, "", 4, "Saco de dormir", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(622), 1.0, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a2ba318f-8026-4571-9eb3-e7085b33691e"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(54), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Mangual", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(54), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a416b65a-c603-4634-a9b9-f426062ad46a"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(611), 1, "", 4, "Roupas comuns", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(611), 5.0, 1.5 },
                    { new Guid("a43d2ab2-a484-47f3-a4fa-81ad188deba2"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(775), 0, "", 4, "Ferramentas de Costureiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(775), 1.0, 2.5 },
                    { new Guid("a4d0dc47-8b1f-4961-b947-36ff7288efcc"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(614), 0, "", 4, "Roupas de entretenimento", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(614), 5.0, 2.0 },
                    { new Guid("a6589029-a7c2-4d79-8a4b-feb364240402"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(630), 0, "", 4, "Sino", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(630), 1.0, 0.0 },
                    { new Guid("a6877f0e-3a47-436a-bdaf-fb999665dd3e"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(419), 2, "", 4, "Caneca", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(419), 2.0, 0.5 },
                    { new Guid("aca6ee69-c57a-4bc5-bb86-91b0be4bf6bc"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(874), 0, "", 4, "Alaúde", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(874), 35.0, 1.0 },
                    { new Guid("acae45de-27bd-4970-b1f4-41b25e1de14d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(480), 0, "Um kit de escalada inclui pítons \r\nespeciais, botas com solas pontiagudas, luvas e um cinto. \r\nVocê pode usar o kit de escalada como uma ação para \r\n\"ancorar-se\". Quando faz isso, você não pode cair mais de \r\n7,5 metros a partir do ponto onde se ancorou, e não pode \r\nsubir mais de 7,5 metros de distância desse ponto, sem \r\ndesfazer a âncora.", 4, "Kit de escalada", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(480), 25.0, 6.0 },
                    { new Guid("aeb67f1b-a4da-40cb-8f98-a458c9f55b67"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(454), 0, "", 4, "Orbe", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(454), 20.0, 1.5 },
                    { new Guid("afd1d751-cfa0-4c90-8edb-0aa3e49bf593"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(782), 0, "", 4, "Ferramentas de Oleiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(782), 10.0, 1.5 },
                    { new Guid("b22866dc-c0d1-4913-b044-1b62c4a48aa9"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(636), 2, "A tocha queima por 1 hora, fornecendo luz \r\nplena em um raio de 6 metros e penumbra por mais 6 \r\nmetros. Se você realizar um ataque corpo-a-corpo com \r\numa tocha acesa e acertar, causa 1 de dano flamejante.", 4, "Tocha", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(636), 1.0, 0.5 },
                    { new Guid("b396851e-f5c4-491c-b33c-4a2b9d259f59"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(488), 0, "Uma lanterna furta-fogo \r\nlança luz plena em um cone de 18 metros e penumbra por \r\nmais 18 metros. Uma vez acesa, ela queima por 6 horas \r\nusando um frasco de óleo (500 ml).", 4, "Lanterna furta-fogo", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(488), 10.0, 1.0 },
                    { new Guid("b6d2e2c1-f296-4840-9bee-57dc39699187"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(398), 0, "Uma criatura que beber o líquido desse \r\nvidro tem vantagem em testes de resistência contra \r\nvenenos por 1 hora. O antídoto não confere nenhum \r\nbenefício para mortos-vivos ou constructos. ", 4, "Antídoto (vidro)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(398), 50.0, 0.0 },
                    { new Guid("b85fe3d6-cc1b-468f-82dd-972d20a7c4ae"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(566), 2, "", 4, "Balas de Funda (20)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(566), 4.0, 0.75 },
                    { new Guid("b96bb689-5341-4656-b177-e78bc3afb057"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(559), 0, "", 4, "Manto", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(559), 1.0, 2.0 },
                    { new Guid("b9b1b516-b07a-42ec-ad60-733dc6c45cfa"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(431), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de cânhamo (15 metros)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(431), 1.0, 5.0 },
                    { new Guid("ba01b2f4-1873-4244-a74f-df095a89288d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(595), 0, "", 4, "Picareta de minerador", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(595), 2.0, 5.0 },
                    { new Guid("bab64e08-fa5d-4ba7-acaa-cb4471582dfa"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(411), 2, "", 4, "Balde", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(411), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("bb0c88d8-0c0e-44ae-89c5-5a41c8c2a91f"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(55), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Martelo de Guerra", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(55), 15.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("bbb475a4-3cd3-46d5-90ca-c0100b0feaa7"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(451), 0, "", 4, "Cajado", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(451), 5.0, 2.0 },
                    { new Guid("bcdd9291-adac-4efd-bfa5-a8dca28050b1"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(567), 0, "", 4, "Flechas (20)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(567), 1.0, 0.5 },
                    { new Guid("bdd2791a-1392-4b11-81fe-7e1aa34b0e82"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(462), 0, "", 4, "Ramo de visco", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(462), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("be9e57e4-3bb6-4bf2-829e-697662e67f93"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9962), 0, 1, "Armas Simples à Distância", 1, 8, 0, "Besta Leve", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9962), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("bf96575e-55f9-49e6-9c05-12c0811473c3"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(891), 0, "Esse kit contém uma variedade \r\nde instrumentos, como alicates, almofariz e pilão, e bolsas \r\ne frascos utilizados pelos herbalistas para criar remédios \r\ne poções. Proficiência com este kit permite adicionar o \r\nbônus de proficiência para quaisquer testes de habilidade \r\nque você fizer para identificar ou aplicar ervas. Além \r\ndisso, a proficiência com esse kit é necessária para criar \r\nantídotos e poções de cura.", 4, "Kit de Herbalismo", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(891), 5.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("bfbbd5d2-6472-4294-9916-599b62869543"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9964), 2, 1, "Armas Simples à Distância", 1, 4, 0, "Dardo", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9964), 5.0, 0.10000000000000001 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c0b7d5be-bfb5-4d9a-a789-0169adc88cc2"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(482), 0, "Esse kit é uma bolsa de \r\ncouro contendo ataduras, pomadas e talas. O kit possui \r\nmaterial suficiente para dez usos. Usando uma ação, você \r\npode gastar um uso do kit para estabilizar uma criatura \r\nque tenha 0 pontos de vida, sem a necessidade de realizar \r\num teste de Sabedoria (Medicina).", 4, "Kit de primeiros-socorros", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(482), 5.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c0bcd7cb-aa7a-4c7f-ac6c-80470f85bf5d"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9982), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Glaive", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9982), 20.0, 3.0 },
                    { new Guid("c0cae5e7-808c-4182-b6c0-c1394d3ed62c"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(45), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Lança Longa", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(45), 5.0, 4.0 },
                    { new Guid("c150c17d-e9fa-41ad-8910-5d7a59b4af65"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9984), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 12, 0, "Lança de Montaria", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9984), 10.0, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c542607c-692a-4d0a-9300-725abd0209a1"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(472), 2, "", 4, "Giz (1 peça)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(472), 1.0, 0.0 },
                    { new Guid("c5abc616-93c2-41cc-810a-900397f5de07"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(562), 0, "", 4, "Martelo", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(562), 1.0, 1.5 },
                    { new Guid("c6631b64-ab85-44bd-97da-e8278adeb9c3"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(777), 0, "", 4, "Ferramentas de Entalhador", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(777), 1.0, 2.5 },
                    { new Guid("c9416dab-0834-4223-8763-28f28c1a12df"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(584), 1, "", 4, "Parafina", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(584), 5.0, 0.0 },
                    { new Guid("c97db69d-a821-4d7d-860e-11c70c71b63e"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(780), 0, "", 4, "Ferramentas de Funileiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(780), 50.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("cbbdac3c-905c-445b-9fb1-da0d2a39e777"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(51), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Machado de Batalha", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(51), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("ced0358b-0fc6-4b98-a3e7-02ef5a74eaf1"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(434), 0, "Uma corrente possui 10 pontos de vida e \r\npode ser arrebentada com um teste de Força CD 20 bem \r\nsucedido.", 4, "Corrente (3 metros)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(434), 5.0, 5.0 },
                    { new Guid("cf60dd0f-600f-4578-885d-168a76709900"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(580), 0, "", 4, "Panela de ferro", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(580), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d0bca771-c707-4fac-a0ff-aa1637a03770"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(67), 0, 1, "Armas Marciais à Distância", 0, 1, 0, "Rede", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(67), 1.0, 1.5 },
                    { new Guid("d1ce6b5f-8c09-4490-9d49-20c9f38b65c8"), new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9970), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Cimitarra", 0, new DateTime(2024, 6, 4, 11, 37, 25, 950, DateTimeKind.Local).AddTicks(9970), 25.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d28a0b5e-4488-41a1-9179-fc5b90f0bf9c"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(560), 0, "", 4, "Marreta", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(560), 2.0, 5.0 },
                    { new Guid("d468b4f4-6a5d-465a-a9c1-bdba0c65f3cc"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(863), 0, "", 4, "Ferramentas de Vidreiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(863), 30.0, 2.5 },
                    { new Guid("d578d5ef-e0aa-44d4-aa5f-da8e813af28d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(393), 0, "Uma bolsa de pano ou couro que pode \r\narmazenar até 20 munições de funda ou 50 munições de \r\nzarabatana, entre outras coisas. Para armazenar \r\ncomponentes de magia, veja bolsa de componentes, \r\ntambém descrita nessa seção.", 4, "Algibeira", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(393), 5.0, 0.5 },
                    { new Guid("d5c092a2-d1fa-45c6-a1b8-2b4b679db8a5"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(427), 1, "", 4, "Cesto", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(427), 4.0, 1.0 },
                    { new Guid("dd5833f5-0336-4d95-8b4d-9c32012d43a8"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(416), 0, "Trata-se de uma pequena \r\nbolsa de couro à prova d'água que pode ser fixada em um \r\ncinto. Ela possui compartimentos para armazenar todos \r\nos componentes materiais e outros itens especiais que \r\nvocê precisa para lançar suas magias, exceto os \r\ncomponentes que possuem um custo específico (conforme \r\nindicado na descrição da magia).", 4, "Bolsa de componentes", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(416), 25.0, 1.5 },
                    { new Guid("dddb1661-58d2-4a6c-bd15-baa000b3acaa"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(543), 0, "Essa lente permite ver pequenos \r\nobjetos mais de perto. Ela também é útil como um \r\nsubstituto da pederneira e isqueiro para acender fogo. \r\nUsar uma lupa para acender fogo necessita de luz tão \r\nbrilhante como a luz do sol para focar, um pavio e cerca \r\nde 5 minutos. Uma lente de aumento concede vantagem \r\nem qualquer teste de habilidade feito para avaliar ou \r\ninspecionar um item que é pequeno ou muito detalhado.", 4, "Lente de aumento", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(543), 100.0, 0.0 },
                    { new Guid("de7172f8-a86d-4661-a294-3bb01d0c480b"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(421), 2, "", 4, "Caneta tinteiro", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(421), 2.0, 0.0 },
                    { new Guid("e0433a6e-8d3c-4af2-9406-4e05691edb2c"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(637), 0, "", 4, "Tinta (frasco de 30ml)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(637), 10.0, 0.0 },
                    { new Guid("e25c0638-5c54-48aa-8e47-ac88817fbd04"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(425), 1, "", 4, "Cantil", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(425), 2.0, 2.5 },
                    { new Guid("e3f4c5c4-5045-4b47-891f-7900be1df418"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(787), 0, "", 4, "Ferramentas de Pintor", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(787), 10.0, 2.5 },
                    { new Guid("e6b6fb80-55be-44fe-9cfb-86d52b37beab"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(485), 1, "Uma lâmpada lança luz plena em um raio \r\nde 4,5 metros e penumbra por mais 9 metros. Uma vez \r\nacesa, a lâmpada queima por 6 horas usando um frasco de \r\nóleo (500 ml).", 4, "Lâmpada", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(485), 5.0, 0.5 },
                    { new Guid("e8a44153-fb86-4ba7-94e0-b1dd3993b159"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(861), 0, "", 4, "Ferramentas de Sapateiro", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(861), 5.0, 2.5 },
                    { new Guid("ea5f97c1-3409-4f2e-b347-5a548e408e4a"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(577), 1, "Geralmente vem em um frasco de argila que \r\ncontém 500 ml. Usando uma ação, você pode espirrar o \r\nóleo desse frasco em uma criatura a até 1,5 metro de você\r\nou arremessar a até 6 metros, quebrando-o com o \r\nimpacto. Você deve realizar um ataque à distância contra \r\numa criatura ou objeto, tratando o óleo como uma arma \r\nimprovisada. Com um sucesso, o alvo é coberto de óleo. Se \r\no alvo sofrer qualquer dano flamejante antes do óleo secar\r\n (depois de 1 minuto), a criatura sofre 5 de dano \r\nflamejante adicional pela queima do óleo. Você também \r\npode derramar um frasco de óleo no chão para cobrir uma \r\nárea de um quadrado de 1,5 metro de lado, desde que a \r\nsuperfície esteja nivelada. Se aceso, o óleo queima por 2 \r\nrodadas e causa 5 de dano flamejante a qualquer criatura \r\nque entrar na área ou terminar seu turno dentro da área. \r\nUma criatura pode sofrer esse dano apenas uma vez por \r\nturno.", 4, "Óleo (frasco)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(577), 1.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("eb409a79-81d4-47ed-b195-17e073f9e105"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(68), 0, 1, "Armas Marciais à Distância", 1, 1, 0, "Zarabatana", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(68), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("ebdb080a-035b-4988-ae99-1d5b386de4ea"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(433), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de seda (15 metros)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(433), 10.0, 2.5 },
                    { new Guid("ecd04814-070f-4e48-bf2b-aa1583ce3bbe"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(414), 0, "", 4, "Baú", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(414), 5.0, 12.5 },
                    { new Guid("eefa3873-9f78-4674-a84f-8338eb0b3048"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(613), 0, "", 4, "Roupas de viajante", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(613), 2.0, 2.0 },
                    { new Guid("ef8c0601-6a41-4486-97b3-e05985e08baf"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(446), 0, "Usando uma ação, você pode espalhar um \r\núnico saco de estrepes para cobrir a área de um quadrado \r\nde 1,5 metro de lado. Qualquer criatura que entrar na \r\nárea deve ser bem sucedida em um teste de resistência de \r\nDestreza CD 15. Se falhar, para de se mover e sofre 1 de \r\ndano perfurante. Até que a criatura recupere pelo menos \r\n1 ponto de vida, seu deslocamento de caminhada é \r\nreduzido em 3 metros. Uma criatura que se mover pela \r\nárea usando metade do seu deslocamento não precisa \r\nfazer o teste de resistência.", 4, "Estrepes (bolsa com 20)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(446), 1.0, 1.0 },
                    { new Guid("efb11127-78f5-4b4f-bdb9-3736d0645f7c"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(602), 0, "", 4, "Pregos de ferro (10)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(602), 1.0, 2.5 },
                    { new Guid("eff648dc-56a5-4771-b8e9-6d279957646f"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(471), 0, "", 4, "Garrafa de vidro", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(471), 1.0, 1.0 },
                    { new Guid("f165240a-53f4-4578-8e06-1612896e4175"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(557), 0, "Objetos vistos através de uma luneta são \r\nampliados até o dobro do seu tamanho.", 4, "Luneta", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(557), 1000.0, 0.5 },
                    { new Guid("f327c959-b080-420e-a28e-9fbc7c0e707d"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(578), 0, "", 4, "Pá", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(578), 2.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f3960bfb-a2f6-45d1-963c-a9998b53ad6a"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(64), 0, 1, "Armas Marciais à Distância", 1, 6, 0, "Besta de Mão", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(64), 75.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f5f41fbc-9331-4565-8520-d7f80cbec9e5"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(892), 1, "", 4, "Baralho de Cartas", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(892), 5.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f66b07bf-f62f-4ce5-aeda-3cb2492ddc32"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(57), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Picareta de Guerra", 0, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(57), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("f9447469-b2bd-4625-9eb4-705773e3d55e"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(385), 0, "", 4, "Ácido (vidro)", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(385), 25.0, 0.5 },
                    { new Guid("fad8349b-1275-4e48-8e33-a61e3e0c7ff4"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(871), 0, "Esse conjunto de instrumentos é usado para navegação no mar. \r\nProficiência com as ferramentas de navegador permite \r\ntraçar um curso de navio e seguir cartas de navegação. \r\nAlém disso, essas ferramentas permitem que você \r\nadicione seu bônus de proficiência para qualquer teste de \r\nhabilidade que fizer para não se perder no mar. ", 4, "Ferramentas de navegação", 3, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(871), 25.0, 1.0 },
                    { new Guid("fd4129ab-e30c-4372-884a-33f8ce3786ad"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(625), 0, "", 4, "Emblema", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(625), 5.0, 0.0 },
                    { new Guid("fe390b3a-ef20-48d2-a5d2-fbfb9323ada4"), new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(412), 0, "", 4, "Barril", 4, new DateTime(2024, 6, 4, 11, 37, 25, 951, DateTimeKind.Local).AddTicks(412), 2.0, 35.0 }
                });
        }
    }
}
