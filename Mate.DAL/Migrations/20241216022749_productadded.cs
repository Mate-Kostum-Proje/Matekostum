using System;
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

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "GSM",
                table: "SiteCommInfos",
                newName: "Transportation");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Products",
                newName: "Amount");

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
                name: "ProductSize",
                columns: table => new
                {
                    ProductsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SizesId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => new { x.ProductsId, x.SizesId });
                    table.ForeignKey(
                        name: "FK_ProductSize_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSize_Size_SizesId",
                        column: x => x.SizesId,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FotoDesign",
                columns: new[] { "Id", "CreatedAt", "Name", "PhotoPath" },
                values: new object[,]
                {
                    { "0f3f793e-408b-4b38-ba61-710898d65fb9", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9827), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "2b2461ac-f9b8-4ad9-acfd-7d9f92e80a1c", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9822), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "351dea60-575d-42f4-b005-4daf0b94dff4", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9796), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" },
                    { "408869fb-51fc-4aea-b401-7e9e1550e7c6", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9720), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "46e4ffdf-6c18-4a18-86ec-2ad28da279a4", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9843), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "56a48d34-c73a-401e-b742-4383cc8d1edd", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9838), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "57058d86-b43e-41e7-92de-8d3d4f76e8e9", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9792), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "7e8ef4b0-4860-41f9-8275-ea55d7018c8a", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9770), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "942b1222-5fbb-4d82-8776-ea48cde51e70", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9781), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" },
                    { "98b90d48-9f8c-4ea6-9799-f0591fd30a11", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9776), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "c535eda9-81a2-4160-8698-38ba772b9ce7", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9785), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "ecdd14ab-7f1c-487d-af7c-a8d664a2d48d", new DateTime(2024, 12, 16, 5, 27, 49, 307, DateTimeKind.Local).AddTicks(9834), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "129e985f-9081-433d-a85a-3c07a1144842", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1953), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "363916ff-9dc6-4f61-a9cb-081877374ca7", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2035), "/databaseimg/galeri/galeriIMG-8454.jpg" },
                    { "407d5920-e96b-497b-a92d-585880962e03", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1993), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "53242edf-2f92-4c73-8266-953e5895cc36", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2020), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "5d5118d2-e82f-496e-b029-efee79e225e9", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1967), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "6bffb097-6383-41a8-a59f-d1d1191bc981", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2040), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "715a475b-6f43-4111-bf59-4328b2146707", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1999), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "7c3ab568-68cb-43d1-8052-b57888156644", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2008), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "80e2452d-d14d-48ff-a424-6b348635f4e7", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1962), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "81732743-bdc1-4e12-a207-2e91d5fb3246", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2012), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "89a1aec2-3e39-402b-91ed-26b2208f671f", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2048), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "8a9adb73-4197-458b-b96f-7af5a698a025", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2004), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "945c1466-beb7-45a9-883f-40f512846cf4", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2029), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "9501b478-5321-4528-a928-33df1459cc88", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1932), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "99746d95-d058-440d-8c31-0724cae3b206", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2025), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "aee24086-9487-472f-8709-4a7361d7d399", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1949), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" },
                    { "b8259045-e6e2-4507-9f32-c7d02a784824", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1985), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "b8bc0afa-9a42-41bf-872c-a4fcabbcd011", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2044), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "bd896127-aadb-4fd5-a204-ce834a5f3eaa", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1972), "/databaseimg/galeri/galeriIMG_1958.jpg" },
                    { "cbc94b42-37fb-46e4-9f61-1f008b56f3c4", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1980), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "defe0065-3c97-44b8-b0bb-6d48b68a7935", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1989), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "e3f8b262-dac8-4a3f-b808-d33ad41d4a5c", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2052), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "f459104f-7738-47a2-9abe-7e66e58ae883", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(1976), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "f5dc7a98-019a-46df-877d-4f049e725398", new DateTime(2024, 12, 16, 5, 27, 49, 308, DateTimeKind.Local).AddTicks(2016), "/databaseimg/galeri/galeriDMID3671.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 317, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 317, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 317, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 317, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 317, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 317, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "22f223d4-5bbb-4946-9bee-5cd2fd00dbeb", new DateTime(2024, 12, 16, 5, 27, 49, 318, DateTimeKind.Local).AddTicks(8864), "Siparişiniz Tamamlandı" },
                    { "932293c0-41a0-4201-9e0c-bbc8d6afe530", new DateTime(2024, 12, 16, 5, 27, 49, 318, DateTimeKind.Local).AddTicks(8855), "Siparişiniz Hazırlanıyor" },
                    { "b66b5d07-c3ee-4651-afd0-c635dc75d9f2", new DateTime(2024, 12, 16, 5, 27, 49, 318, DateTimeKind.Local).AddTicks(8860), "Siparişiniz Kargoya verildi" },
                    { "e49ae816-e3c4-47fe-a18c-2342346c63cd", new DateTime(2024, 12, 16, 5, 27, 49, 318, DateTimeKind.Local).AddTicks(8836), "Siparişiniz Alındı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "019629a9-11e2-4404-b9fd-19e7d358383f", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7677), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 1500, null },
                    { "02c262ce-f3e9-4394-98bd-6963bb4e7777", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8303), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N3", null, null, 1500, null },
                    { "03ea8738-2779-4b0c-844b-44e14be7ccf8", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7720), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "059cbbfe-2cb3-4db5-ac2c-da6314146b61", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8099), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 1500, null },
                    { "0655e9b9-a3e0-498f-a8cf-45eacf1e31ab", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8246), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N2", null, null, 1500, null },
                    { "08aca359-c739-4ccf-bf37-8d31108512fe", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7730), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 1500, null },
                    { "098e4558-d30d-4ee1-8480-374b8229df8d", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7868), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 1500, null },
                    { "0f30161a-b6b2-46b9-93b9-b78604e2b6e7", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7920), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 1500, null },
                    { "1146e798-d98f-4b98-b6de-7d380c734a65", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8212), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 1500, null },
                    { "135d3977-8c12-4506-a068-42f3cd64d1d7", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8231), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MUĞLA", "EGE", "ZEYBEK", 1500, null },
                    { "14d91eb7-6764-47ba-b851-174bfb484367", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7662), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 1500, null },
                    { "1584ca09-5e8e-4301-87ec-f6198ff7f86a", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8108), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 1500, null },
                    { "19fd95fd-92df-49fc-8cd9-30208fb20db0", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8080), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "1e8f21c3-5904-4d0f-8dba-106182d83042", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8046), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "254e625e-75c7-4861-8754-dd2de4833d62", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7693), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 1500, null },
                    { "27a45823-2b9a-43a0-8c0e-78473520ec16", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8208), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "27b844ba-981a-4ea1-8cac-eb776cd3388f", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7988), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 0, 1500 },
                    { "2844aa02-e975-405f-8af7-8cd243329268", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8069), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 1500, null },
                    { "2864e6f1-8ab9-4766-8823-840f2c80002e", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7973), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 0, 1500 },
                    { "2a63a1f2-b22d-4b10-97c5-58a7e2083fd0", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8051), null, true, true, false, "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "2d4a33f0-2a6b-4d51-85ff-c823f1f08e3c", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7906), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 1500, null },
                    { "3064139d-7ed9-4eb0-bb81-cf48e05f426a", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7925), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 1500, null },
                    { "31e4174f-24e8-46c2-8ba3-ad92ea0b877b", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7902), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 1500, null },
                    { "34ee0bc4-0b7e-4123-9821-c8ad6a8d2ea1", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8027), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpG", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 1500, null },
                    { "3663d5c1-c5d4-4a40-968d-e5ffe3988290", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7779), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "380e47e1-adfa-4b7a-b7b9-43c7a5f8dad6", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8227), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK PEMBE", "EGE", "ZEYBEK", 1500, null },
                    { "39723e98-c48f-4039-9345-9729d6090286", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7910), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 1500, null },
                    { "3b67b406-c04a-46fe-bc77-76d89b35d30e", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7855), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 1500, null },
                    { "3e950375-0882-48ba-ae38-166984706b37", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8271), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN YEŞİL", null, null, 1500, null },
                    { "3fcf7b87-7f17-456c-b837-c903a5ece045", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7969), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 0, 1500 },
                    { "3ff5027d-79a0-49b0-9911-3ce157e1fa31", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7832), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 1500, null },
                    { "4166f194-9b1d-481d-8c88-eff469330fce", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7704), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "47103496-0772-4a25-8a10-2b4493cda279", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8065), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 1500, null },
                    { "47bf52f9-0056-488a-bba9-38c895a6996f", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8164), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "48a5bc29-cfc8-46cf-ad46-560da2ca27d4", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8178), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "499fcecc-c75f-4224-87bf-3c25280126e7", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8160), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "4aa6fdb1-a0dd-49c5-8325-1a15b54f4e0c", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8288), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI-N2", null, null, 1500, null },
                    { "4c7f89d3-ad14-4928-85e7-a9bfe080d460", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8334), null, null, true, false, "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", "4dans", "ÇİFTETELLİ BEYAZ", null, "ÇİFTETELLİ", 1500, null },
                    { "4c989a31-e7cc-4b6e-8910-ea3e7231522c", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7942), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 1500, null },
                    { "4ca7704f-a679-416e-8173-7be4f31e1fc1", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8241), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI", null, null, 1500, null },
                    { "4cec8196-2c9a-4c3c-a05e-9ba74cb1dcbe", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7804), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 1500, null },
                    { "4da4de7c-32e0-4e1f-b00f-ec8d8c8c3410", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8127), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 1500, null },
                    { "4e78bc08-260a-4350-b934-e59d1e178ee6", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8003), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 0, 1500 },
                    { "4fc977c9-425c-4e7f-aee9-9740d3d78741", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8073), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "50caa4e8-48e7-4ebf-a7e2-b9f788a2ca04", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7889), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 1500, null },
                    { "51d7860d-735f-4515-b2a7-8a716023846e", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8293), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT", null, null, 1500, null },
                    { "51f0b076-581d-41ec-9033-35ffbea7e81e", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7698), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 1500, null },
                    { "51f244e9-ca61-4026-abb2-f9a046a67ba6", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7950), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 1500, null },
                    { "5493261a-c620-4c56-854a-c4454aace7ec", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7822), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 1500, null },
                    { "598ab973-15c3-4c02-af95-2a65ae19b36e", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7765), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 1500, null },
                    { "59c9121e-dc98-4e2b-bf6e-160695c74397", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7897), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 1500, null },
                    { "5ad60e55-f2a6-4eec-b727-0955ed0812cb", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8217), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 1500, null },
                    { "5c7528fb-4666-4b31-8abe-1c800723a3b5", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7683), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "60675bc1-c5e0-4451-9036-fdbd055271a6", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7754), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 1500, null },
                    { "60b9ee0e-2a58-4095-8313-c4e9bc5b1d76", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8199), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 1500, null },
                    { "62e63b7f-ea1d-4652-91da-38c585ddd14f", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8173), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "64ec3b5d-4c5d-49d8-8c76-3736d2fde4c2", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8346), null, null, true, false, "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, "ROMAN", 1500, null },
                    { "66d4a483-1e54-4482-8ef2-f4ba5ae41e4c", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8131), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 1500, null },
                    { "6764d265-4b68-458a-85ec-689b56856efb", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7954), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 0, 1500 },
                    { "685c90e8-e736-4e13-b628-d78091ddb38f", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7749), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 1500, null },
                    { "6c54fb89-f037-4157-a3fb-1b4a218e522d", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7965), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 0, 1500 },
                    { "6d6bfa67-3e4d-4eae-9731-1b282596bf6d", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7770), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 1500, null },
                    { "6d7f522a-a3b7-45bb-b6e5-6ca02de748d5", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7709), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 1500, null },
                    { "7191b227-ab2c-462e-b1df-4302c87ac938", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7657), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "738dd802-101b-429c-baab-1b24a67a1cae", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7667), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 1500, null },
                    { "75785616-c577-42da-b9d9-1fb0a7313612", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7977), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 0, 1500 },
                    { "76a68a28-3065-4fb8-a0b1-0f1c2e956474", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8376), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI K", null, null, 1500, null },
                    { "7928e19e-21cd-405a-b4d5-b479750e0170", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8012), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "7a6d8dc9-d210-426f-9661-a6a2ed268a68", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7992), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 0, 1500 },
                    { "7aa570bd-ba53-44cc-b6f5-03028eb2d22f", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8285), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI", null, null, 1500, null },
                    { "7b2e0513-7e0b-4f35-876d-0cb45781add5", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8188), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 1500, null },
                    { "81c5ae5a-ff08-4652-a0c0-5c13d38f2cfd", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7859), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 1500, null },
                    { "8428f772-0e67-4f75-a326-059286a021db", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7961), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 0, 1500 },
                    { "85acfe6e-9833-4abe-8592-07324724e480", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8261), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MÜRDÜM", null, null, 1500, null },
                    { "88f1cd90-23b3-4301-b1b2-abb2f2dc1186", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7774), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 1500, null },
                    { "89d8a5de-16f2-4d66-9bb8-ff8af359127e", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8338), null, null, true, false, "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", "4dans", "LİRİK", null, null, 1500, null },
                    { "89d9e342-fb35-41c4-879e-93e7b939ce16", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8136), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 1500, null },
                    { "8e84a34a-9e2e-4be2-adcb-3f5765c3becb", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8007), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 0, 1500 },
                    { "8f0f98e3-67db-4b53-9e06-48a452cf0b89", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8299), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N2", null, null, 1500, null },
                    { "9093a00c-6d6a-425d-b726-928a169d59e1", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8118), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "911dd2e3-e609-4fd0-a140-f397b501ecea", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7850), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 1500, null },
                    { "91a7d285-ac62-4d9e-a109-2c0ea9c621e3", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7933), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 1500, null },
                    { "92035258-f199-4ef1-a75e-7a04cf6ad49a", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8222), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "9375f9f4-3a84-4aaa-86ce-600c32ee89f3", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7915), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 1500, null },
                    { "98f6a59a-c669-4c26-b848-b15b5f461a12", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8112), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 1500, null },
                    { "9928273f-3b12-4cd6-81e1-427471d8128c", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7814), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "998b43c5-33a3-42c1-9267-c59d525d9672", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8358), null, null, true, false, "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN RENKLİ ETEK", null, "ROMAN", 1500, null },
                    { "99e31708-681e-4f95-aa0d-1e6f46e31f08", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7864), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 1500, null },
                    { "9a2d76f4-a849-4a44-a321-8f857418eac1", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7828), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 1500, null },
                    { "9c11ad84-16e8-4f10-8c0c-a51cb07e3e0d", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7809), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 1500, null },
                    { "9dfafd48-46f9-482a-b2f1-6aef9187cd9c", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8276), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ BORDO", null, null, 1500, null },
                    { "9ea6b5de-d100-4628-b68f-000455336339", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7818), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 1500, null },
                    { "9f15efc7-e132-483c-9981-fb6f6cd83749", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8362), null, null, true, false, "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN TURUNCU", null, "ROMAN", 1500, null },
                    { "9f5485f5-36f9-4df7-b0a2-3681d3f8a91f", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8307), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE", null, null, 1500, null },
                    { "a02ded9e-fe90-4c60-80e0-37eeb855204b", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8257), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MOR", null, null, 1500, null },
                    { "a1742aa3-d2ef-4507-8232-2d5eac6b7b87", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8353), null, null, true, false, "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN PEMBE", null, "ROMAN", 1500, null },
                    { "a2c4b911-8810-4036-bfdd-04591364fb5e", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7839), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 1500, null },
                    { "a3cb1e3d-38c5-4587-a111-83040c4d72a4", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8204), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 1500, null },
                    { "a4f0c053-2f4f-4120-92a0-6fb62b56f1be", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7636), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "a6c41b39-f165-4961-9d27-afd7152ed274", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7783), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 1500, null },
                    { "a8184970-b0a3-4068-9fb2-5432aaa2ce85", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8085), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "ab92b7af-a3b9-4119-a27c-6c3617be133b", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8384), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ K", null, null, 1500, null },
                    { "ad207d6c-e47e-4924-9c7c-41c4f27ea067", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8060), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 1500, null },
                    { "afbc718e-4206-49e0-b7dd-4f27e6a6a126", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8342), null, null, true, false, "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, "ROMAN", 1500, null },
                    { "b0af6908-6e08-48ed-aeba-9843674c1124", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8322), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ YEŞİL", null, null, 1500, null },
                    { "b3f5b091-4d55-4970-811b-f6255634e3ed", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7983), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 0, 1500 },
                    { "b66b8405-6ad3-4642-a657-392791e86ef1", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7998), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 0, 1500 },
                    { "b7d11ff7-3824-4ae4-b6e2-c5570aa8be82", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8318), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ ÜSKÜP-N2", null, null, 1500, null },
                    { "b7ef1275-dfe3-4acf-87f4-ec7aef02b12e", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8183), null, true, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "b823f150-2ad9-45f4-900e-c7e84ddb1dc5", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8017), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "baa1a0c3-b3b1-4f81-b8e7-e6ba37917a92", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7878), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 1500, null },
                    { "bdd11288-4599-427f-9f6a-febd2db5d210", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8123), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "bed7d6f3-27c6-4820-b0fe-cc3b824e44a5", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7788), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 1500, null },
                    { "bfce6bb2-f437-491a-b8b4-4fe4d06d0c83", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7893), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 1500, null },
                    { "c11c5ec6-dbd4-4c97-a470-1098e06007da", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7792), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 1500, null },
                    { "c4656dde-7da9-41af-8ee4-754a0e5027c0", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7714), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "c69b9e24-50eb-4f10-8649-97baf489a43d", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8103), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 1500, null },
                    { "ca01c69b-0d97-4278-8c85-986a22112c9f", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8153), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 1500, null },
                    { "ca28cf67-679e-4137-9006-07b9d06ff380", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7725), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 1500, null },
                    { "ca2b25bd-fba6-4efc-b9cd-f7c935a47296", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8367), null, null, true, false, "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN YEŞİL", null, "ROMAN", 1500, null },
                    { "ca39c71a-d754-4a14-8f92-0ef593490d51", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8143), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 1500, null },
                    { "cb05fab5-372d-41ac-8e39-acd5c9e25ccc", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8035), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 1500, null },
                    { "cc5d21fa-7cca-4269-9c0e-e18a4811880a", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8371), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI E", null, null, 1500, null },
                    { "ce19b7ac-1e0e-4808-8b06-37db569fb40e", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7884), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 1500, null },
                    { "d6a66c5d-ba4f-42e9-a93d-ef4eb8f0948f", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8193), null, true, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 1500, null },
                    { "d6ace530-be1d-46f6-bd8e-e591a0df5429", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7759), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 1500, null },
                    { "d8417820-c8c0-4d5c-bc1d-649ee3efc448", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8380), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ E", null, null, 1500, null },
                    { "d87e7e49-c208-4e69-968a-a2055e704937", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8148), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 1500, null },
                    { "dbd404ea-3ab9-42b9-91e9-83baba8639eb", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8089), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "dc04663a-864f-43c4-b01e-9694bd03caee", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8169), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "dd5d6285-c1a9-450f-a4e1-a9ee0c43c796", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8280), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ GRİ-SİYAH", null, null, 1500, null },
                    { "de45b24d-6c7c-42c2-9d33-ad2491b766ba", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7797), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "de8865a5-76f9-4c31-8cf4-9ece2bebe986", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8329), null, null, true, false, "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", "4dans", "AŞUK MAŞUK", null, null, 1500, null },
                    { "dfc08350-9c1d-4817-8efa-c927ec5ef888", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7846), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 1500, null },
                    { "e1e8aae2-61d9-4120-a04b-9442da9e7f13", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7946), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 1500, null },
                    { "e47b324a-6e22-434c-8f9e-4ed9aa2e94fe", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7744), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 1500, null },
                    { "e86601c5-56d7-4505-ba03-9f1029962279", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7873), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 1500, null },
                    { "ebada7e6-7a82-4f07-9ea6-51dc3d560ebb", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8253), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N3", null, null, 1500, null },
                    { "edbf2c08-9ec0-479d-a808-af6ce235ee0d", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7688), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "f02e8a4c-340f-435a-bb07-5eca923ca3ab", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8023), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "f584ba6f-57a5-4ed4-b327-8d33f0607331", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8266), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN PEMBE", null, null, 1500, null },
                    { "f5887a14-fb75-406b-b1e1-ddba12644407", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8094), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 1500, null },
                    { "f7aeeed0-5412-4220-9cca-24030d6701f0", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7740), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 1500, null },
                    { "f8c602bb-3a6f-450f-a2e8-978e11c118fe", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8055), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "fa45bf8a-3a56-43bd-ba6b-6d30418b3fa9", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8313), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE-N2", null, null, 1500, null },
                    { "fc19c689-fac5-475e-b647-68d7b70b9a30", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(7929), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 1500, null },
                    { "fc3116b4-75f4-4766-abf4-06c7b59151dc", 0, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8237), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN BORDO", null, null, 1500, null },
                    { "ff8f5651-747a-4a63-aab4-77bc019ec0a3", 10, new DateTime(2024, 12, 16, 5, 27, 49, 319, DateTimeKind.Local).AddTicks(8042), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 5, 27, 49, 320, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "fffcf24e-86e4-4dfc-b146-5c3741b357f4", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 16, 5, 27, 49, 321, DateTimeKind.Local).AddTicks(2), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreatedAt", "SizeNumber" },
                values: new object[,]
                {
                    { "128ba4a5-9538-4038-81ba-fa90a013d89c", new DateTime(2024, 12, 16, 5, 27, 49, 321, DateTimeKind.Local).AddTicks(2049), 14 },
                    { "171bbe28-b170-4b73-901e-81c43747e9be", new DateTime(2024, 12, 16, 5, 27, 49, 321, DateTimeKind.Local).AddTicks(2040), 10 },
                    { "278fd668-ce29-4178-bec5-4d746567fdc7", new DateTime(2024, 12, 16, 5, 27, 49, 321, DateTimeKind.Local).AddTicks(2045), 12 },
                    { "ec0e5213-606b-4af2-8af6-62c25d2321a7", new DateTime(2024, 12, 16, 5, 27, 49, 321, DateTimeKind.Local).AddTicks(2023), 8 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "e89dcd9e-aee6-4a28-a7e4-36072c0b6553", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                name: "IX_ProductSize_SizesId",
                table: "ProductSize",
                column: "SizesId");

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
                name: "ProductSize");

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
                keyValue: "129e985f-9081-433d-a85a-3c07a1144842");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "363916ff-9dc6-4f61-a9cb-081877374ca7");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "407d5920-e96b-497b-a92d-585880962e03");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "53242edf-2f92-4c73-8266-953e5895cc36");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5d5118d2-e82f-496e-b029-efee79e225e9");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "6bffb097-6383-41a8-a59f-d1d1191bc981");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "715a475b-6f43-4111-bf59-4328b2146707");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "7c3ab568-68cb-43d1-8052-b57888156644");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "80e2452d-d14d-48ff-a424-6b348635f4e7");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "81732743-bdc1-4e12-a207-2e91d5fb3246");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "89a1aec2-3e39-402b-91ed-26b2208f671f");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "8a9adb73-4197-458b-b96f-7af5a698a025");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "945c1466-beb7-45a9-883f-40f512846cf4");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "9501b478-5321-4528-a928-33df1459cc88");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "99746d95-d058-440d-8c31-0724cae3b206");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "aee24086-9487-472f-8709-4a7361d7d399");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b8259045-e6e2-4507-9f32-c7d02a784824");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b8bc0afa-9a42-41bf-872c-a4fcabbcd011");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "bd896127-aadb-4fd5-a204-ce834a5f3eaa");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "cbc94b42-37fb-46e4-9f61-1f008b56f3c4");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "defe0065-3c97-44b8-b0bb-6d48b68a7935");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "e3f8b262-dac8-4a3f-b808-d33ad41d4a5c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f459104f-7738-47a2-9abe-7e66e58ae883");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f5dc7a98-019a-46df-877d-4f049e725398");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "22f223d4-5bbb-4946-9bee-5cd2fd00dbeb");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "932293c0-41a0-4201-9e0c-bbc8d6afe530");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "b66b5d07-c3ee-4651-afd0-c635dc75d9f2");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "e49ae816-e3c4-47fe-a18c-2342346c63cd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "019629a9-11e2-4404-b9fd-19e7d358383f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "02c262ce-f3e9-4394-98bd-6963bb4e7777");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "03ea8738-2779-4b0c-844b-44e14be7ccf8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "059cbbfe-2cb3-4db5-ac2c-da6314146b61");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0655e9b9-a3e0-498f-a8cf-45eacf1e31ab");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "08aca359-c739-4ccf-bf37-8d31108512fe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "098e4558-d30d-4ee1-8480-374b8229df8d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f30161a-b6b2-46b9-93b9-b78604e2b6e7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1146e798-d98f-4b98-b6de-7d380c734a65");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "135d3977-8c12-4506-a068-42f3cd64d1d7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "14d91eb7-6764-47ba-b851-174bfb484367");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1584ca09-5e8e-4301-87ec-f6198ff7f86a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19fd95fd-92df-49fc-8cd9-30208fb20db0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1e8f21c3-5904-4d0f-8dba-106182d83042");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "254e625e-75c7-4861-8754-dd2de4833d62");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "27a45823-2b9a-43a0-8c0e-78473520ec16");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "27b844ba-981a-4ea1-8cac-eb776cd3388f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2844aa02-e975-405f-8af7-8cd243329268");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2864e6f1-8ab9-4766-8823-840f2c80002e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a63a1f2-b22d-4b10-97c5-58a7e2083fd0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d4a33f0-2a6b-4d51-85ff-c823f1f08e3c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3064139d-7ed9-4eb0-bb81-cf48e05f426a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31e4174f-24e8-46c2-8ba3-ad92ea0b877b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "34ee0bc4-0b7e-4123-9821-c8ad6a8d2ea1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3663d5c1-c5d4-4a40-968d-e5ffe3988290");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "380e47e1-adfa-4b7a-b7b9-43c7a5f8dad6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39723e98-c48f-4039-9345-9729d6090286");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3b67b406-c04a-46fe-bc77-76d89b35d30e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e950375-0882-48ba-ae38-166984706b37");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3fcf7b87-7f17-456c-b837-c903a5ece045");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3ff5027d-79a0-49b0-9911-3ce157e1fa31");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4166f194-9b1d-481d-8c88-eff469330fce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "47103496-0772-4a25-8a10-2b4493cda279");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "47bf52f9-0056-488a-bba9-38c895a6996f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "48a5bc29-cfc8-46cf-ad46-560da2ca27d4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "499fcecc-c75f-4224-87bf-3c25280126e7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4aa6fdb1-a0dd-49c5-8325-1a15b54f4e0c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c7f89d3-ad14-4928-85e7-a9bfe080d460");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c989a31-e7cc-4b6e-8910-ea3e7231522c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4ca7704f-a679-416e-8173-7be4f31e1fc1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4cec8196-2c9a-4c3c-a05e-9ba74cb1dcbe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4da4de7c-32e0-4e1f-b00f-ec8d8c8c3410");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e78bc08-260a-4350-b934-e59d1e178ee6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4fc977c9-425c-4e7f-aee9-9740d3d78741");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50caa4e8-48e7-4ebf-a7e2-b9f788a2ca04");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "51d7860d-735f-4515-b2a7-8a716023846e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "51f0b076-581d-41ec-9033-35ffbea7e81e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "51f244e9-ca61-4026-abb2-f9a046a67ba6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5493261a-c620-4c56-854a-c4454aace7ec");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "598ab973-15c3-4c02-af95-2a65ae19b36e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "59c9121e-dc98-4e2b-bf6e-160695c74397");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5ad60e55-f2a6-4eec-b727-0955ed0812cb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5c7528fb-4666-4b31-8abe-1c800723a3b5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "60675bc1-c5e0-4451-9036-fdbd055271a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "60b9ee0e-2a58-4095-8313-c4e9bc5b1d76");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "62e63b7f-ea1d-4652-91da-38c585ddd14f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64ec3b5d-4c5d-49d8-8c76-3736d2fde4c2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "66d4a483-1e54-4482-8ef2-f4ba5ae41e4c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6764d265-4b68-458a-85ec-689b56856efb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "685c90e8-e736-4e13-b628-d78091ddb38f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c54fb89-f037-4157-a3fb-1b4a218e522d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d6bfa67-3e4d-4eae-9731-1b282596bf6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d7f522a-a3b7-45bb-b6e5-6ca02de748d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7191b227-ab2c-462e-b1df-4302c87ac938");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "738dd802-101b-429c-baab-1b24a67a1cae");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75785616-c577-42da-b9d9-1fb0a7313612");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "76a68a28-3065-4fb8-a0b1-0f1c2e956474");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7928e19e-21cd-405a-b4d5-b479750e0170");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a6d8dc9-d210-426f-9661-a6a2ed268a68");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7aa570bd-ba53-44cc-b6f5-03028eb2d22f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7b2e0513-7e0b-4f35-876d-0cb45781add5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81c5ae5a-ff08-4652-a0c0-5c13d38f2cfd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8428f772-0e67-4f75-a326-059286a021db");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85acfe6e-9833-4abe-8592-07324724e480");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "88f1cd90-23b3-4301-b1b2-abb2f2dc1186");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "89d8a5de-16f2-4d66-9bb8-ff8af359127e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "89d9e342-fb35-41c4-879e-93e7b939ce16");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8e84a34a-9e2e-4be2-adcb-3f5765c3becb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f0f98e3-67db-4b53-9e06-48a452cf0b89");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9093a00c-6d6a-425d-b726-928a169d59e1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "911dd2e3-e609-4fd0-a140-f397b501ecea");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91a7d285-ac62-4d9e-a109-2c0ea9c621e3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92035258-f199-4ef1-a75e-7a04cf6ad49a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9375f9f4-3a84-4aaa-86ce-600c32ee89f3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98f6a59a-c669-4c26-b848-b15b5f461a12");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9928273f-3b12-4cd6-81e1-427471d8128c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "998b43c5-33a3-42c1-9267-c59d525d9672");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "99e31708-681e-4f95-aa0d-1e6f46e31f08");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9a2d76f4-a849-4a44-a321-8f857418eac1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c11ad84-16e8-4f10-8c0c-a51cb07e3e0d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9dfafd48-46f9-482a-b2f1-6aef9187cd9c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9ea6b5de-d100-4628-b68f-000455336339");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f15efc7-e132-483c-9981-fb6f6cd83749");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f5485f5-36f9-4df7-b0a2-3681d3f8a91f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a02ded9e-fe90-4c60-80e0-37eeb855204b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a1742aa3-d2ef-4507-8232-2d5eac6b7b87");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2c4b911-8810-4036-bfdd-04591364fb5e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a3cb1e3d-38c5-4587-a111-83040c4d72a4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4f0c053-2f4f-4120-92a0-6fb62b56f1be");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a6c41b39-f165-4961-9d27-afd7152ed274");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a8184970-b0a3-4068-9fb2-5432aaa2ce85");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ab92b7af-a3b9-4119-a27c-6c3617be133b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad207d6c-e47e-4924-9c7c-41c4f27ea067");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "afbc718e-4206-49e0-b7dd-4f27e6a6a126");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b0af6908-6e08-48ed-aeba-9843674c1124");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b3f5b091-4d55-4970-811b-f6255634e3ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b66b8405-6ad3-4642-a657-392791e86ef1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7d11ff7-3824-4ae4-b6e2-c5570aa8be82");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7ef1275-dfe3-4acf-87f4-ec7aef02b12e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b823f150-2ad9-45f4-900e-c7e84ddb1dc5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "baa1a0c3-b3b1-4f81-b8e7-e6ba37917a92");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bdd11288-4599-427f-9f6a-febd2db5d210");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bed7d6f3-27c6-4820-b0fe-cc3b824e44a5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfce6bb2-f437-491a-b8b4-4fe4d06d0c83");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c11c5ec6-dbd4-4c97-a470-1098e06007da");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c4656dde-7da9-41af-8ee4-754a0e5027c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c69b9e24-50eb-4f10-8649-97baf489a43d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ca01c69b-0d97-4278-8c85-986a22112c9f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ca28cf67-679e-4137-9006-07b9d06ff380");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ca2b25bd-fba6-4efc-b9cd-f7c935a47296");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ca39c71a-d754-4a14-8f92-0ef593490d51");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb05fab5-372d-41ac-8e39-acd5c9e25ccc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cc5d21fa-7cca-4269-9c0e-e18a4811880a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ce19b7ac-1e0e-4808-8b06-37db569fb40e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6a66c5d-ba4f-42e9-a93d-ef4eb8f0948f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6ace530-be1d-46f6-bd8e-e591a0df5429");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d8417820-c8c0-4d5c-bc1d-649ee3efc448");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d87e7e49-c208-4e69-968a-a2055e704937");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dbd404ea-3ab9-42b9-91e9-83baba8639eb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc04663a-864f-43c4-b01e-9694bd03caee");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd5d6285-c1a9-450f-a4e1-a9ee0c43c796");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "de45b24d-6c7c-42c2-9d33-ad2491b766ba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "de8865a5-76f9-4c31-8cf4-9ece2bebe986");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dfc08350-9c1d-4817-8efa-c927ec5ef888");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e1e8aae2-61d9-4120-a04b-9442da9e7f13");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e47b324a-6e22-434c-8f9e-4ed9aa2e94fe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e86601c5-56d7-4505-ba03-9f1029962279");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ebada7e6-7a82-4f07-9ea6-51dc3d560ebb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "edbf2c08-9ec0-479d-a808-af6ce235ee0d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f02e8a4c-340f-435a-bb07-5eca923ca3ab");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f584ba6f-57a5-4ed4-b327-8d33f0607331");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f5887a14-fb75-406b-b1e1-ddba12644407");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f7aeeed0-5412-4220-9cca-24030d6701f0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f8c602bb-3a6f-450f-a2e8-978e11c118fe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fa45bf8a-3a56-43bd-ba6b-6d30418b3fa9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc19c689-fac5-475e-b647-68d7b70b9a30");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc3116b4-75f4-4766-abf4-06c7b59151dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff8f5651-747a-4a63-aab4-77bc019ec0a3");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "fffcf24e-86e4-4dfc-b146-5c3741b357f4");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "e89dcd9e-aee6-4a28-a7e4-36072c0b6553");

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

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Product",
                newName: "Size");

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
