using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "0a581413-0c67-4ab8-8c75-9f9f2e48ff44");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "0e20dd16-6655-4d7d-8942-77dc124b53ff");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "340b2c2d-ee3c-488e-b2de-88944cd574c2");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "3e779e25-0923-490f-81ab-df2c6b03832b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00d1a858-1a3f-4fda-860a-45f9257b8cc2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "03529ba8-6948-445a-a8bf-d5a2b864b05b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0396b6c5-af67-4ccf-a92f-9c9ea13319c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "07011efa-6524-4edd-b91c-b7e14dd7ca81");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0ce50e64-6a35-40ff-a274-2043b1581e45");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e67b642-0c5a-440a-8a65-81f265de501c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0fc8197e-aef5-469d-a1ab-6e60955619d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "150d3278-31be-42d8-94d2-d067b3ac9a4d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16fc0140-30b4-4cd3-be24-067820dbeb6c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c95f9d7-eeff-4aad-be05-2e56037a64cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1ca0bcd3-86c9-4ee2-9084-f34019605346");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "20143159-5369-4562-ba57-e369e9520b48");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "21e92b44-6eb1-46e0-8d9b-e2b4c862819b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "231fb661-bbbe-4dac-bab7-4900ec51c6f4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "24dec3f5-7988-48ba-9364-b1282efa7036");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "25db851d-c05e-46ac-b90b-2c51c2d8253e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "26fe5e28-1060-401a-a3c0-8a217dc91c06");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "27829230-fa39-49f9-9aba-3d0d1d28594e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d9d0dc9-37a4-45bd-a5dd-eb41d355f4f5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "329c0570-7598-4939-8f7a-1aac19d15975");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3cfddbb0-2663-4671-8ff3-712ac24b5889");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d0a92bc-3106-44f4-b443-149c2fc895ba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d0f5b37-2d73-4db3-b6e9-35264b1601ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40483e35-48cf-4960-b51d-3548b0ec3eef");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "411004ba-6ed7-4549-9dfe-f8605948765e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4156b015-5f67-4782-8263-9c69884d899d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "444658cf-e84c-4b89-a625-2220d40cce86");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "461b9443-2582-469d-b952-92f55bb6d00d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "49eec1e2-af9b-4410-9e91-36f17b628851");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c02c36b-b10c-4d66-97ff-f5aedd2d3358");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4cec16cd-f212-4ce3-a11e-20e713ab6ee9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "508e885c-3a4e-4a9b-8b19-d18dd0957468");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "530fd436-ba4b-498c-bf8a-2d7df80417b1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "547c0c13-01f8-455d-aa99-ae478f22d4a9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55d47038-0d47-433f-bddc-f3754ae11ddb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5c005a5c-36e6-47b6-8fc0-d4ce9cc6da21");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5d422b5f-62da-44d2-8580-87c9aa6b4b4d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61cbc635-34f8-4b98-8f6c-6cfda91618bf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61d65e65-741b-4d37-ad55-524501038a7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "62a2a7b9-f256-4c3a-98cd-eedbc02d4197");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6384c0bf-a202-4cba-8781-d5da88cbae6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64645f17-f500-45dd-a34d-d2d73a639c6c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "67ed74d9-da48-4e3c-badb-5b37db76b647");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "68447990-d592-4417-94d5-817dd9f345e8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6a84f992-8bce-4ff8-83cd-5cfd04a3b31b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6a878e4f-03d0-43bc-b8b2-7db91a4401e5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6aa220ed-3e43-4f64-9102-8a7eac1a4ef0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d546985-0380-442d-80ee-d3bdd3643684");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f94be7a-0145-4d71-bbb6-e3431ba66ab9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7266ed8d-bc61-4f9b-a340-e79f3168312c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "727c9144-b957-451e-82a3-e0b5b00bc0f9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7310aafd-cafa-40ef-951f-28757cc89d15");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "732b6177-a2a1-456f-9b93-59663384b2a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "73e28867-1a9c-4716-aaec-fb7dcdad86ce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "755db037-2139-47ce-9e55-4dd8930822fc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75f46dc6-b1c4-42ff-8cff-d32ac1f20617");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7805bd15-bda8-4916-9cc0-ee3add4a78aa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7df91756-30eb-46ae-a4be-0b322ce38402");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "809ce49d-3d66-42ea-9e3e-59f789fea71d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "812422ff-9f1b-4ca6-9c46-994041fcfb8a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "82c26033-7065-42da-b8ae-ebc84bd53cdc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d06b16a-c0af-4ff4-aa11-24856651fddf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "959e6378-9efa-4b84-b7f6-80d1ad7589e7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9872f9de-1f03-4a97-abea-0a3fcf524d7b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "999efea5-3c4d-466b-8e01-76d5fc04969d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9aecf701-8bdf-484e-8c67-4645d6b22d05");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c71d876-d824-423d-8bd2-d4ca7e1497a5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9ef0d7b9-5535-4aa5-980c-d82359265a6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a5f8a24c-d22d-417b-8552-b76c3fd11e30");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a74c926c-26b2-4af0-844e-46b9226c7224");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a7ff2ef8-49a6-4c1b-9ada-16f7140fa45f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ac5db831-3e1d-463e-a06f-1e951d5a0b97");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ac687d5f-fd30-43e0-bdb2-3220805b0e03");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "acc7bf82-2056-45ef-bb02-b69712c7a822");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "acca2e84-b6f7-40da-bf8e-2590b8350d4e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b0a00229-455e-47bf-b91f-4a2d600fb12d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b0c912a2-b5f7-4916-872b-ebcacdfb397e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b132b9f3-ff1e-4c6d-8721-d249b6044758");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b4136ee7-d477-4561-b299-cf1fdc799f87");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7589b08-c6de-462a-b1b9-8d2f7b11c5df");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b79659aa-0adf-40c1-94bb-475b8dee7d6a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8dbf089-c937-47a9-941f-091f8cb216b0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b9182a07-9242-4a8d-b002-16d10634ce23");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "be716ac3-459e-4afe-b9c9-a66c2c4f0f17");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c05a6568-c31b-42a1-8776-9181e0a5559c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c1e725b7-4e6c-4c95-9b23-8b9984a53f77");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c2472fcc-e49c-4ec7-bf31-4f6c1cf37849");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c3fb5f5e-5a49-4e21-8843-6d5efbce01cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c57e52d2-7ede-4eaf-a8d3-f23d03085715");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c7ff0826-4134-4e47-b3ab-0464577f5991");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c88677ab-b32f-4313-8686-36215ca078ba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8bcebbc-585d-4c6a-865d-bc9b6e769398");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8f016cb-3072-4c2f-a867-88dbcb67bf3a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb9a96e9-f216-49c6-9118-742bca8b1b7f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cc1622c9-f670-4fd0-b43b-cfc791b74e7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd6437ad-d6c9-4fd9-977c-8258a946ff35");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d0f91b9d-13db-41a0-ab96-93b8bb216b20");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d1052221-b786-44b7-909c-6a52138d28eb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d21af49b-9255-4eef-9aad-2015be5eecbf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3256ce4-8820-477b-9c23-f0473f30bbcf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d584b540-aa55-4b68-95b7-709c0cb7feae");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d641c5c7-cd44-4812-a6a4-7ceeed270ae3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e582de49-e65f-45cb-89fe-8f5450469b3a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e60f82b7-167c-48c3-a367-4a228ae78d3e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d74b70-d72a-43f0-8fb5-81005dea146a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea8ca821-a085-497e-b0b1-645f963c1367");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb47b780-813c-46d9-8be2-a912ee8aff37");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ecf00b7f-4a81-4dd6-81b0-ebb885ea9ce7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef924b3a-0a28-4340-9c55-49545db02952");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f75c301e-599c-4c64-a432-69890384d0d7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f805d438-91a2-4225-86d6-fd4d3957430f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f8e53933-48c8-49da-9864-b03792cacba6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f9301541-c680-4451-a1a8-30cd8184162f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fa606cc8-ae9a-4c81-ab99-c035a3fde49c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb01ba02-5ec3-4583-9b52-c8c447ac5963");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb7474f8-7a2f-476b-826b-a4c40f665077");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fd28af3c-c1f7-40af-a2cb-9742b1b11006");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fe1ca323-a536-4a05-b563-bfa983ec396c");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "ef3825da-f0af-44d3-9d45-2ecca7ec0ef9");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "b2c7931c-49a7-4830-a197-183547a13c25");

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 215, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 215, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 215, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 215, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 215, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 215, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "19ba81ea-df1f-4668-b5bb-338024a5ec5a", new DateTime(2024, 12, 15, 19, 14, 45, 217, DateTimeKind.Local).AddTicks(8875), "Siparişiniz Alındı" },
                    { "377d8b5f-debb-4a95-b4a0-6aec092ef627", new DateTime(2024, 12, 15, 19, 14, 45, 217, DateTimeKind.Local).AddTicks(8983), "Siparişiniz Tamamlandı" },
                    { "7177207f-2366-44fc-a050-c1697defca28", new DateTime(2024, 12, 15, 19, 14, 45, 217, DateTimeKind.Local).AddTicks(8964), "Siparişiniz Hazırlanıyor" },
                    { "bc382cab-dc0d-4ac1-90ab-da76190c838f", new DateTime(2024, 12, 15, 19, 14, 45, 217, DateTimeKind.Local).AddTicks(8974), "Siparişiniz Kargoya verildi" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 218, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 218, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 218, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 218, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 218, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "Size", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "0242d3ba-ab18-4173-acd5-ac0a5977613d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4923), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 8, 1500, null },
                    { "024a89c8-f460-4add-9ac9-5b77d68ddc03", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5230), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 8, 0, 1500 },
                    { "0399b054-06ba-4358-bfe8-bd87dd469ef4", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5470), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 14, 1500, null },
                    { "072a37ad-4a1f-4199-a343-1d5af85a8e4d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5333), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 14, 1500, null },
                    { "07ae6403-6d5d-40b5-8513-d0975030474b", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4997), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 8, 1500, null },
                    { "0a1a0fae-57f5-491c-b2f3-511da36a08d7", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5578), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 14, 1500, null },
                    { "0a327913-aa2c-44e2-9ffe-216ae89a7414", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5053), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 8, 1500, null },
                    { "0c722d9a-feb7-4159-95bb-51aba33687bd", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5780), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ BORDO", null, null, 14, 1500, null },
                    { "0db1e2ca-06e5-42c9-b43c-49be3a53a9ad", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5643), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 14, 1500, null },
                    { "0dcf24b7-ad37-417d-8ad9-70508d7587ce", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4941), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 8, 1500, null },
                    { "0e382a40-1e9e-4932-8de6-fe89182538bf", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5238), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 8, 0, 1500 },
                    { "0ef57975-7450-4f0f-bf47-07eb461b38c0", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5694), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "0fa98ee9-99c3-4d6d-92c9-2837a781e7cc", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5356), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 14, 1500, null },
                    { "1254b2a1-8a88-414e-8b62-ee5d0905b0d2", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4948), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 8, 1500, null },
                    { "125dbf1b-80a7-483a-b4e3-a3995bff2070", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5113), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 8, 1500, null },
                    { "15faf571-c06a-4dd5-ac14-22fe2c1c4b1e", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4620), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "16a5eb4d-ca20-450b-9ae7-b4f4aa4690d7", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5812), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI-N2", null, null, 14, 1500, null },
                    { "17fe55bc-142a-4248-a46f-da4d1901eb63", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5521), null, false, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "18471f4c-2ee2-4c22-84a5-d983f933fd5d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4843), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 8, 1500, null },
                    { "188c8fda-6190-4660-9aba-a732dfab2f0d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4642), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 8, 1500, null },
                    { "1c3e92eb-0d5b-426a-80a1-331f1465a4ec", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5530), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "1c8a8ef2-b048-4966-a2ee-817e010ba6ae", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5569), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "1f467419-6c92-4f45-8dca-fe3f76c6ee01", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5661), null, false, true, false, "/databaseimg/HALKOYUN-VAN-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "1fca98bd-1276-4f76-b9a2-974554a07c31", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4793), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 8, 1500, null },
                    { "1feb6200-50d2-45a7-b5a3-4c2fffdd6601", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4883), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 8, 1500, null },
                    { "2000fbe6-d4fb-43a0-b19b-a0779b6fd5c9", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5038), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 8, 1500, null },
                    { "25449503-64fb-4308-829d-d7197d0e7d3d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4817), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "2738c783-3059-47b8-aded-31bb969c163b", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5298), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 14, 1500, null },
                    { "293bed2d-4b12-4e0d-b4fe-83976158f367", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5315), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ", "DOGU ANADOLU", "BİTLİS", 14, 1500, null },
                    { "29e5ea87-1cf8-477a-bceb-5ef60ad77398", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4825), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 8, 1500, null },
                    { "2a444377-0d27-4b9b-8533-d811b3aa41f2", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5223), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 8, 0, 1500 },
                    { "2fe72021-176c-4325-860e-8f12fb8d74d6", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4718), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "301d23cc-9a45-43b7-8ec8-bd65404b19ee", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4851), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 8, 1500, null },
                    { "31d96073-f148-44f1-8d66-44619871d732", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5930), null, null, true, false, "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, "ROMAN", 14, 1500, null },
                    { "3223e19f-aba3-4d5b-a35f-f00d96f72c5f", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5961), null, null, true, false, "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN TURUNCU", null, "ROMAN", 14, 1500, null },
                    { "34a290b1-6889-49f2-bc6b-e77bb1aa6562", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4665), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "371ab523-0543-4c34-b684-c4a12bf4e9fd", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5850), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE-N2", null, null, 14, 1500, null },
                    { "3c4781bd-22fd-4a2d-84f5-47424a5d470e", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5734), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N3", null, null, 14, 1500, null },
                    { "3d3f9732-9d95-4c07-a091-708bbda1d36e", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5416), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 14, 1500, null },
                    { "3db346f3-4523-4315-9b36-816fe9b61898", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4689), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 8, 1500, null },
                    { "3e4a6c04-f8dc-4284-91d6-8784b532df1f", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5154), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 8, 1500, null },
                    { "45e47c35-4702-4fd1-b3a5-7b8996e3f777", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5435), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 14, 1500, null },
                    { "4735dc0a-f319-44f0-9f6b-e3847f158922", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5389), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 14, 1500, null },
                    { "48a11ebe-81f4-4bb5-b7f4-a663d077800f", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4802), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "48c7b704-342f-43b1-82e6-62d65837d750", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5992), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ E", null, null, 14, 1500, null },
                    { "4a49b1a4-9421-49a9-b75b-fa1124377204", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4971), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 8, 1500, null },
                    { "4b1b0308-77c9-4d14-b1a9-b69da40c9da4", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5947), null, null, true, false, "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN RENKLİ ETEK", null, "ROMAN", 14, 1500, null },
                    { "4bdd4d93-f94e-40af-9de8-850ffbb7b6f5", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5090), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 8, 1500, null },
                    { "4c65c0ad-3571-4b9d-979e-84d659b47ff9", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4891), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 8, 1500, null },
                    { "4e6fb76b-a383-4d28-be07-4507d2a80679", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5194), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 8, 0, 1500 },
                    { "50320d92-1a61-410e-b957-ef5665304ae6", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5773), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN YEŞİL", null, null, 14, 1500, null },
                    { "504e75ac-5f32-4c33-bccd-1b2c56765c00", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5480), null, null, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 14, 1500, null },
                    { "51896c53-f63b-4b83-ae5e-56a17919b17e", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4832), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 8, 1500, null },
                    { "52ec151b-b692-425c-892d-67a0f26b533e", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5765), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN PEMBE", null, null, 14, 1500, null },
                    { "53feb8b1-5486-47af-a850-f218b5573ab0", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5131), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 8, 1500, null },
                    { "55c0fce6-8b01-44b8-b29c-ac4ba8ae43c2", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5171), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 8, 0, 1500 },
                    { "5675f956-75a6-4f2d-8010-cd0da0fa19d0", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5611), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 14, 1500, null },
                    { "5a49b775-4803-426c-8864-f0eaf0c60b71", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5701), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 14, 1500, null },
                    { "5abbf34d-6390-4d02-9bfb-06a838f365ed", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5139), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 8, 1500, null },
                    { "5b671691-0c4f-484f-a168-9fd6b788e5c7", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5801), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI", null, null, 14, 1500, null },
                    { "5bdb1483-25d2-4a48-92d4-ac7557821465", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5121), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 8, 1500, null },
                    { "5d6754dc-706e-41a1-9d60-cae05bad3dce", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4742), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 8, 1500, null },
                    { "603ff1e8-5e08-4bcb-90bc-8ae052ac86e6", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5215), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 8, 0, 1500 },
                    { "60519bc5-e796-44a0-9dcc-dc3fb214ecd6", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4676), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 8, 1500, null },
                    { "61c7b810-748a-4438-9b7b-cfa3d509e923", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4631), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "62da79c0-1b14-476e-978c-93d0ed6d506a", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4784), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 8, 1500, null },
                    { "6583fa30-ec12-464d-93c8-f8f27c8aee49", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5399), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 14, 1500, null },
                    { "6675f0b3-a256-4634-934d-f0740409097d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4709), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 8, 1500, null },
                    { "6786f334-d8f4-44bf-962c-aa9d3b52ee00", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5835), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N3", null, null, 14, 1500, null },
                    { "67dfe5db-6311-4d0c-a150-2c3f4798e707", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5071), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 8, 1500, null },
                    { "6864f9de-10dd-45ae-867f-34ab800401fc", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5273), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 14, 1500, null },
                    { "69430b96-b88e-4b0d-a9a7-6fe11e709264", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4933), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 8, 1500, null },
                    { "6b199866-2c1e-4940-8e04-6e498f647edc", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5635), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "6c95a1fb-877b-4051-9787-1c0dce149cd6", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4809), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "70308543-89a6-4c10-a419-c9ad0511bdb1", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5709), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN BORDO", null, null, 14, 1500, null },
                    { "7213a5b7-8c23-4aa9-85d6-d903177b85e1", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5427), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 14, 1500, null },
                    { "72f41ae8-6aff-4c82-ab1d-26e92d1165bd", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5343), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 14, 1500, null },
                    { "740a0ed0-75bf-42bc-9993-0172e4a2f8ce", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5030), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 8, 1500, null },
                    { "743ce734-8d26-4902-b074-6be21139e571", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5179), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 8, 0, 1500 },
                    { "780097f5-8993-4557-b9a8-65f291697371", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5977), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI E", null, null, 14, 1500, null },
                    { "7a8c1a45-99e4-49e3-bf22-872aefec3d8a", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4772), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 8, 1500, null },
                    { "7eebb909-26b8-45e5-b347-8103ca87b4f5", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5686), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "8027d144-d643-4ede-bbc7-559f0fd99e39", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5559), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "842af3a9-5073-481d-9fd2-0009f8965d96", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5106), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 8, 1500, null },
                    { "85cef1f3-2eb2-4b4a-8b7e-f42149a0b79a", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5082), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 8, 1500, null },
                    { "8a6ad805-6958-498b-80a2-3c3172173061", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4700), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 8, 1500, null },
                    { "8aaf84a3-6738-415d-a83a-f101bf50957d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5063), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 8, 1500, null },
                    { "8f9ccf91-d127-4f59-a643-c9d5c53b2939", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5716), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI", null, null, 14, 1500, null },
                    { "904da179-31b6-43e3-9035-b3533a296704", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5651), null, false, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "92673830-8e72-430d-b0aa-0205e01a0e4a", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5006), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 8, 1500, null },
                    { "93091f0b-ea14-4f9a-9df7-bea7cf78a3d5", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5014), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 8, 1500, null },
                    { "9742589d-8d4d-49b2-b7bd-5077fd4826df", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5246), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 8, 0, 1500 },
                    { "99e6dc09-d3b1-40a3-9606-859e74d3d3f9", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5262), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 14, 1500, null },
                    { "9b94600a-5f0c-41fa-b645-ab01ca11c957", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5461), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 14, 1500, null },
                    { "9d7a3956-38f4-44a1-9a7f-2f784ee84544", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5914), null, null, true, false, "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", "4dans", "LİRİK", "", "", 14, 1500, null },
                    { "9fd6acee-f099-4516-9afe-664c8bc55090", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5022), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 8, 1500, null },
                    { "a250f675-4274-4f5b-8894-991eb61fe86a", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5187), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 8, 0, 1500 },
                    { "a3085f74-51e6-4801-8f07-ddc4acba5835", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5306), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 14, 1500, null },
                    { "a4a99379-443d-41c0-81c5-263cfeae8ebb", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5550), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "a5083f11-6be7-4d2b-87db-2c87ae52a0a4", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5490), null, null, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 14, 1500, null },
                    { "a5b8921c-1ff3-4ab6-ab0c-51fea68a4d2e", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5281), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 14, 1500, null },
                    { "a5eda580-21c1-4c37-9645-c9a1b4925ac6", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5627), null, null, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "a7213596-4286-4a66-976a-d56518c8fe80", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5373), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 14, 1500, null },
                    { "a730f344-cf01-424e-af08-a20773056f87", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5453), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 14, 1500, null },
                    { "aa10e913-62f7-49bd-8f05-991f22a1af8a", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5827), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N2", null, null, 14, 1500, null },
                    { "aaa06c08-7a33-4c06-92c7-e33c0e78421c", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5857), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ ÜSKÜP-N2", null, null, 14, 1500, null },
                    { "ab283d59-1354-472b-94a1-69e4c29dbf04", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5619), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 14, 1500, null },
                    { "ab986956-b014-4c79-8f90-8ebd077a58f6", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5444), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 14, 1500, null },
                    { "ae715dbf-ad9e-4b9e-9656-d05d1b14c2d6", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5511), null, true, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 14, 1500, null },
                    { "afefd6b8-5a74-4dba-be0a-9edaf0033998", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5163), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 8, 0, 1500 },
                    { "b00dd9c2-0865-4984-815a-f3b345c36568", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5758), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MÜRDÜM", null, null, 14, 1500, null },
                    { "b3c5084f-d588-4d84-9b04-3f1ad7f4ef1c", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5408), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 14, 1500, null },
                    { "b403fb37-4c7e-4282-a089-e5ed508bdb52", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4609), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 8, 1500, null },
                    { "b42c3b4f-6a83-4b6c-a233-978c48aaf44e", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4979), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 8, 1500, null },
                    { "b550ce5c-35fe-460d-9ab2-f66185e7b060", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4875), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 8, 1500, null },
                    { "b650498a-c7c2-47b4-8516-4a2d6ce67eb3", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5602), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 14, 1500, null },
                    { "b6fc6bba-472a-4ee4-9ac0-f3f703dd0106", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4727), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "b78d972e-c87b-45ff-93c5-154803f97449", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4572), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 8, 1500, null },
                    { "b93b0a7a-687c-4c3a-9997-c653f214842a", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5789), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ GRİ-SİYAH", null, null, 14, 1500, null },
                    { "ba5e2458-6ccb-4ee8-8276-e12edec016d1", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5594), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 14, 1500, null },
                    { "bfbeb63b-6d24-407c-a127-7cfdfd225f34", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4986), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 8, 1500, null },
                    { "c1ffe74b-8443-47e2-9cd0-50402ecbd383", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5205), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 8, 0, 1500 },
                    { "c4254282-96e7-4e89-bad7-171e02b9b36c", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4735), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 8, 1500, null },
                    { "c4db16db-396b-4c4a-af76-63139e74e8b4", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4867), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 8, 1500, null },
                    { "c82dca4c-16bf-4656-8466-a051e312d752", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5502), null, null, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 14, 1500, null },
                    { "c846ceb1-10bd-4895-b901-bbdba2836c7d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5677), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "c96fba0b-902e-4434-91f3-cb71b90d2d42", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5843), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE", null, null, 14, 1500, null },
                    { "cab250be-21be-4479-aecd-727ca433cd15", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5365), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 14, 1500, null },
                    { "d2e411f1-ee12-4681-aa61-00f76a6b96cf", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5254), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 8, 0, 1500 },
                    { "d30125b8-535c-4d0d-afc2-3fb09f4581a7", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5098), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 8, 1500, null },
                    { "d670be4b-9395-45f8-91cb-a87f246b82cb", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5969), null, null, true, false, "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN YEŞİL", null, "ROMAN", 14, 1500, null },
                    { "d833b696-fefb-44fc-b2df-4838312cfeb1", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5883), null, null, true, false, "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", "4dans", "ÇİFTETELLİ BEYAZ", null, "ÇİFTETELLİ", 14, 1500, null },
                    { "d8bd0519-f6c0-44fe-8cd5-785143f4fcaf", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5938), null, null, true, false, "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN PEMBE", null, "ROMAN", 14, 1500, null },
                    { "da82ee95-a98c-4be2-bddc-ef6bcde2b96d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4902), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 8, 1500, null },
                    { "dbb6a2bf-ca3b-4247-9fb5-a57ecb793449", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4655), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "dbc2f869-5175-4ff8-9f2c-129608d31b46", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5923), null, null, true, false, "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, "ROMAN", 14, 1500, null },
                    { "de213923-fb80-4d88-8743-38414e0cf02c", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4859), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 8, 1500, null },
                    { "de2ad041-aced-43f2-962e-c24c359cd949", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4963), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 8, 1500, null },
                    { "e01c2402-5225-4ceb-83f3-2162975bde63", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5875), null, null, true, false, "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", "4dans", "AŞUK MAŞUK", null, null, 14, 1500, null },
                    { "e0c624df-4015-4979-8dfb-4933358dd811", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(4751), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 8, 1500, null },
                    { "e3eac08b-a8b2-4046-a957-6c9ba7a8a05a", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5669), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "eacf3d71-352f-42bc-be61-603071629cb9", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5045), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 8, 1500, null },
                    { "ebbeffc4-11d9-4286-9860-9e7d3766468e", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5868), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ YEŞİL", null, null, 14, 1500, null },
                    { "eccab8a0-3725-46f1-8238-1051d8c917b6", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5381), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 14, 1500, null },
                    { "edabe995-aed1-4105-ad39-1fe1a7b34ea2", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5727), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N2", null, null, 14, 1500, null },
                    { "f21341cd-1cf1-4912-aee6-9099876a820d", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5984), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI K", null, null, 14, 1500, null },
                    { "f36c9887-3164-4451-83a2-d0817b6aff7b", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5290), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpG", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 14, 1500, null },
                    { "f3b52a65-f854-4c54-93ac-92c4972cc9cd", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5749), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MOR", null, null, 14, 1500, null },
                    { "fefaf31d-22eb-4de3-994a-f2d276eabc8e", 0, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(5820), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT", null, null, 14, 1500, null },
                    { "ffe06dd2-7f8a-413d-b513-4616a2ec49fa", 10, new DateTime(2024, 12, 15, 19, 14, 45, 219, DateTimeKind.Local).AddTicks(6000), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ K", null, null, 14, 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 19, 14, 45, 220, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "d1ce2528-a4fe-4395-b8d5-4a2802fe5321", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 15, 19, 14, 45, 221, DateTimeKind.Local).AddTicks(4545), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "9706a210-2ed6-48a6-9111-42f7b2ffd050", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "19ba81ea-df1f-4668-b5bb-338024a5ec5a");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "377d8b5f-debb-4a95-b4a0-6aec092ef627");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "7177207f-2366-44fc-a050-c1697defca28");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "bc382cab-dc0d-4ac1-90ab-da76190c838f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0242d3ba-ab18-4173-acd5-ac0a5977613d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "024a89c8-f460-4add-9ac9-5b77d68ddc03");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0399b054-06ba-4358-bfe8-bd87dd469ef4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "072a37ad-4a1f-4199-a343-1d5af85a8e4d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "07ae6403-6d5d-40b5-8513-d0975030474b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a1a0fae-57f5-491c-b2f3-511da36a08d7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a327913-aa2c-44e2-9ffe-216ae89a7414");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c722d9a-feb7-4159-95bb-51aba33687bd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0db1e2ca-06e5-42c9-b43c-49be3a53a9ad");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0dcf24b7-ad37-417d-8ad9-70508d7587ce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e382a40-1e9e-4932-8de6-fe89182538bf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0ef57975-7450-4f0f-bf47-07eb461b38c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0fa98ee9-99c3-4d6d-92c9-2837a781e7cc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1254b2a1-8a88-414e-8b62-ee5d0905b0d2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "125dbf1b-80a7-483a-b4e3-a3995bff2070");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "15faf571-c06a-4dd5-ac14-22fe2c1c4b1e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16a5eb4d-ca20-450b-9ae7-b4f4aa4690d7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "17fe55bc-142a-4248-a46f-da4d1901eb63");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "18471f4c-2ee2-4c22-84a5-d983f933fd5d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "188c8fda-6190-4660-9aba-a732dfab2f0d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c3e92eb-0d5b-426a-80a1-331f1465a4ec");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c8a8ef2-b048-4966-a2ee-817e010ba6ae");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f467419-6c92-4f45-8dca-fe3f76c6ee01");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1fca98bd-1276-4f76-b9a2-974554a07c31");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1feb6200-50d2-45a7-b5a3-4c2fffdd6601");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2000fbe6-d4fb-43a0-b19b-a0779b6fd5c9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "25449503-64fb-4308-829d-d7197d0e7d3d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2738c783-3059-47b8-aded-31bb969c163b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "293bed2d-4b12-4e0d-b4fe-83976158f367");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "29e5ea87-1cf8-477a-bceb-5ef60ad77398");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a444377-0d27-4b9b-8533-d811b3aa41f2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2fe72021-176c-4325-860e-8f12fb8d74d6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "301d23cc-9a45-43b7-8ec8-bd65404b19ee");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31d96073-f148-44f1-8d66-44619871d732");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3223e19f-aba3-4d5b-a35f-f00d96f72c5f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "34a290b1-6889-49f2-bc6b-e77bb1aa6562");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "371ab523-0543-4c34-b684-c4a12bf4e9fd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3c4781bd-22fd-4a2d-84f5-47424a5d470e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d3f9732-9d95-4c07-a091-708bbda1d36e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3db346f3-4523-4315-9b36-816fe9b61898");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e4a6c04-f8dc-4284-91d6-8784b532df1f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "45e47c35-4702-4fd1-b3a5-7b8996e3f777");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4735dc0a-f319-44f0-9f6b-e3847f158922");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "48a11ebe-81f4-4bb5-b7f4-a663d077800f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "48c7b704-342f-43b1-82e6-62d65837d750");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a49b1a4-9421-49a9-b75b-fa1124377204");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b1b0308-77c9-4d14-b1a9-b69da40c9da4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4bdd4d93-f94e-40af-9de8-850ffbb7b6f5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c65c0ad-3571-4b9d-979e-84d659b47ff9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e6fb76b-a383-4d28-be07-4507d2a80679");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50320d92-1a61-410e-b957-ef5665304ae6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "504e75ac-5f32-4c33-bccd-1b2c56765c00");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "51896c53-f63b-4b83-ae5e-56a17919b17e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52ec151b-b692-425c-892d-67a0f26b533e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "53feb8b1-5486-47af-a850-f218b5573ab0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55c0fce6-8b01-44b8-b29c-ac4ba8ae43c2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5675f956-75a6-4f2d-8010-cd0da0fa19d0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a49b775-4803-426c-8864-f0eaf0c60b71");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5abbf34d-6390-4d02-9bfb-06a838f365ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b671691-0c4f-484f-a168-9fd6b788e5c7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5bdb1483-25d2-4a48-92d4-ac7557821465");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5d6754dc-706e-41a1-9d60-cae05bad3dce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "603ff1e8-5e08-4bcb-90bc-8ae052ac86e6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "60519bc5-e796-44a0-9dcc-dc3fb214ecd6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61c7b810-748a-4438-9b7b-cfa3d509e923");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "62da79c0-1b14-476e-978c-93d0ed6d506a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6583fa30-ec12-464d-93c8-f8f27c8aee49");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6675f0b3-a256-4634-934d-f0740409097d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6786f334-d8f4-44bf-962c-aa9d3b52ee00");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "67dfe5db-6311-4d0c-a150-2c3f4798e707");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6864f9de-10dd-45ae-867f-34ab800401fc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69430b96-b88e-4b0d-a9a7-6fe11e709264");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6b199866-2c1e-4940-8e04-6e498f647edc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c95a1fb-877b-4051-9787-1c0dce149cd6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70308543-89a6-4c10-a419-c9ad0511bdb1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7213a5b7-8c23-4aa9-85d6-d903177b85e1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72f41ae8-6aff-4c82-ab1d-26e92d1165bd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "740a0ed0-75bf-42bc-9993-0172e4a2f8ce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "743ce734-8d26-4902-b074-6be21139e571");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "780097f5-8993-4557-b9a8-65f291697371");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a8c1a45-99e4-49e3-bf22-872aefec3d8a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7eebb909-26b8-45e5-b347-8103ca87b4f5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8027d144-d643-4ede-bbc7-559f0fd99e39");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "842af3a9-5073-481d-9fd2-0009f8965d96");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85cef1f3-2eb2-4b4a-8b7e-f42149a0b79a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8a6ad805-6958-498b-80a2-3c3172173061");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8aaf84a3-6738-415d-a83a-f101bf50957d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f9ccf91-d127-4f59-a643-c9d5c53b2939");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "904da179-31b6-43e3-9035-b3533a296704");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92673830-8e72-430d-b0aa-0205e01a0e4a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93091f0b-ea14-4f9a-9df7-bea7cf78a3d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9742589d-8d4d-49b2-b7bd-5077fd4826df");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "99e6dc09-d3b1-40a3-9606-859e74d3d3f9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9b94600a-5f0c-41fa-b645-ab01ca11c957");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9d7a3956-38f4-44a1-9a7f-2f784ee84544");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9fd6acee-f099-4516-9afe-664c8bc55090");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a250f675-4274-4f5b-8894-991eb61fe86a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a3085f74-51e6-4801-8f07-ddc4acba5835");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4a99379-443d-41c0-81c5-263cfeae8ebb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a5083f11-6be7-4d2b-87db-2c87ae52a0a4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a5b8921c-1ff3-4ab6-ab0c-51fea68a4d2e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a5eda580-21c1-4c37-9645-c9a1b4925ac6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a7213596-4286-4a66-976a-d56518c8fe80");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a730f344-cf01-424e-af08-a20773056f87");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aa10e913-62f7-49bd-8f05-991f22a1af8a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aaa06c08-7a33-4c06-92c7-e33c0e78421c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ab283d59-1354-472b-94a1-69e4c29dbf04");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ab986956-b014-4c79-8f90-8ebd077a58f6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ae715dbf-ad9e-4b9e-9656-d05d1b14c2d6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "afefd6b8-5a74-4dba-be0a-9edaf0033998");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b00dd9c2-0865-4984-815a-f3b345c36568");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b3c5084f-d588-4d84-9b04-3f1ad7f4ef1c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b403fb37-4c7e-4282-a089-e5ed508bdb52");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b42c3b4f-6a83-4b6c-a233-978c48aaf44e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b550ce5c-35fe-460d-9ab2-f66185e7b060");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b650498a-c7c2-47b4-8516-4a2d6ce67eb3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6fc6bba-472a-4ee4-9ac0-f3f703dd0106");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b78d972e-c87b-45ff-93c5-154803f97449");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b93b0a7a-687c-4c3a-9997-c653f214842a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ba5e2458-6ccb-4ee8-8276-e12edec016d1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfbeb63b-6d24-407c-a127-7cfdfd225f34");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c1ffe74b-8443-47e2-9cd0-50402ecbd383");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c4254282-96e7-4e89-bad7-171e02b9b36c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c4db16db-396b-4c4a-af76-63139e74e8b4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c82dca4c-16bf-4656-8466-a051e312d752");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c846ceb1-10bd-4895-b901-bbdba2836c7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c96fba0b-902e-4434-91f3-cb71b90d2d42");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cab250be-21be-4479-aecd-727ca433cd15");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d2e411f1-ee12-4681-aa61-00f76a6b96cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d30125b8-535c-4d0d-afc2-3fb09f4581a7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d670be4b-9395-45f8-91cb-a87f246b82cb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d833b696-fefb-44fc-b2df-4838312cfeb1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d8bd0519-f6c0-44fe-8cd5-785143f4fcaf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "da82ee95-a98c-4be2-bddc-ef6bcde2b96d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dbb6a2bf-ca3b-4247-9fb5-a57ecb793449");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dbc2f869-5175-4ff8-9f2c-129608d31b46");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "de213923-fb80-4d88-8743-38414e0cf02c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "de2ad041-aced-43f2-962e-c24c359cd949");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e01c2402-5225-4ceb-83f3-2162975bde63");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e0c624df-4015-4979-8dfb-4933358dd811");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e3eac08b-a8b2-4046-a957-6c9ba7a8a05a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eacf3d71-352f-42bc-be61-603071629cb9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ebbeffc4-11d9-4286-9860-9e7d3766468e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eccab8a0-3725-46f1-8238-1051d8c917b6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "edabe995-aed1-4105-ad39-1fe1a7b34ea2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f21341cd-1cf1-4912-aee6-9099876a820d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f36c9887-3164-4451-83a2-d0817b6aff7b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f3b52a65-f854-4c54-93ac-92c4972cc9cd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fefaf31d-22eb-4de3-994a-f2d276eabc8e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffe06dd2-7f8a-413d-b513-4616a2ec49fa");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "d1ce2528-a4fe-4395-b8d5-4a2802fe5321");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "9706a210-2ed6-48a6-9111-42f7b2ffd050");

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "0a581413-0c67-4ab8-8c75-9f9f2e48ff44", new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(7047), "Siparişiniz Kargoya verildi" },
                    { "0e20dd16-6655-4d7d-8942-77dc124b53ff", new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(7051), "Siparişiniz Tamamlandı" },
                    { "340b2c2d-ee3c-488e-b2de-88944cd574c2", new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(7042), "Siparişiniz Hazırlanıyor" },
                    { "3e779e25-0923-490f-81ab-df2c6b03832b", new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(6994), "Siparişiniz Alındı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "Size", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "00d1a858-1a3f-4fda-860a-45f9257b8cc2", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5839), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 8, 1500, null },
                    { "03529ba8-6948-445a-a8bf-d5a2b864b05b", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5824), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 8, 1500, null },
                    { "0396b6c5-af67-4ccf-a92f-9c9ea13319c0", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5813), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 8, 1500, null },
                    { "07011efa-6524-4edd-b91c-b7e14dd7ca81", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6230), null, false, true, false, "/databaseimg/HALKOYUN-VAN-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "0ce50e64-6a35-40ff-a274-2043b1581e45", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6004), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 8, 0, 1500 },
                    { "0e67b642-0c5a-440a-8a65-81f265de501c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6141), null, null, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 14, 1500, null },
                    { "0fc8197e-aef5-469d-a1ab-6e60955619d5", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5799), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 8, 1500, null },
                    { "150d3278-31be-42d8-94d2-d067b3ac9a4d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5970), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 8, 0, 1500 },
                    { "16fc0140-30b4-4cd3-be24-067820dbeb6c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6210), null, null, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "1c95f9d7-eeff-4aad-be05-2e56037a64cf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5665), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 8, 1500, null },
                    { "1ca0bcd3-86c9-4ee2-9084-f34019605346", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5885), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 8, 1500, null },
                    { "20143159-5369-4562-ba57-e369e9520b48", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5780), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 8, 1500, null },
                    { "21e92b44-6eb1-46e0-8d9b-e2b4c862819b", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6072), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 14, 1500, null },
                    { "231fb661-bbbe-4dac-bab7-4900ec51c6f4", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6245), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "24dec3f5-7988-48ba-9364-b1282efa7036", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5974), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 8, 0, 1500 },
                    { "25db851d-c05e-46ac-b90b-2c51c2d8253e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6158), null, true, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 14, 1500, null },
                    { "26fe5e28-1060-401a-a3c0-8a217dc91c06", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6095), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 14, 1500, null },
                    { "27829230-fa39-49f9-9aba-3d0d1d28594e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6106), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 14, 1500, null },
                    { "2d9d0dc9-37a4-45bd-a5dd-eb41d355f4f5", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5848), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 8, 1500, null },
                    { "329c0570-7598-4939-8f7a-1aac19d15975", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5709), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 8, 1500, null },
                    { "3cfddbb0-2663-4671-8ff3-712ac24b5889", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6047), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 14, 1500, null },
                    { "3d0a92bc-3106-44f4-b443-149c2fc895ba", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5980), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 8, 0, 1500 },
                    { "3d0f5b37-2d73-4db3-b6e9-35264b1601ac", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5804), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 8, 1500, null },
                    { "40483e35-48cf-4960-b51d-3548b0ec3eef", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5795), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 8, 1500, null },
                    { "411004ba-6ed7-4549-9dfe-f8605948765e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5914), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 8, 1500, null },
                    { "4156b015-5f67-4782-8263-9c69884d899d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6086), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 14, 1500, null },
                    { "444658cf-e84c-4b89-a625-2220d40cce86", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5890), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 8, 1500, null },
                    { "461b9443-2582-469d-b952-92f55bb6d00d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5689), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 8, 1500, null },
                    { "49eec1e2-af9b-4410-9e91-36f17b628851", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6185), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 14, 1500, null },
                    { "4c02c36b-b10c-4d66-97ff-f5aedd2d3358", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6042), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 14, 1500, null },
                    { "4cec16cd-f212-4ce3-a11e-20e713ab6ee9", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6196), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 14, 1500, null },
                    { "508e885c-3a4e-4a9b-8b19-d18dd0957468", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5844), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 8, 1500, null },
                    { "530fd436-ba4b-498c-bf8a-2d7df80417b1", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5739), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 8, 1500, null },
                    { "547c0c13-01f8-455d-aa99-ae478f22d4a9", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6117), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 14, 1500, null },
                    { "55d47038-0d47-433f-bddc-f3754ae11ddb", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5894), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 8, 1500, null },
                    { "5c005a5c-36e6-47b6-8fc0-d4ce9cc6da21", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6192), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 14, 1500, null },
                    { "5d422b5f-62da-44d2-8580-87c9aa6b4b4d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5937), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 8, 1500, null },
                    { "61cbc635-34f8-4b98-8f6c-6cfda91618bf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6056), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 14, 1500, null },
                    { "61d65e65-741b-4d37-ad55-524501038a7d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5654), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "62a2a7b9-f256-4c3a-98cd-eedbc02d4197", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5863), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 8, 1500, null },
                    { "6384c0bf-a202-4cba-8781-d5da88cbae6d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5852), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 8, 1500, null },
                    { "64645f17-f500-45dd-a34d-d2d73a639c6c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5774), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 8, 1500, null },
                    { "67ed74d9-da48-4e3c-badb-5b37db76b647", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6171), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "68447990-d592-4417-94d5-817dd9f345e8", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6167), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "6a84f992-8bce-4ff8-83cd-5cfd04a3b31b", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6126), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 14, 1500, null },
                    { "6a878e4f-03d0-43bc-b8b2-7db91a4401e5", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5809), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 8, 1500, null },
                    { "6aa220ed-3e43-4f64-9102-8a7eac1a4ef0", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5932), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 8, 1500, null },
                    { "6d546985-0380-442d-80ee-d3bdd3643684", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5995), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 8, 0, 1500 },
                    { "6f94be7a-0145-4d71-bbb6-e3431ba66ab9", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6000), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 8, 0, 1500 },
                    { "7266ed8d-bc61-4f9b-a340-e79f3168312c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6077), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 14, 1500, null },
                    { "727c9144-b957-451e-82a3-e0b5b00bc0f9", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5714), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "7310aafd-cafa-40ef-951f-28757cc89d15", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5943), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 8, 1500, null },
                    { "732b6177-a2a1-456f-9b93-59663384b2a6", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6260), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 14, 1500, null },
                    { "73e28867-1a9c-4716-aaec-fb7dcdad86ce", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6224), null, false, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "755db037-2139-47ce-9e55-4dd8930822fc", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6091), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 14, 1500, null },
                    { "75f46dc6-b1c4-42ff-8cff-d32ac1f20617", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5760), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "7805bd15-bda8-4916-9cc0-ee3add4a78aa", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5733), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 8, 1500, null },
                    { "7df91756-30eb-46ae-a4be-0b322ce38402", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5682), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 8, 1500, null },
                    { "809ce49d-3d66-42ea-9e3e-59f789fea71d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6146), null, null, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 14, 1500, null },
                    { "812422ff-9f1b-4ca6-9c46-994041fcfb8a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5881), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 8, 1500, null },
                    { "82c26033-7065-42da-b8ae-ebc84bd53cdc", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6032), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 14, 1500, null },
                    { "8d06b16a-c0af-4ff4-aa11-24856651fddf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5910), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 8, 1500, null },
                    { "959e6378-9efa-4b84-b7f6-80d1ad7589e7", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5764), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "9872f9de-1f03-4a97-abea-0a3fcf524d7b", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6027), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 14, 1500, null },
                    { "999efea5-3c4d-466b-8e01-76d5fc04969d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6176), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "9aecf701-8bdf-484e-8c67-4645d6b22d05", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6061), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 14, 1500, null },
                    { "9c71d876-d824-423d-8bd2-d4ca7e1497a5", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6241), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "9ef0d7b9-5535-4aa5-980c-d82359265a6d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5769), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 8, 1500, null },
                    { "a5f8a24c-d22d-417b-8552-b76c3fd11e30", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5785), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 8, 1500, null },
                    { "a74c926c-26b2-4af0-844e-46b9226c7224", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6219), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 14, 1500, null },
                    { "a7ff2ef8-49a6-4c1b-9ada-16f7140fa45f", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5671), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "ac5db831-3e1d-463e-a06f-1e951d5a0b97", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5877), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 8, 1500, null },
                    { "ac687d5f-fd30-43e0-bdb2-3220805b0e03", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5919), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 8, 1500, null },
                    { "acc7bf82-2056-45ef-bb02-b69712c7a822", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5696), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 8, 1500, null },
                    { "acca2e84-b6f7-40da-bf8e-2590b8350d4e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5830), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 8, 1500, null },
                    { "b0a00229-455e-47bf-b91f-4a2d600fb12d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6100), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 14, 1500, null },
                    { "b0c912a2-b5f7-4916-872b-ebcacdfb397e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6250), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "b132b9f3-ff1e-4c6d-8721-d249b6044758", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5872), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 8, 1500, null },
                    { "b4136ee7-d477-4561-b299-cf1fdc799f87", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5745), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 8, 1500, null },
                    { "b7589b08-c6de-462a-b1b9-8d2f7b11c5df", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6111), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 14, 1500, null },
                    { "b79659aa-0adf-40c1-94bb-475b8dee7d6a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6122), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 14, 1500, null },
                    { "b8dbf089-c937-47a9-941f-091f8cb216b0", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5659), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "b9182a07-9242-4a8d-b002-16d10634ce23", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5990), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 8, 0, 1500 },
                    { "be716ac3-459e-4afe-b9c9-a66c2c4f0f17", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6181), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "c05a6568-c31b-42a1-8776-9181e0a5559c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5719), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "c1e725b7-4e6c-4c95-9b23-8b9984a53f77", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5677), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "c2472fcc-e49c-4ec7-bf31-4f6c1cf37849", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5900), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 8, 1500, null },
                    { "c3fb5f5e-5a49-4e21-8843-6d5efbce01cf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5965), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 8, 0, 1500 },
                    { "c57e52d2-7ede-4eaf-a8d3-f23d03085715", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6037), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpG", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 14, 1500, null },
                    { "c7ff0826-4134-4e47-b3ab-0464577f5991", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5627), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 8, 1500, null },
                    { "c88677ab-b32f-4313-8686-36215ca078ba", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5961), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 8, 0, 1500 },
                    { "c8bcebbc-585d-4c6a-865d-bc9b6e769398", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6215), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "c8f016cb-3072-4c2f-a867-88dbcb67bf3a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5728), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 8, 1500, null },
                    { "cb9a96e9-f216-49c6-9118-742bca8b1b7f", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6162), null, false, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "cc1622c9-f670-4fd0-b43b-cfc791b74e7d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6014), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 14, 1500, null },
                    { "cd6437ad-d6c9-4fd9-977c-8258a946ff35", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6236), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "d0f91b9d-13db-41a0-ab96-93b8bb216b20", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6205), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 14, 1500, null },
                    { "d1052221-b786-44b7-909c-6a52138d28eb", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5857), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 8, 1500, null },
                    { "d21af49b-9255-4eef-9aad-2015be5eecbf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5647), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 8, 1500, null },
                    { "d3256ce4-8820-477b-9c23-f0473f30bbcf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5986), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 8, 0, 1500 },
                    { "d584b540-aa55-4b68-95b7-709c0cb7feae", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5755), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "d641c5c7-cd44-4812-a6a4-7ceeed270ae3", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5723), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 8, 1500, null },
                    { "e582de49-e65f-45cb-89fe-8f5450469b3a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6051), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ", "DOGU ANADOLU", "BİTLİS", 14, 1500, null },
                    { "e60f82b7-167c-48c3-a367-4a228ae78d3e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6081), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 14, 1500, null },
                    { "e7d74b70-d72a-43f0-8fb5-81005dea146a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6131), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 14, 1500, null },
                    { "ea8ca821-a085-497e-b0b1-645f963c1367", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5905), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 8, 1500, null },
                    { "eb47b780-813c-46d9-8be2-a912ee8aff37", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5834), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 8, 1500, null },
                    { "ecf00b7f-4a81-4dd6-81b0-ebb885ea9ce7", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5868), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 8, 1500, null },
                    { "ef924b3a-0a28-4340-9c55-49545db02952", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5948), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 8, 1500, null },
                    { "f75c301e-599c-4c64-a432-69890384d0d7", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6153), null, null, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 14, 1500, null },
                    { "f805d438-91a2-4225-86d6-fd4d3957430f", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5957), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 8, 0, 1500 },
                    { "f8e53933-48c8-49da-9864-b03792cacba6", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5928), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 8, 1500, null },
                    { "f9301541-c680-4451-a1a8-30cd8184162f", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6009), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 8, 0, 1500 },
                    { "fa606cc8-ae9a-4c81-ab99-c035a3fde49c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5749), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 8, 1500, null },
                    { "fb01ba02-5ec3-4583-9b52-c8c447ac5963", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5790), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 8, 1500, null },
                    { "fb7474f8-7a2f-476b-826b-a4c40f665077", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5953), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 8, 1500, null },
                    { "fd28af3c-c1f7-40af-a2cb-9742b1b11006", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6067), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 14, 1500, null },
                    { "fe1ca323-a536-4a05-b563-bfa983ec396c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6201), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 14, 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "ef3825da-f0af-44d3-9d45-2ecca7ec0ef9", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(7549), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "b2c7931c-49a7-4830-a197-183547a13c25", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });
        }
    }
}
