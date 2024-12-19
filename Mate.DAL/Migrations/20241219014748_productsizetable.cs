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

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId" });

            migrationBuilder.InsertData(
                table: "FotoDesign",
                columns: new[] { "Id", "CreatedAt", "Name", "PhotoPath" },
                values: new object[,]
                {
                    { "0752146a-41f3-4328-93e1-bfdcf263842a", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2693), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" },
                    { "0adee95f-f2ef-42bf-b33e-50ffc3a36f5f", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2701), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "0c5dab5a-6ccf-4d07-95de-18ff83557459", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2668), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "153b12a7-82ef-47d7-9846-b9323774ef6f", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2714), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "5ccd4008-6646-443b-a90c-ac4b64245677", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2705), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" },
                    { "700871fc-0624-4745-a000-39862d1e2cdb", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2697), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "8fd35c4b-2a59-4104-b45e-ff732e67c471", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2662), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "afa2ee37-daf8-4b8e-a8cd-16df8c959b7f", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2677), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "b32a1327-37d1-48e9-bebd-7744a0cd7c0e", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2688), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "cd177bd8-f5f5-4e0c-ab7f-997f56576539", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2615), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "f35e30b1-871c-44f7-8d64-dc27b8d1e645", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2710), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "f818bb04-375a-413d-81fd-439e7ce93ce4", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(2672), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "03672d96-dfe1-48dc-9497-f3844b167f03", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5125), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "1c1e5ab6-dd4a-431d-9452-b937667e2922", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5133), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "2b61e3b0-f129-4a9b-bdc4-6791ad4b739b", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5182), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "2bd90bd6-bd81-4c3b-8cc5-87a2947b65b5", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5178), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "4b403dd4-e5c7-4a21-9bb2-9fa5d9b56782", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5121), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "4d9b0ada-32d4-454c-a9a8-b883cd46a064", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5058), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "5f463310-e7b7-4ed8-a83c-e375094415d2", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5165), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "6ee3c462-9044-4c80-8689-9975c2b662d2", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5136), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "730f0497-7ada-400b-b6c4-f5eaeca9540a", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5111), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "771c405e-3d89-498d-b2ad-19f12dc73ca1", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5141), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "8463a5fc-2463-4a14-9ecc-35f3e2f3fb18", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5145), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "b88e555e-f7e5-4bf1-a7f8-8c44203bb23f", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5103), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "bbaa0cac-eab7-43ab-bfe1-2cc301932825", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5129), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "c1d6d8c4-0af0-4b3d-ad9a-6e694d78f25e", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5174), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "c755a514-5822-4e03-9991-e5e7ae877c0f", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5091), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "c86a703c-693a-4849-bb81-08e72002d6cb", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5117), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "cc104b66-3f92-4bae-903e-889a79207d9e", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5161), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "d00f0b2f-79cc-4c57-b677-e284ed5121a3", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5087), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "d584b52f-e92f-43c0-a679-2206d5a8a004", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5095), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "d9747fef-3f72-432e-beec-fd04f5405348", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5100), "/databaseimg/galeri/galeriIMG_1958.jpg" },
                    { "db561cb2-1843-4640-bb25-0a75408af44e", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5170), "/databaseimg/galeri/galeriIMG-8454.jpg" },
                    { "e417e2d3-2534-4fe7-ab1e-277c235d9f92", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5185), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "f4362030-a76f-40d3-93f5-5fbfa9f834ee", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5107), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "f9e5af5a-9a73-451c-97fe-656716dcba7c", new DateTime(2024, 12, 19, 4, 47, 46, 235, DateTimeKind.Local).AddTicks(5082), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 241, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 241, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 241, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 241, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 241, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 241, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "2eb517aa-34dd-4750-996f-cfb6db3fde8c", new DateTime(2024, 12, 19, 4, 47, 46, 243, DateTimeKind.Local).AddTicks(4759), "Siparişiniz Tamamlandı" },
                    { "53311321-d11b-446a-85bd-46c69ef81e76", new DateTime(2024, 12, 19, 4, 47, 46, 243, DateTimeKind.Local).AddTicks(4725), "Siparişiniz Alındı" },
                    { "cc72a668-2fa2-4b35-b776-9a985a5fbfb4", new DateTime(2024, 12, 19, 4, 47, 46, 243, DateTimeKind.Local).AddTicks(4744), "Siparişiniz Hazırlanıyor" },
                    { "e3816187-23cf-4b02-b74d-53f0409daf67", new DateTime(2024, 12, 19, 4, 47, 46, 243, DateTimeKind.Local).AddTicks(4754), "Siparişiniz Kargoya verildi" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 243, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 243, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 243, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 243, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 243, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.InsertData(
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId", "Id", "SizeAmount", "SizeNumber" },
                values: new object[,]
                {
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4073dacd-7077-47b6-aa09-4d7c54490ec3", 6, 12 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "38dddca7-f0db-4059-a472-e898d961803b", 7, 14 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b6280182-751e-4aed-a7ae-4e13f7d6dd52", 4, 8 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8d54d7d6-5121-473a-b557-49b6d9335a4b", 5, 10 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "41430c3e-8b05-4c91-8f93-4ce41d7d45af", 6, 12 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5a61e93f-2157-4bb0-b6b5-d665c983a952", 7, 14 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "efdcd9b1-b86a-4749-ae36-7f2bdea98521", 4, 8 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4331f25f-76d8-44c0-864d-f0f439c6e855", 5, 10 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "164aa24a-376b-48a9-b5ab-17e2da66022a", 6, 12 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8d7c220c-0937-45fd-97be-f154b51e6b83", 7, 14 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bf9d3448-98c3-4d19-a0ef-b6288ad650a1", 4, 8 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e39eb71c-6b5d-402a-8a8f-d6ded1b62661", 5, 10 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c787389b-d5a3-4e72-8b20-72e1ae8dd783", 6, 12 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f2299fea-93f5-4e59-949f-0e29d7e6f9e9", 7, 14 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c38147d6-8d12-406d-9e40-ac36ba6fd3f5", 4, 8 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dc22dc0d-8809-4a74-985f-0ac4337e2257", 5, 10 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c09c5205-bba8-4144-ad35-e74f5960b411", 6, 12 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4e8f0a0a-1f3e-4d28-a919-888f0801413a", 7, 14 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a4a4ced8-eaa8-44e0-81bb-2c0dfd9a2c2a", 4, 8 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "25375eb0-e340-49e5-bd53-28c6833e474a", 5, 10 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8be79ce7-cc7a-40e0-9647-9ce68f825dc8", 6, 12 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "37d2f10a-fd9f-4f3c-a347-47166a5a704c", 7, 14 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "711e80a8-4cf9-43cf-abf9-a8dd4c46d1a4", 4, 8 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "97e63323-3ed9-4eb5-8a55-e5ec6fd4ca99", 5, 10 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e2a03292-4fa0-4433-9510-6db6d8785980", 6, 12 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "49232a4a-a280-4f09-b205-d81ebe9b0176", 7, 14 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "474dc291-74a2-41a6-813c-7fb98c4b384a", 4, 8 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "30aeb64b-5687-4ed1-9823-67666d528959", 5, 10 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "25457033-ab7f-469b-8cdb-aafbe0eca01e", 6, 12 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6fe1ec0b-fd20-4116-b990-f9729847edbe", 7, 14 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d3df2014-9ea4-4659-b9a9-109c2a1bdf76", 4, 8 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d05c6a51-082b-45a7-b949-f18b5876c211", 5, 10 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "20a071ca-f8fc-4c24-b72f-11a65b5bce3a", 6, 12 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "57a74bdb-f146-44da-a593-74d440a4aaaa", 7, 14 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "91050e50-40e0-4938-b87c-aa53806a5813", 4, 8 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5ad67145-01b3-4520-a0dc-b1e468187f7a", 5, 10 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e8379ff6-ee69-4b4a-bc8c-9c7ba79be690", 6, 12 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "968b39a8-c3a0-4148-ab22-b8aa2d5f354c", 7, 14 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c35184b1-1826-4beb-83ec-33c6ef8ca428", 4, 8 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "424000fd-dfb1-408e-9aea-99eccd6bf943", 5, 10 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "95fad45e-8341-416f-b5e9-da81dc444d68", 6, 12 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f7316043-7d81-4c69-bcf6-4bd790daf2f3", 7, 14 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7491d181-82eb-4eda-a388-046f1c90e462", 4, 8 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "52a17380-3a60-4130-a5b3-50e381627f6f", 5, 10 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2495e44b-646c-4dfa-8dc5-b95d5fd1bb27", 6, 12 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1926878d-8c93-4f45-aca8-71e12a63d5fb", 7, 14 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6ff06838-41d7-4e87-892b-9b41b1f218e1", 4, 8 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d06ab16d-1014-4f23-8958-8c4aea2eaffd", 5, 10 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "87f8c7e7-a5c4-4aa4-9cf2-07a94f30ada3", 6, 12 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "18c42a2a-f275-4324-bbbb-bc857f608e41", 7, 14 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8b44b024-e974-45b5-ab25-213fc6ad53f2", 4, 8 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4024d128-8e83-4eb4-895f-8a8dff92eaa0", 5, 10 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8c556315-98ee-41b7-9ff4-d8b494910884", 6, 12 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f2fd5c7c-853d-49a0-95b1-ce6d36c4a9ee", 7, 14 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cfb4a044-6eaf-4678-ad55-747efb43ddc6", 4, 8 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cc888274-7d2a-4123-be20-93e14c218a5c", 5, 10 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cd68fa53-7979-47ad-b245-09c35dad77ad", 6, 12 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "10709f27-c1f5-40df-82a0-06a25f036161", 7, 14 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "63b0b2f8-527f-49af-bd6d-573bebcb2d48", 4, 8 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4b58cac9-5f46-450a-9684-bc3329bf979d", 5, 10 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6e609757-e3a5-41b6-a7bb-6d4c7b160c16", 6, 12 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f851312d-8bcd-47de-973d-2eafda7a9577", 7, 14 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "115e12c8-8902-4ad4-b58c-da9dff335175", 4, 8 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "95aaf6ac-ce86-435b-88a3-2499547de831", 5, 10 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "808dac2e-3bd9-4482-bed1-695bc6842494", 6, 12 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e883d8ee-0da1-4ed3-985d-5ad657c11690", 7, 14 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8b796409-8360-4a6b-abb2-5b7a4ab65fdf", 4, 8 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "429fafbf-daeb-493b-8e01-bb7f1bcb2185", 5, 10 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "99bae348-5109-453c-b2f0-3280163e0710", 6, 12 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2712182a-7da4-4a30-be35-d09d9fd681d6", 7, 14 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f18a4b57-081c-4162-b910-c3e8984ecc81", 4, 8 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f88cee65-2270-4608-a1b4-b250c965f895", 5, 10 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "acc7c868-3901-4881-833f-cde390a55216", 6, 12 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a82c0160-fef5-4418-8046-1d139ad2d1aa", 7, 14 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "43638698-9745-434a-9e90-c11dfc2f5af9", 4, 8 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "34d3b1e5-f29d-44c6-b04e-9c838f132a44", 5, 10 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "880faad3-1f38-4fa3-bfca-40818aa14f44", 6, 12 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5fec602d-7435-4736-b572-65aeea6f0289", 7, 14 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dfe7bf67-5cf4-4e43-951c-234a4fe304a7", 4, 8 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bf93c48d-da13-4957-85f9-e2ef84b30122", 5, 10 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "edefbd02-5a3e-4d17-b439-2bcbcd6bd2f3", 6, 12 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0ca07125-d349-4217-aa63-9f0a09747ae0", 7, 14 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "58b83698-1f90-4ed5-a5f0-05aaa2a5886c", 4, 8 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4a69b8dd-1a14-4355-92b5-11eaddacfa93", 5, 10 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0f055a65-76c7-4662-ac84-76beb3190e16", 6, 12 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c2f2cc44-ceb3-4707-80af-56a8f907ea1e", 7, 14 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ce1264c2-395d-42b4-8235-d77acbd863d2", 4, 8 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f752841f-0611-4cc4-80cc-b036d091454a", 5, 10 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1409498a-531c-45b1-a604-e94257707d30", 6, 12 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "db0cfc79-89a1-4272-8d57-14e9e60ad0c2", 7, 14 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "afd6ccc1-dcef-436f-85d4-8770279506dd", 4, 8 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1d851dc9-d597-46a9-bccf-82e6bf24d0f8", 5, 10 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e56ff47b-7551-4804-a4dc-b4e60cc7147e", 6, 12 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ecd31487-87a8-4e33-ba6c-bb5014dfcab9", 7, 14 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0f228a1a-2953-4c64-970d-f6768d1332f0", 4, 8 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f24188ad-0f4e-463a-9bca-78efc768317a", 5, 10 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "48656e29-d904-43f8-99cf-3b9969a28919", 6, 12 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1575189f-0dac-40d6-8240-05a37c7d09a9", 7, 14 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "abf3aafa-ab7c-4afa-8faf-6962d39e7698", 4, 8 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3c2ba457-753c-456e-824e-af1b32195fa2", 5, 10 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c110d4b8-5fad-4bb4-9003-4d2fd78b32e9", 6, 12 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4a7e97d4-e7b3-47db-827d-f007fa2ce59d", 7, 14 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a3fa888d-a89a-43a9-9fee-e109918f4756", 4, 8 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "39b87ac0-734c-4d9f-b7a9-c013e31d0e66", 5, 10 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cf39f01f-c141-4ddc-948a-e8d66e2f8b92", 6, 12 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f1706a59-0bcd-41b7-a2fd-dfc6cfecbbc8", 7, 14 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8c028477-5f99-4a14-83f5-d06d2f059f82", 4, 8 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cb43e9da-4775-4669-8a31-f0d3832aaad9", 5, 10 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1c579bbe-7b8c-46a4-aacb-b0387f0d713e", 6, 12 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fd0806e4-2a19-40d0-9a21-3220f79e0771", 7, 14 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a6e79577-7b86-4c15-9202-24ed158719b1", 4, 8 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3acf604b-7ef5-4d44-ad31-0dbbec615182", 5, 10 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ca44c5b7-9f13-4edc-afdf-a2907cf2079e", 6, 12 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0106b31b-95a2-434a-aa40-d79a66e85494", 7, 14 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "baa28a07-482a-493f-a8d9-8c3b3cac9c67", 4, 8 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "29955217-e7dd-4d5a-8edd-021161ab47e4", 5, 10 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "06f51e72-7383-48ff-b713-d879060a8ee7", 6, 12 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e7a00881-2436-4f3f-abcc-580ed5a3f631", 7, 14 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "01e54ffa-3d51-4671-8564-7f9394d903a7", 4, 8 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c97fad52-6fa0-47e7-8ec0-fa7b8e459a07", 5, 10 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0ba7e8c4-59ff-43b3-8049-0adf50e6d989", 6, 12 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "60531aba-e8f1-4d05-b56b-85d39e3bf796", 7, 14 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "23342634-1228-4626-a36a-3992e963474e", 4, 8 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1b40e7a8-1874-4298-a893-7b94aff90c66", 5, 10 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "81019fa9-3e9c-418f-8962-72b654f746a2", 6, 12 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "36825ec3-3c28-4ae1-8191-abb370f88c5a", 7, 14 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6df1732f-4e71-4c7e-8b7c-2722f07ceb3d", 4, 8 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "569fa7ab-e9c7-48c4-b3f3-521ed3463ade", 5, 10 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6f12c0fe-0dd7-432d-b9ff-f89c3dcbd4b7", 6, 12 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8e4acd85-2015-4632-9138-662f3a9d062e", 7, 14 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "81728abd-02eb-4068-835e-f3b5b729b9b5", 4, 8 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b47f9836-c05e-483f-96c1-5dd9cb2e0025", 5, 10 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3d2769da-e747-4e08-90fd-d923440bac5e", 6, 12 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6e92e586-a6dd-41fe-87e6-f7bb3d57278e", 7, 14 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9fd986b5-6455-4682-aee0-6395e96f95d8", 4, 8 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4b15837b-2f87-48ab-8519-2d59073e7590", 5, 10 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8f653542-200a-47c8-943d-10cb9eccd3bd", 6, 12 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e882ebbf-7f63-4fc7-8a67-d01da50f81d6", 7, 14 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cc9da0bd-1fe0-4d87-8806-df518a3ff57c", 4, 8 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "723654df-7628-40d2-a111-8a7102de9c5c", 5, 10 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "045cb20e-af47-4d8e-ae57-cf20a6799316", 6, 12 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8553c7a4-3dc5-4d73-9bae-982c05fb28ea", 7, 14 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b3265db4-be48-4788-8b64-75675dcae307", 4, 8 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d1ac028e-66f5-4e0c-82ae-f17b9be23de1", 5, 10 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5ffa33ab-d700-4818-ace7-6c0ede41420e", 6, 12 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c7e54583-1740-4177-98cd-b63c5fa9ae4b", 7, 14 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b291eddd-9fc5-4f65-9f6b-38fb68f87f7e", 4, 8 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b6a8091f-778c-405b-8f48-745c1f6310e9", 5, 10 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "114578a9-b0c6-40da-9d4e-27f4134b692e", 6, 12 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4b4a7adb-9504-4473-a6d4-4bfa8c7850db", 7, 14 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "87e7f3db-7d84-44ad-a9d2-7122092a38b8", 4, 8 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "53e4b965-689c-4e9c-9fbf-093c61db5347", 5, 10 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "04b77d4a-a915-4f2c-bd79-0b1955dbb239", 6, 12 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f2a88218-61fb-488a-bd86-7f292eff84de", 7, 14 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cc057533-8cf3-4b45-9d5e-61462eca35fb", 4, 8 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "473df67a-8c0f-4254-a44c-824c394b046d", 5, 10 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "099991d7-5eb1-4887-af35-15024baf1369", 6, 12 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4e016723-cec9-4f34-8979-7cfbc3b581d0", 7, 14 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "918f6177-1d6b-425e-bb67-a4a52d014f85", 4, 8 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "088d3e12-c604-4ccf-a6f0-deedf9b93fac", 5, 10 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "856a5ee8-a8c2-47a4-884d-cc22e3842897", 6, 12 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c78861d0-66f2-4a65-abd7-adb87044855d", 7, 14 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7330af00-628a-448a-8a21-c00f4d602fb6", 4, 8 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0eda2e8e-70a0-4915-85fd-9e30ede92495", 5, 10 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "efab0476-c2b8-4440-8eb2-a6f56e8042d7", 6, 12 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9803502f-9312-4a6e-b55a-f17aa9888703", 7, 14 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6fbed768-30a9-4fa7-8db6-6b7cc4a3dcec", 4, 8 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5dca9742-cbc1-4a42-a8d8-05aacbfd7546", 5, 10 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e93c5901-64fd-4e31-9708-1f80e15f6683", 6, 12 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ebf64511-f056-4cbb-b052-5033cabb1d8a", 7, 14 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2f924953-7048-4e23-b302-e7fb86caddda", 4, 8 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "97442264-b952-497f-afd4-33de4fd38949", 5, 10 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6ecdcfe0-8c64-48cd-a04e-2e37471f0969", 6, 12 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "911158ce-12f8-489b-96a5-0d5fb2836761", 7, 14 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "acddc835-601d-47c7-893b-a7ee95b6da1e", 4, 8 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d2480bcf-b604-4197-95ea-f63715cd2777", 5, 10 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b0138b5b-1c39-43dc-bcc6-e7f243e2b0d9", 6, 12 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6f10241d-226f-4cbe-94b5-0b40f3d5fa1e", 7, 14 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e2378234-e4a1-41f2-a852-a70b7dc39ae4", 4, 8 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "62b78d7b-dc43-4335-a07a-64c5d8dc1306", 5, 10 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "046fbc6e-06a6-4402-84be-138ffd3b5414", 6, 12 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8a5b9ba0-bdb6-416f-9d52-ee6cb4e4d796", 7, 14 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "71387bc7-7622-43ca-9c77-d52addf60902", 4, 8 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1c9bf870-df74-4890-a870-78c77958bbc5", 5, 10 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "22e9e2c8-f1ac-400e-8d19-3aa8b4dfeef5", 6, 12 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dadb2248-5c84-4c30-82b7-a48977082496", 7, 14 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cbd8e7a7-d681-4402-b03e-28b2f1a6c4b3", 4, 8 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1773ab0e-6abd-445f-825f-5e8f32429617", 5, 10 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f1e8426f-7591-45c2-9e6b-eb687ef02e28", 6, 12 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1e7ecdb7-8aeb-481e-8d3e-7ff7092f37a3", 7, 14 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "447b4edf-a0e4-4d98-9676-e48e10d3f69b", 4, 8 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "75d602b8-6aa5-4d8d-a295-afa25ab1fb32", 5, 10 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "01781b01-a35c-4890-961c-76db87f35e58", 6, 12 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "270a1101-2201-41d1-8f70-77ce1add9712", 7, 14 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d993a7fd-6417-429f-a9e9-b62722dc90ec", 4, 8 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4a9e4e9f-745c-4a40-908a-4e01c8c48df2", 5, 10 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "442db6d0-b254-4daf-be40-0f97eab0ca06", 6, 12 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "92fc3330-a24a-46a1-8a6d-d8509d9318a3", 7, 14 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d9bae359-846d-4344-9d2e-7359366b9ec9", 4, 8 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1230d8d3-a2c9-4822-b2f6-95fa5167aa7c", 5, 10 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1094ceb3-7132-4ba7-912d-ce241f0b28a3", 6, 12 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2c045c80-6679-4682-a22f-3141937932ad", 7, 14 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "73726b05-eab5-421e-a538-ff7122803374", 4, 8 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fd628816-f1a5-4017-a006-639b85ebe9d1", 5, 10 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "af21ab29-ba39-47ad-b8fd-9413bd354d4a", 6, 12 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "83ae56a5-daa6-439f-b5b2-78782bbf27b8", 7, 14 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bd31d33a-46db-4d91-b3c5-7c1f3c6eb2a8", 4, 8 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ca9d8980-8fc6-4f2d-b82e-a3137f073ffc", 5, 10 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0ba66810-e097-4163-a708-29e7f1df8a68", 6, 12 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "30bcc19d-ec80-44fc-b6e7-d4bf2914ed53", 7, 14 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a567afdb-7016-4230-922e-8b06c0e7e77e", 4, 8 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b811d0bc-2b27-4aa0-987e-27b4e3fbf5a4", 5, 10 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3f69f4ce-3167-4917-b40a-3f182f42b474", 6, 12 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "88918f31-d700-4d9f-a36e-f07be1dbe3b7", 7, 14 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8b267343-7d20-44f2-b870-bd43c298e875", 4, 8 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "85e19133-b512-4d6f-a26d-15e03bfb0228", 5, 10 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1da5a41e-9d8e-4a09-9798-ef1c17314466", 6, 12 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "db012e85-ebd6-4f0b-b7cc-f046a7b76b8a", 7, 14 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "abf1c1c8-bb8f-4105-a739-ed07d421b8fb", 4, 8 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e867015d-68a7-416b-a1fa-04de4319837e", 5, 10 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ff3a7c03-ba47-447e-8802-3bf601eb2511", 6, 12 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7755aea0-01bc-4ea9-b3de-dafcc9f116cd", 7, 14 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fe201ee7-160d-4390-983c-c2dedc2475e0", 4, 8 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8f332122-8f6a-47bf-9445-fdee09d6517f", 5, 10 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5387f33e-753e-4ffe-b344-3e251feca3b3", 6, 12 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e5dcae79-ebb1-4793-b6b1-28cd994a693b", 7, 14 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c992367b-59f1-4230-8f13-6d82d295f4ba", 4, 8 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "75f06125-68ec-46fc-9e05-f79041e51364", 5, 10 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "129ce54c-f77b-4619-995a-48c587e50844", 6, 12 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b71674f7-5035-497a-bb2b-6d3efd4c4bd3", 7, 14 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f8b253e9-a789-4c76-a04c-192e388d5e9b", 4, 8 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fdf64578-7e6e-4488-bc0e-ab420062ecea", 5, 10 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "66a03309-3cc7-4fd3-b63a-758f27142a6b", 6, 12 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c66d2609-bae4-415d-b642-f5b725587027", 7, 14 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0358eb5f-2a00-4894-bb6f-5672ca846555", 4, 8 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d96e34ce-648b-421f-9443-ed95666eaf6a", 5, 10 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "24814d3e-1f64-416b-ba53-4c1801849421", 6, 12 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "253ad642-9a35-4afc-aab1-d92cc5ca1fc2", 7, 14 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ac0f4969-0d04-4310-bc3c-c078634678ee", 4, 8 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "19764048-96e7-48bc-8f70-04d096d6f1cc", 5, 10 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "efecf091-e417-4462-acb9-06cb4ccf6bd3", 6, 12 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "170211bc-ff20-4878-a7ae-5bb9f876fcea", 7, 14 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ef258c63-b692-4422-9853-1284a7035c3c", 4, 8 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "889bf1e9-94aa-4531-b541-5036b37095da", 5, 10 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d58a781a-01bf-4bd8-803e-4cc2e7d06a18", 6, 12 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "790cc284-cbe4-4a34-9ba1-1ec111f4f217", 7, 14 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "05ec2806-ef28-44f7-ab71-645843b4e5bb", 4, 8 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "21d07c84-0253-43ec-95a5-00611fea0418", 5, 10 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "40b03ed0-3974-4c19-83f5-af35d5c310e3", 6, 12 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f42481f9-77d3-49e3-96c8-029df9ddbf45", 7, 14 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2f84f868-62f6-4001-bf7d-061189495a6f", 4, 8 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b16e2574-fe0b-4eb5-a865-f43246c9c4fd", 5, 10 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a5685765-8725-4589-90e0-ce4fa8c7c366", 6, 12 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "43cc3418-43c5-4331-96df-b873cfdb9210", 7, 14 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8d6a91ca-c1f6-4c25-959b-130adeec6e20", 4, 8 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2b285b3c-4189-4338-9a66-85e70e1b0488", 5, 10 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c4f7f5ac-9102-4648-a5b7-6282e4d377a5", 6, 12 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7fe42eaf-4fca-4842-b03d-8c733a13cae3", 7, 14 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "629f4502-61a2-410c-8bb4-cc36f0b54a88", 4, 8 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "607f4782-674e-4f92-8c33-38959740ff3c", 5, 10 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5f7831c4-6c16-488d-837e-cd9c41194cb4", 6, 12 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "61fea64d-b801-47b5-8843-6a2746bc7871", 7, 14 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "afb68a63-4a74-4967-b203-4be6e421f50d", 4, 8 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7aa46edd-26d2-43e8-ad2b-3960d8877a61", 5, 10 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "00378816-721c-4ee2-bba6-0ab48ae50d12", 6, 12 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ef4d728f-8f13-4877-b58b-e88f0d0fd82c", 7, 14 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e1287db9-473a-41b2-99b6-9522befcb5b6", 4, 8 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "15f466d8-17e4-4cf7-8e05-094f39a3e4a3", 5, 10 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9be4bb5a-f276-4eca-a02b-e57d80c5131d", 6, 12 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bedc1190-5968-4cd6-91bc-ca7cbc8e9cc5", 7, 14 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7104650b-4c12-4469-95c8-ff81a8217e03", 4, 8 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c81e7c06-0ddb-4cc4-983e-769a5776fc60", 5, 10 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f8ec0701-5efd-40e4-b42d-a2d30b6153bb", 6, 12 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "31a28964-2c7d-4182-ba9a-833a14126c64", 7, 14 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c1fcf8f3-18a6-4080-a99a-92c861d261d1", 4, 8 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2279f4bf-18d1-407a-8a16-b25910645d2e", 5, 10 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "63f55f4a-4877-46ad-bb20-af2e4ba60997", 6, 12 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1e15106e-c24e-4873-8570-dfa2a3cdf52b", 7, 14 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8bf71d98-540b-4cc6-a44d-c6ecba561133", 4, 8 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0fb2b99a-df9b-4a99-97a7-7a2313cac944", 5, 10 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2665f5ff-7303-4df4-9b37-3b43153841ee", 6, 12 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c49ec7a4-2a5c-47eb-adea-c9dd002cf395", 7, 14 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f07f1635-d111-4b1e-98ca-211cd3962cdb", 4, 8 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6d99067a-5a3f-4c52-8669-e74b41e290d3", 5, 10 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1047bdad-2248-40f1-bd2e-e40b2d4339d6", 6, 12 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e45ac313-5654-416b-84b2-4ca44af5fd4f", 7, 14 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f5a1278f-19b1-47d3-9a19-42b51bb2cdd8", 4, 8 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4fd05042-756d-4663-8757-c9e48f53001a", 5, 10 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "82e17d2a-ff4c-46d3-82c6-ad5fab946e69", 6, 12 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a00a8211-0435-49fd-9320-b137d78e4c0a", 7, 14 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "29c89037-3373-4318-9f83-23a34d837677", 4, 8 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c41f6843-67a1-4389-a97d-aba7cb604dee", 5, 10 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "548b45f5-b334-46ee-b2c3-fac577693ae4", 6, 12 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1c1a581c-23e1-4d7c-bc2c-c0e9c32ecba7", 7, 14 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2fa37466-2ba1-470b-b2e3-9d3f078d2e5e", 4, 8 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b709bf28-24d1-4b5a-8560-000df057d958", 5, 10 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0903140f-048e-42ea-93e9-278ab0d1d9cb", 6, 12 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d22e21bd-ffe2-49b3-bb0c-a27519848e0b", 7, 14 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2ed66981-793b-4cdc-af19-a39c8eb1a165", 4, 8 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d78d388b-4d08-418d-a8b5-b2bb8dbe487a", 5, 10 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "42c596d4-6f2e-4fba-a058-6a2b82fb4440", 6, 12 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "923152e0-47e5-4bfc-93d0-ba3d1d33269b", 7, 14 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8dee60b6-1489-429d-bc96-3c24ea38c685", 4, 8 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2ee7f7dc-b94a-4118-a69f-205d3ef47a65", 5, 10 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eec9a7bc-77b1-4192-b8d0-444008d41929", 6, 12 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9c42626a-8184-4bac-b3c0-3665bd56b482", 7, 14 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1d999f0a-2ab8-4d55-8aa7-920f052f7dc3", 4, 8 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a318a5d8-c4d2-44c3-84da-6c13e8f1ee10", 5, 10 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1b5a57d8-bb6a-4880-a9f0-b4abf7297f83", 6, 12 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6d39a4a5-8c71-4ee7-9a9c-69d6f3675261", 7, 14 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b4f08e89-ad40-4570-945e-11f96499df20", 4, 8 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "61c96b4b-991e-45ee-827d-763f39d9039c", 5, 10 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d5e2e83b-b39d-4d90-a56a-db58d7272a8f", 6, 12 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2318d39c-fcf6-4819-8c0a-b4f6561b7f08", 7, 14 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1e26828b-e015-4a67-b941-0600e1bd80ad", 4, 8 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "30a8b567-4123-4872-859e-40e23bd709f5", 5, 10 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "52a9f825-f555-4391-b2da-53ae2181eb66", 6, 12 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "81a532dc-1c3c-4f07-b60a-583d2584638f", 7, 14 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b5ce1a27-cc62-4f13-aa90-303086f1016e", 4, 8 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d1a6d425-c306-4a24-9ce2-a2c4ad0b4776", 5, 10 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cd0c4af1-0ea8-4d4c-8c69-da39e8d1c504", 6, 12 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a38503a3-080b-4de3-8526-0cdf9ddcced9", 7, 14 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "98cc9fa5-dec2-43fb-a4cc-a5c8477ed973", 4, 8 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bc0119ed-5e91-4e43-a0d3-e74b5251b9e2", 5, 10 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "80f67413-ecd7-4f6d-adfb-1e06489212bc", 6, 12 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2146c7a0-b9f5-489f-b549-5d13127efe87", 7, 14 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "40add54b-ed38-403c-875b-c4598b290435", 4, 8 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5359fccb-5c36-4bf2-85b0-534253813f34", 5, 10 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a67d0626-3e80-4136-ba6b-1392fe2b6cdc", 6, 12 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "af694501-a2c4-434d-96c9-36b0a046fc03", 7, 14 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "72f0be92-da75-417c-a75a-13bdd192bae5", 4, 8 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "95357cd1-1bdf-4968-8591-f5ee4fa59171", 5, 10 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f956f9c2-f9c9-4698-a001-d4fd450285d7", 6, 12 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dfb72b6b-468e-4cad-b871-9a1eeab06870", 7, 14 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "838ea474-49b3-468d-9f1b-d3d868be0613", 4, 8 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3ab0c9b2-2313-47f9-aabe-85a1969330fe", 5, 10 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2a47ceca-9f76-413b-8e1b-8e16516e3e36", 6, 12 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "02467187-ba78-4d73-82a4-a4463978ff27", 7, 14 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9aed686b-bfe5-49c6-abd3-d19ca4a4f17a", 4, 8 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2d065e7c-57ca-4742-ad12-89a01dbbc9e5", 5, 10 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fd7300ec-3bf5-4be5-a866-1fb53933a94e", 6, 12 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "58ba00d5-3575-4916-94b5-91434975474f", 7, 14 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2f69096b-c411-4a2d-9abd-64cf29ea196f", 4, 8 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d7fa213b-91b2-4c3c-bc90-474c5a8c3bdf", 5, 10 },
                    { "56072689-4550-44be-987e-b08667758de4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "50d58dc3-e1d7-46b2-bf19-682f8e1aec87", 6, 12 },
                    { "56072689-4550-44be-987e-b08667758de4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9a3c05b4-1c5d-4f38-8cac-d45c3343c7d7", 7, 14 },
                    { "56072689-4550-44be-987e-b08667758de4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bd5cbcf7-bf76-4476-814e-5aac894706cc", 4, 8 },
                    { "56072689-4550-44be-987e-b08667758de4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3961e38b-e1c4-4140-bdef-b4e897cf12bf", 5, 10 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a7cccf3c-0db8-43c4-956f-7a42fd4b441c", 6, 12 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "04186f24-3469-4304-acb7-bd827fc4a3e3", 7, 14 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bfd04a9c-3454-42f7-82e1-af76f5c1392b", 4, 8 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1e9c433c-5873-4676-a7ef-9ec2eaa3c2a9", 5, 10 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "77949076-31dc-4df7-8010-92b744b823ce", 6, 12 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f7ebb224-0a43-4320-ab95-c3810c12fbdf", 7, 14 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "774d7ab6-f498-4263-9ddb-1b58ce3837cf", 4, 8 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7cd04b3d-d85b-4a6b-be49-c9ffdb8dc905", 5, 10 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3eb1d2ef-bcf6-458b-b2a2-57dc5e6a57e4", 6, 12 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7ca083fd-0731-4905-8c64-e01d5b0319f7", 7, 14 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "48dbea0b-eba9-4b68-a6b7-d8ed06ccfd44", 4, 8 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b717ee58-1a3b-4dea-9fa3-944567e0b6aa", 5, 10 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a99a480b-8fa4-4069-a454-78bb341b5674", 6, 12 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8f44ca0a-8d97-482d-a69e-d3cff51d483c", 7, 14 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "62242476-7761-454f-ba67-5dd38f218755", 4, 8 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "401fc267-833d-49d9-9ba8-f7011b36fde7", 5, 10 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fe1091e9-dbbf-47db-b25b-2a107be4494a", 6, 12 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "64f4c979-8ce9-454a-ad1b-2a2271da4613", 7, 14 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "427f2d36-63af-460b-a9df-af9d0908d2b8", 4, 8 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d37c32a5-37b8-438a-8a42-fe3d25607c45", 5, 10 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cc9f6084-ddc8-45cb-9e47-b6180bac4234", 6, 12 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3ca11f76-b812-4a90-a54d-cb10e0847702", 7, 14 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "83fcb011-052b-4f8e-ae5d-9fc9fd8051d0", 4, 8 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "06790561-519b-4505-bc9d-8c0ef1545426", 5, 10 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "59a82427-c393-4365-813b-91c751ab3b09", 6, 12 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f495dc0a-56f1-4432-94ac-4df93962b388", 7, 14 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d0262e62-07ca-4c97-ad0b-bdfa3ddb1666", 4, 8 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bf96b543-513b-4591-9b9d-d91b628b18f1", 5, 10 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5e3835a0-7c26-4bee-8f7b-c213aea08729", 6, 12 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "84722e3d-dc91-4f3d-84c2-5f73c1b70b78", 7, 14 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cf8d2d7b-6de2-464b-8636-a53ab2fdedcf", 4, 8 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f16e3c08-a57a-4fc0-8404-0939fbfb3d1d", 5, 10 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1adb5233-3acf-4ff4-9f6d-e04c2ab8c0a7", 6, 12 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8ec8cb7f-9dde-4a09-ae6b-605b18805444", 7, 14 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "adca2e76-abc3-4041-807b-7a3a44eaea2b", 4, 8 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3bc7b62f-7adf-491e-afd4-bb1adf2df3a3", 5, 10 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a9a349be-f24f-4254-b700-3c0c3919ae35", 6, 12 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "09d36343-0bfb-4b11-abb9-a14ab62a4bad", 7, 14 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cbd11c7b-81e5-49b8-b360-15907cae6f83", 4, 8 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f3910066-e213-4659-a22d-cef332a29b42", 5, 10 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6b63f5e4-43c0-4935-a5a5-6c26b723c03b", 6, 12 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5faad122-a8bb-44b8-801b-46972aeece44", 7, 14 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "500cd84c-8566-49d9-8bf6-0b6d5628676e", 4, 8 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e51817be-bd1a-42e3-86c8-26daeee8430a", 5, 10 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "521aa252-0b58-4f2e-974b-f29a60dbe2ed", 6, 12 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b417f40b-049b-4017-bff1-d554811a3280", 7, 14 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3b47da7d-fc07-42c4-a8cc-d8930b96bfe3", 4, 8 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ab6e7313-47d3-49b4-ad46-cc6f3205a446", 5, 10 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9ae08d2e-c0ba-4b65-a994-08ccaa03911d", 6, 12 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2aae4fd0-9d94-4447-a357-ee4d0ceaa566", 7, 14 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8ff7a81d-1c4a-4f1a-8f18-a39fd7b0b2b2", 4, 8 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "77fa6f24-3f81-4c29-9d6a-7eaca6ba9301", 5, 10 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c75aaf9b-d172-491f-a3a0-93040515b40b", 6, 12 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ae94adf4-4dea-4ede-b6ce-5adc8e43a2a6", 7, 14 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e42bea37-cc55-42db-8908-625c0ab8fea9", 4, 8 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7e195379-7014-4c7b-88f4-501f3c06bcf6", 5, 10 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "df94c856-06e1-4224-a70e-c74f3e63a21a", 6, 12 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9f6519ab-d433-4ee9-b8f0-5e50d0c769ec", 7, 14 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9e2e52eb-bd47-4dfb-8faa-fca931721244", 4, 8 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1d7e8e07-3bd6-43c7-856d-0bd8b1acc920", 5, 10 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dbe123ab-e8ad-43eb-884a-fdba2cf722bf", 6, 12 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "eeb0d8b8-b7ad-455f-8c7f-53c434a7d583", 7, 14 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bb49d2e8-0a9d-426a-807f-e5beb0efa4df", 4, 8 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8b72b19f-89d5-41f4-95ce-fd216b23ecee", 5, 10 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ff7b9afe-09df-4737-b0ae-b1085bbe22e4", 6, 12 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e87884ff-15e7-422d-8eb9-801c154245f0", 7, 14 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f297312b-fde7-47e8-ae10-0156d75104f7", 4, 8 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aeb00eaf-d185-4444-b2a8-80b9ca9b3aa4", 5, 10 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0600ebeb-d6a6-4bb5-a1b5-28bdb6366d59", 6, 12 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6f66457f-8e33-42a1-a526-13f2680717e8", 7, 14 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9ba73fda-7eca-4e9b-a9d8-441e8de41696", 4, 8 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e7ed9152-5858-4db4-a26c-da227decb2b3", 5, 10 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a650425b-e30a-4b19-94cb-6a1d28a9784c", 6, 12 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8e0b3bdc-e882-4631-b818-302e62b8ede6", 7, 14 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9e9f8f49-5350-4330-af8f-2a48bc3742d2", 4, 8 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4f68dff7-99a7-4e03-8c88-e3c9298a00cb", 5, 10 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f4e702a1-f3f4-48c1-9197-3f635b0068cf", 6, 12 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e12530b5-d7ed-4d45-ae4d-c1ed12899bb2", 7, 14 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "664e56f1-295f-4ff8-a5c2-f403ac461ea2", 4, 8 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ce245049-be06-47dc-9b36-8bb572c6790b", 5, 10 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9cc96385-b7b5-4b90-b34e-7fe9ea851ff2", 6, 12 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8efa8f12-2cf6-431d-b26c-1b76a2988347", 7, 14 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2ca2936a-3fbd-4bb7-9f2d-8c8abab89055", 4, 8 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a674ae78-5bf2-4f52-a02a-2266648359db", 5, 10 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3276d57a-c566-489f-8559-45de20481f15", 6, 12 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2611fc40-ac30-405d-9459-61de45fa2169", 7, 14 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "443dbaa8-86d5-4808-b432-286d26c71305", 4, 8 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ce66da6b-1ecc-4d5b-bce7-0ea0025dd667", 5, 10 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fb061136-cf46-4d8f-b4b8-69f01ea6a077", 6, 12 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a3f3591d-82db-4cce-9461-02027254a104", 7, 14 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7051e44f-de46-4426-82ac-045e79c34d66", 4, 8 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9be849eb-c38e-4ca0-940d-9f2ea44320f8", 5, 10 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "721430fb-03ce-4a92-a44f-fcb38d9e7669", 6, 12 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "705fd2fa-35f7-47b0-8b2b-9756a5264db6", 7, 14 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c7daab5b-e5df-48bf-9a96-52fcc407ca06", 4, 8 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4716bdfe-1f5d-433c-ba02-12f608698bb8", 5, 10 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f27d6b93-3f96-4fdf-8ee9-fb00ba00de5b", 6, 12 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "72c62b9e-b029-45e1-afc9-2ce6802dfe91", 7, 14 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3673de8a-e438-47bc-a997-8e75cec3d8bb", 4, 8 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "64775499-3b9c-470e-a121-823cdfde3670", 5, 10 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "32150bfb-3265-4f90-a18e-750dc94102fd", 6, 12 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f6ca2ab8-68ff-4c40-a904-89a39ad7d03c", 7, 14 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dff6ba80-e52a-445d-b81c-fc71fc6556c0", 4, 8 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cf9375e4-54e4-45fa-b27c-3af85dd4bb1b", 5, 10 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5d530dd7-1beb-42fe-b800-4573964d0856", 6, 12 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b6cb4986-7275-4952-aca3-a13e936542bf", 7, 14 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b3a89b7b-7212-4fbe-b5f5-6ce4b3cd1129", 4, 8 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5c575629-8b20-471e-a071-7c14ddc4bf4a", 5, 10 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f503e279-2f22-4837-a9fb-b69cce272440", 6, 12 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "39a591ae-1575-4030-b9ce-11237f8dd6d7", 7, 14 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "75ffe398-82c0-466f-b735-28ffc9c567a4", 4, 8 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6068fa36-01e4-4015-8f16-664a2762f2a0", 5, 10 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "84fef856-61d1-4939-90ef-f7af98ec94f3", 6, 12 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "92257e72-e9a3-4bdc-8484-9500a3904f9c", 7, 14 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9da662c7-7046-47d9-a810-082c1707e48c", 4, 8 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "24a3fad7-364d-4d72-b5cb-b7d03cfa9baa", 5, 10 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d6964f98-59d7-4e0d-933f-1f8d5112e3b9", 6, 12 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "56e7a73a-5498-49bc-becf-7f5b25852b44", 7, 14 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a96804a4-c0f9-44ca-96c7-fb87c73034a4", 4, 8 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "48e22c2f-fd86-4640-be92-1339fdfa20fd", 5, 10 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1844b51e-3962-4760-a1e8-17db8257aef1", 6, 12 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d5defe9f-bff6-4720-a803-b517f1b6aae0", 7, 14 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "df63eb12-5d2c-4af6-9ff5-8ae5143699be", 4, 8 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b4e5934f-f1e3-4f71-a9d3-25ee06ba03c4", 5, 10 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f61f9828-a847-423c-9ca4-73b7fd61db71", 6, 12 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d74b48ae-d13b-4d32-823c-4da5cc2a3efe", 7, 14 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e8843f2f-8f25-4586-9998-8d362048e83c", 4, 8 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3c82b52b-6882-4f2d-91b6-f6fca504bc2e", 5, 10 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "19c7f3d1-bc77-431a-a463-a87c28f7ec00", 6, 12 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "534e3e86-af87-4775-a204-298fd554000c", 7, 14 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ff314cb5-f88d-4d8d-865c-0dc96698a5f0", 4, 8 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cf98acf7-bf8c-4bbe-84d9-c9f2f691ecab", 5, 10 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1198a47a-ecf1-4b67-a6e0-0808923ac733", 6, 12 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6df293a5-1e4a-4c90-8d69-a11e23876a1a", 7, 14 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7dad3c11-81f2-4ab0-afd9-312b4cfbc765", 4, 8 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "054ee1d1-f3ea-44aa-8657-b2b85d4de3ac", 5, 10 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b409f0c0-a3ef-4c42-b704-ab51ee886ae2", 6, 12 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "653844c2-dfae-43ed-8359-05017860defe", 7, 14 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ef0cc8c9-628d-402f-8bed-eb4d4b236f8b", 4, 8 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b83cc4bd-454e-4782-8960-e2f34c930d47", 5, 10 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "73ef9ddc-9090-471b-aa5f-713a2d93a31f", 6, 12 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c1810c1f-52ea-4aa3-9173-c50692d9299b", 7, 14 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1a9c47e2-eef3-40bf-82e2-b2b9840f399e", 4, 8 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ad74de7e-5fc0-4c12-8b2f-06cdc6607823", 5, 10 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b5c35c78-e5ed-4624-91d0-0a399cc04fba", 6, 12 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "07f6d60c-7558-48fc-9e94-df5ca5db9e40", 7, 14 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "12750722-3254-440a-83ad-7196a1525768", 4, 8 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "27273aaa-31ab-4610-8bb2-232bf6586191", 5, 10 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7637777c-202a-4d14-90d7-527c02b89dde", 6, 12 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e574b4f7-809d-4d6a-a11b-42048c6ce845", 7, 14 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f2c57e72-c7af-41c1-90bf-c5f81ced6549", 4, 8 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aa746583-18ac-4ada-86f6-6ff6af70193a", 5, 10 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "998ff3d3-c982-428e-a3a7-ae4fc378953c", 6, 12 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e4bd8b4e-162c-43fd-9f36-9c438cd226cd", 7, 14 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "25292fc2-8f94-4f98-8ea3-ff7d4a5b0ba8", 4, 8 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d1a2571b-aa9a-4908-ad56-74577209f9b9", 5, 10 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0d625375-4439-45b9-aa0e-6b987b56496d", 6, 12 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d1c724db-9733-4ce4-9ba4-72e30bc0cfa5", 7, 14 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "58fbbe61-ae8e-43d7-90e9-9edb6aa9596d", 4, 8 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "55ec8802-8cbc-444f-b33a-9f2d86724db4", 5, 10 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f6ae2250-2dee-43aa-a98e-5dd135658b97", 6, 12 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0e46f568-0c74-4e6a-9ca8-00ae40052bd4", 7, 14 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "78d592cd-1d0a-468a-a88f-4c2ad2ac43a6", 4, 8 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3847b362-670a-4791-822c-489e4d194a3d", 5, 10 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "583cf30f-d140-41de-a468-544aef9e52d5", 6, 12 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "55473ba5-3ca4-43cd-a517-dbe09e2ec16d", 7, 14 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f27dcad7-da65-4e4f-83e0-3f60c783c7fc", 4, 8 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "76fcf80f-5d62-4bfc-87b7-b215df13fb69", 5, 10 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "840f746c-3fef-42ab-88da-1f7a7b9a9293", 6, 12 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "89379b5a-3fa8-48a2-b8e6-5728852abb7b", 7, 14 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6dd33224-278f-485e-be76-1ae8f24d2fdf", 4, 8 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "57e461cf-ab28-4cae-88e3-fc2f0aaa9803", 5, 10 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "194b71d7-f482-4f90-848a-7122ba9db39a", 6, 12 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e9c68697-769a-478f-9eef-5bed06feec9e", 7, 14 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cf60906b-ed2e-4fa8-9940-7f1e218c815e", 4, 8 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "722679b8-3fa1-420b-baf9-74a4cd463748", 5, 10 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "854a61a5-5d57-4c81-94bb-5563e3ef5876", 6, 12 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6e6fa34a-3cb8-42b3-87aa-2b8bebd4c2bb", 7, 14 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "19d7d29b-7527-494a-ad96-38cfe741ef95", 4, 8 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "29a2ac02-9dbe-4217-94ed-dd571c1b931a", 5, 10 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a00e18b8-e3e2-4675-b7f8-401e6c833e12", 6, 12 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dffff7f4-165e-40d1-bcd0-32a868881467", 7, 14 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "194e6892-5550-43d5-a7fd-3ff891c73ae8", 4, 8 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8d8ae1d0-898c-4c3f-8024-4ad2781bbb92", 5, 10 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "78b21249-1ef9-445b-9f92-84aa7cef1b0e", 6, 12 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2e143bbf-f6fa-43f6-b470-d6e3ab0f0d91", 7, 14 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "038abd4f-7c64-4ac2-bd0f-a9f7a0dbe439", 4, 8 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8b42bbfa-2b75-4a53-903b-911a1360dbad", 5, 10 },
                    { "78157107-23fa-4638-bd17-38187695312c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3acb1a54-c24a-4841-aae5-64d914300c65", 6, 12 },
                    { "78157107-23fa-4638-bd17-38187695312c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2d0c9c0d-2845-4be4-b0ff-c380e4345fda", 7, 14 },
                    { "78157107-23fa-4638-bd17-38187695312c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "505c23e7-6e73-4a78-b842-c02a77a4ca27", 4, 8 },
                    { "78157107-23fa-4638-bd17-38187695312c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c63ec5a2-c7d5-4169-b221-df806b580b29", 5, 10 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "52b3743b-3c02-41b7-9b8b-83041ea0fe8e", 6, 12 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4c7ae14c-a2ae-4f44-afac-66df7c41ffa6", 7, 14 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a8414951-ea9f-4101-8a34-b19cbdc9df8e", 4, 8 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "04eb661e-fd9d-4f67-a595-15debc9884fd", 5, 10 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c1c266b3-c608-4f1d-8c98-a41beacb364a", 6, 12 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8b54652f-deb9-4a2c-8d6f-bdf31b2ad445", 7, 14 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3c2ad11b-4abf-484e-84e0-d8638e95b567", 4, 8 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6847f896-776c-44bb-b114-9d8f6ab36ae6", 5, 10 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "701baddd-6612-4eab-b83e-ec7a5512d689", 6, 12 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3e91241c-7f43-43fa-9832-648ecf13d63d", 7, 14 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4568481c-282c-4d68-bc8b-176f5bf909a9", 4, 8 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "31a1f19b-c65e-4c7e-9162-e95a59f2a50f", 5, 10 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "65157db3-a5c4-4e9f-b893-745b27f8304a", 6, 12 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dd47a0a4-8412-47cb-a378-27dbd48917ea", 7, 14 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "de488b15-8441-49ba-9e8c-8a6fd127c5e3", 4, 8 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a6b31af3-765a-46d4-a2fa-2a74c3585828", 5, 10 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6528be25-f999-4159-b5d6-68dcae5b8cae", 6, 12 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fc054d0a-87fd-4ea1-84a9-16a51a94b23d", 7, 14 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bc5dc0d6-96ef-4674-8511-7dfe3eaff777", 4, 8 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bdaee8e6-a955-4fd0-95f7-5e8a3aecc0b5", 5, 10 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ca3c7141-149a-4af4-bcd0-a3e5ac60e83b", 6, 12 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "aded6cf7-599f-445e-9ed3-62174cf8108e", 7, 14 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "97eae3d8-72ff-45f0-a493-44c61d26e11d", 4, 8 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b77804fb-791a-477c-ae9b-3921d6e9bb98", 5, 10 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8a7a05f8-ac0e-4239-97aa-f5d7d542aac2", 6, 12 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ebe016d0-8cb3-4353-bf35-ebec0c29e07b", 7, 14 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5eb0b26e-4f18-475b-a70c-e5ea0e833a3e", 4, 8 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b25bb5ee-4e63-45ff-b6a2-a8e328ce9070", 5, 10 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2e0125f9-ad55-4998-91f8-b24ac8957c2f", 6, 12 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f6581932-8d21-4177-ba3b-ffd572113aca", 7, 14 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "20016b53-bf08-4127-b7aa-7062a6b78934", 4, 8 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "44cb8534-9564-47dd-af68-b28b6ab224c3", 5, 10 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0ca0288d-efcf-4f88-bddc-a26a8561763a", 6, 12 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "23566b50-e51c-4841-a250-685b4796f568", 7, 14 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dba18daa-407e-4f35-8c81-e03177d59465", 4, 8 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "de1cc7bd-7dfa-4cfd-823b-1f79064f1e2b", 5, 10 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2c41805a-d717-46dd-bea5-64a2dba99d6b", 6, 12 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "24bcb174-e64b-4e33-ba88-ad2858b0a97e", 7, 14 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dfa2736b-91cb-487e-90ba-beb2ac0a67d0", 4, 8 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0b05f3f7-801b-4ba8-8938-9fc8b18e1de6", 5, 10 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ca259aea-3e98-401d-bc90-0d4559177aa5", 6, 12 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "649762ee-db25-40f6-b9b0-bf9de84736f0", 7, 14 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1d743359-500f-4d81-9267-b594f97cc26b", 4, 8 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "92a2508f-d53b-4c60-8901-0d443e761f0e", 5, 10 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "832a22cc-1e0e-479e-bcfd-57e0e228f7f9", 6, 12 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ae42657d-e995-4c34-ad99-df9dc2eeaf54", 7, 14 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fdd8326d-8be7-4269-9dff-d26572d8ebfe", 4, 8 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f0835ecd-4064-4c10-a5cc-49a9bf9c20e7", 5, 10 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "673ab507-1d95-41ab-b147-17d98d4dfaa0", 6, 12 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bef37c21-51be-4c6c-b5f5-9e87361a014e", 7, 14 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "92cd279a-631f-4b74-94db-704fc3424d64", 4, 8 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "776d16a8-b9f5-42dc-ac9b-229fe0c121e5", 5, 10 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "19818972-7687-4a3f-9965-23ca98a7fc15", 6, 12 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4d8ad365-7bd7-4d39-806b-02a49e1c7db5", 7, 14 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f67ef939-e8c6-45a3-b549-8da1bb74398e", 4, 8 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "940d9a40-db1f-422a-adbe-c2c9f4936c4e", 5, 10 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cf2f46a2-c553-4310-a7f3-1d6eda7891bb", 6, 12 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e978513d-a080-4fb5-915f-bbf6c7e98064", 7, 14 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7256f484-7ed3-4284-b18a-d87b14f11996", 4, 8 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a67c888f-ef00-4a1e-8a77-e915234839f3", 5, 10 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "62530c7e-5b93-4cc7-bf17-3b3c927692ca", 6, 12 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "778ab0c4-8d62-47bc-9ddd-143c494c283c", 7, 14 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e28b8d42-7f94-45cf-9741-fd2259c19853", 4, 8 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aa125adf-d381-4905-ab60-286f1455c168", 5, 10 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b027887a-ce6c-4c21-8233-464fd2410c25", 6, 12 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4e0a4683-869f-404f-bb76-1ecef77b3599", 7, 14 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fecbee0e-2fc9-42a5-a8a6-d0f162fba4ab", 4, 8 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "496c8788-6fed-48b4-9d90-c9ff42909580", 5, 10 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fc41f4ce-e3eb-4325-b214-886ff8c0e901", 6, 12 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8bbc793d-d336-45df-8c98-d42fb5438062", 7, 14 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f319c824-ab13-4911-99d8-54849bc6a2e7", 4, 8 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f3189aac-151d-4112-a185-62d8e8a18330", 5, 10 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e7fc0947-063e-4c9e-aa51-d1a16c3f1271", 6, 12 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ce657294-b8f0-490d-8f6a-2a47a43d22eb", 7, 14 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fc2407b6-5962-46e3-91ce-f637a32830e8", 4, 8 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "44451059-05dc-4082-a410-7f4bd740a95a", 5, 10 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "473ad62f-a23b-46a9-a57b-2b153ca0a9a6", 6, 12 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cd3f99d6-c80f-4273-a0f1-7b084d92a78a", 7, 14 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e2ce9447-83d2-4490-adf7-3321abee23b2", 4, 8 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4a7515e0-3a13-4526-aff6-50717a8cbf02", 5, 10 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3e002603-e4e4-48c1-aea1-2bcb4dce8a9f", 6, 12 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d60c8e05-6343-4baf-a1ad-1e8aea6397d2", 7, 14 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bef960a3-431a-418e-bda7-7183938b118f", 4, 8 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "33f950f1-82d2-444a-a324-54f642ad9331", 5, 10 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "af4ed223-9bba-4a03-9860-358502342d90", 6, 12 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3d5f686b-772c-48d0-8a4b-d6988d372fa1", 7, 14 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1fedb7e4-ec8e-42e7-b6b4-8fc5c639a919", 4, 8 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "918f93ab-8de5-46b5-b47f-f0a07fa2027d", 5, 10 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6d57784d-2ec1-4f0b-a843-4f54608efee1", 6, 12 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dd6e02e3-6c13-4ba1-a6a2-11cca39e9768", 7, 14 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0df01d0e-b74b-4ef7-8f9f-4729c2dfce2f", 4, 8 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "02bdf841-8503-481e-a90a-2d00f1e3908e", 5, 10 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ee78dd44-5be3-4c55-b17a-b6893a7b2246", 6, 12 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "911374c2-4f11-40c6-931a-f52da3c508d8", 7, 14 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5489534a-eb18-48ea-b16f-73e79f3ffd69", 4, 8 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "db6ce14a-2a55-40aa-a540-7ee16eb9ca9a", 5, 10 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d16b15b6-5d37-4132-b400-07e02323feed", 6, 12 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "88cc0ffd-edd8-4cd8-aa68-c5119104c1e7", 7, 14 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c49ed6dc-1167-4251-aa36-e5d475c9d6c1", 4, 8 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "016be3c5-a748-4cec-835d-caac0cf3407e", 5, 10 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1f6e2890-09fc-47e7-94ce-5d4c19d057cc", 6, 12 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "61f99bca-79e1-4f2a-8555-7364717ecdbb", 7, 14 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c906dfc9-e137-4553-9a90-5487759cd461", 4, 8 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "07f23cb8-79fa-4dcc-902c-f044a146179c", 5, 10 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b289edd0-d4a8-4f82-bb64-e77a92d24849", 6, 12 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7e737c50-2adc-433b-9db6-ad66a73a221e", 7, 14 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8bc8838d-ee01-41a3-aa53-ba9a5e7b49ed", 4, 8 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a8253c6a-93e0-4d6a-bf6e-c0036ee4564c", 5, 10 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bf1100ec-b66f-46c5-95f5-7adfd460730a", 6, 12 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b72155c2-4d18-478d-b615-a010cebcc7bd", 7, 14 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5e072af4-d95d-45b2-b235-1da2f8087506", 4, 8 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2423a496-69d6-477d-a68c-95e8343c63ca", 5, 10 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "da17d15f-f2c6-409c-aa01-a464e812774b", 6, 12 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "aa6ac0b2-75c6-4dda-bf0d-82082d6ff3cb", 7, 14 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0bcd2177-a9c6-409a-9f71-4afe7877ed19", 4, 8 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7df1c9fa-56b4-4d2d-bdc5-33317dba9d34", 5, 10 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "517dc23b-544b-4e7b-b4e4-81c7df960f83", 6, 12 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0504a437-c204-4756-bfee-be6793000479", 7, 14 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f7ea4319-a5c0-4960-a3d2-cd032630f9d4", 4, 8 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "491af8bb-fa1c-4580-8709-7aa6bd1af773", 5, 10 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "449176aa-62d9-4db5-8974-6610e89aff47", 6, 12 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "56fed70d-19c5-4a32-b3e4-57546927c460", 7, 14 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "11d3936d-8b86-4ab6-b2c3-aff99b3d8215", 4, 8 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8468368b-63a1-44ff-8c16-85dc4b081485", 5, 10 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "343e477d-64ec-45e9-a0b2-25dfe796dce3", 6, 12 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dd3e8a03-1410-48ee-ba36-31c9f7bf3458", 7, 14 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "af6cbe11-f601-484d-8d18-ac14828876aa", 4, 8 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ea9bb0fa-5082-4d96-b23e-4fef3fdb85d5", 5, 10 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9a0496d4-ac6c-4ca7-a3a0-6978c5656d3c", 6, 12 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1b612646-6992-410f-8287-b9bd180490e2", 7, 14 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "33e93318-8099-4366-a806-90104cde819c", 4, 8 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b57f7861-0fe9-489e-ae0e-16bdfea73906", 5, 10 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "77badac2-9f45-4e28-89fd-ed63f2c10169", 6, 12 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5534df45-2fad-49b3-b6a3-751acd7c2011", 7, 14 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5788a5ce-a5b4-4747-8c90-d7cb113fbe63", 4, 8 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d1afdb26-318c-4d79-8ed1-e407668a7ee1", 5, 10 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cdf91e97-64a4-4980-b5e6-e16c5bd1378b", 6, 12 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "973dfe9c-6224-4a74-ad17-84876e0de0f3", 7, 14 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c0c43953-ed71-443b-b903-5d8fe37b29a3", 4, 8 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0f2f454c-c518-4a44-a83a-1e80d6442d12", 5, 10 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8d5a2efb-9d87-4f44-905d-a519c6b4b9d3", 6, 12 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2efd429b-ffbd-4473-9701-e3f65163b06d", 7, 14 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8644cd89-4ea9-47f8-9adb-2bb0e798212d", 4, 8 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fd41c051-3bf6-4f01-aea8-26beb3c3e7b6", 5, 10 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "df67cb72-ff2d-487d-a4da-f357cec6868c", 6, 12 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "790faa01-7f41-4b1e-8405-3ab1e72f9abb", 7, 14 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d77e364a-bde1-4b14-acc3-65e0add37ad1", 4, 8 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dd3f50c0-a4a7-4732-847f-cb3695d7956c", 5, 10 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "62e8b614-05ec-4ee4-8879-1ccb3bf94289", 6, 12 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "822d4318-28d6-4030-836b-fbcb2061ae76", 7, 14 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4cecd377-0c63-44ff-bb4c-a78e5767bdd3", 4, 8 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c2d8f924-7f86-47af-b3d4-fd1bc5366260", 5, 10 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "763b1d00-34c3-44dd-9b16-7efde2c9ec17", 6, 12 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "73062d26-c503-4d3e-8c2a-bc59ac587b89", 7, 14 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e22c5b18-afde-4e62-8d3b-b5191999ebc2", 4, 8 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fdb90e1b-0c23-4e04-b813-c2400949b1c5", 5, 10 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1beaa516-073d-4be1-827d-016b2854ae47", 6, 12 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cd71b48c-9d37-4664-afbd-4f79595bfc8d", 7, 14 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a6989987-4873-4aa1-a1c4-4efdaf3e3cfb", 4, 8 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9e269734-f804-4599-8e74-4411aba765a6", 5, 10 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "37fea020-bc62-4c90-8f76-071687d5b09b", 6, 12 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0e2f0a3e-6b02-4c88-ab2a-ba9c447b1c57", 7, 14 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "23587605-b002-4192-a952-54c98d7fe5ed", 4, 8 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8194dafb-fb3d-4396-bcb8-b8168fdaf676", 5, 10 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "512cfb18-5e6a-4f92-9d2b-162fbe5dd9f9", 6, 12 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "18621099-0007-4c91-96de-ffe69afbd2d5", 7, 14 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "27154b80-88b7-4f93-856f-7a1fbdd5491f", 4, 8 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "56639a4e-98ff-426a-b53c-45acd0630ad0", 5, 10 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4ccbbb6e-375b-4004-aa2e-03a60a0b5f6e", 6, 12 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1cd76a52-9dce-4974-9a2b-5adf4b526ea8", 7, 14 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6d1a816c-77be-4fae-bde8-cf8a4036bf5e", 4, 8 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3d9c4810-111d-483a-90ac-56a3ea74715b", 5, 10 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "df58d423-1944-4445-ba6f-37dcc80ac5c8", 6, 12 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "def9c2ad-f1ed-451e-9f2f-575cea45fb87", 7, 14 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "356a1007-369e-4922-8d29-6a5428e9ed40", 4, 8 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1546050d-1cfd-40c1-aa5e-5beabe6cb3a5", 5, 10 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4e523cae-8648-46a7-862c-86d7d35a84c6", 6, 12 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "22103e5d-8f5d-4e6f-9c79-9a68055470ca", 7, 14 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "12586953-84c1-457b-a085-3330913e529e", 4, 8 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e675e4c7-77e6-40b2-acfc-e8a0b4fc7e68", 5, 10 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b84fa063-a767-4073-9e93-2417d5e74f9c", 6, 12 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7d48d7e2-30d2-4d99-abac-7c2a5473f46e", 7, 14 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "af217766-b358-4131-8e04-cd9dcb65c9e5", 4, 8 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "19251dee-99d3-40d5-ae5d-b2d2257e102d", 5, 10 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bad8b6d3-6ccf-41b6-9d65-911958c24d6c", 6, 12 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "275e895a-ed43-4a71-9cda-b453170414a6", 7, 14 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4b68bd86-0200-4f18-a371-ef715368bf83", 4, 8 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "652147f2-0b8e-48f2-be96-3db235c13041", 5, 10 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "694bcab9-12c0-45e7-b22b-0c5011a07d31", 6, 12 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1dd8b6ef-8895-42db-9c56-54b25d791ef3", 7, 14 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "23badfed-458f-4afe-aa0c-5916b376727d", 4, 8 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "875c687a-f6a3-43b3-a774-bff549d1d8c6", 5, 10 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e97e329e-345b-4df3-8599-a6c533c042da", 6, 12 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "666b1666-a7ca-4ae7-aad6-5a3a386f023d", 7, 14 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f6a634f4-1463-47eb-9d3f-0fe38f92f245", 4, 8 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "45fdb5bf-7176-4eb9-84b2-945bf707d0b4", 5, 10 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ee610e56-ef05-49ca-97e6-c4a4dfb99e65", 6, 12 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1739318a-9308-45f0-8500-84c3c33bfd0a", 7, 14 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c06700b6-cf37-47ea-aa11-f8bf5cb03cd5", 4, 8 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9c8130be-c5ce-43f1-a1a2-c36ace525322", 5, 10 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "305f6568-3462-450a-85b3-e68083bda259", 6, 12 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6b4fcd5e-ea93-423a-a1ed-595ff87e436b", 7, 14 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "10dee5ca-2227-48fd-8d77-9807386d0a6a", 4, 8 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8ff7a1e6-89b9-4fae-bdb2-71ecc4462a72", 5, 10 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "50b6d28c-b3df-4325-bccf-3d980116dcd6", 6, 12 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "00de8133-6fd7-419e-8a1a-f91bec888d74", 7, 14 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "73fdf4d9-b715-453e-a749-781835c9b0ef", 4, 8 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "88a9ba61-7a67-487e-b823-82f8f4fc4d95", 5, 10 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b3fc26c3-602e-4f20-8a4f-8ffe63a92da6", 6, 12 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a0b1cc73-d9e5-49c4-98c0-0350b6b3b7ea", 7, 14 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ea3816a2-40b3-4ba4-9619-80754d2ccebe", 4, 8 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d55e5276-7ff1-4bd2-9383-326e1b80c653", 5, 10 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0bb0286c-b8b4-4987-83d1-fabb36e5b66c", 6, 12 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c678d77a-902b-49f5-a1fc-a0e1386c5e58", 7, 14 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c804f1d3-243d-4c16-8767-4d591ee3a2eb", 4, 8 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "630330f8-1235-401f-844f-a3a7e5b79d46", 5, 10 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "81c80f90-3e83-4d5c-90c9-d317bc3734c0", 6, 12 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "78850a42-92e1-4c86-9e65-416538456ef6", 7, 14 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "04f5ce95-3a37-4188-8145-705bdd8ce4c8", 4, 8 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "169996d0-7858-4e60-87c6-fe752c0336a8", 5, 10 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f9fdd3ec-e7d8-415e-8f0e-14c6983c3df1", 6, 12 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "681ecdb8-e766-46bb-b67e-00be914f2942", 7, 14 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a4058567-f56a-42b8-a67f-abd6fbdd8cde", 4, 8 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f73e59f2-e972-4161-8ab4-d60af83a4883", 5, 10 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0e82367c-5cc0-433b-b820-8cce9809739c", 6, 12 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "87621d85-b618-4f0c-b064-fcb2f7675c8f", 7, 14 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6e264a1b-2e9c-4a00-83a2-0fc38b5f42f1", 4, 8 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7cd3020d-05d6-497c-84e2-30e34e3e17ef", 5, 10 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e51fd768-ce98-4ae8-80c1-e5958312ea52", 6, 12 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1e08a90b-a408-4879-a3c7-faf1e4cfb0a7", 7, 14 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a467ed84-dea6-479d-8821-ce27bbd193d4", 4, 8 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d2adcbdb-b25f-45e4-8a19-0c921c3d993c", 5, 10 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "05259cd9-f7b8-44f4-a8a3-f712cf99961a", 6, 12 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "38d73b20-3507-4d46-bbd6-3f78ba711add", 7, 14 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e03832a9-22d6-4963-bcf1-9bd69be78b49", 4, 8 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "77e710e6-4bf6-46ed-b251-ffc847d48766", 5, 10 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "92f61c10-46c9-46e4-ac0a-55efd96db2d3", 6, 12 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6e1032e5-d8b8-4779-8709-1a16877610a0", 7, 14 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6b54841e-fb75-4429-b9b5-184e1be897f5", 4, 8 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3344e8e2-b4ce-4c3e-bd56-e3543a3f0f59", 5, 10 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5db59503-515e-4e27-af1a-ad9996982f68", 6, 12 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b21ab68f-14ad-4cc7-9a5c-0eeec3d375c5", 7, 14 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fbd08c08-b86b-45e8-924d-c2a1a726fc10", 4, 8 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7e0552ef-da50-4b0f-af29-e8e830333d5a", 5, 10 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "214b2f0f-936f-4572-b7ca-595853a24b64", 6, 12 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "91d26d66-8371-4b23-9014-d613a1fe9801", 7, 14 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f9ab87f7-bef6-4877-b9ff-30ceacc8c1ad", 4, 8 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c7c665bb-f6ef-4dc6-a9f3-6050d0b12cba", 5, 10 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1c9d44e9-9620-4306-8fdb-26078533fc29", 6, 12 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bfd0e040-346b-4dd0-82ad-3add6793c253", 7, 14 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cbf25b6a-0c54-465d-a626-58ffd5bac2be", 4, 8 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "72b4e6be-430e-4737-980b-3420e268856e", 5, 10 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d0db336c-e45f-4f5b-92bf-5619a4823f52", 6, 12 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0b536e72-8e46-450d-8a2b-54b5cd307bf7", 7, 14 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "93d4987f-11cf-477b-857f-3b765991f39f", 4, 8 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8d65c125-ae26-4bcc-b7e4-ed3dcdce0b2a", 5, 10 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "346e42dd-399a-42ae-9268-ee3914e41ebc", 6, 12 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2109f32e-b7a5-4049-97ea-befd95cc4583", 7, 14 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "93f537ed-f5be-46f7-986d-c5926ab7e2a7", 4, 8 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "41b05ede-80ca-475d-8166-2a0d007cdce1", 5, 10 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7c9be50a-f318-485c-bc9e-a85fd5c6b640", 6, 12 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3c097626-dd29-4122-8e04-e91794cf5d60", 7, 14 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d4c0da60-839a-4ea0-a89d-652e374b8b30", 4, 8 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bcac3e24-50de-4e41-9050-23aca052c866", 5, 10 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5220c5de-424d-4262-bfc7-ac855b39a36c", 6, 12 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5424aa06-be31-4126-9909-988a687634fa", 7, 14 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "90492224-1edd-482f-a311-b2a2e3b0af7b", 4, 8 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4998f655-ca9e-4e53-a094-1fbca60ee190", 5, 10 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d69e67dd-ba4e-4aad-ace7-b72825561fde", 6, 12 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "66e80004-35f3-46c7-aa87-2de664e53c87", 7, 14 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "807129c0-c677-4d13-979d-cefd427823b0", 4, 8 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f742f788-8919-4d6f-935e-b355dd9637a8", 5, 10 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "41555bf6-bd31-45d6-8a2c-a18f0f4f8f3a", 6, 12 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cd950b1c-b137-4b7d-9e11-757d058a1976", 7, 14 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9c1c981a-44bd-428a-8713-32aeb53aafc5", 4, 8 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "27f410ab-71f2-400c-9161-42ad1addffc7", 5, 10 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bae41888-f50c-4950-8686-7b3b0818d812", 6, 12 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "76a656c4-da4c-4005-b3db-465ebbc5a097", 7, 14 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cb8c8c67-1c41-4e18-97ab-5176bd3820f6", 4, 8 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "86a5ecd4-ea9c-42e1-a188-53ace9255391", 5, 10 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "640b4e98-c708-4f59-8cb1-ba00b8847cdd", 6, 12 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c793de6e-b623-426f-bd14-52c316c4856f", 7, 14 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9f903748-9882-4efa-b464-9c91a405bd93", 4, 8 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d5950dd8-ba24-4719-bc66-8239d55ec629", 5, 10 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "79ff5b20-30b5-45ef-ad65-3ecd6c4ecee8", 6, 12 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f6d14c7c-45c7-448e-ba6d-bebb0f5cf8df", 7, 14 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a68f7d6b-fea2-4a63-ab4c-235a5f147d34", 4, 8 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3dda0b0c-ab91-46b9-9258-e89356627398", 5, 10 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b1ca8d09-0f40-4412-8bc0-650bd85e0546", 7, 14 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9119b00a-dd2f-4c86-a59c-b933bf228226", 4, 8 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bb9995d1-a7b9-48bd-bfb8-473a25b1fca0", 5, 10 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768g", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4ce5b163-b773-43f7-bd99-69a0f0b655d4", 6, 12 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c78f5430-467e-48cd-b78e-3becc19b9897", 6, 12 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b5944123-bf42-4bb1-974e-b4034e58ae78", 7, 14 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f76329f0-dd75-4344-95df-a2470c848778", 4, 8 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8889484c-ac84-4369-ad85-25eb5ecac69c", 5, 10 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "74286c09-2c78-4a29-aaa0-13878482e32b", 6, 12 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a4533f23-ad12-46b8-9f84-17736fa8ecba", 7, 14 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7aa17b53-269f-44cc-b4c3-6bd3ac066eca", 4, 8 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0c70d5bb-2e9a-48c2-b45a-016701b3378b", 5, 10 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b2f95340-4442-4bfa-88f6-df3d8832f5f4", 6, 12 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "17b2403e-e547-4d49-ab1b-9ce3e0ad2f25", 7, 14 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a79d998e-1a75-4005-9d56-fe54caa9c81d", 4, 8 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2852cf8e-401b-4b95-815d-8fc928110048", 5, 10 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c92f2299-2e9f-4210-88f0-e3e26104b755", 6, 12 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8e0cf1d3-7ae2-4794-9d6c-11c6f61ce0df", 7, 14 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5cd3804f-daeb-4ec1-97a6-0cfb0583d0f5", 4, 8 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "26da37de-a7f2-49f2-b3df-f3ed81dcea97", 5, 10 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "98df8e4e-9176-45c0-8b5a-b63281337d20", 6, 12 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4feb4e90-25fa-4d6a-9c03-80c3fa3fefbe", 7, 14 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cf2483d2-0987-4d7a-bcb6-f50aca3ed881", 4, 8 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "981afa9c-a7ee-430e-8759-3eb3d1ddc6f2", 5, 10 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f4bfa44a-ba82-45b4-a0cf-fae47cdcc1e9", 6, 12 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f62bf10f-3ff2-439e-a8a8-670d6e9fb6e2", 7, 14 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d826ffe2-65c7-4543-9e0e-ac893d77a839", 4, 8 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fb85bc29-18d0-4890-a73e-803782de37aa", 5, 10 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "00c2aee8-a1b0-4416-810e-338dd211a93f", 6, 12 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "81163fab-8dd6-4a65-aaf1-02cbb5003f17", 7, 14 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "74e4503e-672a-4afd-8395-b15f3921d17e", 4, 8 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "272fce81-88d4-4670-84a0-9a55fc855985", 5, 10 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "39bb4fde-8872-4a7a-b431-65ec35ddc3ef", 6, 12 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f8babfb9-c4df-474b-ad74-4025d8e2da52", 7, 14 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3bf26cdc-5655-4574-8beb-fd7b7aad3a2b", 4, 8 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "107036d0-bf8c-461b-8496-85a341705b0c", 5, 10 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7bb00f89-5186-4def-941b-8772d29acc3b", 6, 12 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "92e60f70-89f7-4f1d-a7a2-0cd699cdaf4b", 7, 14 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f6bea4f9-e389-4e1a-bf5d-52692831f809", 4, 8 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a4507dbe-062b-4bfb-9468-a7f2478dba76", 5, 10 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f6872f09-8c6f-4c95-8ea2-c827cb730e35", 6, 12 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "135c5801-f9d4-4bfd-b4f8-54cd1565809b", 7, 14 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "54a266c2-f853-4362-a0aa-f917167a2d69", 4, 8 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9dc6c1e1-a93d-487d-9410-f65ae27ce8d7", 5, 10 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1c12c285-1631-4e13-af40-d3c92bd6d3cc", 6, 12 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9ea1a87a-533d-40d8-a008-3dc7def2b6d6", 7, 14 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5c3e0835-7086-4d9e-8e5d-65856fafb31d", 4, 8 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "44fe8e46-37c7-43a7-9c74-78b798e6dd5e", 5, 10 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "756a4c21-a46c-4f87-8539-cf809cae2130", 6, 12 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a8b7abe4-2bfc-4d23-959d-2eff4f40ad60", 7, 14 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4be3c1a3-2689-4450-b8f4-3af382393d98", 4, 8 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bdb1f51d-bd8a-452a-b305-0544094b27e5", 5, 10 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "72a3dace-1272-4f0b-a55d-cb94fbb4ef1b", 6, 12 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "73df559a-2e02-4648-9f60-00fbd8688ec9", 7, 14 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "21a005a6-0ee9-47cc-b078-0bffa7c889a7", 4, 8 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bbd8684f-8d3a-43bf-b7c2-7c9dadb96b53", 5, 10 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bf11bd37-931e-47bc-8946-9692d82b2a8a", 6, 12 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b18db5e6-cb47-4bc4-9156-0e2b63c68fdd", 7, 14 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "341c46d8-ff56-4305-97dc-8ce619212e08", 4, 8 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cd9c3701-18f3-463d-b1bb-cabd52a1d778", 5, 10 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "445bb8c4-b4ae-447d-9ce9-794c50dd2d03", 7, 14 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "72d7b0ec-7bcf-4a80-8517-76567ef4761d", 4, 8 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ab11c3da-a864-4a46-ab56-2a08d33b2796", 5, 10 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2eg", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2eb627e5-c3ef-4f35-bf5d-4b0183cc2121", 6, 12 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0a10d223-5261-4401-97c7-69f9660c7d6e", 6, 12 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5a4f0fa5-aaf7-4784-b2a5-230d3adf8ba2", 7, 14 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fdc7bfaf-da5d-43cd-8ffa-cf86f4ed1b76", 4, 8 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "836b3582-85f3-4be8-98ba-064c05d97770", 5, 10 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "09aa5abd-10d1-4374-9288-e6f117b2cade", 6, 12 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d9e01c72-280e-4ca6-8814-b4f804673784", 7, 14 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "15f21161-51a8-4b30-9434-4f402cdb6a34", 4, 8 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6debb49d-538f-4dc6-b88d-cbe44ec6e149", 5, 10 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9fb000a6-d258-40fb-a6fd-2e51391b87c9", 6, 12 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "311d3062-ac2a-4464-b86a-a02ae3332c51", 7, 14 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "27bc005f-2184-421c-8e52-c5ee882f5014", 4, 8 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dbba495d-6f3a-40a4-9e74-5e78a0ac64e6", 5, 10 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2574ce41-8d7d-458d-813e-58eed4f9891f", 6, 12 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3dd95512-b421-40c4-a7b6-4cfd852854c7", 7, 14 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "16efdf1f-7411-43ac-a449-943d0d3a8261", 4, 8 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "28bfdab0-4d9b-45cf-b117-94dd84f2ec79", 5, 10 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ef59d8b2-08ec-4d23-9437-1ccbbbb5f8d1", 6, 12 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "41e747a9-702a-4d95-93b5-2d3e78acfb30", 7, 14 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ec0984b6-a21c-474d-ab68-8f107dbf7c63", 4, 8 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "47177ba2-819c-401b-b770-f8f2d0e4af8d", 5, 10 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f6b2960a-feed-432f-bec3-6011bec248c8", 6, 12 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c52a4afd-eff8-46da-b763-3cb8c5e8750f", 7, 14 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "28404df6-d094-4b13-b286-ac5fafd59728", 4, 8 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0373aac4-984c-4370-8fb6-86f50e925e59", 5, 10 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bb5a3171-64eb-4408-9ea6-92e26e842d19", 6, 12 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e7c4a3d6-543a-42bd-8af8-9b6d34f95f15", 7, 14 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "66c5df48-a368-4a44-bc18-f173988599c7", 4, 8 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "585244f5-664e-4a2e-aef3-2d5bb411cde8", 5, 10 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d3442d66-aea0-4aad-85ed-937e0daf3ff4", 6, 12 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "90368473-730d-45ff-8bac-360889525fac", 7, 14 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d0159ce7-7ea6-4cbd-9bb6-0feb9b56026d", 4, 8 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e1a5aef7-d1ff-475b-abee-3660c7fa6e01", 5, 10 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aa9c4ab3-58ad-4216-b552-cd23fc54064f", 6, 12 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d8b57f09-9e9c-40c0-ae58-24087ec9fc75", 7, 14 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "31f281f2-af93-401e-9c52-584ed094f8be", 4, 8 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "36740fad-05a8-4e1f-84ee-2777c1b641c5", 5, 10 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a64d0b0f-2a6d-427a-b030-de6df75b81e2", 6, 12 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "649ad8bb-3c88-447e-b98a-9da1ddd87651", 7, 14 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1b41c683-fa78-44ce-9ddf-f0e03f4d86df", 4, 8 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5adbe93c-3f64-4264-a884-0618b94dea72", 5, 10 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ba3fef96-8c7c-4f8b-ba5c-d95eb890aeca", 6, 12 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ed59740d-3b6e-45d5-bc48-ec52dab8c858", 7, 14 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "47ee875e-c940-4d39-9e97-0a51d3cd0387", 4, 8 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f5b6447b-5f47-451a-b180-a59dd788b9d0", 5, 10 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e074a65d-49b8-42cc-a56d-d19b133218eb", 6, 12 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "086364d2-2341-4518-8a17-326e7795c336", 7, 14 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8f2fcb11-7865-4af4-ae4e-11f29308ae87", 4, 8 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b3076d0b-5f2e-4ca5-af2d-f81dd85b291d", 5, 10 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "398fa0b0-e68f-40c2-bb54-ab44e4e07b82", 6, 12 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d3d09606-2cc8-4a28-a4c2-3993c47c8923", 7, 14 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8ad4122b-9071-4e0a-a6a5-50939a130cf6", 4, 8 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c541f750-60d5-41cd-8812-e0e2c80c6d41", 5, 10 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "97b829c4-effc-431d-adf0-a0673f65324d", 6, 12 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e2b452dc-5dc4-4f7b-9ac7-b7f0fa620d6f", 7, 14 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "86fbb924-d3dd-4e4e-8f01-7e784febccd6", 4, 8 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4aebe62f-4404-4d38-9293-706a43c10394", 5, 10 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "075b1e23-f733-4e2e-a3f1-5d055a585650", 6, 12 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "64aabc25-b2cb-4949-b8cd-a8dad4c03084", 7, 14 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "57ac30be-b965-4dd3-b691-9c484fc35f96", 4, 8 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4b7f0c9c-f43f-4e0f-8e92-3fd182efd6a4", 5, 10 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a2b26031-06ff-4044-9799-09f9d701aa6f", 6, 12 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "73299dcb-4884-45eb-8da4-bda7a22651ab", 7, 14 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "42f4df1d-4ee8-45d0-a5d1-29b0a8e0cecb", 4, 8 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a51f132f-c762-4bac-8460-cb9924dd12e9", 5, 10 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "979e86e7-655d-46ea-95f7-2a8bc5450e21", 6, 12 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d0bdc0ee-57c1-420f-ab7d-4d3b3db873a5", 7, 14 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "37f7855f-134c-475a-ae0d-8363284b8e31", 4, 8 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cad5d881-0f1f-42a9-950d-6d5511756a74", 5, 10 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4b765a52-272f-43ba-8be8-01aee6c571c5", 6, 12 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "239ebcce-6017-4d83-ba55-258a288fffdb", 7, 14 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "aa365461-98b8-4aec-bb92-7570b2359250", 4, 8 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "61865ef7-e671-4c6e-bb1a-9555a6c5dac2", 5, 10 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "121b5778-da5c-444f-a554-f780aef1b4af", 6, 12 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5b7ca336-55c1-4134-97d0-9423f686a71b", 7, 14 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b06f2db1-b7aa-4e9e-8489-70237c913ed4", 4, 8 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "82d51bb1-7e7b-4518-8cb0-7aca226c9431", 5, 10 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4dcce812-68d9-4e80-83ec-fdbc7a56fa62", 6, 12 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2b4658b0-2b5d-4bad-89cd-4846a93d4075", 7, 14 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "98b251a4-eb15-4867-b4bb-29cf4b43b836", 4, 8 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a6f851dd-a7ed-4451-bdf8-5abe1cda0eaf", 5, 10 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "45e56228-bc10-4133-9f33-dbc572c948f6", 6, 12 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "881b0dd3-bc79-4923-8efa-eb19518c81a9", 7, 14 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f8ca0a66-4353-45a4-b1aa-48b7581b6ad2", 4, 8 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e686c96d-59fa-4c39-a26b-305446133623", 5, 10 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a0e0524a-5095-4e03-ad65-cee3c8458b55", 6, 12 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6941a740-37db-430c-9d0b-8f08d1dc3b53", 7, 14 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e046177d-b4ea-44cb-9f8c-2d73f3e03a93", 4, 8 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "14781ec6-c5ae-4160-ac01-7bc2a17ed9f5", 5, 10 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "43d227ee-93c3-4d89-ac50-b46c5c6b5827", 6, 12 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a893e782-58ce-46c3-811c-6ef0ef615289", 7, 14 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5f14d76b-5b07-4621-8201-ec218edd7031", 4, 8 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4d176e70-7159-48f4-8bd1-4a0a950d4f9c", 5, 10 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "56bae193-2b4a-412b-9f83-94e80d37cbc3", 6, 12 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "327666ab-9487-4c98-b12d-435d0fd2aa94", 7, 14 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0991fda1-4330-4fe9-95b4-13f969a1ca03", 4, 8 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0d06ffa9-2118-456c-850c-cdb8d24d5a89", 5, 10 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0333560c-8f34-4db2-9729-7a6cf951f0b0", 6, 12 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "11cebe15-e71c-4182-a8b6-61fc5edf07f3", 7, 14 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "df21a764-2b3a-46ce-8566-4442d7887389", 4, 8 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f6509788-1867-4481-873b-8b28af8990d5", 5, 10 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9d9fa4b5-1725-4688-ad45-b6642ff95cd0", 6, 12 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7fe52272-4cf4-4929-8d9a-7a4f1fac5336", 7, 14 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5b02f7a6-8e97-45e4-8904-36e2672b4489", 4, 8 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5026824c-c1c8-45a5-a32b-8879fe42f4bc", 5, 10 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ae16a805-1b88-4342-b8b7-f96c925a5cfd", 6, 12 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c415b995-b0bc-4dff-a947-c7e90a27ca73", 7, 14 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "466f14b6-a1c4-4e42-b840-1ab07dcd8573", 4, 8 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4ce80570-e960-4339-85ed-11bde72d002d", 5, 10 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9bd8ff14-76de-4d99-8645-8e29d9b912e0", 6, 12 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1b9d8de9-9a0f-4b70-8c88-7e5ef440d851", 7, 14 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "93634fd5-d239-46c1-8438-4e174a359d9d", 4, 8 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e14a7676-7379-4930-8a97-d74958c3d323", 5, 10 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "38484caf-cb3f-4a33-be5d-5eccb2f8809d", 6, 12 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4a40650e-8fe9-4c82-9ca4-31f8fd3e3c7a", 7, 14 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "db9cba51-4813-4cf2-81c4-8b620702d3ed", 4, 8 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a37c2099-b8af-45b9-8c8b-f7ed843ebff2", 5, 10 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d7e2fb3d-7430-4026-a4bb-cc07236aa2c3", 6, 12 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a8eb43a3-b732-483a-91fa-82ec37740175", 7, 14 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ecd3059c-0e13-4215-b2ff-b38fc9277403", 4, 8 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4179972d-31c7-4bfd-ab40-132252de8a39", 5, 10 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "70c10985-6fb1-4678-98cb-d1b9e83435f6", 6, 12 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1554deba-3211-4052-b8df-61d9e870f2af", 7, 14 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "33454e4a-493c-4639-b7d1-d9cc46c7c7f4", 4, 8 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d09fe968-5b33-4fad-864b-82e507eb0c71", 5, 10 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "96211190-8be2-4876-9ec8-b991c7747028", 6, 12 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2441f407-27de-4b14-bcc5-31f175eef08e", 7, 14 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "48c55ae3-f5c0-47f3-8ccf-8e08bae06a2e", 4, 8 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3954c129-d54c-4e8d-ab56-095c452334bc", 5, 10 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d82c37fe-9b97-436e-8162-a6d02607e789", 6, 12 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e0eebc79-1fa3-4d78-af8a-92213c6f3b6d", 7, 14 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f6b929df-e9c4-4a82-b5df-3794a1b6bb91", 4, 8 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "86a2ca35-b093-473f-a725-40a04e42368a", 5, 10 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bc3d9256-0a93-4fb7-8e11-5d372b0f5bad", 6, 12 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "37c6ee9a-d19f-4106-be2a-a82c6ad516e7", 7, 14 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a882163d-1932-473f-90ea-6c2ea7868ff8", 4, 8 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "382ade41-ce9e-42af-b662-4ed74d06c304", 5, 10 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0c52276a-8b66-4494-8eff-49797cadb5f0", 6, 12 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6a3df30c-1d76-45e9-a2fa-f58ccc814c46", 7, 14 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "08862cb0-2e2a-49fe-8e91-ad00929b7559", 4, 8 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a46ea6f5-beab-44fa-8c25-56f05c8b8101", 5, 10 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "90815f79-fa13-4e75-b1b9-294e355bcbae", 6, 12 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b2d953ae-4fd5-473e-93c8-b47155acf01a", 7, 14 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "17aebe3a-9573-460e-a8a0-1bf866b59c3d", 4, 8 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bb01c2d3-6d88-4263-961c-19b0ea741077", 5, 10 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "abde111c-acad-4b3f-8162-534c7132eaa0", 6, 12 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f9867ef4-8530-4a50-93c2-cda8a5756aa7", 7, 14 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3c26789b-2127-4e5b-bb7a-6242576501b9", 4, 8 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4cd017b0-b610-4869-84f5-a10c1fbe8a6e", 5, 10 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4ccdfc9e-d39a-4d02-a902-6970f530b066", 6, 12 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "348e0502-ec08-4224-b5ff-8fc1522e41f9", 7, 14 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "12d28562-d170-4c59-b899-47302f798a45", 4, 8 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7195a7b0-5b36-41a6-840d-f7964a6ac4f0", 5, 10 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a30e0941-8d13-4bbd-8c17-669e6f0c31b6", 6, 12 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "db957c69-0828-4804-8384-4db8f16b52fb", 7, 14 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "42546be1-acb4-4348-9e01-49dcbc169f7d", 4, 8 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "32f33819-f2d3-4599-b4ee-147705632196", 5, 10 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "391d81de-d409-442a-9065-a33eb84f5de5", 6, 12 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4c4c2c5d-61f2-4f3f-a66b-d9c3e068b69c", 7, 14 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5012fa3e-4f4f-44d1-a89e-d96e904559fc", 4, 8 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "205e8cd8-c7e1-4042-bddf-9408fddab565", 5, 10 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ac8e38a9-e7dc-4818-8baf-d5553647c6cc", 6, 12 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "98f6d65a-a7f0-436d-8978-f81eb5d895e1", 7, 14 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3121cb3e-bdd0-45e4-bc0f-4a1d6ba731d4", 4, 8 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "169c2698-d849-4717-8e07-ff0b7c888a80", 5, 10 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e5ed7ab7-5f27-459b-ba5a-67adb69d7462", 6, 12 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a542bd36-a07e-4933-a86e-d38baecd020f", 7, 14 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "88fb77d8-f096-4735-87a9-782a85d4e8e8", 4, 8 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "88f2a1ed-8db2-40e6-9be0-7030c02ec2fd", 5, 10 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b323015d-d8f7-477b-b11d-3fa2c3c198d4", 6, 12 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fc464af7-915c-4c15-8346-0a9262a357eb", 7, 14 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "526e4e76-4ff3-4e0d-98ee-be5d892af44c", 4, 8 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "81bd07a9-a39f-4a08-b8ec-3e8049231b22", 5, 10 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9351abe0-e1f5-4e3d-bf05-fc175c2b54ee", 6, 12 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d87e05eb-f58d-4388-bf3c-046b77b7a78f", 7, 14 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2fe2456d-422a-4900-a5ce-c1a381637119", 4, 8 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1ce79319-f7f6-4256-8d3f-cc00dc25ce46", 5, 10 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "50827074-ad59-4c9f-814c-3a4300e16c59", 6, 12 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7b7dee6d-4e80-4467-8eab-25ca5f971e3d", 7, 14 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dd96811a-7fe8-4fc3-b80b-c0fc78d876ba", 4, 8 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8ca99ecf-7cc7-496d-8d9d-0d77ff71c04d", 5, 10 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6abeb8bd-ef70-4053-a065-d97aca3d35e4", 6, 12 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7eee1dd8-9d6c-4bd1-bf25-124416be54ca", 7, 14 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "379cacf7-0058-46a3-b18d-8b61537464e9", 4, 8 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8ac68dec-7afc-4436-b5a6-48028ee91c24", 5, 10 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c46ba986-3e45-4aeb-8ac0-322e0e96c199", 6, 12 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9430fbf8-1641-4589-a72b-60b92cab22e8", 7, 14 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c0ae61f3-eeb6-4ba4-9a42-78ae43434488", 4, 8 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "228efaad-5777-46c4-b501-047c7c3a060f", 5, 10 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "361f4e7e-c5b8-48b5-9f94-f0b7d21d45c0", 6, 12 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a03329a9-de44-426e-9a3d-c7b2b67d240a", 7, 14 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9b9873e0-bbe1-46ce-a7a4-a2755f0937cc", 4, 8 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "515b3f93-feff-4c1b-a910-2975130b5127", 5, 10 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "241bfbdd-bdc4-4a6a-b904-da11002fd3e0", 6, 12 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0d491ec6-8ff8-4699-902e-5bcea3edd52b", 7, 14 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2a07a639-7ef6-4d5a-8afc-1b8cb07613e1", 4, 8 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "11c3f58e-6a25-4b2f-84cc-4232e2469618", 5, 10 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a85268b8-1944-4ea7-836b-0a65fa0f335c", 6, 12 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "12a47b59-e213-467b-9d74-02fc04f2fb62", 7, 14 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b25c7226-01c2-4ca0-ba9b-5950b5cfc3c6", 4, 8 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c6979e97-626d-446f-b1d8-62916726b94c", 5, 10 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8574351b-3b90-4aec-9ebe-80a707595f62", 6, 12 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "96c539e2-a17b-468e-b000-1e2841cf7126", 4, 8 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b1f7576f-729a-432a-89a8-36fa7d4a19a3", 5, 10 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2x", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8b658f6b-a30f-4e80-a5c0-77bc826c050c", 7, 14 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4f55a6c0-d75d-4181-8377-d463832f16a1", 6, 12 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ab468978-0add-407c-b812-9d944e67b613", 7, 14 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d4ed0a3e-1031-4191-aeb4-531a4f5b6837", 4, 8 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ebf26937-a220-4476-ad7a-7325e785bd6d", 5, 10 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8366983d-9d4a-4759-9a43-374a76865f5d", 6, 12 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2e1f6025-ee1b-41c2-8c05-cb8277a55218", 7, 14 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e379f285-d2b9-4757-aa49-15c8b25869d4", 4, 8 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "10ae0002-e9b5-4d3f-bd2c-bf955261b3f8", 5, 10 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "74bbfb8f-c11e-4203-97c7-2c863cb8c50d", 6, 12 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6689905d-de99-4261-8016-73e0b0e5fe4a", 7, 14 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dc5bca26-a673-479a-8d61-91d49f1c1630", 4, 8 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "284c3594-660f-474a-8dc4-bc0423bcf2ff", 5, 10 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "66225093-c78f-43c5-b67c-4219dd5e2f26", 6, 12 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "18319c2b-c106-4a80-ae83-8929198f5622", 7, 14 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0f05f492-e472-4857-855f-496b12bbe1f7", 4, 8 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a301194a-6932-432f-a217-dac2b5ba2bab", 5, 10 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5a2a7255-410f-47a7-b603-94ce5e1156ea", 6, 12 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "65942ee5-8ba1-4db3-a230-45a107c0f407", 7, 14 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2a94c746-b97d-4aed-b159-92005e349161", 4, 8 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "794492e4-af63-451f-bf4d-d9b81c2c27cf", 5, 10 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "70bfae91-aee2-41e4-ba8f-27f025d7085b", 6, 12 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f1959e8a-fc2c-4f2b-b437-8dcc4fdcec26", 7, 14 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "be799591-8300-4015-a6ff-f9ceb870988c", 4, 8 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2c825da5-2c66-4a33-9fb9-49d11525d898", 5, 10 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e8b465e9-3bef-469e-bb1a-232ee2b44c71", 6, 12 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c6744775-7388-4fef-bc20-efcabe614774", 7, 14 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "00ff9371-186d-414c-82c0-a66578a76ebe", 4, 8 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f363c8c1-7412-4369-a55b-a87d2d342a98", 5, 10 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2285abfb-4ffb-4f8a-aa77-8fea873864d6", 6, 12 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a61e7f47-d5c6-41ad-b47a-c29ea89402f1", 7, 14 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e3035c3b-5f79-4212-a5ac-d9d23b19a56c", 4, 8 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b70bfc03-1b79-43ff-8648-f29944367000", 5, 10 }
                });

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00e2e1d5-5577-4f8e-b13b-dde82c77b91d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01388782-b75d-4762-8ccf-4499568fd455",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01e005f3-0bbb-4ae2-9136-f3afe1353315",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "034b18a2-33ad-4020-8d9d-5a98891d0be9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0418ebf4-0b73-4042-a5e4-ce396d5b512b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04871b2a-5533-41da-9959-f664809887c3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04886a46-180e-42d2-a3e5-86df27efaee2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04a7d241-f761-4ead-803b-1d204df7bd53",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04c2c202-afa7-4e2c-941c-29f956783f6d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "06c505ec-998c-46c0-9163-0188423113b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "074db959-27e0-42a0-98d9-0961864e1a7e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0973a418-280f-416d-8df1-7139e28961d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09a2d110-7772-44cd-af5f-27fb951f0544",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09ff2634-4a59-46ce-94c7-8428324d789f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a1ff474-48a1-4366-a120-8ece6ce5ba04",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a7149b1-6928-4099-b623-787d0201e213",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0bf06e4b-d062-4e01-a985-9b05e3f12fd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c59ca0d-60e5-4686-80be-18ab36b53468",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0dddae8d-37b4-47e5-9c89-95589a3f787a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e9b45b3-2915-4dcd-99fa-77ad89f182a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f1d6d17-8b8b-489d-a0f6-7349691aadd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "121345d8-2660-489c-a90d-2469b9c44222",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "142730b0-0df7-430d-ab80-e750ffe0a6ba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16b681bd-b39a-4891-ab7a-9073365bc1e7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a9626f8-303d-41e3-aa54-ae1a971ad179",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f4cf9f5-2976-4b5c-9428-122096bf3877",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2146af26-ce2b-461b-883b-e6f4fe0c8085",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "229759ff-14dd-4c4e-82aa-f56a2181c0ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23672a63-2fd2-4e6a-905b-340ae4456b83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2838e6e6-1238-418a-988c-0346a2abdbc3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "286d76ad-723d-476b-aa84-c7a6541afe81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "299be826-3901-425f-90eb-e445e73ac37c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2b514c67-a65f-4c0a-86b8-5bf92a974c34",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2bc1e669-d825-44a8-a11c-656a8209498a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e5e4216-4af5-4fb6-9c65-8989715e5a40",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b00595-bfeb-47b6-9af3-91d117e003d4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b3b531-3e47-4ccb-9cc9-8e7aafedb810",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "334d6d7e-422b-4376-ac30-161f98aab66d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3396c18a-dcd2-4638-8827-2c7fc10d6996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "364cd9de-6ddd-47d6-a534-74f3f00a0b7c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3770c1af-e181-494b-8c1a-c6f09a3b825a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38af7185-32ce-4cf9-95d2-52c4c4d18bce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38c1edea-3339-4f95-8d4a-5f5583660d9f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c8cf49-d75e-4703-8958-ec3bbff87723",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c99f61-efbf-4f5c-b084-eac381d82049",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39f01cd0-ae41-4070-9eb0-0f2423cc3286",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d6e031d-2fcc-46ce-9eb7-268e95ae1323",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d704609-8abd-4a0a-80dd-2ee9f38a3608",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3da92c21-3bf0-4de1-a187-459271e16106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e2f7a5f-b665-4b13-861e-c5a5029216a0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f6f1dbc-9042-42c2-85ca-a117c745c5e8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41c0e64a-97f8-45fa-a2b3-399ed47cddcc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43606bc6-5874-4469-bcdf-fe1b86f66882",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43bf1028-ea0f-439a-b940-3b81b1f4d683",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43c746aa-0830-449b-a594-621f04923cf6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43ca244e-8d5a-468b-b327-ce6bdc541cf7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43f658bf-a5f4-4537-a281-77dbb5ce1c27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4534cffd-7ed4-406c-9cee-23179740daba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "46c82189-5271-43ba-97aa-a7b0a7dbf126",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4779905b-91b3-4878-97e0-58a010668be5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a450a7f-5ca6-42f5-9931-e130264c8e0c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a67e8f3-4dec-41ad-a5e7-18995a14535d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4aa47021-28ed-4c36-81c3-6e2734d3873b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b376f71-ebf0-4762-bbff-e61541afa410",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b656abf-bdc5-4058-a12b-488d93cc1677",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c0b609e-a2cc-4477-b8d7-9fec89d49462",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e99c977-d86c-48a7-8bd8-9e71d999539a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f8cc09d-7512-44d8-a98c-3004c93031f0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50680664-523a-475b-869f-0aa5e0cd88b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "523db500-84c9-42fa-bf24-f66e77e724e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52a0bd63-231d-4620-9e7a-10b6d4fb8b65",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "541a5387-302a-478d-99f2-c98f6d979aaa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55f0346e-6b98-4a1d-99f8-463b81f6a627",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "56072689-4550-44be-987e-b08667758de4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "564ea3f5-665c-45f3-85ee-e4c45d3ba362",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5754a3be-8508-452d-8a64-9d752bde4f70",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5787a57d-27d4-4dd2-b5e1-35e4125a6e94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a04a2e5-489b-4671-933a-1db0a971f40e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a382843-9817-449b-b9d8-4e48d90aef5e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a529282-1b91-46d6-b472-e6386b95cf5d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b26e8ac-df32-4b9d-8992-047e22372332",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b36c084-dce0-4ba9-ba55-613210750e27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cc37e11-afea-478b-b360-1256896a421b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5eaed820-0af4-4157-8fea-1f58baa77661",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5f9a2c76-50a5-4e93-95c9-158ae078c357",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6183a2d7-d2c5-4828-bccb-754ce1bbb002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "618fdb18-11c3-4166-9bb1-79298a32a7a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61efcce3-e4ac-4aa6-ae46-1b7976b5da88",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64a56e1a-be01-40b0-bc09-1fcaf2161c10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "674202c6-8a9b-4c1f-9eae-0ab056cef8d6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "676211f2-1f90-4059-bdf8-9e26f9a637a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6883361b-7a86-49b9-8fc2-90029770fe22",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69191d39-5c1b-4261-b0d7-48a7833e08bd",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69920a1e-2cdf-4b1a-a9cc-329b986e4b69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bdd753a-2706-48b6-b485-23c989a5f326",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c4014cc-3cc2-481d-9cd6-b13c45da0908",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6e0185cc-235f-4603-9470-5f4ca7c92514",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6eee1f90-a40d-4d95-9ca6-0e45689398be",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f001fcf-f1b6-4abb-8d91-7038044fabfa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f055d63-314e-4a36-86eb-ea7e11e820c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f154805-6e66-45a6-a147-87edf4267def",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f169352-0f68-4d11-b562-f693a0158100",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fe7b587-9518-460f-8c8f-7aa43ad55f9c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7203c646-e705-48d1-8141-b2619b227d8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72d46b9b-612d-41c4-8303-8f8571771de9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "731dd6c2-2937-4d4b-8c56-63b5cf581729",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74770ec2-4585-4665-8f69-b2f0d4f0fc7f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "748cbc1e-8d05-4f4f-8196-9cfb28db232c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74aa5d7a-f513-4993-b672-cdf9bb448319",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "752bc953-0f26-4a2c-afd2-45c5f0b9aecb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75ce2f59-fa25-4745-bb37-371fc11ab655",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77035e08-21a9-4149-8d7c-d4266f88ad03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "777bd2e2-cd9e-4d51-b191-c81eb9d113cc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78157107-23fa-4638-bd17-38187695312c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7965d633-4f86-44de-8ea4-fe0c68aa6a83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79876823-dd75-471e-b2b5-80650a4bdd47",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a3ccc47-8f30-4952-8909-ed3537cfe7e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a7cb657-507c-4325-a047-f9d67b6fbffc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7ac3fbad-b279-4d80-a8d7-ff1407a6465f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7d543840-b11e-4380-a147-7dab483cf5ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "809d901e-d7de-4fec-aa95-655deb2301b6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "80f38d33-7c5f-4952-809c-85af1dc69962",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "815f578a-5fd8-4c79-8446-ff236b6ffafb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8191402a-33f8-4195-bd73-3aa71191981e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81c921f4-7fd6-428a-aefe-648e5e11ed46",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81cb9635-df03-42c8-8d68-944f99de02ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "827e88a3-8580-436c-9112-02d58ca2d7d0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85634f26-c60b-4cc5-8c0f-0fad3182a5f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8601b2c5-4e87-49e4-9099-8c21a9ca00b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86513d65-cf7e-49d6-bd16-94286e5d60c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8906cf96-12d6-4eca-8a0b-d39dd78dc597",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "89c5b8e4-4c60-4e08-88ad-4509be08bde4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8a84a13e-c0cc-4496-81a8-f4550c5807ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8abdfc01-6b02-4b55-93d3-eea25b17de37",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8ad91c05-ccae-4482-9f43-f8f197dccdf9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8af7be7f-0ff6-40e1-b206-e89d78430393",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8cefc01c-282b-4866-a0fa-238ed864481c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d1f8204-852a-4342-b836-767fb2b71263",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9017f445-e420-4568-b8d9-0d84b3c46aad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91cb02d4-02ee-4632-a12b-7aaa4b220344",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "924916c0-2ad0-493a-b544-5df45fa43152",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92a51416-05b5-47ef-834f-ad0baccbb932",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "932c7c4b-36c5-4580-a276-a176a72fd72d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9377deeb-6354-4346-8d56-03b29c97d5fc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93c17f7a-aedf-4f6d-8429-df9ff308d381",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "94430690-6bd2-4e48-b0c3-4de11c7f5d81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9445ce49-5efd-41b8-bdab-b8d7f350b5e2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9570f221-d5cb-4963-896f-371af0b32c79",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "958017ca-725f-4d80-b65e-79560a051a03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "976d92d5-de98-47ea-a219-26842c7f8caf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c301f9b-43b4-4015-bc1d-70ad1b2b690e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f0127f0-a604-46ba-a855-ca6be06fcdb2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f2f3880-4997-4c0b-88e8-f9a74f8b1564",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a07ed297-38cd-456e-834f-c31583eab987",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a08d4c19-059b-42bc-83db-26206735e40f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a278895c-19b5-45c6-92f9-48c5f2724e8a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2a34d3f-9082-4d98-9637-2bd936e60256",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2bcb56b-1da2-43fc-b133-3b5c04603123",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a34e2f74-5403-4e43-bc88-30019ebd460f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a39041d7-3a20-4e73-9334-3fc6d8327e06",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4efe1b6-e7fb-4cee-96aa-1125a3888791",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a907697f-9b47-4302-87f3-c4bed83b24c9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad918937-0645-4b89-86d5-0672662fd46e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aee09720-0d54-473a-b585-c62d6c516e68",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1dae3fe-91d2-42cc-8ba7-dcf237882eac",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2b71d89-5501-4bd6-a358-aca8ce706bdb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5b67003-636d-425d-9784-45d374db713c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5e13a1d-86f3-415c-9c2f-4343258a4b57",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8b726c6-227d-4267-8dba-c1bf5ec0301f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8cc3bd3-ac03-46c4-820b-f7988f3088f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bac28c61-4b74-4193-a109-f4456c44cf67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb1dfb9b-70aa-495e-a041-156a4fbb4fec",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd0cb50a-e769-48ed-8473-b25faa687e15",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "beacb4b7-e74c-45d8-b8df-60e1a2a50768",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c15e0f9b-39be-49ff-aff8-1800116358f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c24852f9-007d-455a-8cb5-0e2681c7a0a5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c35ccc97-39f5-4396-bbe1-2a6171f30d10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c37d754a-9f08-4f13-8d26-630d896c9371",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c474ff32-d65e-4d11-90a2-f9ad2e8ee772",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c50585c6-d1df-4eaa-b5bf-317678e7d3bb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5381f46-f707-4fcb-8f1e-605cee507946",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5d36e60-0945-4e35-9239-22f30c29025f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6633a62-08d6-4613-8f06-a3fcfd76f974",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6fcf873-e9c2-43c9-81ec-ba09bd063e13",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c87ce8ae-adb7-4007-8c0e-0090d0926e2e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8e6b9db-dbc9-4d49-a473-2c8593982b56",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8eeda2a-0260-4488-9acf-fddaee71e124",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c941ed50-01c0-472d-8122-3756b9b55a29",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c99efd04-1f14-49e6-bd60-208290d057a6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cae31f17-a52f-4ac3-97bb-6886500b19bf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "caf33f50-8517-4995-a849-4a70bbe202f6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd21938d-8cdf-4c18-a25a-73a2970c2deb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3167af-629a-4795-8c18-cf4f49e0a7d1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3be091-3d72-4512-ba1d-e8466285b930",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ceaa3043-fb10-4638-b942-85d7b5fc20ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cf03ef83-babf-4710-ab13-ace35476b474",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfb34052-097c-4637-b13e-86a2bc255163",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d302b7f9-1306-4a95-85d4-ff189df4b527",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d501bc94-2256-4ce7-b0bf-be4357ada814",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6003f61-89ae-4240-b53c-542ab36728ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d7a31657-3101-42e7-8b97-aa6ff61d3e84",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d99cdf9c-bda7-4807-b92e-34b3de2e6002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db5aeda4-2830-4ddd-a7ca-02363d58bf25",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db604d4c-9f40-48f5-b244-9b3bdcaf71c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db9ccc9b-5149-474b-a0b4-af8a13f01bc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc91cbb3-94e1-43fe-bf92-06077cf48d87",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc94da97-75b3-48b7-bfb6-d46984b5f106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd438551-3d93-45bc-982d-7c338b69983b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e0f91ecb-de8b-44fb-9a15-59c38d5093b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e35c267e-66ab-453d-ba33-a31c4ce7e5ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d54d6e-42fe-472b-b696-6642067802b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e9ca0d20-0315-4fca-b334-e6e046cd076e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea3367e6-6d1c-4e58-883a-b18d66f30f8b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea59937e-0296-4758-95ad-196fce18db72",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb3e277a-61f3-4f55-b179-d474841a80a3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed9ab94a-9354-48de-8695-43131a67bd2c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eec8a34e-e0ea-4a80-bd38-c7db22f84173",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef08937f-96ed-443c-80ac-1f7b764d10a1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef23ec60-f223-44c4-915e-196d6b011b94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efe2c4a0-7529-4f91-9026-696ea0a1f7b7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f03ff26b-30e9-4a60-b99a-780060db1e35",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f102b409-56b3-42b4-b70c-25192033ba8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f20906f6-cdbb-4f93-9ad0-87e63f0782ff",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f39485eb-f82b-495c-8b60-7dada21ee477",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f43faef4-2885-42c1-9035-ccc2667d7fca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f6edd915-a9e4-4713-8e0a-6f1d7efde18f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f7062df1-beb7-4814-a074-e9da66830639",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "faa28a13-3b08-4a67-834d-621e4dd3d287",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb0deebe-ca58-4eb6-ac5b-67442c846405",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc72a988-3078-4c69-a8ca-c0f1dc1ec996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fee54746-70cf-44dd-98df-5c09bb8959a8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffcc6812-deda-4b92-b2dd-0f59e0a46c44",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 244, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "71d2bcf6-d6c0-468c-900e-baed4920fb52", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 19, 4, 47, 46, 246, DateTimeKind.Local).AddTicks(9854), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "11ebdd3a-f75a-4d85-9916-220874cf8af9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 247, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "152002fb-d980-4750-a70a-7b5d0bdac9e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 247, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 247, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 4, 47, 46, 247, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "54be337e-d97e-484d-b5eb-6bb113b75c8a", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                keyValue: "0752146a-41f3-4328-93e1-bfdcf263842a");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "0adee95f-f2ef-42bf-b33e-50ffc3a36f5f");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "0c5dab5a-6ccf-4d07-95de-18ff83557459");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "153b12a7-82ef-47d7-9846-b9323774ef6f");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "5ccd4008-6646-443b-a90c-ac4b64245677");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "700871fc-0624-4745-a000-39862d1e2cdb");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "8fd35c4b-2a59-4104-b45e-ff732e67c471");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "afa2ee37-daf8-4b8e-a8cd-16df8c959b7f");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "b32a1327-37d1-48e9-bebd-7744a0cd7c0e");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "cd177bd8-f5f5-4e0c-ab7f-997f56576539");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "f35e30b1-871c-44f7-8d64-dc27b8d1e645");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "f818bb04-375a-413d-81fd-439e7ce93ce4");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "03672d96-dfe1-48dc-9497-f3844b167f03");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "1c1e5ab6-dd4a-431d-9452-b937667e2922");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "2b61e3b0-f129-4a9b-bdc4-6791ad4b739b");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "2bd90bd6-bd81-4c3b-8cc5-87a2947b65b5");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "4b403dd4-e5c7-4a21-9bb2-9fa5d9b56782");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "4d9b0ada-32d4-454c-a9a8-b883cd46a064");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5f463310-e7b7-4ed8-a83c-e375094415d2");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "6ee3c462-9044-4c80-8689-9975c2b662d2");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "730f0497-7ada-400b-b6c4-f5eaeca9540a");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "771c405e-3d89-498d-b2ad-19f12dc73ca1");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "8463a5fc-2463-4a14-9ecc-35f3e2f3fb18");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b88e555e-f7e5-4bf1-a7f8-8c44203bb23f");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "bbaa0cac-eab7-43ab-bfe1-2cc301932825");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "c1d6d8c4-0af0-4b3d-ad9a-6e694d78f25e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "c755a514-5822-4e03-9991-e5e7ae877c0f");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "c86a703c-693a-4849-bb81-08e72002d6cb");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "cc104b66-3f92-4bae-903e-889a79207d9e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d00f0b2f-79cc-4c57-b677-e284ed5121a3");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d584b52f-e92f-43c0-a679-2206d5a8a004");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d9747fef-3f72-432e-beec-fd04f5405348");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "db561cb2-1843-4640-bb25-0a75408af44e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "e417e2d3-2534-4fe7-ab1e-277c235d9f92");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f4362030-a76f-40d3-93f5-5fbfa9f834ee");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f9e5af5a-9a73-451c-97fe-656716dcba7c");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "2eb517aa-34dd-4750-996f-cfb6db3fde8c");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "53311321-d11b-446a-85bd-46c69ef81e76");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "cc72a668-2fa2-4b35-b776-9a985a5fbfb4");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "e3816187-23cf-4b02-b74d-53f0409daf67");

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
                keyValues: new object[] { "beacb4b7-e74c-45d8-b8df-60e1a2a50768g", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

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
                keyValues: new object[] { "c87ce8ae-adb7-4007-8c0e-0090d0926e2eg", "11ebdd3a-f75a-4d85-9916-220874cf8af9" });

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
                keyValues: new object[] { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d" });

            migrationBuilder.DeleteData(
                table: "ProductSizes",
                keyColumns: new[] { "ProductId", "SizeId" },
                keyValues: new object[] { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2x", "152002fb-d980-4750-a70a-7b5d0bdac9e4" });

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
                keyValue: "71d2bcf6-d6c0-468c-900e-baed4920fb52");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "54be337e-d97e-484d-b5eb-6bb113b75c8a");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ProductSizes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
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
