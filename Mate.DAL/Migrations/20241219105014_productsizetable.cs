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

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId" });

            migrationBuilder.InsertData(
                table: "FotoDesign",
                columns: new[] { "Id", "CreatedAt", "Name", "PhotoPath" },
                values: new object[,]
                {
                    { "16632797-554e-4dd4-8f0c-0748873316bc", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2492), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "1aa0d393-0974-475d-b618-e90b54ad375a", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2502), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" },
                    { "21e4f76b-45e9-4d12-8eff-cd66600703f6", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2517), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" },
                    { "22afdc79-87aa-4194-b0a3-bc96925481b8", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2521), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "5cc444e8-6e92-4cdc-a0b5-309b2e1ec567", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2480), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" },
                    { "5ec205e4-39af-47fb-ab2d-d6779a0da4ea", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2525), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "67856786-c2f1-490b-9962-5080764c48b1", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2498), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "6c4c7eb0-6ba4-4e62-857b-e87bafd6f665", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2470), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "6f955a5a-0a5a-4e4b-a5f9-c205e14836fa", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2475), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "a4786639-cb5a-4bdd-b2c3-436c97875b38", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2511), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "bb42d09a-8904-45e1-8bb1-59fb95a4f2f7", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2506), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "d1905e6c-4d73-4588-8356-b6dd57b137dc", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(2425), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "0afd72ce-006e-4086-a5d8-aa4bb250568a", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4702), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "242ff0a9-1519-4e4e-b52b-c4e7cad71639", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4765), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "24538033-ea29-4dfa-be63-286df4aaf58b", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4725), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "29b7a882-8046-4f62-814e-ee0e99c7aca4", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4732), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "2ba6ee82-8150-43c6-9ce1-1c73f18b84e2", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4754), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "3267f577-95e6-410b-b2c4-10aa1c99bfb4", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4683), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "333fee66-e241-48a7-8507-082d6d34ad29", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4729), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "3e7b8203-5548-4fef-94e3-d01a0a7e569f", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4693), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "478b1e27-b3ca-4bf1-825a-086457cfc827", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4761), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "4a575fd6-e952-44a9-86ee-c8572b9c14e0", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4758), "/databaseimg/galeri/galeriIMG-8454.jpg" },
                    { "5b16dcc6-002e-44b6-950d-de068efb8f39", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4713), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "687f8f27-5ce6-41a4-ba8f-571e64c2a967", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4707), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "80e58a3a-48a8-4ffb-8461-80e7679f829f", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4721), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "866e67f5-4005-474a-a48e-3bd4810ce642", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4736), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "8c6eed63-a3fc-4c74-a400-340234ee6062", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4750), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "8ecba55d-147c-4c81-b09a-2b551cc590af", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4740), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "97a32430-2539-414c-8a3d-9a589c5e758c", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4675), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" },
                    { "a2cbc8b5-7fdb-481d-a510-fbb2aa531cc7", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4717), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "a4a200de-d8da-44fc-8958-0ffd53ab3001", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4679), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "acce86d6-d18f-45b2-b983-9ff28061ead0", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4698), "/databaseimg/galeri/galeriIMG_1958.jpg" },
                    { "b3bd5386-72a5-41a4-83b3-b4670670e637", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4768), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "d8d7f937-dbca-4d34-a9be-aca3481c2b41", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4658), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "e43a46ff-4203-4213-8327-650900184885", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4745), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "fbf4ab74-87ec-4d75-a2e6-12f9ad483816", new DateTime(2024, 12, 19, 13, 50, 13, 96, DateTimeKind.Local).AddTicks(4772), "/databaseimg/galeri/galeriIMG_2688.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 101, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 101, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 101, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 101, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 101, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 101, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "11ed7f43-a26f-45ba-a241-644be7412422", new DateTime(2024, 12, 19, 13, 50, 13, 103, DateTimeKind.Local).AddTicks(6002), "Siparişiniz Kargoya verildi" },
                    { "20af44f5-d296-4a3d-a45f-013dbc699f6d", new DateTime(2024, 12, 19, 13, 50, 13, 103, DateTimeKind.Local).AddTicks(5973), "Siparişiniz Alındı" },
                    { "75128f11-db49-4f4d-93a9-62a5da419d2c", new DateTime(2024, 12, 19, 13, 50, 13, 103, DateTimeKind.Local).AddTicks(5991), "Siparişiniz Hazırlanıyor" },
                    { "9525d2ed-c1f3-4c76-8369-b722425c367c", new DateTime(2024, 12, 19, 13, 50, 13, 103, DateTimeKind.Local).AddTicks(6006), "Siparişiniz Tamamlandı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 103, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 103, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 103, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 103, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 103, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.InsertData(
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId", "Id", "SizeAmount", "SizeNumber" },
                values: new object[,]
                {
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bc8266b1-40d2-412a-936c-e3a776b26c26", 6, 12 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8543e94e-55da-4e2b-96eb-c9109494b96f", 7, 14 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5ac7445f-3e53-401a-bbf3-d814c5264ecf", 4, 8 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fff0b3cd-f663-4061-bd35-12c8222c4d19", 5, 10 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2ae509e5-cc9d-4eb2-a901-752e61df3e80", 6, 12 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4b9d3485-9d17-4549-957c-7e00c25efa9f", 7, 14 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "02c863cd-7901-4eb9-9e8e-b3bf51d2a527", 4, 8 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2973064e-47f5-4e15-a75c-31fd5db2a238", 5, 10 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "84cf688a-c29e-46ab-824d-e208c8578c60", 6, 12 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "37aad57e-21f9-4b4f-9d16-a20ee16a1b43", 7, 14 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0063f6b8-27bb-4aed-8464-74eba53c8cfa", 4, 8 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "151b1fb7-3761-4e2f-bec8-e0f3f193d405", 5, 10 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fb54dc09-be7c-46e2-9ee6-0290154e8524", 6, 12 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f409dadc-c729-487c-a435-05b48b11692b", 7, 14 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b471ee86-f4c9-4a45-83dd-f530a5355801", 4, 8 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e903aa81-f0c7-4243-8506-2ccf75bb41b3", 5, 10 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "39b8f16f-288c-4509-9ba2-6d6ee6e57c3c", 6, 12 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a46c3696-a768-4bfb-a607-ec5ba44c5d75", 7, 14 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ebb901e5-8706-4a0e-af62-0c06e3bd5400", 4, 8 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "820921bf-641f-44f7-91b7-996b446e54e7", 5, 10 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "df377ff0-265b-4544-ae56-a087dc654e92", 6, 12 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a5002d82-a375-43ff-aac6-cceb6e25ddcb", 7, 14 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6ad7d66d-20c0-4712-94af-754047082128", 4, 8 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a35fdd9e-db22-4538-a074-b81fb3cf3c19", 5, 10 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "45db65a6-7904-462a-8eb7-bf36f73befc1", 6, 12 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cb6f2e14-93ec-47ee-bd7c-440846595b6e", 7, 14 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "10c4acab-19c7-4279-9720-fc6d2ffe199c", 4, 8 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "59d98e54-f44b-4bf5-9156-ea2a484e0f92", 5, 10 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "639289a4-680d-4c2e-a1a3-d0aeccadac95", 6, 12 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "123a7314-3370-403c-921a-dff665d9afda", 7, 14 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "27c29458-ead3-4389-a7e1-7834c9292634", 4, 8 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bdf248d2-42d7-4c41-9f3a-36008b1fcf10", 5, 10 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "423a6c0b-a078-4d3b-b220-76e52bad110d", 6, 12 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "11223c9e-26fc-4a4a-a6f5-4beaa08ebfe7", 7, 14 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "63538ef2-a370-42ff-af29-d5d26142efd2", 4, 8 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ec2b0e6c-c50d-40a5-be40-628f2a51bb3c", 5, 10 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bf5b4f1c-a224-415a-b86a-67821a56431d", 6, 12 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cf71ed10-14ee-4388-9b32-43ac1bd57ee3", 7, 14 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1a2d6402-21a5-48fc-8726-22f67625ab7b", 4, 8 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e8c5fc72-9611-4004-bc06-eec0116b9a5d", 5, 10 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ab7e72e7-38d7-4900-b56b-b163d192a296", 6, 12 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8924ceea-1d91-4780-ac5e-88329b1b4b59", 7, 14 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "06dda27a-cd21-49d0-8d51-1cd0bc3585a2", 4, 8 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3eda4567-0c27-4e6d-9297-5cc8d3fb838a", 5, 10 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f19b7f5e-88a1-475f-99a6-6772c580091b", 6, 12 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "576303e4-5762-41da-ab06-201bbbca310e", 7, 14 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b728d3f6-ed7a-4e00-9fa1-eddb50998f6b", 4, 8 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "61bbd6d3-4690-4c95-87bc-595c69751d16", 5, 10 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7e08f674-2681-491e-b5aa-3afb89567105", 6, 12 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b0fb8e5e-ff9b-4423-b62d-9c380a279765", 7, 14 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6eb69f9e-6506-44eb-9d70-da7dc4e8fa6b", 4, 8 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "128bfdf3-f361-4bd6-9fc6-aa40d4246f08", 5, 10 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2787c914-5d8a-4e77-9649-2d4a24983dcc", 6, 12 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b19582e0-07ae-4efe-b2bd-dc8da4b8c763", 7, 14 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ff4da91e-8be7-4b6f-ac7e-93bc33956b82", 4, 8 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "97a545de-6f65-43ce-bd16-e4732232d1ab", 5, 10 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "65014a0c-075c-4b7d-9d76-64fefb7506a3", 6, 12 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "703975f3-bb81-40d7-a4d0-554833085d23", 7, 14 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f7e41b02-f6c4-43f2-ba82-59bacd255159", 4, 8 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d700ca76-449a-4875-aa59-92519040b273", 5, 10 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b577725c-fff5-497e-8068-149ee37697ff", 6, 12 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "02030448-b83d-43d1-b512-8430325bc28f", 7, 14 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "44e8ccb3-3933-4311-85ff-6a15203e1673", 4, 8 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "882c1f82-da8d-476a-b99c-c046087e5092", 5, 10 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8d74aea8-94f4-409c-96ef-7132bc0adf4f", 6, 12 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9cdedcb6-714c-4337-9ed0-624a59d1ef4f", 7, 14 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7dfe5cf7-848b-4856-8cec-339d78bba265", 4, 8 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "446e214f-378a-4491-9408-359aa3e59380", 5, 10 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "efc4b521-e287-4681-bb2a-bc838b23c586", 6, 12 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e0c9ed35-73aa-4b42-adac-de903df2da1c", 7, 14 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e779a1fb-933b-418e-8ccc-7935c29f5e85", 4, 8 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "72be1549-33c7-462d-a979-afe7258bd569", 5, 10 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1dd87ab9-6602-4805-8fa2-1866845e7614", 6, 12 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5a261277-8109-4193-8d5a-211b351020aa", 7, 14 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b55ddae1-06a5-4e3e-8b94-8e1d833bfd4c", 4, 8 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "60fdc295-cf65-49d0-9242-3ef79dacf9e2", 5, 10 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "176500c2-3822-4844-a619-29493fda6095", 6, 12 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d36fb183-4983-474d-9d2f-52edda6941a3", 7, 14 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b70c0027-250b-414e-85b1-c1f48e53c168", 4, 8 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a96863d0-d9b8-4603-95db-bc570e70dc6f", 5, 10 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "18abafc8-b0cc-4137-bfc7-d8caa74876b9", 6, 12 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a24f1e46-70b8-4441-8af7-29fd81a1331f", 7, 14 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "13b76e0b-cdf2-493a-9d57-7ddbe07ea359", 4, 8 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ef5fc52f-c9b4-4ff6-bae9-8547c336db12", 5, 10 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2541b524-ede4-45f0-b9fb-ae84c4970f94", 6, 12 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b29b815a-7b01-4161-b913-8dfcee5fce7b", 7, 14 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "de12033b-1215-4487-9b53-4e92032040d4", 4, 8 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0ee0554b-595b-4dd1-b200-e81fbdc4a032", 5, 10 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cbfdf33d-a5e2-42d3-a83a-16cef4559d0a", 6, 12 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cee9a9f2-e556-40de-abdb-2d66cffb05fe", 7, 14 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "91e17268-73b3-49b5-8875-026855a8e118", 4, 8 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "62f5a9ec-267b-437e-9812-3628a05e761b", 5, 10 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fd3b7b47-bd78-45d4-865d-e48b406ea7cc", 6, 12 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "69873e4c-0a92-4570-b3fb-0db07de61ba6", 7, 14 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1118ce94-aa39-43de-b6bc-0eade556f9b7", 4, 8 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bb1239cc-091b-4e2a-86e8-e86cc940d159", 5, 10 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dd46341b-8504-4bbc-bbe4-3ef95d62140f", 6, 12 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e1f71bab-f8bd-4fbb-9d1e-dbb0148b38ed", 7, 14 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "626c9b49-45d9-4891-b787-6378a4ceef14", 4, 8 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0f86433e-882d-4c70-afc7-93258f6b3f79", 5, 10 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "12678bcd-e77f-43d9-aee3-ef82e6743088", 6, 12 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fb8aa055-4186-4e02-b349-2177e0a78f96", 7, 14 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f9f57481-39ee-4a2c-802e-b85679594b58", 4, 8 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f6387f47-fbc9-4062-b3ca-bb46a3155fce", 5, 10 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7eb3b4d5-3bc2-43e7-8b1f-4457e3055bf9", 6, 12 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b5407efc-59c6-4f20-84cf-a8ce9bb54a66", 7, 14 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "81fe8352-f294-4aca-ab7b-854ea35c2407", 4, 8 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b09c8917-ca8b-44b3-9e19-303bf070abfc", 5, 10 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d9776c70-a122-4833-a859-fa0349a07932", 6, 12 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a33f5067-ac46-443e-9f46-bb425175fe89", 7, 14 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8fb88562-3103-4098-9373-5cca9ea68ef4", 4, 8 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c05345c5-ac31-402e-b7f8-851f936495f8", 5, 10 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3629b198-4515-44cb-8b7d-2d9925b37f13", 6, 12 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "394f1873-6dd3-4a39-bb2c-0d0755b2c2f1", 7, 14 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0fe812ba-0feb-4550-8660-38dcacf0784e", 4, 8 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "615436a2-e150-4fef-b392-26f49eb1a027", 5, 10 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4d20accf-4f60-4837-8643-7d41d772cafd", 6, 12 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "19216bec-2891-4b96-aa32-34d622a78990", 7, 14 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6b710b13-e855-4501-80d8-6190cc9be391", 4, 8 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "78091fa0-c3eb-498a-8222-d1374b8f58a7", 5, 10 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "18f7df5a-b589-4602-918d-1984911842a9", 6, 12 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d14f119a-7b29-4961-853a-19a78e4af38a", 7, 14 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "57d7b2b1-db68-4ad2-9692-b574e614bf2a", 4, 8 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b67f6dd2-c373-415e-bdf3-0c07adf7741f", 5, 10 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5f9ac889-b35f-4897-8e4d-345243d07f41", 6, 12 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3fee2088-2747-45eb-b264-67fe6c10d849", 7, 14 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c3c7edc6-c5f4-4702-9bac-54324995226a", 4, 8 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "60b8f94c-8255-4d2f-b3d4-1954e630e7a5", 5, 10 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4dc6cfaa-3a54-45a9-8175-537f7f0068c1", 6, 12 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e59f78ba-a0de-4674-b9a6-aea22af0426e", 7, 14 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a79a67dc-9343-4a6b-ab4a-3745e860dd7c", 4, 8 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7a17c741-aed7-4edc-bb4e-a02a3e338684", 5, 10 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c463d81d-c595-46f1-b017-811023ac8d5c", 6, 12 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c8d9592b-70f2-4d3b-8b4c-fc633e9b8dbc", 7, 14 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2fffd18f-45a0-4ca7-be9e-2a53eae14629", 4, 8 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b7756dc1-c4dc-4782-999e-e5dc12c4f81a", 5, 10 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4d4781a4-6c16-468a-bf4d-f5589af4e28b", 6, 12 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7d15669c-eb37-48dd-bedd-9bcf84c31ec1", 7, 14 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a65575c4-e078-4ef2-a43d-3f5923add7da", 4, 8 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b5db1406-0064-447a-84db-3f04bbc46d85", 5, 10 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8d454c1c-55d3-4e9e-a387-d360b6626096", 6, 12 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "42657ea9-04d5-493b-bc24-bc1f9e925908", 7, 14 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9d911920-4409-469d-854e-1ac3492e268f", 4, 8 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4dac6e85-0874-4334-9820-bac656379082", 5, 10 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fefe65d9-2306-420d-906c-173d5b26f931", 6, 12 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ea31e88f-833b-4e7a-90ef-2aa72fc3a9f0", 7, 14 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8610baeb-edf2-4bc8-adfc-27e747a89e60", 4, 8 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9aec4d5f-382f-415b-8fde-78c0713e8414", 5, 10 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b4baa90c-949f-4e2d-967b-61aac02a9e4e", 6, 12 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1ab7ed87-a79d-4f27-adbb-0171f8ac1c42", 7, 14 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2303e935-72c2-469b-870d-908625072ba6", 4, 8 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "56bc3bfc-2ada-46ed-8532-2e4d5e9fb102", 5, 10 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "14f37c95-16bc-4a3b-bf85-59850bca5342", 6, 12 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "022704fa-25da-424a-bf46-d0c4f20747cf", 7, 14 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8e05c2af-1cde-48b1-8bc2-a572d1b34ea3", 4, 8 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b79eba63-22d0-491d-b0a4-83f8696b2d70", 5, 10 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f859a428-a960-4a96-91b2-d1bb402ba993", 6, 12 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0648ae90-1bad-4cb8-ba5c-fda7bce9e80a", 7, 14 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "47cd23f0-fa83-4ed2-a5c2-afa7f329c339", 4, 8 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4808152e-4443-4a6d-9e24-e4b0457e0e46", 5, 10 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9aa7281e-4d98-416f-9bb3-7b91117508fd", 6, 12 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f08e174d-1068-4805-a3b1-8fda036668e2", 7, 14 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "746d2e76-a672-41c2-a76e-4ee49ef16eb7", 4, 8 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "32fee7a4-8286-4387-a60c-98ee315c9987", 5, 10 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "753b13f4-9767-4c4e-8fa1-89c12c9baf9e", 6, 12 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1eec7125-e721-406f-ab29-4d66ec6f912f", 7, 14 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6ec8fba0-dae2-4f5a-a00a-a1f3d311ef5d", 4, 8 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "399b35b9-e15f-44b5-b9b4-08203ea074b2", 5, 10 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "904c6f8c-25d7-4a27-9513-75c7cbede114", 6, 12 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ac4f108d-79a0-4fa0-b158-c54efa480953", 7, 14 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8885b805-e265-4ffa-9d1a-862764f40e52", 4, 8 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "75f82366-5569-48f9-81c9-05cc6ccf0bd3", 5, 10 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a6b13abd-fa61-4758-8d25-63e3fb854262", 6, 12 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "584b5545-6b69-465c-ae6d-96b594340839", 7, 14 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e67866bf-99e6-4496-ba83-cb8e0bb21d69", 4, 8 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0edd7156-20b3-4ebd-a9af-9d70827321e1", 5, 10 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "51f18698-abb9-4e88-b8c1-1764bdac9155", 6, 12 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cc78e6d3-dbca-42bd-99fe-883d4adfedfa", 7, 14 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2a957bfd-32cc-4e6b-b080-34bafd6c5012", 4, 8 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cf8f0d35-b101-49a8-b6d8-399dd7fae5d2", 5, 10 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1da7b3d1-3dcb-473a-9c42-cab7bc24dcaf", 6, 12 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "252b3498-8e19-49e1-a094-c24f5e30a2ab", 7, 14 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2892e3e4-a775-4a21-99c9-c042b225b1e6", 4, 8 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5530772c-8bf3-42d8-b0d5-871cfab50538", 5, 10 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2e468347-5489-4df3-8e03-99e54d4e839e", 6, 12 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3554b00d-4fbe-4fa3-b193-bb578c14e32e", 7, 14 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a9395326-3f24-4ecb-9ba3-baec0d9e8bc7", 4, 8 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "df90bbcb-02e3-4ec8-8f0b-f641019d9e77", 5, 10 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "41f78b82-5eac-4d86-89ac-385dc068c375", 6, 12 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1cabd5c8-3ab2-4d72-89ef-dc44308fac68", 7, 14 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "52ca8252-73ea-4952-8977-82fe5a64556a", 4, 8 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "47b3bb79-244c-4892-881c-7a1dcfaa936a", 5, 10 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3f3de3c0-2f71-43a6-9be6-9103a67d7732", 6, 12 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ae795845-98dc-4fe2-9505-b4e5aeb9c118", 7, 14 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d78dfc71-2ddd-4d4a-833e-bc2258bcbd8a", 4, 8 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d69fdd5f-18c5-4375-8e92-84c1faebb403", 5, 10 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "614fbc61-60da-4865-9cd0-6bba38045b76", 6, 12 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1056b128-edfc-49ac-9249-adebb7d1f17e", 7, 14 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "51cb53ca-902b-4b54-a38e-a3094de180a4", 4, 8 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ecfdb7d1-c19b-4a59-aa17-d521fba52e54", 5, 10 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "326774d4-d656-4736-b28f-1c42356b2894", 6, 12 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7ee40c4f-21f2-454c-a154-fcaf04e56c86", 7, 14 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ff75f3d0-8dcd-4806-98ac-50af5a3e4cb9", 4, 8 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d9371e80-15a3-45c8-b090-cd584079bcb1", 5, 10 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7e57186d-5b5c-40ee-b71c-d36b5903aa12", 6, 12 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "96d38849-b426-4201-9342-4674142e799e", 7, 14 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d16b2442-cfec-4977-ac6a-9dd503b210ad", 4, 8 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "640127ab-d89d-437d-bce5-4b7204fd179a", 5, 10 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "346d87b5-0d66-440f-bf68-be2ca59e813e", 6, 12 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "de06170a-3074-421c-bacd-20cf51c88c8f", 7, 14 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4b373e0e-2426-40ea-9eeb-76db331deca5", 4, 8 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2a11985d-634f-4575-8390-6008f04730a0", 5, 10 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2bae828f-7b38-42e8-99e1-fa19258072de", 6, 12 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e847c182-37e7-486d-aefc-4a28cbfdfd63", 7, 14 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9cd38309-41ae-4ae4-9236-eb52c8c596c9", 4, 8 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9977e355-971f-424e-b98f-4876bfeccbbf", 5, 10 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d60a81a9-dd54-4fe9-b21a-b639ed5b7049", 6, 12 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e48be2e6-c72d-42c6-b8d8-01deff1dc034", 7, 14 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0e5ce820-4acc-4fe2-8868-6ec0cf93d244", 4, 8 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7b1c804d-78dd-407b-aecd-b46ca0efb9f2", 5, 10 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5d710a8d-9032-4663-badb-0e1a73306f2e", 6, 12 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6575e121-4305-4e73-82d7-3b8752ca8d64", 7, 14 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "863f5c46-4902-4440-b170-a1198f841281", 4, 8 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8ecbf309-48ea-468a-8733-a96b2c5aee5f", 5, 10 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "61434931-de99-484f-85aa-8312e706501b", 6, 12 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ffb1d351-0a0d-48c9-805f-c71ac29662b8", 7, 14 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2fb60070-b446-48b3-bbf2-aad3f0872a8f", 4, 8 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "496a5587-53bf-4250-bfb1-c2e6f6e31943", 5, 10 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "514b4893-81da-4da6-ba24-742bb301e202", 6, 12 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9ffc178e-7019-4d2a-b0e5-c6341211819c", 7, 14 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e0b2b12e-7187-4c31-83c1-ddf37f5a367a", 4, 8 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "958b5a7b-1bc3-4b2b-ae25-4d6c0d22c5c6", 5, 10 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "406c7b75-f0d5-4484-a52a-7bdbbc716ad4", 6, 12 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1068c77c-cfec-4507-8c2a-20499f868814", 7, 14 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "21c6eeaa-a2f9-4106-9a72-3d553821c092", 4, 8 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5e2f9e3f-4908-42c0-8d2d-430211576ff2", 5, 10 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bb43434a-0e25-4116-b5c9-2481c0ded29a", 6, 12 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ecfe9bac-d22f-40f8-a456-4ea6f89ea2db", 7, 14 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "30b912e2-a60a-4f1a-8e38-d6d183820e9c", 4, 8 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6a461276-4b60-4685-85c8-395aa784923b", 5, 10 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2ca842a1-cc40-4813-ba94-0bbe9573b135", 6, 12 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "75579849-4aea-40db-8502-a05398e5efb1", 7, 14 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d27322e4-a797-45da-8063-98ffd392bbf6", 4, 8 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a7ba376a-6196-45c3-81d8-3f8bbd446dcb", 5, 10 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5e46bb48-d443-469e-8a73-beb55daa957b", 6, 12 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f186d7e4-2c8b-440b-aa8a-a6b71ccf8fa8", 7, 14 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d1aeadb9-d2fe-47c3-a8bf-4cdddc627835", 4, 8 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c5d76c67-2347-4571-9859-898135ac978b", 5, 10 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "24632c6a-644e-42dd-93a1-da7429d3ad05", 6, 12 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9335dad6-cdd5-49ab-a483-9d12a03d1aa5", 7, 14 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "302c6529-78d0-4adf-8712-255f213dea20", 4, 8 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3903fd58-8166-4165-b7cd-f956e72e8282", 5, 10 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "80ad9ac6-eb4f-497a-b990-ff46d62a939c", 6, 12 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b3df4243-1e60-4b55-aad7-c908b5613b75", 7, 14 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "59619675-3303-4967-8627-782132d9f17f", 4, 8 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "63374968-acba-4640-bc76-ccb2ac520c3d", 5, 10 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1b2a850f-1eef-40df-978d-22c822e34a0d", 6, 12 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "243137c3-3900-4fde-a2f0-cfb393db3966", 7, 14 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7492e339-86e5-4776-8553-84ef5872774e", 4, 8 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "afc5478a-5f7a-4bf7-b762-6148833449c4", 5, 10 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1e42c3e6-b205-4680-981f-91e9ce91c89c", 6, 12 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "53c8c90d-d313-4710-9270-6586bb29dbf4", 7, 14 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f6b07789-f6ce-4eec-8253-6e7535a670d3", 4, 8 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6724acff-5f20-455d-ac8c-499c0deed28e", 5, 10 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "87ddf67d-e82a-465b-a6e7-d681354326b7", 6, 12 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "413cdaf2-df9d-4eea-9fb1-3d9e242f14ae", 7, 14 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "311575d6-5603-465f-8bff-1a6b9b3d1178", 4, 8 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "750688a4-a0a9-4816-98df-37213d0128fb", 5, 10 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "82f3258b-fb1d-40b3-9eb2-62dfe5a2a3f4", 6, 12 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1466cc03-40a7-4415-af39-42cb3fef54df", 7, 14 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0e03e3b5-d924-409b-a2e2-f7fbaf9bd403", 4, 8 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9850fa29-e19e-47e5-8862-e249fea5f374", 5, 10 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "43b6331b-1b45-43b4-9eae-ccf6030f42e5", 6, 12 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f5d504cf-8e8d-4151-b176-fb8518e6c6ac", 7, 14 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6420d118-b6f6-4bd5-89e8-1b6343f0f313", 4, 8 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0ee74e8c-76ab-445f-8028-89c3ac9ba305", 5, 10 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2e400abc-723a-4abe-a589-7b53645605ce", 6, 12 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e672fd9e-7f1e-4572-a1e2-1d49fa3746df", 7, 14 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c0c23035-48b0-43e0-ad07-1901fe583123", 4, 8 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6902c9ae-1967-4111-9aae-e696a88e58ee", 5, 10 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "995ce72e-64df-48ac-a2b2-0d55ae0b426c", 6, 12 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d45bde9a-d71e-432b-8d63-53ea52a15d7e", 7, 14 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2d676c97-0ac0-40a1-9f4b-a2ad44ffc7eb", 4, 8 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "916bfa94-7d52-450c-b918-027b01e7afb1", 5, 10 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "888d6f5d-7f77-4d91-9c9d-7cff3ffd3208", 6, 12 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0cf4c1b2-7515-4454-b2c6-4a870e02b571", 7, 14 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4b0b5f3e-8dda-4a48-ba31-85816c02755f", 4, 8 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a94685ba-9320-4688-b186-fd58e37292f7", 5, 10 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "401f671e-fb5f-44f1-afb8-cb7fbd969a68", 6, 12 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "be3c222d-febd-4568-bac5-ddede64b331a", 7, 14 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "55972ab4-c5c5-4cac-8eb0-8886483f0a36", 4, 8 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f6f568c9-8641-417d-8794-a3e7d455dcc3", 5, 10 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "57e58d03-7a45-4d9f-9f0a-b72e4bcb8d6b", 6, 12 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e6f24605-2bd7-440d-a660-c166b276da0f", 7, 14 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e4cd3389-a663-45fb-a10d-2222c5999a3f", 4, 8 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0119535d-5dc9-42ae-863d-a4d5f0fdce0a", 5, 10 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "52d0c3e6-bc1f-405c-bfbb-c200bcb3b06b", 6, 12 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "15d71e92-4184-4498-8275-221204c15117", 7, 14 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a7ea51a4-0397-40a3-90e3-77702910f8d4", 4, 8 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "83166a47-3312-4794-957d-6c2a941e8498", 5, 10 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6f7ec1e8-2798-4f0c-9735-4e744139e342", 6, 12 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d3bfaf68-2cce-4a63-969d-ff952bbbdf37", 7, 14 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e34c5ffc-a1fe-4c23-81dd-bca8091f4f9d", 4, 8 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "08aec9ed-04c5-4605-ae8f-b8ae5691fcaa", 5, 10 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8c24465b-c069-4b36-beb7-938567008e01", 6, 12 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4670277b-6d40-46fe-a5bd-282e4bf59dcf", 7, 14 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "539ae27f-2919-44d4-a44d-cbcd8c9c00ce", 4, 8 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bacf39f1-ea16-442e-9308-385aa8646c63", 5, 10 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "55685c1c-5cba-4ca7-aacc-690a59e7e7d4", 6, 12 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3cc395be-4e96-4730-b4be-3f0d8ff9f917", 7, 14 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ee85abcc-3011-4da5-989b-6c23bcc8a141", 4, 8 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2a561c1d-f74a-4319-a64e-ba092116a05a", 5, 10 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cab0b355-8c76-4323-9e7e-eba93f6ce455", 6, 12 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "48d8ecaf-935a-4009-9758-e0cd88b4c08c", 7, 14 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "83ee4c46-9121-4cfc-9a83-2bf188b770f4", 4, 8 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b9c43056-ffd3-4b3d-9c39-7b93df4cb686", 5, 10 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1ee8334f-6010-4bb4-9b2e-98d94ec4e33d", 6, 12 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f4962039-c449-4ca6-8944-ae17c763ab46", 7, 14 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ae6a4267-810d-4e90-815b-4dcf3550eeb3", 4, 8 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5af10b32-e312-4dcd-b75b-3b774e51009f", 5, 10 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6e8614fc-1f93-4e81-b376-de3ad24e813c", 6, 12 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4f76dc01-0973-4eec-9ffd-5df4b27ff16b", 7, 14 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "be5d81ba-5181-43a4-8757-c682d2e342a4", 4, 8 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "823e9a21-b23f-407c-8a47-6c1d5cb16ecb", 5, 10 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "041692ec-0abd-47d1-a294-535728823f0d", 6, 12 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "eab5b1bc-d3dd-48a2-99a6-cafd932ef24e", 7, 14 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "197e659e-6e33-4759-b9e6-ca06035e3ec1", 4, 8 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "95aa17bc-5b73-4943-a9a3-b33b5f8c11db", 5, 10 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a844f0b0-9038-41fb-ad24-705daf58cf70", 6, 12 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b3135f01-d3f2-46fe-bc3d-0e8faf12d24d", 7, 14 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e91a50ba-8885-415f-a6cf-96e5f7be263e", 4, 8 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e48e52ad-a366-4174-b7cc-9e63e21bf31e", 5, 10 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7d143197-cfee-47ac-abd6-8c4a536e68f5", 6, 12 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "db3fd6b1-26ed-4ba2-b7a4-c76e8e9e9996", 7, 14 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f841858d-e1aa-421c-be1f-6a2fd18f7344", 4, 8 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "642e6b45-5d42-46d6-8309-7d9137cfef4f", 5, 10 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "879e62f0-c91b-452b-873c-8cb20a9ad6c5", 6, 12 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c319c891-531f-4aa8-a738-0ddfff4de11c", 7, 14 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6f5e5fb4-65ff-43ed-8542-8bc7857a725d", 4, 8 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7706e94b-2451-4d31-8707-1c602604365e", 5, 10 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2e45d9f1-cf55-405b-92b1-f99b6c2aeb61", 6, 12 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6f0b994e-305e-4227-ac96-ae1f5af827b3", 7, 14 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "95132aee-eca8-4325-b453-74023d116c5b", 4, 8 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "015e23c6-3ec0-49eb-84b5-c2923e874554", 5, 10 },
                    { "56072689-4550-44be-987e-b08667758de4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4c008477-079a-4a8f-8b6e-f186a0a6167f", 6, 12 },
                    { "56072689-4550-44be-987e-b08667758de4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "04c353ff-7446-4a1f-b14c-480cf282bdf2", 7, 14 },
                    { "56072689-4550-44be-987e-b08667758de4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "71a43f06-c139-4638-884c-80640894e444", 4, 8 },
                    { "56072689-4550-44be-987e-b08667758de4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "432c35f7-06ce-474d-8720-af949458d491", 5, 10 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "959b957e-b5c2-45a2-a0d3-5f58e83adc5c", 6, 12 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d45a4de6-5e7d-414e-a339-12af80ddebe3", 7, 14 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "856c9f30-9b84-4acc-899e-c68f6b55b6ca", 4, 8 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "277043b1-284f-45cd-aaa2-5316da2fa273", 5, 10 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cb783422-c8ae-446e-94f0-8c97b23ab086", 6, 12 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c0953874-e32b-4d60-8a91-68153b0e4e35", 7, 14 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "df2fd330-df91-4191-9a5c-0c7c78d16b6a", 4, 8 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c69001e6-f33f-4644-8e5c-b8378e20c06f", 5, 10 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e56f6970-68bc-4ce3-a8e6-286dd329e037", 6, 12 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bed905e0-9fbd-4425-aaed-c2bf04c95ce5", 7, 14 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3fd4d209-1714-48cc-bee3-c1553c9efa3b", 4, 8 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "61147fc8-65b2-4c12-8d5c-c68c591eaeaf", 5, 10 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b1f6339b-eff8-4e27-94fb-5709cb3fff2a", 6, 12 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "64652506-a67d-4792-a1ed-4c0612c14b49", 7, 14 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "94364b1a-1295-4b39-9dfe-2bf41daea8ca", 4, 8 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "84ca885b-cdb5-473d-9206-788644fca22f", 5, 10 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3f3bee3f-710d-4b89-830f-ac8e8b3b3b9c", 6, 12 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "111c9c0e-1727-4db2-938b-a79028e78947", 7, 14 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "419f72b6-45fa-4e43-a72d-f9485dbb5f95", 4, 8 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "48668b7f-d434-4a15-be99-be7627f645be", 5, 10 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "96a18718-351e-43e4-81ba-541aa9347ee4", 6, 12 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "649531a6-438a-414d-9ff3-4139662e511c", 7, 14 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1f651fa2-8d54-4680-947f-62a6901ba78d", 4, 8 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fb76b832-d7f5-4932-acf6-3411c739d66a", 5, 10 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "63310ca2-f0e0-4c71-a6e8-3b94f820b3d5", 6, 12 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c92e5744-fd07-4e1c-a868-8b2a85414e9d", 7, 14 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f0e1f74d-69ca-4684-ba0f-6ac58992c5b5", 4, 8 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e1d01308-6474-43d4-a5f7-8966fdd4b408", 5, 10 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c1e5884d-80df-4f0c-adb6-f884005a3656", 6, 12 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "426e4734-cea1-4068-92ec-f096a7c6b496", 7, 14 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c250a2eb-5ad5-4b4d-a031-583a436571d7", 4, 8 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "36cd56a8-8695-46f8-bf23-f5d510dcd46c", 5, 10 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "198cdf81-b432-45cc-be8a-4ad00c95636e", 6, 12 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f4b59cc6-07d8-40b2-b178-a2a927161db7", 7, 14 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bc3a701f-7921-4a6f-8f2e-408020486619", 4, 8 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "07782543-f48c-4b82-ad34-a7ca405033f6", 5, 10 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "af5de5f8-e297-4ff7-83aa-812e99ffb4b7", 6, 12 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "da785cab-9c2f-4b92-92ad-787164123da3", 7, 14 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "db517116-f491-400f-84b6-98fd39509186", 4, 8 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f70de7a0-4b35-45fb-b0ce-98190a096bb0", 5, 10 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "060b51fb-4901-4e31-8e08-404ae1e91f09", 6, 12 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0a478dbb-f64a-49eb-97c4-137e4b34b6d5", 7, 14 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6ca02c91-8274-4906-a042-54fd701dbec6", 4, 8 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "386273dc-d4fc-43d4-888b-85d5092fc2a8", 5, 10 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ede6221d-b994-4f89-8647-98dc79bd77ac", 6, 12 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "89dd601f-2ec9-4345-91dd-a688a77b7789", 7, 14 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e549ccf0-046a-4477-a865-98a4611d1346", 4, 8 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "00f782ec-5a9b-4f03-a095-5d1e95d799ab", 5, 10 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "93e9f885-a275-46a1-9b7f-39a2fdc1e225", 6, 12 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3418f7e9-5304-4e73-92ad-d806b77ddeb9", 7, 14 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2fb426a1-1b96-4db8-b7cb-a88085c6aad0", 4, 8 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d88e4c0f-bc12-4372-8852-cf1c6caaac43", 5, 10 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8aa1459f-ebbb-47e1-9687-41a8e82e8f93", 6, 12 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5cf3a3b0-d60c-41a9-956a-f368d6a2c310", 7, 14 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e6445678-9cac-44ca-a767-3db5017ff8e8", 4, 8 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c882650b-848f-4d2a-8003-fcbd2673feef", 5, 10 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3b463e43-5587-47ba-8ef4-d1df024ee4c6", 6, 12 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f95386f9-2392-4074-a7ab-926a0dca12a9", 7, 14 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "730a7783-d0d7-4564-9f2f-9aa0cc3d4a99", 4, 8 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a0f95d55-6bc4-4bec-b055-d2c06e03cedb", 5, 10 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "29823f5e-9dd7-42c1-8a0f-36d61682890d", 6, 12 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3f76d379-c299-48c3-9452-b06781fa786c", 7, 14 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "caf7035b-eafc-494d-8b01-51e811367e2a", 4, 8 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f5b90b68-33e3-4069-add5-edc718301575", 5, 10 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "75b799b4-caaa-4995-8f13-d71e0e6464d2", 6, 12 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1c2560a3-b9a9-48e9-b948-28fcb77af6d0", 7, 14 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "812e0c22-d74e-4dd4-8082-9b3f4b740eb4", 4, 8 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "01861e2f-3aa0-4f2d-bdb7-15170f792d79", 5, 10 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "00248eda-989e-4afd-9850-203bafe0ce3e", 6, 12 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "aba6ad3e-658e-41d5-865b-4c9a025a1346", 7, 14 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bdba6dc0-ac07-4471-82d3-cd69e471c7e1", 4, 8 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b86e8bd8-eb53-44cd-8e16-9c6b3a73135f", 5, 10 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "add6b498-4d91-452c-b16a-7032c06bbb72", 6, 12 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f33b5540-b53f-4dbb-b0b7-5e1c923db502", 7, 14 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b247085c-23f7-4ebe-834b-582c5ed86743", 4, 8 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "eb41baa3-0e9b-4f70-8572-43f29292a9bf", 5, 10 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f88579c1-1e88-4c68-8e0e-bd47f8eaa31a", 6, 12 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "085c76cf-06e8-4e69-a34e-ecdf52d2e3df", 7, 14 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "df93b8ba-a988-4e01-8827-c1e05598d25d", 4, 8 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2aee6aa4-c229-418c-8a7d-ba096273e8df", 5, 10 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "46f96a36-4be5-4c29-85ff-a64201162c9a", 6, 12 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "639d6637-31f1-48ef-bef9-77c6817737ec", 7, 14 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e048e47e-b9f0-45d2-9467-fef8be5d3ce7", 4, 8 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fe289632-66b6-4edf-8596-26392d8cda4b", 5, 10 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "31fb8186-bc34-46f3-a665-46c197e3e0d5", 6, 12 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c44ab10d-c772-423b-a949-553f212c4005", 7, 14 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2799d6cd-3b46-4999-bf14-86e11158937a", 4, 8 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c3ea8b79-10c9-405c-94dd-c0673b8018b1", 5, 10 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c532e127-3d7e-4691-8e4a-08578ad8843a", 6, 12 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f29bf8fe-1f35-4395-b871-4007bc0b6d4b", 7, 14 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e73514db-a317-4ba6-b30b-c159c3c2fa27", 4, 8 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "58ec897e-12c3-4201-9d3f-967bbb21c9e4", 5, 10 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6b1f6982-0e84-4502-bdbd-99647987c1e5", 6, 12 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "820d3255-9991-4bc1-8864-91ecd58d0991", 7, 14 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9236ef6f-d54d-4835-b43c-48355b10847b", 4, 8 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9b58e0af-f2c0-462a-a537-c10441ca8c7d", 5, 10 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1439e532-9a14-44dc-ae9e-b95b0e9df947", 6, 12 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f45ddd2e-57ab-4e7a-babc-c08098e52cf1", 7, 14 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "92924da8-9f8c-48fb-819e-1b76f4f1e8be", 4, 8 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5e79315e-a13d-44f9-a1f3-533c0f83842c", 5, 10 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7baeddea-1ac6-4c27-b065-1dd5f4b7345b", 6, 12 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0a4a6593-85da-4b5c-a05d-eb9addd13506", 7, 14 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e87c0f1f-5e7a-4ee3-9ede-6894aa4e166b", 4, 8 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e3d62e58-c031-41f6-8d48-664761bc6152", 5, 10 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "91296394-aa86-43ca-aace-75205b8fac0c", 6, 12 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "00a67d7f-037a-4fa6-9e14-803ace111364", 7, 14 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d2cc16d9-b284-44e9-a03b-91d5a97b4527", 4, 8 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d78c84ed-8fa2-4eb1-9e9a-85099ba8913e", 5, 10 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fb5490be-a220-4ade-9d71-ef7af1d65b77", 6, 12 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9f11563b-3380-4f7c-9187-d2a4067aeead", 7, 14 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a859d4ee-024e-4211-b72f-92fcdccc6faa", 4, 8 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5ffd7a8a-2778-4ce6-9f25-5941af4cf254", 5, 10 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "889e13b2-69ec-44cc-8b6b-666a5bf3d60e", 6, 12 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "933786ed-b459-403d-8904-e05af84dfa2a", 7, 14 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d9ce42e8-bc7f-441e-91cc-572b7382d97e", 4, 8 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ade2c5a0-2177-4a07-9c89-0769dc7197e0", 5, 10 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4ec5498f-a506-4601-92a9-06a749659978", 6, 12 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a2a60d8e-46be-4f55-ba4a-95d5d5d6d593", 7, 14 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5371500e-64f9-4182-9f46-c22ef7673722", 4, 8 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "39c13c3b-b0c4-4753-8ac8-0e2ee47a8ba0", 5, 10 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2882ff0d-3d8b-48c5-8ff7-04d74a23186d", 6, 12 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c42cd488-e4f5-47e7-9727-83a760b7bd5f", 7, 14 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "60f843c2-9db1-4363-b37b-a12dc4750179", 4, 8 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6715f1a9-00a7-46f4-b3f9-5dd81d2e8d8e", 5, 10 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0b2b7378-f171-4827-8b4c-aacaf89eca8c", 6, 12 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9e9ad1bc-0926-4eda-9933-611f4810764d", 7, 14 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "eed4739b-0d40-4d19-bd6a-a14af2235c2d", 4, 8 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "54f67c50-bfa0-4a40-8115-c3be757399d6", 5, 10 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "52d96a80-f84e-4f1b-bbf7-1747f21001d7", 6, 12 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1f3ffae3-e09e-4f08-9139-8b54891d0927", 7, 14 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4a49f269-8273-453b-a6d4-f9f5515efc4f", 4, 8 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bac9c43d-cbb5-4076-ae75-bc6cffc50143", 5, 10 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8b7e2564-d432-419b-89ce-065276ab72a7", 6, 12 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7e1d76b3-e619-4bd6-ac07-5e603b8c6202", 7, 14 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "16f06622-bff8-469c-8fb4-3f3aec176f45", 4, 8 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3d4d91b1-cae9-4f0b-b6e9-30f9129d21f9", 5, 10 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "58aff310-073e-4ebe-ae87-1e53caa27bda", 6, 12 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "35136c7c-18ff-48a4-85c1-56a4ee47dd3a", 7, 14 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b1ff1e17-6469-4a00-967b-71f1b970dd6a", 4, 8 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c7afcdfa-2bad-46c5-8104-02fb19b863e0", 5, 10 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "df8f495b-69bd-4600-b792-436a7605b9e8", 6, 12 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bd7a18c9-7021-4a1e-b4c5-8df06a68d74a", 7, 14 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6383c556-84b6-4771-adc7-7bd3f43128d0", 4, 8 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a8c5b80b-0021-4c7b-baaf-81950a89b62b", 5, 10 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "17431f89-6bf2-4dee-9b24-d4fb9d504261", 6, 12 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5221bdcd-4196-46c0-b945-2f448fb619bc", 7, 14 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d019258d-8f88-430e-a452-72452c06d802", 4, 8 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ba8da06a-7186-410e-8f67-bec5fd3b7e6d", 5, 10 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1e868098-e0ef-43c4-bd7b-de9886ff788b", 6, 12 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f89e8bd9-853d-4fa6-bffc-fb812b715d96", 7, 14 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2f793036-a770-4adc-b6ee-7a1e78ab95a0", 4, 8 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4bf2bc97-1eb7-4ba0-82ff-ddc1ac16b458", 5, 10 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5d7c024a-2714-49c3-9b6e-a940f5aeb78d", 6, 12 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9a018d64-97be-4ea2-8bf2-69cd9b31c25f", 7, 14 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ce4cdf9a-0196-4ea4-a120-3e470092e3a1", 4, 8 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3b75dd74-6d2e-4e06-ac60-72dbd9bcf340", 5, 10 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0f7fab38-ef33-4381-abbe-59d09414f973", 6, 12 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3b01ff4d-8be1-4960-a60a-ee4e53ae8b58", 7, 14 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "57f79ce3-caad-4c63-977f-336d89f1dcf9", 4, 8 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "209ec59a-c4e5-43ef-8723-0f5c1a0a5da1", 5, 10 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0664835d-c727-4d96-a062-7f2c518c2b7a", 6, 12 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b949f39c-8d43-4143-893b-2683f2032ce2", 7, 14 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3b9cdacb-c3d3-490a-bfd2-88ef4997d37a", 4, 8 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "397d9d13-c71e-492f-b565-3d9b533519c4", 5, 10 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b369d5ec-2ee9-4c01-be3f-96bfea86967f", 6, 12 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fac4c229-d852-4c99-87be-db3c7e37251e", 7, 14 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "54278c99-784e-447e-8c7d-357fb6b6e433", 4, 8 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "67fba5d6-21ce-43fb-b481-4e407949a818", 5, 10 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "caa8abf6-673e-4d11-9a27-aa1810915b14", 6, 12 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "25c020d6-eefd-4491-9d95-a6bac4457916", 7, 14 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "653efe52-85c9-4325-a6ed-96517acf0baf", 4, 8 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c2931e1d-436a-4c0a-bb15-cc9ef592b9d7", 5, 10 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2ae54762-ffa1-4b2a-b4f4-556f7bc4bc03", 6, 12 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "65297553-7b80-40ea-87cb-057e3b9cb8d0", 7, 14 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "87d3bf87-4893-401b-8d50-2060e67565df", 4, 8 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b74d03a8-c94f-4dba-a060-305ad0543f0b", 5, 10 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ef518d7f-9df5-4857-8f0f-2429e3d84894", 6, 12 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bd1aec62-9ba2-44d2-bac1-0a51a1ef4aaa", 7, 14 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ec46e7d0-d22b-47d4-8962-15a1ae689f7e", 4, 8 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "06d8c9a7-86e1-457d-9a62-ebf7c083f9ae", 5, 10 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9779ae64-c7ec-4cb4-b69b-b1407fb03071", 6, 12 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "68b8ec0d-22c9-4a2f-839a-f7f3e0abc68f", 7, 14 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3f4fe4be-8db5-4468-a50a-35d7c65ee563", 4, 8 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5839fa09-07c3-411b-b4b7-701cd10b12f6", 5, 10 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8d8f0efe-43d7-479a-948e-4eeed4b39ff5", 6, 12 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9b6fc9f6-87d0-4af7-8168-657c97d85073", 7, 14 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2ebd93c5-006f-4d75-b80b-7cdda6e8a8b7", 4, 8 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3a0f4e2c-2449-403f-886f-e684766921b3", 5, 10 },
                    { "78157107-23fa-4638-bd17-38187695312c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b69e8799-c3d2-4aa1-b269-05eb71b1e7ae", 6, 12 },
                    { "78157107-23fa-4638-bd17-38187695312c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d8d2fdd7-e4f0-4773-ada6-9cdea8f58577", 7, 14 },
                    { "78157107-23fa-4638-bd17-38187695312c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fab4a941-7221-4063-8537-b5649b95557c", 4, 8 },
                    { "78157107-23fa-4638-bd17-38187695312c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b68e0e7c-f817-4745-a3b4-7fbd7db58bfc", 5, 10 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d1ab7333-23a1-4a2d-95af-931a907ed112", 6, 12 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f4d385cd-bd4c-4601-8bc4-12b2e5716df2", 7, 14 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3d716e6a-3f60-4b36-83c0-31834ed7fa4f", 4, 8 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "df21c56c-4d53-40d0-a66a-84bcc00ec695", 5, 10 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eb0f7c91-b687-4373-b6c0-9a9dffe6e9ca", 6, 12 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5a5e56ce-8644-4014-8a93-c92807035622", 7, 14 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6732ed85-9d56-4432-8596-41af0092ed97", 4, 8 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4ca2f732-570d-4965-b724-49dd47cc5aae", 5, 10 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "553b3472-51f5-4ac2-8e36-bf5f6468c648", 6, 12 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "92e86262-d940-42ae-98f4-436b7943d7ff", 7, 14 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "19b6557a-4bdf-491f-8105-477a2f091341", 4, 8 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "595cdfc5-e7d7-48d4-8417-20b633a29488", 5, 10 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "35c50246-bb42-496a-a38a-32e0ace4ef64", 6, 12 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "990ffaef-7bc0-4cb3-9ced-07d83c2a3ccb", 7, 14 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f1c3ea58-14bf-4391-9656-bc3f7ea3312e", 4, 8 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3fb36b09-e957-4820-849a-abde19e803d4", 5, 10 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "08e43ae2-a25f-459f-898c-b3362bbd13e3", 6, 12 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6ad0291d-5193-48cd-b0c2-2e62e263bc92", 7, 14 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b3c57d87-5d17-440d-8163-597c6a1f77b2", 4, 8 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bc6828f5-633a-4855-8427-00873de46e32", 5, 10 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8f466663-b15f-45fd-b584-02f468a70acc", 6, 12 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e81b70d5-5596-4876-99d7-29b018cec3d6", 7, 14 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b6fcae1b-687f-43bb-8b6e-8929499ea0b1", 4, 8 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "74f46dd6-c39d-4a28-b058-319776c02972", 5, 10 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fd017f5f-4839-455e-a827-36591662e5d7", 6, 12 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c153c288-7797-44a0-99eb-7e051cd60c3f", 7, 14 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2adfd51f-7567-4769-b186-f75e88891772", 4, 8 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "08998544-3d1c-426e-9233-deae6f3ef7f1", 5, 10 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f8cde876-a5ae-4943-b073-0cb284d470a4", 6, 12 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "448bb014-4d6b-4b31-99eb-5f3db124947e", 7, 14 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "66359853-e634-4ae6-a216-5ebe67db5f4e", 4, 8 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "37c8537e-5328-409d-9b05-50dae7bdbc3f", 5, 10 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "593720bd-2e5b-4d99-b1d7-dcac9ce40849", 6, 12 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e95ba779-0dd2-4128-b03a-19e367e63882", 7, 14 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1e0c4ca2-855f-48ed-8eb5-dda2d298db24", 4, 8 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e7fe2c72-9227-46e5-8349-8ecd8805e117", 5, 10 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6f011012-e3ca-46e8-94c1-e5f61081bf3a", 6, 12 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8c9f7796-0357-4b17-a3c6-40c0dc8b1ab5", 7, 14 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "12d1d2ca-ddd0-4afd-9b4e-eaf0740df27c", 4, 8 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "44e85194-5bb2-4857-9003-fc7dca99c704", 5, 10 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b0b2476a-4384-4a17-b709-8a7ff0055dec", 6, 12 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f1c0e7a9-1bb5-46b8-a19b-5d39ab7e1ebd", 7, 14 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ce0487d2-68d5-4b0a-bfad-2cf47174427e", 4, 8 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cf2a153e-fe89-4bf8-9001-c3db806f9cb9", 5, 10 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1089a59b-cb71-49d3-90a4-b244d31a6d9f", 6, 12 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9972b52f-e580-40f8-9886-c26dd8113fbb", 7, 14 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b565a7db-7f66-49b2-b464-79de24eb9a07", 4, 8 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6e324380-227e-4c03-bc43-8d69dcd16d51", 5, 10 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dcd321c2-9b98-4222-947b-ccf50ea1409d", 6, 12 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d698cc56-066a-4026-a8f6-a59be44e6db9", 7, 14 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0c2c79e8-c2be-497e-8b27-725eff74149e", 4, 8 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "22834b77-bade-47a9-ae81-0354862e4bef", 5, 10 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3416f9ae-7ddb-4b9e-a726-34401155c3a1", 6, 12 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e16e60c4-218d-4303-b9ec-6e6c13c546fe", 7, 14 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5594b650-d4ea-4840-9d3a-5123bba5e4cb", 4, 8 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "74239e67-760f-484d-bc4a-b33830631b8f", 5, 10 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fc6ed022-44ee-4d99-89e5-49563b972bae", 6, 12 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7fdf33eb-2009-42dc-bf59-6cd01aba1807", 7, 14 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a1589742-e74c-4bfa-bf90-355921b67e85", 4, 8 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b6ae12e3-65b7-46ff-a123-b4fba5e3945b", 5, 10 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9d32bf67-68bc-4959-a8e9-f7641374e2cc", 6, 12 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "80c0b444-dc42-4f75-b368-c0b50bf1f164", 7, 14 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3098a0dd-c2db-40e4-83ee-da99158d019f", 4, 8 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e9363cba-fe2c-4ed8-812b-f5dc012f45dc", 5, 10 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "20f9ecaa-1b4a-4c44-857c-55ac55454999", 6, 12 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4adacd2d-07b3-4c99-8b89-481d39f70322", 7, 14 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5a0968e6-5ac9-448c-aa8b-635963be42b5", 4, 8 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d3f1653c-ee96-4917-b5a6-cadfd46b1af0", 5, 10 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9b388782-1caf-443d-986c-c3704f16389f", 6, 12 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7fcf2594-17ec-4ec5-8256-785fece1f6f6", 7, 14 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "496d00dc-8858-4784-85d0-ded4cf0ff578", 4, 8 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "eb796b29-837b-43ef-b78c-7468d7b6411b", 5, 10 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d954ba6a-d9a0-437e-83b9-f4eea7d8eb57", 6, 12 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ee1c0210-9b7c-46fa-8441-ab3a35463c28", 7, 14 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f0c8efe3-8fa5-44e2-a7f3-fca21a17a134", 4, 8 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ae2ab557-d6f5-446b-af76-9dff0a4df253", 5, 10 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e2ec94d1-b5e9-40b9-b738-5eae7651388b", 6, 12 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "27ef98ec-5e23-4df0-a346-6b63f022c71d", 7, 14 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8d15362f-f81e-46ff-8525-646ce725db7d", 4, 8 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "845b0b3e-3554-4f9a-8518-86e97cbfa5e1", 5, 10 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "add9260d-e501-4c72-9a63-b30d44ef51d8", 6, 12 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d264c0a2-33ad-459d-94e1-038f8adb8784", 7, 14 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b488d8d8-6385-49d6-9357-f1f35c552a97", 4, 8 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a55458d2-e004-4749-a4ac-fb4766d0e9ab", 5, 10 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5719d83b-2241-4e9f-85b7-218b56a3a059", 6, 12 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "99b338ca-55b0-4c39-a5a3-38080e03122a", 7, 14 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5bfdd22b-e1f1-411d-a2af-d0338a5b9033", 4, 8 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0f6b3c23-edfb-4952-b446-42b29d0e92d3", 5, 10 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7aff9f2f-2232-449e-8259-90542dce5c31", 6, 12 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "022e724c-9414-4588-963a-a22d9b2fe32c", 7, 14 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7a903ef2-9f51-47c4-b8f1-3b2711dff830", 4, 8 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "95f01ec1-c248-4eee-9078-d8f3a2c35c16", 5, 10 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a512bef1-3562-4d1f-8e54-c4d2213f3f1d", 6, 12 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "beb66ce8-d460-4281-a5fe-585200468b8c", 7, 14 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0b334e8f-2462-4353-9bb7-15792c4c0ce3", 4, 8 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "404f25c6-72cb-465f-af4c-17ae23aff653", 5, 10 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f35abb9c-cb8a-46d5-805c-99d1f35cd188", 6, 12 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6dd6e1ab-c93f-4d6f-9d6c-f576db77f447", 7, 14 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9a0adfbd-3cc4-4e37-b074-b684aa9daa94", 4, 8 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "58b5577a-5a30-488f-beab-ecc51cecb8c8", 5, 10 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c8703489-643b-48c5-a1cf-8ba7ba5d0ac6", 6, 12 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c0f06364-6db6-43e3-bd99-6f4edd22a28f", 7, 14 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "69b16731-1748-451c-bcb7-0ad5061cb937", 4, 8 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "03be4519-f98c-4b1d-91b3-ac42d5448591", 5, 10 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a4c41ee5-9c05-451f-8033-6296f6691d34", 6, 12 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6c11f7fc-90ba-42db-aa96-4cb53cc4c9d0", 7, 14 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3e7de79c-0f59-4981-81a1-fe653d0d4dc7", 4, 8 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b7f74b37-8ee6-4afb-aeaa-3bcbb8024b98", 5, 10 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d29f852f-bc07-496f-b391-07fff5ec85a4", 6, 12 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "84d13563-d618-4366-a153-ead55991a9a5", 7, 14 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d13d3ea7-b4f6-4ca6-9c3d-f701e2c7903d", 4, 8 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8cf54782-f06c-42bc-aed4-35de91b698b6", 5, 10 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "44f18c42-314f-43af-92d8-7db61c54055a", 6, 12 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "91643961-d936-4cc9-a4bc-e85469fc2dd5", 7, 14 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "83ccf89d-45da-4168-b0c6-507d77223471", 4, 8 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c92cf3bd-379e-49bc-9ef7-db2f9858496b", 5, 10 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b7206db1-a719-4d77-9fa2-999da4c1f9ed", 6, 12 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f3f67dfe-2f1f-40bd-8021-7c72725914ee", 7, 14 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "788e5ec6-170e-4419-a00e-0ace6c4fc99a", 4, 8 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "495435b2-9558-4de8-b7c8-767cd881a912", 5, 10 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "90a9e4f6-4874-4428-aaf0-33ab3d73c8ad", 6, 12 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6f67370b-2b1e-4f85-9966-440d400e86f1", 7, 14 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6505156b-cfd5-4fe0-93c0-e13fc537c692", 4, 8 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b26f77d0-48a7-43dc-abaf-0a1e8789055d", 5, 10 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ba21af3a-c9dc-4e5f-8db1-5d5aa7de4493", 6, 12 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "38ca67be-0018-45ae-9844-3e8eae767685", 7, 14 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f9a2fe20-195e-4086-89ae-e38fa1f2b2ab", 4, 8 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4429c035-ee4a-4f95-b307-78500bde384e", 5, 10 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "826c2247-29d7-4d9a-8218-6a1a091add2b", 6, 12 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1d761ec0-202f-4dd0-b1d1-1213dd2844e9", 7, 14 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a354f2ea-33df-4d99-ae65-6a4d5a48801e", 4, 8 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d29a1036-ce3f-494e-a93e-068f1aaaee17", 5, 10 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0deee799-9122-4c8d-92a8-785bbf7a5544", 6, 12 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "801e750c-2cb5-4340-826c-1cf419981955", 7, 14 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "68f255a4-ca7c-4972-aa7a-c2b1688353a5", 4, 8 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "eb4b85b0-78a6-4cf3-9ef0-5008630c8a1f", 5, 10 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fd57768d-3a8e-4d0a-977c-4e7e5c8e9118", 6, 12 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7c1bf720-8dd5-41db-9cde-4ad9c62b763b", 7, 14 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "da01bb70-2a4e-423b-bb65-91e2e268ddf8", 4, 8 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "60175763-af65-4f64-bf71-7d69fcc7d524", 5, 10 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d774ed9a-cb07-4e50-b97e-bd3a4e10fe60", 6, 12 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "206e4b4b-9586-43da-92ab-25fe68320d58", 7, 14 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d1523302-8c74-45a7-b275-0b2e8b86db8a", 4, 8 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8d219822-b8e7-40b6-ab49-b628df646de1", 5, 10 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6e2607d6-493e-4b5e-87aa-95ab41bc3460", 6, 12 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ce28e270-db76-44ec-a660-1ba27fe51794", 7, 14 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "48fa34cf-822f-4175-b657-d1e37eb131fc", 4, 8 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "812e75fd-5f09-4bfc-9c2f-2810b07f5544", 5, 10 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cf638a10-8bb0-451e-9d14-fa46d4e51633", 6, 12 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8cdce56a-186d-45c2-bf8d-9168acf38c0d", 7, 14 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "76f91bcd-2ada-4220-a80d-fc813cb24e13", 4, 8 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "86116f7f-0305-494d-8be6-b6726e8a8ac8", 5, 10 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "25383f61-e3e1-4453-9d7a-84ea992c8e3f", 6, 12 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7abbedc0-71e4-4dbb-a883-7c74de447e76", 7, 14 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8919beca-d41b-4275-b375-986f3dfdd382", 4, 8 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4622e8e4-1fc5-4015-8c54-0e9aac991f7e", 5, 10 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "89cc18e4-5b33-4540-be53-49e4d766a27b", 6, 12 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "36efde0b-a8d6-421e-846b-802b2f3a817b", 7, 14 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f7b5356b-34b1-40e2-abf5-805966fda3ab", 4, 8 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8f6fa7a4-3378-47ff-b035-3daf53466163", 5, 10 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "afd83aac-9bc9-4e1b-8857-e26808740ac7", 6, 12 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2dcd086d-d302-456c-9687-22fdd94c94ae", 7, 14 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8b8817ec-0506-40c0-a736-3e636625113d", 4, 8 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4e4cbeb4-87d0-45d5-b48f-c7112eba87d3", 5, 10 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5ce90bdb-7c2b-4ff8-ab23-5994dd5f0159", 6, 12 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "19c9d828-5e55-44da-9e57-025bd2d25ecb", 7, 14 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1eb3c680-8a99-41d2-b685-64e19a4f6379", 4, 8 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "792c311b-d8b1-4afe-a85b-115c4e025cc8", 5, 10 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "66c924d9-9178-488b-99c3-957f7c1b2f30", 6, 12 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "603f6589-8f5c-4991-9f6a-889cd5229ec9", 7, 14 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "322dc36f-e4d6-4361-88b6-35d7bb73af27", 4, 8 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5a044c4d-e578-4f53-a211-ecefbf213796", 5, 10 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e17d56ec-9bf2-4e7a-b61a-a868fd8fe439", 6, 12 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "47cdb4b0-0dc7-4772-a5d9-4373c2b7f9b6", 7, 14 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "67b08d8f-7e96-4190-8054-f9724aacd3cf", 4, 8 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ca24082d-f674-42ae-8042-0f7032fd693a", 5, 10 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eb7c6438-85dc-4573-8b92-638ac3fdef65", 6, 12 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "77b293a2-334e-4f16-ad4a-7675dcbe86e6", 7, 14 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c1176457-ff7b-486d-bc6b-53e6cfbabd24", 4, 8 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8f53ca8d-e9e9-4ae0-a0bd-d5adb158743a", 5, 10 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "97413fa7-b202-4f88-b1a6-c1e9fedce61a", 6, 12 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b8bc6c56-6546-4795-9ba5-fc3a94193521", 7, 14 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2767d202-6896-4840-9d0b-7d1e3bd50993", 4, 8 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f4874299-9248-4b10-b72e-19b84c114a98", 5, 10 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "64d1ff2c-c9e2-4b29-8e9c-104a7969e775", 6, 12 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d7fee0d5-edab-4104-bfc6-2eeb82bf5c28", 7, 14 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2e9bf1c1-14c9-4bd6-8c0a-12ef5008513d", 4, 8 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f3fc5e8f-3dcd-4f2d-ad4c-a9e76377015a", 5, 10 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "204d4759-ed1d-46ae-a4d4-f5fad5fb3b29", 6, 12 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "74f737af-e306-4513-a6e7-0e9f6789b6d2", 7, 14 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3f1bea4d-6a5c-4551-b012-3c1e5bd9a60e", 4, 8 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1735665e-5d8b-4d36-a95c-c05dead68064", 5, 10 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bd981bcc-5919-4f4b-836c-8538a0ab6d99", 6, 12 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cd36e19a-e7e8-41b9-93f7-d9897fa9454a", 7, 14 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bfc54ffa-0ffe-45c7-bd6a-e7e7fb1ebe46", 4, 8 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "79626ff3-5d4f-449f-be1b-aad5e166bab6", 5, 10 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8bcb2ca0-5795-49a2-aa8f-90673313df46", 6, 12 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ff159597-1049-4ccc-8be0-00ed139a461e", 7, 14 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7b8d3dcd-5184-4009-b773-c83b691b52e5", 4, 8 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e149b201-deab-4544-bf22-285b357a3481", 5, 10 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c6b95243-af59-4c88-81aa-790b4144c7df", 6, 12 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "170d9560-d086-4772-a367-e4a370c27de7", 7, 14 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "337693dd-16e3-4e97-899a-65f7c037dd6e", 4, 8 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "427c8dfa-7e68-4353-abd3-7d5233e8bb30", 5, 10 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "535e0669-28cc-44ed-9b64-5d35e2ee6132", 6, 12 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "db6f2cae-9b4c-4947-96d1-bce5da251c78", 7, 14 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "03727182-a854-4887-8ae3-8093df14531e", 4, 8 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "81b9a304-afca-4a21-a914-8fdd63eb7f04", 5, 10 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7032cbbe-f738-45da-9a49-681c5b90f058", 6, 12 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1694fd33-0e0d-48f6-827b-d2e98d2a78dc", 7, 14 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b570b99a-e5d1-4d24-b8f1-9b79933f49e7", 4, 8 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "be46a318-4f2b-4b13-b572-290b87e4e34d", 5, 10 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "89b1cc05-ef1e-4515-a210-8b4e5bfa4e5f", 6, 12 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "98a95fa4-5bd5-4f36-a7b9-87bdba56c602", 7, 14 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2fce1c8a-b2f3-4d19-b682-a6abfba2a06f", 4, 8 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "302b4281-e21a-4e1a-b5ee-950d0e90bbe9", 5, 10 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "32fab7ce-d29b-419d-b06c-6dab40ee2b7b", 6, 12 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c4e65eac-2ee4-47ca-9b44-29522c823413", 7, 14 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "698eeae1-c820-40d9-82df-50850ec94bbb", 4, 8 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d2ad0258-e67b-4ed2-b206-7e16d1514271", 5, 10 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f0d61270-e14d-4b0e-b5c4-eba8684ca6a4", 6, 12 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a9cd20c4-533e-4b49-a569-141c579d1831", 7, 14 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f8026e3f-c020-448f-b3df-9866ff355797", 4, 8 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b220f679-eaa3-4d74-bafc-cfca2d039c79", 5, 10 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2a9d39e0-c01e-41bd-b8cb-c41efb5736b2", 6, 12 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7ecff0c4-9a78-4936-b907-feadcc032b9a", 7, 14 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c829175a-4b1d-468b-839f-26f9017748a6", 4, 8 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4cd7a20c-f4f5-4f3f-a574-ea7be7a18da8", 5, 10 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "efe2d7b1-bbe2-464f-8b1b-5229fae65566", 6, 12 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e810f0fd-c0b0-4c09-852d-56252dd047de", 7, 14 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c06611bd-e741-4f99-a11c-e09aa09f8571", 4, 8 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4c704782-8822-416c-8c63-717f086d6bb6", 5, 10 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "63a0f3ca-b24d-4864-92f6-e1e71f945850", 6, 12 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9dcddd91-87fd-4125-b228-32cc130b4aa7", 7, 14 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "85277e21-3268-48a4-8ce0-e79c1e4405a1", 4, 8 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "66f9f274-85cb-48fe-aa29-040301e5651a", 5, 10 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "808c7260-3de3-4f3a-a539-3da4381b6299", 6, 12 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9ca4b8d6-98a2-484c-b82f-f0c3ad3495eb", 7, 14 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cdc9d3e8-84ff-4b50-9e42-b5d5812d6704", 4, 8 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ce481386-d1c1-43fd-abe1-bf86421e77fa", 5, 10 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8b1462d9-02d3-47cc-92e4-ad6228916b43", 6, 12 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "04737596-326e-4e75-b75b-fb1ff58847c7", 7, 14 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9ebb4f6f-ea18-46e1-a72f-351357f8f8fd", 4, 8 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7367cc61-5acf-4fd4-9ae0-88f0d7ea26c6", 5, 10 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5e8076b6-280e-4315-96e4-84c85d85d9ff", 6, 12 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bbd0a0cb-f363-4c89-b468-2be5bfd3df33", 7, 14 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cf67f4f7-3c37-415b-8fd3-32e0858c4b37", 4, 8 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ae082e72-7f0a-467e-a1c0-96b952c54f10", 5, 10 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5aa166ef-584f-4bac-a0e2-a25bbae4ea29", 6, 12 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6cfbb62b-cae0-4aea-bec7-55d23ce5e840", 7, 14 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5615c892-a2d8-4ed1-a907-f9e356be27d4", 4, 8 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cbb49ab9-c9ba-4e6b-a239-7321de96c436", 5, 10 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b21f4705-cbf8-4fd0-a17e-8665aa69b839", 6, 12 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5f924362-2a33-4fa9-9cb1-666cc7c62f41", 7, 14 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a081f46e-93b9-4ee6-a3eb-bad71f874357", 4, 8 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d91c99c9-cd67-4f26-8a8e-f43d53fd7bd5", 5, 10 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "de4f5e59-1a59-4e42-ac0c-87624fca6673", 6, 12 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f9edd0f9-2ad5-4aac-adad-677d57ef82eb", 7, 14 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "11032c06-7143-43c9-8fea-8431a7965e0b", 4, 8 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "21238805-6865-48e6-8076-bd8e8aa9f853", 5, 10 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ac94b2c1-905a-4c71-b2dc-17093f9a98a6", 6, 12 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0698b34a-6b85-4d97-960d-14f24de10c18", 7, 14 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "637358b1-f52c-4374-ba9a-1fba45b09083", 4, 8 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a8f20019-3f1a-4337-b825-03221248f969", 5, 10 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8df3f5a9-a4e0-4751-8aa9-f117a8b16537", 6, 12 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b629ed51-2bc7-4739-b40b-0c7bae1ee1fb", 7, 14 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fe745378-e6eb-45fd-a71e-1cc721777056", 4, 8 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a3d5acc3-a94d-4754-8d86-ae64d64e7eab", 5, 10 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aae7bafd-af93-4c35-a8e2-a2ebe39f6a8c", 6, 12 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "35703802-5261-4ae9-857a-4726c07757bf", 7, 14 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "63c626e6-631c-4336-a7ab-c0023d07bd61", 4, 8 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fc2db0ab-4fda-4004-ac00-51f04cf3b8c1", 5, 10 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8fff68f9-c7d1-4912-8540-48bbef414b42", 6, 12 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f72c1112-ae57-4d8d-aa22-3e4a5574b2fd", 7, 14 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9bb6ae35-e098-427f-bed8-3d9d2850b908", 4, 8 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "21eadf80-9c06-41ae-998f-48fdfd8ce15a", 5, 10 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "46c04afd-2b7f-49fe-8c16-df01c96f2eb0", 6, 12 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "eaffeeb6-9de7-4b9e-8ba4-3db25c87e466", 7, 14 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1d615d7d-332a-4783-9890-5a75dac22f87", 4, 8 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "696adfc1-da4a-49bf-b0ba-a82e14a6e1e4", 5, 10 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1d6390c6-7f03-41ea-b743-5c70c743ab4e", 6, 12 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2a22f0e5-55d0-4412-ad60-22cf02effdcb", 7, 14 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5d3b10c1-657d-4549-b5f1-2f62f53b5f3a", 4, 8 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "245cb4f0-898e-4665-8b29-44e2d1f77ae1", 5, 10 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1b56e797-7fe4-4432-9cc5-6149b9d32f32", 6, 12 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c569db98-1e74-4058-b821-df1282bb1c12", 7, 14 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "71532aee-a416-4a9e-83c1-3f2c5cfed6df", 4, 8 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "31252b2e-a21f-41de-96a1-6e53e7f24d27", 5, 10 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ef26c9f4-0ea7-471b-b28b-b49596e1dfa3", 6, 12 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "eab77acb-79b1-4458-85d9-f3ebd40bc388", 7, 14 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a4134243-7f3e-4fe3-87cc-18aa5746806d", 4, 8 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "efc1fd29-9835-4ed0-8e72-9e5c9d5c2e3f", 5, 10 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ecc2c048-a1e4-4fa5-ab9c-21b7610ec3d7", 6, 12 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "73398d36-10e2-4067-8e5c-ec7074e31815", 7, 14 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bcd007c8-dd37-4a20-a5c6-201dd9f2b93c", 4, 8 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b5d20146-74d6-40fa-b58c-496b699b35bd", 5, 10 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "041c1878-7bcd-478f-8310-c1a73af91e60", 6, 12 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "40ce496f-f275-4b13-a512-05478071537b", 7, 14 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c8b5c297-518c-4ea7-8a5b-e4885bb8e0f8", 4, 8 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2dffdd9b-6674-42b4-9443-cf884a2b69b0", 5, 10 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8985f472-6d2e-4da9-b1e6-7d21b444ff3e", 6, 12 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ba8c9004-b237-4091-bbd6-d2545c70a435", 7, 14 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "324f4fc6-3278-41d6-94c1-ba426ad436f9", 4, 8 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d2b3989a-3341-4559-8db6-691d35d7544a", 5, 10 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8ee80243-f185-4bed-9b62-255b7bec580b", 6, 12 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1181cf41-4a2f-4288-945f-0b11dfa62760", 7, 14 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d2d38c11-de7e-4053-b71b-8473f9619eab", 4, 8 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1d86da6c-ec6c-4f13-81b7-e9a0f2d82153", 5, 10 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "23105e87-1a6d-4d90-9b36-1e1a0690b3d4", 6, 12 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1e5a1a2e-7dd1-4286-9aeb-6f6afcd97ca1", 7, 14 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c786a52c-7898-4d3b-a5ae-6c1a81d5a5bb", 4, 8 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dc693491-99e7-42d7-ba17-cf8dd91ac4e4", 5, 10 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d67d406d-f0b4-41cd-9d3b-8bc66a8cb8e3", 6, 12 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "479c9e2e-647d-41f8-b87e-bae98faea08e", 7, 14 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c31df566-bca6-460d-a552-2d72e405bbad", 4, 8 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a00afc1c-1308-429e-a8a9-29967a7e3cd3", 5, 10 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5b9b9f03-d106-47fd-99e9-177c70a44bed", 6, 12 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "26cb6df1-cd14-4b01-b8d7-9924ce3e73b0", 7, 14 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "77598c06-904c-47a8-a592-c8a62f532b07", 4, 8 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a1171643-ed03-4772-b060-260fbcf509f8", 5, 10 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "65ed05cc-5321-448b-a2db-ad7d4443ae31", 6, 12 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b1998060-7dad-439f-a064-ca5bfd6aa6f2", 7, 14 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "22822b97-66c4-42be-94ee-c6c5320ff19d", 4, 8 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a2e09194-0ed6-4c93-bb4a-59c47f232b1e", 5, 10 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7e56ac8a-287b-46be-89bc-6a298b00bddd", 6, 12 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ae7ea524-1428-4c06-a238-93473d75ccb1", 7, 14 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ad77f5d2-a70e-4542-94b6-8f3bc72ac1f8", 4, 8 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "78d1cd31-92a0-4e2c-a388-ecc2c515272a", 5, 10 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0591ba5c-131f-4ba5-8b75-427e627daf10", 6, 12 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0b54f1ed-3442-4655-a03b-b48e59ad3ce0", 7, 14 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "95831c89-9e78-4dc4-8c93-63aa499248c7", 4, 8 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "31f79f55-4bdd-4a78-9ab6-436835a99850", 5, 10 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "12b185bd-c323-4cb7-80fb-17b67bc74dc4", 6, 12 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1c230bf3-b234-4b1a-9966-49964f70a3a1", 7, 14 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "47d84dd4-ebe7-4bf5-816a-e85bfc71a3d6", 4, 8 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3b70923b-0dd7-49e6-b6ed-67e798f3f7e9", 5, 10 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d68928b5-ab0e-4c26-8062-ce3754d9fd03", 6, 12 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "80d36bfc-435a-4073-9408-b645d743f9bd", 7, 14 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1a745a49-5475-4807-810a-fa8fea2d631f", 4, 8 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9e62ca15-f0ab-40f4-be31-d7d20326bb76", 5, 10 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f3a1b806-8fe2-4671-a8ee-c7907b8c550c", 6, 12 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a561a404-928d-445b-9fa7-de2fbfd03141", 7, 14 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8829e4e0-7f32-4ce9-b7c7-a12b72d46730", 4, 8 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4d1e82e0-72fe-46a5-896c-cfa000a4b57e", 5, 10 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "055d6eef-7194-4ef6-b7fa-f357fa0c42b9", 6, 12 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5b6bbf6a-8218-47f0-b39f-8bf1986ee13e", 7, 14 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "62302a1f-6256-4fef-a753-0f21261235fd", 4, 8 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "34c7d8d2-d4b9-4542-a26a-895eee10748d", 5, 10 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d1405ffb-0e12-4c70-bf8e-dd3b1213005e", 6, 12 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a452f31b-9f4f-4d23-afeb-5582f623e473", 7, 14 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "916c8007-d412-48b1-8b4e-c7397cae5594", 4, 8 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c7fe8aa5-0be1-4b11-b190-1a802cd67b1a", 5, 10 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b156c1ec-6eff-4688-b0fd-a1d736dac58a", 6, 12 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f2e4c608-d58b-4924-983c-48aa4661161d", 7, 14 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dad8231b-9ae5-403d-bc2f-812680aa2a47", 4, 8 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ba83fb35-6e72-4d9a-a5d2-f3b27683fd80", 5, 10 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8b55adee-d0c5-426b-a3c8-6037922876f1", 6, 12 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "37410e70-5ef6-4b72-96a4-c74e61c50db3", 7, 14 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "139de359-5199-4546-8508-a379aa971dd7", 4, 8 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "27c821e5-40f9-432b-9622-b8b248e4b7c5", 5, 10 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "776cc0f9-ecd6-4a78-92bf-4e11952bb73f", 6, 12 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c048fc0b-d83c-4dbc-846b-f25e30ea51d3", 7, 14 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "590aae53-df87-46cb-a1f3-0629da56bf2a", 4, 8 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ea4b2007-04d0-4b53-8ea7-6f78ca9ba5ae", 5, 10 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6bff75b7-9a41-4851-975a-ced8b29999b6", 6, 12 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "10ed7ddd-822f-4a2e-968d-3a61dfe3e146", 7, 14 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "364a0eff-b864-4a45-909f-bb557098f39f", 4, 8 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b078dde0-b17d-4ef4-8a84-aef30cc6ac46", 5, 10 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6ca99473-5a12-4d1c-9274-ad85bcdad5a6", 6, 12 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3b4f2fac-73f1-4b18-bc5c-35183d225a2a", 7, 14 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d5827364-2998-4404-b03f-cc63c2dc310d", 4, 8 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7d20d0a3-ba01-481f-87f5-8f3165be1949", 5, 10 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5d90150b-5a0b-4d24-8ec2-b89b865fac3f", 6, 12 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0e69ec5e-12f4-4cf5-85ba-bf093f6869f0", 7, 14 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f23e6757-8cdf-4294-9722-6291e2c1b1b4", 4, 8 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b23a0881-95fa-4729-9654-14e3af6bc459", 5, 10 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "532480f2-654a-42f1-a875-a913d2664ebe", 6, 12 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "34a8cf6b-dd12-4fc8-b29b-fb17f642ef78", 7, 14 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "147f2a03-04d5-4a1a-9205-4a37d3aff37c", 4, 8 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "60956339-a114-47c0-a4f1-e04a8c177ad0", 5, 10 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "772901f8-8887-4de4-b405-16f17a90183f", 6, 12 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a43f3fd9-737b-4365-bbbd-31981eab0b46", 7, 14 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cc0dd1b9-5524-49b2-9491-fe3b57f26d4e", 4, 8 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9bd2de54-e291-40ee-ba98-36bf0d042235", 5, 10 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7675f661-8a56-4798-b862-c75658b5e127", 6, 12 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "98cb231b-ba08-47b3-ab40-2796d3901998", 7, 14 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d01ded6f-e138-48f5-9da2-a8469144aaa2", 4, 8 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1ace9af0-601e-4307-b0ce-1be386d54c13", 5, 10 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d67b5079-a435-4d45-b4e4-57359df2c786", 6, 12 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3ea6f761-ddd1-42fe-8931-e996132ec892", 7, 14 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "712dbe37-ff5e-43b1-8014-f552e44ff858", 4, 8 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fe4d179e-7c19-4d55-9c7f-6a3f0bd38060", 5, 10 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "79581467-cf24-4d32-937a-be9be4eb6400", 6, 12 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "198e9719-f86b-4a5a-8326-9f81fb08eaa9", 7, 14 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4f10a314-4054-49cd-99c3-5b7a74ff6a55", 4, 8 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b1caddce-ae7b-41fe-90dc-0b5ec327606d", 5, 10 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "91c42d04-e5da-4122-a979-9005971abc25", 6, 12 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d9db07d3-dec9-44ec-b284-a37dfed0af38", 7, 14 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6f9241d5-3709-4a70-a399-bd2a06d16fb5", 4, 8 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8d20781e-3d0e-4bee-9848-dd0a8c048d19", 5, 10 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d7d889db-269c-451a-a50d-09da94816cc2", 6, 12 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c3a218d2-c0d6-4521-8054-d1cae0542964", 7, 14 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "78071050-5524-45fc-adc9-d7c174c985b9", 4, 8 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "855d4cff-1ca3-4d58-b939-8a47ec377027", 5, 10 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4366596f-8a80-4c38-9d79-a01860edca80", 6, 12 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ba2440b5-61c9-41be-9c57-7a12ad49007e", 7, 14 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "39ce720f-388c-4ce3-9c23-11d0d8b0a8d0", 4, 8 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "eed52379-25dd-4ca8-bde2-8b2a9d861fb9", 5, 10 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "add0a503-ef2d-4da7-affc-f779c054cf24", 6, 12 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "367304bf-695d-45ec-9371-12b5da6fc003", 7, 14 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "53eaee47-ceb3-4199-a2a4-3e267b218f43", 4, 8 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c52985f8-a11e-4f01-9fe2-651cb60f4b45", 5, 10 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "95f79eb4-7005-4faf-b4e4-6193236560dc", 6, 12 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6de99f7a-81a2-49e0-99c3-b51b152104b5", 7, 14 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ec94c75d-a050-4724-8cb2-2c7ce661bb21", 4, 8 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "33fe2a2c-33a0-4d58-a48c-2a815f14da6d", 5, 10 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "64f84348-c7cc-4ada-8bd4-e5827fd08c90", 6, 12 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5855dd1c-3758-41e3-b41a-5d5845261201", 7, 14 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "69865149-3ac5-4400-a9b1-8ef333babe92", 4, 8 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aff1a0be-de4b-432a-b673-26afeeef0f23", 5, 10 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4ad9e472-fd59-4421-bc39-f954bfbd8738", 6, 12 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0004d702-59ec-42a9-8467-8f80ec5bc7ea", 7, 14 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7ab149ff-b44a-479b-ac50-85b51cd19104", 4, 8 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "911bb97e-fe71-4f86-9b07-660e66d8f528", 5, 10 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5434d927-a5f1-49d0-89fe-cc97108a8eae", 6, 12 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2f60dc05-2b7c-4a70-96f9-2a446a7d55e6", 7, 14 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "24f03e0b-80b7-4d00-a0c8-c58387e4e822", 4, 8 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "eade3df7-ac1a-4d24-b1e9-5ae92d7e74f9", 5, 10 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3819d896-7d34-4139-b12c-7811c85f92e1", 6, 12 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b2a585cf-aa1a-4c03-b250-5098e9ff69c0", 7, 14 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b73c5d69-71f3-41d5-8709-e7c83c41317d", 4, 8 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7460dc36-eb74-445c-866c-5a19c9721450", 5, 10 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2d824625-2fa3-4143-9d8b-22308e307200", 6, 12 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "38c1db23-fd6e-4bf4-9cd8-35687cb38e06", 7, 14 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a7935df4-3c7b-4016-805e-edf612b3c396", 4, 8 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c9f2c152-343e-446f-b403-32f02eeed25c", 5, 10 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "91af8086-9dfe-46ad-afd4-5886941e4400", 6, 12 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b7a9ab34-0729-4eb0-8737-31717fbb22f7", 7, 14 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3eca5f2c-1c8e-4a5c-87e4-f4d347c4a86a", 4, 8 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e221f872-339f-4747-848e-c4036075e492", 5, 10 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9947fa63-b718-45d2-8e14-36fbcc7c4f81", 6, 12 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d1a34516-0031-4e55-8350-dd320b227b6c", 7, 14 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "463aa9c6-176f-4fa8-9634-cd7b3ee72990", 4, 8 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "93e0b166-407b-4b32-bda9-3065da92de1e", 5, 10 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b8fd8c1d-82a1-4328-b5b6-c0eb763ac13a", 6, 12 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "eae658c4-2542-4dc4-b1bf-fb362bc1778b", 7, 14 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b8df8138-1f25-494d-9c9c-185ca6d1d817", 4, 8 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1fd91415-b7cd-4cab-92ea-6edd47b718f6", 5, 10 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b37f3555-ff0b-46ed-8a36-3294a15f7a27", 6, 12 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5a5e18d8-aaa0-47d0-8ec6-266aab2e1480", 7, 14 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f48b26b1-1dbc-4ba6-8137-ea5c28b35619", 4, 8 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8717cd74-97fd-478d-9492-97c3fc8680ca", 5, 10 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0d8c831a-6273-41e6-acdf-1bf0add07d23", 6, 12 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3059428d-1e1c-4a66-917b-ad73720a726b", 7, 14 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7ba92adb-d0dc-49bf-8802-5ac327b466e4", 4, 8 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "208e6969-efb4-44f4-a7de-8e1dd359cb77", 5, 10 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f4cc1b8e-9576-4abc-99c4-8457a829f68e", 6, 12 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "563ce285-d61b-4cb1-b6a0-3d0f7519850b", 7, 14 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7d5262af-cfb8-4d15-b8f2-0bac4c068267", 4, 8 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e3ca924e-7722-4e52-a104-9d8ec50c35e9", 5, 10 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ee97f237-5307-42bb-a68f-c972a531c45b", 6, 12 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3fc967e6-29cd-481a-b85f-cd86f2c5737a", 7, 14 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ce9d98cf-1015-4a04-af8e-7e67e4c5e182", 4, 8 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ce57da79-e271-48b0-9e03-0ec46ea8e4f3", 5, 10 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "43bd3778-0839-43bb-8deb-6673ce1b16e5", 6, 12 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ed2bf6a9-1f35-41e6-8310-b7e48467b458", 7, 14 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b6359226-2474-43ea-b3df-466e0e8cda66", 4, 8 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cf66bb11-f087-4c27-b811-8dcc859160ab", 5, 10 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0b80a4d0-7107-4700-b481-7ebb08c18494", 6, 12 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "72383733-2884-493e-a038-754f1dcaf165", 7, 14 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6f87bb9b-d2a6-48b7-bc73-41667680130b", 4, 8 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "51e09b36-a54e-46a4-b697-a62e140cad6a", 5, 10 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3cbb4c79-a500-45cf-abe8-e6825c9efd79", 6, 12 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f997d698-2db2-4c41-8b14-afbf47913574", 7, 14 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7dcc8998-5dae-4412-81c8-3d24932afdfd", 4, 8 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7736610c-a6f3-44e2-84c5-3a39556752d5", 5, 10 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d245ad02-f4ff-4c9d-8226-b47312152442", 6, 12 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5667e075-9d86-48e3-a34e-74c93f7cb68c", 7, 14 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "37716815-5bbb-405e-99ec-7e0ef846c35f", 4, 8 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bf4f6f9b-b156-4ada-ad9e-a6429d2c8339", 5, 10 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "454adf06-1d60-4d3c-a737-eca1f0b1a601", 6, 12 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fc193d18-e79a-4070-a484-5238517e1b74", 7, 14 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9bded092-a1dd-4928-85da-c9477708f777", 4, 8 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f44c04ed-28c8-4a32-8736-d55ca40b8037", 5, 10 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "661af567-3661-48ad-8ce9-5d5e02430635", 6, 12 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e9d90af8-7cf6-4bfa-ac5d-5e0642e563d7", 7, 14 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f370194a-50ba-40f5-82a7-5c1e018195ee", 4, 8 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "73cb9ea9-8403-4351-90e6-867e9feb7e42", 5, 10 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f45b9de6-fa8c-4ec4-a6d9-69d2ec5e84c3", 6, 12 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5e9f93a8-749e-4ab1-8b5d-2793f7e7205e", 7, 14 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "640aa1ed-d4e4-4ac7-8a50-a64c3a70f664", 4, 8 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "756a7945-db50-4d8c-83bd-aa37aa835108", 5, 10 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7a172dee-049a-4fa2-b7a2-4886f1499476", 6, 12 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "63557e94-ebd2-467a-84af-8fe28f3d9724", 7, 14 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ef4b4696-5b2c-42e6-9f65-196fb1dc2ef7", 4, 8 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0cdb51ff-2d54-4341-aa8a-c1757d88656d", 5, 10 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ac421c70-462c-4a9f-9b38-2e863eb3498c", 6, 12 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7777cf26-3511-4622-993d-e15d19547bbc", 7, 14 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d9fac311-b5c5-4403-8eac-4b2b798b04d7", 4, 8 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8478b745-bf20-41c0-a6d6-05d5783dd98e", 5, 10 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ffd2572c-16e4-40f1-8ed1-7734b6a7df1e", 6, 12 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fc6b1ec2-bafe-4838-8853-0bee5eb7e4e1", 7, 14 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bdad0597-5873-40ca-93ec-37cc5c4c1972", 4, 8 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6c245687-6f51-4795-8348-01cfb32ea4fb", 5, 10 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ff9f6d82-5ca2-4e48-aad4-65ecd2f60dbf", 6, 12 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6e1fff62-f975-427b-b1aa-19c221d2b076", 7, 14 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "59b76d27-c15b-406c-a779-c5b7bde7dbe1", 4, 8 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2899fc3e-771d-44a6-8ca3-4358085a054e", 5, 10 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2bc75aeb-26e1-4594-80bb-70c3e4c88eff", 6, 12 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b72fd3f8-2fbe-4130-9ed6-0ab6ebed161a", 7, 14 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ed2fb08f-2adc-428f-9b84-05f572ae8f27", 4, 8 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bb7a81c3-5d59-4d57-a893-ab752e5bb45a", 5, 10 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "75e57e51-87b6-47fd-a6e6-423cef5ae247", 6, 12 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "46fb42b5-0ec8-41e1-aaf2-0afef3e53796", 7, 14 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e6c0fd12-730f-4a63-b414-066d6a135025", 4, 8 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a1957daa-774c-40a2-b63e-a721c65350c5", 5, 10 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8abf7104-66d9-4c2c-8ec3-b6d089215510", 6, 12 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9be00880-3934-4760-a7e7-9ab4ddd05ad6", 7, 14 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8f235b5e-251a-443b-8e7d-e30794465ce9", 4, 8 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a62a138e-e267-411b-ac80-660610c32f7f", 5, 10 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c19f43a2-07bf-45aa-9020-6aef381ce3e7", 6, 12 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "247a6373-8e8e-43e2-846e-f5717f21c8b6", 7, 14 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "119cc888-2d7c-4df4-ae0e-00e0783cc782", 4, 8 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bfd1484a-551b-4ef5-9a1d-98184eb9501c", 5, 10 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "99f509f2-d225-4029-a2e2-8363ee9b8219", 6, 12 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e1364697-0aff-4783-9097-99671964620e", 7, 14 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a7183083-e575-4483-a7fa-fc3dd98e8ff8", 4, 8 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ec646383-9e49-4d83-a5a0-6cefd3a848a0", 5, 10 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "da69b9c7-fa99-4b75-8b49-81688b7e1fd1", 6, 12 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8f06e43b-b14d-4b84-89af-95f666278100", 7, 14 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f1f11124-d89c-4a77-83d9-4d7a26f28fbf", 4, 8 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "956f0a65-54a6-4163-a116-4648a1e5301e", 5, 10 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bfde965d-1e12-4af9-acad-9faa3a79d7c8", 6, 12 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "42cf0ad6-f0b6-4658-8550-f4e25cd162d4", 7, 14 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "83b3efab-8217-4c42-8269-44dd6f1336e3", 4, 8 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e47a3fb8-fefc-4585-87ef-ea0360ff83e7", 5, 10 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "43632a95-49da-42bf-8c9f-b332fd909e7c", 6, 12 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3cfd0a2e-1c46-4c5e-88a6-1a641c9fd7ce", 7, 14 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b95ec5e7-678b-4563-9dfb-8b8e368873da", 4, 8 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b9f175ed-cd2b-44dd-9dc2-590994774232", 5, 10 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9ce80b19-a1ce-4f0f-8ed5-7a3bd73afa8e", 6, 12 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2f336b33-e203-442b-8a9a-bcdb060a9792", 7, 14 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "37175225-b940-4583-bc8c-6aa537f399e1", 4, 8 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "348de72a-0e2b-4d34-ac40-4b24896d0a53", 5, 10 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eb04b8c4-468a-43e5-b66b-e5698ea42888", 6, 12 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "55220694-bcdd-4f1b-bd7d-aaa96cb393af", 7, 14 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6cd8ae64-a9d9-44f8-98a0-cb338acddb09", 4, 8 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c2faebda-f19f-44d5-b6e0-a15e206f66ca", 5, 10 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "32ec75c5-1c25-40b0-b8a2-758b8225e464", 6, 12 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "339cea7e-093a-4ad0-b7a4-9af5f3088ae2", 7, 14 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cb01e3b6-ad4d-47da-87fe-28be18db8c28", 4, 8 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "46646741-eb5d-4dfc-849c-6ce64cf27302", 5, 10 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f6a0f948-a4ee-4f96-bc3e-43ee0f185281", 6, 12 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e08681d5-718c-4710-8153-c7aec6693376", 7, 14 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1b2c295a-239f-409c-abb1-523e3eb59653", 4, 8 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e03875b8-723f-4630-8fda-3c3fd92b6b42", 5, 10 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d3b32e49-1a90-4e64-a63a-6806efc38ba1", 6, 12 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "478ea003-3573-458d-aabd-9baef695d6cc", 7, 14 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "15a476fa-8f30-498d-ba6b-32a994d58adc", 4, 8 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "103bc102-5452-4b1c-9830-edb619bf7a75", 5, 10 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0e226d1f-fdf9-4907-a6f4-2fc67e28a358", 6, 12 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "42a52315-2dee-481e-96d1-ef27ad68f276", 7, 14 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a9cf7677-423c-42a4-a794-4e24d890a7db", 4, 8 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5f1feff8-fa13-403c-bee5-e90476c35895", 5, 10 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "569c14dd-fd74-4151-88e8-a49ac1f9aeb8", 6, 12 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "593a574f-4e3b-42ea-85ea-69643eba317a", 7, 14 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "24f03f29-9138-441f-8edf-291d0d2aba7f", 4, 8 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9cb3b6c9-3d7f-4b59-8976-a565bc84b543", 5, 10 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2de2202d-2457-4d4e-baf8-179347c9e45b", 6, 12 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b9e8e8bd-5b3d-4a40-90d7-89343d2e36e2", 7, 14 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d04165ed-e690-41e6-acde-b8f585c3b1a4", 4, 8 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2f92e950-dca6-4665-9d04-a95060241044", 5, 10 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fd406a64-1935-46cc-8966-f4c31be2e8c9", 6, 12 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8cabd491-9670-4b7d-bd41-53e31e2926b3", 7, 14 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2154a373-1b65-467d-9c15-007fb626efc8", 4, 8 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c5cfd87f-3e60-477c-9d91-619b39bf6bd4", 5, 10 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3191bba0-63c5-4f89-a269-93a43597c023", 6, 12 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ca0dde1b-4921-467b-9f1a-87ab19bec6e2", 7, 14 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "19dfe503-78d7-4a27-a680-1cbea914036e", 4, 8 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dc0bcb35-e15f-4b5e-904f-5f39f44584a6", 5, 10 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "78cb23ba-7828-45ed-889d-5ff9c9817f30", 6, 12 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "79de3000-01e7-46c6-a138-796e778a9c35", 7, 14 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "86694eca-0a27-44c8-a495-7aaf88c17111", 4, 8 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "19758198-80b1-4b0b-8d54-2ddf7e183942", 5, 10 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1b57fc07-08c6-4644-900f-33b00ef1a0ac", 6, 12 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "34405078-2058-4309-ac52-4facad8dcca8", 7, 14 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b87e0836-82ed-45d6-a452-e5e3713fda9d", 4, 8 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d783e854-a9e6-4919-a88d-a85acd35778d", 5, 10 }
                });

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00e2e1d5-5577-4f8e-b13b-dde82c77b91d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01388782-b75d-4762-8ccf-4499568fd455",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01e005f3-0bbb-4ae2-9136-f3afe1353315",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "034b18a2-33ad-4020-8d9d-5a98891d0be9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0418ebf4-0b73-4042-a5e4-ce396d5b512b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04871b2a-5533-41da-9959-f664809887c3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04886a46-180e-42d2-a3e5-86df27efaee2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04a7d241-f761-4ead-803b-1d204df7bd53",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04c2c202-afa7-4e2c-941c-29f956783f6d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "06c505ec-998c-46c0-9163-0188423113b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "074db959-27e0-42a0-98d9-0961864e1a7e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0973a418-280f-416d-8df1-7139e28961d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09a2d110-7772-44cd-af5f-27fb951f0544",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09ff2634-4a59-46ce-94c7-8428324d789f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a1ff474-48a1-4366-a120-8ece6ce5ba04",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a7149b1-6928-4099-b623-787d0201e213",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0bf06e4b-d062-4e01-a985-9b05e3f12fd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c59ca0d-60e5-4686-80be-18ab36b53468",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0dddae8d-37b4-47e5-9c89-95589a3f787a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e9b45b3-2915-4dcd-99fa-77ad89f182a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f1d6d17-8b8b-489d-a0f6-7349691aadd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "121345d8-2660-489c-a90d-2469b9c44222",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "142730b0-0df7-430d-ab80-e750ffe0a6ba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16b681bd-b39a-4891-ab7a-9073365bc1e7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a9626f8-303d-41e3-aa54-ae1a971ad179",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f4cf9f5-2976-4b5c-9428-122096bf3877",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2146af26-ce2b-461b-883b-e6f4fe0c8085",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "229759ff-14dd-4c4e-82aa-f56a2181c0ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23672a63-2fd2-4e6a-905b-340ae4456b83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2838e6e6-1238-418a-988c-0346a2abdbc3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "286d76ad-723d-476b-aa84-c7a6541afe81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "299be826-3901-425f-90eb-e445e73ac37c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2b514c67-a65f-4c0a-86b8-5bf92a974c34",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2bc1e669-d825-44a8-a11c-656a8209498a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e5e4216-4af5-4fb6-9c65-8989715e5a40",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b00595-bfeb-47b6-9af3-91d117e003d4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b3b531-3e47-4ccb-9cc9-8e7aafedb810",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "334d6d7e-422b-4376-ac30-161f98aab66d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3396c18a-dcd2-4638-8827-2c7fc10d6996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "364cd9de-6ddd-47d6-a534-74f3f00a0b7c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3770c1af-e181-494b-8c1a-c6f09a3b825a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38af7185-32ce-4cf9-95d2-52c4c4d18bce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38c1edea-3339-4f95-8d4a-5f5583660d9f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c8cf49-d75e-4703-8958-ec3bbff87723",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c99f61-efbf-4f5c-b084-eac381d82049",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39f01cd0-ae41-4070-9eb0-0f2423cc3286",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d6e031d-2fcc-46ce-9eb7-268e95ae1323",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d704609-8abd-4a0a-80dd-2ee9f38a3608",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3da92c21-3bf0-4de1-a187-459271e16106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e2f7a5f-b665-4b13-861e-c5a5029216a0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f6f1dbc-9042-42c2-85ca-a117c745c5e8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41c0e64a-97f8-45fa-a2b3-399ed47cddcc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43606bc6-5874-4469-bcdf-fe1b86f66882",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43bf1028-ea0f-439a-b940-3b81b1f4d683",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43c746aa-0830-449b-a594-621f04923cf6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43ca244e-8d5a-468b-b327-ce6bdc541cf7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43f658bf-a5f4-4537-a281-77dbb5ce1c27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4534cffd-7ed4-406c-9cee-23179740daba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "46c82189-5271-43ba-97aa-a7b0a7dbf126",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4779905b-91b3-4878-97e0-58a010668be5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a450a7f-5ca6-42f5-9931-e130264c8e0c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a67e8f3-4dec-41ad-a5e7-18995a14535d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4aa47021-28ed-4c36-81c3-6e2734d3873b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b376f71-ebf0-4762-bbff-e61541afa410",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b656abf-bdc5-4058-a12b-488d93cc1677",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c0b609e-a2cc-4477-b8d7-9fec89d49462",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e99c977-d86c-48a7-8bd8-9e71d999539a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f8cc09d-7512-44d8-a98c-3004c93031f0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50680664-523a-475b-869f-0aa5e0cd88b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "523db500-84c9-42fa-bf24-f66e77e724e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52a0bd63-231d-4620-9e7a-10b6d4fb8b65",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "541a5387-302a-478d-99f2-c98f6d979aaa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55f0346e-6b98-4a1d-99f8-463b81f6a627",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "56072689-4550-44be-987e-b08667758de4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "564ea3f5-665c-45f3-85ee-e4c45d3ba362",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5754a3be-8508-452d-8a64-9d752bde4f70",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5787a57d-27d4-4dd2-b5e1-35e4125a6e94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a04a2e5-489b-4671-933a-1db0a971f40e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a382843-9817-449b-b9d8-4e48d90aef5e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a529282-1b91-46d6-b472-e6386b95cf5d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b26e8ac-df32-4b9d-8992-047e22372332",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b36c084-dce0-4ba9-ba55-613210750e27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cc37e11-afea-478b-b360-1256896a421b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5eaed820-0af4-4157-8fea-1f58baa77661",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5f9a2c76-50a5-4e93-95c9-158ae078c357",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6183a2d7-d2c5-4828-bccb-754ce1bbb002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "618fdb18-11c3-4166-9bb1-79298a32a7a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61efcce3-e4ac-4aa6-ae46-1b7976b5da88",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64a56e1a-be01-40b0-bc09-1fcaf2161c10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "674202c6-8a9b-4c1f-9eae-0ab056cef8d6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "676211f2-1f90-4059-bdf8-9e26f9a637a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6883361b-7a86-49b9-8fc2-90029770fe22",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69191d39-5c1b-4261-b0d7-48a7833e08bd",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69920a1e-2cdf-4b1a-a9cc-329b986e4b69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bdd753a-2706-48b6-b485-23c989a5f326",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c4014cc-3cc2-481d-9cd6-b13c45da0908",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6e0185cc-235f-4603-9470-5f4ca7c92514",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6eee1f90-a40d-4d95-9ca6-0e45689398be",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f001fcf-f1b6-4abb-8d91-7038044fabfa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f055d63-314e-4a36-86eb-ea7e11e820c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f154805-6e66-45a6-a147-87edf4267def",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f169352-0f68-4d11-b562-f693a0158100",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fe7b587-9518-460f-8c8f-7aa43ad55f9c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7203c646-e705-48d1-8141-b2619b227d8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72d46b9b-612d-41c4-8303-8f8571771de9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "731dd6c2-2937-4d4b-8c56-63b5cf581729",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74770ec2-4585-4665-8f69-b2f0d4f0fc7f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "748cbc1e-8d05-4f4f-8196-9cfb28db232c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74aa5d7a-f513-4993-b672-cdf9bb448319",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "752bc953-0f26-4a2c-afd2-45c5f0b9aecb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75ce2f59-fa25-4745-bb37-371fc11ab655",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77035e08-21a9-4149-8d7c-d4266f88ad03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "777bd2e2-cd9e-4d51-b191-c81eb9d113cc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78157107-23fa-4638-bd17-38187695312c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7965d633-4f86-44de-8ea4-fe0c68aa6a83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79876823-dd75-471e-b2b5-80650a4bdd47",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a3ccc47-8f30-4952-8909-ed3537cfe7e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a7cb657-507c-4325-a047-f9d67b6fbffc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7ac3fbad-b279-4d80-a8d7-ff1407a6465f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7d543840-b11e-4380-a147-7dab483cf5ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "809d901e-d7de-4fec-aa95-655deb2301b6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "80f38d33-7c5f-4952-809c-85af1dc69962",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "815f578a-5fd8-4c79-8446-ff236b6ffafb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8191402a-33f8-4195-bd73-3aa71191981e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81c921f4-7fd6-428a-aefe-648e5e11ed46",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81cb9635-df03-42c8-8d68-944f99de02ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "827e88a3-8580-436c-9112-02d58ca2d7d0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85634f26-c60b-4cc5-8c0f-0fad3182a5f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8601b2c5-4e87-49e4-9099-8c21a9ca00b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86513d65-cf7e-49d6-bd16-94286e5d60c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8906cf96-12d6-4eca-8a0b-d39dd78dc597",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "89c5b8e4-4c60-4e08-88ad-4509be08bde4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8a84a13e-c0cc-4496-81a8-f4550c5807ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8abdfc01-6b02-4b55-93d3-eea25b17de37",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8ad91c05-ccae-4482-9f43-f8f197dccdf9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8af7be7f-0ff6-40e1-b206-e89d78430393",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8cefc01c-282b-4866-a0fa-238ed864481c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d1f8204-852a-4342-b836-767fb2b71263",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9017f445-e420-4568-b8d9-0d84b3c46aad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91cb02d4-02ee-4632-a12b-7aaa4b220344",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "924916c0-2ad0-493a-b544-5df45fa43152",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92a51416-05b5-47ef-834f-ad0baccbb932",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "932c7c4b-36c5-4580-a276-a176a72fd72d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9377deeb-6354-4346-8d56-03b29c97d5fc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93c17f7a-aedf-4f6d-8429-df9ff308d381",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "94430690-6bd2-4e48-b0c3-4de11c7f5d81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9445ce49-5efd-41b8-bdab-b8d7f350b5e2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9570f221-d5cb-4963-896f-371af0b32c79",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "958017ca-725f-4d80-b65e-79560a051a03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "976d92d5-de98-47ea-a219-26842c7f8caf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c301f9b-43b4-4015-bc1d-70ad1b2b690e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f0127f0-a604-46ba-a855-ca6be06fcdb2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f2f3880-4997-4c0b-88e8-f9a74f8b1564",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a07ed297-38cd-456e-834f-c31583eab987",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a08d4c19-059b-42bc-83db-26206735e40f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a278895c-19b5-45c6-92f9-48c5f2724e8a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2a34d3f-9082-4d98-9637-2bd936e60256",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2bcb56b-1da2-43fc-b133-3b5c04603123",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a34e2f74-5403-4e43-bc88-30019ebd460f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a39041d7-3a20-4e73-9334-3fc6d8327e06",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4efe1b6-e7fb-4cee-96aa-1125a3888791",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a907697f-9b47-4302-87f3-c4bed83b24c9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad918937-0645-4b89-86d5-0672662fd46e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aee09720-0d54-473a-b585-c62d6c516e68",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1dae3fe-91d2-42cc-8ba7-dcf237882eac",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2b71d89-5501-4bd6-a358-aca8ce706bdb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5b67003-636d-425d-9784-45d374db713c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5e13a1d-86f3-415c-9c2f-4343258a4b57",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8b726c6-227d-4267-8dba-c1bf5ec0301f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8cc3bd3-ac03-46c4-820b-f7988f3088f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bac28c61-4b74-4193-a109-f4456c44cf67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb1dfb9b-70aa-495e-a041-156a4fbb4fec",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd0cb50a-e769-48ed-8473-b25faa687e15",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "beacb4b7-e74c-45d8-b8df-60e1a2a50768",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c15e0f9b-39be-49ff-aff8-1800116358f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c24852f9-007d-455a-8cb5-0e2681c7a0a5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c35ccc97-39f5-4396-bbe1-2a6171f30d10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c37d754a-9f08-4f13-8d26-630d896c9371",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c474ff32-d65e-4d11-90a2-f9ad2e8ee772",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c50585c6-d1df-4eaa-b5bf-317678e7d3bb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5381f46-f707-4fcb-8f1e-605cee507946",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5d36e60-0945-4e35-9239-22f30c29025f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6633a62-08d6-4613-8f06-a3fcfd76f974",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6fcf873-e9c2-43c9-81ec-ba09bd063e13",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c87ce8ae-adb7-4007-8c0e-0090d0926e2e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8e6b9db-dbc9-4d49-a473-2c8593982b56",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8eeda2a-0260-4488-9acf-fddaee71e124",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c941ed50-01c0-472d-8122-3756b9b55a29",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c99efd04-1f14-49e6-bd60-208290d057a6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cae31f17-a52f-4ac3-97bb-6886500b19bf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "caf33f50-8517-4995-a849-4a70bbe202f6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd21938d-8cdf-4c18-a25a-73a2970c2deb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3167af-629a-4795-8c18-cf4f49e0a7d1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3be091-3d72-4512-ba1d-e8466285b930",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ceaa3043-fb10-4638-b942-85d7b5fc20ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cf03ef83-babf-4710-ab13-ace35476b474",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfb34052-097c-4637-b13e-86a2bc255163",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d302b7f9-1306-4a95-85d4-ff189df4b527",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d501bc94-2256-4ce7-b0bf-be4357ada814",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6003f61-89ae-4240-b53c-542ab36728ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d7a31657-3101-42e7-8b97-aa6ff61d3e84",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d99cdf9c-bda7-4807-b92e-34b3de2e6002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db5aeda4-2830-4ddd-a7ca-02363d58bf25",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db604d4c-9f40-48f5-b244-9b3bdcaf71c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db9ccc9b-5149-474b-a0b4-af8a13f01bc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc91cbb3-94e1-43fe-bf92-06077cf48d87",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc94da97-75b3-48b7-bfb6-d46984b5f106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd438551-3d93-45bc-982d-7c338b69983b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e0f91ecb-de8b-44fb-9a15-59c38d5093b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e35c267e-66ab-453d-ba33-a31c4ce7e5ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d54d6e-42fe-472b-b696-6642067802b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e9ca0d20-0315-4fca-b334-e6e046cd076e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea3367e6-6d1c-4e58-883a-b18d66f30f8b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea59937e-0296-4758-95ad-196fce18db72",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb3e277a-61f3-4f55-b179-d474841a80a3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed9ab94a-9354-48de-8695-43131a67bd2c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eec8a34e-e0ea-4a80-bd38-c7db22f84173",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef08937f-96ed-443c-80ac-1f7b764d10a1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef23ec60-f223-44c4-915e-196d6b011b94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efe2c4a0-7529-4f91-9026-696ea0a1f7b7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f03ff26b-30e9-4a60-b99a-780060db1e35",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f102b409-56b3-42b4-b70c-25192033ba8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f20906f6-cdbb-4f93-9ad0-87e63f0782ff",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f39485eb-f82b-495c-8b60-7dada21ee477",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f43faef4-2885-42c1-9035-ccc2667d7fca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f6edd915-a9e4-4713-8e0a-6f1d7efde18f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f7062df1-beb7-4814-a074-e9da66830639",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "faa28a13-3b08-4a67-834d-621e4dd3d287",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb0deebe-ca58-4eb6-ac5b-67442c846405",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc72a988-3078-4c69-a8ca-c0f1dc1ec996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fee54746-70cf-44dd-98df-5c09bb8959a8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffcc6812-deda-4b92-b2dd-0f59e0a46c44",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 104, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "c7bf0031-5298-4ef0-ba0e-c015f636477e", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 19, 13, 50, 13, 106, DateTimeKind.Local).AddTicks(9349), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "11ebdd3a-f75a-4d85-9916-220874cf8af9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 107, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "152002fb-d980-4750-a70a-7b5d0bdac9e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 107, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 107, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 19, 13, 50, 13, 107, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "e414c224-c069-4ac1-b0d9-c47e2894d1c9", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                keyValue: "16632797-554e-4dd4-8f0c-0748873316bc");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "1aa0d393-0974-475d-b618-e90b54ad375a");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "21e4f76b-45e9-4d12-8eff-cd66600703f6");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "22afdc79-87aa-4194-b0a3-bc96925481b8");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "5cc444e8-6e92-4cdc-a0b5-309b2e1ec567");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "5ec205e4-39af-47fb-ab2d-d6779a0da4ea");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "67856786-c2f1-490b-9962-5080764c48b1");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "6c4c7eb0-6ba4-4e62-857b-e87bafd6f665");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "6f955a5a-0a5a-4e4b-a5f9-c205e14836fa");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "a4786639-cb5a-4bdd-b2c3-436c97875b38");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "bb42d09a-8904-45e1-8bb1-59fb95a4f2f7");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "d1905e6c-4d73-4588-8356-b6dd57b137dc");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "0afd72ce-006e-4086-a5d8-aa4bb250568a");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "242ff0a9-1519-4e4e-b52b-c4e7cad71639");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "24538033-ea29-4dfa-be63-286df4aaf58b");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "29b7a882-8046-4f62-814e-ee0e99c7aca4");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "2ba6ee82-8150-43c6-9ce1-1c73f18b84e2");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "3267f577-95e6-410b-b2c4-10aa1c99bfb4");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "333fee66-e241-48a7-8507-082d6d34ad29");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "3e7b8203-5548-4fef-94e3-d01a0a7e569f");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "478b1e27-b3ca-4bf1-825a-086457cfc827");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "4a575fd6-e952-44a9-86ee-c8572b9c14e0");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5b16dcc6-002e-44b6-950d-de068efb8f39");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "687f8f27-5ce6-41a4-ba8f-571e64c2a967");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "80e58a3a-48a8-4ffb-8461-80e7679f829f");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "866e67f5-4005-474a-a48e-3bd4810ce642");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "8c6eed63-a3fc-4c74-a400-340234ee6062");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "8ecba55d-147c-4c81-b09a-2b551cc590af");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "97a32430-2539-414c-8a3d-9a589c5e758c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "a2cbc8b5-7fdb-481d-a510-fbb2aa531cc7");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "a4a200de-d8da-44fc-8958-0ffd53ab3001");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "acce86d6-d18f-45b2-b983-9ff28061ead0");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b3bd5386-72a5-41a4-83b3-b4670670e637");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d8d7f937-dbca-4d34-a9be-aca3481c2b41");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "e43a46ff-4203-4213-8327-650900184885");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "fbf4ab74-87ec-4d75-a2e6-12f9ad483816");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "11ed7f43-a26f-45ba-a241-644be7412422");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "20af44f5-d296-4a3d-a45f-013dbc699f6d");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "75128f11-db49-4f4d-93a9-62a5da419d2c");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "9525d2ed-c1f3-4c76-8369-b722425c367c");

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
                keyValue: "c7bf0031-5298-4ef0-ba0e-c015f636477e");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "e414c224-c069-4ac1-b0d9-c47e2894d1c9");

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
