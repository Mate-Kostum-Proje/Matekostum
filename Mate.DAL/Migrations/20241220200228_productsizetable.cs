using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class productsizetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_Id",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_ProductId",
                table: "ProductSizes");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "1b89e2b7-dbcd-491e-bbd9-6ed9e98fc01f");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "264ecf8b-e827-4705-8d88-33bcc6785b5a");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "44c9ed0e-e9a5-4c95-acf0-1c9e5eef12c9");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "4a583063-2ee2-41fd-8ef1-94f504fcc286");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "526556a0-189a-4d2f-81a7-a943c97d1c9f");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "58071e99-f236-44c3-bbe5-4cea0f8ffeaa");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "8e9c04f2-13ff-45b1-baf8-540b7f348329");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "a671fb5c-557a-47bd-b347-c2443ddc57fd");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "adcd4088-7a98-455c-bd2d-c5ad88f07974");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "df8509e8-4fc9-4fec-b31e-bee47e39882f");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "e03a3596-6d39-4207-ae95-e99c871408b8");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "f4ddd565-c3b4-4b3e-bfa2-27e1c3dc8c1c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "08398545-47d2-4d9f-8c9c-9648ff65b0ba");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "0f646bc9-034f-4d8f-a93d-ae4dc8c90419");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "2f0c4c86-bdb2-4778-a0dc-4908e470ed35");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "3363b849-13b8-4a64-b105-ea594a7b0e9c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "41145e12-7699-46f1-bcc4-199aba0ec6ff");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "423273aa-4c1a-4c31-8bfa-b7324d8ef173");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "4bb6bdaf-f0a8-4c1b-a3b2-40eafd2a89ad");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5b6033d8-7210-4e9e-8398-46d8c34161b5");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5f1b3f9b-0574-43dd-b493-8cd33e459b12");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "6e5c8d63-b753-478e-9be0-1f7c304440fb");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "72c87428-cf6e-42c7-aa28-50b6b1843710");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "88a43f4d-a250-4fdb-a397-6144ed19c25e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "88cd7728-2f93-41d4-8f0a-45fe3459449b");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "8e0558fb-c695-48ec-89fd-dc35d17c7405");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "94f24999-7c03-4aa6-ba6d-aa8335649be9");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "a5b6d257-a9e1-4b81-a1fd-dbc4f826b07c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "a9db2ba3-e96d-4d60-8e90-93f752ed03ca");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "af7eb7c9-1f91-49ff-b8ab-16c387f13bab");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b779c08b-abd3-46b5-8aaf-94eff51b71e8");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b7919e75-ea82-4dd4-85f6-9121c8e4ae4c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "c82b2431-b92c-449c-94c2-701dd0fbe457");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d3a3694c-4963-4d67-bda3-8ba8c9fe4217");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "da2bd17c-1f9d-4a9f-b926-7efdca1c54ef");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "dd3c01de-520a-4fb8-932a-52933cf67683");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "455a8f27-9d84-4f95-8e09-494f99866a3b");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "a45358e6-0f2b-4d18-825d-44f907a3ada7");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "b81d44f6-abb1-4594-b4ca-5cb52509d3a9");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "cb77e289-c518-4780-8ea5-32ea102e063c");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "3239f7e3-2a41-4479-aaa0-d55545fdca23");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "52a4cd9f-166a-481d-890c-05e50257655c");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ProductSizes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "UnitPriceForSale",
                table: "BasketDetails",
                type: "int",
                maxLength: 100000,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100000);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId" });

            migrationBuilder.InsertData(
                table: "FotoDesign",
                columns: new[] { "Id", "CreatedAt", "Name", "PhotoPath" },
                values: new object[,]
                {
                    { "00dec16e-23b7-444f-a3aa-88cc8bc2246c", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7352), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "3de66ea5-fb86-4531-ad04-d22dd74e4f63", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7370), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" },
                    { "465f7699-30f0-4c7d-8c1d-132d5d16954b", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7331), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "61c0ad8f-d62d-404d-b56b-d5729bbc53fd", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7356), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" },
                    { "7dcee25d-4880-46d2-93dd-d1f6ac3a57ec", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7360), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "990879c9-b117-43b9-af9d-da61d2a9efea", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7280), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "a18488c1-6955-41a7-a926-30f98a09c6d3", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7374), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "b5b138cb-30d2-4487-ad08-7119d54c9aaa", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7326), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "bb9a85b5-6581-43bc-8472-e70d840489c4", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7378), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "f1446d03-b46b-4863-9bf4-e6cb76b60d00", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7336), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" },
                    { "f14f90a2-c1fb-4d36-a6a6-fc70b003008f", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7340), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "f25a2d0f-daeb-4226-b7f4-cc475007ea59", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(7365), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "0c9c1103-6791-4709-945f-979f39831dc4", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9309), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "1794266c-c2f1-40ae-9091-9dfd88a7db94", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9353), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "1c743e77-8205-44d4-a4f7-eba2c8e9d7f6", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9357), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "1fb1bf27-096c-42f5-968e-be7f47222e21", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9391), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "27f3fe59-fd4c-4e54-94f6-360fd3650357", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9319), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "3771bdb7-adaf-400d-abdf-e0560cc55c4c", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9360), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "52645bff-35f5-4b61-8b9a-ea38f690f6b5", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9297), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" },
                    { "5d6ab2cc-c201-4722-91cc-32711697d0c1", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9334), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "623f6b0e-26ae-4a16-b4a8-c40405269fbc", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9366), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "7d54168a-99d2-4af0-8261-f0fc1456b690", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9373), "/databaseimg/galeri/galeriIMG-8454.jpg" },
                    { "7dfc0d6b-c848-4724-bb5d-5566239edb13", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9377), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "864ef4f1-3049-40a7-b840-25f0e8a995c4", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9327), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "a834e7c4-c840-4d8d-b28d-5b5b19ad9153", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9350), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "ac2b2392-b6ce-477c-9ce9-5b312bfd05b9", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9305), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "b5d942a7-c713-4f5c-901c-69c3faf7f95c", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9323), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "be628b91-19d1-418a-97f0-a46b3fb64a67", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9387), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "c99d7bee-a682-4ea9-9132-10a792605bc4", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9301), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "dffe7ba9-5a12-4922-934e-f80291baffde", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9338), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "e819c5f1-36db-427b-887c-c72cc0f40722", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9276), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "efd6007e-69f9-4746-8f9d-691d3690f12e", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9370), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "f1abee9d-1fdb-48fb-894c-143b7b13bf45", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9395), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "fce5ff90-97bc-476a-bc61-9c1e5ee561b3", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9346), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "fd137de8-20df-4044-a182-ece503fbd64a", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9342), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "febb7317-5e4e-4a25-add5-bd93be917773", new DateTime(2024, 12, 20, 23, 2, 27, 202, DateTimeKind.Local).AddTicks(9315), "/databaseimg/galeri/galeriIMG_1958.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 208, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 208, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 208, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 208, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 208, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 208, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "68cf81d1-a382-4871-9988-bb8f1d573328", new DateTime(2024, 12, 20, 23, 2, 27, 209, DateTimeKind.Local).AddTicks(6786), "Siparişiniz Tamamlandı" },
                    { "8f1c83cc-767f-4dcf-a2d9-99fd437ce843", new DateTime(2024, 12, 20, 23, 2, 27, 209, DateTimeKind.Local).AddTicks(6766), "Siparişiniz Hazırlanıyor" },
                    { "95ab63bb-869d-4d92-89c7-022c2d4ec20e", new DateTime(2024, 12, 20, 23, 2, 27, 209, DateTimeKind.Local).AddTicks(6771), "Siparişiniz Kargoya verildi" },
                    { "d5b801ea-3585-4bc3-af34-25f4345dc1f6", new DateTime(2024, 12, 20, 23, 2, 27, 209, DateTimeKind.Local).AddTicks(6748), "Siparişiniz Alındı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 209, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 209, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 209, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 209, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 209, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.InsertData(
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId", "Id", "SizeAmount", "SizeNumber" },
                values: new object[,]
                {
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3dfc3b23-f81f-4a6b-85ef-fec890f718fd", 6, 12 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d7edc53b-59c8-4c0f-a3fb-626ad50404de", 7, 14 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "df7bb3e8-948b-44bd-8fbb-0a8c8f6b249e", 4, 8 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "da9473b2-4096-480b-9e24-23b6b0f09081", 5, 10 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dc179159-cf83-4367-b5ad-a6777d27aebe", 6, 12 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1d428b11-9adb-448d-a55f-843cd001e50e", 7, 14 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "40403c84-2634-44fd-9a42-b91a769ad2f1", 4, 8 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c858cfb4-68ae-4023-93c8-99cd609ed0a1", 5, 10 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3cfc0e08-3683-4fba-b72c-e1d123c352a1", 6, 12 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "17830378-a485-4c29-8b94-fa38d1c3ce34", 7, 14 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e5a45b56-c13e-4a64-926d-794277f23174", 4, 8 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5237bd54-77fb-4166-852a-cf78735a2e1b", 5, 10 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f05cdd09-6293-4be2-9e00-10f61f2e2ef6", 6, 12 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "818e41f2-6fb7-4bc1-a284-e1af69bcac03", 7, 14 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cd0bf217-00bc-47bb-b9eb-0ca0368ff822", 4, 8 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "27140751-15e3-44ff-865b-408f3f7f4cb2", 5, 10 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a4373899-4619-4a03-a6af-02a408326c79", 6, 12 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "db756082-1b97-4b43-ab2d-43e402e4b8ce", 7, 14 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1ee4bbd2-7924-418b-babf-e57660c4e465", 4, 8 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7c912f8e-d946-43fa-aac9-58f6409a418a", 5, 10 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2bbe9e07-e583-44e4-b427-c1c42ed750cc", 6, 12 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "476adcbd-e114-43ca-b833-f95aae58ba37", 7, 14 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "74f4df9c-e245-4c93-9fc8-5e1fa74185b8", 4, 8 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f4b84534-81ca-4334-bf4d-4edb2d346ac6", 5, 10 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a7fb1616-a885-4573-bc07-b9d2c2060705", 6, 12 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0dfe1b82-8891-4df5-b323-4078fd327abc", 7, 14 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2f02cab4-13a2-457d-b6a1-04c83c543d28", 4, 8 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3fa01044-ea3c-401c-a2ae-c0ebf884d3a1", 5, 10 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "27af6127-76e2-4df1-a438-c8d7d79b220e", 6, 12 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1aeeef4d-b18e-44a5-8022-fda854b3bca4", 7, 14 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ed50031a-83a6-49bf-8847-912cb2ed6bf1", 4, 8 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9ac9d62f-e4d2-4ee5-9c15-3fa9bc4b34bb", 5, 10 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eec4e5e5-4a69-4a1a-86ec-246c87d0b55c", 6, 12 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ad9f08eb-c1c7-4452-a4b2-b39a98ac86b2", 7, 14 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d606f331-e547-4e57-a1c2-ac793da58bd6", 4, 8 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9b99bb1d-e181-495d-9327-46be57b8b604", 5, 10 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f8d219d9-4e7d-4afe-8a63-d369d284a0de", 6, 12 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bbe51abe-fccf-4e12-ab6e-d5e9775ceaed", 7, 14 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8187df0e-1d8d-410a-85bd-6b18ac09ab56", 4, 8 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a0c96f0f-b7a6-4e53-b866-dc1ce95be966", 5, 10 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b70ccc85-ab9b-4139-b272-64ed96c1ccf7", 6, 12 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6c75b5a1-e6c7-48aa-af5f-a71e5bf9026f", 7, 14 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a32318c9-c504-47d0-bf7c-9278d5a7ef4f", 4, 8 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0b5c9119-536b-4863-b55b-148f57bac501", 5, 10 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "83aba9b5-61bd-4b70-9d89-dc0d2247ba8a", 6, 12 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "14a2a98d-c31e-4fca-b73c-33da29964268", 7, 14 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "73308692-c516-470c-b327-776e601118b9", 4, 8 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9aff2c13-db50-4529-9bb3-5cff6fec56d2", 5, 10 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "be053204-76c3-42a3-9fbf-c2abfd645a66", 6, 12 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9252d730-e22e-48bb-aa22-ab104f5fa0c1", 7, 14 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cdf2a01b-674c-4570-8895-87994db6d086", 4, 8 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a684c5b6-19bf-40d7-ac09-05ba871760fe", 5, 10 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7b183bfc-3fae-4a6b-bcbd-7c908d4ee2e9", 6, 12 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "25f01b9f-806f-43eb-9296-0a27d77271da", 7, 14 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "00502488-c5f0-4249-ae46-fce95a05cbec", 4, 8 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0f698569-bb57-45ed-aab9-9b6680fcce15", 5, 10 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "25864797-56d2-4652-9b17-5625831d4ac9", 6, 12 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2025393a-4388-4406-ad65-042d1cb79bc9", 7, 14 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "90392fdb-04ea-4522-b3c2-4f30744c2fd9", 4, 8 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "730e46e1-95d6-4b89-adc6-a1bca8f6b2af", 5, 10 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f54ef070-484c-4ec3-9f10-433c5396869a", 6, 12 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e2434af0-16e4-4f3b-a4ff-719f82fa9bdb", 7, 14 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "eb9ae15a-fefc-4208-a58a-621255e6b48e", 4, 8 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3bdf6c8c-090b-4a99-be50-6d17ae26521a", 5, 10 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "86b5489d-043b-496b-b25c-30c5ffd503cc", 6, 12 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a983df04-3cd3-431c-98a2-d2e9488d62dd", 7, 14 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6c73aa93-7640-4e21-b045-d42b56c74ae3", 4, 8 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "49264dd7-348e-4123-9af1-8de08702207c", 5, 10 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4e94340a-3faf-4fd2-a955-277158e4278e", 6, 12 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "301ff00f-6c97-4a37-8254-2315da1204df", 7, 14 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "43e0f5a2-748a-4efd-98bb-f5d9a0f3a7c6", 4, 8 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a8ff87b6-3bf4-4eb2-8fa7-df30535b3a28", 5, 10 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "79010c04-0901-4a17-b62d-597f49288518", 6, 12 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "20af8775-b6d4-4a56-9ead-9c11ca0ff773", 7, 14 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b035e58b-f06d-4eca-8824-c7cd51fafd3f", 4, 8 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "53b03808-52d7-4310-a6ef-cc3d4c7c73c3", 5, 10 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cbaefbb5-4dd3-435a-a33b-e3562c683d58", 6, 12 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c5ee9803-ce5e-42eb-b2ab-ca15d4dad0dc", 7, 14 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0fcacf1f-3791-4657-9736-4ef09a08e614", 4, 8 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "714d2eae-8a8a-4da1-89aa-6effafdd3e86", 5, 10 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5869e0c0-0bde-42a5-9e3d-ee0380a691b3", 6, 12 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2ed4b5b5-ae64-4a3a-9405-4d9e432877f6", 7, 14 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "77a7e9b7-c699-42a9-965d-7b189cfeedf8", 4, 8 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ae512c1d-fe1e-4f08-8b35-45267070dc6a", 5, 10 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9e886899-f9e8-4ab4-8499-1cd6f1e0199c", 6, 12 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b5be5588-d4db-407c-a138-5b8309e13eff", 7, 14 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "053756b2-92bd-4596-bb45-54d41345cdc0", 4, 8 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4f7d9bf5-4db7-468f-b89f-43f2b3681b36", 5, 10 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1be9431f-ebbb-4475-a118-e17413e508d6", 6, 12 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8d0aa561-3837-4d92-997b-d8c092482e58", 7, 14 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1d869379-f846-4cba-abf8-52978ead7287", 4, 8 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b5868139-1fcd-4a02-9863-67bb3bf89359", 5, 10 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8ef58c07-87a6-41f1-8ea3-1546dd75533d", 6, 12 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "daa0f968-a77d-4073-bef2-e0b03638a705", 7, 14 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "87e89988-4427-4cb8-b8f1-4b766bf92140", 4, 8 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c2bcaec5-3197-4462-bae8-ec56dbb07366", 5, 10 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "43a24836-13c2-4bd3-835b-dad353ff0169", 6, 12 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7edeb585-6707-4f59-a6fc-242b213fa372", 7, 14 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "da7e915b-2639-4159-880d-8040a486bbea", 4, 8 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0fd78b98-ab20-40d1-af3a-4464ffb48958", 5, 10 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "24fa41a8-a2f8-4c2d-8bb9-49d032f67132", 6, 12 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8f5839b3-2113-46da-a0f5-614f32587354", 7, 14 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ea1f8cb8-c336-41c5-b637-c7fe78f77e12", 4, 8 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1fde5447-115c-4f83-a581-a13a6384f7aa", 5, 10 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0ff35efe-8801-4057-9cd9-ea5a34d71c19", 6, 12 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "64b60b78-0bff-498a-88db-bb1959ac77a7", 7, 14 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5af3a6ec-68ab-454c-a717-39bfdf4ce01f", 4, 8 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a4fe7a78-bcf2-434f-a652-a14711b27cc2", 5, 10 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7d1a15ab-55f9-4a1f-9cb9-e7ad44fd9d9f", 6, 12 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3e2eb4b7-76d0-4e58-a84d-f5804f754b18", 7, 14 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fdae2e95-0c4d-4f2f-a293-939655be4196", 4, 8 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "42a5ad04-3921-4e96-a5c1-4a663dfaee66", 5, 10 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ce615b2f-dff0-47dc-a88e-30328044b26a", 6, 12 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a3b1804e-366b-4232-941c-e5a3948b90dd", 7, 14 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "92dde856-0efd-414c-8dff-1f3bac97d258", 4, 8 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e7818843-9f2a-4e75-994d-4fa2c518cac0", 5, 10 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2af4dffb-9b85-4d36-91f7-9bc60178a588", 6, 12 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b8b2bf3d-989e-449e-af56-90219eb1d0d2", 7, 14 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b7ef50cf-cefe-4f71-9695-530a0a5e2d83", 4, 8 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a80be09f-0c17-42c8-9b14-17da9987df69", 5, 10 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5d6e118b-32b4-4c58-847a-4b8ce4da34ba", 6, 12 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "362617c7-7309-4c18-832c-ef685ab788f2", 7, 14 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3b95f753-b39a-4ac6-8673-91abe27de9cd", 4, 8 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aa8bec81-4519-456c-9e3c-1392ad0a7876", 5, 10 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5c5fa853-e500-41e6-a453-0035e08f127c", 6, 12 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "63f2bb64-0750-47e8-b51c-609aac5cdbec", 7, 14 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b182bcaf-532b-4494-b9b6-853bc730aee2", 4, 8 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a581e860-ecb7-4e7d-96bd-f3b54709ac82", 5, 10 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a635c788-a113-4052-bdb1-3ac7f02acc79", 6, 12 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8525296b-905e-4aee-8cc0-dc63e994784a", 7, 14 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f684679c-cea7-458a-b45e-e905d0463ea7", 4, 8 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "89e40c68-7674-4d40-810c-8baac398aa9b", 5, 10 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8fad2968-f47c-46c4-a6da-a3ecfae06991", 6, 12 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "574714f9-b754-44ad-bf68-79f9e50f03eb", 7, 14 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4ca22c28-7cd4-4150-95d1-585ea4aff425", 4, 8 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "be46aff9-c0e3-40a4-8a41-4e899c31aac2", 5, 10 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "21ec5de9-cd3c-4125-af28-97a80063a764", 6, 12 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "878e0dce-801c-44c2-a56a-a14ecb8817c2", 7, 14 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0433a4c3-02a6-4bcf-b3b7-cbb00b8ac28e", 4, 8 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "20e254c3-4a15-4161-802b-ef674619e98c", 5, 10 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "608982dd-fd80-43e6-b3f1-e54ea9de8094", 6, 12 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2979c3e9-f5f3-4bbb-8976-3357fc5a3490", 7, 14 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e0333ffc-ea01-4683-b8f3-7ff5bafc4009", 4, 8 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "313c5e3f-1efc-4324-bf36-5631bc5b0a20", 5, 10 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "54607c55-e8c1-487d-b0d6-3bcba0e26a18", 6, 12 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "aae808e6-fd92-42ca-be0f-6a97ea53672d", 7, 14 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "15e3e312-8326-409f-8f8c-1219f114e7ee", 4, 8 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d6b8f888-c196-4293-9b59-2801f162605e", 5, 10 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5903f587-e441-45a8-af78-784a7c570a2e", 6, 12 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "31d73d60-7215-4672-8e4f-b4e6e17390ac", 7, 14 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cb1f6c20-2447-4bf2-9f06-e99d21dd2362", 4, 8 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "610a03e7-e824-473c-ae8a-c4fad71f3c19", 5, 10 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "713bb514-fc2a-4c15-8ee1-7e97b6c40925", 6, 12 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fba958fd-c40e-4961-b771-ea50bfb786b1", 7, 14 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dfb68040-f383-4309-9737-e3f7d2b1c6be", 4, 8 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "564689b5-59a5-4dd5-b767-8cd691cee3c7", 5, 10 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c0316891-ecde-49ae-aeb0-8ab9bb2bf10e", 6, 12 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "333cf3a8-e0dd-46db-ba29-36b5028dd858", 7, 14 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4ff7892b-84c1-42ca-a78f-d03e6cbefbc8", 4, 8 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "02371f16-119a-4e37-ae88-aef3a9f325eb", 5, 10 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0a23c36f-dd4a-4601-92e9-ee12447ecb59", 6, 12 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5c56e731-0224-4cfd-8cd5-f26c4645c49f", 7, 14 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "25e7eae3-b3de-4d70-a81d-ca89cde06e76", 4, 8 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f2f21966-fbeb-4c7d-85c7-a35674f8553e", 5, 10 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ed218ade-4a1b-4715-b9c2-303dbd0c7254", 6, 12 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "17a73e8c-2db3-4735-95e8-08c9cddaa281", 7, 14 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0309597b-cf3b-4ede-8703-f065690dd5f6", 4, 8 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "066ba489-09ac-447c-aa53-7e8fbc088c4a", 5, 10 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "20131776-05ac-456b-88bf-9ff090f9ad71", 6, 12 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6752ddd9-66be-4de5-afc6-b0a01f273ca5", 7, 14 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c4d6c655-c7d3-4470-8c43-97a8733bf159", 4, 8 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "da3f1670-96af-442b-b4c6-91b84d9e32f7", 5, 10 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "92cf7a78-ce75-4727-8c3c-853ddf3ebc38", 6, 12 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b0135aa2-7fee-42ff-898e-174f80d39318", 7, 14 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1d5e410f-acb4-4d27-b76d-0138b2034d85", 4, 8 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "44f36120-2279-4f65-9fa3-6c48e1bb01ab", 5, 10 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8b229174-cfbb-4e3b-bb41-7a73b62c1ee8", 6, 12 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6b323a33-fac9-423c-9122-3f12dc7511ff", 7, 14 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "20a2c051-6eaf-405f-91a1-6675c6a64600", 4, 8 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9b9f2221-d37a-4d59-8f2f-5dd634492ad7", 5, 10 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4b5fb0bd-bbfa-4609-9b8d-267524174770", 6, 12 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "40a5ef72-cfb8-4114-a102-3c8dc848c3f8", 7, 14 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "40d5a15a-923c-444b-b0c1-d2713cc0d53e", 4, 8 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "59eadc83-6c68-499c-a8a1-8919b16fe110", 5, 10 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e05a6bfd-0939-4164-bde9-d4557a875d07", 6, 12 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9d1d2469-93a3-47af-82c3-18c9690fd19c", 7, 14 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "28aaa475-8aa8-4eaf-b9df-84a6ae408463", 4, 8 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f225a4fd-8c05-43a4-8c3d-9e5e456f1927", 5, 10 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c58b2df3-5e93-44a1-aa0c-589de4e076d9", 6, 12 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "352f0995-6acb-4b1e-b7ea-ccc3a85006f3", 7, 14 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "33e682db-b0bd-4801-8f67-333cd93115e0", 4, 8 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "743240a8-fb6c-411e-8cc4-1484caeb683b", 5, 10 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "46396181-0093-4880-9b3d-7aa2dbbbdac4", 6, 12 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ae49273e-89c6-47db-8610-bd4432497b4a", 7, 14 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "68a6501c-dc0a-4c11-b475-faf2f4b46c3a", 4, 8 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a82c2f74-da88-498e-b65b-e7944bcdcfe5", 5, 10 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d6770fa6-8e47-41c6-8ee5-a7c2845af571", 6, 12 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "80987cb2-e42c-4e5b-a0b8-0f7092370242", 7, 14 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "87dfe740-a9ee-44e5-a086-a31e6ab64b04", 4, 8 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0c5c65b9-e95d-4a9c-b678-d8c94e698d26", 5, 10 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "23fc6991-7bf1-465d-b4f0-b8a0eb7e4bb0", 6, 12 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5fe69f9a-1cc8-41b3-ad27-5a3bf3a7649b", 7, 14 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c623d9fc-4e51-4b76-9099-ac5b6dfd3c3e", 4, 8 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fc861574-693b-43a0-bc8e-eb7944719593", 5, 10 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "575067ff-8d81-4317-8c06-ef539b9e6077", 6, 12 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0d00adfe-9edf-4a66-a2a0-f69d2aa6e62b", 7, 14 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "764f693c-a3a7-40e9-ab30-433f28ba31c0", 4, 8 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "39b055b2-8921-4a5e-925a-aa6ad654a823", 5, 10 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8e1b4bb3-6d29-454e-932b-9065cc5b5575", 6, 12 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8ee1aa8f-c543-4029-a658-c8e4c436fc03", 7, 14 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c306b889-9259-459e-bd19-9b03241db1e6", 4, 8 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a8b073b7-69ec-464a-8e25-0ceb6dfdd51b", 5, 10 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "da9ff763-f7b7-43ca-8a75-27b8d805f12e", 6, 12 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c96fe355-f1c2-480f-96dc-67bc0ffc438d", 7, 14 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a2874b41-79bd-4d77-9e77-919bdc5ef310", 4, 8 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f3dfa975-1f6c-4044-b95e-3edc890d5924", 5, 10 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e453bc0f-9e36-46d3-81bc-f207fb5697f9", 6, 12 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6c8631cc-0f60-4f97-b968-b96cc4fc1bdf", 7, 14 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "81b3f0a3-15aa-4ec1-a273-98001e19e8a4", 4, 8 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "933fd626-f4d0-4e0a-a5d1-1418f83fd7d2", 5, 10 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d2b05b8f-1bf8-42b8-9473-e18420d2461e", 6, 12 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9d4cb2ea-865f-4946-ada9-87962886b451", 7, 14 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7a1ac678-53c9-4633-9a98-94ebe052300d", 4, 8 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dcf37121-311b-4cbb-9109-3ee48e57bb5c", 5, 10 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7d1928e1-6d23-40d4-b87e-c324fca6063e", 6, 12 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6af1f5c2-ad56-48b4-b07c-cf8a5dc7f915", 7, 14 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "67b80e8f-f642-438f-a869-22a8f66fc64d", 4, 8 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5e01054d-f448-453d-8fd8-ce825f30d631", 5, 10 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f44804db-0db7-40e4-aebe-55fccaa5d6d2", 6, 12 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c0fa6ed7-bfc7-4778-adee-65a06b1c0061", 7, 14 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "86745e6b-1fb2-4689-8dad-36d1098265d9", 4, 8 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "77c5517b-92ac-4ce2-bf06-8aa46d3506a2", 5, 10 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "07f95251-c8d3-41aa-b75f-a6af9aa8f51c", 6, 12 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "081b5828-7b71-4a54-b899-dc454129fc84", 7, 14 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "54775b27-328a-44f8-9be1-cf56f451bf85", 4, 8 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1d420f44-abd2-428f-ab03-e571acd55641", 5, 10 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c03c2360-6333-4fe9-9af8-d89e053788df", 6, 12 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "16495d4e-3c01-4a5d-b8ba-96b9e432e206", 7, 14 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8269f1a0-349b-4fe4-b538-8a16e1aaf33a", 4, 8 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5ef3d3ad-4f62-4924-8a89-deef0b63d21c", 5, 10 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c02b0ea6-70d9-4165-9690-e34f80736c1c", 6, 12 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7ba69d6e-a3f5-410b-899e-ea8ca839ce7e", 7, 14 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fb1f04cb-72ae-4dc8-b90d-7f3737f6a248", 4, 8 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a714c29e-9e3b-4dd6-b1bb-6914accf2ab1", 5, 10 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "01e42a7c-c184-43fd-9483-6772777b81e3", 6, 12 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a72bf47a-8607-4782-8cb2-8782ec3a67da", 7, 14 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "13981f3e-b371-4597-975e-d9630f277e26", 4, 8 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8dbab3ea-335e-456d-9ad7-a2b7f44388c9", 5, 10 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "03b1ed33-5354-49cd-b7c9-c9054c0eba11", 6, 12 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2d01bf70-22ed-436d-a288-9310f70e062d", 7, 14 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "adcea54a-a17d-4334-bca4-a24ea038f2dc", 4, 8 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dd7a13cd-7d29-494e-8f5d-e343188af24b", 5, 10 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4f9e5987-4fa8-4ab2-a7c5-6363343bf70a", 6, 12 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dbb78f16-9e36-4264-a72e-0df740cb7cd3", 7, 14 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "db08b75e-9baf-4b33-95f8-6f3e20adfce1", 4, 8 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0fd3f047-b101-4cbe-aa31-df5a63a848a3", 5, 10 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "53471ea7-6c42-4212-bdd2-b64ef0ac51ce", 6, 12 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f4487d94-2f0d-42dc-8cf9-bbfdcd2d481d", 7, 14 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f1077521-c41f-4d50-9ca5-bfda4b988c8c", 4, 8 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "93d6f336-9da2-4f0d-875d-ab26b92dbe67", 5, 10 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c7f9d6fe-1d40-4464-b2b7-59386eb2f46a", 6, 12 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1d24eb0b-ef30-45ff-a1d7-9ee4403ffa11", 7, 14 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "15502b6b-77c7-4bc3-9caa-a5154a13c9a7", 4, 8 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dd400aeb-42bf-4703-a748-78373bc7272a", 5, 10 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "40ee66dd-6bd7-4ae8-868c-fcb5d728aac4", 6, 12 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bd98b3b7-a551-45f1-b278-823137006f10", 7, 14 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "07db9ab7-dfef-4237-a276-f9aa4f4c2ee6", 4, 8 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "50c6e8d8-8f63-4b33-be91-c7a6bdb7bf82", 5, 10 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "93053792-1ff8-4ee3-b57a-c97c1c4df757", 6, 12 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5a76ca8f-1bcf-4b7e-a23b-0b909cac38a3", 7, 14 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cf09481d-2d88-49d1-89f5-5c84d2cf3959", 4, 8 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d4e26962-c3ee-4d47-88c0-8491f13d3639", 5, 10 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dc552b4a-3888-4cb8-a205-c1198db3c423", 6, 12 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9dcafb5a-167d-4abb-ab8b-337caf500392", 7, 14 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "269086b7-05dc-4730-beb4-6ffe6c7ee5ba", 4, 8 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4b5f8648-639e-4eee-b7b7-3e3a1d70d4aa", 5, 10 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8de75280-c597-421d-872c-e0e23e8fa1d3", 6, 12 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dbafca28-8bc0-4374-8b02-13ca1afb8e1b", 7, 14 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "50196e48-bab0-4ea4-99d7-da45de00cf33", 4, 8 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "76f41a41-6a3b-47da-909b-0e7029eec970", 5, 10 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aeaf13ff-b39a-4636-9d21-5efc8efb2c9c", 6, 12 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f737c97d-639f-4c57-bc43-2116e8c3cc6f", 7, 14 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a0952dc9-c4b3-4e74-8343-fe1d9dc7df11", 4, 8 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d853ee98-0520-480b-b79f-056fff9c2108", 5, 10 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8c11960a-0ec3-4996-bf99-ed0a4ea822f6", 6, 12 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f24df827-3452-44e9-af79-3c2f59ff509d", 7, 14 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0e80f228-df1f-403f-8be3-86507d3b01f2", 4, 8 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "78c1fb25-b4dd-4ffa-8138-b77623a7c005", 5, 10 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "79bfb7cd-c391-4306-bbe9-c48aaf9c8277", 6, 12 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8e20ef1e-56c8-442d-bbe0-57eb95f3b9b4", 7, 14 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "81d7e24c-d17e-4414-b0b9-213c31150d18", 4, 8 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9b2f5133-7f5e-48f4-b5a8-3f8abf352313", 5, 10 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "01496d8c-dff3-451b-b6cf-3bffd2fbe69d", 6, 12 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c9ac20db-ec7e-4b92-87bb-5ccb4867d460", 7, 14 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5d3db23a-1e29-4614-b3e3-fc93e7a5e073", 4, 8 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "32a85849-d095-4abf-b91f-3c18202d51a9", 5, 10 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "32009680-7add-4a3d-9d62-68d6cc16013c", 6, 12 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ec6cf96c-dbaa-401c-ba2b-45bca3640c5c", 7, 14 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "afb84bee-0e57-4074-91de-bc2cdc027b83", 4, 8 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b14526cd-5301-4c1b-a18c-0cd59e5c132b", 5, 10 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b48419f5-e8c2-4dd8-aa0f-7035be0512d9", 6, 12 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a068631c-a48b-4090-981a-025914ece192", 7, 14 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0eb620c5-825a-44bb-9368-b330e9292a4d", 4, 8 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "54760497-c6be-490b-a84c-85f484a008a3", 5, 10 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a5f862a1-5e99-4d9a-b22d-9580fcd6f9b4", 6, 12 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4e7799b2-4478-4701-b070-e3cb593ad95d", 7, 14 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cac6cee5-a46e-4b12-b666-8ac7b1e16eb6", 4, 8 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "823955c2-2d65-4bf8-8115-3fb0e6ca85cf", 5, 10 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aa48b222-145d-45ec-9a81-923b90c3cf91", 6, 12 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "96b572e9-9f70-43d4-80a3-fcf07c33349e", 7, 14 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "43ffb5c2-4231-4d63-90b4-fe82de21d75d", 4, 8 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ccc82f66-f9ec-4acb-ab41-8120c65a053c", 5, 10 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cb628dcd-343b-4d4b-9e7c-0e3c7ac2fc12", 6, 12 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8d52ff6f-2c5b-4867-b50c-2c8af2c465e3", 7, 14 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "82c7505d-50a2-4da7-9f51-43ccb33d1325", 4, 8 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7d7fe72d-bb54-42e3-af28-05de0eea1f90", 5, 10 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6513bfec-8550-4c00-aa82-8f6a7cbe712b", 6, 12 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "66d74c24-dddb-4d20-a379-46c88509f119", 7, 14 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4d3f73dc-6f26-4315-9d51-1856d4487896", 4, 8 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "40aa1fe0-aea7-4c1f-967d-71cf92bbd6ef", 5, 10 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2b6ac2e5-e7bf-45f3-9ca7-311aa53e3c3e", 6, 12 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9966fdc0-43b3-482e-b55a-65f268dc6d8f", 7, 14 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2e4ef2ce-8153-44a9-98cb-120fac6f89b1", 4, 8 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b52c0a08-f964-427c-a986-d91218fb05b4", 5, 10 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9a37559c-2aaa-4bee-bd2e-63e4ff64832c", 6, 12 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5aabafa8-4161-4089-83f0-24b7ed708a3a", 7, 14 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4bc1266b-6839-4359-bc17-d029a6c1cc22", 4, 8 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "09ec2d77-4830-4d86-8e0c-172d29f244c9", 5, 10 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fa841998-5266-4716-992b-cb9078f55bc9", 6, 12 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "76bc189b-b102-4d35-a0c9-f150209bd2b4", 7, 14 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e43ed78f-049b-402d-9e77-e6c144ea824d", 4, 8 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2d5ae6ca-bb01-4be7-9414-f1ba691bf196", 5, 10 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "034bb131-c710-4922-a678-53eeae9a03bf", 6, 12 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "257bb018-f803-4e4f-8931-4081da00667d", 7, 14 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b1cde803-2220-4dc4-8a24-650da8e79c63", 4, 8 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fba8d1ea-f43b-434b-a063-32273c959120", 5, 10 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3572a27f-aad7-4245-819d-cf14db58755e", 6, 12 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8a1a90ef-92c0-46f6-ae26-3c214f41fe62", 7, 14 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d26d2035-c2d2-41f5-817c-091a6884ff69", 4, 8 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b4aa38fb-40f2-4dff-9b2f-de303610622c", 5, 10 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aec6dc5f-40ee-407f-be87-bedfa93b7a5a", 6, 12 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e0b7d647-b08d-4e3a-9939-69d8d8a9a3f0", 7, 14 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a6865859-ff9d-4b52-8150-da02f3d84e0e", 4, 8 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f5755e35-e093-4641-8452-d1130fb6a512", 5, 10 },
                    { "56072689-4550-44be-987e-b08667758de4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4bb3189c-7202-4e24-8b1b-8c301cc86a95", 6, 12 },
                    { "56072689-4550-44be-987e-b08667758de4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "71487cf5-c29b-4978-b9a0-c3d991031bdb", 7, 14 },
                    { "56072689-4550-44be-987e-b08667758de4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e4cfedd0-c0ca-487a-9cdd-dd8817223ed6", 4, 8 },
                    { "56072689-4550-44be-987e-b08667758de4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "db43c244-49a6-4c9f-afc3-3af202b11470", 5, 10 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cdedea16-31d6-4207-b068-4bc2c514a7b8", 6, 12 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "676aa656-f0c1-49bd-9c18-2acd9331d2cd", 7, 14 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "db5d677b-a607-48b8-9945-2242dc44ae3a", 4, 8 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b7686229-28b2-4fac-9b9d-c02da3480c1b", 5, 10 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "94b7b53a-3127-4bf8-b764-6fbd833a4bce", 6, 12 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f995fd21-50fd-4696-85b5-447a07590ef5", 7, 14 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "477f4aa1-0c50-4a42-91f8-599ee988e04d", 4, 8 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e1587c3b-d1a5-449b-8f52-6cf201c8b1a2", 5, 10 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9bd59cfc-2499-4578-b190-be9caec6d6b8", 6, 12 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f04ce3bd-57c6-4877-9956-1f7526532353", 7, 14 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "76550570-066b-4355-82fc-72f81d21c47b", 4, 8 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ca143ed0-ab74-4274-9155-ba9ae2dd6d14", 5, 10 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2bdbf4bd-f028-44c5-80ee-9ccffcee223f", 6, 12 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5d27a2ec-3001-4924-8772-ec2702e8f00a", 7, 14 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "84fab273-b2a5-4153-a4f2-3d2f2a55e0e1", 4, 8 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3562018a-49d7-4ed2-97e5-1bd9fc3d9c68", 5, 10 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c4681893-5e30-4264-bfb4-32ea112325b1", 6, 12 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6eff85aa-b4f5-4626-b7b1-c96064a07553", 7, 14 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bbbc05fa-aa02-4c73-a301-5380d69dfd33", 4, 8 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "42a3c35f-f150-42a7-a35a-12ba6552dbec", 5, 10 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5ae10082-0a20-4823-a74e-f61812e49e8c", 6, 12 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "eb15794d-f88c-44bb-9a8f-6859b1728ab5", 7, 14 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ca68a6fb-bee7-4679-8efa-9bc6d013686c", 4, 8 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "40fea04b-2f81-42c8-8fb5-86f622a4c313", 5, 10 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2842595e-e4bc-4c7c-98b8-c8279cf2cfb5", 6, 12 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1cf09a68-7993-4d16-8880-3ade87d043de", 7, 14 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0af384aa-7ed7-472b-94ac-880dfdc5ca8f", 4, 8 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b96b0ad5-46f9-4ac8-a141-b899c246c108", 5, 10 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c68315c7-cdb5-477d-bc94-8bde573ecaf7", 6, 12 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ac34e140-aa85-4c1f-ae2e-582647fe5c4b", 7, 14 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "37bfb4ff-3a44-472b-b7e2-b80e4804dc85", 4, 8 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8ac8fd6e-56ff-4756-8660-b845bf51e60f", 5, 10 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c862f8ed-d5ca-425b-81a0-23ad4e6eefde", 6, 12 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "aa64be74-4fff-471e-ba15-526695a6f42d", 7, 14 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3a3df93a-a495-4a30-8df7-25946ec07e5e", 4, 8 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "422944fc-7a4f-4597-8b4b-d49e2e5ed4d7", 5, 10 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "da07e644-f1ba-4ba3-96f9-f8179cb1175f", 6, 12 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a4d66e37-7d06-465f-b43d-003c834a2120", 7, 14 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "974d033d-8354-42c2-8800-a0eb8a3fba95", 4, 8 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "71d5662f-0708-4c47-9097-45bf87e09571", 5, 10 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "562ca394-91dc-4229-89e2-f09b05950fc4", 6, 12 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1520f74f-af55-4d9d-8c88-c6b566279563", 7, 14 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2cf392cf-bbfc-4006-b156-30f673618f4a", 4, 8 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "40ddb342-bbd5-4c0f-9159-72150ef89348", 5, 10 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4bb144b0-644f-49c5-a5a6-c4266a5d9453", 6, 12 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f59cb0af-f9d2-42fd-90a1-d4eb7d241431", 7, 14 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "14dbd293-e247-4b27-ad2e-3e03fbd75480", 4, 8 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "530b6fd0-403b-476d-a80b-e73943c943b4", 5, 10 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9fc9c981-e44b-4d57-b39b-b8455c44a2c4", 6, 12 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b0a7d589-a1e4-432d-83e8-f84e034f6e3c", 7, 14 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9aa3d4dc-6d4f-4749-a100-5681f66ef1d3", 4, 8 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "86850f27-6a3b-4b3c-9580-4ea694526c2f", 5, 10 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9e497adf-94ff-471b-b8ed-cc3dc6c26792", 6, 12 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8864155a-b40f-48ef-a41a-98a220703cf9", 7, 14 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d0933e9f-ae3e-413e-b112-346eb293976c", 4, 8 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c09cafd3-d8a0-40e0-8f38-18f2e1dbdb1c", 5, 10 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "245ca561-ee5e-478e-a853-0c0becf3e587", 6, 12 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dfc0886c-fe78-4c81-8c09-3f0ec594df55", 7, 14 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ef99da7a-18ce-4672-a2d2-bc06be27e467", 4, 8 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "30bd2d7f-3dd1-4d10-9fc1-0fa26a97ddc2", 5, 10 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "94cf6f39-4749-4313-ba86-e1a73ff8fb04", 6, 12 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "86b57763-3a96-45f0-8f09-784b0e6fa86b", 7, 14 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "11522c9a-efda-4c93-a943-38bad2c4dc07", 4, 8 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ec0ac42d-9aa3-44de-ab52-9fdc8f9739cb", 5, 10 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e7696239-eb4c-487a-9ba5-91ab512a1d44", 6, 12 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "edf364a3-b98f-4b64-b074-10f0e49eb200", 7, 14 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f87e64c3-b8f4-4c87-b471-9fc1a53aeabd", 4, 8 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0466c81c-0b9a-4f76-b8ae-1148f3f25b7e", 5, 10 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e3a7a42c-4e82-42f5-acb8-880f5564dfcd", 6, 12 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "56c056c0-370a-4812-a16d-8b3fb518565d", 7, 14 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a5435dee-e137-4a24-a4ff-880bf02606de", 4, 8 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "51c9ac51-64ee-4da6-9b0f-2d43dfb681e7", 5, 10 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0518ccd6-99bd-4f4e-9e08-2942366b72e6", 6, 12 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0387ce40-2e2f-4b45-8974-c9479e159053", 7, 14 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7c6ad3b0-1241-4be7-9473-9637613db87d", 4, 8 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "103d0e28-bcc6-4bc0-a70f-9f1c3007e2de", 5, 10 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8e2774ef-eb3a-45f5-ad64-3bf6a23b5606", 6, 12 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6c34cdc4-0355-4a05-9507-793d1026ef02", 7, 14 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "148ded7c-6d7d-46ef-b0a4-456208458d62", 4, 8 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b35053c4-531e-440a-81ac-94aa1b02391f", 5, 10 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1ab5be39-4a67-448b-917a-0ef7d53106f1", 6, 12 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0f42f0b4-0dd8-4a14-b9dc-cba2005e26c6", 7, 14 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7c346a3a-826e-426c-ba49-56e4987b19d9", 4, 8 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d8eff789-f04a-47dd-9be3-f1a072aa5d78", 5, 10 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a090598b-92af-43dc-9c42-086f7faca8df", 6, 12 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "76ab3c78-e542-47fc-bf16-1d9ca12767d3", 7, 14 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3b3661b5-f207-492a-9120-a7e13727b1a2", 4, 8 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f27c859e-9927-4b2d-a101-15eed99a7ead", 5, 10 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cc9c39e3-b7f9-46c2-8e3e-2566b54c0864", 6, 12 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e73aef26-0915-4f0f-bb6a-bfc049047619", 7, 14 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "40a9ec39-023c-474b-b18f-4a25fbc3e363", 4, 8 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "14f23e8f-d0f1-4479-8288-e36e7826d508", 5, 10 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8c490439-ebb4-4eba-9838-8ffa211a46ce", 6, 12 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ee65bb97-e12f-497a-a968-1596c8e528e4", 7, 14 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5b2aaf6e-c23e-4045-a6d6-ba0a634e646a", 4, 8 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cfa6da62-4ae9-4b57-8e0b-52e5b3f6ba90", 5, 10 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "69722a50-1d73-4e26-beff-bba72a39b531", 6, 12 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "83685a9e-78f5-4aa6-ace5-36c5c8497c79", 7, 14 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "17892c0f-f57a-4890-889e-f3c6ebf2ba9d", 4, 8 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "69045b93-aef8-4841-94bd-7ffc4c6fb15d", 5, 10 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "284dc94f-a9fd-4370-a63a-5e56fcd67384", 6, 12 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0392b822-2ac6-43d5-b460-d6de6a65468a", 7, 14 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2d92602f-5639-4ddc-aa98-32556453b6b0", 4, 8 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5243df6a-2b11-4337-91ff-69e624c0492f", 5, 10 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "21c42a1b-9452-469e-8b03-f790812777f1", 6, 12 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "08231e9e-e1e7-457e-85b2-33bd3d337453", 7, 14 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "81a25133-ad4c-4b04-bb9b-aacb1f7df7b2", 4, 8 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e4555800-2dae-4bfe-9363-22d88c912184", 5, 10 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f8de223d-f1bb-45cb-aeec-926e1068df3e", 6, 12 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d0c44af1-a547-4baa-9a75-e3caf8214db9", 7, 14 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cbf97e2c-97fb-478e-8fe6-c2a6f03e78d0", 4, 8 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e0510380-9bf1-4a94-b11a-5e90b9e3cee2", 5, 10 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "894ea9e2-f16b-49c9-9256-80d7674691c5", 6, 12 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b9d48d5b-1a65-4e80-b1b5-a38994b8ec0b", 7, 14 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4a66b1fe-a8ce-4626-8181-ba9e2e22a4d4", 4, 8 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "77cac143-0e9d-4c42-8f97-87aff5ff03e8", 5, 10 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8d1c55f4-4ed2-496a-a843-83b21a679959", 6, 12 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c89141c2-695e-44f3-9772-c59d2326561b", 7, 14 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "45457779-c406-4e55-9dd2-d1fec179df6a", 4, 8 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fb0d4be0-7933-4d5d-a4ef-a02ac7884653", 5, 10 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "68a4b5b2-b9df-4077-8484-dfc49ad85c06", 6, 12 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "82115b58-a82e-4488-961f-a2211d82f9a5", 7, 14 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2b5db104-f2da-4d32-a094-a7100f3e0928", 4, 8 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "42c50b3c-c119-4025-912a-db883b3f2fd8", 5, 10 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f3946256-b9ca-4a90-b07d-6fce2904cc81", 6, 12 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1f3801c2-827d-4bec-b479-c8af91b75522", 7, 14 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "54dca12f-697c-4a84-af24-2eb3de33602e", 4, 8 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "671d7112-7cb8-4acb-84fb-0d679403b457", 5, 10 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "48385de8-5041-4e9d-ac84-ded9ba788e37", 6, 12 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "aa5bffa4-119c-4c35-8445-ab2785d79d09", 7, 14 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "90fbe647-ade4-4753-8402-4f6c043f68f9", 4, 8 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f5844718-0274-408f-b64c-85f42afbfc17", 5, 10 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ce94e7f4-b02f-4527-8608-68abb0cf1c13", 6, 12 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "51267180-acaa-4ac5-ab0d-44910221aea3", 7, 14 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "44f9a90d-1b43-4181-863a-ae2a1c7dbdea", 4, 8 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ae409b9c-1aee-498c-9173-a5ccb25bb3a8", 5, 10 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "590742d6-48bf-454f-9c46-10abe36b81df", 6, 12 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d260178c-3887-4b87-97a7-6eb3c2d37c44", 7, 14 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "718faa3c-87a7-4b61-ad5d-fab93dfbd3ad", 4, 8 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3be2e627-35fb-48a1-8b83-e5dba3a28cfb", 5, 10 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c70e8217-8f3e-4243-b0bc-b27306585d01", 6, 12 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d83e8978-0c2c-4159-b99f-2ef1028e7921", 7, 14 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9eedcc8a-9d89-462b-be17-975f1cebebe9", 4, 8 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "93d4c1fb-4fff-4e6b-8915-2ee0025e032b", 5, 10 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7cce6564-0623-4e89-bc25-fecf6ae1f440", 6, 12 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a675fde7-74d7-4a95-ac59-90ac54c16592", 7, 14 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b6dfdae9-0e77-4652-bf3a-15f2619fd870", 4, 8 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8e639571-6c2b-44a8-a0b5-59d525b17001", 5, 10 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6dae9f27-3c6f-4c84-b51a-6281e1f02d97", 6, 12 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4450d612-3ab5-4094-96cc-eb885a4ecb57", 7, 14 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "16f4b0d8-6a2a-4f81-807a-05316cb5c6fd", 4, 8 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ca906905-83e8-46f2-9623-be9cee3a5d23", 5, 10 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0dc4a915-36c6-43e8-9c67-1317e28812d2", 6, 12 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "db2f3de9-66e8-4e68-bb6e-b4ed9c004e27", 7, 14 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7935807a-3447-4833-b9ae-1bfa4f204d0f", 4, 8 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f8c5e720-33e9-4247-a3f0-5b3536738f18", 5, 10 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d34a9117-794d-4e28-8408-a2f871614f1f", 6, 12 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dedf2ed7-40fd-41bd-8c52-c4c2976bbe8e", 7, 14 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ca3f6bd0-9a76-4e91-80db-f4e30f1f8224", 4, 8 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "69306456-a6df-4f60-84fb-fb6d44d14de5", 5, 10 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "900733fb-5e1d-4723-a885-c5c203b9abbc", 6, 12 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7a1d1e6b-4cc0-4e08-8888-721013c27d8e", 7, 14 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2b06d425-a62b-4128-8321-358421bf2c23", 4, 8 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8a2aaafa-911a-4a71-8847-024afa888b11", 5, 10 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cd9c6df3-dd12-42f7-96ae-fadd6298bd04", 6, 12 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f8e7d4fa-9f72-4937-8503-a154ebb00c87", 7, 14 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "37d7bfab-a587-472a-8993-832aaa4e2a0a", 4, 8 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "830999a3-0fab-4619-8e85-b2c62857bd1e", 5, 10 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "43b4c46c-8822-42a0-b411-32e0def1d4d2", 6, 12 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "35246882-3235-4305-825f-eb2d2bb00287", 7, 14 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ee5161e1-6b40-4005-9982-5c8701b53eb9", 4, 8 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c7490977-c633-4b3e-9580-6cb67e666771", 5, 10 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "76c75bd0-ba14-4d3d-b4e3-ee513b5bc245", 6, 12 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cd8ca4cc-9a7b-4321-9544-784aea051a04", 7, 14 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3242ca54-a055-4405-bea6-426314a1bec0", 4, 8 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9a5f0d83-94a8-4770-94ae-d8151264b26b", 5, 10 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "08854453-6b9f-4602-9263-352dfc59dd71", 6, 12 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2692ece5-766a-4143-a993-708ae22b8fd7", 7, 14 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f3a98ffc-b9e9-417d-b9db-184b0934b604", 4, 8 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bb54f94a-07ee-4952-bc53-02cf4e429d85", 5, 10 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2cead6e6-73db-43d7-b6e7-45e997fd92cc", 6, 12 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "83b3474a-f7aa-4620-adb3-d6df2dd97e1f", 7, 14 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8b93f9b4-1b05-4bf3-a74f-110ee8dd25ea", 4, 8 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "485d39d7-7e7a-4e34-b76c-50e3ebb2eaf7", 5, 10 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ff556599-093b-433b-8bae-f64e744ae2d6", 6, 12 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e6963eaa-2946-457e-87ea-45cf90efb9f9", 7, 14 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4e40a687-0948-49fc-bc97-79841834cabb", 4, 8 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4b38b401-5230-4f77-b980-a4de86997dea", 5, 10 },
                    { "78157107-23fa-4638-bd17-38187695312c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5de3b2c7-3b3a-4c30-b66b-340fc491eb10", 6, 12 },
                    { "78157107-23fa-4638-bd17-38187695312c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b3cb91d8-7c12-49da-bd28-3312a5a59166", 7, 14 },
                    { "78157107-23fa-4638-bd17-38187695312c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f1678719-0d59-4f8f-824a-8002af5547af", 4, 8 },
                    { "78157107-23fa-4638-bd17-38187695312c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f9e69f44-dfdb-47e8-b8e3-ec78282f4a27", 5, 10 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "92ae12c0-1b86-429d-8715-973df7804746", 6, 12 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "97fa3238-e07b-4d43-9ac3-70237a78badd", 7, 14 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "43afd76b-e714-41dc-b463-61436e010bc5", 4, 8 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c387c838-ca55-4c28-a276-7ce8ed34fce3", 5, 10 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "05d4d355-6126-4a04-ba7e-512943f4fd10", 6, 12 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1f76255a-001b-4b17-a112-b4419d99dc59", 7, 14 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1cc06ac0-9d49-43ea-a1d1-7ff203232de2", 4, 8 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bb56ea1b-368f-4426-8b2e-b9ffe8fc414c", 5, 10 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "68ad137b-e4da-40a5-bad9-ef3a5b9a95da", 6, 12 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "47822032-47ab-44ba-b48b-62444e044836", 7, 14 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "80e5f493-45a2-4bed-8743-6f61ac7c7284", 4, 8 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "99a08893-4dc1-4283-adad-307e34b48801", 5, 10 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cf5cf598-7c39-490d-acb7-89143a777058", 6, 12 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "76668637-6b41-4798-9ffb-a95c097fe572", 7, 14 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "40f75eb4-d342-45de-8fdb-d7d99d5215c7", 4, 8 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0e47dd76-2ed1-4f29-a6a2-6b9d20f2d2c3", 5, 10 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c5a3b828-dfbf-44d4-a2af-12f0192f4363", 6, 12 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9914b4e7-60da-4e71-ae6c-35199000f6a6", 7, 14 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "38c310ec-2e0f-492c-b290-445aa8b4c7e9", 4, 8 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e710c257-efe5-4c5e-b7bf-41c79d442fe6", 5, 10 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "272cf421-3736-4af0-8d27-c81fcda35969", 6, 12 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "04b34c1f-046f-4583-b826-aa142f97ebfc", 7, 14 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8c501bc7-4390-4f02-94f8-21364709247e", 4, 8 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "247dc654-e21d-4e59-b810-c6da71fc022e", 5, 10 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1adb0229-39f0-4bad-b204-de729f78d397", 6, 12 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6362d6e3-d9bc-42a4-a599-cc6da67dbaaf", 7, 14 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0ff78c6c-8e64-4e4e-ae8a-22ffdcec1d74", 4, 8 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "163c4215-77f3-4ff0-a9ad-69ebf936ed98", 5, 10 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3b11473b-da80-44a7-b500-12d0da2d91ac", 6, 12 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "44a16407-131b-4c6d-b5df-3d9a11cd66f4", 7, 14 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6e8876a4-4ca1-4de4-aa2c-06a7859bc9ab", 4, 8 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "180e4673-a4b3-4a71-a505-b19eed2810a2", 5, 10 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "55488116-0818-40bd-b7b3-2ca45e827521", 6, 12 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4406c18c-963a-4e67-9fc0-d0896dfa533d", 7, 14 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ec6051b2-240a-4be3-9573-c6733a46f787", 4, 8 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bbab568a-f52f-4bc3-b984-d54afc066a5d", 5, 10 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "894406a4-b6b5-41e3-b2c5-9607a3cf6a67", 6, 12 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d1d1a963-5fb5-4408-bda3-3281b80f24b9", 7, 14 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1b610cdc-4ef1-43ff-8138-ef6fed095937", 4, 8 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d2a190d2-51b3-4908-b06a-c84ca980f2a0", 5, 10 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "af1a5acd-1973-4bc9-84d9-90586f211b23", 6, 12 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ee991d9f-2993-4c47-a424-397bad5b17d3", 7, 14 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "30c06d31-f705-4627-9046-c1d61c1ca98c", 4, 8 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "501c4b92-c5b0-49ff-a90f-03b06e99283e", 5, 10 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "17bc3a81-c744-456d-9921-8a549410f6e8", 6, 12 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d3495262-802d-4bb4-a496-3d7ea27fdc2a", 7, 14 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1f41cb4e-cc1f-456b-b802-cc175c342aab", 4, 8 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "60409d7a-f200-41a1-b355-aeae568d0217", 5, 10 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2caaab10-2fe3-485a-ab3b-8156c7c18f02", 6, 12 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "14ea3766-6e2d-43b7-9a65-1da437c3473c", 7, 14 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6962f69f-cd31-48a9-8888-ced2215ed286", 4, 8 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "932907ea-bc20-4ae3-afe0-ad6040177809", 5, 10 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "df906747-1952-4b86-91be-1dbb7a586e4f", 6, 12 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bebeba80-d8f7-40f4-80ef-6c0344058eb2", 7, 14 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "29f14197-d2e1-475f-a7ac-0d6f3d4e7fe4", 4, 8 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5df64807-c3fb-4c02-8435-f6beb4c5a06f", 5, 10 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6e7cd70f-92b0-4540-89d3-505e902a36f6", 6, 12 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "139d9a02-c99e-4b21-ae50-f0d922013de0", 7, 14 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ecdb791f-d902-4527-be9a-30b2ced0fcfe", 4, 8 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0cefbaa6-b5e1-4de8-9577-8f122afb7889", 5, 10 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a1a44b36-0225-4f51-934a-e91ce1a1ee99", 6, 12 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "da46db8d-816c-451a-b07b-b763b0c36578", 7, 14 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fecf7765-92d1-40ea-a741-35fed3b105c2", 4, 8 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d6544f23-7c25-48e3-a078-b91cfaeb5e15", 5, 10 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "61131f15-4ec6-4ffa-85c0-00fc31c352e2", 6, 12 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dd3579bd-7caa-4433-9b39-addf03e63b60", 7, 14 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "06a7d8a6-2fd4-4f7d-96f3-e97af614f135", 4, 8 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "afedd0fb-1c1a-487a-941c-8e7c110d3268", 5, 10 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1eca2f1f-e741-4d3d-9804-873f769ecdce", 6, 12 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e666c217-3427-48d8-a085-5c27fbb301af", 7, 14 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6fd1dce1-b9f1-4d04-9d84-9e133f0d76c6", 4, 8 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f43fe8a5-e1cd-4d26-9c83-dcaf8685a11a", 5, 10 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9c4208de-cdef-4a47-921d-4d5471ec15f2", 6, 12 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f1138bcb-aed2-40c0-978d-70b50d0c8a99", 7, 14 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b33ceebe-4b9a-4086-bad9-1648ccc47ba7", 4, 8 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "967b09f8-09d8-44eb-acd6-76b51bacdc6c", 5, 10 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d54a7994-9650-43ca-a8c4-af250812926b", 6, 12 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b17f456d-4e9c-4265-9800-7a46a8bf2993", 7, 14 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c96c5fcc-f66e-49a4-b479-31a120ae2386", 4, 8 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d738e42b-7b52-4e92-a786-80dbfd0d9103", 5, 10 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c14dda81-447a-4daf-b102-439808028857", 6, 12 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0efbf407-b4a2-4d55-bd42-6da9806f2d36", 7, 14 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a58a4a46-ba79-490e-b27b-74395ca095a1", 4, 8 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "602cb9a1-a16e-4e6d-93d6-8ce998c70a14", 5, 10 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cd449771-0742-4be6-bb0d-ad2300a9ad60", 6, 12 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2aa94e82-47a3-40b6-9c81-dd47b92bea08", 7, 14 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5d26a3c9-b85f-497c-9383-62df1f45d746", 4, 8 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a81d3220-7d66-4a70-b281-460bff34bbec", 5, 10 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "36f2ee24-ac6e-4706-8963-392b20e85ee9", 6, 12 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f0d976e2-9532-46ca-b49f-e99b5b767a20", 7, 14 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e8f0e699-b86a-4ed7-a88d-448237938526", 4, 8 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d8f1fbcd-3c61-4f42-a476-2eae0a4512f3", 5, 10 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5aa9c355-75c5-4bd4-ad65-9a2c28a50304", 6, 12 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5752e271-63b4-4b4b-a0cc-5e50992673c5", 7, 14 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5f23c794-6e81-470c-80f4-404adf4a7899", 4, 8 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bdc358b6-d577-4b3e-9a78-bb45746fcc77", 5, 10 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c5dde52a-2316-4c3b-a290-52bd1f294010", 6, 12 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ebc104f4-238c-4382-a730-524c58d27b37", 7, 14 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "52e8e22d-1151-48e0-974d-c78122d55ef4", 4, 8 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "400eb9a6-a1c0-4550-957e-d82db960f9be", 5, 10 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "56e57632-b260-4c00-87d1-214fe7ce01e7", 6, 12 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c373cd86-62bb-46e3-ab46-daf393b54be9", 7, 14 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e25b30ce-bcac-46e1-ae85-c01a41f5f682", 4, 8 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3e3c9323-f58e-4013-8b8b-e4b655248c1d", 5, 10 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e16aed5e-855e-4856-aa28-88bb1f82aa13", 6, 12 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "64159c9f-c8eb-4fc5-a785-7b0406160a6b", 7, 14 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a08dfa88-17e3-4c67-b8b8-2999ab880b66", 4, 8 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f6a3983b-ed07-4ed5-a1c9-1387b4cbd5cb", 5, 10 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "399c95c2-49bf-4615-ad10-2a2de59979d3", 6, 12 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "60f5a020-964e-4e47-b1bc-bb0e97694f23", 7, 14 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "95ea9de5-1678-463b-8971-65c98e80cd4e", 4, 8 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "657bb233-ae3a-4a96-a4ee-331d80b9924c", 5, 10 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d6f3d745-0a4a-4735-b039-27d73293b558", 6, 12 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "18e79bb0-9716-4bf6-a2fc-22ded6ae720f", 7, 14 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "82c217b7-0cb5-46bf-b974-6167d53ef15a", 4, 8 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aa20d4d5-ac3e-4efa-a617-70bf450f4c44", 5, 10 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4bd267d9-3ec3-4648-8151-59a5b0bdf8c4", 6, 12 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7a7a027b-7598-49bd-b65c-1ef88d8eb814", 7, 14 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "466c0175-22ba-4150-a741-a69b500c5f0f", 4, 8 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6bdb8373-7297-490a-8a56-307c819624f8", 5, 10 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "69eaee50-24e3-4e58-a8d0-8c8f92131168", 6, 12 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "eda2c791-8481-47bd-bcfd-670afdcb3f58", 7, 14 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7381a4ab-e26d-4565-92a5-a489950e9128", 4, 8 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8b8352fe-f94f-40dd-9abe-510d81cfcd50", 5, 10 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b38ac8f3-7191-41ab-acf2-b44ecff3ab60", 6, 12 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3f0685fb-27c7-46cf-83e1-71cb498b35c2", 7, 14 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3051d820-35d4-4c87-9556-3b128998624f", 4, 8 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4ffd959e-fa63-496b-9ee5-ecfd69bcc997", 5, 10 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e834b656-3dbb-42f8-bed0-648eab969881", 6, 12 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "baf32278-0d5e-4b82-9529-2b216f969a46", 7, 14 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "256c9845-4f1f-4c3e-907f-2dbc5d8f9cfb", 4, 8 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "021bc56f-11d8-4017-a339-338ba8d3ed6b", 5, 10 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8a9b88bc-be61-4e10-86f2-6bcde6ac9e25", 6, 12 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a1bf9fbe-2ef8-4cf5-92c0-00f2afd83899", 7, 14 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "67009e27-ea31-486b-af9a-129f719c7ee2", 4, 8 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e062a91f-7c27-4952-9fd5-b49bc3cd6bd6", 5, 10 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3600f642-0d99-4c8d-80cb-b4b05f556a7d", 6, 12 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "891b5de2-31da-4da1-876a-6dd30885fd33", 7, 14 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dcebad71-8f62-4520-b2ae-3fce9f912980", 4, 8 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "43be2478-b235-4371-ac53-81ffed3740e0", 5, 10 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f208c40a-69e0-4d26-a9cf-c9899bead4a3", 6, 12 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ba6b9aa0-ab27-4e8e-8dce-719f59c4e0ae", 7, 14 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "29f8024a-60da-445e-8657-0ae50ef79861", 4, 8 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "13280645-3dbc-433f-b961-bdbd46c9748f", 5, 10 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "db211879-a07d-4b2f-919a-bc63aa9bf04d", 6, 12 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "17ba3c50-6ba6-48f5-84e0-783ab774dfa8", 7, 14 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "541b4705-3cd1-4ea0-9fce-165e9f2270bb", 4, 8 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "faf9e284-3fde-4b40-a621-3a2d5ee62376", 5, 10 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e6fb5e66-b43c-4bfe-bf95-e895b0be5512", 6, 12 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "84ac369f-510a-4406-92ae-9e7b09d91bd7", 7, 14 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "992d8015-c444-4831-9369-c63ead1ad12b", 4, 8 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "763a09cf-61c3-400a-bb3f-6d385dd5e901", 5, 10 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9b936dab-667a-4c40-805a-c8a61808afa7", 6, 12 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "baf48177-a80b-4e8c-a757-b310591ffbeb", 7, 14 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "eac8f57e-11a9-4c16-9e15-f5d42776e0fc", 4, 8 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8cc74581-c1e9-4816-96bb-00d20b78972c", 5, 10 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "88204fd6-7295-4fb7-8f8c-777a4647685d", 6, 12 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7335a82e-1d84-4a1b-bdd9-3f4f25ce65b4", 7, 14 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "17e76eae-206f-4797-abb1-f9e1e88767f3", 4, 8 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c2c94572-e8d7-4a82-8289-b5663b7c5795", 5, 10 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "126f4f43-3ed7-4af0-987a-43e6cb620d50", 6, 12 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6bd3d7fd-52a0-4536-8d21-2e80dabbb045", 7, 14 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "79ce3670-e43c-46fd-9722-bef2023c35ac", 4, 8 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9af9ce0e-596a-413e-bcb3-6b3b1208dd54", 5, 10 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8b72fb50-d4ac-459c-9608-8e639e41b668", 6, 12 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "545c4696-596c-48c5-b3ee-f22e1d396759", 7, 14 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f50080bf-0c13-450c-a34c-e89eba008506", 4, 8 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "852958af-d741-4bc4-9614-26379bdbf01c", 5, 10 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e20dd1a9-8504-485a-9fb5-f6dcff66f7ac", 6, 12 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0ef5f9dd-ec2c-426d-a603-455b8ce7462a", 7, 14 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "72e95be2-0666-4506-bb61-55deed1c5d09", 4, 8 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d496dc02-410d-4398-972d-5b4945fff692", 5, 10 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a7c3d345-1486-4374-9ad0-4389d707eec2", 6, 12 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8e894044-44e9-42fd-9aaa-2b44beccc8c6", 7, 14 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bce8dcbf-4b17-42bc-a8ac-35e0857fa326", 4, 8 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8b78e9c7-bf46-4b25-9761-b2ed309f329e", 5, 10 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aac2a146-dee2-4833-8440-a53f008364b2", 6, 12 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6de44d9f-25ab-430d-be7e-6772f9cafb05", 7, 14 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1852cd62-2885-4e3f-bf98-0282d2c5be4e", 4, 8 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "71145272-1a95-4314-9c79-a947ecb6a868", 5, 10 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ed8011b1-9266-48e9-a061-2d9b3a516d67", 6, 12 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6d3d76ac-cd8b-4453-be0d-ee6920cd1309", 7, 14 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "aa3d2e91-a6c0-4bc2-9446-4f21f7a31773", 4, 8 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "46bfd3f4-5474-4a01-81fb-6a4a41aef859", 5, 10 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3dfdd631-6b40-42b1-9c5c-7dfd4f23881c", 6, 12 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c0817c04-c345-48ba-9c86-dfadd08994a9", 7, 14 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9731843d-e83a-49d9-be02-eedc1b1a22c4", 4, 8 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4087a3a6-2d91-495b-8de2-6b31a17942f4", 5, 10 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dd3842be-80b2-44fe-839b-9967bb5aaf0e", 6, 12 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "789d9030-59d3-46d1-88b8-cfc34cabbdec", 7, 14 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "af0ac95c-2314-4f9b-88c4-303c80ed75e9", 4, 8 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f0c57953-0a13-4b5f-9d24-04ffb08ad9d6", 5, 10 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "447dc77d-75e0-4f7e-ad75-84a71e91aec4", 6, 12 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9d877a55-ca52-4b30-9651-508fab2e8abc", 7, 14 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "78cdf51c-3eb6-4dd2-a186-f4208672412f", 4, 8 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5f14da92-ec72-40a5-9ab6-928895ea54e4", 5, 10 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "70d756fe-6d22-41c1-a870-9a7a272c3bc4", 6, 12 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "357df688-9d03-41a2-a674-17155d929a6b", 7, 14 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "77ea21f9-a7d4-4c3d-ad26-61e445faf6aa", 4, 8 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5324033c-73f2-427c-98bc-2a4bc9901ed7", 5, 10 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "533148f5-f42a-4b6b-b09b-01538408ac78", 6, 12 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b6c87e07-2a3a-4de7-93d3-25688177e94f", 7, 14 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1dfcbef5-5cc0-471f-8384-2effbc3a861a", 4, 8 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7c9dfca8-2657-4bb4-96b6-57b5373e7c55", 5, 10 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cb629d14-3cca-400f-8257-50f7f0fb4223", 6, 12 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f9998c2f-2442-43b2-8620-9883d18a18e8", 7, 14 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3b0ced4c-6f36-49bf-bde3-a7200269b644", 4, 8 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aaffeb7c-d958-47fa-82ca-ed665f83fa76", 5, 10 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "74b36d69-fafc-4327-abf7-67e57e2697ab", 6, 12 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6debdcfa-2250-4d5c-a3d2-d4394e52c118", 7, 14 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "293f0d68-3395-44a5-a30b-dfe8537164bc", 4, 8 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "75eaf92b-81bc-47fa-858a-09edd5a49190", 5, 10 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "53f7cf29-cede-452a-8c59-d955f2456ecd", 6, 12 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b3fa4e2a-bbfe-48e9-9040-e36741fbe3f4", 7, 14 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "333bf495-8a47-4400-b384-c1d1206d69cb", 4, 8 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b73c73b6-359d-4b80-8e3a-96273139c9e6", 5, 10 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "109e84f7-587e-49e9-af06-a0aade8e1318", 6, 12 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0776fe2b-92d5-44d4-a94e-8cad363ba800", 7, 14 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "68eb4ca3-60ed-4c6a-92cf-64a3858a68a3", 4, 8 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "179aaba1-623e-4f55-947d-2ea81965dccd", 5, 10 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2098e4c2-d0d5-47a9-b450-fecca6ca7741", 6, 12 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "70ea5448-0ad2-473f-9337-8990466e25b9", 7, 14 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "39a70ea3-1140-4596-94b8-2b3e915ca768", 4, 8 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9b997524-4979-4732-b11c-4056069f40ee", 5, 10 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e23c1761-fb33-4f9b-85cb-3cde3f5376b6", 6, 12 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d0a1a09d-32b4-4ec1-9a57-fca9645c2678", 7, 14 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c1727eb3-74a8-46a2-9393-c4399aa8b9d3", 4, 8 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "16329b43-4f43-4629-b7e6-d36b03bbbe6f", 5, 10 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9de3383b-0eaa-4c44-b55c-feeab353a98a", 6, 12 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0af64e8e-d474-4e65-9e25-b220f4861771", 7, 14 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "44e14ae2-3dd0-4bc2-a8ab-fff562e4264b", 4, 8 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "642512f8-973a-4536-9417-4e89f8bc952a", 5, 10 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e9f3d48e-d3bc-4a0f-a7c4-e3bc05389d44", 6, 12 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "79d40a13-f741-4389-abcc-efa0a8df0eed", 7, 14 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "88e46ddc-93a4-41ef-bfdd-d64b26e3c259", 4, 8 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "01a41f8e-08ef-4c1a-85b1-70c3ca5ba504", 5, 10 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e354e18b-dbab-48fc-8a72-10f5acddc082", 6, 12 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "858df929-47f4-4822-94a2-4adca5febc09", 7, 14 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f27a8e25-a3db-4929-b034-bef1c9c70976", 4, 8 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bc8a0dff-3ead-4cd9-ba33-f235e70b00c0", 5, 10 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c4fa34cf-9720-4cae-8276-d96bd211c91d", 6, 12 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e28c6e0c-540c-4911-ba32-1bd8265dc8b0", 7, 14 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "592c5e76-22ec-41f6-92ec-9aa36e474053", 4, 8 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0635df50-8fed-4be0-b446-c3f989bc6772", 5, 10 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b6be4f4e-ee99-434e-af51-10117bddf93c", 6, 12 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "323a0abe-bb2c-4729-be21-6c97e474e020", 7, 14 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "641941cd-439e-47fe-ac24-68975478598b", 4, 8 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f0b0dee4-af51-4bd9-a03d-1184a9b6a956", 5, 10 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5fb27cba-2378-49bc-81f4-119a4e277486", 6, 12 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "49323b2f-3e65-4d42-84d6-f9f8b90898d9", 7, 14 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3c692314-46a1-47f8-8728-b7820a56d0ab", 4, 8 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5ccb9c06-17fa-481b-9b77-031da06da915", 5, 10 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "58c3cefc-ac4e-4005-b05d-f26b4dea932b", 6, 12 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "82270938-7699-4c9d-83cb-bdfde7755e5a", 7, 14 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b30acebd-6e17-43aa-b29b-011925fb9f36", 4, 8 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "66f8fd40-bbd6-4c3c-980e-e3b44f1d0838", 5, 10 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3bcb042a-0624-4e92-a04b-457278059c41", 6, 12 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b0ada252-6586-4363-afde-faa51b9d9268", 7, 14 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a838e9aa-7ded-4524-a59f-e21843ce1822", 4, 8 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ea9658da-e216-4f6b-ad5c-2809ec1d027b", 5, 10 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a9f2dfcf-0ad9-4b4e-891f-689ec9e76ed1", 6, 12 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7f4bb7ab-6986-4b48-b8c3-493af3a7af7d", 7, 14 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4fc74e71-3751-4897-b651-0ff8487e33b4", 4, 8 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a7f8c7c9-3d26-44f8-a4f3-26f094fa78b6", 5, 10 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bc313bfe-7fa5-4265-9094-66bf3015633b", 6, 12 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8d90b81a-f2a0-4850-ae98-0c3970b9ee06", 7, 14 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "47bef629-d37d-4806-8431-0f061f3a80c4", 4, 8 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "550ee4cb-8945-4ef6-8a7c-687f8ea09d5b", 5, 10 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "121ffd2d-3514-4c26-a2e6-8f462ab87e3f", 6, 12 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d26c7d2e-cd2e-4813-bf13-b48182600c33", 7, 14 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "815901ef-2023-4052-8c33-1945cc0a8883", 4, 8 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9f7612b8-61d6-416c-b0f1-e76f1f46f42b", 5, 10 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "edf42897-bc90-4569-8cbc-2dfe1c930ff7", 6, 12 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a5707edd-9c0d-4662-a7ee-7ae5c54175c8", 7, 14 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "18f24d6e-02f6-4f49-b870-d67f4cee18e3", 4, 8 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "23863152-e5a5-4da0-abd5-aa91fa7f4ecd", 5, 10 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "22877d8a-13a5-4174-a0ac-8db4fca46949", 6, 12 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4388c9d8-7bfa-427c-af82-f93f9241d4af", 7, 14 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "33abc595-b19a-43ef-a27d-c5c941e660c7", 4, 8 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "56265cab-6822-43c8-8ac8-3d87f42bc980", 5, 10 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d57c62b2-7a0b-46db-97cd-1e98ed37cfcf", 6, 12 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a2919c08-a341-4aee-9880-c6509c43e223", 7, 14 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5f4bc004-291b-4c2f-95f3-06a00845a2ef", 4, 8 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b733c97e-6c5a-4608-9d3e-4551caf8fd1c", 5, 10 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9e556a2c-ca7e-4299-98c2-3acac397bf61", 6, 12 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3970dfdb-b100-4016-9be7-d1784513d95b", 7, 14 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8cdf9a83-88e5-46f4-9e4c-aa031c8e30dd", 4, 8 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c61c0f0f-9c3e-402f-839d-64c1497faade", 5, 10 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3fa23709-5b1a-485f-b17e-109898841c2a", 6, 12 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "22fd37e5-2a16-4386-a910-ca75cd79756d", 7, 14 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "187445af-639b-4add-a23c-6541bc262c32", 4, 8 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1ed3dcb1-88ef-4a38-921d-499244082d21", 5, 10 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d11cb2c1-3660-4f7e-a5b4-7afe5eb08b29", 6, 12 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3f272fae-0358-4b1e-b0d3-65b663684110", 7, 14 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2339639d-cd31-4cb0-9f98-5468d2d57098", 4, 8 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7dad81eb-6c5e-410a-9329-1b1dc2065404", 5, 10 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5198f3dd-88b7-443c-ab37-346169a8d5b6", 6, 12 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cadd9b25-40a4-45ea-8240-fa76faf156fd", 7, 14 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0eb73568-7745-47d5-9718-4cabdb9cffdc", 4, 8 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "71c0b05d-2750-40f7-a005-7be45eaba22c", 5, 10 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9dddf840-0016-424b-9831-f4d02f44706e", 6, 12 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cd733aee-8544-4e64-89a8-5e23a8c8d7c9", 7, 14 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5c363c01-3e5d-4af7-bd58-5cc4484a1249", 4, 8 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9c3a7bc8-f613-4032-8e57-35fa9ceaa7c5", 5, 10 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3189f4c2-c2aa-4a96-97bc-7376125a2585", 6, 12 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8b1791b9-d99b-4cd7-adc2-aa5d220bb03b", 7, 14 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dde1573d-c2b0-4d06-a9b0-6537d5a5bf96", 4, 8 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cb3dc6b8-4269-4a76-84db-6cf876a77377", 5, 10 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1d38ab2a-d313-46c2-9de3-cb1e6937e6a1", 6, 12 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "68f79d11-cad0-456a-ab79-574b2d07ad9e", 7, 14 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "93ea1c3c-514c-4712-aa59-bc3aaf3e9e18", 4, 8 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a8615d74-ed4d-4e79-a267-285c61930989", 5, 10 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "edbb37ef-2dcf-4de2-8194-e57defc1eee9", 6, 12 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "12e505ab-f958-4392-83b3-a64778240ad2", 7, 14 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4f8123a0-ce4d-4b79-a2a1-7dc1c3dcab49", 4, 8 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9755aa26-49f5-45fc-9910-b80e139d7672", 5, 10 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f4a5672e-f2e6-48df-9b6e-c35eda9d37a1", 6, 12 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "921a4c6a-966c-44ee-b645-456f3c1689ef", 7, 14 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "736af07b-b0bf-453a-8921-1caea81065c9", 4, 8 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "31e7be17-dbbc-4dad-8658-62ee6799e3c8", 5, 10 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4365a487-7610-4b78-8e7b-8f79d993fa59", 6, 12 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "92fcd2ea-a328-47f9-b80d-7d4cc65d4cf3", 7, 14 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8004f240-9b98-4d43-a068-437bc4fe58ac", 4, 8 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c0532ad2-64eb-4726-b6d0-e68de661e7cf", 5, 10 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1699a71e-caaa-40b8-8daf-9e0281412c3c", 6, 12 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a7ec964e-07ed-4109-9b70-436ae752496d", 7, 14 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "adf9e0a8-484f-48e5-a75d-52219d451071", 4, 8 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "03b7abe1-83d7-4afc-bb64-dc9d68588b6b", 5, 10 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c67e9a79-5e06-4010-b140-44f83632f943", 6, 12 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d538f85f-dbbb-46e6-a007-1aa5c5fd9660", 7, 14 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "50c97335-f036-4834-89dd-e52cf453a8ee", 4, 8 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e4a7027d-6759-4b4b-a3cf-9d5eb7089d3a", 5, 10 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "78e12b9f-c222-49b1-9c8a-0b0de57741a6", 6, 12 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "76dc06e8-6e89-4b2a-8cf4-e2912e539086", 7, 14 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "69db1050-16ae-406f-ac81-011d2364cf83", 4, 8 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6b0234f8-7ca1-4d42-92b3-80ae61f5d53b", 5, 10 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "91ca85ca-6986-4474-82fa-573abe92fb3e", 6, 12 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5483d9b5-c27f-4425-88b5-b3da012ae9fe", 7, 14 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b867fd5e-a2b4-4897-ae8e-15c4cc699871", 4, 8 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fbfca73d-c9f9-4a6f-bc05-03b5f8cc7a39", 5, 10 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c2185b53-485e-4a66-ba9a-2d91b8c95281", 6, 12 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b852cb3f-cd66-40b1-8a4b-354fa823eb93", 7, 14 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cdaa065f-6519-47dc-807b-26a6a1cd4aa2", 4, 8 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2a682ffb-aea7-45fd-b6fd-09c040bc4e4d", 5, 10 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6f6c7778-5e7f-405e-8d0a-9a87a1958365", 6, 12 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7a1b3185-7ea0-42b3-86eb-e9f8366bc968", 7, 14 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "56b94ded-570f-47f1-a973-553a698c4645", 4, 8 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "157f6c76-88d3-4272-b336-9af414f216fc", 5, 10 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "38587672-8bc3-4a69-acce-64dd7b715c74", 6, 12 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5b6128e7-2587-430c-a13f-386dd3695e22", 7, 14 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6a2d07b5-a443-4dff-91f2-dd61f18e37bf", 4, 8 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a21e5649-1f3f-4f22-93e4-78f956fc12c1", 5, 10 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e5a85385-1937-4fa4-888a-538b8b9e0db7", 6, 12 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "48f6cac1-a80d-4403-a416-a1f80069e290", 7, 14 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "90bea341-4abd-4f91-9eec-9fee90b8e94d", 4, 8 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b29eb1d3-c3c1-4d64-a13f-5e05702987d6", 5, 10 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "27ea80de-4c64-4604-bb68-3d84a5ba6086", 6, 12 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3337df39-534d-4692-bd92-2f3f462512d0", 7, 14 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "24001b28-b056-4a29-8dda-e92fe1e4be59", 4, 8 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "721c0f6e-da4c-4ccd-ba5b-07ed5f54742b", 5, 10 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "61f40128-5ed4-4d9e-bc8a-f6eef251e50a", 6, 12 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "add7a5ac-e7dc-44fd-83a1-d61cb8f2af11", 7, 14 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a6e4fa87-15f8-4b0a-a043-7e6e87252cff", 4, 8 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dbd330de-2ec3-401c-bc74-27fd3e1e0900", 5, 10 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "be114302-f20f-4504-a387-03646d7d4101", 6, 12 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e2f2a1b8-3229-458b-92cd-bd4e30970577", 7, 14 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1da15dff-f019-4b96-8e34-10390ac5318a", 4, 8 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "44fa0081-8e74-4532-8b71-46e7e9ded417", 5, 10 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "63d2bc78-f87c-4496-8bed-e6070a542283", 6, 12 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1754c9ac-d5b9-427c-af79-5d7e460ded1a", 7, 14 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d82efbc3-d756-4315-8c9f-ae865f019948", 4, 8 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "745fef0b-7509-4b0f-bdb6-0743c8a52b4a", 5, 10 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5ceeecf2-98df-4d11-84d2-5279790049fe", 6, 12 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "189f548e-ba60-4bcb-aef0-c2a1554659aa", 7, 14 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "78cef9d8-784b-449b-aed3-6a422f5e936d", 4, 8 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1be2ffcd-b9e0-4e23-bd51-396e71e26e90", 5, 10 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8c8325b5-c7b6-42e3-99cd-7c2b761008f0", 6, 12 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5e4cee26-c245-43dc-a813-e51cf33c8b2e", 7, 14 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0f554b15-bdd0-47fd-b8df-926ddbcf249a", 4, 8 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a76fcc93-0c1b-4420-8b9b-ef9b037a00ae", 5, 10 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "34ed30a9-8f4f-4ce9-8580-bbdb9efd001e", 6, 12 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c4cb15d4-5455-4349-8068-f944f582e52d", 7, 14 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d54311fb-29b7-4a50-b70e-d14324dd4ed8", 4, 8 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d2098c3e-0213-4fb9-bc66-1ac08335be42", 5, 10 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c276bb4f-7ddf-4dcc-840e-17a1bad9aafd", 6, 12 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3e89c071-ad11-461f-a096-cafdb49dd4a7", 7, 14 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c46230b5-cb3d-4532-92dd-9a2e3536bab8", 4, 8 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8a564839-e226-4589-b7b5-f08e042bc4ab", 5, 10 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "07adcb7a-4ccc-46c3-908e-9e79cb704b42", 6, 12 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bab1d52b-0c3b-490e-8fdb-df4372d12980", 7, 14 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2c9340db-f2bc-4b28-a28f-b1f9146fbf69", 4, 8 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3cc58f7f-23c4-4268-ae4e-05460fad97e6", 5, 10 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e9673adb-c9f8-47c6-a7a1-ca742802ba64", 6, 12 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7b985da0-5722-4087-87eb-62d65b03ef7d", 7, 14 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "41156bdf-07b0-4557-a28b-ed3222611333", 4, 8 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7a91c585-21d0-4f73-b0c7-ce701fde56f4", 5, 10 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6721d09e-b825-4898-943a-edff8a728e4d", 6, 12 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1e010f66-d71c-421c-8a19-1984f98962fc", 7, 14 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0107a519-4d1d-4698-b0e4-0d8398320ce5", 4, 8 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "255c55e0-2827-4f1f-a81d-3cf9c715507d", 5, 10 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "25fdf1f6-2653-4513-a669-0db431785b75", 6, 12 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c6705c0e-745c-4875-bcfd-d32f766ebeb3", 7, 14 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d0192b90-386b-48b1-9419-68da46f8099c", 4, 8 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b6e843de-c486-4981-8c58-4f1087c3f1dd", 5, 10 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "906e474c-c7ff-4acf-a053-20abd3f5a47b", 6, 12 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d5eb2e15-faf4-44b7-b40c-f379d63ea201", 7, 14 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "594416ec-51b4-4cf3-a240-9a3b1ada1313", 4, 8 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a97464c6-ffc7-4c26-9c10-3341eaeff4ba", 5, 10 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b86164a6-028b-4287-a77b-73033898cb00", 6, 12 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "069d7980-bc51-42d8-9ed0-6fe2819e10b0", 7, 14 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6eb80021-3379-412c-b39c-10604cdf0e04", 4, 8 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2a29e0b3-eed2-44b5-8bc4-b02b1b97ac88", 5, 10 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "864ea1d0-109e-476c-a912-ef2624cbb1f6", 6, 12 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0e19802f-b9d7-4070-9e03-49b0c60ebff9", 7, 14 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2442ce4f-467b-4e75-bc6b-8c6241d69085", 4, 8 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "adbc8cb7-d052-41fa-b561-5f114975b2fb", 5, 10 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "48c14dab-99d9-4a0f-84ea-20ceb9cb7d10", 6, 12 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "87276178-79de-446a-853e-22e70a022ebe", 7, 14 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bec80f8c-beeb-42f5-b374-4ecf43316c8c", 4, 8 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "89b2e011-dff3-4820-80bc-3724c80e0606", 5, 10 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a956587d-3147-426a-bdf9-af234a278164", 6, 12 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "588b4e06-cd9c-4850-a0b7-0b2c15de7723", 7, 14 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fbbe5d7b-4822-4655-9564-9e9d59edc438", 4, 8 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "222d6cbd-03ff-4a71-8cb9-607c416f55bc", 5, 10 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7b7bf00a-1e3a-4c75-8f61-b16ecde49175", 6, 12 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "56ea9cc2-5d63-43bb-817c-805ad8937526", 7, 14 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "af200784-1a13-4257-8186-8ec473ebbb68", 4, 8 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d34272aa-56d3-4610-97f0-93212d514890", 5, 10 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3b134997-2df2-4f74-9159-891ee979f3a7", 6, 12 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2cb137f6-5fd4-47ef-aaec-b57bd67abcc0", 7, 14 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b80d2477-1241-4bda-b4ca-879703fa84db", 4, 8 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "40669974-43da-4619-aa1b-6c2afb39a1dc", 5, 10 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bccdcdf4-8829-4165-8191-f3612265eefa", 6, 12 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a0d4b79d-1930-4f44-bc34-1f54490f6634", 7, 14 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5bc34e59-a4d2-4194-a4ef-98086ff8afe1", 4, 8 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bf2910d5-7008-4412-8bcd-66ef508e7dd5", 5, 10 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ab318535-acc0-4064-b21d-dd3f66fbb709", 6, 12 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "85b475de-7a2b-4668-910b-b22cd7936a04", 7, 14 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "27b5f795-da13-4b45-bbe5-d1c520fad579", 4, 8 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "66e37a83-6f92-4979-8029-fd200139f64f", 5, 10 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d719a511-825d-4bb6-8066-7c1a8a97b56c", 6, 12 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e48a8673-85ee-4346-9c8d-e2a20f076ab8", 7, 14 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a856634e-1dda-41ac-99e5-a9ce3c3a61b1", 4, 8 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a334b212-d868-4890-be51-86ba66b92c9c", 5, 10 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5ef7d63b-de97-48e2-a91e-fe2d123c8e2e", 6, 12 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8c77ffd8-e215-4890-986e-f927eb60df3b", 7, 14 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5ae546ef-42fb-4d85-810f-aba73e5f628c", 4, 8 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "60878ba1-6f16-443c-afca-f98d7f6f76bf", 5, 10 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1f4d5de2-10d9-42ff-a8db-bb8e1d696caf", 6, 12 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "65fd44ec-59ab-4737-8988-6db34882202b", 7, 14 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "871529ae-bad0-45a5-8052-2feb40b3e95a", 4, 8 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ebe105d2-f6b9-444e-999d-857636fc7fdc", 5, 10 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "75450585-7621-4fd9-af4c-4ac93f0ed29c", 6, 12 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1d1a56c8-2d35-4bfe-b85e-29c78aa2192b", 7, 14 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "14d24756-c04f-47bf-a532-f3455a3f5081", 4, 8 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d2daef40-ad3f-4c99-9bf0-d35cbecc736a", 5, 10 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0dae30cd-e67b-4765-9783-2a7147c68782", 6, 12 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "837d31ea-b27f-4dc3-868e-6b4197cc0d03", 7, 14 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dbf73463-7601-4664-a4e6-c1ec14865882", 4, 8 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bbbd86bc-27f2-42b1-8c27-7e290c2f1c69", 5, 10 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7f85f28c-f317-4f5a-b896-fb55b1e9d515", 6, 12 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d7774ec7-5876-43af-8065-838ab90caa6f", 7, 14 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "df9f3c14-827b-445f-94cf-8dc580434533", 4, 8 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "58fe3822-dadd-4902-a579-c185191cfa6b", 5, 10 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3f157455-2077-4214-99ba-5f92d666cda3", 6, 12 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0e705159-f3aa-4d58-a527-4443b59eeeb2", 7, 14 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b8177566-7bbf-4f9b-87d8-64e73b392b83", 4, 8 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "75e87817-3037-4275-85a5-f69f8dc03b4a", 5, 10 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3d49831d-339e-41b7-80c9-d61951baa172", 6, 12 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0a9d1cf7-b8df-4508-bd84-0c9544b31399", 7, 14 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8a581c07-6722-4828-9250-99f938e59148", 4, 8 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "edbe3854-58bc-4608-84bb-7b8a1ab3465c", 5, 10 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "71b26b73-a8fc-4642-b455-144a4fdb3398", 6, 12 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d65dca28-e8dd-4e66-801a-a20f409d34f0", 7, 14 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "abb9a0b6-4cb9-45ca-a745-1df6f4c612e9", 4, 8 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "676fd3c5-9c59-427f-8f9c-c274462ab30b", 5, 10 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b3eeac6f-7ab6-4e66-90bb-4c6f016e8f1c", 6, 12 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a1c878fd-169f-4bd2-9703-1487d437bf06", 7, 14 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4fd5260c-d9f6-4c35-bb3c-727cdf70ee07", 4, 8 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7181225a-db7e-4b5c-be5e-4795be08b55c", 5, 10 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "35eaf093-b4e7-4e23-9c15-eb49cd1d3311", 6, 12 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "53f811e9-1a33-4c57-b59e-5b5283031db7", 7, 14 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f5a3ab1e-c45c-4919-8722-b8f85e3304c7", 4, 8 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4d1eb9c2-8aec-41e4-bf59-90d36d108aed", 5, 10 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e1dc06c3-4136-4b2f-9fc6-a96e63a7b687", 6, 12 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a0a59a97-35c8-4ffd-a0e4-ffb7be0580c4", 7, 14 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1afeecec-f9b1-41bf-8033-1c14898c9241", 4, 8 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7d3c3249-dc16-40d9-8450-254d7bd51c8b", 5, 10 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a90fe3a8-e1f9-4156-b3dd-a1b91571be2a", 6, 12 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "66aa0a26-9116-4d03-81af-6869c7766597", 7, 14 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7a4f77ca-8f9c-4245-9ef0-37e9d630e9a6", 4, 8 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b6b2b2b0-72c7-4b15-9ea6-253ff073cdb7", 5, 10 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2b8c6530-f810-461b-837c-bb331391aad5", 6, 12 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0591d346-dd23-4215-b1df-1bffee105fa6", 7, 14 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2e6f7999-3dc3-488e-8609-f558a3337138", 4, 8 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "555b8575-7eac-430a-b8f4-168d2e629527", 5, 10 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ab3dd7fa-d9b5-4fe3-9062-5004faa7d60d", 6, 12 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f16fb7ff-48b1-4b8d-91ce-496f29811742", 7, 14 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7b6db506-1e7f-4812-807c-161c4b476228", 4, 8 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "accbcfd3-985b-4431-80c4-3115d142c073", 5, 10 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f2b57ca4-055c-40eb-ac0f-d037e984de0b", 6, 12 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ff75bb0f-d77a-4d55-a0ba-cd186f9ebd15", 7, 14 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1889207f-8b3a-44e7-b88e-0e5a6af475bf", 4, 8 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2821baeb-0453-4049-90e6-cf0af8363b8f", 5, 10 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a9e683f6-fc41-4842-acfa-10732e95e4f3", 6, 12 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cc9d3758-2b10-49ef-9382-f90d7243b4e1", 7, 14 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8ea0566b-56c2-48fe-9380-bbc08fb86f88", 4, 8 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7f707083-ec95-4598-8bc1-e1b813adf994", 5, 10 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7f11853f-ae2e-4eb3-9bea-6f6915d794c8", 6, 12 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b33ec4da-d035-4ae9-999b-ccb06b142ac3", 7, 14 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5f8dd8fe-2220-4803-bfd0-a8b411cab276", 4, 8 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0a7068ff-9ebd-43d2-b2eb-d2b3ed0f8148", 5, 10 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f2e1836b-151b-4b7d-9f83-14814b4bbbf8", 6, 12 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b6bbc9fd-a77b-4f67-9ba9-6aec2e887f74", 7, 14 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "66fab033-97b6-4340-815b-6f3359c9b77f", 4, 8 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2e660e2d-94b8-4fca-a027-a175406ca48c", 5, 10 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e519776e-c6c1-4949-b750-98f75e334a10", 6, 12 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "91ac3c87-15da-4d98-b4cb-ab1153c74c98", 7, 14 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b23c0e08-abe8-4587-9770-60f22cc6d791", 4, 8 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3334dc33-76a1-4e39-9943-13711642b219", 5, 10 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "370016ff-3d13-47c1-a968-024d7b89da71", 6, 12 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3d922c06-98dd-4d6f-9adf-f5c1b973da59", 7, 14 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b27c9818-6071-452f-a444-8c726c9434da", 4, 8 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "04c7556b-b270-4d29-964c-94a3d92a82f1", 5, 10 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d6cb0891-5b6e-48c2-8dfa-ff583f212ac1", 6, 12 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e940821d-c997-4cc1-b280-13924469cdf5", 7, 14 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0e78b31c-11a0-41f0-b085-94b364e75f05", 4, 8 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "14390d0a-a2c2-4c77-a543-1d8a8685bdb9", 5, 10 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ff82b332-dff9-4308-90fa-b30278035873", 6, 12 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2b4582cd-6b63-44bd-aed7-bef4e75e81f1", 7, 14 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5a5276e7-11ee-4fb8-bea0-5f85c5b629de", 4, 8 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2db30e2f-c6c4-41ef-8d82-7eb0bf88292d", 5, 10 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2ef55172-5493-48cb-a20d-c6114e69f487", 6, 12 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "871fa564-e847-409d-9fa9-8f84be339d8e", 7, 14 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7f865619-6132-4815-a334-77da3e7a93d0", 4, 8 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aa6e7fcd-1cbc-498a-a7fe-7c41afcf5e7a", 5, 10 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7348d30d-e4de-4833-a406-fb33e54ccfc8", 6, 12 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "53679849-a6cf-49c5-8193-f86535af52a3", 7, 14 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3f44e668-789a-4913-9486-f39a8da1126d", 4, 8 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "018c0c33-6f9e-4d32-b5ff-10f593065fe9", 5, 10 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7cc33ec6-52da-47fb-92b0-9a58b907b02c", 6, 12 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a1d8893c-a90f-4fe5-b23f-df39bd39d7e0", 7, 14 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0bcd721e-c86d-4a24-b4ad-930d66a1cb33", 4, 8 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b245b9f7-a16b-4578-8d38-7cc4c3dc2feb", 5, 10 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8dbbe581-cb81-4f78-9c73-def055f23d49", 6, 12 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f8651448-e8a5-4cc9-b22a-b4d593127bea", 7, 14 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "514c3094-7e87-4c96-bee1-a416d7988f24", 4, 8 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "be5fb11e-e28a-44e0-b4be-5a98ac759acd", 5, 10 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d1337920-5dc2-4ecb-b9aa-1c8237caf4af", 6, 12 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5d99472e-c6d2-4667-b914-e11de05baf4d", 7, 14 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b0c8afe1-4e4b-4ac2-ba25-3c4fd32589a6", 4, 8 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8c483ac8-e9de-444a-a89c-52fd078b3b9d", 5, 10 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e9d737c0-3c28-4d63-8043-a82d48a14245", 6, 12 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7307e808-0eee-40d1-b4c2-2d9d5e81c76e", 7, 14 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ef04d37d-2205-4640-a874-09404acf9122", 4, 8 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e96c508f-c8b9-44db-b15e-fa353df56aab", 5, 10 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e3f4b96d-0950-492d-895c-bc421d1dde72", 6, 12 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e9e6b1d1-17a6-48f0-af01-6f1f8e4b0339", 7, 14 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "35615f18-6ba8-4d9f-91a1-030dbf539cd1", 4, 8 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "42cf0d8c-cf4b-4cac-ad82-ce91c8c7bf15", 5, 10 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2b10b95e-ec4b-48c0-8980-20f13a07d77f", 6, 12 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1b6fea6d-23c8-4868-be42-6c5ebb1ba130", 7, 14 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1e77c82f-b118-481a-937b-cf7b253626df", 4, 8 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "26831a9f-b70d-4b07-8f6e-c7381d08235c", 5, 10 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ec4cba02-003a-4cd0-a6ca-67552384c6ce", 6, 12 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "063fc742-6a3b-4324-b438-99b2f8c75695", 7, 14 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "49f2633f-5546-4208-ac7f-f96f34cb3ed1", 4, 8 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e5f3a871-1914-4a18-bc19-5aab8b1a119d", 5, 10 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "056e218c-77b1-4def-a136-1623445b7269", 6, 12 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "43e0469d-fce2-4fc8-a021-76bc8f4c406e", 7, 14 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "47614152-2fa6-47c8-a6ca-733744c5020a", 4, 8 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "93c78066-9811-436a-894d-abc5596a897a", 5, 10 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9d6c44ae-e594-47b9-a8a1-a4ce19f95252", 6, 12 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "73e439c5-4b8c-4fb9-881f-905a2bc43e0d", 7, 14 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6a095aa1-8fb0-450b-9188-f34065065402", 4, 8 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "00ad0802-0dc3-4528-9b3a-e822b07b932b", 5, 10 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2aa55ae6-a01b-4bbd-8887-bf48d460703f", 6, 12 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cdcdcfc6-f5af-4376-82dd-182b359ea154", 7, 14 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c42244c6-099b-4d3c-b4f2-ab74ea74aaf6", 4, 8 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3bc010dd-95a1-4b20-b833-c68cbb50c84c", 5, 10 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9082f833-5738-41d1-8d07-a4a471240817", 6, 12 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7c10f9ea-f008-47f9-af90-7d6ed21249df", 7, 14 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2a1d7027-8578-4178-b74d-9ce85a48e364", 4, 8 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e0352870-952f-438b-b1ab-b07c867a48e9", 5, 10 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4bda92f1-3490-4e9e-ac55-1f7447c5916e", 6, 12 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d8b52206-39d9-4d72-b35a-888c98c43a83", 7, 14 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ed0aa258-0d02-44cd-aec2-9c3ad21196bc", 4, 8 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "276c09c3-db1a-47b5-8cf0-146304a6f9b0", 5, 10 }
                });

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00e2e1d5-5577-4f8e-b13b-dde82c77b91d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01388782-b75d-4762-8ccf-4499568fd455",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01e005f3-0bbb-4ae2-9136-f3afe1353315",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "034b18a2-33ad-4020-8d9d-5a98891d0be9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0418ebf4-0b73-4042-a5e4-ce396d5b512b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04871b2a-5533-41da-9959-f664809887c3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04886a46-180e-42d2-a3e5-86df27efaee2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04a7d241-f761-4ead-803b-1d204df7bd53",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04c2c202-afa7-4e2c-941c-29f956783f6d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "06c505ec-998c-46c0-9163-0188423113b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "074db959-27e0-42a0-98d9-0961864e1a7e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0973a418-280f-416d-8df1-7139e28961d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09a2d110-7772-44cd-af5f-27fb951f0544",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09ff2634-4a59-46ce-94c7-8428324d789f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a1ff474-48a1-4366-a120-8ece6ce5ba04",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a7149b1-6928-4099-b623-787d0201e213",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0bf06e4b-d062-4e01-a985-9b05e3f12fd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c59ca0d-60e5-4686-80be-18ab36b53468",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0dddae8d-37b4-47e5-9c89-95589a3f787a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e9b45b3-2915-4dcd-99fa-77ad89f182a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f1d6d17-8b8b-489d-a0f6-7349691aadd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "121345d8-2660-489c-a90d-2469b9c44222",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "142730b0-0df7-430d-ab80-e750ffe0a6ba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16b681bd-b39a-4891-ab7a-9073365bc1e7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a9626f8-303d-41e3-aa54-ae1a971ad179",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f4cf9f5-2976-4b5c-9428-122096bf3877",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2146af26-ce2b-461b-883b-e6f4fe0c8085",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "229759ff-14dd-4c4e-82aa-f56a2181c0ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23672a63-2fd2-4e6a-905b-340ae4456b83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2838e6e6-1238-418a-988c-0346a2abdbc3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "286d76ad-723d-476b-aa84-c7a6541afe81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "299be826-3901-425f-90eb-e445e73ac37c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2b514c67-a65f-4c0a-86b8-5bf92a974c34",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2bc1e669-d825-44a8-a11c-656a8209498a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e5e4216-4af5-4fb6-9c65-8989715e5a40",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b00595-bfeb-47b6-9af3-91d117e003d4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b3b531-3e47-4ccb-9cc9-8e7aafedb810",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "334d6d7e-422b-4376-ac30-161f98aab66d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3396c18a-dcd2-4638-8827-2c7fc10d6996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "364cd9de-6ddd-47d6-a534-74f3f00a0b7c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3770c1af-e181-494b-8c1a-c6f09a3b825a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38af7185-32ce-4cf9-95d2-52c4c4d18bce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38c1edea-3339-4f95-8d4a-5f5583660d9f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c8cf49-d75e-4703-8958-ec3bbff87723",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c99f61-efbf-4f5c-b084-eac381d82049",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39f01cd0-ae41-4070-9eb0-0f2423cc3286",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d6e031d-2fcc-46ce-9eb7-268e95ae1323",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d704609-8abd-4a0a-80dd-2ee9f38a3608",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3da92c21-3bf0-4de1-a187-459271e16106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e2f7a5f-b665-4b13-861e-c5a5029216a0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f6f1dbc-9042-42c2-85ca-a117c745c5e8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41c0e64a-97f8-45fa-a2b3-399ed47cddcc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43606bc6-5874-4469-bcdf-fe1b86f66882",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43bf1028-ea0f-439a-b940-3b81b1f4d683",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43c746aa-0830-449b-a594-621f04923cf6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43ca244e-8d5a-468b-b327-ce6bdc541cf7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43f658bf-a5f4-4537-a281-77dbb5ce1c27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4534cffd-7ed4-406c-9cee-23179740daba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "46c82189-5271-43ba-97aa-a7b0a7dbf126",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4779905b-91b3-4878-97e0-58a010668be5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a450a7f-5ca6-42f5-9931-e130264c8e0c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a67e8f3-4dec-41ad-a5e7-18995a14535d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4aa47021-28ed-4c36-81c3-6e2734d3873b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b376f71-ebf0-4762-bbff-e61541afa410",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b656abf-bdc5-4058-a12b-488d93cc1677",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c0b609e-a2cc-4477-b8d7-9fec89d49462",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e99c977-d86c-48a7-8bd8-9e71d999539a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f8cc09d-7512-44d8-a98c-3004c93031f0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50680664-523a-475b-869f-0aa5e0cd88b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "523db500-84c9-42fa-bf24-f66e77e724e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52a0bd63-231d-4620-9e7a-10b6d4fb8b65",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "541a5387-302a-478d-99f2-c98f6d979aaa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55f0346e-6b98-4a1d-99f8-463b81f6a627",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "56072689-4550-44be-987e-b08667758de4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "564ea3f5-665c-45f3-85ee-e4c45d3ba362",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5754a3be-8508-452d-8a64-9d752bde4f70",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5787a57d-27d4-4dd2-b5e1-35e4125a6e94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a04a2e5-489b-4671-933a-1db0a971f40e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a382843-9817-449b-b9d8-4e48d90aef5e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a529282-1b91-46d6-b472-e6386b95cf5d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b26e8ac-df32-4b9d-8992-047e22372332",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b36c084-dce0-4ba9-ba55-613210750e27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cc37e11-afea-478b-b360-1256896a421b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5eaed820-0af4-4157-8fea-1f58baa77661",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5f9a2c76-50a5-4e93-95c9-158ae078c357",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6183a2d7-d2c5-4828-bccb-754ce1bbb002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "618fdb18-11c3-4166-9bb1-79298a32a7a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61efcce3-e4ac-4aa6-ae46-1b7976b5da88",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64a56e1a-be01-40b0-bc09-1fcaf2161c10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "674202c6-8a9b-4c1f-9eae-0ab056cef8d6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "676211f2-1f90-4059-bdf8-9e26f9a637a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6883361b-7a86-49b9-8fc2-90029770fe22",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69191d39-5c1b-4261-b0d7-48a7833e08bd",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69920a1e-2cdf-4b1a-a9cc-329b986e4b69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bdd753a-2706-48b6-b485-23c989a5f326",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c4014cc-3cc2-481d-9cd6-b13c45da0908",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6e0185cc-235f-4603-9470-5f4ca7c92514",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6eee1f90-a40d-4d95-9ca6-0e45689398be",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f001fcf-f1b6-4abb-8d91-7038044fabfa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f055d63-314e-4a36-86eb-ea7e11e820c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f154805-6e66-45a6-a147-87edf4267def",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f169352-0f68-4d11-b562-f693a0158100",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fe7b587-9518-460f-8c8f-7aa43ad55f9c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7203c646-e705-48d1-8141-b2619b227d8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72d46b9b-612d-41c4-8303-8f8571771de9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "731dd6c2-2937-4d4b-8c56-63b5cf581729",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74770ec2-4585-4665-8f69-b2f0d4f0fc7f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "748cbc1e-8d05-4f4f-8196-9cfb28db232c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74aa5d7a-f513-4993-b672-cdf9bb448319",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "752bc953-0f26-4a2c-afd2-45c5f0b9aecb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75ce2f59-fa25-4745-bb37-371fc11ab655",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77035e08-21a9-4149-8d7c-d4266f88ad03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "777bd2e2-cd9e-4d51-b191-c81eb9d113cc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78157107-23fa-4638-bd17-38187695312c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7965d633-4f86-44de-8ea4-fe0c68aa6a83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79876823-dd75-471e-b2b5-80650a4bdd47",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a3ccc47-8f30-4952-8909-ed3537cfe7e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a7cb657-507c-4325-a047-f9d67b6fbffc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7ac3fbad-b279-4d80-a8d7-ff1407a6465f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7d543840-b11e-4380-a147-7dab483cf5ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "809d901e-d7de-4fec-aa95-655deb2301b6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "80f38d33-7c5f-4952-809c-85af1dc69962",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "815f578a-5fd8-4c79-8446-ff236b6ffafb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8191402a-33f8-4195-bd73-3aa71191981e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81c921f4-7fd6-428a-aefe-648e5e11ed46",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81cb9635-df03-42c8-8d68-944f99de02ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "827e88a3-8580-436c-9112-02d58ca2d7d0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85634f26-c60b-4cc5-8c0f-0fad3182a5f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8601b2c5-4e87-49e4-9099-8c21a9ca00b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86513d65-cf7e-49d6-bd16-94286e5d60c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8906cf96-12d6-4eca-8a0b-d39dd78dc597",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "89c5b8e4-4c60-4e08-88ad-4509be08bde4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8a84a13e-c0cc-4496-81a8-f4550c5807ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8abdfc01-6b02-4b55-93d3-eea25b17de37",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8ad91c05-ccae-4482-9f43-f8f197dccdf9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8af7be7f-0ff6-40e1-b206-e89d78430393",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8cefc01c-282b-4866-a0fa-238ed864481c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d1f8204-852a-4342-b836-767fb2b71263",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9017f445-e420-4568-b8d9-0d84b3c46aad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91cb02d4-02ee-4632-a12b-7aaa4b220344",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "924916c0-2ad0-493a-b544-5df45fa43152",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92a51416-05b5-47ef-834f-ad0baccbb932",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "932c7c4b-36c5-4580-a276-a176a72fd72d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9377deeb-6354-4346-8d56-03b29c97d5fc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93c17f7a-aedf-4f6d-8429-df9ff308d381",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "94430690-6bd2-4e48-b0c3-4de11c7f5d81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9445ce49-5efd-41b8-bdab-b8d7f350b5e2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9570f221-d5cb-4963-896f-371af0b32c79",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "958017ca-725f-4d80-b65e-79560a051a03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "976d92d5-de98-47ea-a219-26842c7f8caf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c301f9b-43b4-4015-bc1d-70ad1b2b690e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f0127f0-a604-46ba-a855-ca6be06fcdb2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f2f3880-4997-4c0b-88e8-f9a74f8b1564",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a07ed297-38cd-456e-834f-c31583eab987",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a08d4c19-059b-42bc-83db-26206735e40f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a278895c-19b5-45c6-92f9-48c5f2724e8a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2a34d3f-9082-4d98-9637-2bd936e60256",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2bcb56b-1da2-43fc-b133-3b5c04603123",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a34e2f74-5403-4e43-bc88-30019ebd460f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a39041d7-3a20-4e73-9334-3fc6d8327e06",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4efe1b6-e7fb-4cee-96aa-1125a3888791",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a907697f-9b47-4302-87f3-c4bed83b24c9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad918937-0645-4b89-86d5-0672662fd46e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aee09720-0d54-473a-b585-c62d6c516e68",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1dae3fe-91d2-42cc-8ba7-dcf237882eac",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2b71d89-5501-4bd6-a358-aca8ce706bdb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5b67003-636d-425d-9784-45d374db713c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5e13a1d-86f3-415c-9c2f-4343258a4b57",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8b726c6-227d-4267-8dba-c1bf5ec0301f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8cc3bd3-ac03-46c4-820b-f7988f3088f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bac28c61-4b74-4193-a109-f4456c44cf67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb1dfb9b-70aa-495e-a041-156a4fbb4fec",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd0cb50a-e769-48ed-8473-b25faa687e15",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "beacb4b7-e74c-45d8-b8df-60e1a2a50768",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c15e0f9b-39be-49ff-aff8-1800116358f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c24852f9-007d-455a-8cb5-0e2681c7a0a5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c35ccc97-39f5-4396-bbe1-2a6171f30d10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c37d754a-9f08-4f13-8d26-630d896c9371",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c474ff32-d65e-4d11-90a2-f9ad2e8ee772",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c50585c6-d1df-4eaa-b5bf-317678e7d3bb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5381f46-f707-4fcb-8f1e-605cee507946",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5d36e60-0945-4e35-9239-22f30c29025f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6633a62-08d6-4613-8f06-a3fcfd76f974",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6fcf873-e9c2-43c9-81ec-ba09bd063e13",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c87ce8ae-adb7-4007-8c0e-0090d0926e2e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8e6b9db-dbc9-4d49-a473-2c8593982b56",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8eeda2a-0260-4488-9acf-fddaee71e124",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c941ed50-01c0-472d-8122-3756b9b55a29",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c99efd04-1f14-49e6-bd60-208290d057a6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cae31f17-a52f-4ac3-97bb-6886500b19bf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "caf33f50-8517-4995-a849-4a70bbe202f6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd21938d-8cdf-4c18-a25a-73a2970c2deb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3167af-629a-4795-8c18-cf4f49e0a7d1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3be091-3d72-4512-ba1d-e8466285b930",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ceaa3043-fb10-4638-b942-85d7b5fc20ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cf03ef83-babf-4710-ab13-ace35476b474",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfb34052-097c-4637-b13e-86a2bc255163",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d302b7f9-1306-4a95-85d4-ff189df4b527",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d501bc94-2256-4ce7-b0bf-be4357ada814",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6003f61-89ae-4240-b53c-542ab36728ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d7a31657-3101-42e7-8b97-aa6ff61d3e84",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d99cdf9c-bda7-4807-b92e-34b3de2e6002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db5aeda4-2830-4ddd-a7ca-02363d58bf25",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db604d4c-9f40-48f5-b244-9b3bdcaf71c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db9ccc9b-5149-474b-a0b4-af8a13f01bc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc91cbb3-94e1-43fe-bf92-06077cf48d87",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc94da97-75b3-48b7-bfb6-d46984b5f106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd438551-3d93-45bc-982d-7c338b69983b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e0f91ecb-de8b-44fb-9a15-59c38d5093b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e35c267e-66ab-453d-ba33-a31c4ce7e5ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d54d6e-42fe-472b-b696-6642067802b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e9ca0d20-0315-4fca-b334-e6e046cd076e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea3367e6-6d1c-4e58-883a-b18d66f30f8b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea59937e-0296-4758-95ad-196fce18db72",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb3e277a-61f3-4f55-b179-d474841a80a3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed9ab94a-9354-48de-8695-43131a67bd2c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eec8a34e-e0ea-4a80-bd38-c7db22f84173",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef08937f-96ed-443c-80ac-1f7b764d10a1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef23ec60-f223-44c4-915e-196d6b011b94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efe2c4a0-7529-4f91-9026-696ea0a1f7b7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f03ff26b-30e9-4a60-b99a-780060db1e35",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f102b409-56b3-42b4-b70c-25192033ba8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f20906f6-cdbb-4f93-9ad0-87e63f0782ff",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f39485eb-f82b-495c-8b60-7dada21ee477",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f43faef4-2885-42c1-9035-ccc2667d7fca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f6edd915-a9e4-4713-8e0a-6f1d7efde18f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f7062df1-beb7-4814-a074-e9da66830639",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "faa28a13-3b08-4a67-834d-621e4dd3d287",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb0deebe-ca58-4eb6-ac5b-67442c846405",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc72a988-3078-4c69-a8ca-c0f1dc1ec996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fee54746-70cf-44dd-98df-5c09bb8959a8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffcc6812-deda-4b92-b2dd-0f59e0a46c44",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 210, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "2acf1b67-6217-4302-8ff8-1d818d955e6f", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 20, 23, 2, 27, 212, DateTimeKind.Local).AddTicks(8567), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "11ebdd3a-f75a-4d85-9916-220874cf8af9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 213, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "152002fb-d980-4750-a70a-7b5d0bdac9e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 213, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 213, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 20, 23, 2, 27, 213, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "a4366f38-41fd-4835-8468-8a726897446c", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_Id",
                table: "ProductSizes",
                column: "Id",
                unique: true,
                filter: "[Id] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_Id",
                table: "ProductSizes");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "00dec16e-23b7-444f-a3aa-88cc8bc2246c");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "3de66ea5-fb86-4531-ad04-d22dd74e4f63");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "465f7699-30f0-4c7d-8c1d-132d5d16954b");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "61c0ad8f-d62d-404d-b56b-d5729bbc53fd");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "7dcee25d-4880-46d2-93dd-d1f6ac3a57ec");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "990879c9-b117-43b9-af9d-da61d2a9efea");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "a18488c1-6955-41a7-a926-30f98a09c6d3");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "b5b138cb-30d2-4487-ad08-7119d54c9aaa");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "bb9a85b5-6581-43bc-8472-e70d840489c4");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "f1446d03-b46b-4863-9bf4-e6cb76b60d00");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "f14f90a2-c1fb-4d36-a6a6-fc70b003008f");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "f25a2d0f-daeb-4226-b7f4-cc475007ea59");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "0c9c1103-6791-4709-945f-979f39831dc4");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "1794266c-c2f1-40ae-9091-9dfd88a7db94");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "1c743e77-8205-44d4-a4f7-eba2c8e9d7f6");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "1fb1bf27-096c-42f5-968e-be7f47222e21");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "27f3fe59-fd4c-4e54-94f6-360fd3650357");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "3771bdb7-adaf-400d-abdf-e0560cc55c4c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "52645bff-35f5-4b61-8b9a-ea38f690f6b5");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5d6ab2cc-c201-4722-91cc-32711697d0c1");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "623f6b0e-26ae-4a16-b4a8-c40405269fbc");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "7d54168a-99d2-4af0-8261-f0fc1456b690");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "7dfc0d6b-c848-4724-bb5d-5566239edb13");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "864ef4f1-3049-40a7-b840-25f0e8a995c4");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "a834e7c4-c840-4d8d-b28d-5b5b19ad9153");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "ac2b2392-b6ce-477c-9ce9-5b312bfd05b9");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b5d942a7-c713-4f5c-901c-69c3faf7f95c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "be628b91-19d1-418a-97f0-a46b3fb64a67");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "c99d7bee-a682-4ea9-9132-10a792605bc4");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "dffe7ba9-5a12-4922-934e-f80291baffde");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "e819c5f1-36db-427b-887c-c72cc0f40722");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "efd6007e-69f9-4746-8f9d-691d3690f12e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f1abee9d-1fdb-48fb-894c-143b7b13bf45");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "fce5ff90-97bc-476a-bc61-9c1e5ee561b3");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "fd137de8-20df-4044-a182-ece503fbd64a");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "febb7317-5e4e-4a25-add5-bd93be917773");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "68cf81d1-a382-4871-9988-bb8f1d573328");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "8f1c83cc-767f-4dcf-a2d9-99fd437ce843");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "95ab63bb-869d-4d92-89c7-022c2d4ec20e");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "d5b801ea-3585-4bc3-af34-25f4345dc1f6");

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "01388782-b75d-4762-8ccf-4499568fd455", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "01388782-b75d-4762-8ccf-4499568fd455", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "01388782-b75d-4762-8ccf-4499568fd455", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "01388782-b75d-4762-8ccf-4499568fd455", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04871b2a-5533-41da-9959-f664809887c3", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04871b2a-5533-41da-9959-f664809887c3", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04871b2a-5533-41da-9959-f664809887c3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04871b2a-5533-41da-9959-f664809887c3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04886a46-180e-42d2-a3e5-86df27efaee2", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04886a46-180e-42d2-a3e5-86df27efaee2", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04886a46-180e-42d2-a3e5-86df27efaee2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04886a46-180e-42d2-a3e5-86df27efaee2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04a7d241-f761-4ead-803b-1d204df7bd53", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04a7d241-f761-4ead-803b-1d204df7bd53", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04a7d241-f761-4ead-803b-1d204df7bd53", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04a7d241-f761-4ead-803b-1d204df7bd53", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04c2c202-afa7-4e2c-941c-29f956783f6d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04c2c202-afa7-4e2c-941c-29f956783f6d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04c2c202-afa7-4e2c-941c-29f956783f6d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "04c2c202-afa7-4e2c-941c-29f956783f6d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "06c505ec-998c-46c0-9163-0188423113b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "06c505ec-998c-46c0-9163-0188423113b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "06c505ec-998c-46c0-9163-0188423113b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "06c505ec-998c-46c0-9163-0188423113b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "074db959-27e0-42a0-98d9-0961864e1a7e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "074db959-27e0-42a0-98d9-0961864e1a7e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "074db959-27e0-42a0-98d9-0961864e1a7e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "074db959-27e0-42a0-98d9-0961864e1a7e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0973a418-280f-416d-8df1-7139e28961d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0973a418-280f-416d-8df1-7139e28961d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0973a418-280f-416d-8df1-7139e28961d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0973a418-280f-416d-8df1-7139e28961d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "09a2d110-7772-44cd-af5f-27fb951f0544", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "09a2d110-7772-44cd-af5f-27fb951f0544", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "09a2d110-7772-44cd-af5f-27fb951f0544", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "09a2d110-7772-44cd-af5f-27fb951f0544", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "09ff2634-4a59-46ce-94c7-8428324d789f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "09ff2634-4a59-46ce-94c7-8428324d789f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "09ff2634-4a59-46ce-94c7-8428324d789f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "09ff2634-4a59-46ce-94c7-8428324d789f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0a7149b1-6928-4099-b623-787d0201e213", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0a7149b1-6928-4099-b623-787d0201e213", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0a7149b1-6928-4099-b623-787d0201e213", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0a7149b1-6928-4099-b623-787d0201e213", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0c59ca0d-60e5-4686-80be-18ab36b53468", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0c59ca0d-60e5-4686-80be-18ab36b53468", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0c59ca0d-60e5-4686-80be-18ab36b53468", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0c59ca0d-60e5-4686-80be-18ab36b53468", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "121345d8-2660-489c-a90d-2469b9c44222", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "121345d8-2660-489c-a90d-2469b9c44222", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "121345d8-2660-489c-a90d-2469b9c44222", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "121345d8-2660-489c-a90d-2469b9c44222", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "23672a63-2fd2-4e6a-905b-340ae4456b83", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "23672a63-2fd2-4e6a-905b-340ae4456b83", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "23672a63-2fd2-4e6a-905b-340ae4456b83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "23672a63-2fd2-4e6a-905b-340ae4456b83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2838e6e6-1238-418a-988c-0346a2abdbc3", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2838e6e6-1238-418a-988c-0346a2abdbc3", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2838e6e6-1238-418a-988c-0346a2abdbc3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2838e6e6-1238-418a-988c-0346a2abdbc3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "286d76ad-723d-476b-aa84-c7a6541afe81", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "286d76ad-723d-476b-aa84-c7a6541afe81", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "286d76ad-723d-476b-aa84-c7a6541afe81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "286d76ad-723d-476b-aa84-c7a6541afe81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "299be826-3901-425f-90eb-e445e73ac37c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "299be826-3901-425f-90eb-e445e73ac37c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "299be826-3901-425f-90eb-e445e73ac37c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "299be826-3901-425f-90eb-e445e73ac37c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2bc1e669-d825-44a8-a11c-656a8209498a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2bc1e669-d825-44a8-a11c-656a8209498a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2bc1e669-d825-44a8-a11c-656a8209498a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2bc1e669-d825-44a8-a11c-656a8209498a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "31b00595-bfeb-47b6-9af3-91d117e003d4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "31b00595-bfeb-47b6-9af3-91d117e003d4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "31b00595-bfeb-47b6-9af3-91d117e003d4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "31b00595-bfeb-47b6-9af3-91d117e003d4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "334d6d7e-422b-4376-ac30-161f98aab66d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "334d6d7e-422b-4376-ac30-161f98aab66d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "334d6d7e-422b-4376-ac30-161f98aab66d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "334d6d7e-422b-4376-ac30-161f98aab66d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39c8cf49-d75e-4703-8958-ec3bbff87723", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39c8cf49-d75e-4703-8958-ec3bbff87723", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39c8cf49-d75e-4703-8958-ec3bbff87723", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39c8cf49-d75e-4703-8958-ec3bbff87723", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39c99f61-efbf-4f5c-b084-eac381d82049", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39c99f61-efbf-4f5c-b084-eac381d82049", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39c99f61-efbf-4f5c-b084-eac381d82049", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39c99f61-efbf-4f5c-b084-eac381d82049", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3da92c21-3bf0-4de1-a187-459271e16106", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3da92c21-3bf0-4de1-a187-459271e16106", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3da92c21-3bf0-4de1-a187-459271e16106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3da92c21-3bf0-4de1-a187-459271e16106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43606bc6-5874-4469-bcdf-fe1b86f66882", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43606bc6-5874-4469-bcdf-fe1b86f66882", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43606bc6-5874-4469-bcdf-fe1b86f66882", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43606bc6-5874-4469-bcdf-fe1b86f66882", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43c746aa-0830-449b-a594-621f04923cf6", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43c746aa-0830-449b-a594-621f04923cf6", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43c746aa-0830-449b-a594-621f04923cf6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43c746aa-0830-449b-a594-621f04923cf6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4534cffd-7ed4-406c-9cee-23179740daba", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4534cffd-7ed4-406c-9cee-23179740daba", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4534cffd-7ed4-406c-9cee-23179740daba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4534cffd-7ed4-406c-9cee-23179740daba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4779905b-91b3-4878-97e0-58a010668be5", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4779905b-91b3-4878-97e0-58a010668be5", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4779905b-91b3-4878-97e0-58a010668be5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4779905b-91b3-4878-97e0-58a010668be5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4b376f71-ebf0-4762-bbff-e61541afa410", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4b376f71-ebf0-4762-bbff-e61541afa410", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4b376f71-ebf0-4762-bbff-e61541afa410", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4b376f71-ebf0-4762-bbff-e61541afa410", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4b656abf-bdc5-4058-a12b-488d93cc1677", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4b656abf-bdc5-4058-a12b-488d93cc1677", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4b656abf-bdc5-4058-a12b-488d93cc1677", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4b656abf-bdc5-4058-a12b-488d93cc1677", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "50680664-523a-475b-869f-0aa5e0cd88b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "50680664-523a-475b-869f-0aa5e0cd88b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "50680664-523a-475b-869f-0aa5e0cd88b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "50680664-523a-475b-869f-0aa5e0cd88b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "523db500-84c9-42fa-bf24-f66e77e724e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "523db500-84c9-42fa-bf24-f66e77e724e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "523db500-84c9-42fa-bf24-f66e77e724e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "523db500-84c9-42fa-bf24-f66e77e724e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "541a5387-302a-478d-99f2-c98f6d979aaa", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "541a5387-302a-478d-99f2-c98f6d979aaa", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "541a5387-302a-478d-99f2-c98f6d979aaa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "541a5387-302a-478d-99f2-c98f6d979aaa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "56072689-4550-44be-987e-b08667758de4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "56072689-4550-44be-987e-b08667758de4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "56072689-4550-44be-987e-b08667758de4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "56072689-4550-44be-987e-b08667758de4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5754a3be-8508-452d-8a64-9d752bde4f70", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5754a3be-8508-452d-8a64-9d752bde4f70", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5754a3be-8508-452d-8a64-9d752bde4f70", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5754a3be-8508-452d-8a64-9d752bde4f70", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a04a2e5-489b-4671-933a-1db0a971f40e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a04a2e5-489b-4671-933a-1db0a971f40e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a04a2e5-489b-4671-933a-1db0a971f40e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a04a2e5-489b-4671-933a-1db0a971f40e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a382843-9817-449b-b9d8-4e48d90aef5e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a382843-9817-449b-b9d8-4e48d90aef5e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a382843-9817-449b-b9d8-4e48d90aef5e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a382843-9817-449b-b9d8-4e48d90aef5e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a529282-1b91-46d6-b472-e6386b95cf5d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a529282-1b91-46d6-b472-e6386b95cf5d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a529282-1b91-46d6-b472-e6386b95cf5d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5a529282-1b91-46d6-b472-e6386b95cf5d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5b26e8ac-df32-4b9d-8992-047e22372332", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5b26e8ac-df32-4b9d-8992-047e22372332", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5b26e8ac-df32-4b9d-8992-047e22372332", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5b26e8ac-df32-4b9d-8992-047e22372332", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5b36c084-dce0-4ba9-ba55-613210750e27", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5b36c084-dce0-4ba9-ba55-613210750e27", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5b36c084-dce0-4ba9-ba55-613210750e27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5b36c084-dce0-4ba9-ba55-613210750e27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5cc37e11-afea-478b-b360-1256896a421b", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5cc37e11-afea-478b-b360-1256896a421b", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5cc37e11-afea-478b-b360-1256896a421b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5cc37e11-afea-478b-b360-1256896a421b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5eaed820-0af4-4157-8fea-1f58baa77661", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5eaed820-0af4-4157-8fea-1f58baa77661", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5eaed820-0af4-4157-8fea-1f58baa77661", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5eaed820-0af4-4157-8fea-1f58baa77661", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6883361b-7a86-49b9-8fc2-90029770fe22", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6883361b-7a86-49b9-8fc2-90029770fe22", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6883361b-7a86-49b9-8fc2-90029770fe22", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6883361b-7a86-49b9-8fc2-90029770fe22", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6bdd753a-2706-48b6-b485-23c989a5f326", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6bdd753a-2706-48b6-b485-23c989a5f326", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6bdd753a-2706-48b6-b485-23c989a5f326", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6bdd753a-2706-48b6-b485-23c989a5f326", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6e0185cc-235f-4603-9470-5f4ca7c92514", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6e0185cc-235f-4603-9470-5f4ca7c92514", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6e0185cc-235f-4603-9470-5f4ca7c92514", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6e0185cc-235f-4603-9470-5f4ca7c92514", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f154805-6e66-45a6-a147-87edf4267def", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f154805-6e66-45a6-a147-87edf4267def", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f154805-6e66-45a6-a147-87edf4267def", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f154805-6e66-45a6-a147-87edf4267def", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f169352-0f68-4d11-b562-f693a0158100", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f169352-0f68-4d11-b562-f693a0158100", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f169352-0f68-4d11-b562-f693a0158100", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6f169352-0f68-4d11-b562-f693a0158100", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7203c646-e705-48d1-8141-b2619b227d8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7203c646-e705-48d1-8141-b2619b227d8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7203c646-e705-48d1-8141-b2619b227d8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7203c646-e705-48d1-8141-b2619b227d8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "72d46b9b-612d-41c4-8303-8f8571771de9", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "72d46b9b-612d-41c4-8303-8f8571771de9", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "72d46b9b-612d-41c4-8303-8f8571771de9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "72d46b9b-612d-41c4-8303-8f8571771de9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "74aa5d7a-f513-4993-b672-cdf9bb448319", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "74aa5d7a-f513-4993-b672-cdf9bb448319", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "74aa5d7a-f513-4993-b672-cdf9bb448319", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "74aa5d7a-f513-4993-b672-cdf9bb448319", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "75ce2f59-fa25-4745-bb37-371fc11ab655", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "75ce2f59-fa25-4745-bb37-371fc11ab655", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "75ce2f59-fa25-4745-bb37-371fc11ab655", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "75ce2f59-fa25-4745-bb37-371fc11ab655", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "77035e08-21a9-4149-8d7c-d4266f88ad03", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "77035e08-21a9-4149-8d7c-d4266f88ad03", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "77035e08-21a9-4149-8d7c-d4266f88ad03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "77035e08-21a9-4149-8d7c-d4266f88ad03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "78157107-23fa-4638-bd17-38187695312c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "78157107-23fa-4638-bd17-38187695312c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "78157107-23fa-4638-bd17-38187695312c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "78157107-23fa-4638-bd17-38187695312c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "79876823-dd75-471e-b2b5-80650a4bdd47", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "79876823-dd75-471e-b2b5-80650a4bdd47", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "79876823-dd75-471e-b2b5-80650a4bdd47", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "79876823-dd75-471e-b2b5-80650a4bdd47", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7d543840-b11e-4380-a147-7dab483cf5ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7d543840-b11e-4380-a147-7dab483cf5ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7d543840-b11e-4380-a147-7dab483cf5ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7d543840-b11e-4380-a147-7dab483cf5ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "809d901e-d7de-4fec-aa95-655deb2301b6", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "809d901e-d7de-4fec-aa95-655deb2301b6", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "809d901e-d7de-4fec-aa95-655deb2301b6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "809d901e-d7de-4fec-aa95-655deb2301b6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "80f38d33-7c5f-4952-809c-85af1dc69962", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "80f38d33-7c5f-4952-809c-85af1dc69962", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "80f38d33-7c5f-4952-809c-85af1dc69962", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "80f38d33-7c5f-4952-809c-85af1dc69962", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8191402a-33f8-4195-bd73-3aa71191981e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8191402a-33f8-4195-bd73-3aa71191981e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8191402a-33f8-4195-bd73-3aa71191981e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8191402a-33f8-4195-bd73-3aa71191981e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "81cb9635-df03-42c8-8d68-944f99de02ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "81cb9635-df03-42c8-8d68-944f99de02ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "81cb9635-df03-42c8-8d68-944f99de02ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "81cb9635-df03-42c8-8d68-944f99de02ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "827e88a3-8580-436c-9112-02d58ca2d7d0", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "827e88a3-8580-436c-9112-02d58ca2d7d0", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "827e88a3-8580-436c-9112-02d58ca2d7d0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "827e88a3-8580-436c-9112-02d58ca2d7d0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8af7be7f-0ff6-40e1-b206-e89d78430393", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8af7be7f-0ff6-40e1-b206-e89d78430393", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8af7be7f-0ff6-40e1-b206-e89d78430393", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8af7be7f-0ff6-40e1-b206-e89d78430393", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8cefc01c-282b-4866-a0fa-238ed864481c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8cefc01c-282b-4866-a0fa-238ed864481c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8cefc01c-282b-4866-a0fa-238ed864481c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8cefc01c-282b-4866-a0fa-238ed864481c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8d1f8204-852a-4342-b836-767fb2b71263", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8d1f8204-852a-4342-b836-767fb2b71263", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8d1f8204-852a-4342-b836-767fb2b71263", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8d1f8204-852a-4342-b836-767fb2b71263", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9017f445-e420-4568-b8d9-0d84b3c46aad", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9017f445-e420-4568-b8d9-0d84b3c46aad", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9017f445-e420-4568-b8d9-0d84b3c46aad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9017f445-e420-4568-b8d9-0d84b3c46aad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "924916c0-2ad0-493a-b544-5df45fa43152", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "924916c0-2ad0-493a-b544-5df45fa43152", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "924916c0-2ad0-493a-b544-5df45fa43152", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "924916c0-2ad0-493a-b544-5df45fa43152", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "92a51416-05b5-47ef-834f-ad0baccbb932", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "92a51416-05b5-47ef-834f-ad0baccbb932", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "92a51416-05b5-47ef-834f-ad0baccbb932", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "92a51416-05b5-47ef-834f-ad0baccbb932", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "932c7c4b-36c5-4580-a276-a176a72fd72d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "932c7c4b-36c5-4580-a276-a176a72fd72d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "932c7c4b-36c5-4580-a276-a176a72fd72d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "932c7c4b-36c5-4580-a276-a176a72fd72d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9377deeb-6354-4346-8d56-03b29c97d5fc", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9377deeb-6354-4346-8d56-03b29c97d5fc", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9377deeb-6354-4346-8d56-03b29c97d5fc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9377deeb-6354-4346-8d56-03b29c97d5fc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9570f221-d5cb-4963-896f-371af0b32c79", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9570f221-d5cb-4963-896f-371af0b32c79", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9570f221-d5cb-4963-896f-371af0b32c79", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9570f221-d5cb-4963-896f-371af0b32c79", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "958017ca-725f-4d80-b65e-79560a051a03", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "958017ca-725f-4d80-b65e-79560a051a03", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "958017ca-725f-4d80-b65e-79560a051a03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "958017ca-725f-4d80-b65e-79560a051a03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "976d92d5-de98-47ea-a219-26842c7f8caf", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "976d92d5-de98-47ea-a219-26842c7f8caf", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "976d92d5-de98-47ea-a219-26842c7f8caf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "976d92d5-de98-47ea-a219-26842c7f8caf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a07ed297-38cd-456e-834f-c31583eab987", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a07ed297-38cd-456e-834f-c31583eab987", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a07ed297-38cd-456e-834f-c31583eab987", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a07ed297-38cd-456e-834f-c31583eab987", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a08d4c19-059b-42bc-83db-26206735e40f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a08d4c19-059b-42bc-83db-26206735e40f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a08d4c19-059b-42bc-83db-26206735e40f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a08d4c19-059b-42bc-83db-26206735e40f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a2a34d3f-9082-4d98-9637-2bd936e60256", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a2a34d3f-9082-4d98-9637-2bd936e60256", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a2a34d3f-9082-4d98-9637-2bd936e60256", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a2a34d3f-9082-4d98-9637-2bd936e60256", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a34e2f74-5403-4e43-bc88-30019ebd460f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a34e2f74-5403-4e43-bc88-30019ebd460f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a34e2f74-5403-4e43-bc88-30019ebd460f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a34e2f74-5403-4e43-bc88-30019ebd460f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a907697f-9b47-4302-87f3-c4bed83b24c9", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a907697f-9b47-4302-87f3-c4bed83b24c9", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a907697f-9b47-4302-87f3-c4bed83b24c9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a907697f-9b47-4302-87f3-c4bed83b24c9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ad918937-0645-4b89-86d5-0672662fd46e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ad918937-0645-4b89-86d5-0672662fd46e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ad918937-0645-4b89-86d5-0672662fd46e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ad918937-0645-4b89-86d5-0672662fd46e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "aee09720-0d54-473a-b585-c62d6c516e68", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "aee09720-0d54-473a-b585-c62d6c516e68", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "aee09720-0d54-473a-b585-c62d6c516e68", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "aee09720-0d54-473a-b585-c62d6c516e68", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b5b67003-636d-425d-9784-45d374db713c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b5b67003-636d-425d-9784-45d374db713c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b5b67003-636d-425d-9784-45d374db713c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b5b67003-636d-425d-9784-45d374db713c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bac28c61-4b74-4193-a109-f4456c44cf67", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bac28c61-4b74-4193-a109-f4456c44cf67", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bac28c61-4b74-4193-a109-f4456c44cf67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bac28c61-4b74-4193-a109-f4456c44cf67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bd0cb50a-e769-48ed-8473-b25faa687e15", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bd0cb50a-e769-48ed-8473-b25faa687e15", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bd0cb50a-e769-48ed-8473-b25faa687e15", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bd0cb50a-e769-48ed-8473-b25faa687e15", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c15e0f9b-39be-49ff-aff8-1800116358f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c15e0f9b-39be-49ff-aff8-1800116358f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c15e0f9b-39be-49ff-aff8-1800116358f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c15e0f9b-39be-49ff-aff8-1800116358f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c37d754a-9f08-4f13-8d26-630d896c9371", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c37d754a-9f08-4f13-8d26-630d896c9371", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c37d754a-9f08-4f13-8d26-630d896c9371", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c37d754a-9f08-4f13-8d26-630d896c9371", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5381f46-f707-4fcb-8f1e-605cee507946", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5381f46-f707-4fcb-8f1e-605cee507946", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5381f46-f707-4fcb-8f1e-605cee507946", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5381f46-f707-4fcb-8f1e-605cee507946", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5d36e60-0945-4e35-9239-22f30c29025f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5d36e60-0945-4e35-9239-22f30c29025f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5d36e60-0945-4e35-9239-22f30c29025f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5d36e60-0945-4e35-9239-22f30c29025f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c8eeda2a-0260-4488-9acf-fddaee71e124", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c8eeda2a-0260-4488-9acf-fddaee71e124", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c8eeda2a-0260-4488-9acf-fddaee71e124", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c8eeda2a-0260-4488-9acf-fddaee71e124", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c941ed50-01c0-472d-8122-3756b9b55a29", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c941ed50-01c0-472d-8122-3756b9b55a29", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c941ed50-01c0-472d-8122-3756b9b55a29", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c941ed50-01c0-472d-8122-3756b9b55a29", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c99efd04-1f14-49e6-bd60-208290d057a6", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c99efd04-1f14-49e6-bd60-208290d057a6", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c99efd04-1f14-49e6-bd60-208290d057a6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "c99efd04-1f14-49e6-bd60-208290d057a6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "caf33f50-8517-4995-a849-4a70bbe202f6", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "caf33f50-8517-4995-a849-4a70bbe202f6", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "caf33f50-8517-4995-a849-4a70bbe202f6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "caf33f50-8517-4995-a849-4a70bbe202f6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd3be091-3d72-4512-ba1d-e8466285b930", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd3be091-3d72-4512-ba1d-e8466285b930", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd3be091-3d72-4512-ba1d-e8466285b930", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cd3be091-3d72-4512-ba1d-e8466285b930", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cf03ef83-babf-4710-ab13-ace35476b474", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cf03ef83-babf-4710-ab13-ace35476b474", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cf03ef83-babf-4710-ab13-ace35476b474", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cf03ef83-babf-4710-ab13-ace35476b474", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cfb34052-097c-4637-b13e-86a2bc255163", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cfb34052-097c-4637-b13e-86a2bc255163", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cfb34052-097c-4637-b13e-86a2bc255163", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "cfb34052-097c-4637-b13e-86a2bc255163", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d302b7f9-1306-4a95-85d4-ff189df4b527", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d302b7f9-1306-4a95-85d4-ff189df4b527", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d302b7f9-1306-4a95-85d4-ff189df4b527", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d302b7f9-1306-4a95-85d4-ff189df4b527", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d501bc94-2256-4ce7-b0bf-be4357ada814", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d501bc94-2256-4ce7-b0bf-be4357ada814", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d501bc94-2256-4ce7-b0bf-be4357ada814", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d501bc94-2256-4ce7-b0bf-be4357ada814", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d6003f61-89ae-4240-b53c-542ab36728ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d6003f61-89ae-4240-b53c-542ab36728ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d6003f61-89ae-4240-b53c-542ab36728ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d6003f61-89ae-4240-b53c-542ab36728ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dd438551-3d93-45bc-982d-7c338b69983b", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dd438551-3d93-45bc-982d-7c338b69983b", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dd438551-3d93-45bc-982d-7c338b69983b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "dd438551-3d93-45bc-982d-7c338b69983b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e7d54d6e-42fe-472b-b696-6642067802b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e7d54d6e-42fe-472b-b696-6642067802b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e7d54d6e-42fe-472b-b696-6642067802b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e7d54d6e-42fe-472b-b696-6642067802b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ea59937e-0296-4758-95ad-196fce18db72", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ea59937e-0296-4758-95ad-196fce18db72", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ea59937e-0296-4758-95ad-196fce18db72", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ea59937e-0296-4758-95ad-196fce18db72", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "eb3e277a-61f3-4f55-b179-d474841a80a3", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "eb3e277a-61f3-4f55-b179-d474841a80a3", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "eb3e277a-61f3-4f55-b179-d474841a80a3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "eb3e277a-61f3-4f55-b179-d474841a80a3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ed9ab94a-9354-48de-8695-43131a67bd2c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ed9ab94a-9354-48de-8695-43131a67bd2c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ed9ab94a-9354-48de-8695-43131a67bd2c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ed9ab94a-9354-48de-8695-43131a67bd2c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ef23ec60-f223-44c4-915e-196d6b011b94", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ef23ec60-f223-44c4-915e-196d6b011b94", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ef23ec60-f223-44c4-915e-196d6b011b94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ef23ec60-f223-44c4-915e-196d6b011b94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f03ff26b-30e9-4a60-b99a-780060db1e35", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f03ff26b-30e9-4a60-b99a-780060db1e35", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f03ff26b-30e9-4a60-b99a-780060db1e35", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f03ff26b-30e9-4a60-b99a-780060db1e35", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f102b409-56b3-42b4-b70c-25192033ba8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f102b409-56b3-42b4-b70c-25192033ba8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f102b409-56b3-42b4-b70c-25192033ba8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f102b409-56b3-42b4-b70c-25192033ba8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f39485eb-f82b-495c-8b60-7dada21ee477", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f39485eb-f82b-495c-8b60-7dada21ee477", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f39485eb-f82b-495c-8b60-7dada21ee477", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f39485eb-f82b-495c-8b60-7dada21ee477", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f43faef4-2885-42c1-9035-ccc2667d7fca", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f43faef4-2885-42c1-9035-ccc2667d7fca", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f43faef4-2885-42c1-9035-ccc2667d7fca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f43faef4-2885-42c1-9035-ccc2667d7fca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f7062df1-beb7-4814-a074-e9da66830639", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f7062df1-beb7-4814-a074-e9da66830639", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f7062df1-beb7-4814-a074-e9da66830639", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f7062df1-beb7-4814-a074-e9da66830639", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "faa28a13-3b08-4a67-834d-621e4dd3d287", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "faa28a13-3b08-4a67-834d-621e4dd3d287", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "faa28a13-3b08-4a67-834d-621e4dd3d287", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "faa28a13-3b08-4a67-834d-621e4dd3d287", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fee54746-70cf-44dd-98df-5c09bb8959a8", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fee54746-70cf-44dd-98df-5c09bb8959a8", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fee54746-70cf-44dd-98df-5c09bb8959a8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "fee54746-70cf-44dd-98df-5c09bb8959a8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "2acf1b67-6217-4302-8ff8-1d818d955e6f");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "a4366f38-41fd-4835-8468-8a726897446c");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ProductSizes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UnitPriceForSale",
                table: "BasketDetails",
                type: "int",
                maxLength: 100000,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100000,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes",
                column: "Id");

            migrationBuilder.InsertData(
                table: "FotoDesign",
                columns: new[] { "Id", "CreatedAt", "Name", "PhotoPath" },
                values: new object[,]
                {
                    { "1b89e2b7-dbcd-491e-bbd9-6ed9e98fc01f", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(272), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "264ecf8b-e827-4705-8d88-33bcc6785b5a", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(267), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" },
                    { "44c9ed0e-e9a5-4c95-acf0-1c9e5eef12c9", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(176), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "4a583063-2ee2-41fd-8ef1-94f504fcc286", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(286), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" },
                    { "526556a0-189a-4d2f-81a7-a943c97d1c9f", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(290), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "58071e99-f236-44c3-bbe5-4cea0f8ffeaa", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(246), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "8e9c04f2-13ff-45b1-baf8-540b7f348329", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(239), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "a671fb5c-557a-47bd-b347-c2443ddc57fd", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(295), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "adcd4088-7a98-455c-bd2d-c5ad88f07974", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(280), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "df8509e8-4fc9-4fec-b31e-bee47e39882f", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(256), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "e03a3596-6d39-4207-ae95-e99c871408b8", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(263), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "f4ddd565-c3b4-4b3e-bfa2-27e1c3dc8c1c", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(251), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "08398545-47d2-4d9f-8c9c-9648ff65b0ba", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2817), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "0f646bc9-034f-4d8f-a93d-ae4dc8c90419", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2843), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "2f0c4c86-bdb2-4778-a0dc-4908e470ed35", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2881), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "3363b849-13b8-4a64-b105-ea594a7b0e9c", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2863), "/databaseimg/galeri/galeriIMG_1958.jpg" },
                    { "41145e12-7699-46f1-bcc4-199aba0ec6ff", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2937), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "423273aa-4c1a-4c31-8bfa-b7324d8ef173", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2932), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "4bb6bdaf-f0a8-4c1b-a3b2-40eafd2a89ad", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2856), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "5b6033d8-7210-4e9e-8398-46d8c34161b5", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2941), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "5f1b3f9b-0574-43dd-b493-8cd33e459b12", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2904), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "6e5c8d63-b753-478e-9be0-1f7c304440fb", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2889), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "72c87428-cf6e-42c7-aa28-50b6b1843710", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2838), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" },
                    { "88a43f4d-a250-4fdb-a397-6144ed19c25e", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2867), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "88cd7728-2f93-41d4-8f0a-45fe3459449b", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2945), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "8e0558fb-c695-48ec-89fd-dc35d17c7405", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2885), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "94f24999-7c03-4aa6-ba6d-aa8335649be9", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2913), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "a5b6d257-a9e1-4b81-a1fd-dbc4f826b07c", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2847), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "a9db2ba3-e96d-4d60-8e90-93f752ed03ca", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2918), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "af7eb7c9-1f91-49ff-b8ab-16c387f13bab", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2923), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "b779c08b-abd3-46b5-8aaf-94eff51b71e8", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2909), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "b7919e75-ea82-4dd4-85f6-9121c8e4ae4c", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2875), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "c82b2431-b92c-449c-94c2-701dd0fbe457", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2900), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "d3a3694c-4963-4d67-bda3-8ba8c9fe4217", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2896), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "da2bd17c-1f9d-4a9f-b926-7efdca1c54ef", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2871), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "dd3c01de-520a-4fb8-932a-52933cf67683", new DateTime(2024, 12, 19, 4, 4, 55, 370, DateTimeKind.Local).AddTicks(2926), "/databaseimg/galeri/galeriIMG-8454.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "455a8f27-9d84-4f95-8e09-494f99866a3b", new DateTime(2024, 12, 19, 4, 4, 55, 380, DateTimeKind.Local).AddTicks(7991), "Siparişiniz Kargoya verildi" },
                    { "a45358e6-0f2b-4d18-825d-44f907a3ada7", new DateTime(2024, 12, 19, 4, 4, 55, 380, DateTimeKind.Local).AddTicks(7986), "Siparişiniz Hazırlanıyor" },
                    { "b81d44f6-abb1-4594-b4ca-5cb52509d3a9", new DateTime(2024, 12, 19, 4, 4, 55, 380, DateTimeKind.Local).AddTicks(7959), "Siparişiniz Alındı" },
                    { "cb77e289-c518-4780-8ea5-32ea102e063c", new DateTime(2024, 12, 19, 4, 4, 55, 380, DateTimeKind.Local).AddTicks(7996), "Siparişiniz Tamamlandı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 382, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00e2e1d5-5577-4f8e-b13b-dde82c77b91d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01388782-b75d-4762-8ccf-4499568fd455",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01e005f3-0bbb-4ae2-9136-f3afe1353315",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "034b18a2-33ad-4020-8d9d-5a98891d0be9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0418ebf4-0b73-4042-a5e4-ce396d5b512b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04871b2a-5533-41da-9959-f664809887c3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04886a46-180e-42d2-a3e5-86df27efaee2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04a7d241-f761-4ead-803b-1d204df7bd53",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04c2c202-afa7-4e2c-941c-29f956783f6d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "06c505ec-998c-46c0-9163-0188423113b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "074db959-27e0-42a0-98d9-0961864e1a7e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0973a418-280f-416d-8df1-7139e28961d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09a2d110-7772-44cd-af5f-27fb951f0544",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09ff2634-4a59-46ce-94c7-8428324d789f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a1ff474-48a1-4366-a120-8ece6ce5ba04",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a7149b1-6928-4099-b623-787d0201e213",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0bf06e4b-d062-4e01-a985-9b05e3f12fd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c59ca0d-60e5-4686-80be-18ab36b53468",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0dddae8d-37b4-47e5-9c89-95589a3f787a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e9b45b3-2915-4dcd-99fa-77ad89f182a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f1d6d17-8b8b-489d-a0f6-7349691aadd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "121345d8-2660-489c-a90d-2469b9c44222",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "142730b0-0df7-430d-ab80-e750ffe0a6ba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16b681bd-b39a-4891-ab7a-9073365bc1e7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a9626f8-303d-41e3-aa54-ae1a971ad179",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f4cf9f5-2976-4b5c-9428-122096bf3877",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2146af26-ce2b-461b-883b-e6f4fe0c8085",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "229759ff-14dd-4c4e-82aa-f56a2181c0ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23672a63-2fd2-4e6a-905b-340ae4456b83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2838e6e6-1238-418a-988c-0346a2abdbc3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "286d76ad-723d-476b-aa84-c7a6541afe81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "299be826-3901-425f-90eb-e445e73ac37c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2b514c67-a65f-4c0a-86b8-5bf92a974c34",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2bc1e669-d825-44a8-a11c-656a8209498a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e5e4216-4af5-4fb6-9c65-8989715e5a40",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b00595-bfeb-47b6-9af3-91d117e003d4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b3b531-3e47-4ccb-9cc9-8e7aafedb810",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "334d6d7e-422b-4376-ac30-161f98aab66d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3396c18a-dcd2-4638-8827-2c7fc10d6996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "364cd9de-6ddd-47d6-a534-74f3f00a0b7c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3770c1af-e181-494b-8c1a-c6f09a3b825a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38af7185-32ce-4cf9-95d2-52c4c4d18bce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38c1edea-3339-4f95-8d4a-5f5583660d9f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c8cf49-d75e-4703-8958-ec3bbff87723",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c99f61-efbf-4f5c-b084-eac381d82049",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39f01cd0-ae41-4070-9eb0-0f2423cc3286",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d6e031d-2fcc-46ce-9eb7-268e95ae1323",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d704609-8abd-4a0a-80dd-2ee9f38a3608",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3da92c21-3bf0-4de1-a187-459271e16106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e2f7a5f-b665-4b13-861e-c5a5029216a0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f6f1dbc-9042-42c2-85ca-a117c745c5e8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41c0e64a-97f8-45fa-a2b3-399ed47cddcc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43606bc6-5874-4469-bcdf-fe1b86f66882",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43bf1028-ea0f-439a-b940-3b81b1f4d683",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43c746aa-0830-449b-a594-621f04923cf6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43ca244e-8d5a-468b-b327-ce6bdc541cf7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43f658bf-a5f4-4537-a281-77dbb5ce1c27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4534cffd-7ed4-406c-9cee-23179740daba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "46c82189-5271-43ba-97aa-a7b0a7dbf126",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4779905b-91b3-4878-97e0-58a010668be5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a450a7f-5ca6-42f5-9931-e130264c8e0c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a67e8f3-4dec-41ad-a5e7-18995a14535d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4aa47021-28ed-4c36-81c3-6e2734d3873b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b376f71-ebf0-4762-bbff-e61541afa410",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b656abf-bdc5-4058-a12b-488d93cc1677",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c0b609e-a2cc-4477-b8d7-9fec89d49462",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e99c977-d86c-48a7-8bd8-9e71d999539a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f8cc09d-7512-44d8-a98c-3004c93031f0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50680664-523a-475b-869f-0aa5e0cd88b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "523db500-84c9-42fa-bf24-f66e77e724e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52a0bd63-231d-4620-9e7a-10b6d4fb8b65",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "541a5387-302a-478d-99f2-c98f6d979aaa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55f0346e-6b98-4a1d-99f8-463b81f6a627",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "56072689-4550-44be-987e-b08667758de4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "564ea3f5-665c-45f3-85ee-e4c45d3ba362",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5754a3be-8508-452d-8a64-9d752bde4f70",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5787a57d-27d4-4dd2-b5e1-35e4125a6e94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a04a2e5-489b-4671-933a-1db0a971f40e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a382843-9817-449b-b9d8-4e48d90aef5e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a529282-1b91-46d6-b472-e6386b95cf5d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b26e8ac-df32-4b9d-8992-047e22372332",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b36c084-dce0-4ba9-ba55-613210750e27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cc37e11-afea-478b-b360-1256896a421b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5eaed820-0af4-4157-8fea-1f58baa77661",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5f9a2c76-50a5-4e93-95c9-158ae078c357",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6183a2d7-d2c5-4828-bccb-754ce1bbb002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "618fdb18-11c3-4166-9bb1-79298a32a7a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61efcce3-e4ac-4aa6-ae46-1b7976b5da88",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64a56e1a-be01-40b0-bc09-1fcaf2161c10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "674202c6-8a9b-4c1f-9eae-0ab056cef8d6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "676211f2-1f90-4059-bdf8-9e26f9a637a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6883361b-7a86-49b9-8fc2-90029770fe22",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69191d39-5c1b-4261-b0d7-48a7833e08bd",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69920a1e-2cdf-4b1a-a9cc-329b986e4b69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bdd753a-2706-48b6-b485-23c989a5f326",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c4014cc-3cc2-481d-9cd6-b13c45da0908",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6e0185cc-235f-4603-9470-5f4ca7c92514",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6eee1f90-a40d-4d95-9ca6-0e45689398be",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f001fcf-f1b6-4abb-8d91-7038044fabfa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f055d63-314e-4a36-86eb-ea7e11e820c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f154805-6e66-45a6-a147-87edf4267def",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f169352-0f68-4d11-b562-f693a0158100",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fe7b587-9518-460f-8c8f-7aa43ad55f9c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7203c646-e705-48d1-8141-b2619b227d8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72d46b9b-612d-41c4-8303-8f8571771de9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "731dd6c2-2937-4d4b-8c56-63b5cf581729",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74770ec2-4585-4665-8f69-b2f0d4f0fc7f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "748cbc1e-8d05-4f4f-8196-9cfb28db232c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74aa5d7a-f513-4993-b672-cdf9bb448319",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "752bc953-0f26-4a2c-afd2-45c5f0b9aecb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75ce2f59-fa25-4745-bb37-371fc11ab655",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77035e08-21a9-4149-8d7c-d4266f88ad03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "777bd2e2-cd9e-4d51-b191-c81eb9d113cc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78157107-23fa-4638-bd17-38187695312c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7965d633-4f86-44de-8ea4-fe0c68aa6a83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79876823-dd75-471e-b2b5-80650a4bdd47",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a3ccc47-8f30-4952-8909-ed3537cfe7e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a7cb657-507c-4325-a047-f9d67b6fbffc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7ac3fbad-b279-4d80-a8d7-ff1407a6465f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7d543840-b11e-4380-a147-7dab483cf5ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "809d901e-d7de-4fec-aa95-655deb2301b6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "80f38d33-7c5f-4952-809c-85af1dc69962",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "815f578a-5fd8-4c79-8446-ff236b6ffafb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8191402a-33f8-4195-bd73-3aa71191981e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81c921f4-7fd6-428a-aefe-648e5e11ed46",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81cb9635-df03-42c8-8d68-944f99de02ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "827e88a3-8580-436c-9112-02d58ca2d7d0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85634f26-c60b-4cc5-8c0f-0fad3182a5f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8601b2c5-4e87-49e4-9099-8c21a9ca00b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86513d65-cf7e-49d6-bd16-94286e5d60c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8906cf96-12d6-4eca-8a0b-d39dd78dc597",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "89c5b8e4-4c60-4e08-88ad-4509be08bde4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8a84a13e-c0cc-4496-81a8-f4550c5807ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8abdfc01-6b02-4b55-93d3-eea25b17de37",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8ad91c05-ccae-4482-9f43-f8f197dccdf9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8af7be7f-0ff6-40e1-b206-e89d78430393",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8cefc01c-282b-4866-a0fa-238ed864481c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d1f8204-852a-4342-b836-767fb2b71263",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9017f445-e420-4568-b8d9-0d84b3c46aad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91cb02d4-02ee-4632-a12b-7aaa4b220344",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "924916c0-2ad0-493a-b544-5df45fa43152",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92a51416-05b5-47ef-834f-ad0baccbb932",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "932c7c4b-36c5-4580-a276-a176a72fd72d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9377deeb-6354-4346-8d56-03b29c97d5fc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93c17f7a-aedf-4f6d-8429-df9ff308d381",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "94430690-6bd2-4e48-b0c3-4de11c7f5d81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9445ce49-5efd-41b8-bdab-b8d7f350b5e2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9570f221-d5cb-4963-896f-371af0b32c79",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "958017ca-725f-4d80-b65e-79560a051a03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "976d92d5-de98-47ea-a219-26842c7f8caf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c301f9b-43b4-4015-bc1d-70ad1b2b690e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f0127f0-a604-46ba-a855-ca6be06fcdb2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f2f3880-4997-4c0b-88e8-f9a74f8b1564",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a07ed297-38cd-456e-834f-c31583eab987",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a08d4c19-059b-42bc-83db-26206735e40f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a278895c-19b5-45c6-92f9-48c5f2724e8a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2a34d3f-9082-4d98-9637-2bd936e60256",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2bcb56b-1da2-43fc-b133-3b5c04603123",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a34e2f74-5403-4e43-bc88-30019ebd460f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a39041d7-3a20-4e73-9334-3fc6d8327e06",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4efe1b6-e7fb-4cee-96aa-1125a3888791",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a907697f-9b47-4302-87f3-c4bed83b24c9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad918937-0645-4b89-86d5-0672662fd46e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aee09720-0d54-473a-b585-c62d6c516e68",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1dae3fe-91d2-42cc-8ba7-dcf237882eac",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2b71d89-5501-4bd6-a358-aca8ce706bdb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5b67003-636d-425d-9784-45d374db713c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5e13a1d-86f3-415c-9c2f-4343258a4b57",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8b726c6-227d-4267-8dba-c1bf5ec0301f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8cc3bd3-ac03-46c4-820b-f7988f3088f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bac28c61-4b74-4193-a109-f4456c44cf67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb1dfb9b-70aa-495e-a041-156a4fbb4fec",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd0cb50a-e769-48ed-8473-b25faa687e15",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "beacb4b7-e74c-45d8-b8df-60e1a2a50768",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c15e0f9b-39be-49ff-aff8-1800116358f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c24852f9-007d-455a-8cb5-0e2681c7a0a5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c35ccc97-39f5-4396-bbe1-2a6171f30d10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c37d754a-9f08-4f13-8d26-630d896c9371",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c474ff32-d65e-4d11-90a2-f9ad2e8ee772",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c50585c6-d1df-4eaa-b5bf-317678e7d3bb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5381f46-f707-4fcb-8f1e-605cee507946",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5d36e60-0945-4e35-9239-22f30c29025f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6633a62-08d6-4613-8f06-a3fcfd76f974",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6fcf873-e9c2-43c9-81ec-ba09bd063e13",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c87ce8ae-adb7-4007-8c0e-0090d0926e2e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8e6b9db-dbc9-4d49-a473-2c8593982b56",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8eeda2a-0260-4488-9acf-fddaee71e124",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c941ed50-01c0-472d-8122-3756b9b55a29",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c99efd04-1f14-49e6-bd60-208290d057a6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cae31f17-a52f-4ac3-97bb-6886500b19bf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "caf33f50-8517-4995-a849-4a70bbe202f6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd21938d-8cdf-4c18-a25a-73a2970c2deb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3167af-629a-4795-8c18-cf4f49e0a7d1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3be091-3d72-4512-ba1d-e8466285b930",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ceaa3043-fb10-4638-b942-85d7b5fc20ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cf03ef83-babf-4710-ab13-ace35476b474",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfb34052-097c-4637-b13e-86a2bc255163",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d302b7f9-1306-4a95-85d4-ff189df4b527",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d501bc94-2256-4ce7-b0bf-be4357ada814",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6003f61-89ae-4240-b53c-542ab36728ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d7a31657-3101-42e7-8b97-aa6ff61d3e84",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d99cdf9c-bda7-4807-b92e-34b3de2e6002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db5aeda4-2830-4ddd-a7ca-02363d58bf25",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db604d4c-9f40-48f5-b244-9b3bdcaf71c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db9ccc9b-5149-474b-a0b4-af8a13f01bc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc91cbb3-94e1-43fe-bf92-06077cf48d87",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc94da97-75b3-48b7-bfb6-d46984b5f106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd438551-3d93-45bc-982d-7c338b69983b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e0f91ecb-de8b-44fb-9a15-59c38d5093b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e35c267e-66ab-453d-ba33-a31c4ce7e5ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d54d6e-42fe-472b-b696-6642067802b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e9ca0d20-0315-4fca-b334-e6e046cd076e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea3367e6-6d1c-4e58-883a-b18d66f30f8b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea59937e-0296-4758-95ad-196fce18db72",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb3e277a-61f3-4f55-b179-d474841a80a3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed9ab94a-9354-48de-8695-43131a67bd2c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eec8a34e-e0ea-4a80-bd38-c7db22f84173",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef08937f-96ed-443c-80ac-1f7b764d10a1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef23ec60-f223-44c4-915e-196d6b011b94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efe2c4a0-7529-4f91-9026-696ea0a1f7b7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f03ff26b-30e9-4a60-b99a-780060db1e35",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f102b409-56b3-42b4-b70c-25192033ba8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f20906f6-cdbb-4f93-9ad0-87e63f0782ff",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f39485eb-f82b-495c-8b60-7dada21ee477",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f43faef4-2885-42c1-9035-ccc2667d7fca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f6edd915-a9e4-4713-8e0a-6f1d7efde18f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f7062df1-beb7-4814-a074-e9da66830639",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "faa28a13-3b08-4a67-834d-621e4dd3d287",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb0deebe-ca58-4eb6-ac5b-67442c846405",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc72a988-3078-4c69-a8ca-c0f1dc1ec996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fee54746-70cf-44dd-98df-5c09bb8959a8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffcc6812-deda-4b92-b2dd-0f59e0a46c44",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "3239f7e3-2a41-4479-aaa0-d55545fdca23", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(7507), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "11ebdd3a-f75a-4d85-9916-220874cf8af9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "152002fb-d980-4750-a70a-7b5d0bdac9e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "52a4cd9f-166a-481d-890c-05e50257655c", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_Id",
                table: "ProductSizes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_ProductId",
                table: "ProductSizes",
                column: "ProductId");
        }
    }
}
