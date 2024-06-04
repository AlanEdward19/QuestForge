using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuestForge.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class proficiencies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ArmorProficiencies",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "SavingThrows",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "SkillsProficiencies",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "ToolProficiencies",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "WeaponProficiencies",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ArmorProficiencies",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "SavingThrows",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "SkillsProficiencies",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ToolProficiencies",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "WeaponProficiencies",
                table: "Classes");

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
        }
    }
}
