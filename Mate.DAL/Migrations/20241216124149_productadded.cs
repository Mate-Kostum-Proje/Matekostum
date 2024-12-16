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
                    { "02b4f54d-51a8-4d6f-8589-7f04fcd73a80", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5209), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "0ed997c2-2bcc-4f09-880d-90ba19188d1e", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5116), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "1728ff28-38b1-486f-b454-f96d7594d15f", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5172), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "3e3758ff-4a74-4dd1-a5ee-cb44508c44e1", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5225), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "43ce576b-45ce-42ed-afb1-9bab3abc8325", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5166), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "4a1d7131-f55d-4255-bf7f-a23c8427fb92", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5185), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "8d063703-a95d-467e-8d0f-3244533bb247", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5221), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "95e202b4-f485-449f-8768-2f8e10fb0cd1", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5213), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "a4ad6882-7836-4f77-8b45-2fc9d5ffd938", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5176), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" },
                    { "ac811e14-09ce-4550-a46d-6a20d7207452", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5218), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" },
                    { "dfbb44f0-0f26-4a20-90cf-fa6c154396a5", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5180), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "e570cd2c-1b03-4dcf-af58-aea4c8b88814", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(5196), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "02e0aabd-ad4e-4260-961a-81106ad6c79e", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7227), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "12b8abfa-5d09-4b1f-a430-a623f967b57d", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7220), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "22b29aa9-c5a6-4ccc-a6b2-6ae24c3cfbf6", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7167), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "2810a569-81e9-453c-8bec-d6dcea85e804", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7136), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "28e2f2c4-b6e9-428d-9f56-063d99b4fdb3", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7245), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "2d24b0be-5dbd-4032-87b5-b5fe31aac987", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7249), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "34503727-7ba2-448c-a5ec-2091092c6607", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7232), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "370d9848-a831-40f8-82a0-4008af96bcdb", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7217), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "41c7d694-d690-468e-8a75-2abb4a21e661", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7181), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "48d8683e-860b-4afe-b2c3-487a6020c400", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7209), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "4dcefb01-c4de-4e13-9458-57c611fbd586", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7256), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "5d6f79b1-14c2-4955-9115-c0c7f223c878", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7203), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "790f751b-cf55-438d-b7e8-fd8a8eb5a2bd", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7153), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" },
                    { "7d6258f1-cd25-414a-ab67-d44dd0c62947", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7253), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "9301747d-1c76-4ad6-946e-2d78cfc99ad5", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7213), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "992ac0db-f945-4411-9e4b-3a8a500e606f", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7171), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "9968c814-de50-4022-b21d-09ccb293b4e3", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7237), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "99af2d8a-f5f0-44bb-a151-756afe05769d", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7224), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "9a96cfab-dd4d-4865-a94e-26c9a8df7045", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7185), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "b4d34423-4ae3-4f69-9054-17651111a21f", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7193), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "c504f4d6-da94-47e7-85de-89ab7d043f47", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7242), "/databaseimg/galeri/galeriIMG-8454.jpg" },
                    { "d6e7ba4c-21c4-4d98-8791-29b561459db1", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7158), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "e016c3f7-3afe-4920-9d19-83b5c3bb5119", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7189), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "ee05529d-ef5e-4c43-ace4-851c0f11ceb3", new DateTime(2024, 12, 16, 15, 41, 48, 946, DateTimeKind.Local).AddTicks(7177), "/databaseimg/galeri/galeriIMG_1958.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 955, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 955, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 955, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 955, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 955, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 955, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "06c264e5-1bf0-4646-ac80-21414a32e776", new DateTime(2024, 12, 16, 15, 41, 48, 957, DateTimeKind.Local).AddTicks(1779), "Siparişiniz Hazırlanıyor" },
                    { "515d9188-a275-4f1a-b0d8-69db4d454dba", new DateTime(2024, 12, 16, 15, 41, 48, 957, DateTimeKind.Local).AddTicks(1762), "Siparişiniz Alındı" },
                    { "60b35ebf-6689-4654-87e1-9d623907e143", new DateTime(2024, 12, 16, 15, 41, 48, 957, DateTimeKind.Local).AddTicks(1788), "Siparişiniz Tamamlandı" },
                    { "7768d254-03c7-44d8-b543-3067169c6115", new DateTime(2024, 12, 16, 15, 41, 48, 957, DateTimeKind.Local).AddTicks(1783), "Siparişiniz Kargoya verildi" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 957, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 957, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 957, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 957, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 957, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "00ca1eea-147a-48c1-850b-0774f95ff363", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(899), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI", null, null, 1500, null },
                    { "00d761da-1003-4f9c-8fc1-ddadbd0f9428", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(309), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "01c6fe07-0c0a-4456-a148-5ef67f43abcf", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(556), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 1500, null },
                    { "01f4addb-4a61-4c9c-9557-f393b4b02451", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(427), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 1500, null },
                    { "0b2f0db5-66e5-4385-8091-a613b323415e", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(597), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 1500, null },
                    { "0f501032-abb6-4398-bcbb-a346e7999b42", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(975), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ ÜSKÜP-N2", null, null, 1500, null },
                    { "109768ec-125d-40f6-a6ef-a690f4ba0801", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(367), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 1500, null },
                    { "142eced5-c6f7-4a32-bb5e-ba34e35e5a4b", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(616), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 0, 1500 },
                    { "16ee9d77-4b38-472b-9397-935f8f698c2b", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(601), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 1500, null },
                    { "1afea2cc-e18b-4553-9894-cfc113fe78b4", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(578), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 1500, null },
                    { "1b4bbc80-e800-4b51-b4f0-5e093cb1b8b0", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(764), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 1500, null },
                    { "1bdb2ee8-8310-4c69-9e9d-3a09a0e81565", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(675), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "1c365be7-789f-4080-a7d1-48fc1fd90b60", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(814), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "1cc71d2b-2bb5-40c7-8779-f27d696f33fd", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(871), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 1500, null },
                    { "208585e6-a46b-4ad7-ac5e-aa7ce33ff5d8", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(989), null, null, true, false, "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", "4dans", "ÇİFTETELLİ BEYAZ", null, "ÇİFTETELLİ", 1500, null },
                    { "20b61ac1-5193-49ad-84c6-c57a974943b7", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(716), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 1500, null },
                    { "219c674a-aedf-463e-b58f-9c9b6122af89", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(314), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 1500, null },
                    { "233c027f-4810-4b4a-ae65-375543d0abb2", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(934), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ GRİ-SİYAH", null, null, 1500, null },
                    { "238f4937-288e-411c-99de-db9c1859a494", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(383), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 1500, null },
                    { "23a28ff9-53a0-408d-9188-78f6183eb55d", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(819), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "26fa8020-088b-4996-aba5-93d8cbff6741", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(775), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "27e20909-18ec-40c9-9dea-473a316fb504", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(340), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "28a8d522-da87-4c96-90d3-14678e4137b6", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(361), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "2946bf2e-b197-435c-9ba2-9de82dd72aa9", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(573), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 1500, null },
                    { "2a871f68-6b8a-4176-9b06-31b23074a5bb", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(679), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "2fa0b9d6-7e42-4a80-9a25-3836a85fbb8c", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(712), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 1500, null },
                    { "300d935c-1c06-4fda-91f3-88f0eeab0705", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(533), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 1500, null },
                    { "300e4f84-ddd3-400b-b554-f7e19237171b", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(507), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 1500, null },
                    { "312089a9-a367-41ab-adb3-27e610d75c1a", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(930), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ BORDO", null, null, 1500, null },
                    { "33f007de-2109-4e89-8f25-7e1cf354cd12", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(371), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "36e2c57d-e258-4796-aeb8-4f7bdbf9274f", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(924), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN YEŞİL", null, null, 1500, null },
                    { "3a38d7b9-9048-4c9b-9459-98ac5ffad5f9", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(755), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 1500, null },
                    { "3b632c6b-f0f0-4b13-ab33-c7ccfa1ebf32", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(516), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 1500, null },
                    { "3ea52498-7af4-4fac-899d-d07f50214a6b", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(824), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "41d2aefc-07d1-48c1-959e-74614a27bab3", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(334), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 1500, null },
                    { "43115192-09b7-4c16-a484-eace86e49533", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(587), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 1500, null },
                    { "451443a0-e122-4dd3-ae92-6b7db3ccd2f1", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(511), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 1500, null },
                    { "4551f594-396c-4830-880f-14deafef7e1e", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(406), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 1500, null },
                    { "45727b54-5d46-4288-8d2d-d0e4354a11ed", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(387), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 1500, null },
                    { "459c8477-02bf-45f7-a39e-4a94c832a599", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(496), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 1500, null },
                    { "46e6d244-5d2f-4f75-ad84-fb1ed51dc25f", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(916), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MÜRDÜM", null, null, 1500, null },
                    { "48c3323b-38f0-48ea-832a-287c9ba5ba6a", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(605), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 1500, null },
                    { "4ae3eef5-482b-4728-ad9b-140142025460", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(583), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 1500, null },
                    { "4b891be5-f34c-4986-8d95-555c3ecbb5ec", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(592), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 1500, null },
                    { "508cf277-3399-48b9-8c68-883415100757", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(908), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N3", null, null, 1500, null },
                    { "50bcf2de-d045-4855-9808-13ceeeeb5be3", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(444), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 1500, null },
                    { "52da7b16-e953-451b-8e9d-a0bd11eaa051", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(551), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 1500, null },
                    { "577af770-787e-4125-8158-79f916a53fab", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(642), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 0, 1500 },
                    { "5c377542-24bd-438a-81b7-64d0303f2e06", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(634), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 0, 1500 },
                    { "5cfb1c83-d665-4d60-ba0a-ae21b57250b5", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(833), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "5d61aefb-abce-4522-bc19-833b395aba8f", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(462), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 1500, null },
                    { "605d89f7-f68f-43f6-b648-61de13f330ce", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(889), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MUĞLA", "EGE", "ZEYBEK", 1500, null },
                    { "60618c28-afbd-446b-be2c-909c658d483f", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(396), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 1500, null },
                    { "61ad9140-a2dc-4084-bdff-65b85d7b534d", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(621), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 0, 1500 },
                    { "640e4837-9a61-4252-88d8-26982caeb8c6", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(651), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 0, 1500 },
                    { "677786c8-f911-4e13-a840-8915eb2d287a", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(721), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 1500, null },
                    { "68d4a8e8-68b7-4f94-acf4-7a2e195f2d33", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(422), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 1500, null },
                    { "6a1ae9f6-b8d1-4938-b42a-a51947febafc", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(726), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "6bcf8a23-465e-4cb0-b4e6-6c98fe1690bc", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(895), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN BORDO", null, null, 1500, null },
                    { "6c7f6821-06c3-4848-a73d-37392bea1323", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(789), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 1500, null },
                    { "6dece0a9-b102-4c97-902d-5cf6247c8e50", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(401), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 1500, null },
                    { "7112039a-9c8f-4613-ac9e-ad1004d4950a", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(455), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "715492ef-e0ed-4221-b672-ed9cea308242", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(1030), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI K", null, null, 1500, null },
                    { "7236cf81-13f6-4064-90c3-faeed98888bf", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(665), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 0, 1500 },
                    { "75ffc15d-9526-4c8d-8bd2-e33dd19f4f25", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(450), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 1500, null },
                    { "76c5ec78-10a2-46bc-a468-ee405d60e0d9", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(866), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "7f22a151-90e0-4787-8ef2-bb71822a9356", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(657), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 0, 1500 },
                    { "802b9794-6c12-494b-98bd-49940f8de1f0", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(345), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "82a59df5-3bcc-49c6-9668-45c592c8a775", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(971), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE-N2", null, null, 1500, null },
                    { "84962b89-168a-4988-9888-52effabc3895", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(646), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 0, 1500 },
                    { "872a4684-67f8-4504-a409-7fa929d7a5d4", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(698), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "87b49d87-ac75-4b72-a114-68807ccea6ac", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(466), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 1500, null },
                    { "8b9814e2-2b8b-422a-b58e-208becf2ef1e", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(850), null, true, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 1500, null },
                    { "8f4250e2-0ddb-4d25-a7c7-efe6b6237750", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(502), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 1500, null },
                    { "90111fdc-f67b-461e-a0fa-e324a4f8a59f", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(943), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI-N2", null, null, 1500, null },
                    { "9013f9dc-3dcc-4244-ae3d-cc8e14bc1cb2", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(560), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 1500, null },
                    { "91894168-ad44-465b-861b-d60a24059a7d", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(947), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT", null, null, 1500, null },
                    { "9344f98d-88ae-43bc-830c-ee0a110304f9", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(472), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "93a4df6a-31c1-41f6-bf5c-f1cdf25afde9", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(884), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK PEMBE", "EGE", "ZEYBEK", 1500, null },
                    { "96ee4969-f6b2-4630-aaa6-0fea09f92045", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(939), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI", null, null, 1500, null },
                    { "97151132-df70-426f-95ce-f079942a547e", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(546), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 1500, null },
                    { "9799795e-9b4c-471d-a93c-68e0755a2fea", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(524), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 1500, null },
                    { "97e77dfe-0760-4940-b93e-0665fed9d6f0", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(610), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 0, 1500 },
                    { "99f5a57f-e21c-454b-8328-fe057c935bad", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(431), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "9a4270d2-56b3-46a1-9ba4-95067dfe1619", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(539), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 1500, null },
                    { "9c79aa18-14be-44f3-bbfd-3cae84988a96", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(1002), null, null, true, false, "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, "ROMAN", 1500, null },
                    { "9c923019-543b-40f2-bcac-3b0322733f6f", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(350), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 1500, null },
                    { "9cd24526-296e-4ce6-b12b-34f2ea04bea1", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(482), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 1500, null },
                    { "a023b116-0504-497e-a5a7-b0613bd74b83", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(733), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "a074dbfe-1ee6-4db9-b380-4203a530c5a8", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(857), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 1500, null },
                    { "a21c3d02-a8ae-4b3c-8dfb-7d5a997af2e4", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(290), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "a21d7570-3776-4325-8b4e-4a967bae43a2", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(1042), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ K", null, null, 1500, null },
                    { "a23df146-1277-489e-be29-ec0521b51e64", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(993), null, null, true, false, "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", "4dans", "LİRİK", null, null, 1500, null },
                    { "a25594f8-9be1-4e19-9cb9-edc4a66f26b7", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(487), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 1500, null },
                    { "a6a6b22f-1f9b-4213-a915-401f433e52e1", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(1021), null, null, true, false, "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN YEŞİL", null, "ROMAN", 1500, null },
                    { "a860522f-0a9c-4a90-b2b3-e27cd5660e61", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(629), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 0, 1500 },
                    { "aa66e304-48b2-409c-8d77-97cbeb8489af", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(1016), null, null, true, false, "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN TURUNCU", null, "ROMAN", 1500, null },
                    { "ace06115-2db4-4607-ae2d-b5b436de54a9", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(769), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 1500, null },
                    { "ae0efa92-a737-4d6d-87d4-a3520643d160", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(960), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N3", null, null, 1500, null },
                    { "af6f519e-fc79-404a-b89e-976649ef715d", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(955), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N2", null, null, 1500, null },
                    { "af9bd98f-cf7c-4f92-b912-564f70707f72", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(529), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 1500, null },
                    { "b2089857-ac03-4fda-8156-e3b8feb37904", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(412), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 1500, null },
                    { "b2c26b57-9585-481a-a127-7691791e7819", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(477), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 1500, null },
                    { "b6a0ed1e-8a94-423e-aee3-38352c4f8655", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(803), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 1500, null },
                    { "b7a67f5c-bbfe-420a-9d3a-2997c9c5cb90", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(708), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "bbaebf55-a3b2-4f6a-a913-f46d2e8a3626", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(492), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 1500, null },
                    { "bd78ef13-f590-4d43-b918-ef5ed7a6a892", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(661), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 0, 1500 },
                    { "bef9177a-9f61-4b2a-9460-10fda3dce08c", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(979), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ YEŞİL", null, null, 1500, null },
                    { "bfafedfa-78f7-4f29-af80-82d4f5a795dd", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(1026), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI E", null, null, 1500, null },
                    { "c09a6a39-5624-439e-8b8b-a14d29bb873d", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(750), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 1500, null },
                    { "c0b14705-59bc-4229-af38-02d7c40d00a7", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(564), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 1500, null },
                    { "c3169977-39d5-4776-b28c-20824d256b40", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(625), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 0, 1500 },
                    { "c38b3b09-15b1-4ece-b21e-909a7f28b9de", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(828), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "c4c3d4fa-2382-428a-9f56-f36bfca1388f", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(837), null, true, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "c4de2b51-99eb-496d-9c87-0166875f7693", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(520), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 1500, null },
                    { "c67fb42e-bf3f-4bef-b4b0-2217475b4d15", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(319), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 1500, null },
                    { "c703bd0a-ef36-4ead-bd8e-d6d0e4417ebf", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(903), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N2", null, null, 1500, null },
                    { "c70676b4-0431-4963-84fa-51695f0522bd", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(912), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MOR", null, null, 1500, null },
                    { "c920e281-6931-41d6-bfc9-f55786016e7d", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(439), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 1500, null },
                    { "cc7180d2-8915-4d8d-9d78-0134a98f9c10", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(418), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 1500, null },
                    { "ccf64152-23f8-4bd1-8924-589ab7d0251e", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(738), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "cda9effa-2605-4bab-b0ff-537deb936ab4", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(355), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 1500, null },
                    { "cdea02fb-1b8f-4a12-9f44-430480d41865", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(798), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 1500, null },
                    { "d07b09fa-03f9-4d7a-978b-4167f590f507", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(920), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN PEMBE", null, null, 1500, null },
                    { "d3e6069d-593d-445c-b75a-180f1e554415", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(861), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 1500, null },
                    { "d5cbfe0c-df2e-4f5b-b074-aecb9c445a44", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(760), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 1500, null },
                    { "daa182c6-f29a-4a43-b8ed-38be12b084cf", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(688), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 1500, null },
                    { "dabcb3a1-6b27-4e00-bb63-91a7d44c3891", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(808), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 1500, null },
                    { "dd0ff4a4-3de3-4f38-867b-c48029a4cfa7", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(793), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 1500, null },
                    { "df21364f-4d88-40de-be5b-0859e970e98b", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(746), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "e24b85a5-0fbb-4c20-b1f3-f47c617f1244", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(1012), null, null, true, false, "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN RENKLİ ETEK", null, "ROMAN", 1500, null },
                    { "e4cda55e-43e5-47ea-8099-1e2d12860c37", 0, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(964), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE", null, null, 1500, null },
                    { "e5245069-8b7c-430a-a85d-2da6ebd12fcf", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(784), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 1500, null },
                    { "e5af43b7-5178-431e-8201-1e01469624e4", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(880), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "e62b9dd0-8107-4976-954d-bfff95007666", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(875), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 1500, null },
                    { "e770e37b-c411-48ca-8e6a-17fedec106d8", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(780), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "ee28ad72-a385-484b-a220-8e162db91611", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(984), null, null, true, false, "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", "4dans", "AŞUK MAŞUK", null, null, 1500, null },
                    { "f0db7ae6-a941-47c0-ae12-ba1e710f4e96", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(703), null, true, true, false, "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "f30f71ca-ec8a-404d-866b-dc2d20055e28", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(378), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "f33d39ab-36bf-4b65-a8c5-18580f4966b4", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(1037), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ E", null, null, 1500, null },
                    { "f36690a7-f63e-4cf1-bddf-492650c6483f", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(683), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpG", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 1500, null },
                    { "f57e08ad-287c-4ece-829e-915cca5fda4b", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(568), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 1500, null },
                    { "f86a940b-156c-4401-bb0b-dd4e078ccae2", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(392), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 1500, null },
                    { "f9020a81-2423-4fde-bfab-81bb8922c29a", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(694), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 1500, null },
                    { "fbe452c4-55d5-4501-904e-543de8f93654", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(1007), null, null, true, false, "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN PEMBE", null, "ROMAN", 1500, null },
                    { "fcd7dac6-185c-495b-9292-55eefe9fda4d", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(997), null, null, true, false, "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, "ROMAN", 1500, null },
                    { "fdf626e8-56c6-433d-88ce-4ce5609523f2", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(842), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 1500, null },
                    { "fe3f45de-c17e-411f-bc04-5b26dad31061", 10, new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(670), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 15, 41, 48, 958, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "e80d2c2c-f1a7-4b7b-97e1-103cac5e088d", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 16, 15, 41, 48, 959, DateTimeKind.Local).AddTicks(2474), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreatedAt", "SizeNumber" },
                values: new object[,]
                {
                    { "3fbf18e2-5ca5-4678-ae0e-af1f357de919", new DateTime(2024, 12, 16, 15, 41, 48, 959, DateTimeKind.Local).AddTicks(4467), 14 },
                    { "4878f1dc-5310-4fb5-bb93-ecc8efbff27e", new DateTime(2024, 12, 16, 15, 41, 48, 959, DateTimeKind.Local).AddTicks(4463), 12 },
                    { "586cda70-464b-489f-9ed9-fc27b7247238", new DateTime(2024, 12, 16, 15, 41, 48, 959, DateTimeKind.Local).AddTicks(4457), 10 },
                    { "67a7d737-4ae5-480a-8ced-d66627c63e5a", new DateTime(2024, 12, 16, 15, 41, 48, 959, DateTimeKind.Local).AddTicks(4441), 8 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "f364550c-0416-49dd-9fa9-637750ec94e2", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                keyValue: "02e0aabd-ad4e-4260-961a-81106ad6c79e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "12b8abfa-5d09-4b1f-a430-a623f967b57d");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "22b29aa9-c5a6-4ccc-a6b2-6ae24c3cfbf6");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "2810a569-81e9-453c-8bec-d6dcea85e804");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "28e2f2c4-b6e9-428d-9f56-063d99b4fdb3");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "2d24b0be-5dbd-4032-87b5-b5fe31aac987");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "34503727-7ba2-448c-a5ec-2091092c6607");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "370d9848-a831-40f8-82a0-4008af96bcdb");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "41c7d694-d690-468e-8a75-2abb4a21e661");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "48d8683e-860b-4afe-b2c3-487a6020c400");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "4dcefb01-c4de-4e13-9458-57c611fbd586");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "5d6f79b1-14c2-4955-9115-c0c7f223c878");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "790f751b-cf55-438d-b7e8-fd8a8eb5a2bd");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "7d6258f1-cd25-414a-ab67-d44dd0c62947");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "9301747d-1c76-4ad6-946e-2d78cfc99ad5");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "992ac0db-f945-4411-9e4b-3a8a500e606f");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "9968c814-de50-4022-b21d-09ccb293b4e3");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "99af2d8a-f5f0-44bb-a151-756afe05769d");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "9a96cfab-dd4d-4865-a94e-26c9a8df7045");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "b4d34423-4ae3-4f69-9054-17651111a21f");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "c504f4d6-da94-47e7-85de-89ab7d043f47");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d6e7ba4c-21c4-4d98-8791-29b561459db1");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "e016c3f7-3afe-4920-9d19-83b5c3bb5119");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "ee05529d-ef5e-4c43-ace4-851c0f11ceb3");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "06c264e5-1bf0-4646-ac80-21414a32e776");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "515d9188-a275-4f1a-b0d8-69db4d454dba");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "60b35ebf-6689-4654-87e1-9d623907e143");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "7768d254-03c7-44d8-b543-3067169c6115");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00ca1eea-147a-48c1-850b-0774f95ff363");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00d761da-1003-4f9c-8fc1-ddadbd0f9428");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01c6fe07-0c0a-4456-a148-5ef67f43abcf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "01f4addb-4a61-4c9c-9557-f393b4b02451");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0b2f0db5-66e5-4385-8091-a613b323415e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0f501032-abb6-4398-bcbb-a346e7999b42");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "109768ec-125d-40f6-a6ef-a690f4ba0801");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "142eced5-c6f7-4a32-bb5e-ba34e35e5a4b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16ee9d77-4b38-472b-9397-935f8f698c2b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1afea2cc-e18b-4553-9894-cfc113fe78b4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1b4bbc80-e800-4b51-b4f0-5e093cb1b8b0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1bdb2ee8-8310-4c69-9e9d-3a09a0e81565");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c365be7-789f-4080-a7d1-48fc1fd90b60");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1cc71d2b-2bb5-40c7-8779-f27d696f33fd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "208585e6-a46b-4ad7-ac5e-aa7ce33ff5d8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "20b61ac1-5193-49ad-84c6-c57a974943b7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "219c674a-aedf-463e-b58f-9c9b6122af89");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "233c027f-4810-4b4a-ae65-375543d0abb2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "238f4937-288e-411c-99de-db9c1859a494");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23a28ff9-53a0-408d-9188-78f6183eb55d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "26fa8020-088b-4996-aba5-93d8cbff6741");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "27e20909-18ec-40c9-9dea-473a316fb504");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "28a8d522-da87-4c96-90d3-14678e4137b6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2946bf2e-b197-435c-9ba2-9de82dd72aa9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a871f68-6b8a-4176-9b06-31b23074a5bb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2fa0b9d6-7e42-4a80-9a25-3836a85fbb8c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "300d935c-1c06-4fda-91f3-88f0eeab0705");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "300e4f84-ddd3-400b-b554-f7e19237171b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "312089a9-a367-41ab-adb3-27e610d75c1a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "33f007de-2109-4e89-8f25-7e1cf354cd12");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "36e2c57d-e258-4796-aeb8-4f7bdbf9274f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a38d7b9-9048-4c9b-9459-98ac5ffad5f9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3b632c6b-f0f0-4b13-ab33-c7ccfa1ebf32");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3ea52498-7af4-4fac-899d-d07f50214a6b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41d2aefc-07d1-48c1-959e-74614a27bab3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43115192-09b7-4c16-a484-eace86e49533");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "451443a0-e122-4dd3-ae92-6b7db3ccd2f1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4551f594-396c-4830-880f-14deafef7e1e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "45727b54-5d46-4288-8d2d-d0e4354a11ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "459c8477-02bf-45f7-a39e-4a94c832a599");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "46e6d244-5d2f-4f75-ad84-fb1ed51dc25f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "48c3323b-38f0-48ea-832a-287c9ba5ba6a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4ae3eef5-482b-4728-ad9b-140142025460");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b891be5-f34c-4986-8d95-555c3ecbb5ec");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "508cf277-3399-48b9-8c68-883415100757");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "50bcf2de-d045-4855-9808-13ceeeeb5be3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52da7b16-e953-451b-8e9d-a0bd11eaa051");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "577af770-787e-4125-8158-79f916a53fab");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5c377542-24bd-438a-81b7-64d0303f2e06");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cfb1c83-d665-4d60-ba0a-ae21b57250b5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5d61aefb-abce-4522-bc19-833b395aba8f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "605d89f7-f68f-43f6-b648-61de13f330ce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "60618c28-afbd-446b-be2c-909c658d483f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61ad9140-a2dc-4084-bdff-65b85d7b534d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "640e4837-9a61-4252-88d8-26982caeb8c6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "677786c8-f911-4e13-a840-8915eb2d287a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "68d4a8e8-68b7-4f94-acf4-7a2e195f2d33");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6a1ae9f6-b8d1-4938-b42a-a51947febafc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6bcf8a23-465e-4cb0-b4e6-6c98fe1690bc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c7f6821-06c3-4848-a73d-37392bea1323");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6dece0a9-b102-4c97-902d-5cf6247c8e50");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7112039a-9c8f-4613-ac9e-ad1004d4950a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "715492ef-e0ed-4221-b672-ed9cea308242");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7236cf81-13f6-4064-90c3-faeed98888bf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75ffc15d-9526-4c8d-8bd2-e33dd19f4f25");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "76c5ec78-10a2-46bc-a468-ee405d60e0d9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7f22a151-90e0-4787-8ef2-bb71822a9356");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "802b9794-6c12-494b-98bd-49940f8de1f0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "82a59df5-3bcc-49c6-9668-45c592c8a775");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "84962b89-168a-4988-9888-52effabc3895");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "872a4684-67f8-4504-a409-7fa929d7a5d4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "87b49d87-ac75-4b72-a114-68807ccea6ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8b9814e2-2b8b-422a-b58e-208becf2ef1e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f4250e2-0ddb-4d25-a7c7-efe6b6237750");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "90111fdc-f67b-461e-a0fa-e324a4f8a59f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9013f9dc-3dcc-4244-ae3d-cc8e14bc1cb2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91894168-ad44-465b-861b-d60a24059a7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9344f98d-88ae-43bc-830c-ee0a110304f9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93a4df6a-31c1-41f6-bf5c-f1cdf25afde9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "96ee4969-f6b2-4630-aaa6-0fea09f92045");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "97151132-df70-426f-95ce-f079942a547e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9799795e-9b4c-471d-a93c-68e0755a2fea");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "97e77dfe-0760-4940-b93e-0665fed9d6f0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "99f5a57f-e21c-454b-8328-fe057c935bad");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9a4270d2-56b3-46a1-9ba4-95067dfe1619");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c79aa18-14be-44f3-bbfd-3cae84988a96");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c923019-543b-40f2-bcac-3b0322733f6f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9cd24526-296e-4ce6-b12b-34f2ea04bea1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a023b116-0504-497e-a5a7-b0613bd74b83");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a074dbfe-1ee6-4db9-b380-4203a530c5a8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a21c3d02-a8ae-4b3c-8dfb-7d5a997af2e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a21d7570-3776-4325-8b4e-4a967bae43a2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a23df146-1277-489e-be29-ec0521b51e64");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a25594f8-9be1-4e19-9cb9-edc4a66f26b7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a6a6b22f-1f9b-4213-a915-401f433e52e1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a860522f-0a9c-4a90-b2b3-e27cd5660e61");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aa66e304-48b2-409c-8d77-97cbeb8489af");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ace06115-2db4-4607-ae2d-b5b436de54a9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ae0efa92-a737-4d6d-87d4-a3520643d160");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "af6f519e-fc79-404a-b89e-976649ef715d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "af9bd98f-cf7c-4f92-b912-564f70707f72");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2089857-ac03-4fda-8156-e3b8feb37904");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b2c26b57-9585-481a-a127-7691791e7819");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6a0ed1e-8a94-423e-aee3-38352c4f8655");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7a67f5c-bbfe-420a-9d3a-2997c9c5cb90");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bbaebf55-a3b2-4f6a-a913-f46d2e8a3626");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd78ef13-f590-4d43-b918-ef5ed7a6a892");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bef9177a-9f61-4b2a-9460-10fda3dce08c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bfafedfa-78f7-4f29-af80-82d4f5a795dd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c09a6a39-5624-439e-8b8b-a14d29bb873d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c0b14705-59bc-4229-af38-02d7c40d00a7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c3169977-39d5-4776-b28c-20824d256b40");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c38b3b09-15b1-4ece-b21e-909a7f28b9de");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c4c3d4fa-2382-428a-9f56-f36bfca1388f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c4de2b51-99eb-496d-9c87-0166875f7693");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c67fb42e-bf3f-4bef-b4b0-2217475b4d15");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c703bd0a-ef36-4ead-bd8e-d6d0e4417ebf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c70676b4-0431-4963-84fa-51695f0522bd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c920e281-6931-41d6-bfc9-f55786016e7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cc7180d2-8915-4d8d-9d78-0134a98f9c10");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ccf64152-23f8-4bd1-8924-589ab7d0251e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cda9effa-2605-4bab-b0ff-537deb936ab4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cdea02fb-1b8f-4a12-9f44-430480d41865");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d07b09fa-03f9-4d7a-978b-4167f590f507");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3e6069d-593d-445c-b75a-180f1e554415");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d5cbfe0c-df2e-4f5b-b074-aecb9c445a44");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "daa182c6-f29a-4a43-b8ed-38be12b084cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dabcb3a1-6b27-4e00-bb63-91a7d44c3891");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd0ff4a4-3de3-4f38-867b-c48029a4cfa7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "df21364f-4d88-40de-be5b-0859e970e98b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e24b85a5-0fbb-4c20-b1f3-f47c617f1244");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e4cda55e-43e5-47ea-8099-1e2d12860c37");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e5245069-8b7c-430a-a85d-2da6ebd12fcf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e5af43b7-5178-431e-8201-1e01469624e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e62b9dd0-8107-4976-954d-bfff95007666");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e770e37b-c411-48ca-8e6a-17fedec106d8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ee28ad72-a385-484b-a220-8e162db91611");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f0db7ae6-a941-47c0-ae12-ba1e710f4e96");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f30f71ca-ec8a-404d-866b-dc2d20055e28");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f33d39ab-36bf-4b65-a8c5-18580f4966b4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f36690a7-f63e-4cf1-bddf-492650c6483f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f57e08ad-287c-4ece-829e-915cca5fda4b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f86a940b-156c-4401-bb0b-dd4e078ccae2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f9020a81-2423-4fde-bfab-81bb8922c29a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fbe452c4-55d5-4501-904e-543de8f93654");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fcd7dac6-185c-495b-9292-55eefe9fda4d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fdf626e8-56c6-433d-88ce-4ce5609523f2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fe3f45de-c17e-411f-bc04-5b26dad31061");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "e80d2c2c-f1a7-4b7b-97e1-103cac5e088d");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "f364550c-0416-49dd-9fa9-637750ec94e2");

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
