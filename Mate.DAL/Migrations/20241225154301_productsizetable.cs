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
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm");

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
                    { "07f8b873-7581-4254-b815-4049bba61906", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(916), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "2f0c36aa-9021-43bc-a0a9-105f31039f1e", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(882), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "34b92f94-cab3-4c00-adbd-5d44564e2956", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(920), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "52525383-5045-4b3f-9a1d-c70e87b827dd", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(896), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "529b2623-4ad8-49c2-b1d6-a7376913a121", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(925), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" },
                    { "72f28bdd-b3ba-46fc-a028-8d69676d3c93", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(933), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "7942fba2-ea3b-4b4c-aa17-43ea379d7fc5", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(911), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" },
                    { "984595cb-84d5-4645-b525-68a9c07e0fa8", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(892), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" },
                    { "abd81aeb-2384-40b4-8b57-de47f787b2b4", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(929), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "b741ccfa-dfb2-4178-aa28-53fb13f163cf", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(888), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "f175e8cd-4514-4391-9695-c0f7ae3d0346", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(808), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "fa411301-2e80-418c-9e7f-6a850fbaae42", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(908), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "03e073d5-0fc8-4c6e-94e7-b85f82c9cbf3", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6060), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "0488b4da-cc9f-4572-a3b7-3caab13f3e3c", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6019), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "1c3c3d1b-9e1a-4f56-a9e2-895ce1c13259", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6074), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "251de8db-12fb-4a14-871f-af6fb43d6dc9", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6033), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "2f348f5e-aac3-41d5-b4e2-692176284447", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6132), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "3f4a25a7-22cf-4673-929d-ac0ef2ebb640", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(5990), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "43f4bf45-cb5c-4b3f-9731-5ef8346121cd", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6125), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "5435d8e6-b0ef-4a01-8bf4-913e03d5b3db", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6087), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "5e3f6876-0ef1-405d-a636-f6bdafd48f74", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6053), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "633e2b9d-b30d-48c7-bd86-7d63c85494b3", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6138), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "82426e2e-28b6-485d-b835-e62a5982fde6", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6105), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "877968f8-c429-49fb-bcfe-46d445032c95", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6156), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "8e63cc63-539b-4bba-a56a-487ff82da8c3", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(5935), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "a422b393-ddb2-4cc3-b74b-0e8f4682ce0f", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6080), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "a9447dfe-7272-4ac7-93de-dd6f20147366", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6067), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "b91af158-f36d-4342-9014-02baffc6784a", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(5996), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "bdf28961-0f5c-494e-92ca-5d25f5bfbc03", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6013), "/databaseimg/galeri/galeriIMG_1958.jpg" },
                    { "bef3c24f-0eec-434c-ad2c-b0a76e7b84e6", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6094), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "d3c9fb94-3698-46f2-a873-7a2268a88633", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(5981), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" },
                    { "f38971e5-78eb-47ea-bd27-328b5d22c5a7", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6026), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "f7206262-9534-45ac-88bd-2c75187cb289", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6046), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "f8111ccb-0c71-4a21-864e-cab621804921", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6119), "/databaseimg/galeri/galeriIMG-8454.jpg" },
                    { "f94525b4-7628-4e33-ba83-c059963ddd82", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6112), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "fc9b659f-b472-4511-8e03-bba95224f9f0", new DateTime(2024, 12, 25, 18, 42, 59, 859, DateTimeKind.Local).AddTicks(6004), "/databaseimg/galeri/galeriIMG_2356.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "bi bi-caret-right-fill", new DateTime(2024, 12, 25, 18, 42, 59, 866, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "bi bi-caret-right-fill", new DateTime(2024, 12, 25, 18, 42, 59, 866, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "bi bi-caret-right-fill", new DateTime(2024, 12, 25, 18, 42, 59, 866, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "bi bi-caret-right-fill", new DateTime(2024, 12, 25, 18, 42, 59, 866, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "bi bi-caret-right-fill", new DateTime(2024, 12, 25, 18, 42, 59, 866, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.InsertData(
                table: "MainMenu",
                columns: new[] { "Id", "ActionName", "AreaName", "ClassName", "ControllerName", "CreatedAt", "CssName", "IconName", "MenuName", "OrderNo", "ParentMenuId", "ParentMenuId1", "RoleId", "RolesId" },
                values: new object[] { "Communication", "Communication", null, "bi bi-caret-right-fill", "Home", new DateTime(2024, 12, 25, 18, 42, 59, 866, DateTimeKind.Local).AddTicks(2406), "", null, "Communication", null, null, null, 1, null });

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "5860e32d-d1f5-451b-b62a-cfe8b27a62fa", new DateTime(2024, 12, 25, 18, 42, 59, 869, DateTimeKind.Local).AddTicks(5850), "Siparişiniz Kargoya verildi" },
                    { "618f0ac8-f2d8-4405-a307-3b1195eafe44", new DateTime(2024, 12, 25, 18, 42, 59, 869, DateTimeKind.Local).AddTicks(5845), "Siparişiniz Hazırlanıyor" },
                    { "b25e5258-6524-44db-a702-ea6fe77f33a6", new DateTime(2024, 12, 25, 18, 42, 59, 869, DateTimeKind.Local).AddTicks(5814), "Siparişiniz Alındı" },
                    { "f7d4f67c-ad44-40b0-adf3-184fddadba79", new DateTime(2024, 12, 25, 18, 42, 59, 869, DateTimeKind.Local).AddTicks(5869), "Siparişiniz Tamamlandı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 869, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 869, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 869, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 869, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 869, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.InsertData(
                table: "ProductSizes",
                columns: new[] { "ProductId", "SizeId", "Id", "SizeAmount", "SizeNumber" },
                values: new object[,]
                {
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "84846044-b097-4849-81bd-e12fc79a9864", 6, 12 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e34a6d9d-8ea9-4b6c-a6b8-9f004b9d0bb2", 7, 14 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6299e3fc-3c93-45ab-b753-eb793420247e", 4, 8 },
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fa0011f4-ba45-4174-b97b-03df230f1dec", 5, 10 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "66f06eba-1c90-471e-938d-a6e0e05d0f1b", 6, 12 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7e2b37f6-2ff3-4da4-8ae7-7d5cd6646f1e", 7, 14 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c34484f5-0f8c-4319-9206-afe3a76f3748", 4, 8 },
                    { "01388782-b75d-4762-8ccf-4499568fd455", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fad84fba-888e-4f71-a19a-9ee1d85fd290", 5, 10 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "12e99c3f-e6e9-46d3-9c5d-9a2a52616ee0", 6, 12 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c9efda4c-e806-4802-beaf-ca55a8e63a4c", 7, 14 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "96d19f7a-4270-4d7b-b845-e07886bce88e", 4, 8 },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "14c2899b-0069-4a88-abd5-280e3c6c65f8", 5, 10 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "14fee102-7280-47b9-ae0e-95d14b7772c7", 6, 12 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "82b8d3a2-f217-4906-8778-cb1f6a1e4e1c", 7, 14 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "00ebfc70-c1df-44b4-a342-b3d9cd696a90", 4, 8 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b8cd853d-a3cc-428e-8efe-09b882ac872a", 5, 10 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1b3645f7-9eae-486e-8d05-d3b9c74753d6", 6, 12 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9b87df20-8e18-4e50-a3cb-11b4586ef14b", 7, 14 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c12b772b-079d-4aa5-aaa3-789fbe1a95cb", 4, 8 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5532e1b6-8332-4c24-9255-1ace963d2cf5", 5, 10 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "14481288-a38e-48a2-9740-397e5a69b18a", 6, 12 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "99fd5a43-b3c3-4a4d-97be-18051f0622b4", 7, 14 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c494ac71-cc43-4aac-b360-401cd9d6dcf2", 4, 8 },
                    { "04871b2a-5533-41da-9959-f664809887c3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "74c74455-7151-4482-85f5-fb214427b521", 5, 10 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "608b2f93-9812-4ddc-b12e-a8891f8b79f6", 6, 12 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6c65ccbb-72e5-419e-bdc1-44bfd738ef56", 7, 14 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "72595d35-1f7a-4475-9ae5-21d5d672d714", 4, 8 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "19b74d14-7ada-4f0f-821d-24488b0b9ebc", 5, 10 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aa09b281-6f45-47ee-a897-8ed08d253bbf", 6, 12 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c2cb5313-ae4b-40ff-9b3c-3b6280834c19", 7, 14 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "50329634-412d-49f2-bf7b-aa9cf2e4e710", 4, 8 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7c0f7493-0c8a-4b98-8ebe-b0264f997de7", 5, 10 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9cca651a-ce76-42be-aa92-8295fc02ae04", 6, 12 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "561a6958-8ef7-44f5-a78e-57acb1f60114", 7, 14 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "35301293-585b-40a4-886a-becc9a80cdef", 4, 8 },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9a035b16-7bf2-4457-a920-a2bf61e4c7d5", 5, 10 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "18b71ebf-ffe4-474c-b66e-8a3614133115", 6, 12 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "371e12a4-f21a-4cb0-a50f-6f3fc9f411c7", 7, 14 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bc93ba7c-9388-46f3-8e63-16e054ac7d75", 4, 8 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6e17a1a8-9c35-442e-9629-e4f07b8aa922", 5, 10 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "da96f218-7bdf-41f4-b154-b1fb79390e29", 6, 12 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "89f692a3-8471-4398-9ef5-77d6e9f6d953", 7, 14 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bb8987f2-5397-4c65-80ac-178b41b912b5", 4, 8 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "03706f8e-0b84-46aa-985e-c945f01741e0", 5, 10 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c59ce762-08e8-479c-a685-7631f9e3cfff", 6, 12 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1265bde5-89b0-4d76-b0a5-dd44c3b08403", 7, 14 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "906690d7-b485-47d7-8585-d0ee5df2287b", 4, 8 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5305dc38-863d-430b-a0aa-d84ee4626075", 5, 10 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b149ddfb-2df3-4d8a-be11-24141ae91b20", 6, 12 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "324b271c-1e02-42a6-bdb9-9a301bd941cf", 7, 14 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1fe4378d-bcba-40bf-a9a7-c8dc4af2a28e", 4, 8 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2f90ca57-714d-4bf9-ba49-c64b6930f7ca", 5, 10 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b3ca6f67-362d-4089-890d-812a9271af25", 6, 12 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b0aa7da1-199a-4505-abd8-f7e980f5a4df", 7, 14 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c77ce6f4-8ab8-4773-9bea-b4e08ebd5c77", 4, 8 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6fa8dd4d-8d63-4eaf-97cb-556b5b4c2197", 5, 10 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fc996969-6324-4b12-9a42-3814b8642b44", 6, 12 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bbef253f-d26a-4065-9393-22ca175ca577", 7, 14 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "45107e7f-2213-4252-8fba-6398b183acbf", 4, 8 },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d1083ea5-db40-4f6b-92c8-e241c95d6553", 5, 10 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4e9d6ff2-b86b-4fe5-aa5e-2357bcd40eec", 6, 12 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3981cfc1-e6fe-44f5-ac9a-ffc4d43a1ab5", 7, 14 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1bcc3581-e316-43e0-9f51-e39e0637874f", 4, 8 },
                    { "0a7149b1-6928-4099-b623-787d0201e213", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dbbfb13d-7b5c-4f6c-b5ae-04446f5b527c", 5, 10 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eb3a424d-a779-4ec1-8ef0-5a62e6589d6f", 6, 12 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cf7bed28-2fc9-473e-bd49-a3dccf953339", 7, 14 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1452c1e0-1658-4b95-a398-5467e160314c", 4, 8 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bf8f06eb-45a9-4bf9-953e-5f912dc35df8", 5, 10 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fbe4b44c-9cc5-4ab9-baec-60c7434fdc9b", 6, 12 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "45539cd6-7c7d-4ac8-a048-13f5b8ce975c", 7, 14 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "843de2b5-42fc-4f94-8b29-2e5d0fcb3ffe", 4, 8 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e1eb1bb7-e1db-4f55-898d-bb83e579b02a", 5, 10 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9f09237d-af49-49ee-a85d-aee886eb05a5", 6, 12 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cf439389-7537-460f-99a9-74ec8b4a074c", 7, 14 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c190c534-e99e-4778-9549-ac0d0b0d6eff", 4, 8 },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f2d74302-feb9-44e1-84b2-dfc61ad6a847", 5, 10 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b8d841df-509c-4c5b-9c31-64f8af1cf636", 6, 12 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d3b16c2f-2854-4dc0-a7c1-41139e7ab540", 7, 14 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "052ab7c5-90e7-4e61-a1e6-267276a19798", 4, 8 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "09e01ad6-7036-444e-85e6-a467ef5218b5", 5, 10 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fe7c282b-96fe-4075-b4b1-af2dfd8b17cd", 6, 12 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8ab88069-48d5-4ac7-8563-2d2dda558e02", 7, 14 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4ee7c30f-861d-448c-9147-3f9fe8c922ff", 4, 8 },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3f7ffff1-63f1-48a5-8797-f769572ff925", 5, 10 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5cdffe7d-d526-45f3-b464-96cac20bb1aa", 6, 12 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e70e6ace-e6f4-4ba6-8536-4080208517df", 7, 14 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "186091bc-4819-48de-8868-5a5f54a76c00", 4, 8 },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fe3321c2-c3fd-4ff4-8344-10a040abd5d8", 5, 10 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2936fe41-7360-4dc2-a7ad-bb0ebab58d09", 6, 12 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "933d6adf-6016-4ae8-8b02-2f1982b356df", 7, 14 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2bf419a8-0299-4cbd-b206-0e225740ba6b", 4, 8 },
                    { "121345d8-2660-489c-a90d-2469b9c44222", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "55035151-ede6-47f1-bd6a-a96d25e3c31b", 5, 10 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4f83118a-2a13-4992-abd3-b0b13b13aea8", 6, 12 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ba686337-f2cf-4a88-851c-56bfb13f722c", 7, 14 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b581d033-317d-4488-a3d9-036f96b568f7", 4, 8 },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2f637fe7-305b-4b33-a59d-955db41e7717", 5, 10 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e80f1d7b-8344-4f81-93c3-e1d58a72e95a", 6, 12 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "31c8f8b5-ce26-4b2c-8539-b446727c1627", 7, 14 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "71811753-c71d-4fb3-be62-488b467b35f8", 4, 8 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c4d36c2b-ae18-4f2b-8319-4e0a0296738f", 5, 10 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dd6ae79c-8ead-43fd-ab4b-5b18ecfc28c9", 6, 12 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "484c50e8-c259-46e7-a054-056ab4a7248b", 7, 14 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "adc3a159-7f71-4bbc-93b1-473aaff9c8a3", 4, 8 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fe8ec95f-7e3a-4d87-b7ac-4cfd07fa17ed", 5, 10 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0efabfa1-c157-42d9-a66f-c4dd15a7de81", 6, 12 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d203914d-a85f-4f60-a2c8-d054a2644cc7", 7, 14 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "11280129-338c-4cda-91c6-bfcae20dd8df", 4, 8 },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4139fe23-9223-4bec-8b9d-d35734281720", 5, 10 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1e7d263e-2dcb-4f8a-b5af-105c6d08c5a5", 6, 12 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "df6a8f41-a7b1-4b94-9806-799f0c05c074", 7, 14 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f0959335-f5b6-4fcd-83da-08260631b508", 4, 8 },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "39295d2e-a283-4e88-acf8-70266c7e40f3", 5, 10 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2def4744-1634-4a08-8b21-fb5f33130c12", 6, 12 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3e992594-a5dc-4d19-b04d-e2dde50a4a3a", 7, 14 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6e46136d-6a43-493e-8e70-7c83abd48a3f", 4, 8 },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7b45b919-d6ae-4225-946d-51c532e2336e", 5, 10 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8413fb04-cce5-4f6f-8102-69f6b8339bd9", 6, 12 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ec185bce-8b6d-4478-b1dd-4330875db6da", 7, 14 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "06890c00-2f7a-435c-af5e-8ea8667557ed", 4, 8 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "64bd67de-4a35-4800-8a58-7f752f7ee107", 5, 10 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "23026b78-3702-4aa1-81cb-62c6a0900067", 6, 12 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "673c22ce-063a-48cf-8c4e-527bb86ce5a2", 7, 14 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "55b670d3-f21f-4803-b3fe-f04061bdeacc", 4, 8 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "128f2e58-f22a-4bae-ace5-e942b2dc06c8", 5, 10 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4a6dd2bf-5aff-4bfc-a07c-753bb049789e", 6, 12 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6e5c9423-6b6c-4b1b-a719-38c165bf9f2c", 7, 14 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f18ed39c-ce5e-4562-8fb5-fe8b83db1309", 4, 8 },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c3975221-28b4-4807-a2a0-98348e4730bd", 5, 10 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "001b4fa7-f026-4ef7-83bb-29716844594a", 6, 12 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4d882ba1-fab8-4718-b217-59cddf5fecf9", 7, 14 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "79c7750a-4491-45f2-9272-20600edf8e31", 4, 8 },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "eafb3f9f-da19-4db7-81d5-b11abd0e87cb", 5, 10 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c6e7919c-471b-4a67-a90a-798e87c9507b", 6, 12 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e684e20b-a223-432d-93b8-dc77078d2d79", 7, 14 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "14c5ab6f-6a68-40f0-9f6c-0732cde997ee", 4, 8 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "36f6977f-f67a-4570-85ca-fd7f0c309f60", 5, 10 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d7e3d980-90bd-44e9-8c1c-d5129989425b", 6, 12 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0d0e6ac6-d409-42b8-ac71-fbc5d7f87103", 7, 14 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dc5b7432-c688-41b0-80bb-46afc578f165", 4, 8 },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d636e4e4-d12d-476f-bbf9-89c111a23a84", 5, 10 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e67057af-e125-42bb-832e-aa2f28c8de87", 6, 12 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7f443d2a-576f-4d80-8ccf-14745a5234a1", 7, 14 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5beb7acf-409f-4ed2-851e-68de89e7b522", 4, 8 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7805fc5d-00fb-45a4-bf81-135512a8d975", 5, 10 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1d3ade9f-e5d2-4891-a1a3-4267a0dc0861", 6, 12 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "22fa0709-ee7c-4e31-b59a-1e91344650ce", 7, 14 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "336ff015-8ec6-4742-8bb6-9eb72a64120a", 4, 8 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "61490f11-ae6d-4924-af67-c2763ee72250", 5, 10 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "500cca3c-faa7-4958-8113-f53f2f8e1b3a", 6, 12 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "62262925-b4ec-4e7c-b0ab-95424efa2271", 7, 14 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8abc9e04-4167-44aa-9292-f81246ce77b4", 4, 8 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e9fce6fb-0cc6-4cac-86c2-f2a468b21e45", 5, 10 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "02941e3c-90f6-4d7b-88e1-220614cb0e1c", 6, 12 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a6ed248d-f6ba-47b5-89fd-c54a75b35efc", 7, 14 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "461a44fc-67b8-408d-9d73-be98acbc4810", 4, 8 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6d12a305-9a3b-4192-b1a7-2f6e70ff4396", 5, 10 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "906a5c74-d4c8-40e4-83f3-03ba8e01fc02", 6, 12 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "74649d10-ccc1-4caa-ad6b-a3f58facf8fe", 7, 14 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "787a14ea-adc4-45a7-b480-ee11841ca9d1", 4, 8 },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "41e996e2-417a-4ce3-88ea-e26031e50ce3", 5, 10 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "11725d9b-8b21-4331-9483-73eda6a1824f", 6, 12 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b382e194-dbf6-4668-8661-f1b866a0426a", 7, 14 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4d8c9df6-910b-4851-b068-4a00335a8168", 4, 8 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a183c34b-66ce-46b6-acad-91a4d6bc8fc3", 5, 10 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "29a0c26e-4f18-48b7-8c41-65be6c318e00", 6, 12 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5d72d1f8-7fa6-427f-a893-e21c5ba26b42", 7, 14 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1b3bdcab-0295-4cb7-a9a3-a579f446f1b8", 4, 8 },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "52cd42dc-8be6-4694-88ca-1d2bf65f228f", 5, 10 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "91b068ed-a4f7-4867-bceb-93a9dba3747e", 6, 12 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "97741ed3-efe8-444c-a78a-0bb00e6f7e90", 7, 14 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8dc05c87-15d2-4d65-a998-f407ab1028b7", 4, 8 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c5d824e4-d62f-495d-b25e-cf72695b91fb", 5, 10 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8b7a2406-6275-45d3-8a3c-f25650c7b3b5", 6, 12 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5da3574a-f5f7-4dd5-adec-55cd5a3b5ccf", 7, 14 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2240a9e7-35e4-4823-9df1-9660ff2e95dd", 4, 8 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4e4be795-2e7a-454d-acea-d639244678c6", 5, 10 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2796b137-adf3-4d20-8522-21306adffa91", 6, 12 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0d350e0d-527d-41a5-8231-a75661742cb4", 7, 14 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3e0ada61-0484-4995-a98a-701379abbf49", 4, 8 },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "53ede54e-9c48-4efb-b575-ab9562c07f43", 5, 10 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bd1f70dc-bade-44ff-9649-15bbd707ca61", 6, 12 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3ae69f86-64c6-4e75-b4d7-439f59dbc56e", 7, 14 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d30597c2-71d1-4c01-a7b8-15d060b0f5ff", 4, 8 },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "295d10a0-36e2-4d9e-88ec-ddf62550f3af", 5, 10 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "95ad281c-a70f-4b03-8cb5-00f261dab657", 6, 12 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c1f0475b-75ed-40ff-b70d-150ff4881296", 7, 14 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "adc0dbe7-1a7d-4171-aa19-d63e89bad5ef", 4, 8 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4ae05198-2b86-46f7-989d-63306a26588c", 5, 10 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d40f27cc-e10e-4510-ab20-f7c876a7e84d", 6, 12 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c33f06f6-dccd-4a7b-b401-96e19233ed6d", 7, 14 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "73fb6e02-8f76-467c-be8b-730de120fcaa", 4, 8 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7bf72b01-4181-4d20-8f3e-f4425066af4c", 5, 10 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1c7a8d1f-018f-4b72-b064-52592e986906", 6, 12 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "658103a5-9f04-48d7-bb83-30d0d1d4da9d", 7, 14 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "735cbada-c75b-4e36-8a40-8bd25c866beb", 4, 8 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7000abee-38c2-4c7d-bf12-1e68c78c574f", 5, 10 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "21d1576b-d782-4a82-b270-73674467c03a", 6, 12 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0a97d147-dfdb-4625-b328-a100c4c3a3bd", 7, 14 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1b5df5d2-68ef-48af-8cfd-a9585f1dd430", 4, 8 },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b23b8936-a8da-4da3-a3f0-a186cb6f4061", 5, 10 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b67197f4-843a-4bd5-a59e-091276467dd5", 6, 12 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "394e0556-42b2-4fad-ab23-7ef83f80b221", 7, 14 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "15aa566e-d21b-40a4-9c69-58a63abbceac", 4, 8 },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0f4a4430-3ec8-4869-b634-a67979291061", 5, 10 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ac491124-bdb7-48bc-bd63-b883a6d7fb91", 6, 12 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e60c0cb5-4f55-4d69-9e2d-fde0a8815e56", 7, 14 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "58ab9a63-05dc-4109-a1e4-ea4b819dfaf0", 4, 8 },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e4292767-9c1b-4e7f-b86d-5241fea0921b", 5, 10 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9de73844-564f-4e7d-afbb-8526acc395f4", 6, 12 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8b1f432d-2cf9-4b87-86c4-d1e09a2ed813", 7, 14 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "68059ef3-a2bd-42b8-8bdb-2b9d41f485fd", 4, 8 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7a17aec7-4e03-40c7-a48c-3316f373dec9", 5, 10 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e6f27327-a3c9-4c8d-9999-2ef9f1ea693b", 6, 12 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "47d9bc2d-62d6-4e46-af5a-8c26b72386f0", 7, 14 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a4355419-7bb1-43b9-8b4a-de308746122b", 4, 8 },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "87426c6a-a795-4e2b-b384-fdf48027d6a9", 5, 10 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2d70df76-6d3e-4fe7-9f23-f963eea9df83", 6, 12 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5b3cf9e7-6445-45fb-8a24-c19a00911b04", 7, 14 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d60f1cf8-1b5f-4784-845f-790206f8f596", 4, 8 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7b65b61b-4f05-4861-b1fd-119699c53253", 5, 10 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9ec843f3-a103-4242-9249-25056ac26862", 6, 12 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3d58d03a-57d5-4982-a8a1-4faf0499ca47", 7, 14 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0731ff52-9a19-4c81-a659-5e6c054ce975", 4, 8 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "98a6c3d4-abdd-4582-86e5-c84a8a76f0be", 5, 10 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3987627a-5b39-4f1b-8490-e7d9b33fb367", 6, 12 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "adb7f2c0-3a98-49d6-b20f-cd430de8cbc0", 7, 14 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e81ceed8-1aa8-4843-8557-136f2440bcd4", 4, 8 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "732fb5e9-4950-49d6-919c-cfcdd55a2b04", 5, 10 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d378ac8d-da93-4f7d-9a5c-c4361db83428", 6, 12 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c827230b-d767-4ba1-a59e-9c05befdf1f1", 7, 14 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7e79a89a-8844-4e1e-9dc3-d717e2f90f27", 4, 8 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f34ba516-96d0-4cda-8471-3eecd3826570", 5, 10 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "405bda34-b910-4f84-b87b-1258ab5723ae", 6, 12 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "aa3e010a-81ca-4c14-baf5-366a0c76ae23", 7, 14 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7577fc12-8599-4803-9b4a-f5359f43293f", 4, 8 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "39670c41-8d59-4ffb-bd17-91d3d891f305", 5, 10 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4a05f36f-19a5-4cd6-98c2-ad70fb9abcfa", 6, 12 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "09e6f252-ab29-4b9b-b102-fd2352854e38", 7, 14 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b41c08d0-f503-4571-a13f-b7edac066b37", 4, 8 },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "43791b31-3e5d-4fc9-b510-7dd7fbf09c54", 5, 10 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0028065d-0b24-49e4-84ff-bf426943a873", 6, 12 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "160d225e-d6af-4946-a5d5-a90e88ee3097", 7, 14 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "598c1c4e-a483-44ea-a414-4a8639810c52", 4, 8 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e98bb19e-feed-446a-939f-e32fb2e878d3", 5, 10 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "52b0597a-4ab8-45d5-b46c-5d541f5688ed", 6, 12 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "faf454d8-c841-4bd1-88af-611f942b5ea9", 7, 14 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3863ca20-3e39-4329-9b2d-60cc0e87e314", 4, 8 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "03fd72e0-5a92-4a81-b47e-8fe78662f87e", 5, 10 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e4b949f2-9eeb-42a9-88f2-79dc48282eda", 6, 12 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "26fb9884-dc18-4cb6-9121-61d35b492a20", 7, 14 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a7acc7c0-0343-4dd2-92b4-457c8efe9dfc", 4, 8 },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0a69b0a4-362d-4733-b7bd-c62683452658", 5, 10 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "885e1aa6-ae82-4014-a411-fc4d83d9d2fd", 6, 12 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2b8659a3-58cb-4e19-ba5e-ee13a5028425", 7, 14 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3d5f8f75-56a7-4636-a19e-c6256970f755", 4, 8 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7e22c4a4-4ece-4944-be10-3a5b71d2b35b", 5, 10 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2029f85d-3f7c-44a2-86c1-7f62a632b296", 6, 12 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7457df02-fed3-499e-afd6-a59757036265", 7, 14 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fe948eec-ec0c-4eb2-8c37-6f7dc77d94c4", 4, 8 },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "656a1319-388c-4d14-b7a1-6524e8ca6a52", 5, 10 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9c5694b7-ca15-47f4-98d2-3dba914682a2", 6, 12 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b53f6b97-96d4-442e-98c7-28ffe64094fe", 7, 14 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "82e3740e-af9f-4b25-afe4-41d21ec6a2d7", 4, 8 },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "70c4c8a0-3352-474a-bbc0-d5af2f3aa241", 5, 10 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "51617cff-07b1-407f-8563-982c12de163c", 6, 12 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b69cdb24-d4e7-4707-bde4-d7eb6cb023c4", 7, 14 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e4a50b15-d49d-4e4a-b351-a6159fd8951e", 4, 8 },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0c248bb4-11b6-4c86-97bf-cb0313468285", 5, 10 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3aeace7c-a34e-438b-8088-3cec8d6684b7", 6, 12 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "094d4b14-9059-4ff2-97f7-48a8d23029df", 7, 14 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "04bb4c0b-db60-4932-91b8-1cf909427932", 4, 8 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9642c5dc-5f09-4077-abc8-896141e13503", 5, 10 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7b479f04-7621-4f43-8152-ce46708d1b68", 6, 12 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c96bd95a-42b3-4d36-a182-7fa0a705d759", 7, 14 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7c4ff908-cf5c-45ad-bdc6-4576c0faf78b", 4, 8 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3ffe9ed4-67d8-48f5-925f-cbc05246a3f5", 5, 10 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f6b564fe-039f-4890-961f-4d9eebea86f6", 6, 12 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6e6e4a86-ee8c-4b9a-a06f-104bf66788d1", 7, 14 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "58266392-c278-43e0-8170-e306b3c2124f", 4, 8 },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9611000c-3bec-4ded-9fb8-d96f26f8f731", 5, 10 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d547e6d5-7cc7-424b-b07b-51285db28412", 6, 12 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a9f7f23b-faa1-4192-bd4f-9a9acbb97814", 7, 14 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "211701f1-ed3f-4767-b6a7-32c749954461", 4, 8 },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f3d30ab7-3bf9-4795-8559-ace9b1776ca0", 5, 10 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bd78be9a-2fa3-4155-9208-0fb45c868241", 6, 12 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "73323f12-676c-4611-9c55-e25e5729faa8", 7, 14 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e42a7947-c957-4a38-8f7b-369aad142b9e", 4, 8 },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6ce04396-ee3d-485c-a4c9-ad4b2fdacb46", 5, 10 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "76a89a7b-9a65-49eb-95e6-4230f6f5c745", 6, 12 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8276e543-eb4a-4a24-aa58-042fa3935746", 7, 14 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "abe4226a-80fb-4aa0-8c4f-194de2397129", 4, 8 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0cb6f0b2-5432-4a88-907e-9ebc2543c6d3", 5, 10 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6786b0ea-8579-404c-9c43-40d8e494f9be", 6, 12 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "40767d71-0825-47d2-a15b-f48ef7535e1a", 7, 14 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e9ff3dba-c538-412b-b47a-451574d9a434", 4, 8 },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "522dbfea-eb4e-401e-afba-4944c2a8cef9", 5, 10 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eb1893fc-7842-4134-a39c-595408676c6e", 6, 12 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "35f82bf4-d10b-43a5-bc47-ac8f4b79147e", 7, 14 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "58b4ff06-7fcb-451b-a05c-d1992443188a", 4, 8 },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9df449a1-8b02-400d-934f-53cb26208c6b", 5, 10 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b0289c4d-d2a6-4b37-8c28-6cb1c0089df7", 6, 12 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4172b3ec-5cdc-44d8-b412-fe7627f8b55d", 7, 14 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f401e2f2-2e34-43b3-8b98-5b2a20ceb725", 4, 8 },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "57d63894-7cdd-44f4-b2aa-e57e46a0c9d2", 5, 10 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e752d7d6-077f-40b9-9725-fa4002811719", 6, 12 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3b9c415c-3e50-4a07-9490-a439eff695f1", 7, 14 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "885a6194-d173-4ec5-8457-086d385d43b7", 4, 8 },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "15cf211a-56ae-4ac2-a89b-462b46e48419", 5, 10 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "02dbde69-0262-4784-9131-0fcc1dafd48f", 6, 12 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "26031dd2-3ec2-492a-bdbd-71ebbf25892c", 7, 14 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "91abf530-f69d-48dc-9014-459db7f483c0", 4, 8 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fc98b4de-a1fb-4caf-a425-883c7da82989", 5, 10 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8367aeb9-9bca-4ee9-b7d9-5c5722b5bb60", 6, 12 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "54cda646-a33a-4eb4-8580-557ad1c5f0f8", 7, 14 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "130de74f-8a29-4c8e-a646-94ec91732149", 4, 8 },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c12df11a-3f47-45fa-bdf1-6845655d15f7", 5, 10 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ecfdb853-1d7b-4066-987c-5cecd9879556", 6, 12 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cb8f389e-c3d9-4b6c-9441-ae07d146bd6b", 7, 14 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "47b965b6-a8f0-468f-a48f-a8903db8bd03", 4, 8 },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0846a379-91c4-4039-bcba-8933233aadcb", 5, 10 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c2cccf1b-fa84-4501-acc4-719e288f610b", 6, 12 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b9a6207f-0f5a-487a-a43d-3f292c30b7b9", 7, 14 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "988734bf-09a3-4fee-9f86-702a5052a604", 4, 8 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "00863b9f-5d05-4f9e-ab95-6bf7bc114e7c", 5, 10 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ab3e84ec-51f7-4f63-8a9a-e7af6ecdc791", 6, 12 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4874e2b7-61c1-4cf4-877f-347cf1fc0b15", 7, 14 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6fd63a20-e108-4bee-a630-373234f99cbe", 4, 8 },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ebafbf77-5295-4d07-9e78-5b04811b266c", 5, 10 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d9505433-ddcf-4bed-ba9f-da89d1cbcaed", 6, 12 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "954dd466-8f03-47fa-b8a2-35e4217eb631", 7, 14 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "75e660bb-fb37-47a3-b458-8cfdbfc69381", 4, 8 },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8a086aef-60d1-47a0-96ad-8f79c23b0aa6", 5, 10 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "975508b7-c5ca-4b1a-9f85-f92548e4c366", 6, 12 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e81cb7ad-92bd-40ec-861a-d519b2b1520f", 7, 14 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "937131c2-1776-4467-bf64-cd2f1214a3b5", 4, 8 },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fcb944d4-6339-4ed2-acf5-66b2ab4bfc8f", 5, 10 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8db03f22-f3a4-4b64-bcf1-983eb60f80f7", 6, 12 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a564cd79-a8ce-433b-bee9-08ec15705958", 7, 14 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "69365244-4eac-48d8-a69f-41f6b09f19aa", 4, 8 },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0b63c806-8f78-418f-8c87-822e4e82d913", 5, 10 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4664d1cb-2e88-448f-8403-82120c84e018", 6, 12 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b98baa5a-223d-43d6-a4d0-e40881cacea3", 7, 14 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b3d15bd4-b934-49b2-b4de-7140d47ba6e7", 4, 8 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8e0520c7-a718-4443-8b5f-3cf0633edb52", 5, 10 },
                    { "56072689-4550-44be-987e-b08667758de4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d2fc09c8-c17e-4a7c-9ad5-1d87db96c916", 6, 12 },
                    { "56072689-4550-44be-987e-b08667758de4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f4c85637-9f1c-43c3-b190-d9fe77866bee", 7, 14 },
                    { "56072689-4550-44be-987e-b08667758de4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0de079bd-dc8f-4473-a7a7-abc9b48d9164", 4, 8 },
                    { "56072689-4550-44be-987e-b08667758de4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cd542df5-d12c-4e56-8145-7db9e9e2f957", 5, 10 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dbb43a76-28c6-4d4f-8e00-e140cfc0bedd", 6, 12 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6beefbcd-0b60-4726-a311-6cbd80a97afc", 7, 14 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "be786422-1737-4feb-8fe5-8714ba44254e", 4, 8 },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9012bbc3-7d2f-4a78-ac31-6a0884f6540d", 5, 10 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e87a5918-0171-422a-a118-67172063c36c", 6, 12 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a083fd8a-5f62-4d28-9841-3bad7d903332", 7, 14 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0432c688-399c-4cd6-82d7-37d3cb6c438f", 4, 8 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5bcf3a4c-e29a-4a50-94e6-8d9836df5c48", 5, 10 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3ea11812-df14-450b-b6a7-e877e29b89cf", 6, 12 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f0fe241e-6edb-47ec-8cde-f0eab046fde6", 7, 14 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6faaf742-3322-4a08-abec-19e09e681b99", 4, 8 },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9d4056bc-2d6d-46a4-8d78-26ce488aadd5", 5, 10 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7be269dc-368e-46e4-a44d-260fc28e6eff", 6, 12 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "66bb68ee-899a-4405-aedb-63bd90301a5f", 7, 14 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3718a276-b85a-422a-98ae-e22f4d19cad4", 4, 8 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "be8bb436-7ce0-46eb-b49d-43696762fda3", 5, 10 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fbf328db-0b57-4bfb-a22f-0f6fddfc0b1f", 6, 12 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3293322b-8c04-4b41-a930-09ee939a4e37", 7, 14 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e4919571-4cd1-4a20-a3f1-101ef1fd367a", 4, 8 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "89586023-77ee-426b-8b14-73bb33667b90", 5, 10 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d59212d6-322b-42fc-a5e5-b9034b61bf75", 6, 12 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7c7a4fc8-d6b3-4ba3-bf4d-8dd714cd8e99", 7, 14 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "98130e30-a5f7-4035-be2c-18bc5eeede28", 4, 8 },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "eb99b9f4-d195-4def-aa5c-ecef11590cef", 5, 10 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "784714cc-c6ae-436c-8f22-0826f0049463", 6, 12 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f4bf6e67-ae93-4a42-888a-6a4af3b079d6", 7, 14 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "70e8a7a4-8314-4fd6-a777-c5bfd3b5e59c", 4, 8 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1f3af202-521d-4dc9-9851-75af36d1b39d", 5, 10 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ec2a46eb-5dfa-4cf0-877e-13114c2556ae", 6, 12 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e95a6706-9b71-418d-8881-985aa387060d", 7, 14 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "659c8b38-dd97-4c0b-8c61-3d17df92c74b", 4, 8 },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cf0ce88e-f9b4-47c4-a219-edbdaaa5ca2f", 5, 10 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f0cc5558-ecd0-4141-9f62-dfb088f73946", 6, 12 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b3c72eee-3d2e-4e8c-8259-8c1548af4fbd", 7, 14 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d1a4764a-1f41-4860-8787-3100ae6428ba", 4, 8 },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2a182fc6-87aa-480f-99fe-9b90cc557f45", 5, 10 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9e86373b-0d0d-448e-aae9-ecb27922dffa", 6, 12 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ae07458f-6802-45b4-bfa8-73f32befb3fa", 7, 14 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "62bee008-9382-443c-9275-2fb4bce18c01", 4, 8 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "207f5287-75ff-4002-9bbe-2c35b2d8f837", 5, 10 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4b093e90-3797-4c69-a4ee-0bf74e9bf833", 6, 12 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3e8a26d7-7104-4bde-86d6-36d355bd037e", 7, 14 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ce7f1fac-ec3c-4b94-98ff-127e669d9cf4", 4, 8 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3d0c1bdf-7f53-4130-b4f0-962a07ed2b81", 5, 10 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9f819e09-6a18-4df9-a4eb-204ffc59bcb9", 6, 12 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "831dd6cb-9ca1-4e57-a679-b12f83f81390", 7, 14 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2debf900-71f0-4567-9e5d-fc506af25b0e", 4, 8 },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5d8ee0d7-c87d-4228-af69-8e106ba47bd9", 5, 10 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "310fc2f9-a8b3-471f-9c23-22c646808acd", 6, 12 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "84aef931-6d73-4ccc-808a-25367d0cdc44", 7, 14 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "89aed1cb-5887-4dac-9bcd-7837a1e3d069", 4, 8 },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "db33ed61-f5ae-47ed-97b9-4957ad3689f9", 5, 10 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "22ce5c8a-1653-4a7f-b23d-7b1f5853be6a", 6, 12 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8d94834b-21cd-42a0-8bbc-8f352b6c8a8c", 7, 14 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1878f2c3-45e6-4e39-a4b9-6b95af9d51a1", 4, 8 },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "98f94eb5-4b7e-488a-86c1-d0afd46b7f55", 5, 10 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "601b7798-73aa-429c-9b0e-a3a2ca670387", 6, 12 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "de205e23-3df5-4627-a16e-f7f3f40a692f", 7, 14 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "47c8a831-a696-4d47-bf8e-b04a8f214dec", 4, 8 },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d7176eb0-f61f-4358-afd6-b735a8c591d9", 5, 10 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6fb1891a-878c-462b-9e8f-746ce5bb59b1", 6, 12 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e09ff9d9-feb7-43bd-a873-3eeb91a49e46", 7, 14 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "2f859699-9974-4b20-8fed-1cbd5a140a4c", 4, 8 },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b6c81542-a687-442c-9616-1b5172c5e090", 5, 10 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "536e2dac-e9cb-430f-b607-32852226b34c", 6, 12 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cf38b67e-1449-4438-9a80-5da142639855", 7, 14 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d4ca97a8-b2dc-44e7-b764-ea499bc260ce", 4, 8 },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dc09837e-5aae-439d-b8ce-4d0e9796533a", 5, 10 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e37ae838-b5ef-48ca-a15a-ae785e2085cc", 6, 12 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cef10204-b32d-44d0-b58a-7a50f61be2e3", 7, 14 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ae35a4c1-8cee-44ea-91cd-80ee52bb4d41", 4, 8 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "75da35aa-67b1-4e7c-b9af-ed2a0435b408", 5, 10 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0a2bfe97-e4de-42b2-83c9-c1a12992ad7d", 6, 12 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4b652ee5-11e0-406a-805b-14a2861f2d58", 7, 14 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c9ba6c7b-d272-4d46-873d-1914855ef9d4", 4, 8 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5b16d3dd-bce5-4075-9d4b-d486d65f64cd", 5, 10 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "99451ac8-3a7c-438f-86a7-9c288f7c240a", 6, 12 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9d47664d-fd6c-4eb3-8307-b59b21099943", 7, 14 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6e016774-11a3-42e9-ba6d-5310b812e1a4", 4, 8 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8c3e09c7-bbb2-4fde-a183-2d36ed0c52b1", 5, 10 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "21fbab02-525d-4759-a31a-a7643134cb2f", 6, 12 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "21b99afe-e372-44ec-bcb1-d226fa51ac10", 7, 14 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5da9c4c4-ba73-4ea1-9521-9000aae782cf", 4, 8 },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "cf26650c-85c4-4e2f-aa87-987f343f632c", 5, 10 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d798c2f7-f9ee-45b6-8af5-65d2335483d9", 6, 12 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "89d56670-a0c0-48a3-8d9b-25392a675f09", 7, 14 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "45085e83-51b9-4a25-ab11-cddac431a9cd", 4, 8 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1a86b5a7-baaf-4eef-85d1-a62f96d4892b", 5, 10 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d3628275-4686-44c8-b60c-ff5c93ab9b14", 6, 12 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e4909176-de42-4e67-a565-60849f15a55c", 7, 14 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cacb91fd-49b9-492c-bcfc-dc992d1c0b1f", 4, 8 },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "11f3560d-545c-4b5d-acdd-4e3c9012210c", 5, 10 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "132756e3-6514-43de-a648-3bc3c16a8dd2", 6, 12 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ce032f82-b825-48c6-ad27-ab1cdd0565d6", 7, 14 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "54fd250b-fe56-4ad3-915d-d5bf9d6bbdc8", 4, 8 },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "42f37bdc-cbcd-42ba-a23e-7b49c3e0e8e6", 5, 10 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8933f7af-9ac4-4b3a-8d9e-38444e5e4e9b", 6, 12 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fe2ef2d0-a530-41ae-8be8-10b925fa4afb", 7, 14 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a7e4cb20-e65a-47ae-98bb-556b5ef886a0", 4, 8 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "55597bcf-f569-4ca2-8630-7ff3ce4fc0a3", 5, 10 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "49a2dc87-19c5-4ded-9502-591a058b623f", 6, 12 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "97018009-2bc5-4022-8642-86f8e734673f", 7, 14 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "19a9da46-d2e2-4248-b2b7-d9cf5397486c", 4, 8 },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a778653f-7081-46eb-835f-b6cab404cbe0", 5, 10 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "10454a75-0e5e-4ebd-871a-dd79adb393e1", 6, 12 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "22487f52-6344-4702-85c0-9fc187510dd9", 7, 14 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c50b3689-f4b5-49a4-a98e-aa8fbf53fac1", 4, 8 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "76a7d439-0c28-46e9-963b-948da53ad636", 5, 10 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "895d5737-b6b4-45ba-b848-4a679733d6a7", 6, 12 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6f7e7516-0aa6-4e6c-9411-3b71a2b810b9", 7, 14 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3a79e389-11d9-45ff-b8f5-59ed457efc7e", 4, 8 },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e280a7e1-e58e-48a3-af1f-6739d79c6bad", 5, 10 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cf253497-0963-4b5f-916a-ee92980dadfa", 6, 12 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0882ba60-52dd-4671-992a-965823faf1d3", 7, 14 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "20b0280b-99cb-4ca9-8451-f8f1541c5a79", 4, 8 },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dbc13a3a-8f4b-4468-aee9-6e80fb57e4e5", 5, 10 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dae96dab-5ce9-4493-9762-84ff872f6601", 6, 12 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5c55419c-ff10-410d-ac0b-900d9f952f85", 7, 14 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "74e65835-8484-4490-b893-a4a2e9a38468", 4, 8 },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fcf38e1f-9e9e-43d9-be06-6bd0970eba4a", 5, 10 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "55636395-75ba-49d2-9694-e309faf55791", 6, 12 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bdbde548-f473-441f-8570-c35863efadf8", 7, 14 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dd26a416-1097-487b-83dc-0a272ef5d925", 4, 8 },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3a2632f7-7c7b-448a-8fa7-558cea023069", 5, 10 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "afd5cfb1-da42-4845-8161-8a8d3591bf7e", 6, 12 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8ab92882-e4ed-4abc-a8e9-ab88f9850067", 7, 14 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5e7dd790-e355-4df3-9ef5-9bb45fa4de40", 4, 8 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f12bcd18-5627-4f2e-a3bd-0e678e16bbe3", 5, 10 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "74a207e8-6173-4c93-8451-da535b0235d7", 6, 12 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1ea07de6-dc8f-47af-87a8-e5d846a30182", 7, 14 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f0d4b5bb-e9ac-4704-ab9d-e1a014bbf1e5", 4, 8 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "244082be-7dba-4e5a-8dce-44c39e4b7b56", 5, 10 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4a70c5b9-ead1-49c4-a280-4c94f9826165", 6, 12 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e75cd827-86f0-413c-b8e2-f3d1da1127b4", 7, 14 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "00ca8d65-60d1-4083-acab-65f370e78c6a", 4, 8 },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9764ba97-f8a7-479c-9106-a89246a7df12", 5, 10 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8236045d-c3d0-45eb-8718-0a025941365c", 6, 12 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d626517b-5da9-48a6-97d5-78530bfad2bb", 7, 14 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4ba0d532-d5b8-450f-891e-aa82315b5ebc", 4, 8 },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c3d71755-2e0d-4dda-a762-f136a1dd65f6", 5, 10 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6f4bef6e-2454-4ace-b7f6-94a0e74f1dc5", 6, 12 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fd6889b6-4729-4f44-a25f-52ecce498b9b", 7, 14 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4e288d0d-e243-4388-85f0-890a03c83d5d", 4, 8 },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "94f3fa43-1901-4621-bca0-5864d94d0acd", 5, 10 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ee8891b6-01fd-4824-a746-ab1426fec4ce", 6, 12 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c7ba4d06-6747-48eb-a8f0-b4796afff41e", 7, 14 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "52b81d7d-7d67-4819-a5b6-95bac1e8ff27", 4, 8 },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ef42ab1e-b3d7-4118-bd58-7bfb5d4c8ffa", 5, 10 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "524a1e2e-5c48-4aef-a30c-2b7ce72233ea", 6, 12 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bc417f4a-aeb6-4ddc-acc2-735657dad0e0", 7, 14 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "be1480b6-2397-40c3-8800-a7af5cdd94a9", 4, 8 },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1e91b064-3621-483e-bd69-22e366371993", 5, 10 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "67563c16-bcfd-485e-ae39-fe52a1bfa25f", 6, 12 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9bc0979c-e375-48f0-aad1-71c51e1e9a4f", 7, 14 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6058fdde-fff3-4407-b715-6725b7b68738", 4, 8 },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "90e5ebf1-87cf-4c98-8765-3a86323a4af1", 5, 10 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "386b40c5-a706-46a0-b0ee-4678295a71af", 6, 12 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "485fe077-e783-4104-8088-64cc5ee8a694", 7, 14 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c5b1e2ce-f688-4a00-9cc9-c540c8fd6b23", 4, 8 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2857a79f-f94d-43f8-8757-d1440bbfebd5", 5, 10 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "923ad665-9420-4afc-babe-a6758e2b4405", 6, 12 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ecdf78d5-2f95-42df-a774-fbfc1e90724c", 7, 14 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6731ef65-df30-4f1a-9276-6877aa5484c3", 4, 8 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ee413446-c951-47cb-99bf-aa3ca34c0334", 5, 10 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b0cce23d-ab0c-4dba-b564-d09ecce9ca29", 6, 12 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9d3c16ea-e249-46b7-9e15-27f05875dd0d", 7, 14 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "06f28427-4ace-401e-a8d0-5ebb8b725aaf", 4, 8 },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3c8746b6-75d9-4897-beb9-9d0c063f92d2", 5, 10 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ec68b930-0383-4d75-8ee6-6f4a623e1efd", 6, 12 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dab15ebf-05e6-4304-a615-4731442bcabc", 7, 14 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d713adb4-ed5f-47ad-b485-2b8398dc00e2", 4, 8 },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "004d86c5-4944-45df-be2a-c3d6298684b2", 5, 10 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "96312ee0-347f-4531-886a-501e5562c92b", 6, 12 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2787586e-dcdf-47f7-ad31-7ca8e48053cf", 7, 14 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0a6a5f76-ddf4-4bf3-a60c-c0a0ee49e503", 4, 8 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0661de41-120a-443b-9535-51f2e06f18f0", 5, 10 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6606cbad-dc9a-4942-82e4-cbf1c94baef6", 6, 12 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b981e6b7-fe2d-4611-881e-caf41a90f3dd", 7, 14 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c5fdc26b-637a-4be8-b64e-f5dbefd10789", 4, 8 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ac08880a-4dc3-4154-8b96-b0cfa8384fd0", 5, 10 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d1e1c35a-49f4-49aa-85f9-67b38cd42e60", 6, 12 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f53d8392-76c2-41ad-970b-e0c293ac0181", 7, 14 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "626075c8-fdc0-40c2-9468-2a3772c7f8e2", 4, 8 },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "73580da8-414f-4d79-8879-99c425bb17c3", 5, 10 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fadc8cf9-f70c-4ba2-82a4-2fcb4d24ab04", 6, 12 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3c0ec7ff-2e3a-410c-865c-98e6aa5c07ee", 7, 14 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c786090f-9271-48c6-9129-52ec7a274821", 4, 8 },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "497e2a53-e155-4608-9fec-1da0709fef39", 5, 10 },
                    { "78157107-23fa-4638-bd17-38187695312c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6a9e8239-89c4-4216-ae7e-b331a279a8b2", 6, 12 },
                    { "78157107-23fa-4638-bd17-38187695312c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b67761b0-283e-43c4-944e-7dcaa1ae0058", 7, 14 },
                    { "78157107-23fa-4638-bd17-38187695312c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e0926743-ff9d-45d1-8853-600bfc9ea60b", 4, 8 },
                    { "78157107-23fa-4638-bd17-38187695312c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "513dce07-0a33-4711-8a17-0c3886ac951a", 5, 10 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "959006ee-56ca-48ec-929e-62cdeafa90e5", 6, 12 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "872ab8ef-6e96-453c-ab60-4281d6b7ddce", 7, 14 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a6db77ac-b0e2-4ff7-b2a6-5b7b9bc4f794", 4, 8 },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9383213f-6fd3-4494-9cbb-58765b11cab6", 5, 10 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fd529116-787f-4b98-b5ff-b9c96d8dc418", 6, 12 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "24349f92-df59-425f-8154-2f1af3864435", 7, 14 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4693c44a-e37a-4a85-abd7-9f78b9699663", 4, 8 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "fa89dc2d-f586-473d-a54c-a07d0f3673a3", 5, 10 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "85882484-95e3-4570-88d1-393cca850f5c", 6, 12 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8b1227e1-f38a-4e31-8829-5aeab0a8f7a4", 7, 14 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b7f3d4ef-083a-4b57-b22f-3affcffb1f11", 4, 8 },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d5bd7a2c-b41d-4e53-8996-8b275c00f63a", 5, 10 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b3332576-b99e-44a2-b00b-08bab23bbb59", 6, 12 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6f360f88-877a-4643-97dd-f2e9cabd2d61", 7, 14 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "37b72580-0f3c-46f1-9688-fe4b292782fc", 4, 8 },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "528c7926-2d72-44ad-8684-1cd783f042cd", 5, 10 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "46214591-69d0-4a65-b62c-61284beb4cb8", 6, 12 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "41074381-50b5-4a6b-992c-c613080904f3", 7, 14 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "269fad15-90c1-44ab-b963-aa04c15e0b6a", 4, 8 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f0b2fcdc-50d2-44a1-b4ff-bef013f90782", 5, 10 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7b5ac282-4333-4ac5-9393-48169e98eaf8", 6, 12 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b81b7da9-e516-4fff-9e7b-5589bc8edb9a", 7, 14 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0b047096-434e-4cab-89fa-3367baca2f45", 4, 8 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a3c36b13-b2ea-41df-983e-39af61f86269", 5, 10 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dfcc1351-afb2-4286-b52b-498001687606", 6, 12 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "285eebeb-82b2-48e9-911a-193fa0be2449", 7, 14 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3eb8c9fe-cc74-4735-a5b4-45f3df32bfa1", 4, 8 },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b82116d3-b29b-4c5d-9cb0-17420cf00d4f", 5, 10 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "26d695b0-568b-4894-8183-ce47171af314", 6, 12 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "17bb8150-9e1e-4954-bca8-af349765e2b2", 7, 14 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "72d636e7-87c3-4e12-8038-0c534582f729", 4, 8 },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "35ffd1b2-6c18-4624-8347-dfa4a4c5acc9", 5, 10 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3c6a9a5d-9e7f-4234-9ef6-633d6fce848c", 6, 12 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6a232c3b-cc76-44b1-8999-f9e331a59d14", 7, 14 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7b5eaa85-5c36-4f7b-8b35-932ab17d30a3", 4, 8 },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f902bfb3-e28a-4e6b-953c-7cc7738ad63d", 5, 10 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fa2b567c-b38b-4e60-8b99-b36e12f2ff70", 6, 12 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ac789c13-c6d9-4bb1-8c3a-4a2a953e9b4b", 7, 14 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "20db595b-c255-4aa7-9f5d-5a0537be6c36", 4, 8 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b28adc48-1646-4c97-a916-925250b7c3dd", 5, 10 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e1e06c16-b7cb-4240-bc49-6b13b1ba64d9", 6, 12 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "08051ce7-e4f8-4282-bacc-a95cb7c40dc8", 7, 14 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d606ff7e-696b-4f05-b2cb-8c79bae8baaa", 4, 8 },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c9483f2e-7147-429c-bba0-89f535a71c11", 5, 10 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4120bb77-a688-44b7-b1d2-adb09275a424", 6, 12 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f3c913f4-70cc-4cc4-92f9-eebbe5bd2873", 7, 14 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9424a246-71d9-41a8-ad5a-339fa5544eb3", 4, 8 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d15714c0-a768-4247-ae15-8904dae5813d", 5, 10 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f7a35a72-c873-455f-a669-d73654ddfde9", 6, 12 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "54a7bba8-741d-4030-841a-7e5c211f007a", 7, 14 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3dcabd8b-2078-4d53-909a-5acad82da352", 4, 8 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "73a4abec-8f73-4802-980f-eae96124eb9d", 5, 10 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "48067d5b-7ac4-444b-84db-394b034221a6", 6, 12 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7511509a-0de4-4cd1-b5f5-f0e6c496d19c", 7, 14 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d48e59f0-b425-42b7-a398-5b4b006e7d86", 4, 8 },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6fbc963f-da4c-4841-a877-272e38119a09", 5, 10 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "e65cc929-df08-4948-a1f8-37a414c7c2eb", 6, 12 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "351e7887-5a18-4deb-ab09-fe49f1cc5123", 7, 14 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f259c289-1179-4a9a-a5df-26e8c7a561c7", 4, 8 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "69ed79bf-f973-476e-a77a-24b5068b47a9", 5, 10 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "03794f90-6a34-4c73-ac8b-441106359be0", 6, 12 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d91a6323-6c13-4acf-8fcc-fda0119db2c9", 7, 14 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "889c6ee9-99b0-4c72-87e6-fe11009b6875", 4, 8 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "58dd1fe5-54b5-4352-aeb8-886428064c3e", 5, 10 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7bbdc465-de2d-46c5-872f-86fe28111e0c", 6, 12 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c12726c2-c9c3-4ed9-af84-6f39566f3ff0", 7, 14 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6230deff-1bb7-4524-92fe-478e8c7369f2", 4, 8 },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7a9b1ef9-4bea-4662-95de-20dc4a67a870", 5, 10 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "97064d6c-647a-4ea5-84a9-ca49177e3ab2", 6, 12 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4cc2ac1c-441d-46c1-ba40-96bbdc8074be", 7, 14 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f78bf1d5-d076-45ec-abe2-1db8093064ed", 4, 8 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "81cfd7f2-6b41-4133-879f-5738f768fa0c", 5, 10 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "83b03d11-62b9-4062-8165-a84f6911ae1a", 6, 12 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d30bb39b-e02f-4958-a097-66c791b81ac0", 7, 14 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "009264ae-832b-4206-a48e-864d25457961", 4, 8 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "92dc55a1-da27-4cfb-948f-e0b3de71b21b", 5, 10 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0cfa5f1b-9a49-420d-83fb-ef8ca03ce765", 6, 12 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fe403ffb-b05b-43b7-b158-0f4aaa0ac017", 7, 14 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "df527079-b219-4c55-9f74-8e69d0e43aed", 4, 8 },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6da71a05-e4f1-48d4-9803-2e127c974df9", 5, 10 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "937b22de-5f06-4879-9b5e-3fb2ac736a50", 6, 12 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "3d1a4847-8765-4b74-a744-70e3fa36ba59", 7, 14 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e87c99f9-d8f5-406d-ba80-84b0a70adf5c", 4, 8 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aecc2a9f-8111-4426-9b8d-a5f610416510", 5, 10 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4f47516e-c9b0-4a53-8eaf-86343a1dc8ae", 6, 12 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f7d48178-097a-404c-8e61-ecf0d6328837", 7, 14 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "aa0367b0-3af6-4586-9b1b-bf570f32a689", 4, 8 },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "13278afa-083c-44bb-90a7-36af273db6d1", 5, 10 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b9c454bb-01b8-424f-be0a-7de2ea441bae", 6, 12 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "60c3d008-fdca-4966-9154-f199fe8601c9", 7, 14 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c83ba92b-20d1-40b9-9d7e-23c0a78524ba", 4, 8 },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "90bc808c-1e64-40ed-97cd-9dfda90b06a4", 5, 10 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "57487547-bc64-4ba7-b167-29a68a070ff8", 6, 12 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "997baaeb-9c2c-4c86-ae13-83fd9d6b91b5", 7, 14 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "de3c98c9-eb08-433f-a828-47eaa10e5675", 4, 8 },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c4d01f3d-3caa-4fe6-bf6f-25d751c23d84", 5, 10 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "01e81bb6-24b0-40de-8b23-53b9764b6832", 6, 12 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bd43f4fd-981f-4787-9752-d793876e5871", 7, 14 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "77f7b5f5-9e7d-4ebf-8660-6a82455cc492", 4, 8 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dfb9aa5b-84e0-4ec0-9c85-d5b0bee142fa", 5, 10 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bd5e3d07-13ee-4ed4-9a91-b6b47cfc8bc3", 6, 12 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "01614290-c05b-4091-a56e-978b4f3b99a8", 7, 14 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "db0c920a-4e24-49f1-956b-c8c4949e9e86", 4, 8 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f0d711b6-6049-48b2-9c41-a30f3ef03c70", 5, 10 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7943056b-0d42-43e9-aa47-cf400acf8784", 6, 12 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2f8462e8-e324-4bf2-934d-57c6a437a558", 7, 14 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "25e3cb8e-99fb-4183-8b55-a1633b4ea818", 4, 8 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4a8d7166-b178-450a-a7a4-361fb4308826", 5, 10 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8949d0ab-0caa-48fd-a951-1824c6212dc5", 6, 12 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "518546a8-c860-4faf-8417-114746ecea77", 7, 14 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "02d43c93-725c-487f-8fe3-ecd6984b1cdf", 4, 8 },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "760d160a-32d2-428a-889e-bf3bc05fa826", 5, 10 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "63528d4e-d1b8-4feb-8a78-19676d56633a", 6, 12 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ec20dc74-b09b-49cb-8dad-840698d1ce9c", 7, 14 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "824c8116-d874-4013-89fe-b2e39408ab32", 4, 8 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "82bc00f0-0558-4840-9882-5a924b68bcad", 5, 10 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b71c176c-bb1a-4ad7-b1ab-a487c8b9fa73", 6, 12 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "94036a57-99b9-48e7-b98e-bcbefbd54f8e", 7, 14 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a0204e10-766b-47e4-b1fa-90d8ddb45eab", 4, 8 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c0af0aa7-37ff-4a31-8e85-366b4c5c4047", 5, 10 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "09f4c571-5fb2-4d71-bbfa-a5bc94a657d8", 6, 12 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "51cea249-981f-4c01-b778-accb26d4b198", 7, 14 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c6cbfc67-9169-43e6-becd-80ecba6b1be5", 4, 8 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e9e81022-d30a-421e-89ff-b188d40d5791", 5, 10 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ae666a66-3518-4b04-be47-94ddd584a06f", 6, 12 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1e3d2299-f568-42dc-9c05-ff1e0d53b4b5", 7, 14 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bc5e5b53-6792-43d6-aedf-e4101e6889c7", 4, 8 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "68eee5de-78a0-4d5f-a644-f55e01079061", 5, 10 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "35fe002d-078a-4a7a-9bf3-837a66f48eff", 6, 12 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "df746ee9-a55f-40c0-9d0b-9efcecfc97f5", 7, 14 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "750ab6e5-2357-47c7-89c2-30161969e71d", 4, 8 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "64b8b7a1-c812-4b83-8e61-356885d32aac", 5, 10 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0ac77783-f09a-4a43-a29c-759c5136bd76", 6, 12 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0c6895be-9c75-4a16-86da-e0c4031f9f22", 7, 14 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "056cb3b8-30f9-40e5-8a0e-ae512afd5c91", 4, 8 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "62ceb992-f2ca-4e4f-8dc6-caa5d549b32d", 5, 10 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ae73beb4-8554-47a4-b8e2-12c04af01feb", 6, 12 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f545a783-c5c6-471d-9953-e16f3603fb8b", 7, 14 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "527e8df0-1ed8-4df0-9e93-54d9a530ba71", 4, 8 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "555e0ee0-05e1-4b38-83b8-b49cef7e6552", 5, 10 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "82e3e0c7-3515-41a9-97e1-30f0d08a9f1e", 6, 12 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6d512222-b05f-46c4-9596-293b9409b552", 7, 14 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6af1764d-72da-4942-8875-c7b75fa82b14", 4, 8 },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c18e004e-2e57-49bc-a012-450630973a5b", 5, 10 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cd8b0611-044f-4209-8aa5-b381d5020fe6", 6, 12 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b5b51b7d-1450-49ff-808a-8bb362af31fa", 7, 14 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bba07cfd-af5c-477e-99c3-1de77408b823", 4, 8 },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b644c787-cc32-47ca-af1a-ff43861feee0", 5, 10 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8faa96b3-57e7-4fc9-9e48-c86f890e4088", 6, 12 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1c731618-64bf-4206-9933-be2ef731f212", 7, 14 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8c02c378-ede0-428d-aa50-f556d554001e", 4, 8 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5873157e-f743-49d9-8ad6-d5f90fed823d", 5, 10 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7c8a95b1-0b90-4178-a2b9-fa0471a2315a", 6, 12 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "abe3e083-8ae2-45fa-b1f4-035dc05f673d", 7, 14 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "61a36a3c-48d5-4c0a-9f35-455ac9d3a728", 4, 8 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d01dc694-f089-4b46-b8f1-d78ac8168bf8", 5, 10 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a3746ca6-b6f7-4e08-b786-5d62d56e9387", 6, 12 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1f4126d0-ba57-4dfe-a50b-f33df5b39283", 7, 14 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "02ec8aa2-e384-443e-bb54-3908feb781ad", 4, 8 },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dc715480-624e-4cc4-b585-acee2e0882b2", 5, 10 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "28419fdf-e24f-4cf7-bd89-379d6640a73a", 6, 12 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "40ed1b41-e9f0-42da-9c55-bbd1f7e0994c", 7, 14 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9bc54879-604b-4cfc-9fa3-1bf81bfefd0c", 4, 8 },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "51a317dd-baed-493b-8d02-af0009bbee28", 5, 10 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "30200a1e-b8c6-4e49-840a-ba02833de994", 6, 12 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "36bbd691-b55a-4da2-ad10-1ad9b7b4462b", 7, 14 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0d130865-9de9-4939-b9b9-61ad045ef680", 4, 8 },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4d849f99-f9b4-4bb1-92e7-c314972c1374", 5, 10 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fe17a8ef-a4b5-4033-a689-c1209174932e", 6, 12 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "983b9db2-7dd3-4751-a228-234e8abd7b98", 7, 14 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "10a16b1f-83ca-418e-ad7b-661eb88bde53", 4, 8 },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6b9ad3ad-ec8e-4951-91e1-c6dbe95cdd06", 5, 10 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0a476b28-8206-4e1c-b99f-7b5966c99acb", 6, 12 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2a6e5cf5-2358-4dfd-9acd-52149aa990d4", 7, 14 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c50986a3-22d6-4d71-9a09-7ee62b68663a", 4, 8 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b2b3e7ca-f29e-49e1-a56d-f7ed245330a2", 5, 10 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c145f726-c825-4ee9-ad12-f7d05034f41f", 6, 12 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0fb08ed6-2e9d-4623-b7b0-162fcf344d5c", 7, 14 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "63c35c38-673f-4d93-a7b7-8955c1680ef1", 4, 8 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "655a988b-946a-4e04-9332-861ff0862fe9", 5, 10 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0d906877-de3e-44bc-82de-3b8708686fbe", 6, 12 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "16c059f8-a58d-4ae7-9220-141b6d5642ee", 7, 14 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "40ecdb55-e1a4-41e3-9b31-b92775a84c27", 4, 8 },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c52dcab0-12e5-47fb-ba04-3921af4a7bf9", 5, 10 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b00a21d7-3f41-4bf7-ada0-6d17aab63d6b", 6, 12 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a9250d91-d5a1-4628-a04e-4864e71c2c01", 7, 14 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1f202589-df00-4d60-853e-0358821a3b1e", 4, 8 },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3deef780-9e8d-4874-9e02-9337e692eb40", 5, 10 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "29db2a2d-070e-4d4b-8b0f-6106b7c62b21", 6, 12 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "58a4ce7a-4ef1-4da9-a165-95d787629f5d", 7, 14 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "64bb8a7a-c5f6-4d95-a687-e1247f33e767", 4, 8 },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e152b404-ec38-4440-8902-56ed35225cab", 5, 10 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "05d4b2cb-a8b5-4394-9f92-bc3d9c53d4ae", 6, 12 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2098869a-8c1d-4f5a-8887-d6d8773a60f0", 7, 14 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7c19b312-7bf6-4b72-a37e-9ed37087523f", 4, 8 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b308a8af-826d-48b4-9c4e-b9d1936d86ed", 5, 10 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8bc27bf6-74ae-40f1-a384-dc243c62c33d", 6, 12 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b9bc5c16-4830-49e1-955e-478847d29d69", 7, 14 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6686f6fe-5292-45dc-8ea6-62158f32f4cb", 4, 8 },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b60e5c1c-0cfe-4227-9b83-10a360754d87", 5, 10 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8872d840-38e7-4257-9516-a575ea2e11a1", 6, 12 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0a0b1c30-cccb-49d2-a291-18c70a3515c5", 7, 14 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9e2b9609-bfa5-42ec-af5e-e0ea8fdc7dd2", 4, 8 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "06fb8a89-5c4a-4643-ad18-c5e400f9ac03", 5, 10 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eebc1f8b-a2b0-4d9e-a50a-52ff681e96ac", 6, 12 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dccad5bb-4efe-430e-accd-5c72950dda35", 7, 14 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "64be1541-53fb-4c48-a550-1263c6f24aea", 4, 8 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "75af8cbe-d9b7-496b-891a-f545e48a6c4c", 5, 10 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1a9e6ad5-f336-4c78-8bd9-d1e936c72a90", 6, 12 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "29ffb384-87ac-49d8-8281-79d92801b9ff", 7, 14 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1879c612-f623-4488-97c1-f581c0dde83a", 4, 8 },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "57b265a6-ecdf-411e-98c6-281669962366", 5, 10 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bf5bc8f4-a2f5-4796-9a41-7bf8b2bc5280", 6, 12 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4edf871a-695e-4fa3-9c73-c77621136e33", 7, 14 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b7a8d7f5-7c19-47aa-a1cc-1414c0c0a272", 4, 8 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3795875d-a21b-409a-a8f4-ce0af7a83087", 5, 10 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1e87e7c7-8d65-448d-bc5e-23f2804f5f1b", 6, 12 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c09fd09e-a9c0-4863-880c-07af22061ab8", 7, 14 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "617c87d2-49cb-4356-9562-bb428f94a9e2", 4, 8 },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "7e4dbc30-8d5b-410f-8041-38531fad284b", 5, 10 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "72f62256-0538-46ab-91e2-ee989cb4d5d2", 6, 12 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8cd3222e-71ba-4b36-9e32-9c3d119352b7", 7, 14 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f3a69497-c455-404e-af00-b6936f0c4a8b", 4, 8 },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0450d5d0-74c6-4c0b-b2df-7f8f023947d9", 5, 10 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bc294f6b-4636-4819-a4d1-73a7ab04fe08", 6, 12 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7bf7f3d8-475a-4d96-8761-d9d9d9423bdb", 7, 14 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cab722ed-4267-4542-8fb1-dbb1846195f4", 4, 8 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b146b546-47b1-42df-9362-f34dba5d382e", 5, 10 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "91e6f06c-b22e-4330-a758-bdc7caf9a529", 6, 12 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "429c4db8-e1bb-4b67-b9c2-83743a9be4de", 7, 14 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1b72e523-09fc-479e-aa9e-df7801e1c804", 4, 8 },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "14d19a85-c886-4b27-ab4d-32d49a8093f8", 5, 10 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "027d7eee-b105-4477-bbc4-96421b1c9f1d", 6, 12 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a3ba7d36-21a1-49e0-8081-c7b87ca41c9e", 7, 14 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e623327f-4729-4883-b1d4-1eb26421c527", 4, 8 },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a0e7d2e2-c131-43ad-9c1d-f42cb513027d", 5, 10 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "becaec95-c3f0-4522-9042-e480cfd15691", 6, 12 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "71c01afc-2472-40a5-acfa-fa2867816826", 7, 14 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3601f2b8-bb5b-4759-9a4d-32c24121985b", 4, 8 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1c63654a-e0a4-41ce-8108-ce92489a006c", 5, 10 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d2abdede-69a7-4d09-a377-8fd4e9d8284b", 6, 12 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "54401142-d056-4f05-9180-bdd503627e89", 7, 14 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1f3ffc60-de4a-4e37-8a17-e4da2844c3f8", 4, 8 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1cb82cbf-7622-455a-bf8b-a58f5c9c5e74", 5, 10 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ced6beea-777e-4acb-adac-04d2d5e73c1e", 6, 12 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8092d86a-eb9f-4599-8ea9-c06890d3d7c7", 7, 14 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9dce37b6-e106-4dbb-9d68-4b084f8b27fe", 4, 8 },
                    { "b5b67003-636d-425d-9784-45d374db713c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4d626b2c-3efa-47b9-9536-ce0b7fa83253", 5, 10 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0869b8e0-3070-4d3b-a035-839524b5cb5a", 6, 12 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d3b9ff98-c0c8-4ac7-ad0d-fbb83a0f86ff", 7, 14 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f16260ea-7f02-4c74-a203-f9e1d1077f02", 4, 8 },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6c43a64c-4bc3-42ac-8a47-2c8848a0058b", 5, 10 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7723ee33-8676-4329-800f-a0c8497f4a42", 6, 12 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "623b1f70-0ba0-4d34-838c-d13bc010f402", 7, 14 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f0c2ae52-001d-4526-b097-f9ba0c618bfe", 4, 8 },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8bd6c55d-3599-4b26-a8f5-316d44300f8c", 5, 10 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d86c321d-0c45-467d-ad90-473d8b0780f0", 6, 12 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2148bdc6-0f44-4cf4-b56c-b346d321ea2e", 7, 14 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e1913559-cd1b-4686-ba5c-a0d832227235", 4, 8 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "3d053a83-5148-44ab-bdbd-bef3187bad33", 5, 10 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5e64f05f-95e4-4eac-83d6-abca35e95f34", 6, 12 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4504c789-9e05-41d8-a8ca-8c00059e8a96", 7, 14 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c79b09f3-c53d-4683-b10b-1c1b68fffb42", 4, 8 },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "35d72c89-f2b3-4ad0-bee8-55c216cbd104", 5, 10 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "19dd7eb4-032d-4003-8c28-65614a4fc6fc", 6, 12 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0668b3e2-2f72-42f9-855e-aa16e4ac526d", 7, 14 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "08600bc8-e99d-4458-9bdd-03e44fe55b58", 4, 8 },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6ba0bda5-e012-422e-abac-bf10677b1120", 5, 10 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ec76c2fe-ab04-41b6-9168-f1ef4488d0a5", 6, 12 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "24baabf6-eb12-4a9c-b406-57b47d81e2b8", 7, 14 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e96f6bc1-89ad-47d9-bcc8-f78b14cee1a4", 4, 8 },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8ab125ee-e1ef-4418-8403-bcaec61723e3", 5, 10 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4f0891d7-6525-4059-9151-fa76b1349685", 6, 12 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0eca5417-f288-4ffa-801f-42e602be1d45", 7, 14 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b263ada5-dfb3-4962-bc70-0d3e2640a62f", 4, 8 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "119fc198-3abe-47c5-bc64-a60c8edd6670", 5, 10 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "dbbc8009-3b85-471c-b5a2-a698d43d809e", 6, 12 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "be5045c2-59d2-4a9f-90d2-7074826465bd", 7, 14 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3a0fdd79-9fa6-4b4d-a7a9-20811bf219e1", 4, 8 },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "009956e4-c6c3-4569-ae17-5bc9727f2ab6", 5, 10 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "64bf87c7-0336-43be-9a55-adfc330a26df", 6, 12 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0553db05-06c5-45a6-a95a-6e13052024a5", 7, 14 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8bd65fa7-9647-43ae-9a39-a343a69a8695", 4, 8 },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "49db4d4e-543b-41c3-9903-94e8523313c1", 5, 10 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "07b18923-8e32-401a-80ce-cc88a29a41ac", 6, 12 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b2335f0b-62ba-4fd2-afca-e43622a5c569", 7, 14 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "581d512b-8bfb-4e63-80f8-a5d074fa4ef9", 4, 8 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5cc62cf0-1cb5-456a-bfbe-2802c70e746f", 5, 10 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "42562be3-0899-428c-bb08-f42c4b51a1d9", 6, 12 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "95c9cbfe-027b-4ae8-b184-a4dd0f52dfc4", 7, 14 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "713ab3aa-4672-4167-8e17-8689258d5327", 4, 8 },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "29632859-ac59-4d70-908c-03caafcf89da", 5, 10 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b36d1310-1722-426c-aed8-8419e21c2127", 6, 12 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "277eaa59-b67d-43fe-b22f-192a9df6c3a4", 7, 14 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "64851dc3-ed45-485e-8d13-45f2f22b1901", 4, 8 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c329657a-5575-4f0d-88a5-8ac9eb51e778", 5, 10 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d6e0a4ae-01d1-45c9-bc63-c5905d7c41a7", 6, 12 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6fbbbfda-1215-4ed0-b85b-64d6999ac8b1", 7, 14 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "169480d4-e3f9-4c17-ae83-2db74ea0f45a", 4, 8 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "69cb8360-9a9a-4156-9012-cdb06f93df7c", 5, 10 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3291c045-9c32-4e4f-9c47-b8e6b34c6085", 6, 12 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "416c0a20-780c-4fe2-b398-764b9792039b", 7, 14 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0120d0fe-a06f-42be-b277-095fa8fb0e78", 4, 8 },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "5f9b78a6-6385-42c0-8d03-f3d526bd7d6a", 5, 10 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4ea31b24-d2b9-4d62-9e02-e6fa494e859b", 6, 12 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "269bd34e-a3e2-4401-a1ef-203e7cbcdab9", 7, 14 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "825ff338-e173-441e-a122-65fc7a88844f", 4, 8 },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9f544bcb-6634-4573-b676-aa8c83ef3287", 5, 10 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d025de4a-5699-45cb-ac4b-d54e4426490f", 6, 12 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "35d09379-6290-4d0d-a2c8-75d68312d060", 7, 14 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6587da01-5eed-483e-bcf3-102f121f785f", 4, 8 },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "124e8566-553e-415e-8481-7f47dd24c0f7", 5, 10 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "45c08576-d24e-427e-b90b-118b07660673", 6, 12 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "281f691d-e80e-4751-87df-19b035c7aac5", 7, 14 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "0b573007-2944-48c7-b212-d2f691fe4809", 4, 8 },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4b95ac31-18a5-4a1d-b8ce-125d917b537f", 5, 10 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "28afc87b-da3f-454f-8695-35a5f864ead2", 6, 12 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d7bcfa34-9072-4e14-bd17-b5a3b26f9f22", 7, 14 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a6524ee8-938e-4467-87d6-53b16d8412e7", 4, 8 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4a2ff42b-80e4-4f91-98a2-e7873cc3683d", 5, 10 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "04669396-056a-46ce-a0c6-91fb036a8f2d", 6, 12 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "93ee94b3-71a2-42f2-8f70-3bfc98afda6a", 7, 14 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "1cb84863-b83f-453e-b700-5ca704820ece", 4, 8 },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e9695034-a39d-4fc4-b3c1-c224c55a4eaf", 5, 10 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8f8a5aba-380f-4f07-9e8d-59a90c175d02", 6, 12 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4b1ef188-560e-4a7f-9cbc-d5ca4a56614e", 7, 14 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7b89aefe-2a4e-46e4-b650-5d4630d6f9df", 4, 8 },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "74031716-eafc-4bab-9abd-3e5e8a038b1b", 5, 10 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "398da5c8-7e68-45f4-8009-cae65344a404", 6, 12 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "febcfb21-6c73-4b0e-ab6f-e3e8364f339e", 7, 14 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "02479cf4-712b-4e2a-b889-1d06e873e4b2", 4, 8 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "029def52-185c-4639-af29-0433e4fc6980", 5, 10 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "82714df4-680c-4a08-8e82-108f556121d5", 6, 12 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6d955ea2-f445-4f57-97ea-cb50e6ef9fcc", 7, 14 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "fd997460-c744-4d79-865b-10a4efb53771", 4, 8 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4be0a7a8-b28c-4471-9a99-cf2122145aae", 5, 10 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "4bbc5374-667d-445c-8818-eb41d0ccd6dd", 6, 12 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "8f3c9856-ef96-4e58-8a9b-899270b6fd60", 7, 14 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a113ef88-8f65-4dc0-9b8e-43876d9ce9c0", 4, 8 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e640323c-38f3-4c9b-b43c-c8129ec422a1", 5, 10 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0537364f-9230-4816-ae99-f6f16819ea29", 6, 12 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ed210862-8fd4-48c2-9272-c4a3e4b3cbe1", 7, 14 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b58431ee-9524-4bee-93d6-bb8a97734132", 4, 8 },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "91422e2c-ceab-4a3d-8fd0-c20c25f65181", 5, 10 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "95cf1a75-3f6e-44a5-ad60-dceadbb60bec", 6, 12 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "863e51d6-09e7-45e6-bccf-e1b94d8bedab", 7, 14 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "24e0b4f9-3156-4c37-8324-7279128c1fe8", 4, 8 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8ffdd61a-1b80-42de-a6e1-91869fe0edf4", 5, 10 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "17eb0708-90d1-4f00-b092-8bd5e8151566", 6, 12 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b2ed0be5-cc5d-4c43-92f7-455ab9ee0050", 7, 14 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "90a856e3-f478-450b-b720-27f3c8fd8438", 4, 8 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "274a7a63-105e-4232-bdbb-fc8a9ca6a8b6", 5, 10 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "77153e01-e428-4ab8-992c-2a8813562aec", 6, 12 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "5d28475f-867d-4baf-9f57-a0b819e17b85", 7, 14 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5b033dd2-37eb-45da-b262-3000db6486a7", 4, 8 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "dc6e2acc-f6d0-4d96-b820-da00fa6def60", 5, 10 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b4d1b55a-9860-4f9d-87ca-3457fb8d8d25", 6, 12 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ba652ecd-ea7b-4c18-9d97-bfa7c53ba3ef", 7, 14 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "77de63e1-c2e1-4d12-bc40-d7028aa4112f", 4, 8 },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b2f51bba-1a31-4b73-b738-d946be153a98", 5, 10 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "bbd21663-8b4e-4d28-8e7a-c3f5c25a4985", 6, 12 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0666d01c-3587-44d9-bc99-83fee0b464d5", 7, 14 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5272d355-e07b-4d98-a3ca-ed58aac3a4ff", 4, 8 },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4df2d08c-2712-46f6-8511-5e7776812d6d", 5, 10 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5c3e1e96-8bf6-44f0-b628-17b212c23374", 6, 12 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0d30227a-27e7-4631-a804-69388231d82f", 7, 14 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "074ba242-b54d-401a-b00e-280f644d714a", 4, 8 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9b9de56c-f7a7-4873-96e2-72a9fc6a18b7", 5, 10 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "ac9576f3-53c3-4a0a-a8bd-aed73f5c5201", 6, 12 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bcb6f1ce-23c1-43bb-b870-119811589c13", 7, 14 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e6ba166f-90e4-4c17-8873-a45379d04d11", 4, 8 },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "83917475-0160-413d-be08-586d2dfc9bf7", 5, 10 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "f2385c56-2fc1-4e26-9ff6-fdc428358ff8", 6, 12 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "25444f44-9a22-49ff-806a-a4224f312d41", 7, 14 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "446e55a6-357f-4451-9906-e39673001ab1", 4, 8 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "880cab0c-b6d1-434f-9e72-4eeb69a9c976", 5, 10 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5d5264f7-22b9-4f5c-a097-a9d50f117586", 6, 12 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b8a74cf7-f5aa-47b5-bb42-a82f40f6381d", 7, 14 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "997fd181-7fc7-4ec7-9fd4-e1dea63baf4a", 4, 8 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9ba13c8c-1516-4a94-bad9-bc4ffc10b0cd", 5, 10 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b5ae1298-66ae-4ad4-9974-2b6c8e467256", 6, 12 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0009b88c-0f8c-4d6f-9158-8eae166612cd", 7, 14 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8896b068-5613-4704-aa42-deaae1a72116", 4, 8 },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b3d204ff-d3d1-47d3-bc94-79321faee18d", 5, 10 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2e447304-44ce-4fb1-9493-68f2e6b1c51e", 6, 12 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c1ccb143-b5d2-47ff-8788-eace21bfb11a", 7, 14 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "390b5e5d-36d5-43f3-ac7f-ec33e9e5e30a", 4, 8 },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "42fee39d-7dd3-47be-971a-b811b337bced", 5, 10 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "08c31bd1-5c11-443a-9a64-7ba066811926", 6, 12 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "bf710304-4189-4f5f-98ec-fcefc8617297", 7, 14 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6f6960e6-269a-4087-95ae-6ead3725197a", 4, 8 },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ddc043fa-805a-4d85-9aa5-219020caf678", 5, 10 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "52dff4c5-e990-4df2-b068-d28f01abefe5", 6, 12 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "05fa796f-22f6-442e-9ef6-ad12259a5a47", 7, 14 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "04704ffc-c19c-4b0d-b13e-85852ca89da1", 4, 8 },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "aee8f979-e9ac-4990-9e42-1141213d2dae", 5, 10 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "61864448-2b87-4896-b923-e3e0a56c752f", 6, 12 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ccaaf05f-90fd-4ed0-ae90-85dada278814", 7, 14 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "96cfefc9-7d62-42a3-9d26-9bd33bdf0ae9", 4, 8 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6c7c6578-0f42-456f-8630-2914ddf109c7", 5, 10 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "daf9a60b-2e88-42da-a389-022d9228266c", 6, 12 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "4256b718-90b6-447c-b5d0-686756f09abf", 7, 14 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8d8844c4-149c-4156-9ed9-9b4518515115", 4, 8 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "257500f3-2ad7-46a8-b0d4-7f03852abc59", 5, 10 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fcb12cae-b1cd-4ead-ad36-e37b0ba0d90f", 6, 12 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "61c947f7-aac5-42b7-9eda-bda3fdf99a8c", 7, 14 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "79adb89a-301c-4249-a015-5381de936d96", 4, 8 },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "509ebbf6-f40c-4d1d-bce9-3ae50285f885", 5, 10 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b26e2742-4e74-4b33-ab8e-d22adf99347d", 6, 12 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c2b7ffe7-0044-4a8c-86a2-fbb823b1f952", 7, 14 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b66d53d5-3716-4f26-8edf-27bade7857d3", 4, 8 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "2d7ac1af-a688-41a5-a153-331355c53626", 5, 10 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "607997e1-8f08-45ab-95e4-5067bc2e76b2", 6, 12 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "de99b51f-acfd-4580-bcf8-35fff6181808", 7, 14 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "954bfd0f-3477-4fb3-9fdb-927fc13185bd", 4, 8 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "d47f1675-2768-43fe-8c63-97007cf9179a", 5, 10 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b1b9311e-aa4e-4563-b2f6-f0e16dd019a5", 6, 12 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9e04aa03-7a68-421f-99d8-6534becaf278", 7, 14 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "820d458d-944d-4885-ade2-4ce879b0cb18", 4, 8 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "520920be-38e4-4ad9-953d-2469b17587ad", 5, 10 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "35d4a28f-bca0-4b57-af1c-a36b143e9f66", 6, 12 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "457e0b81-6f99-497d-b8e2-5a026dbe3c98", 7, 14 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6c4f1fc1-9914-4c4a-a002-8b37929bd351", 4, 8 },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "02c632ce-9281-4741-8ec0-15f48f35aab3", 5, 10 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "482c937d-ddfb-4f98-9204-7ea00542b8de", 6, 12 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "58df1772-dba1-497d-88cf-87c2aa0d31c1", 7, 14 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "95899b64-4670-4725-9bff-ad0a4ce5e96f", 4, 8 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bb71376e-1e31-4aca-ad8a-447a48675bb9", 5, 10 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0c7b7436-a857-47b3-a02b-80174832d9fb", 6, 12 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d1c2b96e-3ea8-4ce4-8d33-963a4387542e", 7, 14 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5b71ab15-6ce1-460b-ab29-002cb258c482", 4, 8 },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c24db110-b382-47a6-941d-c3b6f09ab26f", 5, 10 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "323ed256-ca0e-41f0-8ce2-08f441feb358", 6, 12 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "12ad5cc3-64e1-489a-84b8-da8b5687cbf2", 7, 14 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "b000b7ba-0df8-42a1-a4aa-ac7dbc007df2", 4, 8 },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6eb343e2-384d-4aba-9124-1fc05b4fd92a", 5, 10 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "babe62aa-cd28-49e7-a2df-20940908ec13", 6, 12 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2d2c8dfc-75e4-40cb-9226-9885d69333a9", 7, 14 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "432067e4-bb85-4d53-9c6f-74b60a08ca3c", 4, 8 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b2dcd59b-50b6-4e5b-820c-724ce029b68e", 5, 10 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "87c61b26-7800-4364-adf9-6f20f5079444", 6, 12 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "cbc7b00a-544f-434f-944d-b418dfa3dea7", 7, 14 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dcee7857-f942-448f-9b56-50a0562d8ab8", 4, 8 },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "86b7af5a-8b88-4401-8ca3-b17d3ce21828", 5, 10 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aab4779a-b729-4e5d-9b95-fa8cdcba7061", 6, 12 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "c6de2488-87a9-4ce6-87c6-f3ec3509249f", 7, 14 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e3379460-3f34-448b-b772-625b1b3b6d01", 4, 8 },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8d02b906-400e-4eac-9954-bd416d821e29", 5, 10 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "8cfdfa13-08b9-437e-a87b-1dc1fc7a8f71", 6, 12 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dd5dec14-44a7-430e-a874-059b45ed3cfd", 7, 14 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6ca95250-8287-47b0-9c8e-fd03585d82fb", 4, 8 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "da0858bc-2da2-418e-8cde-5f46e8248e16", 5, 10 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "0fba0284-036c-4aba-b84d-8ff20842b66b", 6, 12 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1653580d-cafa-4a85-8803-e386caf33804", 7, 14 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5a1ab121-9c4f-4044-a556-98367471f80d", 4, 8 },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "6d7df0e9-fd65-4602-9140-61fbdfa8192b", 5, 10 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "aedc4ee8-2d47-4432-b3ed-426169c9c917", 6, 12 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e1dfff75-30ab-4f3b-a45a-42cd57abb7e5", 7, 14 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "28963f79-0bf8-473b-88ac-d5855877cc11", 4, 8 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "893d3315-c939-449a-b696-803b45422ba4", 5, 10 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "3d812fd7-4bc8-43c8-9171-321aa9d2ad6f", 6, 12 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "dad07768-476b-436b-a615-652789dbfb8a", 7, 14 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "577a2b9b-2e34-4df2-a0c5-93d636b251c5", 4, 8 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "90aa83d0-8580-47c7-b857-0b8dec4c3e4d", 5, 10 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "76337b3f-8480-4858-88c7-378871ccf4d5", 6, 12 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1537cfee-7250-43d6-b478-6f52dfeb0248", 7, 14 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "32e29f3a-0914-489c-b16f-debb987909dc", 4, 8 },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "4f785943-3eb2-4c36-a3b2-a352da722650", 5, 10 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "25114be7-4b25-42c5-b2db-093ba76d5929", 6, 12 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "eb56e1af-629f-4613-ab16-82337312cd04", 7, 14 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e9e7ba1d-cc60-4cc9-b86a-e01e9a28b372", 4, 8 },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "8b627aa1-a67e-40d6-9202-095dde3d00fc", 5, 10 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7774c7ef-24f7-458a-a47f-1b6107470831", 6, 12 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9f95779b-4d67-417e-b7dd-37da50784a48", 7, 14 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9f99ea79-0cab-4abf-9a4f-2cb9fe788813", 4, 8 },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "c585398c-7816-41a9-848e-1d6e04870d1b", 5, 10 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a62a8c2d-46ad-4142-8871-7ff23a86958d", 6, 12 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "ce68db84-4b43-495c-9985-34bb9a33d5f2", 7, 14 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f87fa3f9-2c85-487a-a3df-a816c650ff4b", 4, 8 },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ee719a80-3c5a-4a60-b3e3-d6958a7ce558", 5, 10 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "eb12197e-72be-4b0f-81b8-789028eed128", 6, 12 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "de151786-33b6-4494-be23-7ce8c40385ae", 7, 14 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3f65de54-e322-403b-b08f-408081d3abf4", 4, 8 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "1a4ea487-3e77-4bad-8ea1-951dcfd1f0db", 5, 10 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d01a5daa-1a39-4ebf-9304-812dae26a154", 6, 12 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "795bba97-1278-4ef0-b3f5-cc1a5005affe", 7, 14 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d4318c9d-6ea4-42ac-95eb-12976334ad49", 4, 8 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "30654ce5-2d07-4fdb-bd62-2e378bfbc321", 5, 10 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "17f7d23c-530f-4d22-91d8-a4ec899cefc5", 6, 12 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e9a7960a-4247-4894-831d-be30bed91001", 7, 14 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f68693ac-c5ef-4afe-8965-0cd107436af9", 4, 8 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "682a4859-fc24-4350-9e8d-54fef2728063", 5, 10 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "7c96c695-3656-4213-a5c5-62414388964a", 6, 12 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "55c992b1-1482-4f5c-92f2-993bdf25b626", 7, 14 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9adafe80-5058-461a-a9a3-40d5c159e055", 4, 8 },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "a5d7ab3c-f724-4bbb-9566-6ecd6396f5a4", 5, 10 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5b628383-1f3c-41d5-8487-c4155f2d55df", 6, 12 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "35d518f3-4fa5-4f32-9403-4d2bca93d5bd", 7, 14 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e1ee062e-ba63-4a37-b9e8-387cf2c2cde6", 4, 8 },
                    { "ea59937e-0296-4758-95ad-196fce18db72", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "9f396961-ec74-4363-b085-c8cd302f5982", 5, 10 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "fd49b040-bc89-4a89-aa40-5d289dc42845", 6, 12 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "b6eef95c-932f-4a87-a929-b90132d3f5a5", 7, 14 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "120c48ce-7c38-465f-8671-5cf4cc0ff99d", 4, 8 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "11a33f14-d4dc-4e2a-9d18-63798ef7a444", 5, 10 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c2134f65-af09-4eb1-b775-5edb971a1ab9", 6, 12 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "d42f4753-905d-498d-98a0-4afbabe6d0a6", 7, 14 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "dfe33773-2c74-4e18-bb10-c50c01bedd3b", 4, 8 },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ea0c1872-cbb1-465e-8d73-1e720610e7aa", 5, 10 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "28858c9e-4e80-4229-852c-489de3a8daab", 6, 12 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "19a54e51-56b4-4fce-b72b-0f343f810b8e", 7, 14 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "f5bb4e25-f496-4797-8f94-a8652bd6e91a", 4, 8 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "79ab95e6-7043-4c04-b36f-9229e373d9ed", 5, 10 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "16918fbe-3f1c-4159-a41b-cdf494ca8a32", 6, 12 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "9b4f38ea-571b-42a9-b991-ba90f8a59259", 7, 14 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "bd82850c-1df8-4ed4-aec3-2614907ccc72", 4, 8 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "42a06b3a-b315-4a1a-8e49-6b10175164f9", 5, 10 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a00c62eb-55ea-4a74-8fce-454aaeaeb7f0", 6, 12 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "69a57ec6-82f2-442a-a9a3-201ddcecf303", 7, 14 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "a8f1ab95-f7c4-45f3-bcf6-25b9d76b7270", 4, 8 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "0e4a194b-852f-4062-b5c5-0461971f3311", 5, 10 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6fe09bb4-6f79-4a69-ad7d-808ea99dbe59", 6, 12 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1dbf9af7-9fee-4c4e-ac0f-ba44565bc1f6", 7, 14 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ccdefd72-2c36-4f8f-8541-e35d155e7b21", 4, 8 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "75612685-e41a-4dd4-b644-66b6a75ec93c", 5, 10 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "a7ca1cd7-f7b1-491f-a674-6c8de851b4d5", 6, 12 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "1eedb113-efc3-4a39-8e8f-40041b6951bb", 7, 14 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "ea92aaa3-d9df-4ddc-9df0-e05e9156ca17", 4, 8 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "bac1840c-3b3b-4c39-9ace-9ebd4b618321", 5, 10 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2f764467-a4ac-4d2a-b5e4-02c149cb6998", 6, 12 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "7db4bfa8-f7f6-447c-9b1e-4535d8dc26fa", 7, 14 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c4e1145a-6ba9-4593-8155-056de4ee79b8", 4, 8 },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "55d41a21-3b01-41a4-826a-61f3b8fb59f8", 5, 10 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "c2380c70-c337-4fc0-9154-30e2c568d6ad", 6, 12 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0c3a25bd-299c-4560-a542-f661337f77f4", 7, 14 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "89926621-1223-4947-9570-cdbbad29da0d", 4, 8 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ea0d7321-45f8-4fa8-aad9-cc3be97e9c00", 5, 10 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "cfcde492-ba11-4ef5-979b-a0753b0c60bf", 6, 12 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "da416a45-f8bb-4ce2-a7fc-a3dd6a3d4f19", 7, 14 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "d511a52a-fd0e-406c-89e8-81af0fa9cdf9", 4, 8 },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b888315a-c4e1-4cca-823a-3985e4944bd6", 5, 10 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5591f295-c755-4152-a3c0-30197071d5e2", 6, 12 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "6998c548-e980-435c-b9a9-46342588c32b", 7, 14 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "cfba5d75-1428-45a2-807f-d2dd982e728c", 4, 8 },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e18e6f90-4fd7-4aa3-b21e-c6f459a8dd6a", 5, 10 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "b75ac48d-df0a-4632-ae60-507d1f57bc57", 6, 12 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "0e2e3ff8-ad35-4824-9e06-8d601526b893", 7, 14 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "e0873008-d78f-463d-88ee-aa9dd01092ef", 4, 8 },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "02a20b8f-5cfc-42ee-b693-c15b797d03cf", 5, 10 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "d9cc6e43-2f75-45fa-a8f3-8fe6c167609d", 6, 12 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "2edf251e-bf06-4955-8e07-58c95368753f", 7, 14 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "3149e24e-7bb7-4913-8dd5-742ec26424d7", 4, 8 },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "88f81e43-42f2-44ac-a6ec-570f6752cd12", 5, 10 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "85c1b846-6c2f-424a-8853-f3cf61ddbc02", 6, 12 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "fd591dc7-4df8-41c2-ac53-88742daf7d8d", 7, 14 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "6b17186d-49ed-4b40-bc9f-2912688d6fcc", 4, 8 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b60405e5-04c1-404f-9258-b7ae9c9500a5", 5, 10 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "5ec949ad-20df-42a2-ac79-2711fac46f3b", 6, 12 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "812e60cc-a54b-4d44-ab5d-4f4f89366fd8", 7, 14 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "5fecebf8-08cc-4d49-b335-6a40d828a718", 4, 8 },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b29086c9-c719-46f9-b33f-0aca57585f3e", 5, 10 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "054ce9e0-d822-4789-a0ec-00bbd4553613", 6, 12 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "93c23435-f95c-4310-9003-6a6fc4317046", 7, 14 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "59430d72-47d6-4b84-88d5-afc6a605994f", 4, 8 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "e77915b8-156e-4ce3-a46a-227332a26643", 5, 10 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "578b62c4-0fe6-494b-acbd-78fe7c9d05a9", 6, 12 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "f131f766-e082-4dba-ad10-f32df07d07d9", 7, 14 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7c15fccc-7789-403e-9fa8-4cadd44ae7b2", 4, 8 },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "f9b25009-800c-41bf-a741-08e5cefa44db", 5, 10 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "6386084e-262d-4df5-a91d-a963eb4ce904", 6, 12 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "363aff8d-fcb1-417f-866a-dadde5459a35", 7, 14 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "8e649cdf-476e-4bb6-a3d3-33365c4e27d6", 4, 8 },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "b9ed7c16-b367-41eb-853b-9e9a7e6d70ef", 5, 10 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "621e05b1-26b0-4d7b-9b4e-843b9edc4564", 6, 12 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "72c35e7f-4398-47ab-894c-dddc402ed8bd", 7, 14 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "9ef52162-140a-4f0c-a137-2e519763dc08", 4, 8 },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ee20cc2b-74f7-4f7a-8ee1-27dc6d6f3018", 5, 10 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "2d03d609-0206-4af9-bdf3-c89531a928e3", 6, 12 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "e77f5046-b95e-417f-8aac-2e6a76997fa2", 7, 14 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "c862f1e0-fbe1-4ee3-959b-ae748a10d22b", 4, 8 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "ec79a297-cc53-4ee6-a325-bb2f22b188dc", 5, 10 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "1a84455c-8786-43ae-8a00-e6a1a24849f1", 6, 12 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "23a0011d-5177-4353-ba07-18e154704da7", 7, 14 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "7c33309d-a467-4c0f-8596-b70556ea84d7", 4, 8 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "914d3d89-83bc-4c37-9c6f-e0f4602d5477", 5, 10 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "11ebdd3a-f75a-4d85-9916-220874cf8af9", "9bacfdc2-133e-403f-827d-7c242bd2280e", 6, 12 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "152002fb-d980-4750-a70a-7b5d0bdac9e4", "a9582b4a-4a51-4d01-a213-3f8f57c5d81e", 7, 14 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", "4062a89b-c40a-4fb7-9ace-10d05eb90658", 4, 8 },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", "71edfe02-d39b-476b-8fff-8747d6bc5b9b", 5, 10 }
                });

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00e2e1d5-5577-4f8e-b13b-dde82c77b91d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01388782-b75d-4762-8ccf-4499568fd455",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01e005f3-0bbb-4ae2-9136-f3afe1353315",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "034b18a2-33ad-4020-8d9d-5a98891d0be9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0418ebf4-0b73-4042-a5e4-ce396d5b512b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04871b2a-5533-41da-9959-f664809887c3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04886a46-180e-42d2-a3e5-86df27efaee2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04a7d241-f761-4ead-803b-1d204df7bd53",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04c2c202-afa7-4e2c-941c-29f956783f6d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "06c505ec-998c-46c0-9163-0188423113b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "074db959-27e0-42a0-98d9-0961864e1a7e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0973a418-280f-416d-8df1-7139e28961d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09a2d110-7772-44cd-af5f-27fb951f0544",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09ff2634-4a59-46ce-94c7-8428324d789f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a1ff474-48a1-4366-a120-8ece6ce5ba04",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a7149b1-6928-4099-b623-787d0201e213",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0bf06e4b-d062-4e01-a985-9b05e3f12fd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c59ca0d-60e5-4686-80be-18ab36b53468",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0dddae8d-37b4-47e5-9c89-95589a3f787a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e9b45b3-2915-4dcd-99fa-77ad89f182a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f1d6d17-8b8b-489d-a0f6-7349691aadd6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "121345d8-2660-489c-a90d-2469b9c44222",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "142730b0-0df7-430d-ab80-e750ffe0a6ba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16b681bd-b39a-4891-ab7a-9073365bc1e7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a9626f8-303d-41e3-aa54-ae1a971ad179",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f4cf9f5-2976-4b5c-9428-122096bf3877",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2146af26-ce2b-461b-883b-e6f4fe0c8085",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "229759ff-14dd-4c4e-82aa-f56a2181c0ad",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5443), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23672a63-2fd2-4e6a-905b-340ae4456b83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2838e6e6-1238-418a-988c-0346a2abdbc3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "286d76ad-723d-476b-aa84-c7a6541afe81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5483), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "299be826-3901-425f-90eb-e445e73ac37c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2b514c67-a65f-4c0a-86b8-5bf92a974c34",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2bc1e669-d825-44a8-a11c-656a8209498a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e5e4216-4af5-4fb6-9c65-8989715e5a40",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b00595-bfeb-47b6-9af3-91d117e003d4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b3b531-3e47-4ccb-9cc9-8e7aafedb810",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "334d6d7e-422b-4376-ac30-161f98aab66d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3396c18a-dcd2-4638-8827-2c7fc10d6996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "364cd9de-6ddd-47d6-a534-74f3f00a0b7c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3770c1af-e181-494b-8c1a-c6f09a3b825a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38af7185-32ce-4cf9-95d2-52c4c4d18bce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38c1edea-3339-4f95-8d4a-5f5583660d9f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c8cf49-d75e-4703-8958-ec3bbff87723",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c99f61-efbf-4f5c-b084-eac381d82049",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39f01cd0-ae41-4070-9eb0-0f2423cc3286",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d6e031d-2fcc-46ce-9eb7-268e95ae1323",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d704609-8abd-4a0a-80dd-2ee9f38a3608",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3da92c21-3bf0-4de1-a187-459271e16106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e2f7a5f-b665-4b13-861e-c5a5029216a0",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5457), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f6f1dbc-9042-42c2-85ca-a117c745c5e8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5447), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41c0e64a-97f8-45fa-a2b3-399ed47cddcc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43606bc6-5874-4469-bcdf-fe1b86f66882",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43bf1028-ea0f-439a-b940-3b81b1f4d683",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43c746aa-0830-449b-a594-621f04923cf6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43ca244e-8d5a-468b-b327-ce6bdc541cf7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43f658bf-a5f4-4537-a281-77dbb5ce1c27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4534cffd-7ed4-406c-9cee-23179740daba",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "46c82189-5271-43ba-97aa-a7b0a7dbf126",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4779905b-91b3-4878-97e0-58a010668be5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a450a7f-5ca6-42f5-9931-e130264c8e0c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a67e8f3-4dec-41ad-a5e7-18995a14535d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4aa47021-28ed-4c36-81c3-6e2734d3873b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b376f71-ebf0-4762-bbff-e61541afa410",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b656abf-bdc5-4058-a12b-488d93cc1677",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c0b609e-a2cc-4477-b8d7-9fec89d49462",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e99c977-d86c-48a7-8bd8-9e71d999539a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f8cc09d-7512-44d8-a98c-3004c93031f0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50680664-523a-475b-869f-0aa5e0cd88b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "523db500-84c9-42fa-bf24-f66e77e724e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52a0bd63-231d-4620-9e7a-10b6d4fb8b65",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "541a5387-302a-478d-99f2-c98f6d979aaa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55f0346e-6b98-4a1d-99f8-463b81f6a627",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "56072689-4550-44be-987e-b08667758de4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "564ea3f5-665c-45f3-85ee-e4c45d3ba362",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5754a3be-8508-452d-8a64-9d752bde4f70",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5787a57d-27d4-4dd2-b5e1-35e4125a6e94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a04a2e5-489b-4671-933a-1db0a971f40e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a382843-9817-449b-b9d8-4e48d90aef5e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a529282-1b91-46d6-b472-e6386b95cf5d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b26e8ac-df32-4b9d-8992-047e22372332",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b36c084-dce0-4ba9-ba55-613210750e27",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cc37e11-afea-478b-b360-1256896a421b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5eaed820-0af4-4157-8fea-1f58baa77661",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5f9a2c76-50a5-4e93-95c9-158ae078c357",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6183a2d7-d2c5-4828-bccb-754ce1bbb002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "618fdb18-11c3-4166-9bb1-79298a32a7a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61efcce3-e4ac-4aa6-ae46-1b7976b5da88",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64a56e1a-be01-40b0-bc09-1fcaf2161c10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "674202c6-8a9b-4c1f-9eae-0ab056cef8d6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "676211f2-1f90-4059-bdf8-9e26f9a637a4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6883361b-7a86-49b9-8fc2-90029770fe22",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69191d39-5c1b-4261-b0d7-48a7833e08bd",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69920a1e-2cdf-4b1a-a9cc-329b986e4b69",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bdd753a-2706-48b6-b485-23c989a5f326",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c4014cc-3cc2-481d-9cd6-b13c45da0908",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6e0185cc-235f-4603-9470-5f4ca7c92514",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6eee1f90-a40d-4d95-9ca6-0e45689398be",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f001fcf-f1b6-4abb-8d91-7038044fabfa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f055d63-314e-4a36-86eb-ea7e11e820c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f154805-6e66-45a6-a147-87edf4267def",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f169352-0f68-4d11-b562-f693a0158100",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fe7b587-9518-460f-8c8f-7aa43ad55f9c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7203c646-e705-48d1-8141-b2619b227d8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72d46b9b-612d-41c4-8303-8f8571771de9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "731dd6c2-2937-4d4b-8c56-63b5cf581729",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74770ec2-4585-4665-8f69-b2f0d4f0fc7f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "748cbc1e-8d05-4f4f-8196-9cfb28db232c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74aa5d7a-f513-4993-b672-cdf9bb448319",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "752bc953-0f26-4a2c-afd2-45c5f0b9aecb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75ce2f59-fa25-4745-bb37-371fc11ab655",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77035e08-21a9-4149-8d7c-d4266f88ad03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "777bd2e2-cd9e-4d51-b191-c81eb9d113cc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78157107-23fa-4638-bd17-38187695312c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7965d633-4f86-44de-8ea4-fe0c68aa6a83",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79876823-dd75-471e-b2b5-80650a4bdd47",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a3ccc47-8f30-4952-8909-ed3537cfe7e5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a7cb657-507c-4325-a047-f9d67b6fbffc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7ac3fbad-b279-4d80-a8d7-ff1407a6465f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7d543840-b11e-4380-a147-7dab483cf5ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "809d901e-d7de-4fec-aa95-655deb2301b6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "80f38d33-7c5f-4952-809c-85af1dc69962",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "815f578a-5fd8-4c79-8446-ff236b6ffafb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8191402a-33f8-4195-bd73-3aa71191981e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81c921f4-7fd6-428a-aefe-648e5e11ed46",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81cb9635-df03-42c8-8d68-944f99de02ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "827e88a3-8580-436c-9112-02d58ca2d7d0",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85634f26-c60b-4cc5-8c0f-0fad3182a5f3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8601b2c5-4e87-49e4-9099-8c21a9ca00b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86513d65-cf7e-49d6-bd16-94286e5d60c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8906cf96-12d6-4eca-8a0b-d39dd78dc597",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5501), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "89c5b8e4-4c60-4e08-88ad-4509be08bde4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8a84a13e-c0cc-4496-81a8-f4550c5807ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8abdfc01-6b02-4b55-93d3-eea25b17de37",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8ad91c05-ccae-4482-9f43-f8f197dccdf9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8af7be7f-0ff6-40e1-b206-e89d78430393",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8cefc01c-282b-4866-a0fa-238ed864481c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d1f8204-852a-4342-b836-767fb2b71263",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9017f445-e420-4568-b8d9-0d84b3c46aad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91cb02d4-02ee-4632-a12b-7aaa4b220344",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "924916c0-2ad0-493a-b544-5df45fa43152",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92a51416-05b5-47ef-834f-ad0baccbb932",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "932c7c4b-36c5-4580-a276-a176a72fd72d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9377deeb-6354-4346-8d56-03b29c97d5fc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93c17f7a-aedf-4f6d-8429-df9ff308d381",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "94430690-6bd2-4e48-b0c3-4de11c7f5d81",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9445ce49-5efd-41b8-bdab-b8d7f350b5e2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9570f221-d5cb-4963-896f-371af0b32c79",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "958017ca-725f-4d80-b65e-79560a051a03",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "976d92d5-de98-47ea-a219-26842c7f8caf",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c301f9b-43b4-4015-bc1d-70ad1b2b690e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f0127f0-a604-46ba-a855-ca6be06fcdb2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f2f3880-4997-4c0b-88e8-f9a74f8b1564",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a07ed297-38cd-456e-834f-c31583eab987",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a08d4c19-059b-42bc-83db-26206735e40f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a278895c-19b5-45c6-92f9-48c5f2724e8a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2a34d3f-9082-4d98-9637-2bd936e60256",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2bcb56b-1da2-43fc-b133-3b5c04603123",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a34e2f74-5403-4e43-bc88-30019ebd460f",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5496), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a39041d7-3a20-4e73-9334-3fc6d8327e06",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4efe1b6-e7fb-4cee-96aa-1125a3888791",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a907697f-9b47-4302-87f3-c4bed83b24c9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad918937-0645-4b89-86d5-0672662fd46e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aee09720-0d54-473a-b585-c62d6c516e68",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1dae3fe-91d2-42cc-8ba7-dcf237882eac",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2b71d89-5501-4bd6-a358-aca8ce706bdb",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5510), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5b67003-636d-425d-9784-45d374db713c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5e13a1d-86f3-415c-9c2f-4343258a4b57",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5505), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8b726c6-227d-4267-8dba-c1bf5ec0301f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8cc3bd3-ac03-46c4-820b-f7988f3088f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bac28c61-4b74-4193-a109-f4456c44cf67",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb1dfb9b-70aa-495e-a041-156a4fbb4fec",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd0cb50a-e769-48ed-8473-b25faa687e15",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "beacb4b7-e74c-45d8-b8df-60e1a2a50768",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c15e0f9b-39be-49ff-aff8-1800116358f7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c24852f9-007d-455a-8cb5-0e2681c7a0a5",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c35ccc97-39f5-4396-bbe1-2a6171f30d10",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c37d754a-9f08-4f13-8d26-630d896c9371",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c474ff32-d65e-4d11-90a2-f9ad2e8ee772",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c50585c6-d1df-4eaa-b5bf-317678e7d3bb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5381f46-f707-4fcb-8f1e-605cee507946",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5d36e60-0945-4e35-9239-22f30c29025f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6633a62-08d6-4613-8f06-a3fcfd76f974",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6fcf873-e9c2-43c9-81ec-ba09bd063e13",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c87ce8ae-adb7-4007-8c0e-0090d0926e2e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8e6b9db-dbc9-4d49-a473-2c8593982b56",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8eeda2a-0260-4488-9acf-fddaee71e124",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c941ed50-01c0-472d-8122-3756b9b55a29",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5491), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c99efd04-1f14-49e6-bd60-208290d057a6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cae31f17-a52f-4ac3-97bb-6886500b19bf",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5461), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "caf33f50-8517-4995-a849-4a70bbe202f6",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd21938d-8cdf-4c18-a25a-73a2970c2deb",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3167af-629a-4795-8c18-cf4f49e0a7d1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3be091-3d72-4512-ba1d-e8466285b930",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ceaa3043-fb10-4638-b942-85d7b5fc20ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cf03ef83-babf-4710-ab13-ace35476b474",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfb34052-097c-4637-b13e-86a2bc255163",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d302b7f9-1306-4a95-85d4-ff189df4b527",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d501bc94-2256-4ce7-b0bf-be4357ada814",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6003f61-89ae-4240-b53c-542ab36728ca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d7a31657-3101-42e7-8b97-aa6ff61d3e84",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d99cdf9c-bda7-4807-b92e-34b3de2e6002",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db5aeda4-2830-4ddd-a7ca-02363d58bf25",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db604d4c-9f40-48f5-b244-9b3bdcaf71c1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db9ccc9b-5149-474b-a0b4-af8a13f01bc2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc91cbb3-94e1-43fe-bf92-06077cf48d87",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc94da97-75b3-48b7-bfb6-d46984b5f106",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd438551-3d93-45bc-982d-7c338b69983b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e0f91ecb-de8b-44fb-9a15-59c38d5093b4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e35c267e-66ab-453d-ba33-a31c4ce7e5ed",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d54d6e-42fe-472b-b696-6642067802b3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e9ca0d20-0315-4fca-b334-e6e046cd076e",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea3367e6-6d1c-4e58-883a-b18d66f30f8b",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea59937e-0296-4758-95ad-196fce18db72",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb3e277a-61f3-4f55-b179-d474841a80a3",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed9ab94a-9354-48de-8695-43131a67bd2c",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5477), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eec8a34e-e0ea-4a80-bd38-c7db22f84173",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef08937f-96ed-443c-80ac-1f7b764d10a1",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef23ec60-f223-44c4-915e-196d6b011b94",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efe2c4a0-7529-4f91-9026-696ea0a1f7b7",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f03ff26b-30e9-4a60-b99a-780060db1e35",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f102b409-56b3-42b4-b70c-25192033ba8d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f20906f6-cdbb-4f93-9ad0-87e63f0782ff",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f39485eb-f82b-495c-8b60-7dada21ee477",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f43faef4-2885-42c1-9035-ccc2667d7fca",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c",
                columns: new[] { "CreatedAt", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[] { new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5452), 1500, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f6edd915-a9e4-4713-8e0a-6f1d7efde18f",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f7062df1-beb7-4814-a074-e9da66830639",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "faa28a13-3b08-4a67-834d-621e4dd3d287",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb0deebe-ca58-4eb6-ac5b-67442c846405",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc72a988-3078-4c69-a8ca-c0f1dc1ec996",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fee54746-70cf-44dd-98df-5c09bb8959a8",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffcc6812-deda-4b92-b2dd-0f59e0a46c44",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 870, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "RoleName" },
                values: new object[,]
                {
                    { "d4006779-0b2d-4020-a0e2-81ce3757a287", new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(7271), "User" },
                    { "ddb56725-a12f-4814-be32-af15c09a53eb", new DateTime(2024, 12, 25, 18, 42, 59, 872, DateTimeKind.Local).AddTicks(7247), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "14719c21-6e15-4130-8e18-b031669b94ec", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 25, 18, 42, 59, 873, DateTimeKind.Local).AddTicks(2342), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "11ebdd3a-f75a-4d85-9916-220874cf8af9",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 873, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "152002fb-d980-4750-a70a-7b5d0bdac9e4",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 873, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 873, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 25, 18, 42, 59, 873, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "c9ab58f7-e4dc-4827-9959-e4239a6fcb6f", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                keyValue: "07f8b873-7581-4254-b815-4049bba61906");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "2f0c36aa-9021-43bc-a0a9-105f31039f1e");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "34b92f94-cab3-4c00-adbd-5d44564e2956");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "52525383-5045-4b3f-9a1d-c70e87b827dd");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "529b2623-4ad8-49c2-b1d6-a7376913a121");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "72f28bdd-b3ba-46fc-a028-8d69676d3c93");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "7942fba2-ea3b-4b4c-aa17-43ea379d7fc5");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "984595cb-84d5-4645-b525-68a9c07e0fa8");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "abd81aeb-2384-40b4-8b57-de47f787b2b4");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "b741ccfa-dfb2-4178-aa28-53fb13f163cf");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "f175e8cd-4514-4391-9695-c0f7ae3d0346");

            migrationBuilder.DeleteData(
                table: "FotoDesign",
                keyColumn: "Id",
                keyValue: "fa411301-2e80-418c-9e7f-6a850fbaae42");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "03e073d5-0fc8-4c6e-94e7-b85f82c9cbf3");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "0488b4da-cc9f-4572-a3b7-3caab13f3e3c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "1c3c3d1b-9e1a-4f56-a9e2-895ce1c13259");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "251de8db-12fb-4a14-871f-af6fb43d6dc9");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "2f348f5e-aac3-41d5-b4e2-692176284447");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "3f4a25a7-22cf-4673-929d-ac0ef2ebb640");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "43f4bf45-cb5c-4b3f-9731-5ef8346121cd");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5435d8e6-b0ef-4a01-8bf4-913e03d5b3db");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5e3f6876-0ef1-405d-a636-f6bdafd48f74");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "633e2b9d-b30d-48c7-bd86-7d63c85494b3");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "82426e2e-28b6-485d-b835-e62a5982fde6");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "877968f8-c429-49fb-bcfe-46d445032c95");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "8e63cc63-539b-4bba-a56a-487ff82da8c3");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "a422b393-ddb2-4cc3-b74b-0e8f4682ce0f");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "a9447dfe-7272-4ac7-93de-dd6f20147366");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b91af158-f36d-4342-9014-02baffc6784a");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "bdf28961-0f5c-494e-92ca-5d25f5bfbc03");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "bef3c24f-0eec-434c-ad2c-b0a76e7b84e6");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d3c9fb94-3698-46f2-a873-7a2268a88633");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f38971e5-78eb-47ea-bd27-328b5d22c5a7");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f7206262-9534-45ac-88bd-2c75187cb289");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f8111ccb-0c71-4a21-864e-cab621804921");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f94525b4-7628-4e33-ba83-c059963ddd82");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "fc9b659f-b472-4511-8e03-bba95224f9f0");

            migrationBuilder.DeleteData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Communication");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "5860e32d-d1f5-451b-b62a-cfe8b27a62fa");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "618f0ac8-f2d8-4405-a307-3b1195eafe44");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "b25e5258-6524-44db-a702-ea6fe77f33a6");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "f7d4f67c-ad44-40b0-adf3-184fddadba79");

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
                keyValue: "d4006779-0b2d-4020-a0e2-81ce3757a287");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ddb56725-a12f-4814-be32-af15c09a53eb");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "14719c21-6e15-4130-8e18-b031669b94ec");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "c9ab58f7-e4dc-4827-9959-e4239a6fcb6f");

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
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "far fa-circle nav-icon", new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "far fa-circle nav-icon", new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "far fa-circle nav-icon", new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "far fa-circle nav-icon", new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                columns: new[] { "ClassName", "CreatedAt" },
                values: new object[] { "far fa-circle nav-icon", new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.InsertData(
                table: "MainMenu",
                columns: new[] { "Id", "ActionName", "AreaName", "ClassName", "ControllerName", "CreatedAt", "CssName", "IconName", "MenuName", "OrderNo", "ParentMenuId", "ParentMenuId1", "RoleId", "RolesId" },
                values: new object[] { "Comm", "Comm", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 19, 4, 4, 55, 378, DateTimeKind.Local).AddTicks(7163), "", null, "Comm", null, null, null, 1, null });

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
