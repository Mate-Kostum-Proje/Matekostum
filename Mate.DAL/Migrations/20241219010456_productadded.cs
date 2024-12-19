using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class productadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketDetails_Product_ProductId",
                table: "BasketDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetail_Product_ProductId",
                table: "OrdersDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductCategories_ProductCategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductRegions_ProductRegionId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductSubRegions_ProductSubRegionId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_SiteCommInfos_GSM",
                table: "SiteCommInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "808b204e-5175-43d4-bc40-2b84d28a6d6e");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "ae01048d-c951-43f8-8524-cb9a4a2bad52");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "b0d93886-08d4-4aa4-9728-facf9d7e393d");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "b90decc9-e929-4dc4-b8c0-b1c0737f0eab");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "2c272b5e-1d37-4c9f-b5ff-cc3bde70c145");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "GSM",
                table: "SiteCommInfos",
                newName: "Transportation");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductSubRegionId",
                table: "Products",
                newName: "IX_Products_ProductSubRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductRegionId",
                table: "Products",
                newName: "IX_Products_ProductRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Products",
                newName: "IX_Products_ProductCategoryId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserInfos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SiteCommInfos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "SiteCommInfos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GSM1",
                table: "SiteCommInfos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GSM2",
                table: "SiteCommInfos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GSM3",
                table: "SiteCommInfos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductSubRegions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductRegions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrdersSituation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrdersDetail",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MainMenu",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FotoGaleries",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "FotoGaleries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CommUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "CommUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BasketDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAdult",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Products",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FotoDesign",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotoDesign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SizeNumber = table.Column<int>(type: "int", maxLength: 14, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSizes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SizeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SizeNumber = table.Column<int>(type: "int", nullable: false),
                    SizeAmount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSizes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSizes_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "00e2e1d5-5577-4f8e-b13b-dde82c77b91d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7920), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "01388782-b75d-4762-8ccf-4499568fd455", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7924), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "01e005f3-0bbb-4ae2-9136-f3afe1353315", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9152), null, true, true, true, "/databaseimg/HALKOYUN-BURSA-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURSA K2", "MARMARA", null, 0, 1500 },
                    { "034b18a2-33ad-4020-8d9d-5a98891d0be9", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9142), null, true, true, true, "/databaseimg/HALKOYUN-BURSA-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURSA K", "MARMARA", null, 0, 1500 },
                    { "0418ebf4-0b73-4042-a5e4-ce396d5b512b", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8571), null, false, true, true, "/databaseimg/HALKOYUN-BURDUR-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURDUR E", "AKDENİZ", null, 0, 1500 },
                    { "04871b2a-5533-41da-9959-f664809887c3", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9111), null, null, true, true, "/databaseimg/HALKOYUN-TRABZONYELEK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON YELEK", "KARADENİZ", null, 0, 1500 },
                    { "04886a46-180e-42d2-a3e5-86df27efaee2", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8905), null, true, true, true, "/databaseimg/HALKOYUN-URFA-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "URFA K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "04a7d241-f761-4ead-803b-1d204df7bd53", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8418), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ ÜSKÜP-N2", null, null, 1500, null },
                    { "04c2c202-afa7-4e2c-941c-29f956783f6d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8621), null, true, true, true, "/databaseimg/HALKOYUN-SİLİFKE-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE K3", "AKDENİZ", null, 0, 1500 },
                    { "06c505ec-998c-46c0-9163-0188423113b3", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9020), null, false, true, true, "/databaseimg/HALKOYUN-ARTVİN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN E", "KARADENİZ", null, 0, 1500 },
                    { "074db959-27e0-42a0-98d9-0961864e1a7e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8895), null, true, true, true, "/databaseimg/HALKOYUN-GAZİANTEP-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP K3", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "0973a418-280f-416d-8df1-7139e28961d2", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8910), null, false, true, true, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", null, 0, 1500 },
                    { "09a2d110-7772-44cd-af5f-27fb951f0544", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9262), null, true, true, true, "/databaseimg/HALKOYUN-ÜSKÜPSİYAH-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP SİYAH K", "TRAKYA", null, 0, 1500 },
                    { "09ff2634-4a59-46ce-94c7-8428324d789f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8141), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 1500, null },
                    { "0a1ff474-48a1-4366-a120-8ece6ce5ba04", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8515), null, null, true, false, "/databaseimg/ROND-MANASTIR-YETİŞKİN-KİRALIK.jpg", "5rond", "MANASTIR", null, null, 1500, null },
                    { "0a7149b1-6928-4099-b623-787d0201e213", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9089), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K2", "KARADENİZ", null, 0, 1500 },
                    { "0bf06e4b-d062-4e01-a985-9b05e3f12fd6", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9220), null, null, true, true, "/databaseimg/HALKOYUN-TRAKYABEJ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA BEJ", "TRAKYA", null, 0, 1500 },
                    { "0c59ca0d-60e5-4686-80be-18ab36b53468", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7571), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 1500, null },
                    { "0dddae8d-37b4-47e5-9c89-95589a3f787a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9279), null, true, true, true, "/databaseimg/HALKOYUN-RENKLİSALTA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA RENKLİ SALTA", "TRAKYA", null, 0, 1500 },
                    { "0e9b45b3-2915-4dcd-99fa-77ad89f182a4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8031), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 1500, null },
                    { "0f1d6d17-8b8b-489d-a0f6-7349691aadd6", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7969), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 1500, null },
                    { "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7830), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 1500, null },
                    { "121345d8-2660-489c-a90d-2469b9c44222", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7794), null, null, false, false, "/databaseimg/RONDÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 1500, null },
                    { "142730b0-0df7-430d-ab80-e750ffe0a6ba", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8698), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRMOR-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR MOR", "EGE", null, 0, 1500 },
                    { "16b681bd-b39a-4891-ab7a-9073365bc1e7", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8663), null, false, true, true, "/databaseimg/HALKOYUN-DENİZLİ-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "DENİZLİ K", "EGE", null, 0, 1500 },
                    { "1a9626f8-303d-41e3-aa54-ae1a971ad179", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7772), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 1500, null },
                    { "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7756), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 1500, null },
                    { "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7491), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9063), null, true, true, true, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", null, 0, 1500 },
                    { "1f4cf9f5-2976-4b5c-9428-122096bf3877", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9257), null, true, true, true, "/databaseimg/HALKOYUN-ÜSKÜPKIRMIZI-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP KIRMIZI K", "TRAKYA", null, 0, 1500 },
                    { "2146af26-ce2b-461b-883b-e6f4fe0c8085", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7599), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 1500, null },
                    { "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8067), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 1500, null },
                    { "229759ff-14dd-4c4e-82aa-f56a2181c0ad", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7851), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 0, 1500 },
                    { "23672a63-2fd2-4e6a-905b-340ae4456b83", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7635), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 1500, null },
                    { "2838e6e6-1238-418a-988c-0346a2abdbc3", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8890), null, true, true, true, "/databaseimg/HALKOYUN-GAZİANTEP-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP K2", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "286d76ad-723d-476b-aa84-c7a6541afe81", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9132), null, false, true, true, "/databaseimg/HALKOYUN-BURSA-E2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURSA E2", "MARMARA", null, 0, 1500 },
                    { "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7883), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 0, 1500 },
                    { "299be826-3901-425f-90eb-e445e73ac37c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8603), null, false, true, true, "/databaseimg/HALKOYUN-SİLİFKE-E2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE E2", "AKDENİZ", null, 0, 1500 },
                    { "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7692), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 1500, null },
                    { "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8598), null, false, true, true, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", null, 0, 1500 },
                    { "2b514c67-a65f-4c0a-86b8-5bf92a974c34", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8109), null, true, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "2bc1e669-d825-44a8-a11c-656a8209498a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9007), null, true, true, true, "/databaseimg/HALKOYUN-KAFKAS-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS K3", "KAFKAS", null, 0, 1500 },
                    { "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9274), null, false, true, true, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", null, 0, 1500 },
                    { "2e5e4216-4af5-4fb6-9c65-8989715e5a40", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7708), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 1500, null },
                    { "31b00595-bfeb-47b6-9af3-91d117e003d4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8173), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI", null, null, 1500, null },
                    { "31b3b531-3e47-4ccb-9cc9-8e7aafedb810", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8863), null, false, true, true, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "334d6d7e-422b-4376-ac30-161f98aab66d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8948), null, true, true, true, "/databaseimg/HALKOYUN-TOKAT-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TOKAT K2", "İÇ ANADOLU", null, 0, 1500 },
                    { "3396c18a-dcd2-4638-8827-2c7fc10d6996", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9216), null, null, true, true, "/databaseimg/HALKOYUN-PEMBERENKLİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA PEMBE RENKLİ", "TRAKYA", null, 0, 1500 },
                    { "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7958), null, true, true, false, "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "364cd9de-6ddd-47d6-a534-74f3f00a0b7c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8502), null, null, true, false, "/databaseimg/ROND-FERACE-YETİŞKİN-KİRALIK.jpg", "5rond", "FERACE", null, null, 1500, null },
                    { "3770c1af-e181-494b-8c1a-c6f09a3b825a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7777), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 1500, null },
                    { "38af7185-32ce-4cf9-95d2-52c4c4d18bce", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8885), null, true, true, true, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "38c1edea-3339-4f95-8d4a-5f5583660d9f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8545), null, null, true, false, "/databaseimg/ROND-YENİÇERİ-YETİŞKİN-KİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 1500, null },
                    { "39c8cf49-d75e-4703-8958-ec3bbff87723", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8747), null, true, true, true, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", null, 0, 1500 },
                    { "39c99f61-efbf-4f5c-b084-eac381d82049", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9185), null, null, true, true, "/databaseimg/HALKOYUN-MANASTIRKAFTAN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MANASTIR KAFTAN", "TRAKYA", null, 0, 1500 },
                    { "39f01cd0-ae41-4070-9eb0-0f2423cc3286", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8756), null, true, true, true, "/databaseimg/HALKOYUN-ERZİNCAN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ERZİNCAN", "DOGU ANADOLU", null, 0, 1500 },
                    { "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8702), null, true, true, true, "/databaseimg/HALKOYUN-MUĞLA-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MUĞLA K", "EGE", null, 0, 1500 },
                    { "3d6e031d-2fcc-46ce-9eb7-268e95ae1323", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8843), null, true, true, true, "/databaseimg/HALKOYUN-ADANA-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADANA K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "3d704609-8abd-4a0a-80dd-2ee9f38a3608", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8467), null, null, true, false, "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN TURUNCU", null, "ROMAN", 1500, null },
                    { "3da92c21-3bf0-4de1-a187-459271e16106", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8848), null, true, true, true, "/databaseimg/HALKOYUN-ADANA-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADANA K2", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "3e2f7a5f-b665-4b13-861e-c5a5029216a0", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7866), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 0, 1500 },
                    { "3f6f1dbc-9042-42c2-85ca-a117c745c5e8", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7737), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 1500, null },
                    { "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7856), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 0, 1500 },
                    { "41c0e64a-97f8-45fa-a2b3-399ed47cddcc", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8234), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT", null, null, 1500, null },
                    { "43606bc6-5874-4469-bcdf-fe1b86f66882", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7594), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 1500, null },
                    { "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7543), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "43bf1028-ea0f-439a-b940-3b81b1f4d683", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9231), null, null, true, true, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 0, 1500 },
                    { "43c746aa-0830-449b-a594-621f04923cf6", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8631), null, false, true, true, "/databaseimg/HALKOYUN-AYDIN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AYDIN E", "EGE", null, 0, 1500 },
                    { "43ca244e-8d5a-468b-b327-ce6bdc541cf7", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7742), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 1500, null },
                    { "43f658bf-a5f4-4537-a281-77dbb5ce1c27", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8014), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 1500, null },
                    { "4534cffd-7ed4-406c-9cee-23179740daba", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8432), null, null, true, false, "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", "4dans", "ÇİFTETELLİ BEYAZ", null, "ÇİFTETELLİ", 1500, null },
                    { "46c82189-5271-43ba-97aa-a7b0a7dbf126", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9030), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", null, 0, 1500 },
                    { "4779905b-91b3-4878-97e0-58a010668be5", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8057), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 1500, null },
                    { "4a450a7f-5ca6-42f5-9931-e130264c8e0c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8127), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 1500, null },
                    { "4a67e8f3-4dec-41ad-a5e7-18995a14535d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7763), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 1500, null },
                    { "4aa47021-28ed-4c36-81c3-6e2734d3873b", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7673), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "4b376f71-ebf0-4762-bbff-e61541afa410", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8922), null, true, true, true, "/databaseimg/HALKOYUN-ESKİŞEHİR-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ESKİŞEHİR K2", "İÇ ANADOLU", null, 0, 1500 },
                    { "4b656abf-bdc5-4058-a12b-488d93cc1677", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7816), null, null, false, false, "/databaseimg/RONDİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 1500, null },
                    { "4c0b609e-a2cc-4477-b8d7-9fec89d49462", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8497), null, null, true, false, "/databaseimg/ROND-ÇANAKKALEASKERİ-YETİŞKİN-KİRALIK.jpg", "5rond", "ÇANAKKALE ASKERİ", null, null, 1500, null },
                    { "4e99c977-d86c-48a7-8bd8-9e71d999539a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8668), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRAÇIK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR AÇIK", "EGE", null, 0, 1500 },
                    { "4f8cc09d-7512-44d8-a98c-3004c93031f0", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8157), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK PEMBE", "EGE", "ZEYBEK", 1500, null },
                    { "50680664-523a-475b-869f-0aa5e0cd88b4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7559), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 1500, null },
                    { "523db500-84c9-42fa-bf24-f66e77e724e5", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8098), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "52a0bd63-231d-4620-9e7a-10b6d4fb8b65", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7622), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 1500, null },
                    { "541a5387-302a-478d-99f2-c98f6d979aaa", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8672), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRFUŞYA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR FUŞYA", "EGE", null, 0, 1500 },
                    { "55f0346e-6b98-4a1d-99f8-463b81f6a627", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9169), null, null, true, true, "/databaseimg/HALKOYUN-KIRMIZIRENKLİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KIRMIZI RENKLİ", "TRAKYA", null, 0, 1500 },
                    { "56072689-4550-44be-987e-b08667758de4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8163), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MUĞLA", "EGE", "ZEYBEK", 1500, null },
                    { "564ea3f5-665c-45f3-85ee-e4c45d3ba362", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9073), null, false, true, true, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", null, 0, 1500 },
                    { "5754a3be-8508-452d-8a64-9d752bde4f70", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7937), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 1500, null },
                    { "5787a57d-27d4-4dd2-b5e1-35e4125a6e94", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8646), null, true, true, true, "/databaseimg/HALKOYUN-ÇANAKKALE-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÇANAKKALE K", "EGE", null, 0, 1500 },
                    { "5a04a2e5-489b-4671-933a-1db0a971f40e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8943), null, true, true, true, "/databaseimg/HALKOYUN-TOKAT-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TOKAT K", "İÇ ANADOLU", null, 0, 1500 },
                    { "5a382843-9817-449b-b9d8-4e48d90aef5e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7697), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 1500, null },
                    { "5a529282-1b91-46d6-b472-e6386b95cf5d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9174), null, true, true, true, "/databaseimg/HALKOYUN-KORDONEFK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KORDONE FK", "TRAKYA", null, 0, 1500 },
                    { "5b26e8ac-df32-4b9d-8992-047e22372332", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7929), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 1500, null },
                    { "5b36c084-dce0-4ba9-ba55-613210750e27", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8074), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 1500, null },
                    { "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9057), null, false, true, true, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", null, 0, 1500 },
                    { "5cc37e11-afea-478b-b360-1256896a421b", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8873), null, null, true, true, "/databaseimg/HALKOYUN-GAZİANTEPABA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP ABA", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7719), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 1500, null },
                    { "5eaed820-0af4-4157-8fea-1f58baa77661", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8146), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 1500, null },
                    { "5f9a2c76-50a5-4e93-95c9-158ae078c357", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8192), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MÜRDÜM", null, null, 1500, null },
                    { "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8520), null, null, true, false, "/databaseimg/ROND-MEHTER-YETİŞKİN-KİRALIK.jpg", "5rond", "MEHTER", null, null, 1500, null },
                    { "6183a2d7-d2c5-4828-bccb-754ce1bbb002", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8224), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI", null, null, 1500, null },
                    { "618fdb18-11c3-4166-9bb1-79298a32a7a4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7703), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 1500, null },
                    { "61efcce3-e4ac-4aa6-ae46-1b7976b5da88", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9024), null, false, true, true, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN E2", "KARADENİZ", null, 0, 1500 },
                    { "64a56e1a-be01-40b0-bc09-1fcaf2161c10", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8970), null, true, true, true, "/databaseimg/HALKOYUN-GÜRCÜ-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GÜRCÜ K", "KAFKAS", null, 0, 1500 },
                    { "674202c6-8a9b-4c1f-9eae-0ab056cef8d6", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8651), null, null, true, true, "/databaseimg/HALKOYUN-ÇANAKKALEPOMAK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÇANAKKALE POMAK", "EGE", null, 0, 1500 },
                    { "676211f2-1f90-4059-bdf8-9e26f9a637a4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7998), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "6883361b-7a86-49b9-8fc2-90029770fe22", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8636), null, true, true, true, "/databaseimg/HALKOYUN-AYDIN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AYDIN K", "EGE", null, 0, 1500 },
                    { "69191d39-5c1b-4261-b0d7-48a7833e08bd", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8103), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "69920a1e-2cdf-4b1a-a9cc-329b986e4b69", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8477), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI E", null, null, 1500, null },
                    { "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8815), null, true, true, true, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", null, 0, 1500 },
                    { "6bdd753a-2706-48b6-b485-23c989a5f326", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7789), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 1500, null },
                    { "6c4014cc-3cc2-481d-9cd6-b13c45da0908", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9126), null, false, true, true, "/databaseimg/HALKOYUN-BURSA-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURSA E", "MARMARA", null, 0, 1500 },
                    { "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8215), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ BORDO", null, null, 1500, null },
                    { "6e0185cc-235f-4603-9470-5f4ca7c92514", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7806), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 1500, null },
                    { "6eee1f90-a40d-4d95-9ca6-0e45689398be", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7942), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 1500, null },
                    { "6f001fcf-f1b6-4abb-8d91-7038044fabfa", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8536), null, null, true, false, "/databaseimg/ROND-PADİŞAH-YETİŞKİN-KİRALIK.jpg", "5rond", "PADİŞAH", null, null, 1500, null },
                    { "6f055d63-314e-4a36-86eb-ea7e11e820c1", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8820), null, true, true, true, "/databaseimg/HALKOYUN-VANLACİVERT-YETİŞKİN-SATILIK.jpg", "2halkoyun", "VAN LACİVERT", "DOGU ANADOLU", null, 0, 1500 },
                    { "6f154805-6e66-45a6-a147-87edf4267def", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8853), null, false, true, true, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "6f169352-0f68-4d11-b562-f693a0158100", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7604), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 1500, null },
                    { "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7536), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 1500, null },
                    { "6fe7b587-9518-460f-8c8f-7aa43ad55f9c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7987), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8486), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ E", null, null, 1500, null },
                    { "7203c646-e705-48d1-8141-b2619b227d8d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8511), null, null, true, false, "/databaseimg/ROND-KARAGÖZ-YETİŞKİN-KİRALIK.jpg", "5rond", "KARAGÖZ", null, null, 1500, null },
                    { "72d46b9b-612d-41c4-8303-8f8571771de9", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7840), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 1500, null },
                    { "731dd6c2-2937-4d4b-8c56-63b5cf581729", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9190), null, null, true, true, "/databaseimg/HALKOYUN-MANASTIRYELEK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MANASTIR YELEK", "TRAKYA", null, 0, 1500 },
                    { "74770ec2-4585-4665-8f69-b2f0d4f0fc7f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9252), null, true, true, true, "/databaseimg/HALKOYUN-ÜSKÜPBEYAZ-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP BEYAZ K", "TRAKYA", null, 0, 1500 },
                    { "748cbc1e-8d05-4f4f-8196-9cfb28db232c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8052), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 1500, null },
                    { "74aa5d7a-f513-4993-b672-cdf9bb448319", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8025), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 1500, null },
                    { "752bc953-0f26-4a2c-afd2-45c5f0b9aecb", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8986), null, false, true, true, "/databaseimg/HALKOYUN-KAFKAS-E3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS E3", "KAFKAS", null, 0, 1500 },
                    { "75ce2f59-fa25-4745-bb37-371fc11ab655", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8583), null, true, true, true, "/databaseimg/HALKOYUN-BURDUR-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURDUR K2", "AKDENİZ", null, 0, 1500 },
                    { "77035e08-21a9-4149-8d7c-d4266f88ad03", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7714), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 1500, null },
                    { "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8088), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "777bd2e2-cd9e-4d51-b191-c81eb9d113cc", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8641), null, false, true, true, "/databaseimg/HALKOYUN-ÇANAKKALE-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÇANAKKALE E", "EGE", null, 0, 1500 },
                    { "78157107-23fa-4638-bd17-38187695312c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7678), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 1500, null },
                    { "7965d633-4f86-44de-8ea4-fe0c68aa6a83", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8801), null, true, true, true, "/databaseimg/HALKOYUN-VAN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", null, 0, 1500 },
                    { "79876823-dd75-471e-b2b5-80650a4bdd47", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8541), null, null, true, false, "/databaseimg/ROND-SEMAZEN-YETİŞKİN-KİRALIK.jpg", "5rond", "SEMAZEN", null, null, 1500, null },
                    { "7a3ccc47-8f30-4952-8909-ed3537cfe7e5", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8046), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 1500, null },
                    { "7a7cb657-507c-4325-a047-f9d67b6fbffc", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8868), null, true, true, true, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "7ac3fbad-b279-4d80-a8d7-ff1407a6465f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8626), null, true, true, true, "/databaseimg/HALKOYUN-AFYON-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AFYON K", "EGE", null, 0, 1500 },
                    { "7d543840-b11e-4380-a147-7dab483cf5ce", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7639), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 1500, null },
                    { "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7687), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "809d901e-d7de-4fec-aa95-655deb2301b6", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7825), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 1500, null },
                    { "80f38d33-7c5f-4952-809c-85af1dc69962", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9068), null, null, true, true, "/databaseimg/HALKOYUN-TRABZONCEPKEN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON CEPKEN", "KARADENİZ", null, 0, 1500 },
                    { "815f578a-5fd8-4c79-8446-ff236b6ffafb", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8446), null, null, true, false, "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, "ROMAN", 1500, null },
                    { "8191402a-33f8-4195-bd73-3aa71191981e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9211), null, null, true, true, "/databaseimg/HALKOYUN-MORMONORAY-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 0, 1500 },
                    { "81c921f4-7fd6-428a-aefe-648e5e11ed46", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8938), null, true, true, true, "/databaseimg/", "2halkoyun", "SİVAS K", "İÇ ANADOLU", null, 0, 1500 },
                    { "81cb9635-df03-42c8-8d68-944f99de02ca", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8209), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN YEŞİL", null, null, 1500, null },
                    { "827e88a3-8580-436c-9112-02d58ca2d7d0", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8980), null, false, true, true, "/databaseimg/HALKOYUN-KAFKAS-E2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS E2", "KAFKAS", null, 0, 1500 },
                    { "85634f26-c60b-4cc5-8c0f-0fad3182a5f3", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8879), null, false, true, true, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "8601b2c5-4e87-49e4-9099-8c21a9ca00b4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7549), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "86513d65-cf7e-49d6-bd16-94286e5d60c1", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9243), null, true, true, true, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP BORDO K", "TRAKYA", null, 0, 1500 },
                    { "8906cf96-12d6-4eca-8a0b-d39dd78dc597", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7899), null, null, false, false, "/databaseimg/RONDSTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 0, 1500 },
                    { "89c5b8e4-4c60-4e08-88ad-4509be08bde4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7979), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 1500, null },
                    { "8a84a13e-c0cc-4496-81a8-f4550c5807ed", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9100), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K4", "KARADENİZ", null, 0, 1500 },
                    { "8abdfc01-6b02-4b55-93d3-eea25b17de37", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8122), null, true, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 1500, null },
                    { "8ad91c05-ccae-4482-9f43-f8f197dccdf9", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8531), null, null, true, false, "/databaseimg/ROND-NOELBABA-YETİŞKİN-KİRALIK.jpg", "5rond", "NOEL BABA", null, null, 1500, null },
                    { "8af7be7f-0ff6-40e1-b206-e89d78430393", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8481), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI K", null, null, 1500, null },
                    { "8cefc01c-282b-4866-a0fa-238ed864481c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8928), null, true, true, true, "/databaseimg/", "2halkoyun", "ESKİŞEHİR K3", "İÇ ANADOLU", null, 0, 1500 },
                    { "8d1f8204-852a-4342-b836-767fb2b71263", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9014), null, true, true, true, "/databaseimg/HALKOYUN-KAFKAS-K4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS K4", "KAFKAS", null, 0, 1500 },
                    { "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8765), null, true, true, true, "/databaseimg/HALKOYUN-ERZURUM-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ERZURUM E", "DOGU ANADOLU", null, 0, 1500 },
                    { "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7512), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "9017f445-e420-4568-b8d9-0d84b3c46aad", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8656), null, false, true, true, "/databaseimg/HALKOYUN-DENİZLİ-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "DENİZLİ E", "EGE", null, 0, 1500 },
                    { "91cb02d4-02ee-4632-a12b-7aaa4b220344", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8613), null, true, true, true, "/databaseimg/HALKOYUN-SİLİFKE-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE K2", "AKDENİZ", null, 0, 1500 },
                    { "924916c0-2ad0-493a-b544-5df45fa43152", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9121), null, true, true, true, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BOLU K", "MARMARA", null, 0, 1500 },
                    { "92a51416-05b5-47ef-834f-ad0baccbb932", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8693), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRMÜRDÜM-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR MÜRDÜM", "EGE", null, 0, 1500 },
                    { "932c7c4b-36c5-4580-a276-a176a72fd72d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8566), null, true, true, true, "/databaseimg/HALKOYUN-ANAMUR-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ANAMUR K", "AKDENİZ", null, 0, 1500 },
                    { "9377deeb-6354-4346-8d56-03b29c97d5fc", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8715), null, false, true, true, "/databaseimg/HALKOYUN-AĞRI-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AĞRI E", "DOGU ANADOLU", null, 0, 1500 },
                    { "93c17f7a-aedf-4f6d-8429-df9ff308d381", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9094), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K3", "KARADENİZ", null, 0, 1500 },
                    { "94430690-6bd2-4e48-b0c3-4de11c7f5d81", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7974), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 1500, null },
                    { "9445ce49-5efd-41b8-bdab-b8d7f350b5e2", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7566), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "9570f221-d5cb-4963-896f-371af0b32c79", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8900), null, false, true, true, "/databaseimg/HALKOYUN-URFA-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "URFA E", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "958017ca-725f-4d80-b65e-79560a051a03", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8739), null, true, true, true, "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", null, 0, 1500 },
                    { "976d92d5-de98-47ea-a219-26842c7f8caf", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8219), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ GRİ-SİYAH", null, null, 1500, null },
                    { "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7747), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 1500, null },
                    { "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7730), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 1500, null },
                    { "9c301f9b-43b4-4015-bc1d-70ad1b2b690e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8137), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "9f0127f0-a604-46ba-a855-ca6be06fcdb2", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8734), null, false, true, true, "/databaseimg/HALKOYUN-BİTLİS-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", null, 0, 1500 },
                    { "9f2f3880-4997-4c0b-88e8-f9a74f8b1564", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9116), null, true, true, true, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", null, 0, 1500 },
                    { "a07ed297-38cd-456e-834f-c31583eab987", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8093), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "a08d4c19-059b-42bc-83db-26206735e40f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8036), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "a278895c-19b5-45c6-92f9-48c5f2724e8a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7682), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 1500, null },
                    { "a2a34d3f-9082-4d98-9637-2bd936e60256", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9083), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K", "KARADENİZ", null, 0, 1500 },
                    { "a2bcb56b-1da2-43fc-b133-3b5c04603123", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7783), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 1500, null },
                    { "a34e2f74-5403-4e43-bc88-30019ebd460f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7895), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 0, 1500 },
                    { "a39041d7-3a20-4e73-9334-3fc6d8327e06", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8608), null, true, true, true, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", null, 0, 1500 },
                    { "a4efe1b6-e7fb-4cee-96aa-1125a3888791", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8453), null, null, true, false, "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, "ROMAN", 1500, null },
                    { "a907697f-9b47-4302-87f3-c4bed83b24c9", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8725), null, false, true, true, "/databaseimg/HALKOYUN-ARDAHAN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARDAHAN E", "DOGU ANADOLU", null, 0, 1500 },
                    { "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7629), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 1500, null },
                    { "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7751), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 1500, null },
                    { "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9206), null, null, true, true, "/databaseimg/HALKOYUN-MORSALTA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA MOR SALTA", "TRAKYA", null, 0, 1500 },
                    { "ad918937-0645-4b89-86d5-0672662fd46e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7616), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 1500, null },
                    { "aee09720-0d54-473a-b585-c62d6c516e68", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8152), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9002), null, true, true, true, "/databaseimg/HALKOYUN-KAFKAS-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS K2", "KAFKAS", null, 0, 1500 },
                    { "b1dae3fe-91d2-42cc-8ba7-dcf237882eac", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8682), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRKOYU-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR KOYU", "EGE", null, 0, 1500 },
                    { "b2b71d89-5501-4bd6-a358-aca8ce706bdb", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7909), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 0, 1500 },
                    { "b5b67003-636d-425d-9784-45d374db713c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7518), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 1500, null },
                    { "b5e13a1d-86f3-415c-9c2f-4343258a4b57", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7964), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7904), null, null, false, false, "/databaseimg/RONDSTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 0, 1500 },
                    { "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8229), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI-N2", null, null, 1500, null },
                    { "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8182), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N3", null, null, 1500, null },
                    { "b8b726c6-227d-4267-8dba-c1bf5ec0301f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7799), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 1500, null },
                    { "b8cc3bd3-ac03-46c4-820b-f7988f3088f7", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9201), null, null, true, true, "/databaseimg/HALKOYUN-MORRENKLİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA MOR RENKLİ", "TRAKYA", null, 0, 1500 },
                    { "bac28c61-4b74-4193-a109-f4456c44cf67", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8436), null, null, true, false, "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", "4dans", "LİRİK", null, null, 1500, null },
                    { "bb1dfb9b-70aa-495e-a041-156a4fbb4fec", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8423), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ YEŞİL", null, null, 1500, null },
                    { "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8720), null, null, true, true, "/databaseimg/HALKOYUN-AĞRIKADİFE-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AĞRI KADİFE", "DOGU ANADOLU", null, 0, 1500 },
                    { "bd0cb50a-e769-48ed-8473-b25faa687e15", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7644), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 1500, null },
                    { "beacb4b7-e74c-45d8-b8df-60e1a2a50768", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9236), null, null, true, true, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 0, 1500 },
                    { "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8790), null, true, true, true, "/databaseimg/HALKOYUN-HAKKARİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "HAKKARİ", "DOGU ANADOLU", null, 0, 1500 },
                    { "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7579), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "c15e0f9b-39be-49ff-aff8-1800116358f7", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8413), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE-N2", null, null, 1500, null },
                    { "c24852f9-007d-455a-8cb5-0e2681c7a0a5", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8003), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "c35ccc97-39f5-4396-bbe1-2a6171f30d10", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7820), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 1500, null },
                    { "c37d754a-9f08-4f13-8d26-630d896c9371", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8975), null, false, true, true, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 0, 1500 },
                    { "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8187), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MOR", null, null, 1500, null },
                    { "c474ff32-d65e-4d11-90a2-f9ad2e8ee772", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8408), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE", null, null, 1500, null },
                    { "c50585c6-d1df-4eaa-b5bf-317678e7d3bb", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8997), null, true, true, true, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 0, 1500 },
                    { "c5381f46-f707-4fcb-8f1e-605cee507946", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8588), null, false, true, true, "/databaseimg/HALKOYUN-MUT-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MUT E", "AKDENİZ", null, 0, 1500 },
                    { "c5d36e60-0945-4e35-9239-22f30c29025f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9179), null, true, true, true, "/databaseimg/HALKOYUN-LASELİFK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "LASELİ FK", "TRAKYA", null, 0, 1500 },
                    { "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7666), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 1500, null },
                    { "c6633a62-08d6-4613-8f06-a3fcfd76f974", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8833), null, false, true, true, "/databaseimg/HALKOYUN-ADANAABA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADANA ABA", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "c6fcf873-e9c2-43c9-81ec-ba09bd063e13", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9247), null, null, true, true, "/databaseimg/HALKOYUN-ÜSKÜPBEYAZCEPKEN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP BEYAZ CEPKEN", "TRAKYA", null, 0, 1500 },
                    { "c87ce8ae-adb7-4007-8c0e-0090d0926e2e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9040), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K3", "KARADENİZ", null, 0, 1500 },
                    { "c8e6b9db-dbc9-4d49-a473-2c8593982b56", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8168), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN BORDO", null, null, 1500, null },
                    { "c8eeda2a-0260-4488-9acf-fddaee71e124", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8506), null, null, true, false, "/databaseimg/ROND-HACİVAT-YETİŞKİN-KİRALIK.jpg", "5rond", "HACİVAT", null, null, 1500, null },
                    { "c941ed50-01c0-472d-8122-3756b9b55a29", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7888), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 0, 1500 },
                    { "c99efd04-1f14-49e6-bd60-208290d057a6", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8178), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N2", null, null, 1500, null },
                    { "cae31f17-a52f-4ac3-97bb-6886500b19bf", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7871), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 0, 1500 },
                    { "caf33f50-8517-4995-a849-4a70bbe202f6", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8825), null, false, true, true, "/databaseimg/HALKOYUN-ADANA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADANA", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7661), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 1500, null },
                    { "cd21938d-8cdf-4c18-a25a-73a2970c2deb", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8525), null, null, true, false, "/databaseimg/ROND-NOELANNE-YETİŞKİN-KİRALIK.jpg", "5rond", "NOEL ANNE", null, null, 1500, null },
                    { "cd3167af-629a-4795-8c18-cf4f49e0a7d1", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8083), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "cd3be091-3d72-4512-ba1d-e8466285b930", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7811), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 1500, null },
                    { "ceaa3043-fb10-4638-b942-85d7b5fc20ed", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8858), null, true, true, true, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9035), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K2", "KARADENİZ", null, 0, 1500 },
                    { "cf03ef83-babf-4710-ab13-ace35476b474", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7947), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8730), null, true, true, true, "/databaseimg/HALKOYUN-ARDAHAN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARDAHAN K", "DOGU ANADOLU", null, 0, 1500 },
                    { "cfb34052-097c-4637-b13e-86a2bc255163", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9159), null, null, true, true, "/databaseimg/HALKOYUN-BORDOCEPKEN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BORDO CEPKEN", "TRAKYA", null, 0, 1500 },
                    { "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9226), null, null, true, true, "/databaseimg/HALKOYUN-TRAKYAÇAĞLA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA ÇAĞLA", "TRAKYA", null, 0, 1500 },
                    { "d302b7f9-1306-4a95-85d4-ff189df4b527", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8457), null, null, true, false, "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN PEMBE", null, "ROMAN", 1500, null },
                    { "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8593), null, true, true, true, "/databaseimg/HALKOYUN-MUT-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MUT K", "AKDENİZ", null, 0, 1500 },
                    { "d501bc94-2256-4ce7-b0bf-be4357ada814", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7656), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 1500, null },
                    { "d6003f61-89ae-4240-b53c-542ab36728ca", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7768), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 1500, null },
                    { "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9106), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K5-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K5", "KARADENİZ", null, 0, 1500 },
                    { "d7a31657-3101-42e7-8b97-aa6ff61d3e84", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8114), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 1500, null },
                    { "d99cdf9c-bda7-4807-b92e-34b3de2e6002", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8019), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 1500, null },
                    { "db5aeda4-2830-4ddd-a7ca-02363d58bf25", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8550), null, null, true, true, "/databaseimg/HALKOYUN-AŞUKMAŞUK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AŞUK MAŞUK", "AKDENİZ", null, 0, 1500 },
                    { "db604d4c-9f40-48f5-b244-9b3bdcaf71c1", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8041), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "db9ccc9b-5149-474b-a0b4-af8a13f01bc2", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8958), null, null, true, true, "/databaseimg/HALKOYUN-YOZGAT-YETİŞKİN-SATILIK.jpg", "2halkoyun", "YOZGAT", "İÇ ANADOLU", null, 0, 1500 },
                    { "dc91cbb3-94e1-43fe-bf92-06077cf48d87", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9045), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K4", "KARADENİZ", null, 0, 1500 },
                    { "dc94da97-75b3-48b7-bfb6-d46984b5f106", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8462), null, null, true, false, "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN RENKLİ ETEK", null, "ROMAN", 1500, null },
                    { "dd438551-3d93-45bc-982d-7c338b69983b", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7589), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 1500, null },
                    { "e0f91ecb-de8b-44fb-9a15-59c38d5093b4", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8427), null, null, true, false, "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", "4dans", "AŞUK MAŞUK", null, null, 1500, null },
                    { "e35c267e-66ab-453d-ba33-a31c4ce7e5ed", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8202), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN PEMBE", null, null, 1500, null },
                    { "e7d54d6e-42fe-472b-b696-6642067802b3", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9165), null, null, true, true, "/databaseimg/HALKOYUN-BORDOKISAYELEK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BORDO KISA YELEK", "TRAKYA", null, 0, 1500 },
                    { "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9194), null, null, true, true, "/databaseimg/HALKOYUN-MORMARAŞİŞİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MOR MARAŞ İŞİ", "TRAKYA", null, 0, 1500 },
                    { "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(9050), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K5-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K5", "KARADENİZ", null, 0, 1500 },
                    { "e9ca0d20-0315-4fca-b334-e6e046cd076e", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7992), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "ea3367e6-6d1c-4e58-883a-b18d66f30f8b", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7585), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "ea59937e-0296-4758-95ad-196fce18db72", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8915), null, true, true, true, "/databaseimg/HALKOYUN-ESKİŞEHİR-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ESKİŞEHİR K", "İÇ ANADOLU", null, 0, 1500 },
                    { "eb3e277a-61f3-4f55-b179-d474841a80a3", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8492), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ K", null, null, 1500, null },
                    { "ed9ab94a-9354-48de-8695-43131a67bd2c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7877), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 0, 1500 },
                    { "eec8a34e-e0ea-4a80-bd38-c7db22f84173", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8710), null, null, true, true, "/databaseimg/HALKOYUN-AĞRIBEYAZ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AĞRI BEYAZ", "DOGU ANADOLU", null, 0, 1500 },
                    { "ef08937f-96ed-443c-80ac-1f7b764d10a1", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8688), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRKOYU2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR KOYU 2", "EGE", null, 0, 1500 },
                    { "ef23ec60-f223-44c4-915e-196d6b011b94", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8991), null, false, true, true, "/databaseimg/HALKOYUN-KAFKAS-E4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS E4", "KAFKAS", null, 0, 1500 },
                    { "efe2c4a0-7529-4f91-9026-696ea0a1f7b7", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8933), null, true, true, true, "/databaseimg/HALKOYUN-ESKİŞEHİR-K4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ESKİŞEHİR K4", "İÇ ANADOLU", null, 0, 1500 },
                    { "f03ff26b-30e9-4a60-b99a-780060db1e35", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7835), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 1500, null },
                    { "f102b409-56b3-42b4-b70c-25192033ba8d", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8964), null, true, true, true, "/databaseimg/HALKOYUN-ÇERKES-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÇERKES K", "KAFKAS", null, 0, 1500 },
                    { "f20906f6-cdbb-4f93-9ad0-87e63f0782ff", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7651), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7914), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "f39485eb-f82b-495c-8b60-7dada21ee477", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7554), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 1500, null },
                    { "f43faef4-2885-42c1-9035-ccc2667d7fca", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8241), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N2", null, null, 1500, null },
                    { "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7861), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 0, 1500 },
                    { "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(7530), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 1500, null },
                    { "f6edd915-a9e4-4713-8e0a-6f1d7efde18f", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8577), null, true, true, true, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", null, 0, 1500 },
                    { "f7062df1-beb7-4814-a074-e9da66830639", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8009), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 1500, null },
                    { "faa28a13-3b08-4a67-834d-621e4dd3d287", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8472), null, null, true, false, "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN YEŞİL", null, "ROMAN", 1500, null },
                    { "fb0deebe-ca58-4eb6-ac5b-67442c846405", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8245), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N3", null, null, 1500, null },
                    { "fc72a988-3078-4c69-a8ca-c0f1dc1ec996", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8560), null, false, true, true, "/databaseimg/HALKOYUN-ANAMUR-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ANAMUR E", "AKDENİZ", null, 0, 1500 },
                    { "fee54746-70cf-44dd-98df-5c09bb8959a8", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8810), null, true, true, true, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", null, 0, 1500 },
                    { "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8062), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 1500, null },
                    { "ffcc6812-deda-4b92-b2dd-0f59e0a46c44", new DateTime(2024, 12, 19, 4, 4, 55, 381, DateTimeKind.Local).AddTicks(8132), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 1500, null }
                });

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

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreatedAt", "SizeNumber" },
                values: new object[,]
                {
                    { "11ebdd3a-f75a-4d85-9916-220874cf8af9", new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(9713), 12 },
                    { "152002fb-d980-4750-a70a-7b5d0bdac9e4", new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(9717), 14 },
                    { "b9f3161c-2cf9-4a45-a6f9-13d4b32538ef", new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(9688), 8 },
                    { "baf2e21c-f1c7-4801-a8a0-6e59a809ed7d", new DateTime(2024, 12, 19, 4, 4, 55, 383, DateTimeKind.Local).AddTicks(9708), 10 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "52a4cd9f-166a-481d-890c-05e50257655c", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

            migrationBuilder.CreateIndex(
                name: "IX_SiteCommInfos_GSM1",
                table: "SiteCommInfos",
                column: "GSM1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiteCommInfos_GSM2",
                table: "SiteCommInfos",
                column: "GSM2",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiteCommInfos_GSM3",
                table: "SiteCommInfos",
                column: "GSM3",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FotoDesign_Id",
                table: "FotoDesign",
                column: "Id",
                unique: true);

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
                name: "IX_ProductSizes_SizeAmount",
                table: "ProductSizes",
                column: "SizeAmount");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_SizeId",
                table: "ProductSizes",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizes_SizeNumber",
                table: "ProductSizes",
                column: "SizeNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Size_Id",
                table: "Size",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketDetails_Products_ProductId",
                table: "BasketDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetail_Products_ProductId",
                table: "OrdersDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductRegions_ProductRegionId",
                table: "Products",
                column: "ProductRegionId",
                principalTable: "ProductRegions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductSubRegions_ProductSubRegionId",
                table: "Products",
                column: "ProductSubRegionId",
                principalTable: "ProductSubRegions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketDetails_Products_ProductId",
                table: "BasketDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetail_Products_ProductId",
                table: "OrdersDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductRegions_ProductRegionId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductSubRegions_ProductSubRegionId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "FotoDesign");

            migrationBuilder.DropTable(
                name: "ProductSizes");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropIndex(
                name: "IX_SiteCommInfos_GSM1",
                table: "SiteCommInfos");

            migrationBuilder.DropIndex(
                name: "IX_SiteCommInfos_GSM2",
                table: "SiteCommInfos");

            migrationBuilder.DropIndex(
                name: "IX_SiteCommInfos_GSM3",
                table: "SiteCommInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Id",
                table: "Products");

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
                table: "Products",
                keyColumn: "Id",
                keyValue: "00e2e1d5-5577-4f8e-b13b-dde82c77b91d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01388782-b75d-4762-8ccf-4499568fd455");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01e005f3-0bbb-4ae2-9136-f3afe1353315");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "034b18a2-33ad-4020-8d9d-5a98891d0be9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0418ebf4-0b73-4042-a5e4-ce396d5b512b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04871b2a-5533-41da-9959-f664809887c3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04886a46-180e-42d2-a3e5-86df27efaee2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04a7d241-f761-4ead-803b-1d204df7bd53");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04c2c202-afa7-4e2c-941c-29f956783f6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "06c505ec-998c-46c0-9163-0188423113b3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "074db959-27e0-42a0-98d9-0961864e1a7e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0973a418-280f-416d-8df1-7139e28961d2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09a2d110-7772-44cd-af5f-27fb951f0544");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09ff2634-4a59-46ce-94c7-8428324d789f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a1ff474-48a1-4366-a120-8ece6ce5ba04");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a7149b1-6928-4099-b623-787d0201e213");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0bf06e4b-d062-4e01-a985-9b05e3f12fd6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c59ca0d-60e5-4686-80be-18ab36b53468");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0dddae8d-37b4-47e5-9c89-95589a3f787a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e9b45b3-2915-4dcd-99fa-77ad89f182a4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f1d6d17-8b8b-489d-a0f6-7349691aadd6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "111c9f5f-bd2b-4fc2-9806-5f2e74eaacfb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "121345d8-2660-489c-a90d-2469b9c44222");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "142730b0-0df7-430d-ab80-e750ffe0a6ba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16b681bd-b39a-4891-ab7a-9073365bc1e7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a9626f8-303d-41e3-aa54-ae1a971ad179");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1bab3f06-eb4a-4e6f-8506-ce9fb7c7c56d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c370cf8-9f6e-42fa-b7f0-1dce0caa5364");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1da8a34a-6749-48bf-9df9-fe08cd5c7e3f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f4cf9f5-2976-4b5c-9428-122096bf3877");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2146af26-ce2b-461b-883b-e6f4fe0c8085");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "226fad45-0bcb-4ee2-a4de-0deb8baf8d4c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "229759ff-14dd-4c4e-82aa-f56a2181c0ad");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23672a63-2fd2-4e6a-905b-340ae4456b83");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2838e6e6-1238-418a-988c-0346a2abdbc3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "286d76ad-723d-476b-aa84-c7a6541afe81");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "289fa380-9e0f-4fbb-ab6f-4f462ee90f0a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "299be826-3901-425f-90eb-e445e73ac37c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a29a1d6-b3e1-4724-ba5e-8cbd92a1c34f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2aec24aa-3fd9-4bbf-9d1f-f614d8574a3d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2b514c67-a65f-4c0a-86b8-5bf92a974c34");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2bc1e669-d825-44a8-a11c-656a8209498a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d4dadd2-8e1d-495c-b6ab-c0e4d6b167ea");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e5e4216-4af5-4fb6-9c65-8989715e5a40");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b00595-bfeb-47b6-9af3-91d117e003d4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31b3b531-3e47-4ccb-9cc9-8e7aafedb810");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "334d6d7e-422b-4376-ac30-161f98aab66d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3396c18a-dcd2-4638-8827-2c7fc10d6996");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "35ecfa79-7e24-4e50-bb2f-05a1b4dc529b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "364cd9de-6ddd-47d6-a534-74f3f00a0b7c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3770c1af-e181-494b-8c1a-c6f09a3b825a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38af7185-32ce-4cf9-95d2-52c4c4d18bce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38c1edea-3339-4f95-8d4a-5f5583660d9f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c8cf49-d75e-4703-8958-ec3bbff87723");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39c99f61-efbf-4f5c-b084-eac381d82049");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39f01cd0-ae41-4070-9eb0-0f2423cc3286");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a4e5dbe-c93a-4de1-bf6d-fb249bda0f42");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d6e031d-2fcc-46ce-9eb7-268e95ae1323");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d704609-8abd-4a0a-80dd-2ee9f38a3608");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3da92c21-3bf0-4de1-a187-459271e16106");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e2f7a5f-b665-4b13-861e-c5a5029216a0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f6f1dbc-9042-42c2-85ca-a117c745c5e8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41ba1e6a-1ac7-4cee-902c-6bc1bc46641e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41c0e64a-97f8-45fa-a2b3-399ed47cddcc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43606bc6-5874-4469-bcdf-fe1b86f66882");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43b8b3e0-4ac0-4b56-b0b9-e49cd0d9edd1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43bf1028-ea0f-439a-b940-3b81b1f4d683");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43c746aa-0830-449b-a594-621f04923cf6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43ca244e-8d5a-468b-b327-ce6bdc541cf7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43f658bf-a5f4-4537-a281-77dbb5ce1c27");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4534cffd-7ed4-406c-9cee-23179740daba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "46c82189-5271-43ba-97aa-a7b0a7dbf126");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4779905b-91b3-4878-97e0-58a010668be5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a450a7f-5ca6-42f5-9931-e130264c8e0c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a67e8f3-4dec-41ad-a5e7-18995a14535d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4aa47021-28ed-4c36-81c3-6e2734d3873b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b376f71-ebf0-4762-bbff-e61541afa410");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b656abf-bdc5-4058-a12b-488d93cc1677");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c0b609e-a2cc-4477-b8d7-9fec89d49462");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e99c977-d86c-48a7-8bd8-9e71d999539a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f8cc09d-7512-44d8-a98c-3004c93031f0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50680664-523a-475b-869f-0aa5e0cd88b4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "523db500-84c9-42fa-bf24-f66e77e724e5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52a0bd63-231d-4620-9e7a-10b6d4fb8b65");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "541a5387-302a-478d-99f2-c98f6d979aaa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55f0346e-6b98-4a1d-99f8-463b81f6a627");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "56072689-4550-44be-987e-b08667758de4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "564ea3f5-665c-45f3-85ee-e4c45d3ba362");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5754a3be-8508-452d-8a64-9d752bde4f70");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5787a57d-27d4-4dd2-b5e1-35e4125a6e94");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a04a2e5-489b-4671-933a-1db0a971f40e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a382843-9817-449b-b9d8-4e48d90aef5e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a529282-1b91-46d6-b472-e6386b95cf5d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b26e8ac-df32-4b9d-8992-047e22372332");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b36c084-dce0-4ba9-ba55-613210750e27");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cb4b0a3-e8a7-4ba6-aa60-c88fc65ad77a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cc37e11-afea-478b-b360-1256896a421b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5e029621-e6b2-476c-9ad6-ce8d6ecc24f3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5eaed820-0af4-4157-8fea-1f58baa77661");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5f9a2c76-50a5-4e93-95c9-158ae078c357");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5fbb3a8c-ea2a-46e7-924a-1c9d40ee6c69");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6183a2d7-d2c5-4828-bccb-754ce1bbb002");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "618fdb18-11c3-4166-9bb1-79298a32a7a4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61efcce3-e4ac-4aa6-ae46-1b7976b5da88");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64a56e1a-be01-40b0-bc09-1fcaf2161c10");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "674202c6-8a9b-4c1f-9eae-0ab056cef8d6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "676211f2-1f90-4059-bdf8-9e26f9a637a4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6883361b-7a86-49b9-8fc2-90029770fe22");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69191d39-5c1b-4261-b0d7-48a7833e08bd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69920a1e-2cdf-4b1a-a9cc-329b986e4b69");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bbf3bb3-5dc3-4a5f-b9b7-03cc8fb02fb9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bdd753a-2706-48b6-b485-23c989a5f326");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c4014cc-3cc2-481d-9cd6-b13c45da0908");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d3fcb11-b20a-47f2-aab4-bbceb420ea3d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6e0185cc-235f-4603-9470-5f4ca7c92514");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6eee1f90-a40d-4d95-9ca6-0e45689398be");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f001fcf-f1b6-4abb-8d91-7038044fabfa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f055d63-314e-4a36-86eb-ea7e11e820c1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f154805-6e66-45a6-a147-87edf4267def");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f169352-0f68-4d11-b562-f693a0158100");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fa2bd76-8f79-42d6-ae51-2f7a95535f7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fe7b587-9518-460f-8c8f-7aa43ad55f9c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70d3e030-3eb8-4e54-9af9-d70e0ef78c1d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7203c646-e705-48d1-8141-b2619b227d8d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72d46b9b-612d-41c4-8303-8f8571771de9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "731dd6c2-2937-4d4b-8c56-63b5cf581729");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74770ec2-4585-4665-8f69-b2f0d4f0fc7f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "748cbc1e-8d05-4f4f-8196-9cfb28db232c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74aa5d7a-f513-4993-b672-cdf9bb448319");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "752bc953-0f26-4a2c-afd2-45c5f0b9aecb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75ce2f59-fa25-4745-bb37-371fc11ab655");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77035e08-21a9-4149-8d7c-d4266f88ad03");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "775cd819-72cc-4aa7-89ac-2e89dcbe5c0a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "777bd2e2-cd9e-4d51-b191-c81eb9d113cc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78157107-23fa-4638-bd17-38187695312c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7965d633-4f86-44de-8ea4-fe0c68aa6a83");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "79876823-dd75-471e-b2b5-80650a4bdd47");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a3ccc47-8f30-4952-8909-ed3537cfe7e5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a7cb657-507c-4325-a047-f9d67b6fbffc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7ac3fbad-b279-4d80-a8d7-ff1407a6465f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7d543840-b11e-4380-a147-7dab483cf5ce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7e6e25fd-0c9c-44ea-b2cf-61f70a9fd3ce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "809d901e-d7de-4fec-aa95-655deb2301b6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "80f38d33-7c5f-4952-809c-85af1dc69962");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "815f578a-5fd8-4c79-8446-ff236b6ffafb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8191402a-33f8-4195-bd73-3aa71191981e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81c921f4-7fd6-428a-aefe-648e5e11ed46");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81cb9635-df03-42c8-8d68-944f99de02ca");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "827e88a3-8580-436c-9112-02d58ca2d7d0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85634f26-c60b-4cc5-8c0f-0fad3182a5f3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8601b2c5-4e87-49e4-9099-8c21a9ca00b4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86513d65-cf7e-49d6-bd16-94286e5d60c1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8906cf96-12d6-4eca-8a0b-d39dd78dc597");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "89c5b8e4-4c60-4e08-88ad-4509be08bde4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8a84a13e-c0cc-4496-81a8-f4550c5807ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8abdfc01-6b02-4b55-93d3-eea25b17de37");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8ad91c05-ccae-4482-9f43-f8f197dccdf9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8af7be7f-0ff6-40e1-b206-e89d78430393");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8cefc01c-282b-4866-a0fa-238ed864481c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d1f8204-852a-4342-b836-767fb2b71263");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d290951-033a-4adf-8dd9-f8ca4d9d1f2d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f39d68e-fbf3-4323-8c5a-d8b55cffef2a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9017f445-e420-4568-b8d9-0d84b3c46aad");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91cb02d4-02ee-4632-a12b-7aaa4b220344");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "924916c0-2ad0-493a-b544-5df45fa43152");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92a51416-05b5-47ef-834f-ad0baccbb932");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "932c7c4b-36c5-4580-a276-a176a72fd72d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9377deeb-6354-4346-8d56-03b29c97d5fc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93c17f7a-aedf-4f6d-8429-df9ff308d381");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "94430690-6bd2-4e48-b0c3-4de11c7f5d81");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9445ce49-5efd-41b8-bdab-b8d7f350b5e2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9570f221-d5cb-4963-896f-371af0b32c79");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "958017ca-725f-4d80-b65e-79560a051a03");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "976d92d5-de98-47ea-a219-26842c7f8caf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9880f4c6-87bd-42a6-8c30-f00b3b4e1f8e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98e89d8e-aa22-4ba3-8e1d-0ccc1e9f3747");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c301f9b-43b4-4015-bc1d-70ad1b2b690e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f0127f0-a604-46ba-a855-ca6be06fcdb2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f2f3880-4997-4c0b-88e8-f9a74f8b1564");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a07ed297-38cd-456e-834f-c31583eab987");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a08d4c19-059b-42bc-83db-26206735e40f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a278895c-19b5-45c6-92f9-48c5f2724e8a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2a34d3f-9082-4d98-9637-2bd936e60256");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2bcb56b-1da2-43fc-b133-3b5c04603123");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a34e2f74-5403-4e43-bc88-30019ebd460f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a39041d7-3a20-4e73-9334-3fc6d8327e06");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4efe1b6-e7fb-4cee-96aa-1125a3888791");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a907697f-9b47-4302-87f3-c4bed83b24c9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9f573a8-2c98-4861-9a93-b90d3e8bc6fa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aca583cc-1e5b-4db1-a9d4-6d8d53ae7e67");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad0f7b6d-0d38-4cb4-b7c9-e4f2dede5654");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad918937-0645-4b89-86d5-0672662fd46e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aee09720-0d54-473a-b585-c62d6c516e68");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1a72d3a-9977-4ae1-ab59-1f5a4ae39a33");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1dae3fe-91d2-42cc-8ba7-dcf237882eac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2b71d89-5501-4bd6-a358-aca8ce706bdb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5b67003-636d-425d-9784-45d374db713c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5e13a1d-86f3-415c-9c2f-4343258a4b57");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6dd4dd8-5922-46f8-9ea5-1e5a7953330f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7a53fcf-0ef2-4cf2-ab4a-6fdd3c2e655c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7f47693-ed7e-4c7c-8ef2-c4909b2d2659");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8b726c6-227d-4267-8dba-c1bf5ec0301f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8cc3bd3-ac03-46c4-820b-f7988f3088f7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bac28c61-4b74-4193-a109-f4456c44cf67");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb1dfb9b-70aa-495e-a041-156a4fbb4fec");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bb7ab51d-9d3b-4b32-9e16-6925b504ea1a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd0cb50a-e769-48ed-8473-b25faa687e15");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "beacb4b7-e74c-45d8-b8df-60e1a2a50768");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "befe44f6-84fb-4dd1-bc13-03b43f4ac2e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfdaeb2e-2ddb-4fc7-b971-58d61cbf4ba3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c15e0f9b-39be-49ff-aff8-1800116358f7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c24852f9-007d-455a-8cb5-0e2681c7a0a5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c35ccc97-39f5-4396-bbe1-2a6171f30d10");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c37d754a-9f08-4f13-8d26-630d896c9371");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c38c7a52-bc3b-4095-bbc3-ea23c389a9f8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c474ff32-d65e-4d11-90a2-f9ad2e8ee772");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c50585c6-d1df-4eaa-b5bf-317678e7d3bb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5381f46-f707-4fcb-8f1e-605cee507946");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5d36e60-0945-4e35-9239-22f30c29025f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5dbd9c2-70b4-451d-99cb-5130ab97ed0d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6633a62-08d6-4613-8f06-a3fcfd76f974");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6fcf873-e9c2-43c9-81ec-ba09bd063e13");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c87ce8ae-adb7-4007-8c0e-0090d0926e2e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8e6b9db-dbc9-4d49-a473-2c8593982b56");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8eeda2a-0260-4488-9acf-fddaee71e124");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c941ed50-01c0-472d-8122-3756b9b55a29");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c99efd04-1f14-49e6-bd60-208290d057a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cae31f17-a52f-4ac3-97bb-6886500b19bf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "caf33f50-8517-4995-a849-4a70bbe202f6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb1e122c-1eff-4130-a8e5-cef23cfa8ac1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd21938d-8cdf-4c18-a25a-73a2970c2deb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3167af-629a-4795-8c18-cf4f49e0a7d1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd3be091-3d72-4512-ba1d-e8466285b930");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ceaa3043-fb10-4638-b942-85d7b5fc20ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cec6be0d-a05d-44bc-a5ed-56b0a4d96af3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cf03ef83-babf-4710-ab13-ace35476b474");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfaa92f4-78cf-4cfd-8d3f-6ccb396d823d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfb34052-097c-4637-b13e-86a2bc255163");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d07b2ec3-59c7-46f8-bc3d-6c8c30e1acc2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d302b7f9-1306-4a95-85d4-ff189df4b527");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3c6ff78-122d-4bee-8880-1afc6fdcb0bc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d501bc94-2256-4ce7-b0bf-be4357ada814");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6003f61-89ae-4240-b53c-542ab36728ca");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6ef34e0-f613-405c-a6d8-e2b8f5dd614b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d7a31657-3101-42e7-8b97-aa6ff61d3e84");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d99cdf9c-bda7-4807-b92e-34b3de2e6002");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db5aeda4-2830-4ddd-a7ca-02363d58bf25");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db604d4c-9f40-48f5-b244-9b3bdcaf71c1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "db9ccc9b-5149-474b-a0b4-af8a13f01bc2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc91cbb3-94e1-43fe-bf92-06077cf48d87");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc94da97-75b3-48b7-bfb6-d46984b5f106");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd438551-3d93-45bc-982d-7c338b69983b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e0f91ecb-de8b-44fb-9a15-59c38d5093b4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e35c267e-66ab-453d-ba33-a31c4ce7e5ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d54d6e-42fe-472b-b696-6642067802b3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7ef9e6e-ea8b-4d2f-a20a-aa8d090fbd49");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e87b5530-1a38-4e6e-b6bc-e16c04b6c3b2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e9ca0d20-0315-4fca-b334-e6e046cd076e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea3367e6-6d1c-4e58-883a-b18d66f30f8b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea59937e-0296-4758-95ad-196fce18db72");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb3e277a-61f3-4f55-b179-d474841a80a3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed9ab94a-9354-48de-8695-43131a67bd2c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eec8a34e-e0ea-4a80-bd38-c7db22f84173");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef08937f-96ed-443c-80ac-1f7b764d10a1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef23ec60-f223-44c4-915e-196d6b011b94");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efe2c4a0-7529-4f91-9026-696ea0a1f7b7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f03ff26b-30e9-4a60-b99a-780060db1e35");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f102b409-56b3-42b4-b70c-25192033ba8d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f20906f6-cdbb-4f93-9ad0-87e63f0782ff");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f336bdc4-fd5f-4ffc-ba3d-0800649bb0d2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f39485eb-f82b-495c-8b60-7dada21ee477");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f43faef4-2885-42c1-9035-ccc2667d7fca");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4bab42f-1bb5-4ab3-9b00-22f1f33f006c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4ec3d57-0958-4cd2-8d1f-e3038eb75ae2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f6edd915-a9e4-4713-8e0a-6f1d7efde18f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f7062df1-beb7-4814-a074-e9da66830639");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "faa28a13-3b08-4a67-834d-621e4dd3d287");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb0deebe-ca58-4eb6-ac5b-67442c846405");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc72a988-3078-4c69-a8ca-c0f1dc1ec996");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fee54746-70cf-44dd-98df-5c09bb8959a8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff51a10a-1e10-4f3f-9d7b-b9342fd12bdc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffcc6812-deda-4b92-b2dd-0f59e0a46c44");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "3239f7e3-2a41-4479-aaa0-d55545fdca23");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "52a4cd9f-166a-481d-890c-05e50257655c");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "SiteCommInfos");

            migrationBuilder.DropColumn(
                name: "GSM1",
                table: "SiteCommInfos");

            migrationBuilder.DropColumn(
                name: "GSM2",
                table: "SiteCommInfos");

            migrationBuilder.DropColumn(
                name: "GSM3",
                table: "SiteCommInfos");

            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "FotoGaleries");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "CommUsers");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "Transportation",
                table: "SiteCommInfos",
                newName: "GSM");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductSubRegionId",
                table: "Product",
                newName: "IX_Product_ProductSubRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductRegionId",
                table: "Product",
                newName: "IX_Product_ProductRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Product",
                newName: "IX_Product_ProductCategoryId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SiteCommInfos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductSubRegions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductRegions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrdersSituation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OrdersDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MainMenu",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FotoGaleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CommUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BasketDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "IsAdult",
                table: "Product",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 448, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 448, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 448, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 448, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 448, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 448, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "808b204e-5175-43d4-bc40-2b84d28a6d6e", new DateTime(2024, 12, 11, 14, 2, 23, 450, DateTimeKind.Local).AddTicks(7887), "Siparişiniz Alındı" },
                    { "ae01048d-c951-43f8-8524-cb9a4a2bad52", new DateTime(2024, 12, 11, 14, 2, 23, 450, DateTimeKind.Local).AddTicks(7914), "Siparişiniz Tamamlandı" },
                    { "b0d93886-08d4-4aa4-9728-facf9d7e393d", new DateTime(2024, 12, 11, 14, 2, 23, 450, DateTimeKind.Local).AddTicks(7910), "Siparişiniz Kargoya verildi" },
                    { "b90decc9-e929-4dc4-b8c0-b1c0737f0eab", new DateTime(2024, 12, 11, 14, 2, 23, 450, DateTimeKind.Local).AddTicks(7905), "Siparişiniz Hazırlanıyor" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 2, 23, 451, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "CreatedAt", "Email", "GSM", "Phone", "SocialMedias", "WorkingHours" },
                values: new object[] { "2c272b5e-1d37-4c9f-b5ff-cc3bde70c145", new DateTime(2024, 12, 11, 14, 2, 23, 455, DateTimeKind.Local).AddTicks(766), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı\r\n\r\n0530 909 11 34 – Erdem\r\n\r\nİmalat\r\n\r\n0532 321 64 97 – İsmail\r\n0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "Hafta içi: 09:00 – 17:30\r\n\r\nCumartesi: 09:00 – 13:00" });

            migrationBuilder.CreateIndex(
                name: "IX_SiteCommInfos_GSM",
                table: "SiteCommInfos",
                column: "GSM",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketDetails_Product_ProductId",
                table: "BasketDetails",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetail_Product_ProductId",
                table: "OrdersDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductCategories_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductRegions_ProductRegionId",
                table: "Product",
                column: "ProductRegionId",
                principalTable: "ProductRegions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductSubRegions_ProductSubRegionId",
                table: "Product",
                column: "ProductSubRegionId",
                principalTable: "ProductSubRegions",
                principalColumn: "Id");
        }
    }
}
