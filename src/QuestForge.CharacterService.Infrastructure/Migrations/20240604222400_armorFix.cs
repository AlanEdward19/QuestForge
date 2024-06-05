using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestForge.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class armorFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ArmorType",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0aca6548-0d66-4174-b9ec-60e38caeb8f5"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(687), "Você tem proficiência na perícia \r\nPercepção.", "Sentidos Aguçados", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(687) },
                    { new Guid("17938f1b-e016-44d0-81ca-ce5170e62c86"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(698), "Você pode mover-se através do \r\nespaço de qualquer criatura que for de um tamanho maior \r\nque o seu.", "Agilidade Halfling", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(698) },
                    { new Guid("28bca5ed-4fd9-4b91-ad40-c2a5c5ef2de0"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(703), "Você conhece o truque ilusão \r\nmenor. Inteligência é a sua habilidade usada para \r\nconjurá-la.", "Ilusionista Nato", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(703) },
                    { new Guid("3982aa81-0933-4c50-b34e-a2deeafca105"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(688), "Você tem vantagem nos testes de \r\nresistência para resistir a ser enfeitiçado e magias não \r\npodem colocá-lo para dormir.", "Ancestral Feérico", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(688) },
                    { new Guid("47be69f8-d1ed-4686-8fc5-d7e086063fdc"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(705), "Toda vez que você fizer \r\num teste de Inteligência (História) relacionado a itens \r\nmágicos, objetos alquímicos ou mecanismos tecnológicos, \r\nvocê pode adicionar o dobro do seu bônus de proficiência, \r\nao invés de qualquer bônus de proficiência que você \r\nnormalmente use.", "Conhecimento de Artífice", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(705) },
                    { new Guid("52f7bf51-14de-4e9e-a010-d2e12af34fae"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(699), "Você pode usar uma ação para \r\nexalar energia destrutiva. Seu ancestral dracônico \r\ndetermina o tamanho, formado e tipo de dano que você \r\nexpele. \r\nQuando você usa sua arma de sopro, cada criatura na \r\nárea exalada deve realizar um teste de resistência, o tipo \r\ndo teste é determinado pelo seu ancestral dracônico. A CD \r\ndo teste de resistência é 8 + seu modificador de \r\nConstituição + seu bônus de proficiência. Uma criatura \r\nsofre 2d6 de dano num fracasso e metade desse dano num \r\nsucesso. O dano aumenta para 3d6 no 6° nível, 4d6 no 11° \r\nnível e 5d6 no 16° nível. \r\nDepois de usar sua arma de sopro, você não poderá \r\nutilizá-la novamente até completar um descanso curto ou \r\nlongo.", "Arma de Sopro", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(699) },
                    { new Guid("6a810f92-95b8-419e-8417-decf2d9c0a46"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(683), " Você possui vantagem em testes de \r\nresistência contra venenos e resistência contra dano de \r\nveneno.", "Resiliência Anã", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(683) },
                    { new Guid("78353b39-d8f9-48a4-a349-342952e61709"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(704), "Através de sons e \r\ngestos, você pode comunicar ideias simples para Bestas \r\npequenas ou menores. Gnomos da floresta amam os \r\nanimais e normalmente possuem esquilos, doninhas, \r\ncoelhos, toupeiras, pica-paus e outras criaturas como \r\namados animais de estimação.", "Falar com Bestas Pequenas", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(704) },
                    { new Guid("7c469768-3e0a-4f94-b303-2eb90f1bbf68"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(697), "Você tem vantagem em testes de resistência \r\ncontra ficar amedrontado. ", "Bravura", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(697) },
                    { new Guid("85b509a3-8064-42ac-8c5c-c93d02a3a8a8"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(711), "Quando você atinge um ataque \r\ncrítico com uma arma corpo-a-corpo, você pode rolar um \r\ndos dados de dano da arma mais uma vez e adicioná-lo ao \r\ndano extra causado pelo acerto crítico.", "Ataques Selvagens", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(711) },
                    { new Guid("945b5482-6586-4150-8023-e4e3360d648c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(692), "Você possui \r\ndesvantagem nas jogadas de ataque e testes de Sabedoria \r\n(Percepção) relacionados a visão quando você, o alvo do \r\nseu ataque, ou qualquer coisa que você está tentando \r\nperceber, esteja sob luz solar direta.", "Sensibilidade à Luz Solar", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(692) },
                    { new Guid("962eb7ba-7f49-4818-b86e-7ada317251a7"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(694), "Quando você obtiver um 1 natural em uma \r\njogada de ataque, teste de habilidade ou teste de \r\nresistência, você pode jogar de novo o dado e deve utilizar \r\no novo resultado.", "Sortudo", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(694) },
                    { new Guid("96e99db2-ab5e-4a6a-9363-8608a210e122"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(712), "Você possui resistência a dano \r\nde fogo.", "Resistência Infernal", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(712) },
                    { new Guid("9d08b4c4-6ef7-4141-a96e-c029bde74b51"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(693), "Você possui o truque globos de luz. \r\nQuando você alcança o 3° nível, você pode conjurar a \r\nmagia fogo das fadas. Quando você alcança o 5° nível, \r\nvocê pode conjurar escuridão. Você precisa terminar um \r\ndescanso longo para poder conjurar as magias desse traço \r\nnovamente. Carisma é sua habilidade chave para \r\nconjurar essas magias.", "Magia Drow", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(693) },
                    { new Guid("9d5b3205-f304-4199-8c98-197a19a5f137"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(701), "Você possui resistência ao tipo \r\nde dano associado ao seu ancestral dracônico.", "Resistência a Dano", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(701) },
                    { new Guid("aa795603-e48e-439f-9b6e-e33ce4ca6dd6"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(691), "Você pode tentar se esconder \r\nmesmo quando você está apenas levemente obscurecido  \r\npor folhagem, chuva forte, neve caindo, névoa ou outro \r\nfenômeno natural.", "Máscara da Natureza", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(691) },
                    { new Guid("bda4d22f-4fde-4e2e-ac7e-f01727937e88"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(686), "Sempre que você \r\nrealizar um teste de Inteligência (História) relacionado à \r\norigem de um trabalho em pedra, você é considerado \r\nproficiente na perícia História e adiciona o dobro do seu \r\nbônus de proficiência ao teste, ao invés do seu bônus de \r\nproficiência normal.", "Especialização em Rochas", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(686) },
                    { new Guid("be707ba1-cde1-4685-937d-66ced826c49d"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(708), "Você possui proficiência com \r\nferramentas de artesão (ferramentas de engenhoqueiro). \r\nUsando essas ferramentas, você pode gastar 1 hora e 10 \r\npo em materiais para construir um mecanismo Miúdo (CA \r\n5, 1 pv). O mecanismo para de funcionar após 24 horas (a \r\nnão ser que você gaste 1 hora reparando-o para manter o \r\nmecanismo funcionando), ou quando você usa sua ação \r\npara desmantelá-lo; nesse momento, você pode recuperar \r\no material usado para criá-lo. Você pode ter até três\r\n desses mecanismos ativos ao mesmo tempo.", "Engenhoqueiro", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(708) },
                    { new Guid("ca433277-f6da-4c1d-9963-c0766223328c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(681), "Acostumado à vida subterrânea, \r\nvocê tem uma visão superior no escuro e na penumbra. \r\nVocê enxerga na penumbra a até 18 metros como se fosse \r\nluz plena, e no escuro como se fosse na penumbra. Você \r\nnão pode discernir cores no escuro, apenas tons de cinza.", "Visão no Escuro", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(681) },
                    { new Guid("dc2dbaa2-bd33-4d5a-a450-0cba0c80f132"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(689), "Elfos não precisam dormir. Ao invés disso, \r\neles meditam profundamente, permanecendo \r\nsemiconscientes, durante 4 horas por dia. (A palavra em \r\nidioma comum para tal meditação é \"transe\".) Enquanto \r\nmedita, um elfo é capaz de sonhar de certo modo. Esses \r\nsonhos na verdade são exercícios mentais que se tornam \r\nreflexos através de anos de prática. Depois de descansar \r\ndessa forma, você ganha os mesmos benefícios que um \r\nhumano depois de 8 horas de sono. ", "Transe", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(689) },
                    { new Guid("e5592538-4ee3-4cd4-97b7-accbea14d7f9"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(713), "Você conhece o truque \r\ntaumaturgia. Quando você atingir o 3° nível, você poderá \r\nconjurar a magia repreensão infernal como uma magia de \r\n2° nível. Quando você atingir o 5° nível, você também \r\npoderá conjurar a magia escuridão. Você precisa terminar \r\num descanso longo para poder usar as magias desse traço \r\nnovamente. Sua habilidade de conjuração para essas \r\nmagias é Carisma.", "Legado Infernal", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(713) },
                    { new Guid("ebecb492-cb49-4a17-9eb2-9fcb1b8908f1"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(709), "Quando você é reduzido a \r\n0 pontos de vida mas não é completamente morto, você \r\npode voltar para 1 ponto de vida. Você não pode usar essa \r\ncaracterística novamente até completar um descanso \r\nlongo.", "Resistência Implacável", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(709) },
                    { new Guid("f237402a-18b0-43e7-b7b7-c51155871e00"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(702), "Você possui vantagem em todos \r\nos testes de resistência de Inteligência, Sabedoria e \r\nCarisma contra magia.", "Esperteza Gnômica", new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(702) }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("0170e89a-a505-4f89-98e6-52f3f57ef624"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(567), 0, "", 4, "Ferramentas de Ferreiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(567), 20.0, 4.0 },
                    { new Guid("01929c35-4784-43f3-84e9-9d7bb91304f7"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(611), 0, "", 4, "Xadrez do Dragão", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(611), 1.0, 0.25 },
                    { new Guid("01c847e2-8d34-43ca-a6c9-5eb7706fd63d"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(392), 0, "", 4, "Pá", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(392), 2.0, 2.5 },
                    { new Guid("03cbe4f9-311f-4059-b949-5c1b46c70c03"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(606), 0, "Esse kit contém uma variedade \r\nde instrumentos, como alicates, almofariz e pilão, e bolsas \r\ne frascos utilizados pelos herbalistas para criar remédios \r\ne poções. Proficiência com este kit permite adicionar o \r\nbônus de proficiência para quaisquer testes de habilidade \r\nque você fizer para identificar ou aplicar ervas. Além \r\ndisso, a proficiência com esse kit é necessária para criar \r\nantídotos e poções de cura.", 4, "Kit de Herbalismo", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(606), 5.0, 1.5 },
                    { new Guid("044a2e66-4f1d-4d6e-aa7a-c202704b6283"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(601), 0, "Essa bolsa de cosméticos, tintura de \r\ncabelo e pequenos adereços permite criar disfarces que \r\nmudam sua aparência física. Proficiência com este kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar um disfarce \r\nvisual.", 4, "Kit de Disfarce", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(601), 25.0, 1.5 },
                    { new Guid("0533fe77-f17b-4cb7-aabe-2daabdd131a8"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(585), 0, "Esse conjunto de instrumentos é usado para navegação no mar. \r\nProficiência com as ferramentas de navegador permite \r\ntraçar um curso de navio e seguir cartas de navegação. \r\nAlém disso, essas ferramentas permitem que você \r\nadicione seu bônus de proficiência para qualquer teste de \r\nhabilidade que fizer para não se perder no mar. ", 4, "Ferramentas de navegação", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(585), 25.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("07b0c3c4-ddd3-48c9-a5bd-1511fd1ef462"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(172), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Machado de Batalha", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(172), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("07c0d41d-24d1-46e8-8788-0bea1c56b9a7"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(565), 0, "", 4, "Ferramentas de Entalhador", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(565), 1.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("07f73751-dc2e-4fad-a66f-38e0b0142b38"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(184), 0, 1, "Armas Marciais à Distância", 1, 6, 0, "Besta de Mão", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(184), 75.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("0886f45a-b9ee-4c21-9d36-6ad5ed4b9706"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(352), 0, "", 4, "Cristal", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(352), 10.0, 0.5 },
                    { new Guid("09046a75-24a2-49f3-a7ef-b3c69227e099"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(329), 2, "", 4, "Caneta tinteiro", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(329), 2.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("0967c352-881a-4051-8938-e790cbc5bf01"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(174), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Mangual", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(174), 10.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("0a985225-db98-4dfc-9726-2e3cbb99f6e3"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(560), 0, "", 4, "Ferramentas de Carpinteiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(560), 8.0, 3.0 },
                    { new Guid("0aa2ca10-c304-4d41-bdca-67f20f1ef330"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(357), 0, "", 4, "Ramo de visco", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(357), 1.0, 0.0 },
                    { new Guid("0c085aa4-a2c0-47f4-bec0-e9165200cb1b"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(564), 0, "", 4, "Ferramentas de Coureiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(564), 5.0, 2.5 },
                    { new Guid("0e279628-a3de-4342-8f9a-e3960daaf1d8"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(393), 0, "", 4, "Panela de ferro", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(393), 2.0, 5.0 },
                    { new Guid("0fa7538b-7e4a-458f-b571-61de4d470ca4"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(579), 0, "", 4, "Suprimentos de Cervejeiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(579), 20.0, 4.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("118956a6-403c-44da-9fe3-35434dfad7d7"), 11, 0, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9864), 0, "Consiste em camadas de panos acolchoados e batidos.", 1, 0, 0, 1, "Acolchoada", true, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9864), 5.0, 4.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("132fa4aa-ea6a-424a-85d3-7c7cf5f96fe2"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(307), 0, "Uma bolsa de pano ou couro que pode \r\narmazenar até 20 munições de funda ou 50 munições de \r\nzarabatana, entre outras coisas. Para armazenar \r\ncomponentes de magia, veja bolsa de componentes, \r\ntambém descrita nessa seção.", 4, "Algibeira", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(307), 5.0, 0.5 },
                    { new Guid("15f8e932-9090-4b91-bf48-c86c99190565"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(382), 0, "", 4, "Martelo", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(382), 1.0, 1.5 },
                    { new Guid("16821eda-c402-41ba-8e89-eda5f80c5581"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(355), 0, "", 4, "Cajado de madeira", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(355), 5.0, 2.0 },
                    { new Guid("18eb6462-2af7-46c8-97ae-538585ca1994"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(334), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de cânhamo (15 metros)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(334), 1.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("1a7979cb-16bd-4a00-baca-8b5e89854593"), 13, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9899), 0, "Feito de anéis de metal intercalados, um camisão de cota de malha é usado entre as camadas de roupa. Essa armadura oferece proteção modesta para a parte superior do corpo de quem a usa e permite que o som dos anéis de metal, friccionados uns contra os outros, sejam amortecidos pelas camadas exteriores.", 1, 2, 0, 1, "Camisão de Malha", false, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9899), 30.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("1c36ae14-2575-4834-a3db-9354077707c5"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(230), 0, "Usando uma ação, você pode espalhar o \r\nconteúdo desse frasco em uma criatura a até 1,5 metro de \r\nvocê ou arremessar a até 6 metros, quebrando o frasco \r\ncom o impacto. Em ambos os casos, você deve realizar um \r\nataque à distância contra uma criatura alvo, tratando a \r\nágua benta como uma arma improvisada. Se o alvo for um \r\ncorruptor ou morto-vivo, ele sofre 2d6 de dano radiante. ", 4, "Água benta (frasco)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(230), 25.0, 0.5 },
                    { new Guid("1d8f1f20-f020-46f2-bc89-37379fcbcdd0"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(414), 0, "Um conjunto de roldanas com um \r\ncabo entre elas e um gancho para fixar aos objetos, a \r\nroldana e polia permitem içar até quatro vezes o peso que \r\nvocê ergueria normalmente.", 4, "Roldana e polia", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(414), 1.0, 2.5 },
                    { new Guid("2205c5fd-16ec-478b-a972-c449abcc45d1"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(589), 0, "", 4, "Flauta", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(589), 2.0, 0.5 },
                    { new Guid("25440b74-79cb-4ce8-bed1-6697f3cc06c3"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(427), 0, "", 4, "Emblema", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(427), 5.0, 0.0 },
                    { new Guid("2623bfd7-079a-4d31-8a61-bf09b5b71de5"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(340), 0, "Este kit inclui uma vara \r\nde pesca de madeira, linha de seda, boias de cortiça, \r\nanzóis de aço, chumbadas, iscas e redes de pesca.", 4, "Equipamento de pescaria", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(340), 1.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("279af854-ef87-4b7b-9fa0-8026689b6706"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(166), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Lança Longa", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(166), 5.0, 4.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("28474831-1363-4f7d-b690-92bcaea04d5f"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(390), 0, "", 4, "Zarabatana (50)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(390), 1.0, 0.5 },
                    { new Guid("29ec65fb-0da6-4d3f-b1f0-164337153fec"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(436), 0, "", 4, "Tinta (frasco de 30ml)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(436), 10.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("2c20b2e2-3e6f-480f-8a64-07763a45c6db"), 17, 2, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9935), 0, "Feita de tiras verticais de metal, rebitadas a um suporte de couro, usadas sobre um preenchimento de pano. Cotas de malha flexíveis protegem as articulações.", 1, 0, 15, null, "Cota de malha", true, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9935), 200.0, 30.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("2d89a9f4-605c-4e1d-a4de-6d105520875b"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(321), 0, "", 4, "Barril", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(321), 2.0, 35.0 },
                    { new Guid("2dcb8d48-4fe0-475f-8672-27849f81c502"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(590), 0, "", 4, "Flauta de Pã", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(590), 12.0, 1.0 },
                    { new Guid("305a1d3f-dab4-447f-aa9b-334cd86c7e7c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(435), 2, "A tocha queima por 1 hora, fornecendo luz \r\nplena em um raio de 6 metros e penumbra por mais 6 \r\nmetros. Se você realizar um ataque corpo-a-corpo com \r\numa tocha acesa e acertar, causa 1 de dano flamejante.", 4, "Tocha", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(435), 1.0, 0.5 },
                    { new Guid("306be03d-cb9e-4756-9b5e-96cb88288e1d"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(425), 0, "", 4, "Saco de dormir", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(425), 1.0, 3.5 },
                    { new Guid("312bcfd7-ef74-401e-a6a1-9c9ac2a7853c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(582), 0, "", 4, "Suprimentos de Caligrafia", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(582), 10.0, 2.5 },
                    { new Guid("31704f7b-926a-4a87-82cc-bfcd518d0b4a"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(328), 2, "", 4, "Caneca", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(328), 2.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3686df14-ecb4-43d8-aa86-22e6e099f843"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(176), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Martelo de Guerra", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(176), 15.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("37f863ce-18ee-405f-9e23-6bedf73ee4ac"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(389), 0, "", 4, "Virotes (20)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(389), 1.0, 0.75 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("39d31c19-ebb6-4901-98ee-ce82374b18f8"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(181), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Tridente", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(181), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3a24696b-1aa6-43d2-9f79-00658bae214a"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(409), 0, "Esse estojo de madeira pode \r\narmazenar até 20 virotes de besta.", 4, "Porta virotes", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(409), 1.0, 0.5 },
                    { new Guid("3ac165ae-37d8-4fdb-a886-9bddbc80c28a"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(354), 0, "", 4, "Varinha", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(354), 10.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3b45ee10-d041-43e6-9514-f64ff435d6da"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(132), 0, 1, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Adaga", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(132), 2.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("3c714b3a-a27d-43e5-a243-0a6f7aad96bc"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(576), 0, "", 4, "Ferramentas de Sapateiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(576), 5.0, 2.5 },
                    { new Guid("3ca1844e-99cf-418b-bdb6-4394e7d97851"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(341), 1, "", 4, "Escada (3 metros)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(341), 1.0, 12.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("3d1eb0d1-3f1b-4dab-be74-20f41ce5b0ff"), 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(538), 0, "Você pode usar o veneno contido\r\nnesse vidro para cobrir a lâmina de uma arma cortante ou\r\nperfurante ou até três peças de munição. Aplicar o veneno\r\nleva uma ação. Uma criatura atingida pela arma ou\r\nmunição envenenada deve obter sucesso em um teste de\r\nresistência de Constituição CD 10 ou sofrerá 1d4 de dano\r\nde veneno. Uma vez aplicado, o veneno retém sua\r\npotência durante 1 minuto antes de secar.", 4, 1, 1, 2, "Veneno básico (frasco)", 2, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(538), 100.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4026feb1-dc0f-4d99-ac28-f1ab36050805"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(178), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Rapieira", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(178), 25.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("41feba7c-958b-4843-8167-8c67cf555164"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(342), 0, "Usando uma ação, você pode \r\ndespejar essas minúsculas esferas de metal para cobrir a \r\nárea de um quadrado de 3 metros de lado. A criatura que \r\nse mover dentro da área deve ser bem sucedida em um \r\nteste de resistência de Destreza CD 10 para não cair no \r\nchão. Uma criatura que mover pela área usando metade \r\ndo seu deslocamento não precisa fazer o teste de \r\nresistência.", 4, "Esferas (sacola com 1.000)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(342), 1.0, 1.0 },
                    { new Guid("420bc8a4-b831-4b25-adae-1097527b0cfb"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(612), 0, "O kit de venenos inclui os frascos, \r\nprodutos químicos e outros equipamentos necessários \r\npara a criação de venenos. Proficiência com esse kit \r\npermite adicionar o bônus de proficiência para quaisquer \r\ntestes de habilidade que você fizer para criar ou utilizar \r\nvenenos.", 4, "Kit de Venenos", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(612), 50.0, 1.0 },
                    { new Guid("42fb7a78-737f-4c39-bb9c-a2c267fb0c5a"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(562), 0, "", 4, "Ferramentas de Cartógrafo", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(562), 15.0, 3.0 },
                    { new Guid("4657b87d-4b9c-454e-b702-5750d52d3863"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(372), 0, "Uma lanterna coberta lança luz \r\nplena em um raio de 9 metros e penumbra por mais 9 \r\nmetros. Uma vez acesa, ela queima por 6 horas usando \r\num frasco de óleo (500 ml). Usando uma ação, você pode \r\nabaixar a cobertura, reduzindo a claridade para \r\npenumbra em um raio de 1,5 metro.", 4, "Lanterna coberta", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(372), 5.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("49d1bcd8-66b9-4a6a-a31d-3ba1d070a5b1"), 14, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9929), 0, "Constituída por um peitoral de metal usado com couro flexível em seu interior. Embora ele deixe as pernas e braços do usuário relativamente desprotegidos, essa armadura fornece boa proteção para seus órgãos vitais, deixando quem a usa relativamente sem restrições.", 1, 2, 0, 1, "Peitoral", false, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9929), 400.0, 10.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("49f5d624-fa07-4b58-8fc5-0369aed99908"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(438), 2, "Por uma hora, a vela emana luz plena em um \r\nraio de 1,5 metro e penumbra por mais 1,5 metro.", 4, "Vela", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(438), 1.0, 0.0 },
                    { new Guid("4aa14347-ed2f-49f3-a6b0-bd2f2a37c39e"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(405), 2, "", 4, "Piton", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(405), 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4aac6a2a-2f84-49bb-8041-d92b8311288f"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(152), 1, 2, "Armas Simples à Distância", 1, 4, 0, "Funda", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(152), 1.0, 0.0 },
                    { new Guid("4d27084d-e625-45fa-a5a2-4f114d6d9d91"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(139), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Foice Curta", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(139), 1.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("4da398d9-a4ea-4034-b249-a7f97b068f2b"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(603), 0, "Essa pequena caixa contém uma \r\nvariedade de papéis e pergaminhos, canetas e tintas, \r\nselos e lacres, folha de ouro e prata, e outros suprimentos \r\nnecessários para criar falsificações convincentes de \r\ndocumentos físicos. Proficiência com esse kit permite \r\nadicionar o bônus de proficiência para quaisquer testes de \r\nhabilidade que você fizer para criar uma falsificação de \r\num documento físico.", 4, "Kit de Falsificação", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(603), 15.0, 2.5 },
                    { new Guid("4e278f91-5b78-4a79-9e4e-c1382ce2ab96"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(336), 0, "Tem 2 pontos de vida e pode ser arrebentada com um teste de \r\nForça CD 17 bem sucedido.", 4, "Corda de seda (15 metros)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(336), 10.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("4f9747fd-b175-4470-ba89-ec41396ca777"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(177), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Picareta de Guerra", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(177), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("5215ca0a-c7ab-4ece-941a-9c5657cde874"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(324), 0, "Trata-se de uma pequena \r\nbolsa de couro à prova d'água que pode ser fixada em um \r\ncinto. Ela possui compartimentos para armazenar todos \r\nos componentes materiais e outros itens especiais que \r\nvocê precisa para lançar suas magias, exceto os \r\ncomponentes que possuem um custo específico (conforme \r\nindicado na descrição da magia).", 4, "Bolsa de componentes", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(324), 25.0, 1.5 },
                    { new Guid("53348a20-4b66-4b3b-bcd5-eba43a5eedfd"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(349), 0, "", 4, "Cajado", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(349), 5.0, 2.0 },
                    { new Guid("56a2ff03-61ba-4084-925f-49b04a3f672d"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(386), 2, "", 4, "Balas de Funda (20)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(386), 4.0, 0.75 },
                    { new Guid("5987e50d-ca03-4379-9dcf-b594dc7d9153"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(391), 1, "Geralmente vem em um frasco de argila que \r\ncontém 500 ml. Usando uma ação, você pode espirrar o \r\nóleo desse frasco em uma criatura a até 1,5 metro de você\r\nou arremessar a até 6 metros, quebrando-o com o \r\nimpacto. Você deve realizar um ataque à distância contra \r\numa criatura ou objeto, tratando o óleo como uma arma \r\nimprovisada. Com um sucesso, o alvo é coberto de óleo. Se \r\no alvo sofrer qualquer dano flamejante antes do óleo secar\r\n (depois de 1 minuto), a criatura sofre 5 de dano \r\nflamejante adicional pela queima do óleo. Você também \r\npode derramar um frasco de óleo no chão para cobrir uma \r\nárea de um quadrado de 1,5 metro de lado, desde que a \r\nsuperfície esteja nivelada. Se aceso, o óleo queima por 2 \r\nrodadas e causa 5 de dano flamejante a qualquer criatura \r\nque entrar na área ou terminar seu turno dentro da área. \r\nUma criatura pode sofrer esse dano apenas uma vez por \r\nturno.", 4, "Óleo (frasco)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(391), 1.0, 0.5 },
                    { new Guid("59ab38d1-377d-4c4c-a9a8-f5117570e3d6"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(563), 0, "", 4, "Ferramentas de Costureiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(563), 1.0, 2.5 },
                    { new Guid("5a3a14d2-d54b-40cf-9cf6-7e1ba78e1a36"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(573), 0, "", 4, "Ferramentas de Pedreiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(573), 10.0, 4.0 },
                    { new Guid("5a423c5e-7c0b-47ce-b46c-80413e28f146"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(310), 0, "", 4, "Ampulheta", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(310), 25.0, 0.5 },
                    { new Guid("5cd3bfb2-0b9a-40c7-8629-271695e78ee6"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(422), 2, "", 4, "Sabão", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(422), 2.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5e8f8808-0a62-4487-b642-63fd78cbfe6b"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(146), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Porrete", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(146), 1.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("5ed76bd1-9cc6-4ba1-8801-9f7f299bb462"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(232), 0, " Essas algemas de metal podem prender \r\numa criatura Pequena ou Média. Escapar das algemas \r\nexige sucesso em um teste de Destreza CD 20. Quebrá-las \r\nexige um teste de Força CD 20 bem sucedido. Cada \r\nconjunto de algemas vem com uma chave. Sem a chave, \r\numa criatura proficiente com ferramentas de ladrão pode \r\nabrir a fechadura das algemas com um sucesso em um \r\nteste de Destreza CD 15. As algemas têm 15 pontos de \r\nvida. ", 4, "Algemas", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(232), 2.0, 2.0 },
                    { new Guid("5f1da36b-06b7-446c-b519-549a18917118"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(413), 0, "", 4, "Robes", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(413), 1.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("5fdc81f7-1374-4c19-a914-c750c9cbeedf"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(140), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Maça", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(140), 5.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6068f69b-2012-4a54-a498-ab8379ce0e50"), 0, 3, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9941), 0, "Feito de madeira ou metal e é usado com uma mão. Empunhar um escudo aumenta sua Classe de Armadura em 2. Você só pode se beneficiar de um escudo por vez.", 1, 2, 0, null, "Escudo", true, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9941), 10.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("626c6973-150a-402e-b841-40b357fd7993"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(159), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Espada Curta", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(159), 10.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("64a6fb90-a163-4e32-a487-5f1c424654d0"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(367), 2, "", 4, "Jarra", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(367), 4.0, 2.0 },
                    { new Guid("65b9a81a-5a0a-417c-a78d-956782092cc6"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(600), 0, "", 4, "Xilofone", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(600), 25.0, 5.0 },
                    { new Guid("69dda997-7bf4-4349-a1f1-157c201eb340"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(337), 0, "Uma corrente possui 10 pontos de vida e \r\npode ser arrebentada com um teste de Força CD 20 bem \r\nsucedido.", 4, "Corrente (3 metros)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(337), 5.0, 5.0 },
                    { new Guid("6bbaa239-642a-407f-b00f-c16cd4982c1f"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(308), 0, "Uma aljava pode guardar até 20 flechas.", 4, "Aljava", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(308), 1.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6c7960c8-c9f4-47c5-9add-1f01130dbc75"), 12, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9897), 0, "Armadura bruta consistindo de peles grossas. É comumente usada por tribos bárbaras, humanoides malignos e outros povos que não têm acesso às ferramentas e materiais necessários para criar uma armadura melhor.", 1, 2, 0, 1, "Gibão de Peles", false, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9897), 10.0, 6.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("6cb45bc6-cdbf-4870-b92f-e5208dae3d75"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(423), 2, "", 4, "Saco", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(423), 1.0, 0.25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7232446b-8f09-4762-bdf2-7cb4594df574"), 14, 2, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9932), 0, "Feita de couro com pesados anéis presos a ela. Os anéis ajudam a reforçar a armadura contra golpes de espadas e machados. A cota de anéis é inferior à cota de malha e geralmente é vestida apenas por aqueles que não podem pagar por uma armadura melhor.", 1, 0, 0, null, "Cota de anéis", true, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9932), 30.0, 20.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("735e8647-07fd-4c90-826d-da910afd5c86"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(429), 0, "", 4, "Sinete", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(429), 5.0, 0.0 },
                    { new Guid("73978041-c036-4397-ba6b-aa0c6e789d18"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(428), 0, "", 4, "Relicário", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(428), 5.0, 1.0 },
                    { new Guid("76860ceb-aa91-4d41-9644-4160b50a1d43"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(363), 0, "", 4, "Garrafa de vidro", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(363), 1.0, 1.0 },
                    { new Guid("77879df8-0f12-4d35-84f9-2281e55b0f7c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(332), 1, "", 4, "Cesto", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(332), 4.0, 1.0 },
                    { new Guid("78d1b912-f44b-4614-ad3a-a005e59af306"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(403), 1, "", 4, "Pergaminho (uma folha)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(403), 1.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7a6c2805-2ddc-4298-b39d-cc176ca08030"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(150), 2, 1, "Armas Simples à Distância", 1, 4, 0, "Dardo", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(150), 5.0, 0.10000000000000001 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7b40ed90-8670-4004-8932-d88e5119e77e"), 2, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(536), 0, "Um personagem que beber o líquido\r\nvermelho mágico deste frasco recupera 2d4+2 pontos de\r\nvida. Beber ou administrar uma poção exige uma ação.", 4, 2, 0, 2, "Poção de Cura", 2, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(536), 50.0, 0.25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7b42c2c0-d3c6-41ea-96df-7bf982001756"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(156), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 6, 0, "Cimitarra", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(156), 25.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7bbfae4a-997b-42c9-9e70-03ac899ea139"), 14, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9900), 0, "Consiste em um casaco e calças (e talvez uma saia separada) de couro coberto com peças sobrepostas de metal, assim como as escamas de peixe. O conjunto inclui manoplas.", 1, 2, 0, 1, "Brunea", true, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9900), 50.0, 22.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("7bf2c71c-3637-404c-a7f9-e9984f28ac93"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(143), 0, 0, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Machadinha", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(143), 5.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7d996976-b15d-4c28-9335-59f32a233464"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(345), 0, "Usando uma ação, você pode espalhar um \r\núnico saco de estrepes para cobrir a área de um quadrado \r\nde 1,5 metro de lado. Qualquer criatura que entrar na \r\nárea deve ser bem sucedida em um teste de resistência de \r\nDestreza CD 15. Se falhar, para de se mover e sofre 1 de \r\ndano perfurante. Até que a criatura recupere pelo menos \r\n1 ponto de vida, seu deslocamento de caminhada é \r\nreduzido em 3 metros. Uma criatura que se mover pela \r\nárea usando metade do seu deslocamento não precisa \r\nfazer o teste de resistência.", 4, "Estrepes (bolsa com 20)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(345), 1.0, 1.0 },
                    { new Guid("7f2e1b55-1d2a-47a6-85bd-c71cf2728120"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(360), 2, "", 4, "Frasco", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(360), 2.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("7f88f400-190b-4324-935c-1a56bde68952"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(160), 0, 0, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Espada Grande", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(160), 50.0, 3.0 },
                    { new Guid("821ecb54-cfb8-44b4-b801-f80f5934ee56"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(163), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Glaive", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(163), 20.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("825acd8e-c30e-47b7-ac4d-210240e40403"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(412), 1, "Consistem em alimentos desidratados adequados para viagens longas, \r\nincluindo carne seca, frutas secas, bolachas e nozes. ", 4, "Rações de viagem (1 dia)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(412), 5.0, 1.0 },
                    { new Guid("82edb1e5-23ef-45b1-89d4-936e1ab0d42d"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(421), 0, "", 4, "Roupas finas", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(421), 15.0, 3.0 },
                    { new Guid("843b25b0-c2db-4817-a1e3-8dd44ccac75c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(364), 2, "", 4, "Giz (1 peça)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(364), 1.0, 0.0 },
                    { new Guid("84f13b98-627a-4a25-9688-26f2e4f66496"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(344), 0, "", 4, "Espelho de aço", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(344), 5.0, 0.25 },
                    { new Guid("85f439e2-e410-4e0b-8dc7-df1de5017887"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(400), 2, "", 4, "Pedra de amolar", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(400), 1.0, 0.0 },
                    { new Guid("8645aa70-55db-4704-b379-35ad366d1a75"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(578), 0, "", 4, "Suprimentos de Alquimista", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(578), 50.0, 4.0 },
                    { new Guid("878092c5-e928-4c52-8e6b-c6a79da0b1ec"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(353), 0, "", 4, "Orbe", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(353), 20.0, 1.5 },
                    { new Guid("89e2c06b-15b0-4eef-b841-50e93f21d409"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(411), 0, "", 4, "Pregos de ferro (10)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(411), 1.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8b04a389-68ad-48dd-97a1-e435ada13f60"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(134), 1, 1, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Azagaia", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(134), 5.0, 1.0 },
                    { new Guid("8c8e42d6-911c-4228-b5fc-015537d231b6"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(183), 0, 1, "Armas Marciais à Distância", 1, 8, 0, "Arco Longo", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(183), 50.0, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("8de5cb84-03f8-4049-a89d-6d49e9058d28"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(434), 0, "Um abrigo simples e portátil que acomoda \r\nduas pessoas.", 4, "Tenda para duas pessoas", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(434), 2.0, 10.0 },
                    { new Guid("8e74fdc0-b464-4286-a56c-4373fa85d5bd"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(584), 0, "", 4, "Utensílios de Cozinheiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(584), 1.0, 4.0 },
                    { new Guid("8eb8fd93-c28b-4e30-b80a-7425a1160e9d"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(598), 0, "", 4, "Trombeta", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(598), 3.0, 1.0 },
                    { new Guid("9011e917-b7f1-4a7d-97d9-ad2f81da3e00"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(325), 1, "Esse pequeno recipiente detém uma \r\npederneira, isqueiro e um pavio (um pano geralmente \r\nseco embebido em óleo) usado para acender uma fogueira. \r\nUsá-lo para acender uma tocha – ou qualquer outra coisa \r\nexposta a um combustível abundante – leva uma ação. \r\nAcender qualquer outro fogo leva 1 minuto.", 4, "Caixa de Fogo", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(325), 5.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("914b68e0-7c6c-464d-86fb-a805916f091c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(153), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Alabarda", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(153), 20.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("919e5f65-f19d-43bd-bee8-578ef3aa2c66"), 18, 2, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9939), 0, "Consiste em placas de metal moldadas para cobrir todo o corpo. Inclui luvas, botas de couro pesadas, um capacete com viseira e espessas camadas de enchimento por baixo da armadura. Fivelas e tiras de couro distribuem o peso ao longo do corpo.", 1, 0, 15, null, "Placas", true, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9939), 1500.0, 32.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("920ac1c4-5407-4ce9-9cf4-7a2bbe2ab037"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(368), 0, "Um kit de escalada inclui pítons \r\nespeciais, botas com solas pontiagudas, luvas e um cinto. \r\nVocê pode usar o kit de escalada como uma ação para \r\n\"ancorar-se\". Quando faz isso, você não pode cair mais de \r\n7,5 metros a partir do ponto onde se ancorou, e não pode \r\nsubir mais de 7,5 metros de distância desse ponto, sem \r\ndesfazer a âncora.", 4, "Kit de escalada", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(368), 25.0, 6.0 },
                    { new Guid("926921b9-8fad-47a3-9195-14666f24cc03"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(575), 0, "", 4, "Ferramentas de Pintor", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(575), 10.0, 2.5 },
                    { new Guid("9754c9dd-d7ec-4806-b611-03620a65a083"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(323), 0, "", 4, "Baú", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(323), 5.0, 12.5 },
                    { new Guid("97bf584f-3070-4850-aeda-de7ae12b4db1"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(377), 0, "Um livro pode conter poesia, relatos históricos, \r\ninformações relativas a um campo particular de \r\nsabedoria, diagramas e notas sobre engenhocas gnômicas, \r\nou qualquer outra coisa que possa ser representada \r\nusando texto ou imagens.", 4, "Livro", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(377), 25.0, 2.5 },
                    { new Guid("98d5e844-ff2b-4ebd-a027-0eec96043ca7"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(317), 0, "Quando você usa sua ação para \r\narmá-la, essa armadilha forma um anel de aço com \r\ndentes serrilhados. Eles se fecham quando uma criatura \r\npisa sobre uma placa de pressão no seu centro. A \r\narmadilha é fixada por uma pesada corrente em um \r\nobjeto fixo e imóvel, como uma árvore ou um cravo \r\nenterrado no chão. Uma criatura que pisar na placa de \r\npressão deve ser bem sucedida em um teste de resistência \r\nde Destreza CD 13 ou sofrerá 1d4 de dano perfurante e \r\npara de se mover. Daí em diante, até que a criatura se \r\nliberte da armadilha, seu movimento é limitado ao \r\ncomprimento da corrente (tipicamente 1 metro de \r\ncomprimento). A criatura presa pode usar sua ação para \r\nfazer um teste de Força CD 13 e se libertar, ou outra \r\ncriatura no alcance pode fazer o teste para libertá-la. \r\nCada fracasso no teste causa 1 de dano perfurante à \r\ncriatura presa.", 4, "Armadilha de caça", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(317), 5.0, 12.5 },
                    { new Guid("9aa90472-cffb-4d28-bb60-c8fe42d76dde"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(226), 0, "", 4, "Ábaco", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(226), 2.0, 1.0 },
                    { new Guid("9b496481-bea9-4108-8517-a8a473ae0d6b"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(383), 0, "", 4, "Mochila", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(383), 2.0, 2.5 },
                    { new Guid("9be1358b-ae29-44e1-a8ab-8bbe13722657"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(607), 1, "", 4, "Baralho de Cartas", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(607), 5.0, 0.0 },
                    { new Guid("9c8bb8d5-0247-452f-a056-c9481981ecfc"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(398), 1, "", 4, "Parafina", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(398), 5.0, 0.0 },
                    { new Guid("a0de92a5-ecab-4a8c-a56b-644416a37c5b"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(376), 0, "Essa lente permite ver pequenos \r\nobjetos mais de perto. Ela também é útil como um \r\nsubstituto da pederneira e isqueiro para acender fogo. \r\nUsar uma lupa para acender fogo necessita de luz tão \r\nbrilhante como a luz do sol para focar, um pavio e cerca \r\nde 5 minutos. Uma lente de aumento concede vantagem \r\nem qualquer teste de habilidade feito para avaliar ou \r\ninspecionar um item que é pequeno ou muito detalhado.", 4, "Lente de aumento", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(376), 100.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a1f4d443-93fd-43a5-a2d0-d8e83eab9e7d"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(149), 0, 1, "Armas Simples à Distância", 1, 8, 0, "Besta Leve", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(149), 25.0, 2.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a2976744-446a-4cfb-a5ea-417fca189476"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(610), 0, "", 4, "Jogo dos Três Dragões", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(610), 5.0, 0.0 },
                    { new Guid("a2bb18b8-fed7-4e91-9385-2f4f9edba51a"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(415), 1, "", 4, "Roupas comuns", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(415), 5.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a3e6665e-2713-47c5-84b3-92bfd7785ae2"), 12, 0, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9880), 0, "Feita de couro resistente, mas flexível, é reforçada com rebites ou cravos.", 1, 0, 0, 1, "Couro Batido", false, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9880), 45.0, 6.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("a585044a-9350-4ddf-8359-bfe75d4c2caf"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(170), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 10, 0, "Machado Grande", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(170), 30.0, 3.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("a5dba14d-2750-47ee-939f-15be19818774"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(375), 0, "Uma lanterna furta-fogo \r\nlança luz plena em um cone de 18 metros e penumbra por \r\nmais 18 metros. Uma vez acesa, ela queima por 6 horas \r\nusando um frasco de óleo (500 ml).", 4, "Lanterna furta-fogo", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(375), 10.0, 1.0 },
                    { new Guid("a66ebb03-a6ab-4507-a520-4a031ed2c0e7"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(318), 0, "", 4, "Arpéu", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(318), 2.0, 2.0 },
                    { new Guid("a8ca6e89-a212-475f-a1bc-d307cbc52b59"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(333), 1, "", 4, "Cobertor de inverno", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(333), 5.0, 1.5 },
                    { new Guid("a96c7dcd-59c1-4917-93c2-467befe5d93f"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(572), 0, "", 4, "Ferramentas de Oleiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(572), 10.0, 1.5 },
                    { new Guid("aac9f745-6909-40ff-ae04-ede3bd35353c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(417), 0, "", 4, "Roupas de viajante", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(417), 2.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("b1e66fe2-6a8b-4703-bce2-da570d2ab84e"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(186), 0, 1, "Armas Marciais à Distância", 1, 10, 0, "Besta Pesada", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(186), 50.0, 4.5 },
                    { new Guid("b23bd842-67a5-4057-b523-9cf4a6e90192"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(145), 0, 2, "Armas Simples Corpo-a-Corpo", 1, 4, 0, "Martelo Leve", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(145), 2.0, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b24e581d-880e-4cf4-908a-d4e6e36c38a4"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(596), 0, "", 4, "Tambor", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(596), 6.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("b2c7c58c-5bc5-4345-9a6d-64cce39cbb0f"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(188), 0, 1, "Armas Marciais à Distância", 1, 1, 0, "Zarabatana", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(188), 10.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("b4d76377-5e86-4869-8737-354717db2003"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(432), 0, "", 4, "Sino", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(432), 1.0, 0.0 },
                    { new Guid("b57ab08c-a04e-47bf-aa1c-5bedbdf858fa"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(359), 0, "", 4, "Varinha de teixo", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(359), 10.0, 0.5 },
                    { new Guid("b69a43e1-7c6e-4e33-a6f3-be70d4fc3344"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(591), 0, "", 4, "Gaita de Foles", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(591), 30.0, 3.0 },
                    { new Guid("b74d8511-95e0-42e4-962f-3c45f9267d1c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(312), 0, "", 4, "Apito de advertência", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(312), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("bb0578b6-3913-4b20-8cf1-51b3051ed17c"), 15, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9930), 0, "Composta de placas de metal moldadas que cobrem a maior parte do corpo. Ela não inclui proteção para as pernas além de caneleiras fixadas com tiras de couro.", 1, 2, 0, 1, "Meia-Armadura", true, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9930), 750.0, 20.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("bb5345b2-9c7a-4d8d-ae46-ee62bc1177b3"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(370), 1, "Uma lâmpada lança luz plena em um raio \r\nde 4,5 metros e penumbra por mais 9 metros. Uma vez \r\nacesa, a lâmpada queima por 6 horas usando um frasco de \r\nóleo (500 ml).", 4, "Lâmpada", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(370), 5.0, 0.5 },
                    { new Guid("bc9d39f1-5676-49b4-8dc8-f171069771e2"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(395), 1, "", 4, "Papel (uma folha)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(395), 2.0, 0.0 },
                    { new Guid("bd0ea621-19a8-4237-b879-0c5af13ba42d"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(227), 0, "", 4, "Ácido (vidro)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(227), 25.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("bd42cf93-9b5b-4cd9-9e23-c2729c182c2a"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(158), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 4, 0, "Chicote", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(158), 2.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("bdbc491d-8019-4712-9522-4d9de162482a"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(319), 0, "Trata-se de uma pequena \r\nbalança, pratos e um sortimento adequado de pesos de até \r\n1 kg. Com ela, você pode medir o peso exato de pequenos \r\nobjetos, como metais preciosos brutos ou bens comerciais, \r\npara ajudar a determinar seu valor.", 4, "Balança de mercador", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(319), 5.0, 1.5 },
                    { new Guid("bf91d317-8d55-422d-a0d4-53009f3edb1b"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(381), 0, "", 4, "Marreta", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(381), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c150c30f-60ea-44e4-84b7-7c8454f09286"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(136), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 6, 0, "Bordão", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(136), 2.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Bonus", "CreatedAt", "CurrencyType", "Description", "Dice", "DiceCount", "Effect", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c30e0b7d-ab75-4606-bba7-59cc653a6948"), 2, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(541), 0, "Esse líquido pegajoso e adesivo\r\ninflama em contado com o ar. Usando uma ação, você\r\npode arremessar esse frasco a até 6 metros de distância,\r\nquebrando-o com o impacto. Você deve realizar um ataque\r\nà distância contra uma criatura ou objeto, tratando o fogo\r\nalquímico como uma arma improvisada. Em um sucesso,\r\no alvo sofre 1d4 de dano de fogo no início de cada um de\r\nseus turnos. Uma criatura pode terminar esse dano\r\nusando sua ação e fazendo um teste de Destreza CD 10\r\npara apagar as chamas.", 4, 2, 0, 2, "Fogo alquímico (frasco)", 2, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(541), 50.0, 0.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("c4b67f36-204f-481e-91ca-cdc2e55b2b5e"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(311), 0, "Uma criatura que beber o líquido desse \r\nvidro tem vantagem em testes de resistência contra \r\nvenenos por 1 hora. O antídoto não confere nenhum \r\nbenefício para mortos-vivos ou constructos. ", 4, "Antídoto (vidro)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(311), 50.0, 0.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c5299c38-c0b8-4832-853d-d78d10570e3c"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(173), 0, 2, "Armas Marciais Corpo-a-Corpo", 2, 6, 0, "Malho", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(173), 10.0, 5.0 },
                    { new Guid("c6be19fd-4d3a-4ed9-9667-45dd1d661fb6"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(162), 0, 0, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Espada Longa", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(162), 15.0, 1.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("c93bcabe-cae2-45ab-9e71-5d86c9077cd9"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(571), 0, "", 4, "Ferramentas de Joalheiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(571), 25.0, 1.0 },
                    { new Guid("c9bd37e5-9b48-43c4-ad4b-390397c51b58"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(331), 1, "", 4, "Cantil", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(331), 2.0, 2.5 },
                    { new Guid("cb53168c-6544-4ded-b3e5-24a22bcb0447"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(369), 0, "Esse kit é uma bolsa de \r\ncouro contendo ataduras, pomadas e talas. O kit possui \r\nmaterial suficiente para dez usos. Usando uma ação, você \r\npode gastar um uso do kit para estabilizar uma criatura \r\nque tenha 0 pontos de vida, sem a necessidade de realizar \r\num teste de Sabedoria (Medicina).", 4, "Kit de primeiros-socorros", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(369), 5.0, 1.5 },
                    { new Guid("cb5ca932-dd31-4fca-bd56-33b6125833e9"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(313), 0, " Você pode usar um aríete portátil \r\npara quebrar portas. Ao fazer isso, você ganha um bônus \r\nde +4 no teste de Força. Outra criatura pode ajudá-lo a \r\nusar o aríete, o que concede vantagem no teste.", 4, "Ariete portátil", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(313), 4.0, 17.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("d18f48b8-40ea-4d3c-87f8-2c1e0a597860"), 11, 0, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9878), 0, "São feitos de couro que foi endurecido após ser fervido em óleo. O resto da armadura é feita de materiais mais macios e mais flexíveis.", 1, 0, 0, 1, "Couro", false, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9878), 10.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d259c364-39f2-489e-8010-eaf9e7e74d40"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(358), 0, "", 4, "Totem", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(358), 1.0, 0.0 },
                    { new Guid("d2941735-db9b-48f9-8714-cfbc3cd90b80"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(404), 0, "", 4, "Picareta de minerador", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(404), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("d4ae7f73-cd57-4d66-bb16-8d5448505a55"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(169), 0, 2, "Armas Marciais Corpo-a-Corpo", 1, 8, 0, "Maça Estrela", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(169), 15.0, 2.0 },
                    { new Guid("d50b66ff-332a-4849-868e-c97144d921d6"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(137), 1, 2, "Armas Simples Corpo-a-Corpo", 1, 8, 0, "Clava Grande", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(137), 2.0, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("dcbb2430-fb79-428d-b70f-ac4f5d03a439"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(366), 0, "Essencial para os magos, um grimório é \r\num volume encadernado em couro com 100 páginas de \r\npergaminhos em branco, adequado para armazenar \r\nmagias.", 4, "Grimório", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(366), 50.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ArmorClass", "ArmorType", "CreatedAt", "CurrencyType", "Description", "ItemType", "MaxModifier", "MinStrength", "Modifier", "Name", "StealthDisadvantage", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("dd15e610-7ef6-482d-be59-4e1024f31475"), 16, 2, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9933), 0, "Feita de anéis de metal entrelaçados, a cota de malha inclui uma camada de tecido acolchoado usada por baixo da malha de metal para evitar atrito e amortecer o impacto dos golpes. O conjunto inclui manoplas.", 1, 0, 13, null, "Cota de malha", true, 1, new DateTime(2024, 6, 4, 19, 23, 59, 590, DateTimeKind.Local).AddTicks(9933), 75.0, 27.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("ddc7332c-6952-4245-a26f-65284ecf032f"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(587), 0, "", 4, "Alaúde", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(587), 35.0, 1.0 },
                    { new Guid("de5de99a-df51-45a7-b907-5436e7b5a68a"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(609), 1, "", 4, "Conjunto de Dados", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(609), 1.0, 0.0 },
                    { new Guid("de719e96-2d2b-4755-86f3-7212afd7e227"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(320), 2, "", 4, "Balde", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(320), 5.0, 1.0 },
                    { new Guid("e0ec33b9-df31-4178-899d-48b3506c6531"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(426), 0, "", 4, "Amuleto", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(426), 5.0, 0.5 },
                    { new Guid("e6e3110d-82d7-483c-bf93-a73eb512e433"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(568), 0, "", 4, "Ferramentas de Funileiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(568), 50.0, 5.0 },
                    { new Guid("e74acde9-b160-427f-80af-a9f89925a240"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(577), 0, "", 4, "Ferramentas de Vidreiro", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(577), 30.0, 2.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("e8a8984e-3e91-4afb-9a7f-b04fae22e3ff"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(148), 0, 1, "Armas Simples à Distância", 1, 6, 0, "Arco Curto", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(148), 25.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("e9ce3dc2-c3a0-4e52-a4e3-5c19eea58de9"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(387), 0, "", 4, "Flechas (20)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(387), 1.0, 0.5 },
                    { new Guid("eb4af506-6fca-4d66-a5b9-2a50f3f62e02"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(406), 0, "Esse estojo \r\ncilíndrico de couro pode armazenar até 10 folhas de papel \r\nenroladas ou 5 folhas de pergaminhos enroladas.", 4, "Porta mapas ou pergaminhos", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(406), 1.0, 0.5 },
                    { new Guid("ec4b4462-7031-4e3c-a3ce-1dc8b7be19d8"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(378), 0, "Objetos vistos através de uma luneta são \r\nampliados até o dobro do seu tamanho.", 4, "Luneta", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(378), 1000.0, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("ee90df8c-d3d9-4513-86af-b0a6f78226f7"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(187), 0, 1, "Armas Marciais à Distância", 0, 1, 0, "Rede", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(187), 1.0, 1.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("f12052fe-706d-4226-8fd4-734285dcf6d1"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(347), 0, "", 4, "Bastão", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(347), 10.0, 1.0 },
                    { new Guid("f1613f9c-9dbf-4c42-b024-7e5aa634b694"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(402), 0, "", 4, "Perfume (frasco)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(402), 5.0, 0.0 },
                    { new Guid("f25e7b12-cafd-48cc-b04f-e35b73b16e1d"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(594), 0, "", 4, "Lira", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(594), 30.0, 1.0 },
                    { new Guid("f28d3db1-1996-4c5c-af62-35a653a39de7"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(399), 0, "Usar um pé de cabra concede vantagem \r\nnos testes de Força onde uma alavanca possa ser \r\naplicada.", 4, "Pé de cabra", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(399), 2.0, 2.5 },
                    { new Guid("f386edf4-3801-4a5b-bf77-d4a4b1ea6041"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(437), 2, "", 4, "Vara (3 metros)", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(437), 5.0, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "DamageType", "Description", "WeaponDataModel_Dice", "WeaponDataModel_DiceCount", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[] { new Guid("f3b14ec3-cb71-4202-8fe5-59c812418a97"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(164), 0, 1, "Armas Marciais Corpo-a-Corpo", 1, 12, 0, "Lança de Montaria", 0, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(164), 10.0, 3.5 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedAt", "CurrencyType", "Description", "ItemType", "Name", "Type", "UpdatedAt", "Value", "Weight" },
                values: new object[,]
                {
                    { new Guid("f3c1d36a-e066-4ab0-bf8f-c6b53f692fa9"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(599), 0, "", 4, "Violino", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(599), 30.0, 3.0 },
                    { new Guid("f470520e-c72e-482a-850c-8e91e5cb75b1"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(346), 0, "A fechadura vem com chave. Sem a \r\nchave, uma criatura proficiente com ferramentas de \r\nladrão pode abrir a fechadura com um sucesso em um \r\nteste de Destreza CD 15. O Mestre pode decidir que \r\nfechaduras melhores estão disponíveis por preços mais \r\nelevados.", 4, "Fechadura", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(346), 10.0, 0.5 },
                    { new Guid("f4c4cb7b-8dbe-4b8d-9ad0-e101d4d92760"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(380), 0, "", 4, "Manto", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(380), 1.0, 2.0 },
                    { new Guid("f6b56268-4b4e-4d8a-b99b-56541f8a44c1"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(586), 0, "Esse conjunto de ferramentas inclui uma pequena pasta, um conjunto de \r\nchaves mestras, um pequeno espelho montado em uma \r\nalça de metal, um conjunto de tesouras de lâminas \r\nestreitas e um par de alicates. Proficiência com essas \r\nferramentas permite adicionar o bônus de proficiência \r\npara quaisquer testes de habilidade que você fizer para \r\ndesarmar armadilhas ou abrir fechaduras.", 4, "Ferramentas de ladrão", 3, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(586), 25.0, 0.5 },
                    { new Guid("fc38cf73-9ebb-4183-b634-dff5df04e9f2"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(595), 0, "", 4, "Oboé", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(595), 2.0, 0.5 },
                    { new Guid("fe02bc5c-b8f1-4313-9fb9-53a6fb18b576"), new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(418), 0, "", 4, "Roupas de entretenimento", 4, new DateTime(2024, 6, 4, 19, 23, 59, 591, DateTimeKind.Local).AddTicks(418), 5.0, 2.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("0aca6548-0d66-4174-b9ec-60e38caeb8f5"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("17938f1b-e016-44d0-81ca-ce5170e62c86"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("28bca5ed-4fd9-4b91-ad40-c2a5c5ef2de0"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("3982aa81-0933-4c50-b34e-a2deeafca105"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("47be69f8-d1ed-4686-8fc5-d7e086063fdc"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("52f7bf51-14de-4e9e-a010-d2e12af34fae"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("6a810f92-95b8-419e-8417-decf2d9c0a46"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("78353b39-d8f9-48a4-a349-342952e61709"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("7c469768-3e0a-4f94-b303-2eb90f1bbf68"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("85b509a3-8064-42ac-8c5c-c93d02a3a8a8"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("945b5482-6586-4150-8023-e4e3360d648c"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("962eb7ba-7f49-4818-b86e-7ada317251a7"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("96e99db2-ab5e-4a6a-9363-8608a210e122"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("9d08b4c4-6ef7-4141-a96e-c029bde74b51"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("9d5b3205-f304-4199-8c98-197a19a5f137"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("aa795603-e48e-439f-9b6e-e33ce4ca6dd6"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("bda4d22f-4fde-4e2e-ac7e-f01727937e88"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("be707ba1-cde1-4685-937d-66ced826c49d"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("ca433277-f6da-4c1d-9963-c0766223328c"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("dc2dbaa2-bd33-4d5a-a450-0cba0c80f132"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("e5592538-4ee3-4cd4-97b7-accbea14d7f9"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("ebecb492-cb49-4a17-9eb2-9fcb1b8908f1"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("f237402a-18b0-43e7-b7b7-c51155871e00"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0170e89a-a505-4f89-98e6-52f3f57ef624"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("01929c35-4784-43f3-84e9-9d7bb91304f7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("01c847e2-8d34-43ca-a6c9-5eb7706fd63d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("03cbe4f9-311f-4059-b949-5c1b46c70c03"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("044a2e66-4f1d-4d6e-aa7a-c202704b6283"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0533fe77-f17b-4cb7-aabe-2daabdd131a8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("07b0c3c4-ddd3-48c9-a5bd-1511fd1ef462"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("07c0d41d-24d1-46e8-8788-0bea1c56b9a7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("07f73751-dc2e-4fad-a66f-38e0b0142b38"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0886f45a-b9ee-4c21-9d36-6ad5ed4b9706"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("09046a75-24a2-49f3-a7ef-b3c69227e099"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0967c352-881a-4051-8938-e790cbc5bf01"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0a985225-db98-4dfc-9726-2e3cbb99f6e3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0aa2ca10-c304-4d41-bdca-67f20f1ef330"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0c085aa4-a2c0-47f4-bec0-e9165200cb1b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0e279628-a3de-4342-8f9a-e3960daaf1d8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0fa7538b-7e4a-458f-b571-61de4d470ca4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("118956a6-403c-44da-9fe3-35434dfad7d7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("132fa4aa-ea6a-424a-85d3-7c7cf5f96fe2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("15f8e932-9090-4b91-bf48-c86c99190565"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("16821eda-c402-41ba-8e89-eda5f80c5581"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("18eb6462-2af7-46c8-97ae-538585ca1994"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1a7979cb-16bd-4a00-baca-8b5e89854593"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1c36ae14-2575-4834-a3db-9354077707c5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1d8f1f20-f020-46f2-bc89-37379fcbcdd0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2205c5fd-16ec-478b-a972-c449abcc45d1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("25440b74-79cb-4ce8-bed1-6697f3cc06c3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2623bfd7-079a-4d31-8a61-bf09b5b71de5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("279af854-ef87-4b7b-9fa0-8026689b6706"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("28474831-1363-4f7d-b690-92bcaea04d5f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("29ec65fb-0da6-4d3f-b1f0-164337153fec"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2c20b2e2-3e6f-480f-8a64-07763a45c6db"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2d89a9f4-605c-4e1d-a4de-6d105520875b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2dcb8d48-4fe0-475f-8672-27849f81c502"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("305a1d3f-dab4-447f-aa9b-334cd86c7e7c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("306be03d-cb9e-4756-9b5e-96cb88288e1d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("312bcfd7-ef74-401e-a6a1-9c9ac2a7853c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("31704f7b-926a-4a87-82cc-bfcd518d0b4a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3686df14-ecb4-43d8-aa86-22e6e099f843"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("37f863ce-18ee-405f-9e23-6bedf73ee4ac"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("39d31c19-ebb6-4901-98ee-ce82374b18f8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3a24696b-1aa6-43d2-9f79-00658bae214a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3ac165ae-37d8-4fdb-a886-9bddbc80c28a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3b45ee10-d041-43e6-9514-f64ff435d6da"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c714b3a-a27d-43e5-a243-0a6f7aad96bc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3ca1844e-99cf-418b-bdb6-4394e7d97851"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3d1eb0d1-3f1b-4dab-be74-20f41ce5b0ff"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4026feb1-dc0f-4d99-ac28-f1ab36050805"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("41feba7c-958b-4843-8167-8c67cf555164"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("420bc8a4-b831-4b25-adae-1097527b0cfb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("42fb7a78-737f-4c39-bb9c-a2c267fb0c5a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4657b87d-4b9c-454e-b702-5750d52d3863"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("49d1bcd8-66b9-4a6a-a31d-3ba1d070a5b1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("49f5d624-fa07-4b58-8fc5-0369aed99908"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4aa14347-ed2f-49f3-a6b0-bd2f2a37c39e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4aac6a2a-2f84-49bb-8041-d92b8311288f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4d27084d-e625-45fa-a5a2-4f114d6d9d91"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4da398d9-a4ea-4034-b249-a7f97b068f2b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4e278f91-5b78-4a79-9e4e-c1382ce2ab96"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4f9747fd-b175-4470-ba89-ec41396ca777"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5215ca0a-c7ab-4ece-941a-9c5657cde874"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("53348a20-4b66-4b3b-bcd5-eba43a5eedfd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("56a2ff03-61ba-4084-925f-49b04a3f672d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5987e50d-ca03-4379-9dcf-b594dc7d9153"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("59ab38d1-377d-4c4c-a9a8-f5117570e3d6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5a3a14d2-d54b-40cf-9cf6-7e1ba78e1a36"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5a423c5e-7c0b-47ce-b46c-80413e28f146"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5cd3bfb2-0b9a-40c7-8629-271695e78ee6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5e8f8808-0a62-4487-b642-63fd78cbfe6b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5ed76bd1-9cc6-4ba1-8801-9f7f299bb462"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5f1da36b-06b7-446c-b519-549a18917118"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5fdc81f7-1374-4c19-a914-c750c9cbeedf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6068f69b-2012-4a54-a498-ab8379ce0e50"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("626c6973-150a-402e-b841-40b357fd7993"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("64a6fb90-a163-4e32-a487-5f1c424654d0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("65b9a81a-5a0a-417c-a78d-956782092cc6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("69dda997-7bf4-4349-a1f1-157c201eb340"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6bbaa239-642a-407f-b00f-c16cd4982c1f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6c7960c8-c9f4-47c5-9add-1f01130dbc75"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6cb45bc6-cdbf-4870-b92f-e5208dae3d75"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7232446b-8f09-4762-bdf2-7cb4594df574"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("735e8647-07fd-4c90-826d-da910afd5c86"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("73978041-c036-4397-ba6b-aa0c6e789d18"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("76860ceb-aa91-4d41-9644-4160b50a1d43"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("77879df8-0f12-4d35-84f9-2281e55b0f7c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("78d1b912-f44b-4614-ad3a-a005e59af306"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7a6c2805-2ddc-4298-b39d-cc176ca08030"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7b40ed90-8670-4004-8932-d88e5119e77e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7b42c2c0-d3c6-41ea-96df-7bf982001756"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7bbfae4a-997b-42c9-9e70-03ac899ea139"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7bf2c71c-3637-404c-a7f9-e9984f28ac93"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7d996976-b15d-4c28-9335-59f32a233464"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7f2e1b55-1d2a-47a6-85bd-c71cf2728120"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7f88f400-190b-4324-935c-1a56bde68952"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("821ecb54-cfb8-44b4-b801-f80f5934ee56"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("825acd8e-c30e-47b7-ac4d-210240e40403"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("82edb1e5-23ef-45b1-89d4-936e1ab0d42d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("843b25b0-c2db-4817-a1e3-8dd44ccac75c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("84f13b98-627a-4a25-9688-26f2e4f66496"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("85f439e2-e410-4e0b-8dc7-df1de5017887"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8645aa70-55db-4704-b379-35ad366d1a75"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("878092c5-e928-4c52-8e6b-c6a79da0b1ec"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("89e2c06b-15b0-4eef-b841-50e93f21d409"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8b04a389-68ad-48dd-97a1-e435ada13f60"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8c8e42d6-911c-4228-b5fc-015537d231b6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8de5cb84-03f8-4049-a89d-6d49e9058d28"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8e74fdc0-b464-4286-a56c-4373fa85d5bd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8eb8fd93-c28b-4e30-b80a-7425a1160e9d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9011e917-b7f1-4a7d-97d9-ad2f81da3e00"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("914b68e0-7c6c-464d-86fb-a805916f091c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("919e5f65-f19d-43bd-bee8-578ef3aa2c66"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("920ac1c4-5407-4ce9-9cf4-7a2bbe2ab037"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("926921b9-8fad-47a3-9195-14666f24cc03"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9754c9dd-d7ec-4806-b611-03620a65a083"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("97bf584f-3070-4850-aeda-de7ae12b4db1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("98d5e844-ff2b-4ebd-a027-0eec96043ca7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9aa90472-cffb-4d28-bb60-c8fe42d76dde"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9b496481-bea9-4108-8517-a8a473ae0d6b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9be1358b-ae29-44e1-a8ab-8bbe13722657"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9c8bb8d5-0247-452f-a056-c9481981ecfc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a0de92a5-ecab-4a8c-a56b-644416a37c5b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a1f4d443-93fd-43a5-a2d0-d8e83eab9e7d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a2976744-446a-4cfb-a5ea-417fca189476"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a2bb18b8-fed7-4e91-9385-2f4f9edba51a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a3e6665e-2713-47c5-84b3-92bfd7785ae2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a585044a-9350-4ddf-8359-bfe75d4c2caf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a5dba14d-2750-47ee-939f-15be19818774"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a66ebb03-a6ab-4507-a520-4a031ed2c0e7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a8ca6e89-a212-475f-a1bc-d307cbc52b59"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a96c7dcd-59c1-4917-93c2-467befe5d93f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("aac9f745-6909-40ff-ae04-ede3bd35353c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b1e66fe2-6a8b-4703-bce2-da570d2ab84e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b23bd842-67a5-4057-b523-9cf4a6e90192"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b24e581d-880e-4cf4-908a-d4e6e36c38a4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b2c7c58c-5bc5-4345-9a6d-64cce39cbb0f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b4d76377-5e86-4869-8737-354717db2003"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b57ab08c-a04e-47bf-aa1c-5bedbdf858fa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b69a43e1-7c6e-4e33-a6f3-be70d4fc3344"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b74d8511-95e0-42e4-962f-3c45f9267d1c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bb0578b6-3913-4b20-8cf1-51b3051ed17c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bb5345b2-9c7a-4d8d-ae46-ee62bc1177b3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bc9d39f1-5676-49b4-8dc8-f171069771e2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bd0ea621-19a8-4237-b879-0c5af13ba42d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bd42cf93-9b5b-4cd9-9e23-c2729c182c2a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bdbc491d-8019-4712-9522-4d9de162482a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bf91d317-8d55-422d-a0d4-53009f3edb1b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c150c30f-60ea-44e4-84b7-7c8454f09286"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c30e0b7d-ab75-4606-bba7-59cc653a6948"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c4b67f36-204f-481e-91ca-cdc2e55b2b5e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c5299c38-c0b8-4832-853d-d78d10570e3c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c6be19fd-4d3a-4ed9-9667-45dd1d661fb6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c93bcabe-cae2-45ab-9e71-5d86c9077cd9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c9bd37e5-9b48-43c4-ad4b-390397c51b58"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cb53168c-6544-4ded-b3e5-24a22bcb0447"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cb5ca932-dd31-4fca-bd56-33b6125833e9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d18f48b8-40ea-4d3c-87f8-2c1e0a597860"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d259c364-39f2-489e-8010-eaf9e7e74d40"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d2941735-db9b-48f9-8714-cfbc3cd90b80"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d4ae7f73-cd57-4d66-bb16-8d5448505a55"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d50b66ff-332a-4849-868e-c97144d921d6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dcbb2430-fb79-428d-b70f-ac4f5d03a439"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dd15e610-7ef6-482d-be59-4e1024f31475"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ddc7332c-6952-4245-a26f-65284ecf032f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("de5de99a-df51-45a7-b907-5436e7b5a68a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("de719e96-2d2b-4755-86f3-7212afd7e227"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e0ec33b9-df31-4178-899d-48b3506c6531"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e6e3110d-82d7-483c-bf93-a73eb512e433"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e74acde9-b160-427f-80af-a9f89925a240"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e8a8984e-3e91-4afb-9a7f-b04fae22e3ff"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e9ce3dc2-c3a0-4e52-a4e3-5c19eea58de9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("eb4af506-6fca-4d66-a5b9-2a50f3f62e02"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ec4b4462-7031-4e3c-a3ce-1dc8b7be19d8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ee90df8c-d3d9-4513-86af-b0a6f78226f7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f12052fe-706d-4226-8fd4-734285dcf6d1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f1613f9c-9dbf-4c42-b024-7e5aa634b694"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f25e7b12-cafd-48cc-b04f-e35b73b16e1d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f28d3db1-1996-4c5c-af62-35a653a39de7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f386edf4-3801-4a5b-bf77-d4a4b1ea6041"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f3b14ec3-cb71-4202-8fe5-59c812418a97"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f3c1d36a-e066-4ab0-bf8f-c6b53f692fa9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f470520e-c72e-482a-850c-8e91e5cb75b1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f4c4cb7b-8dbe-4b8d-9ad0-e101d4d92760"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f6b56268-4b4e-4d8a-b99b-56541f8a44c1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fc38cf73-9ebb-4183-b634-dff5df04e9f2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fe02bc5c-b8f1-4313-9fb9-53a6fb18b576"));

            migrationBuilder.DropColumn(
                name: "ArmorType",
                table: "Items");

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
    }
}
