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
                    { "134f4707-8f62-4ffb-9035-5ca7b5886520", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6116), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" },
                    { "2042d69e-462c-4aa7-b455-f0859f7af214", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6101), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" },
                    { "2c99bf2d-7fe0-4485-b8b4-f6f07af02b4f", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6139), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "370a047a-16c4-4cdf-aa0d-f450d5d690fd", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6135), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "4a3064c1-c267-4313-be14-283e3b5056fc", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6106), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "60a5bcb7-4f1b-47bf-9adb-974ae3b24422", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6120), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "6dd147ba-1ebd-45ac-a231-376f785016d2", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6112), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "76c0b27b-1b1d-4835-b9d9-348bb7346089", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6035), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "99bf8225-ef82-495f-9ee8-ce72d082383f", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6126), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "bdd99791-be8c-44ef-96f4-5e9377ec3955", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6092), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "deb16a85-495d-4bdc-ba1f-9f1842309bb1", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6097), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "fa67531f-fcef-4943-b336-2aae7099114e", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(6131), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "010e12d2-c94c-432f-99af-c4e55a2e3d82", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8165), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "04b477a4-9424-4e1c-b108-4ba8314883b0", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8194), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "19818aec-dd49-456e-bdf1-b8d43b8e060a", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8206), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "198eb556-3fd0-4a6a-b21f-82aff9dd7c3e", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8153), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "19fb78a9-14aa-41b4-9490-10b800bb3aee", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8217), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "20496491-c331-4168-bbcc-4f6b2da2cd58", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8178), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "3d456943-4bb9-4687-9346-5ad196c01085", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8182), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "3d5418f7-1038-41a2-8d52-09a55732fd25", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8197), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "472f374f-8560-4a7d-8a95-1d4813b2a4ff", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8157), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "490f738d-750f-4165-8950-5078269b193e", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8185), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "643d07eb-4578-40b1-9e73-ad8dd03f6076", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8169), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "7aa05184-fbc8-40b5-a3d3-3ac71574c465", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8189), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "880f65e9-7efa-4dbe-ad2e-8815395c4586", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8124), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" },
                    { "93e6f81e-e3f2-4f40-9b4c-5a24518f22a6", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8213), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "aafa71a4-465c-4d1a-a05b-ffc95260c91b", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8161), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "ab1b64b9-9bd1-4924-a93a-667d42c1a74c", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8140), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "bc87bfcf-13c7-4b18-aee9-73f1fceaec96", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8146), "/databaseimg/galeri/galeriIMG_1958.jpg" },
                    { "cff120c7-8708-4745-b237-96e105175061", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8128), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "d1daf447-c3da-40d8-bb04-9975a2006d89", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8150), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "d6c09acc-fa6a-43ad-9bdf-337484bb41ed", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8100), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "ee0cfae7-9cae-4c43-8513-f9d915a174ca", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8133), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "f43fac1d-91ec-4fc4-9a4d-922c216b633b", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8174), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "f7860401-a447-4ef2-a37d-b716b9d72d0e", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8210), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "ff966cc5-3458-473d-bf56-1d745cabf406", new DateTime(2024, 12, 18, 15, 39, 50, 336, DateTimeKind.Local).AddTicks(8201), "/databaseimg/galeri/galeriIMG-8454.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 342, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 342, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 342, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 342, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 342, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 342, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "30e1a8b8-c19f-40fb-aba9-4722112c9085", new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(763), "Siparişiniz Tamamlandı" },
                    { "a63acc40-e6c3-4c90-8e47-7689cbafa432", new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(759), "Siparişiniz Kargoya verildi" },
                    { "e6b52e4e-3545-4284-9fa3-82bbd46389e4", new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(754), "Siparişiniz Hazırlanıyor" },
                    { "eb88e5b2-504a-4b36-8f4c-3731ffd73391", new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(734), "Siparişiniz Alındı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "00988b97-d551-4c62-87cc-2ee76f42cca8", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9838), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 1500, null },
                    { "032eb8a2-3232-4fac-b5cc-7a914fb917f0", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(718), null, true, true, true, "/databaseimg/HALKOYUN-ÇERKES-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÇERKES K", "KAFKAS", null, 0, 1500 },
                    { "034d7499-0b10-4460-b5f8-79f5baca0f99", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(853), null, true, true, true, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", null, 0, 1500 },
                    { "066dc471-8739-4a12-90c0-af77bc71d2f3", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(770), null, false, true, true, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN E2", "KARADENİZ", null, 0, 1500 },
                    { "08a831ad-e680-4702-a8e2-6c25a195d02a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(911), null, true, true, true, "/databaseimg/HALKOYUN-LASELİFK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA LASELİ FK", "TRAKYA", null, 0, 1500 },
                    { "09481b3c-1e7f-40fa-8036-e3e00d90b158", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9873), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 0, 1500 },
                    { "0a2db546-0e0c-4d41-996d-377cca442951", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9577), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "0c737309-377a-4b1f-970a-f151be5fd7c4", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(339), null, null, true, false, "/databaseimg/ROND-NOELANNE-YETİŞKİN-KİRALIK.jpg", "5rond", "NOEL ANNE", null, null, 1500, null },
                    { "0d1a32a3-bcf1-4252-b3b4-d8fb54dded21", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(896), null, null, true, true, "/databaseimg/HALKOYUN-BORDOKISAYELEK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA BORDO KISA YELEK", "TRAKYA", null, 0, 1500 },
                    { "0d9e1503-803f-4a76-9642-a8d4bc1fb248", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(147), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI", null, null, 1500, null },
                    { "0f2206e5-0424-4f9e-8c5e-4cf7193785d3", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(226), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ ÜSKÜP-N2", null, null, 1500, null },
                    { "11602e6f-bdd5-49ca-a124-9ddb2bc14498", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(186), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI", null, null, 1500, null },
                    { "11a4566b-28de-4002-b3e3-f5dc43f58dd1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(5), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 1500, null },
                    { "13f56561-c6de-48af-aece-fff5c073aa4b", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(248), null, null, true, false, "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, "ROMAN", 1500, null },
                    { "14de612f-9de8-4d15-ba74-ada91cef24c6", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9649), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 1500, null },
                    { "14f3e519-d722-41cf-99d3-15329ad5f343", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(540), null, false, true, true, "/databaseimg/HALKOYUN-BİTLİS-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", null, 0, 1500 },
                    { "1575d722-ffb4-4576-bcc4-8a72116991c5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9813), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 1500, null },
                    { "159bb68e-40ea-4efe-b193-a6d6fcb8033a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(663), null, true, true, true, "/databaseimg/HALKOYUN-URFA-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "URFA K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "1623fddd-8377-4dad-ae8a-42e34586a3c0", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(50), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 1500, null },
                    { "16b273e7-9b09-450f-ae26-5148db31d95b", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(837), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K4", "KARADENİZ", null, 0, 1500 },
                    { "17257d8f-9048-42d8-b72e-f3a3715858da", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(727), null, false, true, true, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 0, 1500 },
                    { "19480838-dd1e-4b44-bbe8-b5d4f01a0ee2", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(458), null, true, true, true, "/databaseimg/HALKOYUN-ÇANAKKALE-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÇANAKKALE K", "EGE", null, 0, 1500 },
                    { "1991f124-8a3c-44cb-8010-6cd453122be0", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9679), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 1500, null },
                    { "19c3dc39-9d05-4bbc-90fa-28c03f119767", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(526), null, null, true, true, "/databaseimg/HALKOYUN-AĞRIKADİFE-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AĞRI KADİFE", "DOGU ANADOLU", null, 0, 1500 },
                    { "19dff48f-263d-4a37-b443-427088c400fe", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(89), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 1500, null },
                    { "1af6bc2c-0bc6-4596-8967-7ef1d832ab80", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9773), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 1500, null },
                    { "1c65f8c9-fc56-4b05-b283-8b85d532f0e8", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(210), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE", null, null, 1500, null },
                    { "1dec2ab7-2d16-4f8e-9ede-fc8b9230c985", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(304), null, null, true, false, "/databaseimg/ROND-HACİVAT-YETİŞKİN-KİRALIK.jpg", "5rond", "HACİVAT", null, null, 1500, null },
                    { "1e0fe0a3-5c33-489d-acd5-7d440151c133", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(828), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K2", "KARADENİZ", null, 0, 1500 },
                    { "1e3d57d1-1bde-4050-9a28-2c0f4785f740", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(168), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN PEMBE", null, null, 1500, null },
                    { "1e87c325-9b58-4c24-9c3f-7ccfd31342d5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(368), null, null, true, true, "/databaseimg/HALKOYUN-AŞUKMAŞUK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AŞUK MAŞUK", "AKDENİZ", null, 0, 1500 },
                    { "1ece8c33-5711-40bd-8dd7-1b6e5b8b5ad9", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(488), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRFUŞYA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR FUŞYA", "EGE", null, 0, 1500 },
                    { "2048d886-6171-4eab-a1c3-320e881bf5bd", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(151), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N2", null, null, 1500, null },
                    { "206931c4-56ea-4ba8-8425-7de478d0a1b2", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(713), null, null, true, true, "/databaseimg/HALKOYUN-YOZGAT-YETİŞKİN-SATILIK.jpg", "2halkoyun", "YOZGAT", "İÇ ANADOLU", null, 0, 1500 },
                    { "20afda3a-51dd-4c53-8792-ce046a014bee", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(14), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "20d2f544-ae5b-44f0-aa29-5d886154602b", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9850), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 0, 1500 },
                    { "219202db-350f-45f8-b737-4c4e610c17bc", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9887), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 0, 1500 },
                    { "22471522-d28a-4a15-95d1-9fe0eee3c7d1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(387), null, true, true, true, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", null, 0, 1500 },
                    { "22498d36-cc76-4272-bd34-319831912071", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(629), null, true, true, true, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "2255f337-a4a3-42f8-b617-1f4197f93918", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(109), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "22e5b250-9b7e-4662-aeb8-ba6dc3cf5f98", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(531), null, false, true, true, "/databaseimg/HALKOYUN-ARDAHAN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARDAHAN E", "DOGU ANADOLU", null, 0, 1500 },
                    { "24398275-5708-4d04-84cf-bb60fd4a1b24", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(780), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K2", "KARADENİZ", null, 0, 1500 },
                    { "2669e632-55c6-42e9-beef-54f5209295f3", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(55), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 1500, null },
                    { "27002143-d39c-427f-85d8-141f6700e765", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(239), null, null, true, false, "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", "4dans", "ÇİFTETELLİ BEYAZ", null, "ÇİFTETELLİ", 1500, null },
                    { "277f8c18-2ee7-4a35-af1e-df7d1e029872", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9737), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 1500, null },
                    { "27c1fbc5-e660-40a6-89ef-5912f7036b71", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(497), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRKOYU2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR KOYU 2", "EGE", null, 0, 1500 },
                    { "28e57aae-ae88-44dc-a6ba-291caf9d5ed0", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(399), null, false, true, true, "/databaseimg/HALKOYUN-MUT-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MUT E", "AKDENİZ", null, 0, 1500 },
                    { "299d7127-9878-4292-a414-55488e757992", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(986), null, true, true, true, "/databaseimg/HALKOYUN-ÜSKÜPKIRMIZI-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP KIRMIZI K", "TRAKYA", null, 0, 1500 },
                    { "29e433a6-92b2-4c69-a455-9fa23641733d", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(789), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K4", "KARADENİZ", null, 0, 1500 },
                    { "2a880d91-ebf5-4aa1-a44d-162850bc4cd0", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(364), null, null, true, false, "/databaseimg/ROND-YENİÇERİ-YETİŞKİN-KİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 1500, null },
                    { "2a927bf8-6c2b-48ff-ab5f-6dac9898e028", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(577), null, true, true, true, "/databaseimg/HALKOYUN-VAN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", null, 0, 1500 },
                    { "2ae5f38d-01bf-415f-86be-fb06f8769377", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(155), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N3", null, null, 1500, null },
                    { "2b05e1a1-cec7-4db5-be38-0336786eecc6", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(422), null, true, true, true, "/databaseimg/HALKOYUN-SİLİFKE-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE K2", "AKDENİZ", null, 0, 1500 },
                    { "2c45b746-4a98-45e7-8f4d-c95d7202d87a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9987), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "2c5a6e4c-f440-4ad1-a141-d8966df30b5a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(268), null, null, true, false, "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN TURUNCU", null, "ROMAN", 1500, null },
                    { "2cb58155-d359-48f4-be39-6c6d88e76f0f", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9756), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 1500, null },
                    { "2d89f74b-2c5b-44a1-a8ca-dd0185832763", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9666), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 1500, null },
                    { "2da1c2f6-f47c-4c12-b663-82d0d1df3324", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(408), null, false, true, true, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", null, 0, 1500 },
                    { "2e0b1740-0b15-4a8f-bbd0-8692472a493c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9712), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 1500, null },
                    { "2e1e9ca6-73d9-4cf0-ace1-b2990b80d426", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9913), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "2e6c0a33-169f-420d-b52a-e783b9cc3db8", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(982), null, true, true, true, "/databaseimg/HALKOYUN-ÜSKÜPBEYAZ-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP BEYAZ K", "TRAKYA", null, 0, 1500 },
                    { "2f416e13-5a14-4cea-a1b0-49a033797ef1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9938), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 1500, null },
                    { "2fd814bb-ea48-46f0-b288-0c92eac3b54f", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(127), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK PEMBE", "EGE", "ZEYBEK", 1500, null },
                    { "2fece652-a2e3-4f61-95bc-1387d5416448", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9958), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 1500, null },
                    { "305e3ade-9449-4641-94f5-309e8bf92364", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9565), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 1500, null },
                    { "307c5a3a-1ae5-4110-8f54-ae4f198494f5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(634), null, null, true, true, "/databaseimg/HALKOYUN-GAZİANTEPABA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP ABA", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "31303466-2f59-4815-98cd-557a35ccc4bb", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9854), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 0, 1500 },
                    { "318c07e2-4630-4dcd-8a00-63e3e213eb83", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9635), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 1500, null },
                    { "32c09ebc-27e0-4ccc-a04c-af163bc0ea9f", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9659), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 1500, null },
                    { "32dc777b-5a3f-47d4-af6c-18b60d461650", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(654), null, true, true, true, "/databaseimg/HALKOYUN-GAZİANTEP-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP K3", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "3305fcb6-49e0-434d-994c-a0e90302b5a5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(45), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 1500, null },
                    { "34101ac2-a689-493b-9c3d-e6f98c54d565", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(308), null, null, true, false, "/databaseimg/ROND-KARAGÖZ-YETİŞKİN-KİRALIK.jpg", "5rond", "KARAGÖZ", null, null, 1500, null },
                    { "3633e4fb-9f3a-471f-8a3e-bc1f12784a94", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9869), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 0, 1500 },
                    { "3638eac7-7a74-4eb4-9c90-58c5721def6f", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(418), null, true, true, true, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", null, 0, 1500 },
                    { "36e0896f-d02b-4f91-8005-c4c257cb5a17", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(59), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "36f3964a-7316-498e-9370-0ea37585111d", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(520), null, false, true, true, "/databaseimg/HALKOYUN-AĞRI-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AĞRI E", "DOGU ANADOLU", null, 0, 1500 },
                    { "37dc26ce-cc4c-452c-ac8c-90d299e23446", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(196), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT", null, null, 1500, null },
                    { "3c237204-b5b4-415b-9d21-653bb46a1956", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(164), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MÜRDÜM", null, null, 1500, null },
                    { "3f00e412-5d19-4873-bcd1-50d371dbbcfe", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(264), null, null, true, false, "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN RENKLİ ETEK", null, "ROMAN", 1500, null },
                    { "3f18cceb-ae1b-4aa1-9047-3f8e0ac54493", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9747), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 1500, null },
                    { "3f73173d-9ae9-40b8-80a8-f12a25b3929f", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(482), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRAÇIK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR AÇIK", "EGE", null, 0, 1500 },
                    { "4027ac59-523a-437e-89b2-e98aeadaa261", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9626), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 1500, null },
                    { "411b3362-70a2-4c8a-95a3-2459002d190e", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9976), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "412e286b-a90e-4dff-96b4-999f2a901f73", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(775), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", null, 0, 1500 },
                    { "43c3b279-13c8-468e-97bd-3872f9a582e4", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9800), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 1500, null },
                    { "43cfd090-440b-4c76-a3f4-7bca14d16951", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9550), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "44a785d2-3d3b-41a8-bfdf-d27a206351c6", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9833), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 1500, null },
                    { "4596bc32-0875-430f-a34c-c22156321dde", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9904), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 0, 1500 },
                    { "47365abd-3e81-490b-8e7c-bb6e0b662ca3", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(449), null, true, true, true, "/databaseimg/HALKOYUN-AYDIN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AYDIN K", "EGE", null, 0, 1500 },
                    { "47666651-4023-4654-8929-94993b4af8f3", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9602), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 1500, null },
                    { "48df508a-4cbc-44fe-b972-e09bb3c0ed16", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9949), null, true, true, false, "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "49e79188-8bcf-41be-85f4-5c435f070d24", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(136), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN BORDO", null, null, 1500, null },
                    { "4a4a1a1b-7e87-4d25-b947-b78f6fd8d12a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(991), null, true, true, true, "/databaseimg/HALKOYUN-ÜSKÜPSİYAH-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP SİYAH K", "TRAKYA", null, 0, 1500 },
                    { "4b9bea88-096a-4683-8027-9599cfa2d69e", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(159), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MOR", null, null, 1500, null },
                    { "4bea10f7-a7b6-4f34-85b3-b2a00099ed39", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(867), null, false, true, true, "/databaseimg/HALKOYUN-BURSA-E2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURSA E2", "MARMARA", null, 0, 1500 },
                    { "4d8e929c-4d10-4468-ba81-b0cc862b736a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(689), null, true, true, true, "/databaseimg/", "2halkoyun", "ESKİŞEHİR K3", "İÇ ANADOLU", null, 0, 1500 },
                    { "4df1b746-f222-48f2-b107-4cfe364f7577", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9728), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 1500, null },
                    { "4e4bf44d-0d6a-47cc-95ef-cce7c23cd04e", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(961), null, null, true, true, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 0, 1500 },
                    { "4fd2a710-6fac-4234-8b7b-9627ed63b876", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(427), null, true, true, true, "/databaseimg/HALKOYUN-SİLİFKE-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE K3", "AKDENİZ", null, 0, 1500 },
                    { "51677e27-5310-4966-b51f-9025ed7b878a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(746), null, true, true, true, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 0, 1500 },
                    { "51bad36d-670b-48bf-bae6-440f1801ee6a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(600), null, false, true, true, "/databaseimg/HALKOYUN-ADANAABA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADANA ABA", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "51f27150-01ab-4240-a397-6f09c98abf5b", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9804), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 1500, null },
                    { "520e27e8-ac3d-4474-81a4-0be197fb1c46", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9612), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "52b68678-0b02-4e60-abee-d68922f8e2d0", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(620), null, true, true, true, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "53f500bc-055c-4a2d-a936-5ffd528b504e", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(105), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 1500, null },
                    { "54482164-6d2b-4f91-ae90-97936f099a19", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9945), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "54adb991-a34b-4115-990f-d088f694b6fc", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(10), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 1500, null },
                    { "55ead10b-6267-4460-8712-ce04fba73163", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(22), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "5652880a-b166-4f5a-8792-def2bf0fe9c4", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(700), null, true, true, true, "/databaseimg/", "2halkoyun", "SİVAS K", "İÇ ANADOLU", null, 0, 1500 },
                    { "5664f2dc-80e7-4528-a3d2-efaab0fa94e9", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(190), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI-N2", null, null, 1500, null },
                    { "5776db01-4bb8-4152-a9cc-7b99e22c6024", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(824), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K", "KARADENİZ", null, 0, 1500 },
                    { "57e4e491-b662-4805-b12d-4a5f619f1857", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(862), null, false, true, true, "/databaseimg/HALKOYUN-BURSA-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURSA E", "MARMARA", null, 0, 1500 },
                    { "597879bf-b387-4627-8a9a-0247dd4759cf", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(75), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "5b22dcc1-aec1-4038-ac1d-e18fd5662dd5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(118), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 1500, null },
                    { "5b2c04fb-69e0-4140-93b9-e7842b4264cc", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(892), null, null, true, true, "/databaseimg/HALKOYUN-BORDOCEPKEN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA BORDO CEPKEN", "TRAKYA", null, 0, 1500 },
                    { "5b54bd41-3087-4850-878c-46a3d3178120", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9697), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 1500, null },
                    { "5c8a5da0-3069-49bc-832e-92cea672e6e9", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9693), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "5c8ac388-aaaa-463a-8443-a4c0dd019da1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(300), null, null, true, false, "/databaseimg/ROND-FERACE-YETİŞKİN-KİRALIK.jpg", "5rond", "FERACE", null, null, 1500, null },
                    { "5ef38aba-6112-467d-8a26-4b781780c525", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9898), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 0, 1500 },
                    { "5fe57e21-9197-4b53-acbe-33e16d2a0a5d", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(93), null, true, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 1500, null },
                    { "607f4ee6-97c3-4f3c-9eac-d07579d5aa35", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9846), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 1500, null },
                    { "60b5c175-1078-4384-b57a-c0a774b54335", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(738), null, false, true, true, "/databaseimg/HALKOYUN-KAFKAS-E3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS E3", "KAFKAS", null, 0, 1500 },
                    { "6105d1df-f8e0-4c8d-988a-d7997399c5da", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9674), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "61e52819-b22f-4c92-927c-6e47757f92da", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(742), null, false, true, true, "/databaseimg/HALKOYUN-KAFKAS-E4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS E4", "KAFKAS", null, 0, 1500 },
                    { "61f596ff-b53e-461d-92bb-33164b070a84", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(586), null, true, true, true, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", null, 0, 1500 },
                    { "62431546-72d7-4e0e-8cfc-f710ec97a35c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(234), null, null, true, false, "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", "4dans", "AŞUK MAŞUK", null, null, 1500, null },
                    { "63c14549-a051-4916-a4e9-32ea80b02e45", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(66), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "65589cd6-475b-48ed-9f21-9255cf08eb53", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(956), null, null, true, true, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 0, 1500 },
                    { "69511ba7-8de2-47e5-841c-cd2502062bc6", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9741), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 1500, null },
                    { "69b3de9d-5807-4ad1-96c3-eca78a20e801", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(975), null, null, true, true, "/databaseimg/HALKOYUN-ÜSKÜPBEYAZCEPKEN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP BEYAZ CEPKEN", "TRAKYA", null, 0, 1500 },
                    { "6a396607-5ba3-4e44-a844-2e04132771ed", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(404), null, true, true, true, "/databaseimg/HALKOYUN-MUT-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MUT K", "AKDENİZ", null, 0, 1500 },
                    { "6aa225bf-b30c-4d3a-814e-a5918ddb6f59", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(206), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N3", null, null, 1500, null },
                    { "6b918df1-0eba-4fb4-8af0-a4a6773e6b3f", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(902), null, null, true, true, "/databaseimg/HALKOYUN-KIRMIZIRENKLİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA KIRMIZI RENKLİ", "TRAKYA", null, 0, 1500 },
                    { "6cf6137e-971f-49b8-989b-e53814f858d4", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(98), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 1500, null },
                    { "6ee4cff8-083c-468a-b9a3-7fa4a026d1c3", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(172), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN YEŞİL", null, null, 1500, null },
                    { "6f2b144c-152f-49ad-b6f6-045ad98feeb5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9861), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 0, 1500 },
                    { "704a7ba7-7611-4bf9-a3a0-5a99c65a72e6", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(944), null, null, true, true, "/databaseimg/HALKOYUN-PEMBERENKLİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA PEMBE RENKLİ", "TRAKYA", null, 0, 1500 },
                    { "711fda26-d4aa-4c10-8058-fa775cde39af", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(214), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE-N2", null, null, 1500, null },
                    { "7460a2e3-e570-467f-bab7-ad77eac994bd", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9598), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "74e629a1-898e-47de-809b-6767d9b958c9", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(677), null, true, true, true, "/databaseimg/HALKOYUN-ESKİŞEHİR-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ESKİŞEHİR K2", "İÇ ANADOLU", null, 0, 1500 },
                    { "763abbe1-ec25-4e61-887f-30855c051ba3", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9972), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "76e03824-5af4-4569-9414-e0fcadb13f6e", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(939), null, null, true, true, "/databaseimg/HALKOYUN-MORMONORAY-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 0, 1500 },
                    { "77161984-0b89-4241-bae3-5820f98adfc2", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(176), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ BORDO", null, null, 1500, null },
                    { "772aed2b-4279-4929-8718-561b10912c88", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9708), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "77a6c6c3-9bb9-48a0-b788-cab6d8de1a7a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9684), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 1500, null },
                    { "77d8590d-c229-4068-93f7-baff825d11e4", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(605), null, true, true, true, "/databaseimg/HALKOYUN-ADANA-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADANA K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "7b9d6282-03f1-4203-955c-c09c54528b58", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(40), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 1500, null },
                    { "7cc578ac-fe58-4fc9-906b-a433e4f1152a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(431), null, true, true, true, "/databaseimg/HALKOYUN-AFYON-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AFYON K", "EGE", null, 0, 1500 },
                    { "7ea1f017-64cf-48e1-a4e3-85ba8ba18428", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(803), null, false, true, true, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", null, 0, 1500 },
                    { "7fd91b33-614f-4d5d-9e4b-17ae3d5b8050", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(807), null, true, true, true, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", null, 0, 1500 },
                    { "814143b2-d175-471a-859e-4ecddb2c4a38", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(360), null, null, true, false, "/databaseimg/ROND-SEMAZEN-YETİŞKİN-KİRALIK.jpg", "5rond", "SEMAZEN", null, null, 1500, null },
                    { "81499a16-ce2b-4af7-8c5f-3808f58a0e01", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9992), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 1500, null },
                    { "81b3ac1e-8987-47f1-80c3-da64b94fe1e9", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9791), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 1500, null },
                    { "81f4660e-a6b5-4707-a64a-0e59806a3929", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(673), null, true, true, true, "/databaseimg/HALKOYUN-ESKİŞEHİR-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ESKİŞEHİR K", "İÇ ANADOLU", null, 0, 1500 },
                    { "82dee2b4-cc26-45f1-b20d-43c170eea9be", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(536), null, true, true, true, "/databaseimg/HALKOYUN-ARDAHAN-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARDAHAN K", "DOGU ANADOLU", null, 0, 1500 },
                    { "8360acf9-e04a-43a3-bdb0-791c4ee85ad5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(550), null, true, true, true, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", null, 0, 1500 },
                    { "838015d3-fcc0-43c8-ad6e-c4dc4c39cb6c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(285), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ E", null, null, 1500, null },
                    { "862b169a-1797-4e8e-9499-75a2ebe70ff2", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(649), null, true, true, true, "/databaseimg/HALKOYUN-GAZİANTEP-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP K2", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "8677752f-b55e-4242-90b6-c7304c630a48", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9787), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 1500, null },
                    { "86845b55-c725-40f3-8740-83aaea9967a8", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(26), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 1500, null },
                    { "86a65c39-8834-4a09-b197-b0b655f8359c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(695), null, true, true, true, "/databaseimg/HALKOYUN-ESKİŞEHİR-K4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ESKİŞEHİR K4", "İÇ ANADOLU", null, 0, 1500 },
                    { "87562927-b1c9-4e87-bbb8-26d8a237a296", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(113), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 1500, null },
                    { "87c7291a-ab62-43d0-ba73-6f8f3cbde9d0", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9670), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 1500, null },
                    { "893e5443-9f99-470f-ab55-c2fe4c15a91f", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(501), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRMÜRDÜM-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR MÜRDÜM", "EGE", null, 0, 1500 },
                    { "8c8b03a5-a3c6-4291-a714-5a66343e09df", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(733), null, false, true, true, "/databaseimg/HALKOYUN-KAFKAS-E2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS E2", "KAFKAS", null, 0, 1500 },
                    { "90af96d6-ba45-48a4-a703-801c92048156", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9809), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 1500, null },
                    { "90c4d5eb-9457-4ae4-9987-7b487a6b3416", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(349), null, null, true, false, "/databaseimg/ROND-NOELBABA-YETİŞKİN-KİRALIK.jpg", "5rond", "NOEL BABA", null, null, 1500, null },
                    { "91d0103f-3161-4dae-8b79-fb94aa5f872a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(80), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "9302fbf9-3ae8-41ff-a441-0d597347a433", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(515), null, null, true, true, "/databaseimg/HALKOYUN-AĞRIBEYAZ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AĞRI BEYAZ", "DOGU ANADOLU", null, 0, 1500 },
                    { "9336d43a-a6e5-444f-bf93-3d8b5b2599fc", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9928), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpG", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 1500, null },
                    { "94bd351d-6bcc-4dc8-8b3d-edaa298ac010", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(929), null, null, true, true, "/databaseimg/HALKOYUN-MORRENKLİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA MOR RENKLİ", "TRAKYA", null, 0, 1500 },
                    { "96baf646-673b-4ab5-bf32-d0fb41608ca1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(818), null, false, true, true, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", null, 0, 1500 },
                    { "97b906db-0d1c-41ea-a21e-884887ba3a81", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9983), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "9aaad621-6c2f-43d3-9e15-6d42b6c544c9", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(383), null, false, true, true, "/databaseimg/HALKOYUN-BURDUR-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURDUR E", "AKDENİZ", null, 0, 1500 },
                    { "9baee5e3-a3a2-40c0-8027-b3fe5a21dfa3", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(798), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K5-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K5", "KARADENİZ", null, 0, 1500 },
                    { "9dc8d711-51d4-4185-9028-2920cb1810d2", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9908), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "a0b178f8-0ee2-479d-861e-d3afbcc19bbe", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(281), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI K", null, null, 1500, null },
                    { "a1733588-ad88-420a-94c6-6f8b748a12cd", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(625), null, false, true, true, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "a48bb60b-7094-4271-9bab-adc179e237b3", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9688), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 1500, null },
                    { "a6822729-dad5-4cfc-a391-6d23d7b3d9f9", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9865), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 0, 1500 },
                    { "a7f6f6dd-57fc-4743-bd16-7644cac6bf9f", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(907), null, true, true, true, "/databaseimg/HALKOYUN-KORDONEFK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA KORDONE FK", "TRAKYA", null, 0, 1500 },
                    { "a8802bac-216c-45c7-a2d7-ebcb6f3e1d59", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(439), null, false, true, true, "/databaseimg/HALKOYUN-AYDIN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "AYDIN E", "EGE", null, 0, 1500 },
                    { "ab96bf04-30b2-4bfe-aed1-d0ecc6430264", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9996), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 1500, null },
                    { "ac9bf59c-c275-4548-a0f2-6ad973dae402", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(244), null, null, true, false, "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", "4dans", "LİRİK", null, null, 1500, null },
                    { "adf1c7f9-8e50-4753-b49b-9ff7e41c92d5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(709), null, true, true, true, "/databaseimg/HALKOYUN-TOKAT-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TOKAT K2", "İÇ ANADOLU", null, 0, 1500 },
                    { "ae05444b-5201-44e6-bf08-b8c45e900a6c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(616), null, false, true, true, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "aee08430-96f3-4ff6-b9ee-40360096b176", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(952), null, null, true, true, "/databaseimg/HALKOYUN-TRAKYAÇAĞLA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA ÇAĞLA", "TRAKYA", null, 0, 1500 },
                    { "affce813-76e0-400b-bf61-0b368d75c18f", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9704), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 1500, null },
                    { "affdf0f7-b625-460d-a829-8d23cd6f22f2", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9592), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 1500, null },
                    { "b03a71d2-8a66-4454-a967-befcf26db770", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(313), null, null, true, false, "/databaseimg/ROND-MANASTIR-YETİŞKİN-KİRALIK.jpg", "5rond", "MANASTIR", null, null, 1500, null },
                    { "b16ee9cc-18e6-4d7c-b2a3-1b6af629f104", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(257), null, null, true, false, "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN PEMBE", null, "ROMAN", 1500, null },
                    { "b384a5ad-9e17-4866-a386-9ed900e93adf", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9760), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 1500, null },
                    { "b38cf606-1766-4706-b6aa-4e824e8ab989", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(924), null, null, true, true, "/databaseimg/HALKOYUN-MORMARAŞİŞİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MOR MARAŞ İŞİ", "TRAKYA", null, 0, 1500 },
                    { "b3f69e0e-61f0-4dd5-b73f-bcbc82d9cff9", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(493), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRKOYU-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR KOYU", "EGE", null, 0, 1500 },
                    { "b3ff8cb7-5266-44fb-b4be-1ff416d4d4c1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(582), null, true, true, true, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", null, 0, 1500 },
                    { "b58e23b1-c2ad-4eaf-9630-0536f7870a33", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9879), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 0, 1500 },
                    { "b8f62ed3-b2dd-446c-bbb1-847717f6c323", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(704), null, true, true, true, "/databaseimg/HALKOYUN-TOKAT-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TOKAT K", "İÇ ANADOLU", null, 0, 1500 },
                    { "b92844c0-2416-432d-aa0a-a3223b2f0488", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(294), null, null, true, false, "/databaseimg/ROND-ÇANAKKALEASKERİ-YETİŞKİN-KİRALIK.jpg", "5rond", "ÇANAKKALE ASKERİ", null, null, 1500, null },
                    { "b99c46a0-13e3-4ca2-ba1e-ac9b73ef0ef5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(596), null, false, true, true, "/databaseimg/HALKOYUN-ADANA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADANA", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "baa879a2-c12b-4f96-af0e-5104461d14c4", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9645), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 1500, null },
                    { "bab7f3b3-f222-4e09-bcf3-5764dcba0fb5", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(182), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ GRİ-SİYAH", null, null, 1500, null },
                    { "bbc5e54e-999f-4ecf-8429-837a7e0b2f12", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9717), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 1500, null },
                    { "bc1a14ee-6b1f-44ff-9d26-1b0195023b2a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(84), null, true, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "be3c0131-0833-4606-bcb4-bde89ca52f87", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(122), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "c0c714ad-3397-42e8-9ec3-4861ea643c21", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(545), null, true, true, true, "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", null, 0, 1500 },
                    { "c1c1f30c-e3fa-4004-b4f1-54ee88aab81d", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(554), null, true, true, true, "/databaseimg/HALKOYUN-ERZİNCAN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ERZİNCAN", "DOGU ANADOLU", null, 0, 1500 },
                    { "c1c2e742-539b-48ea-bba9-8251e1d29c02", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(1000), null, true, true, true, "/databaseimg/HALKOYUN-RENKLİSALTA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA RENKLİ SALTA", "TRAKYA", null, 0, 1500 },
                    { "c2da624a-1efd-434f-b316-47bc411e15c1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(35), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 1500, null },
                    { "c3d616b9-9284-4c3e-b203-eda305660bc5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(643), null, true, true, true, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "c3f7e33e-9c98-4bdf-8832-fe2048bc5ff2", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(373), null, false, true, true, "/databaseimg/HALKOYUN-ANAMUR-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ANAMUR E", "AKDENİZ", null, 0, 1500 },
                    { "c4019848-1786-4b82-8df2-843b3b0eb50e", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(478), null, false, true, true, "/databaseimg/HALKOYUN-DENİZLİ-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "DENİZLİ K", "EGE", null, 0, 1500 },
                    { "c6c4afae-9444-4a95-b71d-c53732558585", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9587), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 1500, null },
                    { "caa99c02-3b6e-4674-9d36-19bdc4d52580", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(378), null, true, true, true, "/databaseimg/HALKOYUN-ANAMUR-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ANAMUR K", "AKDENİZ", null, 0, 1500 },
                    { "cadbb66e-e9e2-4922-9bfd-f1cc17b71aaf", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9583), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "cc7e00fe-cad0-4d34-8240-132bee900f1d", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9819), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 1500, null },
                    { "cd489e5c-bfc1-4e1c-802b-6bb32a9eba67", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(230), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ YEŞİL", null, null, 1500, null },
                    { "cd4d1a6f-e5c9-404b-9211-49d8bc80ca7a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(857), null, true, true, true, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BOLU K", "MARMARA", null, 0, 1500 },
                    { "ce53687b-40f8-4afe-8e17-5e5c620fef2c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9795), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 1500, null },
                    { "ceacb3c9-eb85-4582-8262-ccfcca6a5d47", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(468), null, null, true, true, "/databaseimg/HALKOYUN-ÇANAKKALEPOMAK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÇANAKKALE POMAK", "EGE", null, 0, 1500 },
                    { "d243e00a-666d-41b6-92a0-cc0165a0385b", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(565), null, true, true, true, "/databaseimg/HALKOYUN-HAKKARİ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "HAKKARİ", "DOGU ANADOLU", null, 0, 1500 },
                    { "d298b6d4-3441-47d0-9cbf-1d790600c39e", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9932), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 1500, null },
                    { "d3f23e0e-2d1f-4ce9-ab1f-2eedb35110ed", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(591), null, true, true, true, "/databaseimg/HALKOYUN-VANLACİVERT-YETİŞKİN-SATILIK.jpg", "2halkoyun", "VAN LACİVERT", "DOGU ANADOLU", null, 0, 1500 },
                    { "d42b7419-2613-4b0b-8827-15d787fd780c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9891), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 0, 1500 },
                    { "d4745d8a-f68b-4a92-a901-f3ed2d20dcfa", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(847), null, null, true, true, "/databaseimg/HALKOYUN-TRABZONYELEK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON YELEK", "KARADENİZ", null, 0, 1500 },
                    { "d606bc67-cc0b-44c4-b9e0-24e284ad4a4c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(131), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MUĞLA", "EGE", "ZEYBEK", 1500, null },
                    { "d6be389e-2df7-45d0-a3a2-fa9839edf708", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9783), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 1500, null },
                    { "d6d4c40c-2bb2-48fe-ad8d-48d3d281d6a4", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9777), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 1500, null },
                    { "d6e8a96f-3bdc-4988-bb38-1e32baac9919", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9654), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 1500, null },
                    { "d7e994d4-1ede-4cde-8992-adabbede9755", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(842), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K5-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K5", "KARADENİZ", null, 0, 1500 },
                    { "d7f6f559-b462-484c-a1b6-0c27eb6e0c49", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(751), null, true, true, true, "/databaseimg/HALKOYUN-KAFKAS-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS K2", "KAFKAS", null, 0, 1500 },
                    { "d8013c32-4b90-4506-a3e3-8cd46d9905d8", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(413), null, false, true, true, "/databaseimg/HALKOYUN-SİLİFKE-E2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "SİLİFKE E2", "AKDENİZ", null, 0, 1500 },
                    { "da13ba52-29cc-49af-84aa-24ac782195ca", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9923), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "dbe94983-02e6-4590-98d2-e6de3204e175", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9555), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 1500, null },
                    { "dc849313-5dd4-4942-9ae7-8086906abe4e", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(511), null, true, true, true, "/databaseimg/HALKOYUN-MUĞLA-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MUĞLA K", "EGE", null, 0, 1500 },
                    { "ddb6b011-1a4e-4d57-a93d-14a8d6cff9d6", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(814), null, null, true, true, "/databaseimg/HALKOYUN-TRABZONCEPKEN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON CEPKEN", "KARADENİZ", null, 0, 1500 },
                    { "ddde73be-5647-48a8-b26b-299a08f8674e", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(317), null, null, true, false, "/databaseimg/ROND-MEHTER-YETİŞKİN-KİRALIK.jpg", "5rond", "MEHTER", null, null, 1500, null },
                    { "de63ddb4-6ffa-47d0-bd6f-d4f7d84fde82", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(354), null, null, true, false, "/databaseimg/ROND-PADİŞAH-YETİŞKİN-KİRALIK.jpg", "5rond", "PADİŞAH", null, null, 1500, null },
                    { "deb2d5a6-f39f-4258-97f1-317de1e84d5d", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(995), null, false, true, true, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", null, 0, 1500 },
                    { "df879dcc-72e5-4c08-be0b-419154f3ccdb", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(755), null, true, true, true, "/databaseimg/HALKOYUN-KAFKAS-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS K3", "KAFKAS", null, 0, 1500 },
                    { "e0e53925-2471-431d-b120-9946b0c387e8", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(760), null, true, true, true, "/databaseimg/HALKOYUN-KAFKAS-K4-YETİŞKİN-SATILIK.jpg", "2halkoyun", "KAFKAS K4", "KAFKAS", null, 0, 1500 },
                    { "e22ccc00-96c0-4c4b-a049-2bdcbc9c45bf", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(276), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI E", null, null, 1500, null },
                    { "e271612f-8bab-4ac0-9362-c46f6871a5e5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9829), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 1500, null },
                    { "e3849814-64f0-47b6-8d7e-f825c9434ef7", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9883), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 0, 1500 },
                    { "e3af3e8e-c0f3-48cd-b653-877743089f7d", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(722), null, true, true, true, "/databaseimg/HALKOYUN-GÜRCÜ-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GÜRCÜ K", "KAFKAS", null, 0, 1500 },
                    { "e60ba730-f850-4d12-aa0a-6021a553ff83", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9561), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 1500, null },
                    { "e79079e1-e8ba-460a-84b0-16c7476a87b3", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(472), null, false, true, true, "/databaseimg/HALKOYUN-DENİZLİ-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "DENİZLİ E", "EGE", null, 0, 1500 },
                    { "e7fe6e95-41a2-4eaa-9db7-04e945e35eb5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(658), null, false, true, true, "/databaseimg/HALKOYUN-URFA-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "URFA E", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "e8434f5b-93ad-46ef-bc0e-bc811cc9b03c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9531), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "e8d97378-4224-4234-a669-49a51b8307ee", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9842), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 1500, null },
                    { "e98f042e-b67e-4422-9342-e5349cb89b69", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(252), null, null, true, false, "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, "ROMAN", 1500, null },
                    { "ea05bd44-20eb-4210-bf10-bc8b35d497fc", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9768), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 1500, null },
                    { "ea77a920-2a76-453f-8113-b0dc04b9504b", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(764), null, false, true, true, "/databaseimg/HALKOYUN-ARTVİN-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN E", "KARADENİZ", null, 0, 1500 },
                    { "ea97c1f0-1970-4fd7-a5d4-7433afbe82ac", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(202), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N2", null, null, 1500, null },
                    { "eb74a597-90c8-4e0a-83cd-224488f64f84", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9607), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "ed0d5e78-22c8-450e-bbdb-dcd3931c029e", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(559), null, true, true, true, "/databaseimg/HALKOYUN-ERZURUM-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ERZURUM E", "DOGU ANADOLU", null, 0, 1500 },
                    { "ee20a4c0-9879-4643-a4d1-daadf5c3b157", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9751), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 1500, null },
                    { "ef1368be-00ea-41af-aab2-fdd7b8017786", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9962), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 1500, null },
                    { "efc3d543-dca1-4c80-b4e2-451b534b2bc3", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(1), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 1500, null },
                    { "efe1611d-a016-45f5-8f33-7778815f7c03", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(784), null, true, true, true, "/databaseimg/HALKOYUN-ARTVİN-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ARTVİN K3", "KARADENİZ", null, 0, 1500 },
                    { "efe57f4f-3047-40e7-a918-ee026cc33d03", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(611), null, true, true, true, "/databaseimg/HALKOYUN-ADANA-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ADANA K2", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "f00adce5-a9e6-44d7-98b0-152761b5b366", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(916), null, null, true, true, "/databaseimg/HALKOYUN-MANASTIRKAFTAN-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MANASTIR KAFTAN", "TRAKYA", null, 0, 1500 },
                    { "f15858ee-1763-4b26-bb3c-82ae6b61eac5", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(882), null, true, true, true, "/databaseimg/HALKOYUN-BURSA-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURSA K", "MARMARA", null, 0, 1500 },
                    { "f22a51a1-cb12-4580-b00d-b27cff7dfd5b", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(290), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ K", null, null, 1500, null },
                    { "f307483d-89af-43f7-9c07-4e9cc8abcd5a", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(933), null, null, true, true, "/databaseimg/HALKOYUN-MORSALTA-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA MOR SALTA", "TRAKYA", null, 0, 1500 },
                    { "f490a487-8e76-4dbb-9e8b-12f9b66f01f4", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9764), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 1500, null },
                    { "f584cff5-f1d0-40f7-9b31-fac90ee79877", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(920), null, null, true, true, "/databaseimg/HALKOYUN-MANASTIRYELEK-YETİŞKİN-SATILIK.jpg", "2halkoyun", "MANASTIR YELEK", "TRAKYA", null, 0, 1500 },
                    { "f5c5ff2d-7260-421f-b842-91103227720c", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9954), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "f620a4fe-8602-4e1f-886b-b041a54f2a80", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(971), null, true, true, true, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÜSKÜP BORDO K", "TRAKYA", null, 0, 1500 },
                    { "f673184c-8fff-45e4-8a25-4bf39529ddf8", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9733), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 1500, null },
                    { "f6886447-efb8-4e3c-a8b8-3866f1bcb4fb", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(506), null, null, true, true, "/databaseimg/HALKOYUN-İZMİRMOR-YETİŞKİN-SATILIK.jpg", "2halkoyun", "İZMİR MOR", "EGE", null, 0, 1500 },
                    { "f835f632-d1dc-4a3b-9aba-e09ffe7078e0", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(272), null, null, true, false, "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN YEŞİL", null, "ROMAN", 1500, null },
                    { "f8a821cc-1ea9-41fa-81d4-d58ec35df947", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(668), null, false, true, true, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", null, 0, 1500 },
                    { "f95c8bd9-9650-4009-be80-58f16892f19b", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9640), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 1500, null },
                    { "f9b90846-a2c7-42d3-9f92-03fa9c45c4ab", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(71), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "fb148cb9-b9e9-4a39-8c99-50f1bcbdcd8a", 0, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(948), null, null, true, true, "/databaseimg/HALKOYUN-TRAKYABEJ-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRAKYA BEJ", "TRAKYA", null, 0, 1500 },
                    { "fb3f1e4f-8007-42ed-91bc-fa22a185881a", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9967), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 1500, null },
                    { "fbfbe31e-7248-4c81-897c-28b32b7e8bc1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(392), null, true, true, true, "/databaseimg/HALKOYUN-BURDUR-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURDUR K2", "AKDENİZ", null, 0, 1500 },
                    { "fc3110d6-a1c8-4d8d-a3d6-7c8edbe46861", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(638), null, false, true, true, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", null, 0, 1500 },
                    { "fcf58329-38f4-4f41-b20e-4ebbbdca17e1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(887), null, true, true, true, "/databaseimg/HALKOYUN-BURSA-K2-YETİŞKİN-SATILIK.jpg", "2halkoyun", "BURSA K2", "MARMARA", null, 0, 1500 },
                    { "fddc360d-162c-45bf-86aa-b17a234eca99", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(454), null, false, true, true, "/databaseimg/HALKOYUN-ÇANAKKALE-E-YETİŞKİN-SATILIK.jpg", "2halkoyun", "ÇANAKKALE E", "EGE", null, 0, 1500 },
                    { "fe661d90-223a-4f13-a7a3-589be4e5d6c1", 10, new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(833), null, true, true, true, "/databaseimg/HALKOYUN-TRABZON-K3-YETİŞKİN-SATILIK.jpg", "2halkoyun", "TRABZON K3", "KARADENİZ", null, 0, 1500 },
                    { "ff3f1142-f3bd-4ee2-a1d6-7e808d844fef", 10, new DateTime(2024, 12, 18, 15, 39, 50, 344, DateTimeKind.Local).AddTicks(9631), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 18, 15, 39, 50, 345, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "d53dc60d-2e5b-4c64-9e2c-b6a795595cd1", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 18, 15, 39, 50, 346, DateTimeKind.Local).AddTicks(2456), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreatedAt", "SizeNumber" },
                values: new object[,]
                {
                    { "04f0832d-56d6-462a-9045-e3b78113f528", new DateTime(2024, 12, 18, 15, 39, 50, 346, DateTimeKind.Local).AddTicks(4431), 10 },
                    { "636dd9cb-281c-453c-b136-6f8b697afaa8", new DateTime(2024, 12, 18, 15, 39, 50, 346, DateTimeKind.Local).AddTicks(4445), 14 },
                    { "778c4ff9-73b9-4fef-80b2-34b957170f1e", new DateTime(2024, 12, 18, 15, 39, 50, 346, DateTimeKind.Local).AddTicks(4440), 12 },
                    { "e9cb512b-f318-4ff8-a44e-c4ba4f28d313", new DateTime(2024, 12, 18, 15, 39, 50, 346, DateTimeKind.Local).AddTicks(4414), 8 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "2ab2b87c-6257-46e3-9425-115c6febb7e0", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                keyValue: "010e12d2-c94c-432f-99af-c4e55a2e3d82");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "04b477a4-9424-4e1c-b108-4ba8314883b0");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "19818aec-dd49-456e-bdf1-b8d43b8e060a");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "198eb556-3fd0-4a6a-b21f-82aff9dd7c3e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "19fb78a9-14aa-41b4-9490-10b800bb3aee");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "20496491-c331-4168-bbcc-4f6b2da2cd58");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "3d456943-4bb9-4687-9346-5ad196c01085");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "3d5418f7-1038-41a2-8d52-09a55732fd25");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "472f374f-8560-4a7d-8a95-1d4813b2a4ff");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "490f738d-750f-4165-8950-5078269b193e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "643d07eb-4578-40b1-9e73-ad8dd03f6076");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "7aa05184-fbc8-40b5-a3d3-3ac71574c465");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "880f65e9-7efa-4dbe-ad2e-8815395c4586");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "93e6f81e-e3f2-4f40-9b4c-5a24518f22a6");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "aafa71a4-465c-4d1a-a05b-ffc95260c91b");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "ab1b64b9-9bd1-4924-a93a-667d42c1a74c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "bc87bfcf-13c7-4b18-aee9-73f1fceaec96");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "cff120c7-8708-4745-b237-96e105175061");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d1daf447-c3da-40d8-bb04-9975a2006d89");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d6c09acc-fa6a-43ad-9bdf-337484bb41ed");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "ee0cfae7-9cae-4c43-8513-f9d915a174ca");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f43fac1d-91ec-4fc4-9a4d-922c216b633b");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f7860401-a447-4ef2-a37d-b716b9d72d0e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "ff966cc5-3458-473d-bf56-1d745cabf406");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "30e1a8b8-c19f-40fb-aba9-4722112c9085");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "a63acc40-e6c3-4c90-8e47-7689cbafa432");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "e6b52e4e-3545-4284-9fa3-82bbd46389e4");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "eb88e5b2-504a-4b36-8f4c-3731ffd73391");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00988b97-d551-4c62-87cc-2ee76f42cca8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "032eb8a2-3232-4fac-b5cc-7a914fb917f0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "034d7499-0b10-4460-b5f8-79f5baca0f99");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "066dc471-8739-4a12-90c0-af77bc71d2f3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "08a831ad-e680-4702-a8e2-6c25a195d02a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09481b3c-1e7f-40fa-8036-e3e00d90b158");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0a2db546-0e0c-4d41-996d-377cca442951");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0c737309-377a-4b1f-970a-f151be5fd7c4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0d1a32a3-bcf1-4252-b3b4-d8fb54dded21");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0d9e1503-803f-4a76-9642-a8d4bc1fb248");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f2206e5-0424-4f9e-8c5e-4cf7193785d3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "11602e6f-bdd5-49ca-a124-9ddb2bc14498");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "11a4566b-28de-4002-b3e3-f5dc43f58dd1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "13f56561-c6de-48af-aece-fff5c073aa4b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "14de612f-9de8-4d15-ba74-ada91cef24c6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "14f3e519-d722-41cf-99d3-15329ad5f343");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1575d722-ffb4-4576-bcc4-8a72116991c5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "159bb68e-40ea-4efe-b193-a6d6fcb8033a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1623fddd-8377-4dad-ae8a-42e34586a3c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16b273e7-9b09-450f-ae26-5148db31d95b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "17257d8f-9048-42d8-b72e-f3a3715858da");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19480838-dd1e-4b44-bbe8-b5d4f01a0ee2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1991f124-8a3c-44cb-8010-6cd453122be0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19c3dc39-9d05-4bbc-90fa-28c03f119767");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19dff48f-263d-4a37-b443-427088c400fe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1af6bc2c-0bc6-4596-8967-7ef1d832ab80");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c65f8c9-fc56-4b05-b283-8b85d532f0e8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1dec2ab7-2d16-4f8e-9ede-fc8b9230c985");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1e0fe0a3-5c33-489d-acd5-7d440151c133");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1e3d57d1-1bde-4050-9a28-2c0f4785f740");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1e87c325-9b58-4c24-9c3f-7ccfd31342d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1ece8c33-5711-40bd-8dd7-1b6e5b8b5ad9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2048d886-6171-4eab-a1c3-320e881bf5bd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "206931c4-56ea-4ba8-8425-7de478d0a1b2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "20afda3a-51dd-4c53-8792-ce046a014bee");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "20d2f544-ae5b-44f0-aa29-5d886154602b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "219202db-350f-45f8-b737-4c4e610c17bc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "22471522-d28a-4a15-95d1-9fe0eee3c7d1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "22498d36-cc76-4272-bd34-319831912071");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2255f337-a4a3-42f8-b617-1f4197f93918");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "22e5b250-9b7e-4662-aeb8-ba6dc3cf5f98");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "24398275-5708-4d04-84cf-bb60fd4a1b24");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2669e632-55c6-42e9-beef-54f5209295f3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "27002143-d39c-427f-85d8-141f6700e765");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "277f8c18-2ee7-4a35-af1e-df7d1e029872");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "27c1fbc5-e660-40a6-89ef-5912f7036b71");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "28e57aae-ae88-44dc-a6ba-291caf9d5ed0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "299d7127-9878-4292-a414-55488e757992");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "29e433a6-92b2-4c69-a455-9fa23641733d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a880d91-ebf5-4aa1-a44d-162850bc4cd0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a927bf8-6c2b-48ff-ab5f-6dac9898e028");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2ae5f38d-01bf-415f-86be-fb06f8769377");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2b05e1a1-cec7-4db5-be38-0336786eecc6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2c45b746-4a98-45e7-8f4d-c95d7202d87a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2c5a6e4c-f440-4ad1-a141-d8966df30b5a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2cb58155-d359-48f4-be39-6c6d88e76f0f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d89f74b-2c5b-44a1-a8ca-dd0185832763");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2da1c2f6-f47c-4c12-b663-82d0d1df3324");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e0b1740-0b15-4a8f-bbd0-8692472a493c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e1e9ca6-73d9-4cf0-ace1-b2990b80d426");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e6c0a33-169f-420d-b52a-e783b9cc3db8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2f416e13-5a14-4cea-a1b0-49a033797ef1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2fd814bb-ea48-46f0-b288-0c92eac3b54f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2fece652-a2e3-4f61-95bc-1387d5416448");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "305e3ade-9449-4641-94f5-309e8bf92364");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "307c5a3a-1ae5-4110-8f54-ae4f198494f5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31303466-2f59-4815-98cd-557a35ccc4bb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "318c07e2-4630-4dcd-8a00-63e3e213eb83");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "32c09ebc-27e0-4ccc-a04c-af163bc0ea9f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "32dc777b-5a3f-47d4-af6c-18b60d461650");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3305fcb6-49e0-434d-994c-a0e90302b5a5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "34101ac2-a689-493b-9c3d-e6f98c54d565");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3633e4fb-9f3a-471f-8a3e-bc1f12784a94");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3638eac7-7a74-4eb4-9c90-58c5721def6f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "36e0896f-d02b-4f91-8005-c4c257cb5a17");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "36f3964a-7316-498e-9370-0ea37585111d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "37dc26ce-cc4c-452c-ac8c-90d299e23446");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3c237204-b5b4-415b-9d21-653bb46a1956");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f00e412-5d19-4873-bcd1-50d371dbbcfe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f18cceb-ae1b-4aa1-9047-3f8e0ac54493");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3f73173d-9ae9-40b8-80a8-f12a25b3929f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4027ac59-523a-437e-89b2-e98aeadaa261");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "411b3362-70a2-4c8a-95a3-2459002d190e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "412e286b-a90e-4dff-96b4-999f2a901f73");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43c3b279-13c8-468e-97bd-3872f9a582e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43cfd090-440b-4c76-a3f4-7bca14d16951");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "44a785d2-3d3b-41a8-bfdf-d27a206351c6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4596bc32-0875-430f-a34c-c22156321dde");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "47365abd-3e81-490b-8e7c-bb6e0b662ca3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "47666651-4023-4654-8929-94993b4af8f3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "48df508a-4cbc-44fe-b972-e09bb3c0ed16");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "49e79188-8bcf-41be-85f4-5c435f070d24");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4a4a1a1b-7e87-4d25-b947-b78f6fd8d12a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b9bea88-096a-4683-8027-9599cfa2d69e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4bea10f7-a7b6-4f34-85b3-b2a00099ed39");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4d8e929c-4d10-4468-ba81-b0cc862b736a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4df1b746-f222-48f2-b107-4cfe364f7577");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e4bf44d-0d6a-47cc-95ef-cce7c23cd04e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4fd2a710-6fac-4234-8b7b-9627ed63b876");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "51677e27-5310-4966-b51f-9025ed7b878a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "51bad36d-670b-48bf-bae6-440f1801ee6a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "51f27150-01ab-4240-a397-6f09c98abf5b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "520e27e8-ac3d-4474-81a4-0be197fb1c46");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52b68678-0b02-4e60-abee-d68922f8e2d0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "53f500bc-055c-4a2d-a936-5ffd528b504e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54482164-6d2b-4f91-ae90-97936f099a19");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54adb991-a34b-4115-990f-d088f694b6fc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55ead10b-6267-4460-8712-ce04fba73163");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5652880a-b166-4f5a-8792-def2bf0fe9c4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5664f2dc-80e7-4528-a3d2-efaab0fa94e9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5776db01-4bb8-4152-a9cc-7b99e22c6024");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "57e4e491-b662-4805-b12d-4a5f619f1857");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "597879bf-b387-4627-8a9a-0247dd4759cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b22dcc1-aec1-4038-ac1d-e18fd5662dd5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b2c04fb-69e0-4140-93b9-e7842b4264cc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b54bd41-3087-4850-878c-46a3d3178120");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5c8a5da0-3069-49bc-832e-92cea672e6e9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5c8ac388-aaaa-463a-8443-a4c0dd019da1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5ef38aba-6112-467d-8a26-4b781780c525");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5fe57e21-9197-4b53-acbe-33e16d2a0a5d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "607f4ee6-97c3-4f3c-9eac-d07579d5aa35");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "60b5c175-1078-4384-b57a-c0a774b54335");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6105d1df-f8e0-4c8d-988a-d7997399c5da");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61e52819-b22f-4c92-927c-6e47757f92da");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61f596ff-b53e-461d-92bb-33164b070a84");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "62431546-72d7-4e0e-8cfc-f710ec97a35c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "63c14549-a051-4916-a4e9-32ea80b02e45");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "65589cd6-475b-48ed-9f21-9255cf08eb53");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69511ba7-8de2-47e5-841c-cd2502062bc6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69b3de9d-5807-4ad1-96c3-eca78a20e801");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6a396607-5ba3-4e44-a844-2e04132771ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6aa225bf-b30c-4d3a-814e-a5918ddb6f59");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6b918df1-0eba-4fb4-8af0-a4a6773e6b3f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6cf6137e-971f-49b8-989b-e53814f858d4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6ee4cff8-083c-468a-b9a3-7fa4a026d1c3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f2b144c-152f-49ad-b6f6-045ad98feeb5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "704a7ba7-7611-4bf9-a3a0-5a99c65a72e6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "711fda26-d4aa-4c10-8058-fa775cde39af");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7460a2e3-e570-467f-bab7-ad77eac994bd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "74e629a1-898e-47de-809b-6767d9b958c9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "763abbe1-ec25-4e61-887f-30855c051ba3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "76e03824-5af4-4569-9414-e0fcadb13f6e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77161984-0b89-4241-bae3-5820f98adfc2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "772aed2b-4279-4929-8718-561b10912c88");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77a6c6c3-9bb9-48a0-b788-cab6d8de1a7a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77d8590d-c229-4068-93f7-baff825d11e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7b9d6282-03f1-4203-955c-c09c54528b58");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7cc578ac-fe58-4fc9-906b-a433e4f1152a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7ea1f017-64cf-48e1-a4e3-85ba8ba18428");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7fd91b33-614f-4d5d-9e4b-17ae3d5b8050");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "814143b2-d175-471a-859e-4ecddb2c4a38");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81499a16-ce2b-4af7-8c5f-3808f58a0e01");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81b3ac1e-8987-47f1-80c3-da64b94fe1e9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "81f4660e-a6b5-4707-a64a-0e59806a3929");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "82dee2b4-cc26-45f1-b20d-43c170eea9be");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8360acf9-e04a-43a3-bdb0-791c4ee85ad5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "838015d3-fcc0-43c8-ad6e-c4dc4c39cb6c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "862b169a-1797-4e8e-9499-75a2ebe70ff2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8677752f-b55e-4242-90b6-c7304c630a48");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86845b55-c725-40f3-8740-83aaea9967a8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86a65c39-8834-4a09-b197-b0b655f8359c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "87562927-b1c9-4e87-bbb8-26d8a237a296");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "87c7291a-ab62-43d0-ba73-6f8f3cbde9d0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "893e5443-9f99-470f-ab55-c2fe4c15a91f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8c8b03a5-a3c6-4291-a714-5a66343e09df");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "90af96d6-ba45-48a4-a703-801c92048156");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "90c4d5eb-9457-4ae4-9987-7b487a6b3416");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91d0103f-3161-4dae-8b79-fb94aa5f872a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9302fbf9-3ae8-41ff-a441-0d597347a433");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9336d43a-a6e5-444f-bf93-3d8b5b2599fc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "94bd351d-6bcc-4dc8-8b3d-edaa298ac010");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "96baf646-673b-4ab5-bf32-d0fb41608ca1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "97b906db-0d1c-41ea-a21e-884887ba3a81");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9aaad621-6c2f-43d3-9e15-6d42b6c544c9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9baee5e3-a3a2-40c0-8027-b3fe5a21dfa3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9dc8d711-51d4-4185-9028-2920cb1810d2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a0b178f8-0ee2-479d-861e-d3afbcc19bbe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a1733588-ad88-420a-94c6-6f8b748a12cd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a48bb60b-7094-4271-9bab-adc179e237b3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a6822729-dad5-4cfc-a391-6d23d7b3d9f9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a7f6f6dd-57fc-4743-bd16-7644cac6bf9f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a8802bac-216c-45c7-a2d7-ebcb6f3e1d59");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ab96bf04-30b2-4bfe-aed1-d0ecc6430264");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ac9bf59c-c275-4548-a0f2-6ad973dae402");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "adf1c7f9-8e50-4753-b49b-9ff7e41c92d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ae05444b-5201-44e6-bf08-b8c45e900a6c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aee08430-96f3-4ff6-b9ee-40360096b176");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "affce813-76e0-400b-bf61-0b368d75c18f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "affdf0f7-b625-460d-a829-8d23cd6f22f2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b03a71d2-8a66-4454-a967-befcf26db770");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b16ee9cc-18e6-4d7c-b2a3-1b6af629f104");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b384a5ad-9e17-4866-a386-9ed900e93adf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b38cf606-1766-4706-b6aa-4e824e8ab989");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b3f69e0e-61f0-4dd5-b73f-bcbc82d9cff9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b3ff8cb7-5266-44fb-b4be-1ff416d4d4c1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b58e23b1-c2ad-4eaf-9630-0536f7870a33");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8f62ed3-b2dd-446c-bbb1-847717f6c323");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b92844c0-2416-432d-aa0a-a3223b2f0488");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b99c46a0-13e3-4ca2-ba1e-ac9b73ef0ef5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "baa879a2-c12b-4f96-af0e-5104461d14c4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bab7f3b3-f222-4e09-bcf3-5764dcba0fb5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bbc5e54e-999f-4ecf-8429-837a7e0b2f12");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bc1a14ee-6b1f-44ff-9d26-1b0195023b2a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "be3c0131-0833-4606-bcb4-bde89ca52f87");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c0c714ad-3397-42e8-9ec3-4861ea643c21");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c1c1f30c-e3fa-4004-b4f1-54ee88aab81d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c1c2e742-539b-48ea-bba9-8251e1d29c02");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c2da624a-1efd-434f-b316-47bc411e15c1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c3d616b9-9284-4c3e-b203-eda305660bc5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c3f7e33e-9c98-4bdf-8832-fe2048bc5ff2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c4019848-1786-4b82-8df2-843b3b0eb50e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6c4afae-9444-4a95-b71d-c53732558585");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "caa99c02-3b6e-4674-9d36-19bdc4d52580");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cadbb66e-e9e2-4922-9bfd-f1cc17b71aaf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cc7e00fe-cad0-4d34-8240-132bee900f1d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd489e5c-bfc1-4e1c-802b-6bb32a9eba67");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd4d1a6f-e5c9-404b-9211-49d8bc80ca7a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ce53687b-40f8-4afe-8e17-5e5c620fef2c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ceacb3c9-eb85-4582-8262-ccfcca6a5d47");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d243e00a-666d-41b6-92a0-cc0165a0385b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d298b6d4-3441-47d0-9cbf-1d790600c39e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3f23e0e-2d1f-4ce9-ab1f-2eedb35110ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d42b7419-2613-4b0b-8827-15d787fd780c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d4745d8a-f68b-4a92-a901-f3ed2d20dcfa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d606bc67-cc0b-44c4-b9e0-24e284ad4a4c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6be389e-2df7-45d0-a3a2-fa9839edf708");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6d4c40c-2bb2-48fe-ad8d-48d3d281d6a4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6e8a96f-3bdc-4988-bb38-1e32baac9919");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d7e994d4-1ede-4cde-8992-adabbede9755");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d7f6f559-b462-484c-a1b6-0c27eb6e0c49");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d8013c32-4b90-4506-a3e3-8cd46d9905d8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "da13ba52-29cc-49af-84aa-24ac782195ca");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dbe94983-02e6-4590-98d2-e6de3204e175");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc849313-5dd4-4942-9ae7-8086906abe4e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ddb6b011-1a4e-4d57-a93d-14a8d6cff9d6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ddde73be-5647-48a8-b26b-299a08f8674e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "de63ddb4-6ffa-47d0-bd6f-d4f7d84fde82");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "deb2d5a6-f39f-4258-97f1-317de1e84d5d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "df879dcc-72e5-4c08-be0b-419154f3ccdb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e0e53925-2471-431d-b120-9946b0c387e8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e22ccc00-96c0-4c4b-a049-2bdcbc9c45bf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e271612f-8bab-4ac0-9362-c46f6871a5e5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e3849814-64f0-47b6-8d7e-f825c9434ef7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e3af3e8e-c0f3-48cd-b653-877743089f7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e60ba730-f850-4d12-aa0a-6021a553ff83");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e79079e1-e8ba-460a-84b0-16c7476a87b3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7fe6e95-41a2-4eaa-9db7-04e945e35eb5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e8434f5b-93ad-46ef-bc0e-bc811cc9b03c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e8d97378-4224-4234-a669-49a51b8307ee");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e98f042e-b67e-4422-9342-e5349cb89b69");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea05bd44-20eb-4210-bf10-bc8b35d497fc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea77a920-2a76-453f-8113-b0dc04b9504b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea97c1f0-1970-4fd7-a5d4-7433afbe82ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb74a597-90c8-4e0a-83cd-224488f64f84");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed0d5e78-22c8-450e-bbdb-dcd3931c029e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ee20a4c0-9879-4643-a4d1-daadf5c3b157");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef1368be-00ea-41af-aab2-fdd7b8017786");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efc3d543-dca1-4c80-b4e2-451b534b2bc3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efe1611d-a016-45f5-8f33-7778815f7c03");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efe57f4f-3047-40e7-a918-ee026cc33d03");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f00adce5-a9e6-44d7-98b0-152761b5b366");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f15858ee-1763-4b26-bb3c-82ae6b61eac5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f22a51a1-cb12-4580-b00d-b27cff7dfd5b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f307483d-89af-43f7-9c07-4e9cc8abcd5a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f490a487-8e76-4dbb-9e8b-12f9b66f01f4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f584cff5-f1d0-40f7-9b31-fac90ee79877");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f5c5ff2d-7260-421f-b842-91103227720c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f620a4fe-8602-4e1f-886b-b041a54f2a80");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f673184c-8fff-45e4-8a25-4bf39529ddf8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f6886447-efb8-4e3c-a8b8-3866f1bcb4fb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f835f632-d1dc-4a3b-9aba-e09ffe7078e0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f8a821cc-1ea9-41fa-81d4-d58ec35df947");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f95c8bd9-9650-4009-be80-58f16892f19b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f9b90846-a2c7-42d3-9f92-03fa9c45c4ab");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb148cb9-b9e9-4a39-8c99-50f1bcbdcd8a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb3f1e4f-8007-42ed-91bc-fa22a185881a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fbfbe31e-7248-4c81-897c-28b32b7e8bc1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc3110d6-a1c8-4d8d-a3d6-7c8edbe46861");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fcf58329-38f4-4f41-b20e-4ebbbdca17e1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fddc360d-162c-45bf-86aa-b17a234eca99");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fe661d90-223a-4f13-a7a3-589be4e5d6c1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff3f1142-f3bd-4ee2-a1d6-7e808d844fef");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "d53dc60d-2e5b-4c64-9e2c-b6a795595cd1");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "2ab2b87c-6257-46e3-9425-115c6febb7e0");

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
