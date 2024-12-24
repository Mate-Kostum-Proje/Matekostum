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
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrdersSituation_SituationName",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "RoleUserInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_Id",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_ProductId",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SituationName",
                table: "Orders");

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
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "3239f7e3-2a41-4479-aaa0-d55545fdca23");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "52a4cd9f-166a-481d-890c-05e50257655c");

            migrationBuilder.DropColumn(
                name: "SituationName",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "ProductSizes",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "UnitPriceForSale",
                table: "OrdersDetail",
                type: "int",
                maxLength: 100000,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100000);

            migrationBuilder.AlterColumn<int>(
                name: "UnitPiceForRent",
                table: "OrdersDetail",
                type: "int",
                maxLength: 100000,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100000);

            migrationBuilder.AddColumn<bool>(
                name: "IsSale",
                table: "OrdersDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "OrdersDetail",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SituationId",
                table: "OrdersDetail",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SituationName",
                table: "OrdersDetail",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "OrdersDetail",
                type: "decimal(18,2)",
                maxLength: 500,
                nullable: false,
                defaultValue: 0m);

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

            migrationBuilder.CreateTable(
                name: "UsersRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UsersRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersRoles_UserInfos_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FotoDesign",
                columns: new[] { "Id", "CreatedAt", "Name", "PhotoPath" },
                values: new object[,]
                {
                    { "365dbe4e-2bce-4b82-bd3a-5261f9379d04", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(215), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "3a1ef73a-5773-4ef8-a478-a405d5afffab", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(165), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "4b7db51f-76f2-4215-8e81-06a2a5012528", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(189), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "4e5045d2-22bc-4740-ba44-434cf6a4f92b", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(206), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "72e72c37-ea8b-4594-a3e8-44b3019f3cf5", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(218), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "75b9c805-517c-4209-8085-5f3f44aa364e", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(169), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "9047c8ca-776d-4d11-be70-b2d8bdada804", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(173), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" },
                    { "9d376c08-fb5b-4625-9066-15d0c6b5a8b8", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(113), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "a664a8ed-a87a-4761-af10-c6577d927e27", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(177), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "b5cad56f-fd3d-4ce6-a679-82001fe7db17", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(202), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "ccafbad4-f868-4951-b3b7-2b00c96c65da", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(211), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" },
                    { "dc750dda-ebd4-4e4c-aff1-0d3a234dd1bf", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(193), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "06717927-c5ac-4c84-ab3d-bc30434799c6", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2358), "/databaseimg/galeri/galeriIMG_1958.jpg" },
                    { "0bfec61b-77bf-486f-bd00-f074293edb0a", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2430), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "1330febd-6722-4da5-8d29-d720fbf9fd7d", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2320), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "287e4799-07dd-4ded-8c14-bf5ac804ed8d", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2421), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "324030cd-a3f9-45e8-9455-401c7e563c71", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2441), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "4861fa0e-f2c5-49f1-9d39-2516f29bc5c6", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2376), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "488edcde-0fcb-43af-bf2e-0ab72fa7117b", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2396), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "5288713a-ccef-4632-b96e-cbd8ae93df31", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2349), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "658f98b7-f679-4cdd-afd1-3702fbbcd203", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2340), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "6aba2899-ac9d-4aa9-9e29-e2f56560ae6e", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2417), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "7acf7f01-681b-4689-8d41-48908b032fd3", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2434), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "821b6762-d818-49f2-b8d5-453b4de5da48", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2372), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "87e1ee8d-41ce-4151-b9e5-2aad553127b7", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2391), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "a58884a8-8661-48fa-823a-3d3fbbdcdd1d", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2408), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "b3be27cc-951f-4146-af5d-38feedb82e96", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2437), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "c873dc32-42b1-4616-bfb7-e4fd17312148", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2404), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "d868dae9-e04e-4791-bfb0-5b4aa3ab1864", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2400), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "da37970e-7d2c-4d52-a8e0-9bb7976d14b9", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2368), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "e1090e0e-ac03-4476-8df6-959560069e15", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2353), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "e7d6d65a-24ae-4016-b438-736e2185107b", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2426), "/databaseimg/galeri/galeriIMG-8454.jpg" },
                    { "ead666d9-a098-4042-b1ba-f377795c14e9", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2412), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "f214122b-dd0a-4a6d-bae9-5abf2d1eb38b", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2381), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "f231ca8f-1173-4143-9dba-cbadf7e2a01c", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2385), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "f81ca274-c921-4661-9a22-c83250e079d6", new DateTime(2024, 12, 24, 19, 25, 58, 729, DateTimeKind.Local).AddTicks(2335), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 734, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 734, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 734, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 734, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 734, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 734, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "488ff51c-27b6-4a92-9b4e-2d394e025450", new DateTime(2024, 12, 24, 19, 25, 58, 736, DateTimeKind.Local).AddTicks(9530), "Siparişiniz Alındı" },
                    { "580c8055-b69f-4514-9e10-eaa3859a057b", new DateTime(2024, 12, 24, 19, 25, 58, 736, DateTimeKind.Local).AddTicks(9556), "Siparişiniz Tamamlandı" },
                    { "a204dab9-d88b-467b-9c79-9af01012f146", new DateTime(2024, 12, 24, 19, 25, 58, 736, DateTimeKind.Local).AddTicks(9552), "Siparişiniz Kargoya verildi" },
                    { "f8fc0e63-97ce-4072-883b-ae7c7fb72180", new DateTime(2024, 12, 24, 19, 25, 58, 736, DateTimeKind.Local).AddTicks(9548), "Siparişiniz Hazırlanıyor" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 738, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 738, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 738, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 738, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 738, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 738, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 738, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 738, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 738, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.InsertData(
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId", "Id", "SizeAmount", "SizeNumber" },
                values: new object[,]
                {
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "17b833b6-9e8e-450c-87a1-b545056bc3cc", 6, 12 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dcc7c2e9-d8c9-4485-96db-f7637a0c020c", 7, 14 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f8af7bee-e8f0-46f0-8f6c-0274290c9c90", 4, 8 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7228b326-92c1-4bf2-9f53-8b9f757efd84", 5, 10 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ce5237b1-3778-4eeb-803a-1c6fc7fce6c2", 6, 12 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e513d4b6-5ab4-4b18-99e9-962aa3394a6a", 7, 14 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f93cabb6-037e-4b83-b517-5dfdfc6c01c3", 4, 8 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b79db2b9-5cac-48f9-a30c-35ce0f0eadfd", 5, 10 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f0260f16-cd85-48d2-9397-9d483b67b6f9", 6, 12 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e3bf65d8-f600-4472-b7a1-3bdc15bcf6b2", 7, 14 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "803cb521-5ba1-4dc9-a8da-15f7e5f37538", 4, 8 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e2f6f213-f861-4774-9504-51c3ad611d70", 5, 10 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8d87f595-90a3-4055-8a23-4e25eab449a1", 6, 12 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c5ca343f-3e2e-4962-a93b-c513c9b73a40", 7, 14 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "498c6235-b41d-4d35-9040-5ad400bd82a5", 4, 8 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "38f4b2c1-e529-47fb-a3d3-3263b7e373aa", 5, 10 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d45f1947-a33d-424f-93c9-8d9545ce8f0c", 6, 12 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "be39c34f-918b-420c-af58-4fddeff3abc1", 7, 14 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b2dcb2a6-19f2-4093-a131-9ffef93e480a", 4, 8 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bf74128a-dfea-4f8a-ac70-693f6481df4f", 5, 10 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cd6c5c6b-40c3-463e-a27f-aca6337f8283", 6, 12 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8569fb8b-db03-43b3-98b7-370d4c5de718", 7, 14 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dfd21eba-a13b-4e86-9365-820fe473e1f2", 4, 8 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "58160e77-ce57-45f5-b0b5-222164ffc9bb", 5, 10 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e119cacc-b83c-4d45-9f4e-ce90960ce91a", 6, 12 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a8801338-ef0a-4497-b2a4-7f155ffeb610", 7, 14 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "35325923-024d-4e4a-a9ab-512e5b12f121", 4, 8 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b103aa91-3d54-48cb-aaac-03cea023a80e", 5, 10 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "556d358a-c66d-4e94-8b7c-b7ce64e6f918", 6, 12 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "16f01119-5614-4121-b442-3cfd4528574e", 7, 14 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8c7889e0-c741-498d-8638-248354fb647b", 4, 8 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4ed69987-842c-4693-8519-2df582fe1d59", 5, 10 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b6b9c18e-d1b3-43ac-ae2c-41045e9b4079", 6, 12 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "519e11a1-5b69-48ef-8a14-ee1070eade02", 7, 14 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "028580fc-288f-4a83-9372-438dc450bb9f", 4, 8 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "321c305d-f0f4-4394-ba75-31deca9d294e", 5, 10 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "732ad461-558a-42f0-8a52-0b9a1bc0fdb5", 6, 12 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9bb37a9c-6453-47d3-89b9-9c8491d93f7e", 7, 14 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ec6bd102-4f11-4b9d-9a46-a0d55ff2c861", 4, 8 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "06824a80-a53e-43ff-a8e0-cdcb20c1da38", 5, 10 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e5f1a6ac-67fb-4716-844b-154076cff028", 6, 12 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "21aaa545-e993-46aa-b33a-64c2e3c36c5d", 7, 14 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2788cbd7-e9f9-4532-8d47-22c6ffa0ef6f", 4, 8 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b9182dc7-63d0-4343-9f6e-04b6997ecda1", 5, 10 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e94a9c12-d635-48b7-b9de-74ff9b87cc84", 6, 12 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a3e41e3d-dbac-4381-8ac3-c9082149f6b3", 7, 14 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5817c920-3b14-474c-ba6a-fed993d8d37c", 4, 8 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "187ec579-9343-497c-b001-3df73b85e103", 5, 10 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "31c96849-849b-48e9-983f-309b764b493b", 6, 12 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1ea1deec-d4b4-472d-9f52-6a6bcc104888", 7, 14 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bd495eb7-77e8-4805-afba-5ec42b557d95", 4, 8 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4e6acadc-f99b-41ab-a4f8-fc652e36abb6", 5, 10 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ee95848e-b3ed-484d-a8fe-c84caca5aaed", 6, 12 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8261af47-74ac-430f-949b-4edea003dc86", 7, 14 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "58f208b0-caf9-40fc-9584-03a82d65147b", 4, 8 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8b9f5ebd-29d7-463c-8f2d-0831085f483f", 5, 10 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6d441568-0d26-47e7-869b-b3befb07e942", 6, 12 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "027d7df9-6751-45f6-9fdd-6f2b80b3f7fa", 7, 14 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8b788724-e291-4afe-857f-40eb3070a396", 4, 8 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "12da1d90-f51a-4db9-814d-d7498fcb612c", 5, 10 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fe04f382-c960-4475-adb7-166215ba266c", 6, 12 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4bf5d2bb-3043-4ea6-94c5-b7be4ca1da62", 7, 14 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b8898506-4860-4476-9d2d-9860e9826f87", 4, 8 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1902f751-efd0-499d-a9b2-9c276a48c057", 5, 10 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c21c7c54-5422-4489-b3e6-d63f3da81ff9", 6, 12 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4b6402f7-4eb7-4226-9a06-351141b642e4", 7, 14 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cf203d46-c16a-4ec4-8baf-73463603a0e4", 4, 8 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "64777125-09ab-49dd-99ad-550e65700543", 5, 10 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "abb5fe3b-f67f-4651-8bd9-cbcd9955615d", 6, 12 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "becc3e38-775c-418b-bb26-4b8369c277ce", 7, 14 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "08478770-f291-4142-a72d-8aae441ce060", 4, 8 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "68c2f568-48e9-4d73-9400-2074adf0956e", 5, 10 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "892aaa29-4132-489b-9ab3-e0aa4baf2298", 6, 12 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fb24db25-e8d0-41cb-affa-6c602374824a", 7, 14 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "28f6f695-ae83-4cbd-b2f2-17e597846692", 4, 8 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9182b808-00eb-4b28-ab94-c588df4d2da1", 5, 10 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9c22c4c9-cd23-444f-894c-4f242f2b89d3", 6, 12 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "65628db5-2237-41f0-a804-48db4ac39210", 7, 14 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ec2259ba-d76b-423e-9a49-a569d8eeb447", 4, 8 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6f34f488-7024-44c9-96c3-627c81e64c29", 5, 10 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "735e2bd7-20c0-4e35-b30a-5274ce8a7276", 6, 12 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6268fb1b-f18a-4959-a75a-2d131639dfc3", 7, 14 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b6021346-8f57-4934-a6db-6e9ace78ab03", 4, 8 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a2fc61ab-6a1c-44f4-a14c-a4a60113bd6f", 5, 10 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a045afea-f758-42c7-b25c-efd70d2e4782", 6, 12 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7e00c0cc-4724-47fe-b3fe-c35ce18c2ab5", 7, 14 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8b5b2b4a-9c25-4d2c-ae26-5d1367d18280", 4, 8 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4c47633b-3aff-4ae5-98ae-0e11963f2d66", 5, 10 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2a4e8b37-a268-4eef-a97f-4dae28716603", 6, 12 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c9dc8da8-626f-407e-93f4-9e01dc7e0c4a", 7, 14 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "94d650b7-fe11-4758-971f-2153ab1bd025", 4, 8 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e015f95e-8607-4bf5-91ea-559b2c40dcdb", 5, 10 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9a0da2d3-7f72-4c9f-8d12-5ad71797956b", 6, 12 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1dca8b7d-143e-4825-af35-97b6ebbeccf5", 7, 14 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "88839d50-05cd-453a-b5c6-8baa8ab1f89a", 4, 8 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3f612ee0-4e5a-493e-a320-58bcab5d6987", 5, 10 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "73382fd5-5fca-4b7d-bca0-59c67ef35f02", 6, 12 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e4d617f2-20db-4bce-8bf0-ba5151da9465", 7, 14 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "aa1d55ee-b241-45b5-8ca4-95718554b715", 4, 8 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "80958dec-e653-4e2d-a3a7-ea6b6d281d74", 5, 10 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9dd4096d-34e0-4435-9719-d9da44cb75da", 6, 12 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bd476c6b-2e97-46a8-87be-881b97991768", 7, 14 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "efe946e0-8c47-4d8c-b7ec-f49dbcc78088", 4, 8 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2c5a48b1-3239-498e-8527-8ee7b2f177e0", 5, 10 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "79b73f59-adfe-4e2e-91fd-8a087f36e25c", 6, 12 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "017c1a6d-5559-4900-9e9a-84527132558b", 7, 14 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "696b406e-9d66-46da-9bda-43dff51fa9b5", 4, 8 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4192dc21-c275-4e1b-a4bd-3f010810c28a", 5, 10 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b3b6f93d-a8ed-41a0-9724-5fa3a5166f12", 6, 12 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "81a1946d-4cba-48d8-8a91-a2ffbf6cca42", 7, 14 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "735ac37c-1e05-4cec-91a1-737e403b9661", 4, 8 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "78180343-f2ac-47d9-93e7-ddfa69956697", 5, 10 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ef719d04-0412-4e4f-ab2e-c92a71b5e073", 6, 12 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "63050eb2-9560-436a-9dff-a8497a36e2fc", 7, 14 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "745b25de-c239-4c0c-92b0-abc5531b66e2", 4, 8 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ee292cdf-47d8-40fd-aea5-525f2f8105c1", 5, 10 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a32b89df-3762-4e13-ba0c-49ce5b98c958", 6, 12 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e44194ee-3bed-44a5-b40c-d53ec328b2eb", 7, 14 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c9c3dae0-2a45-4e46-a26e-0d8e518b92cf", 4, 8 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4f8aeff4-aa77-4511-b0fc-0a759f91254f", 5, 10 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "277c3254-3516-4a71-b736-5b1a0839c7c8", 6, 12 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b588b525-74bf-4126-9998-bbe5b38a4e0b", 7, 14 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9fbc6f56-68a6-4657-be00-6840a640201f", 4, 8 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "94609a71-dbbc-44fd-93b8-9b381b8bc617", 5, 10 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "211d3363-c487-4b32-9f3e-8259541be9e3", 6, 12 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "90fa3b85-5512-444c-a64c-2ea477a1a8c8", 7, 14 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a85aa1bb-5924-47be-a9c7-892dbfaa40d4", 4, 8 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6442641f-b54c-451c-a188-334dc559f724", 5, 10 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b618a552-b32f-4363-ae87-21164d0221c3", 6, 12 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f25896fd-74d4-4dee-b9c4-7ac242a27d9c", 7, 14 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "df95f352-02bb-498c-a504-deea7bdfcb75", 4, 8 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b1c81d59-e941-4cad-a8a2-97b9ce275bcb", 5, 10 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6efaf74b-97fc-4a97-a7cd-749b4c7778ef", 6, 12 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c18afdc5-2894-4b37-8ed5-69938dbb33b4", 7, 14 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7ec2a8ed-2e30-4c2c-84db-20300cb48f4c", 4, 8 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7af5da13-aafe-42c9-82a2-0a7ab803ad9d", 5, 10 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a51cd97b-b618-4a81-a9d4-54390d4ed9b5", 6, 12 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0f1ac326-c584-4067-b8c2-b6abe3cd134e", 7, 14 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e64b8e17-d14d-4206-904b-2d72d9b235cf", 4, 8 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b794445c-358b-4373-85da-6e1a6d06b67d", 5, 10 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "485f7dd4-b80b-4a9e-8c09-29c9ce0a97d5", 6, 12 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "41cba1e5-e03a-4809-b3de-3a84f5363f69", 7, 14 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "eeb262a1-8bb0-40ee-b8a8-6fd6247eb0fe", 4, 8 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e9fabeb8-4732-44c3-a69c-e4e10f46b7c5", 5, 10 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "55b32726-5af9-440f-88e1-024912eea868", 6, 12 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "071f6299-ed10-49ea-8707-8a4b4006e525", 7, 14 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b9ced8c8-bf33-4a4c-ab34-afd1b10868e3", 4, 8 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "eb455b49-3b34-4dbf-82f9-83a16678a06e", 5, 10 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f7a8f1e0-c624-40e5-9440-2aa6e4a9afa7", 6, 12 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2834246d-ee40-4c33-b474-32d54c591679", 7, 14 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4a01d4fe-140e-430b-9520-ca5c332697b3", 4, 8 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e6cfb5d0-1606-4124-b9dd-5c81280e3609", 5, 10 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ea63d774-8271-441b-87cb-5dd9eae4e8d7", 6, 12 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ee633640-31d6-43a1-b30c-5914a4085a87", 7, 14 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f4eb7f32-fdbd-4f65-8c01-1be7483db9a4", 4, 8 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "34d56bcd-f588-4786-8c94-94530a0cc6ae", 5, 10 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "08d1889a-4c4e-4736-90b8-0d1773996f81", 6, 12 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "459e7d7f-af1a-4c64-a33c-c83e785bd222", 7, 14 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6dd90991-0f2a-4dcd-878f-c550dc3bbcc0", 4, 8 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dff39e32-ec1f-4f15-b0bd-bd7c169979d8", 5, 10 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "de2078c3-1f4f-4cde-b21e-3a4d99d29ad8", 6, 12 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "11a8c457-05dd-4734-9f3c-f66c9f6697c2", 7, 14 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7fb48bc0-c982-4621-a22f-89816145062d", 4, 8 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5ede322c-799b-43cf-9ed0-1a1502b810e0", 5, 10 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "73f02740-a15b-4f2a-96c2-b7f7387af542", 6, 12 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "32c0089c-bce1-457c-b486-6674d64d4537", 7, 14 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "808dd577-75fd-432b-831e-2ca0afb4a142", 4, 8 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "954cdf1e-3366-487c-a4dc-60ac002b6d59", 5, 10 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1182ecb4-5579-40ec-bdfa-adbeb50fbed2", 6, 12 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1ad109b8-2227-4782-8473-f54218fc3e24", 7, 14 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "01975538-f93d-4971-8bd4-58d73e6c10af", 4, 8 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9ebb83b8-bb3c-40bf-b46c-f5f5ed8f5b49", 5, 10 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a79534d4-9fce-4492-9a8a-4af39519033b", 6, 12 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "488487ce-bf29-42a7-975c-594cf232fa4a", 7, 14 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a5359c23-469f-4ede-8c4c-d6b4ee2eac55", 4, 8 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c6ffac30-02ef-47e6-a77d-98019e8f6308", 5, 10 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "58b4b835-b12b-48b8-9ba8-44b742f4acd1", 6, 12 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e62069c8-eaa4-4d78-9a6d-e7c3c5f7a70d", 7, 14 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "16a184ee-d0ce-403e-a3b3-e65f1a676f9d", 4, 8 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "431cbf27-6cd6-4a9b-8a05-de69cec59554", 5, 10 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b16f8d67-360c-4139-8ac0-e1e6dd518a44", 6, 12 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0c59abb5-1845-4a3a-8bf7-894fdf5fd3b6", 7, 14 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bc6551f7-f8a8-42ae-8961-81b26c257df5", 4, 8 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "72ab4dce-fe49-4e2b-925f-272aa88dfc89", 5, 10 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8cba4013-9d07-4889-82da-629c042bf6b4", 6, 12 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d75585af-0458-4fb5-89b9-3acf9a8ba919", 7, 14 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7d703172-633b-4cb4-ac92-7029715a7a0d", 4, 8 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "00a96ef5-c0d8-4232-90d0-a84b76f897c8", 5, 10 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "12177a99-6b3c-4dcd-a257-00930a8c75b1", 6, 12 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c3b911a9-cddb-4eac-9b47-a514fb0fcdfe", 7, 14 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "43200f50-a684-45bc-9df1-c6e512785982", 4, 8 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "eb6fc21a-50e5-4873-80b2-3815714a906e", 5, 10 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fdbf89d8-d0a0-4833-8cef-91ec6e942098", 6, 12 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d7b7a486-d6b0-45db-a992-bcf632869928", 7, 14 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "baee6e30-6342-4f9c-ba8d-8a1b5e556c28", 4, 8 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f799caa7-db8c-4f22-95e7-7d32f11cd424", 5, 10 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b8a11298-700a-48e1-8998-129208bd5893", 6, 12 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3a34ba6e-e4d2-4d86-9ee3-9bedc04126be", 7, 14 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f6555d48-0d06-431b-a0e8-e73f1f889717", 4, 8 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bf8fadcd-24b0-480a-b728-13eccf198dce", 5, 10 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5e2d3396-71e1-48c1-a4c0-4f5c28855188", 6, 12 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "816df5e1-7f5e-45fe-9f71-8c4e28dbd08b", 7, 14 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "23bde41a-481a-4aaf-9e78-b6ea99c2ce2b", 4, 8 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d61d201b-372e-4aed-86f0-42e20f9e22b5", 5, 10 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "232991db-1d60-4717-ac6e-f4f65cab8fc2", 6, 12 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fcb05e0e-da7f-4f25-8a91-82339e664db1", 7, 14 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "282661f8-7842-4831-8598-f3c434db299d", 4, 8 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7723e39a-b2ef-4fbc-a840-7a16e10fb3a4", 5, 10 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "63cd7231-8d52-46d1-b3be-3d78e218398a", 6, 12 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "647c4bc5-7f3d-498f-9b80-69374ffd066e", 7, 14 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1b96e990-f2f9-4652-aa6f-3cbbc04bbad7", 4, 8 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c6e71d10-cf94-4bef-b05b-e0ce0194c9e1", 5, 10 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "90c3b80f-af9a-4dfc-ae39-1206f6bb5805", 6, 12 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b4bc8f83-de31-4d46-a69a-bba31a0e99da", 7, 14 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ce22c5ed-beaf-4c0d-a58f-cc7a05dc20dd", 4, 8 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8fd33f37-40f3-4108-98bb-5ebb5c13ba55", 5, 10 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0c1c268d-1918-4d97-9207-bd6899e8a858", 6, 12 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c9ce6ae2-43b8-46e0-a758-29bd7c64b98d", 7, 14 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "334376c9-9d2f-4442-8ccd-bb03c9a10118", 4, 8 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9e8b2a38-786d-4858-b390-c9a24b387309", 5, 10 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dda8715e-0d71-4489-aa5d-d943847210c4", 6, 12 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d553cf12-37d7-4670-8ab3-a0b02bde6166", 7, 14 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8f8f8168-aa72-46af-a4a7-a68b2c51c880", 4, 8 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "95073719-a7ef-432e-b3fe-28029a367e71", 5, 10 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f824b69a-8d14-4311-9d80-21c79badfb2f", 6, 12 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cab36154-a6df-408e-b6b6-67127e39aca0", 7, 14 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c3ee3cda-5b0c-4256-9890-1dc39a065235", 4, 8 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6fbea043-3cec-41ed-a411-7ee16415b4bf", 5, 10 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "49d6f59b-d66a-4293-8115-3aaf2a0ba4a6", 6, 12 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "26d973d5-edc8-43ea-b42c-a6dc19f43c43", 7, 14 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ecfc8099-cd9c-4dbd-ae00-0a88833be152", 4, 8 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c8cd4aa6-f639-4250-8d77-4a2f506024d7", 5, 10 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a2ec2bb3-53a6-486f-8e33-2525b9dcfefe", 6, 12 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4660d43c-0f55-423e-8745-e12adcf26051", 7, 14 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b04307fa-2da5-4189-b298-2a31dfd413f8", 4, 8 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ee124771-3135-4437-9165-34212d8998e5", 5, 10 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fe75385d-a4af-442a-a291-d71fdf41a61a", 6, 12 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b2c51822-0ead-43ef-97f9-0a9cc410b63d", 7, 14 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "94c5a7e3-cb13-40ca-9f5f-30cd6eea0263", 4, 8 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b4eda2a4-a549-4c2b-b238-6bc5aa984ed7", 5, 10 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6a82ff0e-0efc-4831-9ef3-a949230030f5", 6, 12 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e5a730ee-3b12-4ce1-bbfd-b96d16f61efb", 7, 14 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "390b3a86-66d5-41f9-9316-390f4b490e28", 4, 8 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "04f8db7f-1e23-4848-a111-0c64a65a4d7f", 5, 10 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f17d80e0-c1ea-4347-9958-83fea8fa2597", 6, 12 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "44ca108e-0ccd-4838-ba81-338e0ea580df", 7, 14 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0f3e8626-6c1a-4598-94a6-c1471deb9db5", 4, 8 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7cbad395-9bcd-491f-9f37-11e19bb99441", 5, 10 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2b975bd0-8f7a-4691-b962-acc60129f9f5", 6, 12 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cd002da7-4780-4b61-b0a0-1cdf04dbb7db", 7, 14 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ec71b0e2-de3e-4e0d-b752-3c2b5b01b36c", 4, 8 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "62de7704-c6d5-45af-aef5-d869361b32a9", 5, 10 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "22043f90-bb8b-4649-8613-a56099045125", 6, 12 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "95b0539d-958f-436c-8d1f-2936b4e04f31", 7, 14 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7cc9774f-42b9-45eb-9140-05ac80b403cc", 4, 8 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "70df6d01-3836-43b2-910a-f919fc05a969", 5, 10 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f98027dd-0981-48d7-8887-6ad39365897a", 6, 12 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5ecf2710-1acf-46eb-baf6-eb6a9257b550", 7, 14 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0b250d19-b6d8-4a28-bba6-19a687aa8d6a", 4, 8 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a5b19ebe-d7bf-4aed-b063-9312c38305fc", 5, 10 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "93584b19-26d9-41a5-94eb-a494b92bb363", 6, 12 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dc459835-2ec0-48e2-9d81-322a8dd89de7", 7, 14 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "187d4f88-a938-4961-98c7-430b386069ef", 4, 8 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d7530d90-c85d-4f25-8467-635067e3deab", 5, 10 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f4b21340-dd1b-45c9-8c23-cfd0c59a783e", 6, 12 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3d6fd11f-df7b-4290-a0e9-228a293bfc3b", 7, 14 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8dd3155a-b09b-4b9a-aba9-c89b1836cf04", 4, 8 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6adb8b64-a826-4a27-a6aa-998fd5c5fb0b", 5, 10 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d331c307-99e2-432d-b79c-0b98c6caf5ea", 6, 12 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dc1dd3e5-ec7a-41de-99ac-683fb7c81881", 7, 14 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "97e6aa63-5e0b-483f-a480-3772d9d19341", 4, 8 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "786c88a7-c256-4c0b-b075-12e027e66b7c", 5, 10 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d4c01b6f-63ab-4d19-9c00-4e8858352604", 6, 12 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "70217370-39c4-43c9-a796-adf345ab8ef3", 7, 14 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b7e0bd2f-f2f2-4c7c-a549-e83d290a62ff", 4, 8 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ac2dcb81-f224-4f18-9633-dd7e685164ce", 5, 10 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2c3dcd77-3e1c-4667-b755-8a2bdb2aa78c", 6, 12 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d91eb6d6-d117-4300-91b1-41a7b7853bf5", 7, 14 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7a995add-52c1-4476-b324-1788a1f6b9a0", 4, 8 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "36716ecb-6d7f-49d1-91ad-95ea19612a79", 5, 10 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9fe0e532-a38b-419f-8884-25fa4a1a5a08", 6, 12 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c49f4d0d-b356-4917-9314-2390de2eb7c0", 7, 14 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "65755ba2-f279-4ddc-b744-cb7480f9f29e", 4, 8 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "57d1e053-5bb7-46d8-833d-33961e7754b8", 5, 10 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0216e680-f53c-418f-a358-7402fca9403f", 6, 12 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "013927ec-8bdf-4061-820d-7838a76c843b", 7, 14 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "875c6468-173a-4a01-becb-7807bbc5514e", 4, 8 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3ad9a38b-b728-4293-bb14-8011c519d6b1", 5, 10 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8dbe4bb8-991a-4763-87d2-7048a1c9c9c9", 6, 12 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c27b0be7-c9e1-4d72-9b01-53697966ecc9", 7, 14 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "08bbf854-8ae6-4030-ade2-788249c7d3e7", 4, 8 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b1cba026-4160-40a5-8fa4-71470772c990", 5, 10 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "338f13d9-93e7-4fca-8db7-00c1b66a6584", 6, 12 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "299fd41b-3ba8-44f9-8c56-ee9cf11acd9a", 7, 14 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "18b04c36-d605-4cf3-b6f6-aa05de11fd45", 4, 8 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "afea8b56-570e-481d-8ca7-a619dd61b668", 5, 10 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "76026fdb-92cd-4a3b-a916-d72d05bb2434", 6, 12 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a74edc98-0708-472d-9055-2738eafab8ae", 7, 14 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3fcd9215-10ab-4dc0-9cdc-a9bd6b5d60f1", 4, 8 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d89743e0-12ff-4f6d-aa19-68b0a810906d", 5, 10 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f7f6343d-4be7-4861-96fa-7a4be54d8b5f", 6, 12 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "19abab5c-2db2-499e-923e-f07db7ab8f0d", 7, 14 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1b7a836c-d6d1-4567-8a3b-ae90586cab9d", 4, 8 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ec8d13eb-7a86-40c0-98b3-f2afd1b6ef8a", 5, 10 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "50c4871a-9fbd-4684-852b-4651da0d8904", 6, 12 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3adc3ce5-9116-4065-abb9-bb43bb9c6ad5", 7, 14 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d05ab979-0987-4f79-821b-46dbfce812e9", 4, 8 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a956f363-780e-4843-a269-730cfe84bdc0", 5, 10 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "34156c6c-abbb-4117-91d6-1b5e17299e41", 6, 12 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ad2f2f37-0cc9-46e7-9c86-967867ab2155", 7, 14 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "244a647b-9f42-497d-b97b-a526754c07a3", 4, 8 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "db67384e-5c98-4cb2-a076-8732dec69a6a", 5, 10 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6e17fb70-7dfd-4fa0-885b-afd550c2a62a", 6, 12 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6896c96c-8ef5-4768-bcd4-ff483e4d3a62", 7, 14 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ae6765c5-b2a6-459a-a197-4862f587ac4b", 4, 8 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "31dc62fc-9a2c-4649-967d-69e41c70c661", 5, 10 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a482d597-9fdc-4de0-80b6-e98f16bc4b36", 6, 12 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b4c03a2a-19bc-4f2e-bc7e-c699147fd9bb", 7, 14 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bb77d879-e2c7-4f7d-8aa3-8e859124e643", 4, 8 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "53fa7ccb-4c39-4d75-bbd2-40f581c08b31", 5, 10 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "97862f68-df94-46e2-9243-c15232b14fb1", 6, 12 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2533a6b4-9d93-4aee-9b8e-5c0603bf62af", 7, 14 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2997683c-fd49-4c19-b2c2-1af4eaa40dac", 4, 8 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "039bf313-913f-4c35-ae89-5afd1ba76cb8", 5, 10 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4429e489-c463-4f71-9001-8ac2bb8bcbbd", 6, 12 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1c0dc1c6-abd0-45c6-9f82-288ecad248bb", 7, 14 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8cd68cfb-ff74-4f70-87a9-8e242fce82d3", 4, 8 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d85f9657-ffcc-4343-a4ba-5485a5aaad65", 5, 10 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dcadc13f-c6c9-4aa2-970f-8e94554adf2e", 6, 12 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9f9c9836-faa6-4d52-bc6b-40476074731a", 7, 14 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0a5b9636-49c5-499f-a803-e6828ebacbbc", 4, 8 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2819784b-a540-4d4b-a4c9-6432c8e640bd", 5, 10 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6eed93a7-daf0-4438-ad74-e26591cdae50", 6, 12 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0d3da2a5-1c39-4b16-9595-dab162f36b88", 7, 14 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7e62f736-469b-40fa-b92a-9b69e6927cb3", 4, 8 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "479b0b17-cc8e-4e4e-a128-d76f1ab0a9cc", 5, 10 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8f1999b8-05b5-46cc-8aa3-5096ab519ef0", 6, 12 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7967037a-3117-4f32-9ecc-03a8101cc3b9", 7, 14 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ef352ce3-e59d-49ba-9160-e73e31dd74d3", 4, 8 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "884e72ed-d234-472c-8396-9d0a9bbf4230", 5, 10 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "252267a5-b5cb-4084-813f-c0b27c1697a9", 6, 12 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e17d9649-acdd-4c47-89ff-22041f64597a", 7, 14 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1dd50d3d-ebb6-4a9e-82f5-8bae859ea9ec", 4, 8 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1ed6c0b0-643f-4912-a281-52c0cca9c3b5", 5, 10 },
                    { "56072689-4550-44be-987e-b08667758de4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "179f9e81-5883-4232-a513-c56fa4aba87a", 6, 12 },
                    { "56072689-4550-44be-987e-b08667758de4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4c9fd3ff-625a-4b8d-94d5-8ab736ac552e", 7, 14 },
                    { "56072689-4550-44be-987e-b08667758de4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b7c8e0c9-f6bf-4f0c-836c-5ccc18a3dea2", 4, 8 },
                    { "56072689-4550-44be-987e-b08667758de4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bb688a04-1643-4fb9-8bce-4890adf54baa", 5, 10 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b3670712-8ac8-44f7-ab38-a1833c59a477", 6, 12 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "274949c6-9df6-4bbd-8ae4-2d5aaab177a9", 7, 14 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2b4bb33d-0aba-4722-892f-bdd099456bc6", 4, 8 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9a655af9-96de-45fe-9586-a650b12cdf81", 5, 10 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "84b47702-cec2-4919-848b-071fcf23bd29", 6, 12 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "18240021-6cc1-4abc-a2fa-c7a57e426704", 7, 14 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cb138299-eeaf-4b3c-82d9-2bee3d4027a2", 4, 8 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0ca11e5c-379b-4ed6-956e-c991d28ae070", 5, 10 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8a7354c8-4518-45c1-82fe-350beef7f7ba", 6, 12 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1dc26267-ca00-4d9f-bb7e-d4064d7be193", 7, 14 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5d09ad26-05a7-4aa0-aea2-007559433b2e", 4, 8 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "87dcfca6-b27b-4dd2-bc5a-eff86f352a75", 5, 10 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7239e92f-ebf0-4390-887d-8c505bc10f74", 6, 12 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "07be7b91-d070-4451-8fe5-0ee14472de51", 7, 14 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "559600af-1850-433f-84b8-1490838b87d6", 4, 8 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "82d1bc10-bbd6-43ab-add9-53990ee6c7f5", 5, 10 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1fd07480-ec1f-4dee-8c45-8820f0fe4199", 6, 12 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a1c9b17c-fc75-46d7-bc69-ed8c010b4c0a", 7, 14 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5d53eb4c-cb10-4964-8f8b-70891dbd68df", 4, 8 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5123e06d-af61-4d8c-9618-2f8c3664140a", 5, 10 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ab53ddcf-7625-4e91-8f17-97f90fe922ab", 6, 12 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cab76e21-9a1a-4d82-86f0-0bb2fd0874d8", 7, 14 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5249c7ba-05e0-4ea7-be17-269bf585841f", 4, 8 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bc722bb2-251d-49da-85ce-c9fb30c51b7b", 5, 10 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2778dcee-2712-42ee-b17d-1b888a13200e", 6, 12 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ad4e945b-fcd4-422d-ab08-735605175ed5", 7, 14 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "00bd834c-55e9-4604-82e2-2694a450add0", 4, 8 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3f82c77d-2db8-4088-ae1f-7bd915820e2f", 5, 10 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4dd65601-0b2d-42ec-a7ad-89e3c9eaf664", 6, 12 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "81f3ce70-3ead-423d-a75a-91bdb0356332", 7, 14 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1bce0c55-8b2e-443b-83f8-6d1989520cdb", 4, 8 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e6584f0a-135a-48b9-9750-e8619256adea", 5, 10 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bc8cee99-aff8-43f8-a339-00b243ccd81a", 6, 12 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b8ecfa5d-7536-4493-9922-9098f68c704d", 7, 14 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1473148b-c140-46f5-87a8-5c98d8db4b55", 4, 8 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "08167201-26c2-46b7-abdf-ffac5250c31a", 5, 10 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5d6a3a48-068f-468f-a4a7-006066b77465", 6, 12 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4505aad9-f66a-4a0d-ad40-bab432077423", 7, 14 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7480c403-6488-42ee-b519-f3822f5fe4c6", 4, 8 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d7de968a-8e67-43a6-bc8e-89bf6bcfb54d", 5, 10 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3e7d745b-9b9c-4c9f-9126-0de6d167758d", 6, 12 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d8401138-afcf-4d90-a640-94795ebcf042", 7, 14 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "91a04a10-6494-4cb0-9be5-d85faf243f27", 4, 8 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "29114663-6cb7-44ed-9aca-d5d86c854a6e", 5, 10 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "96487871-da2e-42fd-8e18-a9edf9a17fad", 6, 12 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "17e07088-2bdb-4850-a166-1575740824c6", 7, 14 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "32b61300-004f-49eb-b96f-d3d99a98bb39", 4, 8 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1eea0d05-698e-4661-bd29-2764f2d700c5", 5, 10 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d050f8d4-623e-4401-a486-224ac85a0d9e", 6, 12 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a2b4e587-7884-433c-8a20-ee99d5c929ff", 7, 14 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "04312067-cd5c-4077-92d4-70c9b7403973", 4, 8 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "36dfb36c-650a-4e06-8c08-2b1c81219e45", 5, 10 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "86aec1f5-6f55-4772-b6d5-7d893c442f3f", 6, 12 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8e7b71b3-f683-4cc6-92ce-67bec0f61578", 7, 14 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4c322ee9-a56d-4025-be10-8af891f48782", 4, 8 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a156a2d9-5508-42c9-93f8-c88944cfd9f1", 5, 10 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bff9648d-3d22-4f8c-a92b-55a1da4382cb", 6, 12 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e457f238-fcad-47dd-8a35-cbc07bd63fec", 7, 14 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "562e7673-ea9e-4ef2-8740-149af88421ce", 4, 8 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2512020c-6fc3-445e-a8ec-b34cb14c281c", 5, 10 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a40bcf3b-383e-4cdc-8e9e-e24654e74a1f", 6, 12 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ec2a754e-b17e-44f6-bb11-76f18e297b52", 7, 14 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bcd9384b-19c6-4400-b763-dce196163649", 4, 8 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "19abd72a-82f3-4ea2-a555-04d144a321cf", 5, 10 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "15f6c244-1d48-4121-8a79-2c763c9ab1fe", 6, 12 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7a698222-1433-47c2-9960-47861a40425e", 7, 14 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "111f44e4-5e65-475e-b86a-aa28390e6d5c", 4, 8 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0db466d2-c1ae-4d80-91de-d5cd9db00be9", 5, 10 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9b81e27d-32ae-4419-8cb3-930fdd6aa880", 6, 12 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f48c3aaf-d3cc-4f5e-bfbf-c2da78b315a9", 7, 14 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7fb0b05f-6fb7-4b99-8292-9d80c06c2c49", 4, 8 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "adfbdc1f-22fa-4978-b12b-b7d69820a85a", 5, 10 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0c1124f5-463c-4783-ab65-bb7669bbe808", 6, 12 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4b448d77-204d-4e6e-bd89-6cba6b6c4200", 7, 14 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "98164cb6-bcbd-4ef2-970b-90c5d195bd32", 4, 8 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3ae1032a-ee57-45a4-9717-d0e23426fcab", 5, 10 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "636e743f-6ad5-4f55-afaa-4dbe3ed21ded", 6, 12 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3e085bdc-20b3-47f1-b97a-933d7c5b940a", 7, 14 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a3cc2b8f-9499-4790-9d1f-571c2a05a456", 4, 8 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0f2d0f44-cb30-47e7-bbb5-3a1d2fe05818", 5, 10 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1e0add22-53ab-4a99-a6d3-002e17dbd27d", 6, 12 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6d365b79-ecf4-4262-9d0e-7cd335ad6ccb", 7, 14 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2c7a8fa1-94b2-4b91-8f3e-e3ffb08a0611", 4, 8 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b61b0f69-0125-4251-8562-89546d55f56c", 5, 10 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5e31614a-0ce5-4f0d-b98d-7633c95a1788", 6, 12 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "335155ec-525c-4215-9838-36436b141c9e", 7, 14 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "355c2bf4-684e-4bea-9c20-7b1240772cd0", 4, 8 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4cf94c23-0fd1-4cdb-8941-59b7d386b764", 5, 10 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5e7e7da0-1903-4d8c-9a73-561c16a802bf", 6, 12 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "12e3a88b-5005-45cf-a56a-bbe6fad6ed5e", 7, 14 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6dd69d8f-3c3b-4fdf-958f-c0688a01befe", 4, 8 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ae95887e-2d71-4634-adcf-6e77eccdd6d1", 5, 10 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8f1a03a2-2b11-49f2-aaf6-f306f1b28e73", 6, 12 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cbbc3d29-fc95-4cac-99ff-f8a57eb03f04", 7, 14 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5964a422-3b75-4f00-acff-bd62ac6f7150", 4, 8 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e75848ca-84ae-4b08-82d4-c0b0007ae1c9", 5, 10 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d6fcb720-a8e0-4f6d-96db-2f15d6355621", 6, 12 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b40c327d-4492-4ec3-aa87-2f3f422dff8e", 7, 14 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6f291d4b-4a07-426b-9071-6517e2dadc85", 4, 8 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "544f9006-7e02-4c5a-9145-0607395ac43f", 5, 10 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5d3cecbd-05ad-45c6-8c1d-43c34a7ab82c", 6, 12 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9f9859e5-bf07-4567-99db-ce548c9b73c5", 7, 14 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9935902a-9b76-4233-bfc7-79efa2cbc3d3", 4, 8 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "711d145a-3c60-4e3d-bd4a-8c0a044c1f2e", 5, 10 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e177a0ae-5fea-4afc-944a-9e72cde2d716", 6, 12 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "909de571-6c27-44cd-aaf5-4a36a520f97e", 7, 14 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "696fffcd-4ac2-4360-ad89-80ef645cbb22", 4, 8 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "47070de8-c0ec-450d-bf42-ad91a1724e62", 5, 10 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "49e5722d-2983-493d-b6cf-525b9a8079a4", 6, 12 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f9665186-e9d1-480c-9cec-9ccf20ba2bc2", 7, 14 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b9e6023d-a0f4-4aac-94a4-dbac8a54d42b", 4, 8 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e96582db-66f6-4d7b-8e32-1304109eea28", 5, 10 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "43f43056-721e-49f9-8759-392fe1944c17", 6, 12 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c173e474-770d-4403-8f54-024ae8f2d310", 7, 14 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "19027a3f-216c-4073-a3f3-2db0dfb0def6", 4, 8 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "13e0e415-fc13-4ee6-8022-a53e4ee48e00", 5, 10 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b1cd30e8-586b-4d72-8b0e-4b4a2aa71d24", 6, 12 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e8dc1688-ba9a-43ea-b3dc-5cfe7e14fbee", 7, 14 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3b71bcae-6c43-4c0d-aabe-2a5112256a09", 4, 8 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "41cf3ce6-f329-4212-bdc7-76908629d0d6", 5, 10 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a11e0aac-203f-4599-9ab3-308b2fec473b", 6, 12 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d07db393-c92e-43ee-834f-42f15b8d65e7", 7, 14 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b7ee9a05-4d6e-4c1c-92ab-9de2ffb18393", 4, 8 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c84d909a-c6e0-4da4-b3f3-818b885519a0", 5, 10 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9bf2f28d-00e1-4034-bd61-f9b128aea975", 6, 12 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "514d2913-32dd-41c6-ad66-84694ca71938", 7, 14 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d50cb412-1c06-4fed-bdb9-52f0fb4f91a6", 4, 8 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "49ff95e9-f09d-4cc3-80d8-60dad5cbbbb4", 5, 10 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a1744090-55f9-424d-98a7-f5915db26aba", 6, 12 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c2d64c21-7aff-456b-83e6-3ccd004a0427", 7, 14 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "816ef8b5-53ae-4468-ad78-b3e32db59a78", 4, 8 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0eac22df-e94f-404a-b434-24de5f677d1b", 5, 10 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7bfba43a-d083-41f5-a343-78ba306a7ece", 6, 12 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4a59c7a3-5e5f-491d-be67-ae54d4e85a71", 7, 14 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "331e7369-8e81-4ae3-8088-3ac714823645", 4, 8 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ceea4814-a9a4-4b3b-a171-08a4bbf79e4e", 5, 10 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d4fcef52-4233-4007-97a9-abb220bc55b4", 6, 12 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0ae29c61-429a-4f02-a4b6-0afe05fa21f9", 7, 14 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0265ecfe-515e-43cd-98cc-f5a0d29f2eee", 4, 8 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1593ae13-245e-4709-81a9-a3fe2e89d2e5", 5, 10 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "570e9456-a725-4474-a02b-b77205c231a0", 6, 12 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0bfe0fb9-08d8-47ae-8cba-c91c9329100c", 7, 14 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b1a94f5b-c84b-462f-9b34-bae71fb9fd8d", 4, 8 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "70a33a91-dcff-498d-a3ad-8a3ab5ef58cd", 5, 10 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "12d004fe-3f5e-44a9-bd48-c619238a7240", 6, 12 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a21e7788-6e40-4998-90bd-17ad03fca6cc", 7, 14 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fc55dc79-3d85-44ee-b08c-938e66f67226", 4, 8 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5e426165-561a-4a0f-b174-37ef181dfe89", 5, 10 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "439035d4-257a-4378-8b8e-98f5bf9080e2", 6, 12 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6437325d-1e3d-42d7-9b6f-1c12b7fd3bfa", 7, 14 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "78da0965-8486-4961-829e-19ebe40425b0", 4, 8 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d62ecb9b-2ab7-48fb-846d-094cdb3c65f7", 5, 10 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5f02b5f1-054b-410d-89e8-e447e9981fcc", 6, 12 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e96f08db-41ce-46c7-a9ad-8f59d99d201f", 7, 14 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f5c0adb9-5fd9-4e22-8d3f-8f6b33b744e1", 4, 8 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "57b7456a-15a8-4449-871d-a16d9765bbfb", 5, 10 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "73f0ee80-bffc-4118-879a-38704eed15c5", 6, 12 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e7b5551f-2ba9-4cd8-b005-17b8a4fbe6ee", 7, 14 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c67edf99-1830-45d5-a080-b9a67552b537", 4, 8 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "980f4e8e-8602-4e91-b92b-8eead180900f", 5, 10 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c454339c-a9a5-42ec-9264-e548716c0e75", 6, 12 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a31f900c-6d84-452e-b198-9f08b0062904", 7, 14 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c15c1f56-5edb-4a3f-a055-e30bcd97c651", 4, 8 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f792bdce-7682-4a69-93fb-001bc6bbbe65", 5, 10 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2355ef42-7d99-4ef6-b3fa-479ab05e8dc7", 6, 12 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1a785893-5416-4ee2-baa2-5f0140c19734", 7, 14 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0c662380-a9bd-43fa-88ba-cd3e923dc588", 4, 8 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "77905c51-8de6-4969-9b18-ed5b6307ec42", 5, 10 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8db676ff-6830-4008-a57c-3235da5a7958", 6, 12 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "093c8105-009f-4457-aec8-6e9cabd16a18", 7, 14 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b83bdf0d-eabe-4982-87a7-db1847bf18f3", 4, 8 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8739ebb2-9075-405a-8a65-f1baac9b1174", 5, 10 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cf3b2119-a9b5-4787-9a88-6841d142243a", 6, 12 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3222dcfe-e0e0-48ca-9686-13b4d7fb3812", 7, 14 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "849e6717-c3e1-4eb7-9f39-424a0bb4dd85", 4, 8 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3c95d615-a7ad-41f5-9bf1-084bb4ab6118", 5, 10 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3ae93058-5307-4abf-9ded-f4b93b7c122d", 6, 12 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1a53ea03-9728-4b0e-b54c-ceb6e7d59c41", 7, 14 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1db9d06e-0c38-46fa-b2a0-db5d6548d032", 4, 8 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9bf8f5b9-3918-40c3-a079-6d12c89e88a0", 5, 10 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ceab1fe2-0dfb-4481-9a0b-bb1991eced46", 6, 12 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a08ee059-fbca-4042-b9af-f6da82bb00d4", 7, 14 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "90db105c-aa8c-49a6-ae6a-5c34f3b60588", 4, 8 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "71f7dd4e-b562-4319-a90b-91829ff38cb2", 5, 10 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b481d2c7-357b-4654-9be1-6eaa100c4620", 6, 12 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b983a764-3d8d-4d2c-bd01-f4c3577987a9", 7, 14 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "13644454-3428-4436-97f2-0671e95f0f2e", 4, 8 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "89b50f17-bb67-4c84-87fa-2af936fd32f2", 5, 10 },
                    { "78157107-23fa-4638-bd17-38187695312c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "06751d18-4ad1-492d-918a-22a54cc04178", 6, 12 },
                    { "78157107-23fa-4638-bd17-38187695312c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "35c55240-64e0-43a5-8713-ad46c8e7c2a4", 7, 14 },
                    { "78157107-23fa-4638-bd17-38187695312c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f39cfe93-f93b-4fe7-b6d4-b0e4ce1fa33d", 4, 8 },
                    { "78157107-23fa-4638-bd17-38187695312c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a430abe6-7caa-44e9-b51b-5433a8961438", 5, 10 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "904c68e1-1864-4b15-95ee-9759faef674a", 6, 12 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a985870b-3d37-4a6c-9e1e-a76a20a244fb", 7, 14 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5c3d5248-22f3-4977-aaa8-96d5f4a34f9e", 4, 8 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dc1a48e3-01b7-483c-8366-49870e8b7249", 5, 10 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ea534d08-ef6e-46b5-9c4d-f1ac98210178", 6, 12 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f5c5886e-1553-4acb-ad75-32d08780b2cb", 7, 14 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "743d64ff-473f-4557-9e52-e0b73a19d10a", 4, 8 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "68ecdc92-bbe2-43d3-8c08-71db2b1014a7", 5, 10 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "edb3af11-3c84-4526-a602-0ea51f89188d", 6, 12 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "238e6690-e96d-4bb9-8a1e-5d860947e04c", 7, 14 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "192b6ddc-4f08-4813-ba37-ca6407fc4cb5", 4, 8 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3f752a67-d765-423e-a690-e3ac733513f0", 5, 10 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4fbe36c8-2987-4848-bfed-587e1ff4b315", 6, 12 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "49f2de30-bec5-497b-85a6-8087c88626e6", 7, 14 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9c57ef70-f46f-4925-b573-d7dc6a477333", 4, 8 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "40d15962-3790-49d6-b412-5573f664465c", 5, 10 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a21a925c-67f5-4f78-bc8a-5358867be449", 6, 12 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "41ce9bfa-d23d-42c6-be69-32b19826c60d", 7, 14 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a4fa5093-7c45-45ae-8977-2470c8690bf8", 4, 8 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a0883e6a-de16-4176-b25f-c00b76743959", 5, 10 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "10c27935-6b3c-4fb9-b040-bd0a58737de4", 6, 12 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "06b303e5-3639-41fd-ace4-ee24a8946e9f", 7, 14 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dcb79be4-2655-4768-a61d-a90ff48bc8f2", 4, 8 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d7e942b2-3573-46a1-a5f0-54675bf02f94", 5, 10 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d72eff4a-b7f5-4766-a784-db329c38e25e", 6, 12 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5dba3284-57c0-4e7b-9b3c-38f2aaad37e3", 7, 14 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e98e6c83-aedf-4079-8b17-95760e0eb903", 4, 8 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "93abef38-f16e-4fae-bbcd-734e050cba68", 5, 10 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cf11f60d-0df9-4c22-81b0-d96b1de9d08c", 6, 12 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c2f121c9-3202-4877-8050-0dbbcc15f4a4", 7, 14 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "07f8489a-7bc3-45e7-b556-e2b6a0256585", 4, 8 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "88abf448-a00d-4e5b-8161-dfc38c2dca95", 5, 10 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "90145d4f-9551-41eb-a5fa-2c788884242b", 6, 12 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "54bed293-564c-4fee-bd5e-72b43e65df89", 7, 14 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d7b18334-97c8-4af3-8ed3-1dd6d2ebd646", 4, 8 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cb3ce3e4-66e0-4d34-b733-d8bd3d70a8c2", 5, 10 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4b0a6b1e-9af7-42f9-afae-7d508647e798", 6, 12 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7e65ca37-bc88-4aa1-b4aa-a6324d778f0a", 7, 14 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7fb97eb4-ffdb-455f-8f15-2978d8f738db", 4, 8 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "312da4c8-e783-49f9-9fb4-202586f9b2f8", 5, 10 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "444bb5c6-ca23-4d4d-bae5-2cebc4b2833e", 6, 12 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "be16101c-0649-425c-8ff7-01b4c2555243", 7, 14 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dac76bf5-8d2a-4a6f-9500-80850744d123", 4, 8 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "01fa2a7c-a2ec-4cd5-a994-bda7cc50b94d", 5, 10 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f32e4a17-25d1-43ce-8788-eba93cd01cf7", 6, 12 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e189d9e5-46ca-4cc6-aad1-3e01f4b61e1b", 7, 14 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1312029d-f705-4e48-ae71-b155e41f8b28", 4, 8 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4c8d1e99-ca11-4396-af5a-4d1054a432ea", 5, 10 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "269443c8-411e-4f08-8465-34f6c327b4b6", 6, 12 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "86145ddc-e214-4915-9fe6-7aac4739ec27", 7, 14 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e388be55-bd6a-400c-bac9-6f61a46d6a0e", 4, 8 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fe7fb4ee-edbc-4029-96f2-16137357f523", 5, 10 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bf6be5e0-6673-4bc5-bb04-e60baa07eeb0", 6, 12 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "643265c7-3db4-4e47-8798-dcf23a3ad7a1", 7, 14 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "12288fe5-1266-4405-b189-8680a1a49d01", 4, 8 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b5732f0c-e0e8-452e-aac5-7d7dfb6d7f3c", 5, 10 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "88bccbea-9afc-408e-b2f7-21575ba21bb4", 6, 12 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f9d8e7f9-a3dd-4f02-9253-c581b49148c2", 7, 14 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7e2af82a-a514-4d4e-bd11-7dbead81065f", 4, 8 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0ba92eba-14cf-42f6-b325-1725f0d1571a", 5, 10 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "adbbb66c-f2ca-4d2a-a627-0473a2942201", 6, 12 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d218e3e0-f6c6-4df1-9777-2fb750701335", 7, 14 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8a23716c-b0fc-4caa-88b2-cbed1d9cedc2", 4, 8 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "31638cd4-803c-4383-8776-dc97c091cc7c", 5, 10 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "11a0a7fe-b995-4d1d-84ec-8e7ab347afc6", 6, 12 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f9a01a11-ed21-435c-a798-f5d2fe89a3d9", 7, 14 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3630f0f3-22d9-4c92-b09e-2bb8630e66ec", 4, 8 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6b64092f-c495-4868-9f39-b86208ccd6f4", 5, 10 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "923c4ae5-3d9c-4e30-8605-e932831c523e", 6, 12 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "663ca07c-8ce9-45ab-b2fa-fe60beeefc5e", 7, 14 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "195de98a-54ac-41b7-802d-c1f7a2cebde7", 4, 8 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a7ce60c8-6698-4ac1-b75c-b6d55c52efb4", 5, 10 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d39de29e-cccc-4a3f-91e3-81eb86879ac9", 6, 12 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5cfd69f1-307a-4467-8f2f-3c10e5b4ec4f", 7, 14 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1008f13d-56e0-453f-bc69-183aa6c122b1", 4, 8 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ed270f09-13b0-4c89-a093-68e833c9d7c3", 5, 10 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eacd39c5-3195-48d8-aff3-6ada9b36df94", 6, 12 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "96ec6a0c-ca15-4eee-8df1-5b54b4276315", 7, 14 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bca6d6ee-abc0-403f-b54c-1f19d55dbd1b", 4, 8 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f0cbe102-7476-4a62-af20-b6a8047706ed", 5, 10 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "42863ab9-d243-40e7-97bf-64eb494a7b29", 6, 12 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6acdb5e0-5010-4bc0-ba61-1bbc08f7317e", 7, 14 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9399892c-d2be-4d9e-a0c0-ac2e05325083", 4, 8 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "caf80be7-445c-42f1-bf85-dd437482ed7e", 5, 10 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0629140b-d0f8-4f35-aa4f-6bbf771a8cb6", 6, 12 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3714a19b-ee5a-44b8-a0c0-ad19dd2069e6", 7, 14 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a89bafd3-6ccf-433e-88d5-737b99d6d5d6", 4, 8 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d546916e-dfa7-43a7-9fcd-b0c4a1bf558d", 5, 10 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1576ab98-8f41-4bb6-a213-adaef5bf59c3", 6, 12 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5a7486e2-7215-4db0-b89c-39cb34873c56", 7, 14 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1528ef57-745a-4a45-b700-cd1070d1e74c", 4, 8 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cde95a1e-db94-4a23-953f-8e0645255bfd", 5, 10 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6327704c-7921-4c14-92ab-e6d8ccac8803", 6, 12 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0b5cf2d3-eeda-42b7-bcac-ccd7cc60a9d6", 7, 14 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bde96f07-c869-4aed-a63e-020ca137443d", 4, 8 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ae5647af-18cd-4956-88a1-4987330308f1", 5, 10 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "00e5bea0-2043-493e-8be7-602dcd28bcdb", 6, 12 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bf19d908-b9a6-49a8-b924-f11ef98c07aa", 7, 14 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "711b0044-619d-4da0-a87a-24dc5da98fda", 4, 8 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "01c3a218-97b1-4769-b934-0485514d9e36", 5, 10 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9fc6dc98-0252-4a48-8f37-b02ed80ac442", 6, 12 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4ab8e879-040c-419f-9b3a-58ee9111a3e2", 7, 14 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a3108a5b-3b9c-40b9-a6c7-9cea83238309", 4, 8 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "14cfafd6-14d6-4aad-a8fb-d39df71e8d1a", 5, 10 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bc2dde5d-fc8b-4f35-9c8f-b7fcd7ad3db9", 6, 12 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d3074022-b3b6-45e6-ba20-395c87ff5f37", 7, 14 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d1ee87da-3e15-47a7-8f09-e1c83965f8fa", 4, 8 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "34cebd8a-b1f5-41bc-97fc-a3e4abb1b962", 5, 10 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "29a1d50f-dd54-4746-88c2-a2a9be1fee41", 6, 12 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1e71d999-22f3-454b-b1c3-c827528092d7", 7, 14 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "191befbe-ac3a-495b-b702-ce393531afc9", 4, 8 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cce41a99-0547-4f0b-8f11-a5552b4d7e69", 5, 10 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eb4a1293-b7ee-4615-aeb7-348744e6bcfd", 6, 12 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7a4b22e1-3c89-4f11-99b0-f8b3460541ba", 7, 14 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2335de34-a20c-4c5f-be37-731f5885e6f6", 4, 8 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "36c87014-ceb6-4e00-a932-1ecfdf96152b", 5, 10 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1df983ff-d9ae-491e-b783-efd3e8aafc58", 6, 12 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a29e43da-01ad-4f8a-9fa1-9696d5ad1270", 7, 14 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f4962ece-b37e-4261-be23-5611841407f8", 4, 8 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6758d5c1-524f-479b-9de8-4e1dce94b04c", 5, 10 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "030b4646-f5e7-4a4c-a54b-6edadfdbc067", 6, 12 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "59bcf880-878c-4b98-87e3-0aae1088fd27", 7, 14 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "238eaad6-2e91-45c7-bad2-a692e73d16c5", 4, 8 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "177ccceb-819a-493c-a273-1db20162f127", 5, 10 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4395d62f-f284-4da0-a01b-f7e65cc7ce83", 6, 12 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "607198c2-4199-4a47-8b0b-e9d5c9eae4e3", 7, 14 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "de1d608c-d200-4109-b123-c34b36c20f4f", 4, 8 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6f2cac4a-47dc-4ab1-bfb5-9a986943177a", 5, 10 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ac4b399c-c950-47c1-a50e-7b4a520d3906", 6, 12 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0ae07931-e997-4997-bdea-36875fe178fe", 7, 14 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "af0e3eed-fbbb-465b-b007-45989eb8f9d1", 4, 8 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "59163476-88d6-441f-b143-e97968e5660a", 5, 10 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8a8aa58a-5fd4-47d4-8857-d0a940f22dbd", 6, 12 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1098c8ec-6af3-4aa7-a518-067e5657bbf1", 7, 14 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9611e1b8-ae5e-4d19-9965-51d2347149d5", 4, 8 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d2d763d2-c586-423f-ab28-12c9c3888a55", 5, 10 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0c1362a5-4129-4f05-942b-a5c96229528d", 6, 12 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c7bf4507-63d8-48f6-91df-060cfd382e79", 7, 14 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "18c3f428-8ce2-4a8a-846b-43d645cd72a5", 4, 8 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "03a62501-182b-41c8-8719-2a579dd62bb7", 5, 10 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "05f41973-3b4a-4e00-83d2-8951d52a84e8", 6, 12 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bc289601-d693-474a-99ad-a71257631ba7", 7, 14 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ccb32d3a-da4e-4018-b18e-a1b9344566d4", 4, 8 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "025bf0ec-69c9-431a-80d1-1897b9d0cc64", 5, 10 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8cdeb931-4cdc-4877-9388-66d889ce52fb", 6, 12 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "00c2ada1-98de-4d4a-a26e-a1de9454407f", 7, 14 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "86f6c7db-c696-4242-8edb-aebf5d488a85", 4, 8 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d830d3e2-8117-4e9e-aa9b-cc78bdaebd4e", 5, 10 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8eabf97d-9ef9-40b1-8f1d-2b124f6d34c5", 6, 12 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "472971b3-b845-4a50-a634-be78a0973bbf", 7, 14 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "741d9ea8-aa91-474a-980b-415fb433d987", 4, 8 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "582f8d3d-82b6-4896-b46a-db741a561d84", 5, 10 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "68931b47-e89f-40fe-8093-241adde639bb", 6, 12 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2bb65930-359f-45bc-b240-e36f293ae059", 7, 14 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fedc3166-78d3-4c1a-9bba-3d52116522cd", 4, 8 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3faa1413-ba10-48c3-aebb-0ff31904163a", 5, 10 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4466e3f5-dfed-4851-b0da-057104381ef6", 6, 12 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f185a197-b606-4141-b550-6b7deb81ce07", 7, 14 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "49b0b9fd-4c83-47b8-94fd-fe34cdef6f45", 4, 8 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b19a63c4-1e16-4de0-8f7c-0ee353c97068", 5, 10 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "20511c05-e2fa-4997-84ef-68fcb5093c2a", 6, 12 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0fe93cbe-0bd2-4c32-bea4-32ec942b76c0", 7, 14 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "da54fd18-eb9c-4c11-ba39-66847cf76f1a", 4, 8 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5589c0f7-1fcc-4c63-b829-dfd223b6f910", 5, 10 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ec3d08f9-8753-4b85-92a1-4cf7444661e8", 6, 12 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7d77c394-8357-4e78-844c-cc65d5148d33", 7, 14 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ea1dc4b1-c440-45e5-b5c2-e95dbd634b0e", 4, 8 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "08b58c5d-b944-44d7-a76d-81fc03c34b77", 5, 10 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2c088869-aadd-4be8-a98e-0e13b1555447", 6, 12 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "06bea641-4924-4402-8aec-25b536d15f27", 7, 14 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e5121b94-7541-4c0a-b140-d6c237a1745e", 4, 8 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "489eae49-0d7b-4500-ac18-d731c8a70bad", 5, 10 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1abe55b5-d633-4a8d-8f4a-10d5347b452e", 6, 12 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dc355a32-0803-4249-95b8-392f93210aaf", 7, 14 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "28b421ec-0189-4612-81c8-fac2b17fbd46", 4, 8 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5c77a960-3972-4a12-b524-1f3f19e6ee4d", 5, 10 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1b46daf1-5d22-49c6-9c9c-20641695b2a3", 6, 12 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4e5e8f22-e328-4bb6-95bb-58627a3ec668", 7, 14 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f65a8389-770c-47a0-9530-3b0147958001", 4, 8 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "47418fbb-2d07-4ef1-8246-c185e915b917", 5, 10 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "717506c2-4cbb-47b0-8d1f-aca37e3371b2", 6, 12 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "187c756c-7e67-4976-9c38-32c2149bd513", 7, 14 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "856a6a4f-1411-4609-b6fc-2eb472566fc0", 4, 8 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9857db63-0a38-43fe-be57-db9cbbb5250a", 5, 10 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b2ec82fd-e63f-4dec-855c-f9104db0044e", 6, 12 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "57e1e237-2465-4460-ab0f-accd304f3bbc", 7, 14 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "837f6553-749e-46af-a171-73024fc6a3ba", 4, 8 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a3860e63-9817-470a-abb9-2ab163ef05bd", 5, 10 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "de3600fe-247d-46d9-8b40-84688ac4839d", 6, 12 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2de3dadc-1c71-4dd3-ba4b-dcd215623947", 7, 14 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0e724e15-7b60-4580-b21d-e8d3f545c26c", 4, 8 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "251e2e06-3631-42b7-be14-ed0d75ce7ce8", 5, 10 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "642f4726-7353-4448-9e30-a5117806804c", 6, 12 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1b9e9b6d-ea65-479c-b2cc-f0ed9e1dc113", 7, 14 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fc63d816-5959-4ca9-b0d4-8aab56dd0bb4", 4, 8 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2960ea2c-eefd-4f9f-901b-e832992e126e", 5, 10 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b467ca37-5ace-4281-adb5-4b3c685f8591", 6, 12 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a7b269f8-ab17-4e22-b48a-273c4aadb2f2", 7, 14 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "83d6674e-fbc3-4ef0-b3f0-ae47992477a5", 4, 8 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e54e1cae-dfa8-46a5-8fb0-66757a929f1e", 5, 10 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "30f131b2-8e90-4eb5-86ff-be0ad3d3cfb0", 6, 12 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5c06677d-e7c6-46c5-83c2-3ae392e9f473", 7, 14 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9d6fd581-1550-4187-80f9-d456ede3f8e0", 4, 8 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ac8f4aab-2ae7-4df0-ad36-8e999ca7d462", 5, 10 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a1d5622b-cd4a-4602-b56f-d092e8721923", 6, 12 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2615e854-6f9a-48ed-b518-b5c1facb4509", 7, 14 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b9816093-94e9-4be3-9fb0-2200cd784d89", 4, 8 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a5bcc78a-3deb-4837-9aee-176887061d8c", 5, 10 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5bc1133f-14d5-49aa-974a-92b0ef227177", 6, 12 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "01482c6b-f438-4d9e-9500-3d158f939617", 7, 14 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cae754e6-0862-4b83-a9fe-fdeb216ba09b", 4, 8 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "48960842-67b8-4dd0-9e43-74b49756023d", 5, 10 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c9cbf96b-33ec-4ca2-88c4-f383cd6a1f05", 6, 12 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d7989c39-92ef-43fe-b7f8-f3cbf09d72b6", 7, 14 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d1add6f4-79fe-44cd-9093-09b1fb7e4def", 4, 8 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9599d3da-943b-493a-9ffb-981bcebcd2b3", 5, 10 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aebe9f3f-0aeb-442c-b1fb-abe97cf3de90", 6, 12 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f4d25455-9fe0-4977-a8f7-0eae534fd77b", 7, 14 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f595dd80-8afc-4505-944d-e0c5328fa2ac", 4, 8 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b497de0e-c124-4c8d-8874-ae1749379a4e", 5, 10 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6a8f54d0-be98-4c5a-8129-e68013c13287", 6, 12 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b3c17b30-f9a8-4aab-ae20-c1b4663d70fa", 7, 14 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a611ecf8-a742-46d1-9e57-bd9ab27bc116", 4, 8 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3af2f739-ada3-499e-b2aa-acba26b49744", 5, 10 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2dcd3687-6c7f-485d-86b5-f68c58c853d0", 6, 12 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "68fe4ae1-7674-48e7-a24c-d80ea074103f", 7, 14 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d4996d78-2d68-4364-b01c-482b09ec129b", 4, 8 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ca695087-a1de-485f-be75-461d7e5316ee", 5, 10 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1c6e6a8c-32d4-4dbe-9a25-3370fae99bb0", 6, 12 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "687983d8-bbdb-41b3-a8c8-11011b3e77a2", 7, 14 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "70436a91-2fce-434c-9f82-490f87d41e7b", 4, 8 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "196948bf-c1e8-46da-8214-5c9dcfe3d795", 5, 10 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d42b9cc3-e63c-4e0e-bf0b-f0f82cff878a", 6, 12 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "47f994e6-e438-4b07-88d6-8a4e3610bfea", 7, 14 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c09f72e1-47d4-45d2-b274-f12f59248a7d", 4, 8 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "edbcde66-6ec0-4e8e-8c1e-5e36785768fa", 5, 10 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c7138f52-9756-4af7-b824-5a05c0f3c6db", 6, 12 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6bad814c-7940-4815-847e-bd342e13a22f", 7, 14 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "88871321-9a0f-478e-b9bd-ad1b32534945", 4, 8 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "956b37da-e2d0-4999-821c-85f556d8738c", 5, 10 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a72b76fe-3f41-4942-9b43-3ee65110c5b4", 6, 12 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "175f3ed2-dad4-47d3-8d95-a745e1073400", 7, 14 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fcea3f71-ce25-459d-ac9e-49901ca0a1ba", 4, 8 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "79c42be7-19b2-497d-8bd3-fde3db940535", 5, 10 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "640b54f2-960a-49fe-94af-39032359cf6c", 6, 12 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c6904611-e23b-43b0-9389-2084fabe4998", 7, 14 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c077e39e-b46e-48ea-912f-513a1b0ee445", 4, 8 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "770e3b50-6a5e-4835-a14c-747e0bc2519e", 5, 10 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "95cdbcd0-33cc-42fc-b7fe-c7150f713f96", 6, 12 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b1c6323f-9b66-4fd8-a7a3-a36788fbfd1b", 7, 14 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3cb36aba-02ea-439a-8e6e-79785f90c9ca", 4, 8 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c0e886f2-804e-4841-9d9f-885dcb86c85d", 5, 10 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cd2b0671-503e-4887-b137-3922db4f8bcf", 6, 12 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6385f060-a78f-4452-93fa-eabb25d3f360", 7, 14 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5f1cf49e-f7e2-485b-9f02-af1e4b22e8d2", 4, 8 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "38e4c3b9-b907-412a-80e5-ebccb66f6684", 5, 10 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7501f4ae-4aae-4576-9550-f248476575b2", 6, 12 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "765f88f1-532e-4805-9d2e-a9791e037681", 7, 14 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "aa33fdce-04ce-4467-b6ea-c911399b8116", 4, 8 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6081dcc7-34b7-4da6-af4e-9875d9926d89", 5, 10 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e3332537-1019-4421-b4d6-71e34a0ea60d", 6, 12 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "949538f4-0910-4ed9-a07b-2e29a2b448ba", 7, 14 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b1683140-fa96-4321-a01c-308a183daadf", 4, 8 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7448a7b1-84d9-4c84-9a60-ae9a470a4b39", 5, 10 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3e394acc-3c3f-4a6c-88be-f9ab3e5327bc", 6, 12 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "03573052-f6f7-48ca-bee9-9e79f95dc549", 7, 14 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "65054dd8-e618-4e5b-8a17-69cdafb134a4", 4, 8 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "25d1423e-5166-40fc-9a51-d7708195662f", 5, 10 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cc7d354f-e19d-45f7-a574-cbceb32c91aa", 6, 12 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d1baf1a7-67ef-4a9e-a1d2-5aab2d5d8c2c", 7, 14 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b8a1a554-e1f3-4b3c-ae16-5d07c33b84da", 4, 8 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1de27428-34ae-4579-839d-aa9dac008cb4", 5, 10 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6be149c0-4a51-45fa-b73f-e3bee352b544", 6, 12 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d827ce81-ce9d-4569-9379-6b60cdab5b44", 7, 14 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "eb95839b-0da9-4ce9-8951-fcf68d135d78", 4, 8 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2a673245-e0b4-458b-91ce-d8cfd39b8091", 5, 10 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d0898ffa-dead-424c-a628-5002d65fbf40", 6, 12 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9b0f64c4-4696-4dcf-aea4-65c36af8434b", 7, 14 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "307a0607-a806-49d4-8c9a-b14cb209a15a", 4, 8 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c64d585b-ef6b-4b11-b41f-a1768387cc04", 5, 10 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c73fcdd8-72ad-4bc4-b714-a3a84ae6d33a", 6, 12 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6357243e-9751-4e2c-9199-f0b08daa8499", 7, 14 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "95f537fc-04de-459b-9c0c-bbf1c834a9ab", 4, 8 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d19de6e1-c85f-4bb0-bdae-95efa5b0d30a", 5, 10 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "01f70355-9e64-49ee-b1ad-1b003896205d", 6, 12 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b9a9bc17-4938-4e12-9be9-9bc440fcdeed", 7, 14 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bc92c7cd-8d3b-44bc-9c0a-c6959c9ca15b", 4, 8 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2aea9f1c-0c41-42b9-b072-f7e490269ade", 5, 10 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a7311455-9cd4-4d90-8892-781bde12fb90", 6, 12 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d57285cd-d8d6-47a8-9b22-20613b40cda0", 7, 14 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8abc5124-dde8-4eed-92b4-2b0fcd842f48", 4, 8 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f8edbed3-4dc9-48ab-932d-2ec8da155037", 5, 10 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b4f0980e-bad3-46e3-978f-1fef81fc748b", 6, 12 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c46128a6-0f73-4dc0-9935-b19d2207af9a", 7, 14 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "99501e8d-afe6-432f-bfe2-c844dfa13cec", 4, 8 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6e108924-2b07-4ca3-92d7-eeaf6dadf007", 5, 10 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3b0303be-64c0-4e2c-a0aa-93888f2b1d68", 6, 12 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1147fd6b-f106-4ef8-942b-b95aaa8570cd", 7, 14 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4e2c77fa-c78e-4957-a56d-3b0dda973b05", 4, 8 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ec4fe848-4e85-4d71-9898-6e3c72104077", 5, 10 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "410032f8-aa5b-448c-ab68-40ff98567a46", 6, 12 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d2995fcb-da57-4af9-8a56-2629ede24aed", 7, 14 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5488409b-3160-4af3-8166-1ca61afc0b6e", 4, 8 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "da2e4f9c-c795-4cea-8bbb-156172c65018", 5, 10 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "01384ccb-a754-47ca-9869-ed142e478b7a", 6, 12 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "98d329fe-4e69-48bf-8cb8-9f1ae5eda0ef", 7, 14 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "34ee05fc-22c9-4233-8b0c-59cf3091a2ee", 4, 8 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f2c992c4-56de-4c87-abc9-c0e8c9cd11ad", 5, 10 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8d4ccea6-ee90-400b-8ff4-8e3dfa1326c8", 6, 12 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6de73dee-edd6-4554-b3c8-011e2ba70dab", 7, 14 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6d7d7ed9-e5a1-4ee1-a11d-f656d92380a3", 4, 8 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5659d0e7-fd74-4192-919c-9c5c705186f3", 5, 10 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "db7c8573-102d-4e99-a8b7-b4ab56882cdc", 6, 12 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ba7a87bd-8406-430c-b51e-5c948cd0cac1", 7, 14 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "58fbb9d9-5a01-4e5e-af7b-e9f485ddd772", 4, 8 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "14baa888-359a-4c38-9c6a-cd88f6f77d82", 5, 10 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8127abc8-ca36-40b7-8e71-9444559de744", 6, 12 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b3f18121-7902-43e7-9fc7-c70a21d18e6d", 7, 14 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "786bc597-2bdd-427c-83d9-02be5b12f87f", 4, 8 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e55e75a7-a5a8-498a-b5d2-807932c1a4ed", 5, 10 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d7e5814a-eaae-4018-8dfc-5ea83525c4fc", 6, 12 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d8ff7ac2-c6da-47aa-af2b-d2da8cd34d4e", 7, 14 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "65c0805a-583f-4aab-85dd-73c798a6e91f", 4, 8 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5e79c9bb-2b25-4b10-89ac-54a5d7eb5ae5", 5, 10 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "265ff8e3-6ba7-4742-bb40-0683c0b3a200", 6, 12 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f0829488-c24b-43a5-9614-03c7050b0382", 7, 14 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "06f4e68d-aa6c-4e4f-aec1-3970aac1d417", 4, 8 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "504e066b-9b4b-4a3b-8f1a-39ca694355f5", 5, 10 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "171a1474-417a-4ea8-ad0e-d504b0235e24", 6, 12 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "26bb5c8f-acc3-4b28-aaa4-e01308e9ba4e", 7, 14 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e79f3f74-8d7f-4051-9770-b13b0125c30b", 4, 8 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8e2e5fcb-dd1f-4bb3-a32e-25b61bb92591", 5, 10 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6b8374cd-8ffe-413c-aa82-c9afb1a43f3f", 6, 12 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7209e710-047f-449f-be55-a05fa463032d", 7, 14 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "24380689-7389-4920-b4bc-6e4b0df1490c", 4, 8 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ceea05c8-9d85-4e04-80d4-5ef6adf72b5e", 5, 10 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0eb91077-f999-4561-9c54-c97e637f6f10", 6, 12 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e4513c8a-f38c-4d75-94fc-472b5fa21b3f", 7, 14 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "916978e7-9500-4af0-8f3f-bddcea52bc7d", 4, 8 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b042477e-15b3-4519-9afa-fb31f52d70ef", 5, 10 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b4fa3486-a9ba-4dde-b840-f9b0158d8858", 6, 12 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cdcc679a-380e-4ced-9a37-f8713f683523", 7, 14 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fef3d7bf-9f31-473e-bffe-f690a3f575ff", 4, 8 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "175ba49b-958e-4fbd-92eb-6f430c84c246", 5, 10 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "62a5e8c2-197a-4f42-b79f-3f04c6184c98", 6, 12 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8d359b9a-13d0-4046-8f24-59be8413d66d", 7, 14 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5e48a6d7-5e19-47fb-bfaa-133b4fd47c92", 4, 8 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dc7c8159-9154-4500-974b-73e4d5013802", 5, 10 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bb4620f0-bc3e-4d93-8e07-2b61efdb0daa", 6, 12 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "951c1ffe-423a-4e31-8b8c-2dc915c778a6", 7, 14 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "86868b4a-383d-4c9f-b2d2-4a7d6c942201", 4, 8 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e59267fc-2cd8-48c2-91ae-7a9c18b3a2a4", 5, 10 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9186cc77-a86e-405f-9e26-ae76469154f2", 6, 12 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d6436986-848b-4531-a742-2817b215ae25", 7, 14 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "982bc342-6cdd-480d-916c-1ecf1eee9fe3", 4, 8 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "413a9bf7-d3bf-4e96-a597-1c8a0c793f19", 5, 10 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "29cfcf76-9257-4e7e-819c-1282423cc5ee", 6, 12 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f2ba67c7-34bf-403c-b057-7a3433a1d6c5", 7, 14 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6cc404c8-3301-4533-9698-d9423ccc28c0", 4, 8 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "30323d90-cd39-4413-a85c-645f4ec22f2d", 5, 10 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c6187902-f308-42fa-822c-df12028d09af", 6, 12 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6830adb8-4715-4b1c-ad63-a12ec596da41", 7, 14 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fe6f93b1-4331-4b8c-8325-ec61a577d0d2", 4, 8 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3e2a0c5f-9dcc-431e-b8bb-d20e81a26754", 5, 10 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dd97a90b-cdc2-4fb6-96fb-0a124cfb4518", 6, 12 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a517f4e1-e3a5-441f-a8e7-542447d02290", 7, 14 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c13bf042-1bef-44ad-a4e2-36f071403ed6", 4, 8 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6dee3d78-d485-4373-b4ce-2dc85f5cd1ca", 5, 10 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b82029cd-93f1-4d1f-8ba2-e56d126d2199", 6, 12 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "57c9d225-ac5b-46ce-8fda-f8a3376e4eeb", 7, 14 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bff64f75-7ee5-4aba-918d-1a83c71b6d8f", 4, 8 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "714fa38d-45a7-4c07-9016-fc27907e1704", 5, 10 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a8fae454-7521-40e0-aac5-204f48a080c8", 6, 12 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7372e5b2-6711-4b4d-a871-9a09a088fb80", 7, 14 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dad68687-eb94-4866-b128-f53f7ca5308c", 4, 8 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "49d3670d-96cc-4810-98d7-4c3734025366", 5, 10 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "47d5c560-0132-41a6-9faf-a5d8daaa5c58", 6, 12 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "055bfb36-8e6b-42f7-bb1e-0da045acaa52", 7, 14 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "21c2edbe-efcb-4611-8799-bf3f84cdb9e3", 4, 8 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c2fa6a39-d5f3-4028-8abc-f681cdb21d08", 5, 10 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2f701760-bcbb-4837-90e8-cf37610e5dd9", 6, 12 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "db95664a-8155-4a34-9c12-d980c66acbd2", 7, 14 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8069328b-c9a4-48c3-8195-b8ad6feb5704", 4, 8 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "41e11aac-c110-4b69-9d82-4f553c1ee7fd", 5, 10 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2ded98ea-52e3-4e91-b459-c05304bfa10b", 6, 12 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "05ed6e0e-d20f-4fb2-b317-e2c375312f11", 7, 14 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "509f7c05-a96a-4f96-a8a1-92296cef5e33", 4, 8 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2a98f227-f4da-4799-8b1f-6e549973d8e8", 5, 10 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "72ea9cbc-2a4d-4f6d-963b-c9c506e36af2", 6, 12 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8ce1bba9-c626-4869-a3d4-44a7ed04ed3c", 7, 14 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "69ce750f-c77e-4fa0-b6bb-c258198d267b", 4, 8 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2d03aea1-9f4b-41b1-8458-13c372fe64d9", 5, 10 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0fc7cdae-0e92-45c7-91d3-78d231f6828a", 6, 12 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b5072c48-0f7d-47a9-9fa4-356b0fc98775", 7, 14 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "07c66110-6e67-4055-b5e8-9ee127fa145b", 4, 8 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "502f0ecc-058c-4afb-beaa-c8c47677bbec", 5, 10 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9a7d4c23-8514-4bec-846b-aba2ec604cac", 6, 12 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6f83481c-f2b4-4a58-a490-ba902ba3bac0", 7, 14 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0a36cddd-5935-464e-86fc-6c74187a23e0", 4, 8 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e26e27af-67a1-4edf-a7a7-eb868a55a085", 5, 10 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "daa85a46-0852-466f-a134-1f5ac1459db6", 6, 12 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7ef7f85f-a8e0-466b-9628-6ddbec982be2", 7, 14 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "454273cf-fd6a-43b1-aba1-637e18bfd510", 4, 8 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "756d65dd-ff68-49c3-bfb7-72f5e4b001f2", 5, 10 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0ea5e492-2eb1-4c86-847a-9d6828ebd46f", 6, 12 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "55d53651-74cb-40f2-bcc8-af77f97d536c", 7, 14 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b2bf4815-1857-4526-ae0f-212f36229753", 4, 8 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f444843b-a888-4520-9078-1e24b2dbf460", 5, 10 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0321c15c-fb5b-46e8-9924-25da5fb268eb", 6, 12 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "21a62934-76da-4fba-a20b-a8faac2f21d2", 7, 14 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a1e1013d-3224-40b8-a865-640cdef39f2c", 4, 8 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "998c5dea-4172-46a6-8172-f11b7e3838cb", 5, 10 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6c1851b5-1737-4474-92e2-57a3c236adef", 6, 12 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d8f46261-f9ab-4d15-8a36-039287c26a75", 7, 14 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "51817325-5816-4c6d-a448-4d6e8808e927", 4, 8 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f5d9c5c4-480c-4001-a9c5-e49f7cf24271", 5, 10 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ed3306fc-edf8-4905-a37c-a8baa88687ca", 6, 12 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b2af781c-6f33-460b-9cae-27211a80180d", 7, 14 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "382edb3d-843b-4b5d-b960-7cec1ada6d31", 4, 8 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7a316374-97bf-4778-911d-5e8edfec4132", 5, 10 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "62f96dcc-16dc-4ebf-a2a7-93f860140677", 6, 12 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f00f2815-2f9a-4512-8f95-604c2743ed5b", 7, 14 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2cbae691-e21c-4d2e-b00a-3d82059dd5fa", 4, 8 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3a6531f3-668d-401e-a356-26b76999e231", 5, 10 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "77806450-657d-45db-a812-14980825a324", 6, 12 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c952744f-1bb1-41b8-a843-52e18573b06f", 7, 14 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "411b9dc1-f9ac-4153-8577-16b96edd8201", 4, 8 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d17133da-d1e0-4839-a1e4-3a002351bf1a", 5, 10 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1d01fb5a-7574-4115-99b4-afc889829721", 6, 12 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c6432ddc-3915-46e7-91ae-e6f93e5e4d8e", 7, 14 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a06e940e-ac44-4f7d-9a50-237dff4570ab", 4, 8 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ffe53d25-fd65-4eb1-8bf2-bb661de61737", 5, 10 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5076f60f-922e-4d62-a586-b646f80eb511", 6, 12 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2036d478-b0ab-42e2-ae64-3ccf379c53ff", 7, 14 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "36111ae1-c69e-4043-a110-e294b223168a", 4, 8 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9e1c5d4e-5692-4507-99ca-eeea655a2dbd", 5, 10 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d8c67007-3db0-492a-8d88-b980b9a4d8bf", 6, 12 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "af8d23e2-6bc2-494a-9f58-53ea9f49afd3", 7, 14 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7281bce9-deb0-4afb-8b0f-a6ddc598c517", 4, 8 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b2a28adc-a0dd-4b57-898e-def5c08e03b5", 5, 10 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "29fc686b-7ab8-49fc-ad59-1a15f46a8146", 6, 12 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "936af0f9-be27-4d99-be08-a4bff4848654", 7, 14 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "29199166-3d7a-4547-8087-bea7f2adf286", 4, 8 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "441933a0-3782-452d-aee3-e50dcab8755a", 5, 10 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "00af2ff5-a321-4a8f-a0c2-a038220be3be", 6, 12 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d8c9b400-7e85-4319-a167-1ce63f16be5c", 7, 14 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "52ead4d8-9839-4d11-b714-9cde405e2ff1", 4, 8 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bd8643f5-7fdd-4acd-9a52-2ce15b06c10a", 5, 10 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a36e82e3-b243-4e43-8e5d-f239e94f8ccc", 6, 12 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1bea295c-daab-459a-afdc-4b17e50d3ca7", 7, 14 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ddfe8393-36d2-48fb-ab09-5f1b46e962c0", 4, 8 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7acf7b90-70b5-4ad5-bf67-445444961bcb", 5, 10 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "71c0f5da-0d77-4172-be0b-3f66c6a9c077", 6, 12 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8f66b19d-de71-4ec9-9eda-7258869a2e01", 7, 14 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7f85d611-b41d-4d29-9a6a-6473add94049", 4, 8 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4dc7e9dd-e4c5-4467-97b0-1afc5e15aac0", 5, 10 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0529c0ea-3396-480e-b313-663012321a3b", 6, 12 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7063e107-2073-435e-a1ff-2941f785fc50", 7, 14 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4e52412b-709b-4dc4-8160-03ae493e8330", 4, 8 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aa0e0b61-24cd-4dad-bbe7-e6af9426a083", 5, 10 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "98bf4022-ca58-48fa-ac40-7a5bfef7eff2", 6, 12 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9501ef75-6392-4d41-b1ca-785590f60b78", 7, 14 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3e50d465-744f-4145-b062-c0f4ebb8fd0a", 4, 8 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "43b61c82-fe7b-4a34-bac9-fa58712e129d", 5, 10 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b7e4a5d1-c1f0-4b27-8bb8-8a6fa4d3984e", 6, 12 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bc454945-c452-4872-822a-bdefd5893d57", 7, 14 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "172a365d-673c-4e82-bde2-7d6bbbb57979", 4, 8 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bfa981f0-2071-4199-b1b7-18a7b1f16074", 5, 10 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a05aa3fb-d9e7-42d5-b9c9-0f96fe506936", 6, 12 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "306d7a21-6841-4fd0-a0f7-29e614d57d63", 7, 14 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cd7f49e3-5ecf-47f3-8f95-2614c88c03f1", 4, 8 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c8fc040f-f814-4fdd-85ea-182bd591f5e0", 5, 10 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ba39bec9-11b2-4b0b-9e3a-6631bb81bca7", 6, 12 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "64364f12-5eb5-4735-95c2-7f91bfdc5dba", 7, 14 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c0ed88b5-6bb2-4965-9f2e-1beef6f6df8a", 4, 8 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f57196d8-82cd-4859-ab24-6671cf610b38", 5, 10 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "04219939-885a-496b-9f38-7ec4bd35e5ac", 6, 12 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bed70fce-fd80-4428-8a05-954a8c7a4327", 7, 14 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0f1c3bd4-4dc2-4985-ab01-7617e3b69ce0", 4, 8 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ffd81424-a456-4784-a96f-dac0f4949dc7", 5, 10 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c00cef4b-a2a9-4708-83a3-72c394cd7012", 6, 12 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "20e18c54-faa7-4eae-9588-b91f0fe07aa2", 7, 14 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3de55072-6ee2-4769-8e48-779d338805d8", 4, 8 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "65b11780-bbd2-4847-bdc5-9c0f8b485647", 5, 10 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4ef122c5-a6fd-4f7d-983e-e6825df89f12", 6, 12 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f95bbbc6-450b-4746-a03f-e8aca2c33691", 7, 14 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "be6e2416-1c96-4776-9481-f9b345199ca9", 4, 8 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fe790316-dc18-48c4-9565-c0512e71e9d2", 5, 10 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "40634ed8-52ab-4906-9c57-484508c6aab4", 6, 12 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "57720d53-02d7-4209-ba70-3b62b0418540", 7, 14 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "125d453e-eb03-4391-8b33-ec2833ad4979", 4, 8 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1139f071-869a-4059-82b1-65df91bc310b", 5, 10 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8b3241fc-9919-4ccd-af06-7d6250148d63", 6, 12 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "efd53372-3f9e-47f2-97cb-8576248dcb1e", 7, 14 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5697635f-deb0-4b05-86ca-d0e630b4def7", 4, 8 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4b166f93-939d-4f74-9af6-c47aa63f8ac8", 5, 10 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "68a70e54-e44b-4a02-b1fc-1b2050ca85fa", 6, 12 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8c2a6723-5ee8-4f54-a9fb-7f4840d7d702", 7, 14 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4e9ecf6b-faf5-4287-a72c-9f241eb6ecea", 4, 8 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4c2abe98-97a5-4a2d-a1d1-677e8d3ddc93", 5, 10 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "17c2fe62-48de-48f4-9b96-cb7656ec4925", 6, 12 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e9530be6-dd6b-4ee6-82a8-a35329dd508b", 7, 14 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a9acaf08-a49d-4211-8682-bfe1f26ced4f", 4, 8 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0e85d863-a17a-41cf-b8b4-c53fdd104d65", 5, 10 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b8519f34-5729-4b24-b357-4b3ece171463", 6, 12 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "99270c93-e5b0-4ab1-823a-cc415c967424", 7, 14 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cf6de243-7c82-488a-b5a7-e1daa1e7e971", 4, 8 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "03c62c41-3163-4275-a175-0d1bbd8a2273", 5, 10 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a0bf376a-fae2-4920-b550-43d8f1a41f00", 6, 12 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "41289eea-9c2f-43eb-b518-48696e0fc97a", 7, 14 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a5ce46a6-07cd-414b-a463-b3c2920351bb", 4, 8 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "77166814-c230-4894-98b2-10f64293f9f9", 5, 10 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "295d9854-dc38-4d0a-8465-b9bd63fb73f0", 6, 12 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "928ba141-9f56-4740-9243-2e624abf8b73", 7, 14 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ea1384a8-4234-4009-a21e-ab2d0e55b1ac", 4, 8 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "39b63faa-8b27-4806-95a1-e89387dd1de3", 5, 10 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c61b639e-54fb-49a9-863e-7921fca93f13", 6, 12 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "903e6de7-5828-4512-854f-dc0e63cac83e", 7, 14 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0d5fb2fe-438b-4ff5-bda9-07c3fd59774d", 4, 8 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ffafe69c-0bcc-4cda-8706-aa63f577d92b", 5, 10 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "99ef93f6-2f1b-4cc2-aac0-f6462d1a3a2c", 6, 12 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5877957f-cb21-4167-9b82-4537783be1d5", 7, 14 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b6c609f5-e507-4218-854d-6039750d8ca6", 4, 8 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "08803f85-3c59-4e11-856d-a995ed6a83c5", 5, 10 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f7c47caf-db6d-4b1c-9c9b-baa10cb481c0", 6, 12 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "62adeccc-e700-456f-9d10-1e58151ecd09", 7, 14 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "56885b30-f839-48e5-a035-0ca067ca7bb4", 4, 8 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3413920b-fbc7-4dd4-b892-59e6d81399d0", 5, 10 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bb769098-126b-4d77-bd23-9a288491cf2f", 6, 12 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "be3c804f-b65d-4dc2-8ee3-19125064cc7b", 7, 14 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "88c04ef7-c737-493b-b375-d50f04b754ae", 4, 8 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1739f3c9-0b49-4b27-988a-eb4c678fe738", 5, 10 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3940b18e-4689-4afa-b72e-a76d8e597f93", 6, 12 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2b9e6159-2498-4aed-9723-ff9cc960e0d7", 7, 14 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "134f3690-a5cf-4d30-9bfc-fb78a0be1a5e", 4, 8 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "215bc890-867f-4fbb-943b-7e8028dbced7", 5, 10 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2bdc3859-9aa5-4d9f-b00c-fab0b132c5aa", 6, 12 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "62a2b9ac-a16a-41fa-9d44-96b0894bacf5", 7, 14 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1fa60dbc-222a-43da-8005-a57501c51d1e", 4, 8 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6fc23298-3a4e-471c-b786-c4fc0d3a06ae", 5, 10 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a1729967-6fbe-489e-9b6a-02358b6e6f13", 6, 12 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8bc2467f-d81e-48d8-aaa2-6dbdcefb4c8c", 7, 14 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9db7bea8-ee01-4998-8933-82bf7e2b85fd", 4, 8 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2a0edb5f-a214-459c-93c3-0fbea80b64bd", 5, 10 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "04cd4fa5-6b07-4b03-b064-6e9056457ccb", 6, 12 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "81c2f4ef-2239-47d0-bbd4-d388703ef2b6", 7, 14 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "164b03cf-b7a4-4f98-b067-024ac320706c", 4, 8 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9c7fd42d-9ca5-4d76-ba09-d6f78df1b7c9", 5, 10 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a5ede6ef-1112-4fc4-b75d-e506276db848", 6, 12 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "651db8bc-cc22-4396-be14-6b479c1ce993", 7, 14 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "358484ee-a098-4c2f-8ed0-a50c1ad525df", 4, 8 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dde41a2a-61af-4e9a-bac7-62cf134d98ac", 5, 10 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "365ff441-8c20-490d-b42b-aacbe1c7762c", 6, 12 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e52d5ced-67e5-4f8c-9975-b171d32af74d", 7, 14 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "52a47b0e-2bb0-453c-b20d-4d459f564713", 4, 8 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d89c6446-23e6-4175-926c-7c07e916afb5", 5, 10 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "638decba-7e75-430c-91e2-a81099214c4f", 6, 12 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "36c62541-7e9f-42f2-867a-9d7cff8422aa", 7, 14 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3500502a-64ea-45b8-879f-2984fb579ac7", 4, 8 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5d28836c-367b-4652-9a4e-246f0bc5d088", 5, 10 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4ba162d0-e536-4a28-a920-0946d32bed8f", 6, 12 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7b8c91b7-aa8d-4807-8dec-98462e89f623", 7, 14 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a6e6da35-43b5-4461-bab6-4327a9ae370a", 4, 8 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c717e769-3d88-49b4-a540-42b29aa14b04", 5, 10 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "57689fe2-8af7-427c-96dd-4e4e593f36d5", 6, 12 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4d467719-3e5e-425a-8dc0-1c05eea40e79", 7, 14 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5f13492b-7b5e-4ac1-b94a-49222a3413bb", 4, 8 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8739b3dd-2318-43ef-b5e5-a5ea5252ee36", 5, 10 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8e65da88-cefe-422b-aa52-197c85c4ae90", 6, 12 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6d47b752-ea30-4ea1-a77b-91fb5bb60af9", 7, 14 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "15f2ddb0-6472-4911-9c24-886d2d49e6c5", 4, 8 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e7469ecc-1a46-46dd-8930-9ab221e756fb", 5, 10 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5299b0d6-bc52-4ca4-ba3a-19085bef00fd", 6, 12 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5ba6476e-c010-4475-8b07-491c4e740e99", 7, 14 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c6d43795-0dbd-4148-a413-493a379c2cec", 4, 8 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7179eef5-2744-4bb9-877a-cf43c35dfb86", 5, 10 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7d4fe579-17d1-4e4e-a0c8-771841791841", 6, 12 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "183d3302-efa9-4a08-a726-258769fa42db", 7, 14 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0a0cfba7-8e1c-4d54-bf38-8fe66db49c8a", 4, 8 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d32791be-6bfd-48a5-98aa-a84e851948c2", 5, 10 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b1e3ceb3-148a-4c98-8527-019912f77ae0", 6, 12 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4ff60180-d18d-4da6-b406-a117a2e8c974", 7, 14 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "98bc988a-4a31-4296-8482-6be86b57a8af", 4, 8 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ff010b35-d5a8-4105-8cc4-05f1df87191d", 5, 10 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "27ff0453-d36c-4fd0-b347-deed9417db28", 6, 12 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3bfbf371-3b5b-48de-a5d7-6edb765786d4", 7, 14 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cfec467e-e25d-4021-a0f8-a25650f2e5c3", 4, 8 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "63d8f7ea-787d-41c9-8850-d03cda8ef975", 5, 10 }
                });

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00e2e1d5-5577-4f8e-b13b-dde82c77b91d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01388782-b75d-4762-8ccf-4499568fd455",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01e005f3-0bbb-4ae2-9136-f3afe1353315",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "034b18a2-33ad-4020-8d9d-5a98891d0be9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0418ebf4-0b73-4042-a5e4-ce396d5b512b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04871b2a-5533-41da-9959-f664809887c3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04886a46-180e-42d2-a3e5-86df27efaee2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04a7d241-f761-4ead-803b-1d204df7bd53",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04c2c202-afa7-4e2c-941c-29f956783f6d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "06c505ec-998c-46c0-9163-0188423113b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "074db959-27e0-42a0-98d9-0961864e1a7e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0973a418-280f-416d-8df1-7139e28961d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09a2d110-7772-44cd-af5f-27fb951f0544",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09ff2634-4a59-46ce-94c7-8428324d789f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a1ff474-48a1-4366-a120-8ece6ce5ba04",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a7149b1-6928-4099-b623-787d0201e213",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0bf06e4b-d062-4e01-a985-9b05e3f12fd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c59ca0d-60e5-4686-80be-18ab36b53468",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0dddae8d-37b4-47e5-9c89-95589a3f787a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e9b45b3-2915-4dcd-99fa-77ad89f182a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f1d6d17-8b8b-489d-a0f6-7349691aadd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "121345d8-2660-489c-a90d-2469b9c44222",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "142730b0-0df7-430d-ab80-e750ffe0a6ba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16b681bd-b39a-4891-ab7a-9073365bc1e7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a9626f8-303d-41e3-aa54-ae1a971ad179",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f4cf9f5-2976-4b5c-9428-122096bf3877",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2146af26-ce2b-461b-883b-e6f4fe0c8085",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "229759ff-14dd-4c4e-82aa-f56a2181c0ad",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8276), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23672a63-2fd2-4e6a-905b-340ae4456b83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2838e6e6-1238-418a-988c-0346a2abdbc3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "286d76ad-723d-476b-aa84-c7a6541afe81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8306), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "299be826-3901-425f-90eb-e445e73ac37c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2b514c67-a65f-4c0a-86b8-5bf92a974c34",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2bc1e669-d825-44a8-a11c-656a8209498a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e5e4216-4af5-4fb6-9c65-8989715e5a40",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b00595-bfeb-47b6-9af3-91d117e003d4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b3b531-3e47-4ccb-9cc9-8e7aafedb810",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "334d6d7e-422b-4376-ac30-161f98aab66d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3396c18a-dcd2-4638-8827-2c7fc10d6996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "364cd9de-6ddd-47d6-a534-74f3f00a0b7c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3770c1af-e181-494b-8c1a-c6f09a3b825a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38af7185-32ce-4cf9-95d2-52c4c4d18bce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38c1edea-3339-4f95-8d4a-5f5583660d9f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c8cf49-d75e-4703-8958-ec3bbff87723",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c99f61-efbf-4f5c-b084-eac381d82049",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39f01cd0-ae41-4070-9eb0-0f2423cc3286",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d6e031d-2fcc-46ce-9eb7-268e95ae1323",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d704609-8abd-4a0a-80dd-2ee9f38a3608",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3da92c21-3bf0-4de1-a187-459271e16106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e2f7a5f-b665-4b13-861e-c5a5029216a0",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8291), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f6f1dbc-9042-42c2-85ca-a117c745c5e8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8282), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41c0e64a-97f8-45fa-a2b3-399ed47cddcc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43606bc6-5874-4469-bcdf-fe1b86f66882",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43bf1028-ea0f-439a-b940-3b81b1f4d683",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43c746aa-0830-449b-a594-621f04923cf6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43ca244e-8d5a-468b-b327-ce6bdc541cf7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43f658bf-a5f4-4537-a281-77dbb5ce1c27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4534cffd-7ed4-406c-9cee-23179740daba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "46c82189-5271-43ba-97aa-a7b0a7dbf126",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4779905b-91b3-4878-97e0-58a010668be5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a450a7f-5ca6-42f5-9931-e130264c8e0c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a67e8f3-4dec-41ad-a5e7-18995a14535d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4aa47021-28ed-4c36-81c3-6e2734d3873b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b376f71-ebf0-4762-bbff-e61541afa410",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b656abf-bdc5-4058-a12b-488d93cc1677",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c0b609e-a2cc-4477-b8d7-9fec89d49462",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e99c977-d86c-48a7-8bd8-9e71d999539a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f8cc09d-7512-44d8-a98c-3004c93031f0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50680664-523a-475b-869f-0aa5e0cd88b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "523db500-84c9-42fa-bf24-f66e77e724e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52a0bd63-231d-4620-9e7a-10b6d4fb8b65",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "541a5387-302a-478d-99f2-c98f6d979aaa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55f0346e-6b98-4a1d-99f8-463b81f6a627",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "56072689-4550-44be-987e-b08667758de4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "564ea3f5-665c-45f3-85ee-e4c45d3ba362",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5754a3be-8508-452d-8a64-9d752bde4f70",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5787a57d-27d4-4dd2-b5e1-35e4125a6e94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a04a2e5-489b-4671-933a-1db0a971f40e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a382843-9817-449b-b9d8-4e48d90aef5e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a529282-1b91-46d6-b472-e6386b95cf5d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b26e8ac-df32-4b9d-8992-047e22372332",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b36c084-dce0-4ba9-ba55-613210750e27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cc37e11-afea-478b-b360-1256896a421b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5eaed820-0af4-4157-8fea-1f58baa77661",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5f9a2c76-50a5-4e93-95c9-158ae078c357",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6183a2d7-d2c5-4828-bccb-754ce1bbb002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "618fdb18-11c3-4166-9bb1-79298a32a7a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61efcce3-e4ac-4aa6-ae46-1b7976b5da88",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64a56e1a-be01-40b0-bc09-1fcaf2161c10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "674202c6-8a9b-4c1f-9eae-0ab056cef8d6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "676211f2-1f90-4059-bdf8-9e26f9a637a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6883361b-7a86-49b9-8fc2-90029770fe22",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69191d39-5c1b-4261-b0d7-48a7833e08bd",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69920a1e-2cdf-4b1a-a9cc-329b986e4b69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bdd753a-2706-48b6-b485-23c989a5f326",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c4014cc-3cc2-481d-9cd6-b13c45da0908",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6e0185cc-235f-4603-9470-5f4ca7c92514",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6eee1f90-a40d-4d95-9ca6-0e45689398be",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f001fcf-f1b6-4abb-8d91-7038044fabfa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f055d63-314e-4a36-86eb-ea7e11e820c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f154805-6e66-45a6-a147-87edf4267def",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f169352-0f68-4d11-b562-f693a0158100",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fe7b587-9518-460f-8c8f-7aa43ad55f9c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7203c646-e705-48d1-8141-b2619b227d8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72d46b9b-612d-41c4-8303-8f8571771de9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "731dd6c2-2937-4d4b-8c56-63b5cf581729",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74770ec2-4585-4665-8f69-b2f0d4f0fc7f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "748cbc1e-8d05-4f4f-8196-9cfb28db232c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74aa5d7a-f513-4993-b672-cdf9bb448319",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "752bc953-0f26-4a2c-afd2-45c5f0b9aecb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75ce2f59-fa25-4745-bb37-371fc11ab655",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77035e08-21a9-4149-8d7c-d4266f88ad03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "777bd2e2-cd9e-4d51-b191-c81eb9d113cc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78157107-23fa-4638-bd17-38187695312c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7965d633-4f86-44de-8ea4-fe0c68aa6a83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79876823-dd75-471e-b2b5-80650a4bdd47",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a3ccc47-8f30-4952-8909-ed3537cfe7e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a7cb657-507c-4325-a047-f9d67b6fbffc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7ac3fbad-b279-4d80-a8d7-ff1407a6465f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7d543840-b11e-4380-a147-7dab483cf5ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "809d901e-d7de-4fec-aa95-655deb2301b6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "80f38d33-7c5f-4952-809c-85af1dc69962",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "815f578a-5fd8-4c79-8446-ff236b6ffafb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8191402a-33f8-4195-bd73-3aa71191981e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81c921f4-7fd6-428a-aefe-648e5e11ed46",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81cb9635-df03-42c8-8d68-944f99de02ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "827e88a3-8580-436c-9112-02d58ca2d7d0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85634f26-c60b-4cc5-8c0f-0fad3182a5f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8601b2c5-4e87-49e4-9099-8c21a9ca00b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86513d65-cf7e-49d6-bd16-94286e5d60c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8906cf96-12d6-4eca-8a0b-d39dd78dc597",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8322), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "89c5b8e4-4c60-4e08-88ad-4509be08bde4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8a84a13e-c0cc-4496-81a8-f4550c5807ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8abdfc01-6b02-4b55-93d3-eea25b17de37",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8ad91c05-ccae-4482-9f43-f8f197dccdf9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8af7be7f-0ff6-40e1-b206-e89d78430393",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8cefc01c-282b-4866-a0fa-238ed864481c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d1f8204-852a-4342-b836-767fb2b71263",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9017f445-e420-4568-b8d9-0d84b3c46aad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91cb02d4-02ee-4632-a12b-7aaa4b220344",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "924916c0-2ad0-493a-b544-5df45fa43152",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92a51416-05b5-47ef-834f-ad0baccbb932",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "932c7c4b-36c5-4580-a276-a176a72fd72d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9377deeb-6354-4346-8d56-03b29c97d5fc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93c17f7a-aedf-4f6d-8429-df9ff308d381",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "94430690-6bd2-4e48-b0c3-4de11c7f5d81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9445ce49-5efd-41b8-bdab-b8d7f350b5e2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9570f221-d5cb-4963-896f-371af0b32c79",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "958017ca-725f-4d80-b65e-79560a051a03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "976d92d5-de98-47ea-a219-26842c7f8caf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c301f9b-43b4-4015-bc1d-70ad1b2b690e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f0127f0-a604-46ba-a855-ca6be06fcdb2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f2f3880-4997-4c0b-88e8-f9a74f8b1564",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a07ed297-38cd-456e-834f-c31583eab987",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a08d4c19-059b-42bc-83db-26206735e40f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a278895c-19b5-45c6-92f9-48c5f2724e8a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2a34d3f-9082-4d98-9637-2bd936e60256",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2bcb56b-1da2-43fc-b133-3b5c04603123",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a34e2f74-5403-4e43-bc88-30019ebd460f",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8316), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a39041d7-3a20-4e73-9334-3fc6d8327e06",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4efe1b6-e7fb-4cee-96aa-1125a3888791",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a907697f-9b47-4302-87f3-c4bed83b24c9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad918937-0645-4b89-86d5-0672662fd46e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aee09720-0d54-473a-b585-c62d6c516e68",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1dae3fe-91d2-42cc-8ba7-dcf237882eac",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2b71d89-5501-4bd6-a358-aca8ce706bdb",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8331), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5b67003-636d-425d-9784-45d374db713c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5e13a1d-86f3-415c-9c2f-4343258a4b57",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8327), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8b726c6-227d-4267-8dba-c1bf5ec0301f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8cc3bd3-ac03-46c4-820b-f7988f3088f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bac28c61-4b74-4193-a109-f4456c44cf67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb1dfb9b-70aa-495e-a041-156a4fbb4fec",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd0cb50a-e769-48ed-8473-b25faa687e15",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "beacb4b7-e74c-45d8-b8df-60e1a2a50768",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c15e0f9b-39be-49ff-aff8-1800116358f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c24852f9-007d-455a-8cb5-0e2681c7a0a5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c35ccc97-39f5-4396-bbe1-2a6171f30d10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c37d754a-9f08-4f13-8d26-630d896c9371",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c474ff32-d65e-4d11-90a2-f9ad2e8ee772",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c50585c6-d1df-4eaa-b5bf-317678e7d3bb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5381f46-f707-4fcb-8f1e-605cee507946",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5d36e60-0945-4e35-9239-22f30c29025f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6633a62-08d6-4613-8f06-a3fcfd76f974",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6fcf873-e9c2-43c9-81ec-ba09bd063e13",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c87ce8ae-adb7-4007-8c0e-0090d0926e2e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8e6b9db-dbc9-4d49-a473-2c8593982b56",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8eeda2a-0260-4488-9acf-fddaee71e124",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c941ed50-01c0-472d-8122-3756b9b55a29",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8311), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c99efd04-1f14-49e6-bd60-208290d057a6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cae31f17-a52f-4ac3-97bb-6886500b19bf",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8295), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "caf33f50-8517-4995-a849-4a70bbe202f6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd21938d-8cdf-4c18-a25a-73a2970c2deb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3167af-629a-4795-8c18-cf4f49e0a7d1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3be091-3d72-4512-ba1d-e8466285b930",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ceaa3043-fb10-4638-b942-85d7b5fc20ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cf03ef83-babf-4710-ab13-ace35476b474",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfb34052-097c-4637-b13e-86a2bc255163",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d302b7f9-1306-4a95-85d4-ff189df4b527",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d501bc94-2256-4ce7-b0bf-be4357ada814",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6003f61-89ae-4240-b53c-542ab36728ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d7a31657-3101-42e7-8b97-aa6ff61d3e84",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d99cdf9c-bda7-4807-b92e-34b3de2e6002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db5aeda4-2830-4ddd-a7ca-02363d58bf25",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db604d4c-9f40-48f5-b244-9b3bdcaf71c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db9ccc9b-5149-474b-a0b4-af8a13f01bc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc91cbb3-94e1-43fe-bf92-06077cf48d87",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc94da97-75b3-48b7-bfb6-d46984b5f106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd438551-3d93-45bc-982d-7c338b69983b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e0f91ecb-de8b-44fb-9a15-59c38d5093b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e35c267e-66ab-453d-ba33-a31c4ce7e5ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d54d6e-42fe-472b-b696-6642067802b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e9ca0d20-0315-4fca-b334-e6e046cd076e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea3367e6-6d1c-4e58-883a-b18d66f30f8b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea59937e-0296-4758-95ad-196fce18db72",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb3e277a-61f3-4f55-b179-d474841a80a3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed9ab94a-9354-48de-8695-43131a67bd2c",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8300), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eec8a34e-e0ea-4a80-bd38-c7db22f84173",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef08937f-96ed-443c-80ac-1f7b764d10a1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef23ec60-f223-44c4-915e-196d6b011b94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efe2c4a0-7529-4f91-9026-696ea0a1f7b7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f03ff26b-30e9-4a60-b99a-780060db1e35",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f102b409-56b3-42b4-b70c-25192033ba8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f20906f6-cdbb-4f93-9ad0-87e63f0782ff",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f39485eb-f82b-495c-8b60-7dada21ee477",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f43faef4-2885-42c1-9035-ccc2667d7fca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8287), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f6edd915-a9e4-4713-8e0a-6f1d7efde18f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f7062df1-beb7-4814-a074-e9da66830639",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "faa28a13-3b08-4a67-834d-621e4dd3d287",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb0deebe-ca58-4eb6-ac5b-67442c846405",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc72a988-3078-4c69-a8ca-c0f1dc1ec996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fee54746-70cf-44dd-98df-5c09bb8959a8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffcc6812-deda-4b92-b2dd-0f59e0a46c44",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 737, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "RoleName" },
                values: new object[,]
                {
                    { "6af115ee-d3ca-4d9b-9aa5-9000e8096af6", new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(8038), "Admin" },
                    { "a1623d5e-bab4-4ccc-9a32-335f376c3325", new DateTime(2024, 12, 24, 19, 25, 58, 739, DateTimeKind.Local).AddTicks(8057), "User" }
                });

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "91a50006-358f-4d75-aef1-d1dbece33485", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 24, 19, 25, 58, 740, DateTimeKind.Local).AddTicks(2329), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "11ebdd3a-f75a-4d85-9916-220874cf8af9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 740, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "152002fb-d980-4750-a70a-7b5d0bdac9e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 740, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 740, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 24, 19, 25, 58, 740, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "17fba837-42e6-4c79-8e15-6001c8df2544", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_Id",
                table: "ProductSizes",
                column: "Id",
                unique: true,
                filter: "[Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetail_SituationId",
                table: "OrdersDetail",
                column: "SituationId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_RoleId",
                table: "UsersRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetail_OrdersSituation_SituationId",
                table: "OrdersDetail",
                column: "SituationId",
                principalTable: "OrdersSituation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetail_OrdersSituation_SituationId",
                table: "OrdersDetail");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizes",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizes_Id",
                table: "ProductSizes");

            migrationBuilder.DropIndex(
                name: "IX_OrdersDetail_SituationId",
                table: "OrdersDetail");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "365dbe4e-2bce-4b82-bd3a-5261f9379d04");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "3a1ef73a-5773-4ef8-a478-a405d5afffab");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "4b7db51f-76f2-4215-8e81-06a2a5012528");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "4e5045d2-22bc-4740-ba44-434cf6a4f92b");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "72e72c37-ea8b-4594-a3e8-44b3019f3cf5");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "75b9c805-517c-4209-8085-5f3f44aa364e");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "9047c8ca-776d-4d11-be70-b2d8bdada804");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "9d376c08-fb5b-4625-9066-15d0c6b5a8b8");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "a664a8ed-a87a-4761-af10-c6577d927e27");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "b5cad56f-fd3d-4ce6-a679-82001fe7db17");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "ccafbad4-f868-4951-b3b7-2b00c96c65da");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "dc750dda-ebd4-4e4c-aff1-0d3a234dd1bf");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "06717927-c5ac-4c84-ab3d-bc30434799c6");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "0bfec61b-77bf-486f-bd00-f074293edb0a");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "1330febd-6722-4da5-8d29-d720fbf9fd7d");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "287e4799-07dd-4ded-8c14-bf5ac804ed8d");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "324030cd-a3f9-45e8-9455-401c7e563c71");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "4861fa0e-f2c5-49f1-9d39-2516f29bc5c6");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "488edcde-0fcb-43af-bf2e-0ab72fa7117b");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5288713a-ccef-4632-b96e-cbd8ae93df31");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "658f98b7-f679-4cdd-afd1-3702fbbcd203");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "6aba2899-ac9d-4aa9-9e29-e2f56560ae6e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "7acf7f01-681b-4689-8d41-48908b032fd3");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "821b6762-d818-49f2-b8d5-453b4de5da48");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "87e1ee8d-41ce-4151-b9e5-2aad553127b7");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "a58884a8-8661-48fa-823a-3d3fbbdcdd1d");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b3be27cc-951f-4146-af5d-38feedb82e96");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "c873dc32-42b1-4616-bfb7-e4fd17312148");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d868dae9-e04e-4791-bfb0-5b4aa3ab1864");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "da37970e-7d2c-4d52-a8e0-9bb7976d14b9");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "e1090e0e-ac03-4476-8df6-959560069e15");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "e7d6d65a-24ae-4016-b438-736e2185107b");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "ead666d9-a098-4042-b1ba-f377795c14e9");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f214122b-dd0a-4a6d-bae9-5abf2d1eb38b");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f231ca8f-1173-4143-9dba-cbadf7e2a01c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f81ca274-c921-4661-9a22-c83250e079d6");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "488ff51c-27b6-4a92-9b4e-2d394e025450");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "580c8055-b69f-4514-9e10-eaa3859a057b");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "a204dab9-d88b-467b-9c79-9af01012f146");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "f8fc0e63-97ce-4072-883b-ae7c7fb72180");

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
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6af115ee-d3ca-4d9b-9aa5-9000e8096af6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a1623d5e-bab4-4ccc-9a32-335f376c3325");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "91a50006-358f-4d75-aef1-d1dbece33485");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "17fba837-42e6-4c79-8e15-6001c8df2544");

            migrationBuilder.DropColumn(
                name: "IsSale",
                table: "OrdersDetail");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "OrdersDetail");

            migrationBuilder.DropColumn(
                name: "SituationId",
                table: "OrdersDetail");

            migrationBuilder.DropColumn(
                name: "SituationName",
                table: "OrdersDetail");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "OrdersDetail");

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
                table: "OrdersDetail",
                type: "int",
                maxLength: 100000,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100000,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UnitPiceForRent",
                table: "OrdersDetail",
                type: "int",
                maxLength: 100000,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 100000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SituationName",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "RoleUserInfo",
                columns: table => new
                {
                    RolesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUserInfo", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUserInfo_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUserInfo_UserInfos_UsersId",
                        column: x => x.UsersId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7851), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7883), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7866), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7856), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7899), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7895), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7909), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7904), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7888), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7871), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7877), 0, 1500 });

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
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7861), 0, 1500 });

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "RoleName" },
                values: new object[,]
                {
                    { "ad", new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(2405), "Admin" },
                    { "us", new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(2424), "User" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SituationName",
                table: "Orders",
                column: "SituationName");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUserInfo_UsersId",
                table: "RoleUserInfo",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrdersSituation_SituationName",
                table: "Orders",
                column: "SituationName",
                principalTable: "OrdersSituation",
                principalColumn: "Id");
        }
    }
}
