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
                    { "3389f96d-00b3-4f49-9998-887e702948c4", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8466), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "33cb77d0-68d4-4dd1-83f6-d2b036abc745", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8437), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "501df84a-7e92-434f-b125-eb3d9b3c5ccf", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8452), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "720ebddb-8e24-4ad5-b2cf-1386a41dca16", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8447), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" },
                    { "830711e7-5a2b-4f1d-b546-4198b5fb2744", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8473), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "98f455c2-49ed-4261-a222-f40c4adcd3f5", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8462), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" },
                    { "9a3a26f6-8350-4375-bd96-76db5c118898", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8478), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" },
                    { "9ecdb538-ff91-4661-908e-1b64ac6ba986", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8392), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "c71f9c54-270e-43f8-8679-c1700c7e1da8", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8458), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "d0d3e19b-4844-493b-aa8d-feb321fe041a", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8482), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "dc81ec18-ba32-44c9-81b1-253efa6782a8", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8443), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" },
                    { "ea7b38cc-5a54-4a3f-8e26-af389378274f", new DateTime(2024, 12, 16, 7, 13, 19, 285, DateTimeKind.Local).AddTicks(8486), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "03b2eb19-627e-4053-87e1-5cfa4ba21760", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(328), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "1a17b882-dc61-46e1-a36f-180bf3d9c525", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(442), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "263560f6-e9a2-4eb2-8b75-cb0102ba3130", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(348), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "28100e4f-ba98-43cc-b7bf-46e2d1bbc4bf", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(368), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "28816814-8c49-4566-9de0-af156abc67c7", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(449), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "2d7dcb31-19e9-4dfc-8af7-623122304598", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(404), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "3087c3de-b5d1-4b8a-b234-e25493fcf029", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(376), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "43d49876-bf10-413b-b507-83a391cf4fea", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(453), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "444c8681-1d2f-406d-9954-6e5a1ee52419", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(413), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "4a26a61a-8bc6-4a46-8c60-79f0adb4204a", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(436), "/databaseimg/galeri/galeriIMG-8454.jpg" },
                    { "58f06a1f-28b4-42f6-8041-b88b5eeeb6a7", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(384), "/databaseimg/galeri/galeriIMG_1140.jpg" },
                    { "64654e6a-c43d-43d1-82f3-6a586d837c11", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(359), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "778ede5d-3393-4953-9f8f-74b66585c463", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(446), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "8386c546-1fae-4b52-868f-0e39233f05ce", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(394), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "8c5a916a-73f8-4c10-ad73-a68953e96dce", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(408), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "be5c0453-f43c-4717-91c6-e75d42834c0e", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(417), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "c33ed70c-0abc-489b-acdf-ff8b5d21c860", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(398), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "c471f9ee-1b2e-4490-8685-0fc1e55cd051", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(401), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "d4130f52-f778-4dfe-963a-7849ada223fe", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(389), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "ec6bfd04-7aef-450f-a1d4-6839afc39dbf", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(380), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "ec7610f9-6910-4563-be8d-6e286180bc6c", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(364), "/databaseimg/galeri/galeriIMG_1958.jpg" },
                    { "f4dd8f84-f3e9-4fdf-9f3f-5f8fb440772e", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(343), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" },
                    { "f5aaba68-f634-4cec-960b-157a8cfb3df8", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(352), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "f68d6952-3edb-4e59-83cb-e2ec8851dfcc", new DateTime(2024, 12, 16, 7, 13, 19, 286, DateTimeKind.Local).AddTicks(372), "/databaseimg/galeri/galeriIMG_1964.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 294, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 294, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 294, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 294, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 294, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 294, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "08e1644b-2c6e-42c2-8841-9f5c5fbc22eb", new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(1020), "Siparişiniz Hazırlanıyor" },
                    { "27f27997-30ed-4eed-840d-723b79b9e6ed", new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(1025), "Siparişiniz Kargoya verildi" },
                    { "55ce8a69-cf9b-4361-a7a6-d36f29dd786d", new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(1029), "Siparişiniz Tamamlandı" },
                    { "6c9933f0-b7ad-4c71-b093-8cdb0975d592", new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(1003), "Siparişiniz Alındı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "043d246d-95bd-45d8-98f9-b8dbc776b425", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9860), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN BORDO", null, null, 1500, null },
                    { "097911f7-00b3-4dba-9589-c37552b6ef71", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9966), null, null, true, false, "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, "ROMAN", 1500, null },
                    { "0b38a9b0-6a8b-49f9-9b91-4f1b219af5df", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9755), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 1500, null },
                    { "0be3718d-0105-4cd6-91eb-c20711e744b5", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9782), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "0e1926ce-ffa4-4a4e-9ced-271e271cbce3", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9408), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 1500, null },
                    { "10e3dee7-2b07-4594-815f-d2fffbae1d9c", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9760), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 1500, null },
                    { "13b10f43-1e1b-4022-95fb-9d661683b833", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9310), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 1500, null },
                    { "182c7858-16e0-4eb3-88ce-389791bdf4d7", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9806), null, true, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "194c25ca-ad8d-4923-9163-41375a9be4fa", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9470), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 1500, null },
                    { "196aa1d4-4553-4117-9c5b-97e1066b9fa0", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9326), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "1a022a44-4924-488c-9b56-d715f641b086", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9691), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 1500, null },
                    { "1ac7a097-1822-4e5b-85da-9af37fe15d6d", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9404), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 1500, null },
                    { "1c947b89-cb4d-4d6e-a4c9-6f109b1b5579", 10, new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(4), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ K", null, null, 1500, null },
                    { "1f57786c-d0ff-4290-9bb9-f13645350040", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9883), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MÜRDÜM", null, null, 1500, null },
                    { "22cdef43-5a12-4890-92eb-c03a084c9d6a", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9557), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 1500, null },
                    { "2315d382-69fb-43db-a439-0a5c591e828e", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9474), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 1500, null },
                    { "24274ef7-7529-4855-ae8a-fb7da5ef21ac", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9509), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 1500, null },
                    { "26ab983b-0a24-45de-bc95-a37dd56a53cc", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9331), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 1500, null },
                    { "281f5953-904a-41a0-8252-40e84a33e7b0", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9866), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI", null, null, 1500, null },
                    { "2a3570de-f05e-46ab-87ab-b0b93fe8cdff", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9435), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 1500, null },
                    { "2a8a7e65-49a3-4839-83dd-ac698a9265f4", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9773), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 1500, null },
                    { "2b4687c6-3ffb-4bf5-a0fa-c4e9399f74d0", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9527), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 1500, null },
                    { "2badb1e4-fd7c-492f-a18a-f65000eee97c", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9398), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 1500, null },
                    { "2d6333dd-3e73-4630-b074-9ab49b7c25e0", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9832), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "2dbc66f3-6a95-444f-8caa-849d0e519555", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9682), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "2e484e1b-a51c-431d-bfbd-bf9113a11dd9", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9493), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 1500, null },
                    { "2e7816a0-ca8f-485c-900c-13992437303c", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9995), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI K", null, null, 1500, null },
                    { "2f8a4c5f-f7b8-4b28-8fb0-0854b582a382", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9553), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 1500, null },
                    { "31a1beab-c730-4957-a576-42baf211be1c", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9816), null, true, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 1500, null },
                    { "31e2c058-c975-43aa-a4aa-c54c56960963", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9485), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 1500, null },
                    { "32d6458d-f14a-430a-b0b0-ec057896210f", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9768), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 1500, null },
                    { "34095f77-594d-4ed7-9cf4-642f8db61bc4", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9305), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 1500, null },
                    { "3544e4e1-2057-47d9-a6b9-4b033c948086", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9293), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "35cb77c4-de21-462f-808a-5c7f555befcd", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9275), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "37fd69c4-c05d-4e02-8f60-3c911c277e83", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9711), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "3866d847-1071-4cb4-95a0-4763425a035b", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9582), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 0, 1500 },
                    { "389300dc-1a50-43bf-94b5-410651a87b9b", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9811), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 1500, null },
                    { "3b3c8e50-c1d5-4eef-b4b1-15f7adb80d55", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9705), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "3c129174-907e-4d54-8ab6-8fdb8e1e15b1", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9321), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "3fed8b0a-ef7a-4bbb-a0d4-756f626eeb96", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9845), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "41191d3c-1d31-4601-8421-c894d02a5841", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9561), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 1500, null },
                    { "43d049e5-4d2f-4a7e-83a8-3c623f61e19b", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9942), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ ÜSKÜP-N2", null, null, 1500, null },
                    { "4628ced0-96f1-405c-860c-b6aa3dbcc5b8", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9652), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "486a51e3-7c74-4cbb-b788-b37f56cba354", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9946), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ YEŞİL", null, null, 1500, null },
                    { "494b8e0b-5dab-4f2c-80bc-f890e97ddeb6", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9870), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N2", null, null, 1500, null },
                    { "4c2477e4-f84b-4acc-b872-127ec91dbe65", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9716), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "4d2295d7-1ff7-46cc-8960-3e69a5e79b16", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9788), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "4e022baa-00b3-46a4-ae45-32e7716784a9", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9380), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 1500, null },
                    { "500a9162-aed6-4aa1-96f4-0012e40aa746", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9593), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 0, 1500 },
                    { "515a7e44-379f-4234-837f-97b510edb4b0", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9777), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 1500, null },
                    { "55ec2f90-de83-4df6-813b-a85336d9fc95", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9547), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 1500, null },
                    { "59bfac0b-c33a-4951-8970-0b7fd568ebe8", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9489), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 1500, null },
                    { "5a95cbf6-0820-4f87-8527-54ff41c07d44", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9696), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 1500, null },
                    { "5bdb0833-ca9e-49a6-8990-1e3d91f4209e", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9661), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 1500, null },
                    { "5f8b9429-a955-4fbd-9240-e7dca4b29c45", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9738), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 1500, null },
                    { "6139eeab-60c8-42b3-a628-b8a34ec02971", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9958), null, null, true, false, "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", "4dans", "LİRİK", null, null, 1500, null },
                    { "628eb608-0364-41e4-abee-73faffc728e2", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9918), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N2", null, null, 1500, null },
                    { "63989f26-7305-4987-9a3f-9d4868cb5ceb", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9742), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "64b0aa04-9498-426a-8022-ae8fc4a7fb14", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9608), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 0, 1500 },
                    { "64c246d3-4b44-43c6-b71e-e47381342570", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9686), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 1500, null },
                    { "67701588-788c-4c98-b62d-c923355e74f5", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9936), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE-N2", null, null, 1500, null },
                    { "69444092-9650-4f4c-a59c-3c2aee10d1b7", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9827), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 1500, null },
                    { "6a0110b8-7792-447a-a70a-bfafcea1bbbb", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9505), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 1500, null },
                    { "6b09c8b0-b211-4ec1-89c2-f96a1e241697", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9393), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 1500, null },
                    { "6b135c1f-6d5e-4202-a366-3f267bc39df9", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9430), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "6c29954b-8aef-45aa-b742-b5ebfdd2d691", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9497), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 1500, null },
                    { "6f46232d-a2a4-4f03-a350-5998233db9e5", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9579), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 0, 1500 },
                    { "70ca9c78-3399-48d9-a9e8-705bba952306", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9729), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 1500, null },
                    { "71fd6ee1-fe8a-4f46-93c4-07924cc818ee", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9643), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "73ea72c0-f21e-405e-9491-7a54ecc41a08", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9446), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "78097518-39af-4e5a-902f-08e496b44107", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9797), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "784313a4-7a89-4191-bc4a-7186b6caa3cf", 10, new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ E", null, null, 1500, null },
                    { "7ba76db2-edbb-42ad-9b30-f3c35a7e8d94", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9700), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "7e0bdf70-bf00-422b-a9e4-2e5e33e6d44b", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9523), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 1500, null },
                    { "7eaba2f3-ba38-4d18-8f9c-181e1b4f2742", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9895), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ BORDO", null, null, 1500, null },
                    { "7efd46f7-eaf5-4146-85c3-8b486cd9e86f", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9625), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 0, 1500 },
                    { "8038e8aa-f57a-4ae2-a077-87c8e429aefe", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9631), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 0, 1500 },
                    { "8052af07-172e-41f4-be08-a2d7bea36c6f", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9336), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 1500, null },
                    { "82e1aff5-4a7c-4f17-858d-51255775b1e4", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9570), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 1500, null },
                    { "8391d565-085b-47ab-9f00-452c965741e2", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9982), null, null, true, false, "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN TURUNCU", null, "ROMAN", 1500, null },
                    { "84d6948b-2ebd-45a4-9ab4-f96c1ef4e794", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9612), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 0, 1500 },
                    { "8502496f-2a0e-4468-b084-ec1fef6fcbb4", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9856), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MUĞLA", "EGE", "ZEYBEK", 1500, null },
                    { "85f1e9ac-d10f-4075-83c6-d2567d9b9eff", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9421), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 1500, null },
                    { "86536584-635e-4ae2-aed4-1439a4a98c1d", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9962), null, null, true, false, "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, "ROMAN", 1500, null },
                    { "86eec870-8510-47bf-b0a6-f331734f9a53", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9389), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 1500, null },
                    { "878e0d36-2e78-4a81-875a-fd5676c3d3d5", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9597), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 0, 1500 },
                    { "87a3d2a2-dfd9-437a-ae71-d1db5d7b8f9b", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9912), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT", null, null, 1500, null },
                    { "8cba63b9-86ac-4ebd-93bb-f5db69383221", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9720), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 1500, null },
                    { "93dc3a2d-bf5d-41bc-acd6-2096b7a91c6f", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9341), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "94759472-bb72-4f9a-bbf9-a0653748dbde", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9821), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 1500, null },
                    { "95dacc37-93e2-46f1-9fb1-b9dbdfe53413", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9441), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 1500, null },
                    { "9c95f54c-0a80-41f2-b3b0-02f3b739e484", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9971), null, null, true, false, "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN PEMBE", null, "ROMAN", 1500, null },
                    { "9c972eb1-991b-4cb2-a6fc-b2a4218063ad", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9764), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 1500, null },
                    { "9cd10786-95a8-4732-a69b-2377af94359f", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9986), null, null, true, false, "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN YEŞİL", null, "ROMAN", 1500, null },
                    { "a6c2062d-7a64-43c4-a1f0-93893ad720e1", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9887), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN PEMBE", null, null, 1500, null },
                    { "a7afd8a1-d116-4a27-ae92-562046a33180", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9990), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI E", null, null, 1500, null },
                    { "a8d72f48-2084-40b9-b016-525aad9612be", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9733), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 1500, null },
                    { "aa41a1bc-219e-4972-a2eb-e4932423eedd", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9457), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 1500, null },
                    { "aadb99d7-432b-4aa3-b1c7-4fbbdfa6ef47", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9425), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 1500, null },
                    { "ab95e998-8399-4f6a-aac4-8ddc5749d291", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9891), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN YEŞİL", null, null, 1500, null },
                    { "ad8c2f6e-0871-4924-9cdd-ac80ce4965d6", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9371), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 1500, null },
                    { "adf7c54b-4f74-4f36-8bb5-61690a1e987c", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9840), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 1500, null },
                    { "b029e603-3f28-4dfb-b23e-949283bd7883", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9515), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 1500, null },
                    { "b1624497-8fc7-4995-b199-3c26f5539b63", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9977), null, null, true, false, "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN RENKLİ ETEK", null, "ROMAN", 1500, null },
                    { "b571a2e1-30ee-4e8f-a22c-b684a834a5f8", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9793), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "b5953b8c-1e32-4ccd-be47-b2f9299b48ad", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9450), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 1500, null },
                    { "b5abee89-67c1-46ef-8498-6379add24f48", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9904), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI", null, null, 1500, null },
                    { "b990264f-8f6e-4783-b2f6-5f5bd9e2252f", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9647), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "ba745b46-4999-4725-b219-b0c4d0123bf7", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9356), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "badd91db-79b7-4af5-81d4-65d6dc5f11e6", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9836), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 1500, null },
                    { "bc116330-2a06-41a9-a8be-6bd589faebe6", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9676), null, true, true, false, "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "bc5ea138-f7bb-4a12-80b4-4bacc3c9bd45", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9385), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 1500, null },
                    { "c3cebbbe-1edd-41ce-a843-248ef147be41", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9751), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "c476963d-15f5-4a05-b123-d760ec96939d", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9566), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 1500, null },
                    { "c506c855-6934-4feb-9648-d0c1da2759f3", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9908), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI-N2", null, null, 1500, null },
                    { "c64ff40e-7a6d-4e97-8ba3-f5f564e105ac", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9346), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 1500, null },
                    { "c7e2051c-c91b-4e60-b91f-95611bd89fe4", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9635), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 0, 1500 },
                    { "cc003b66-1a33-4609-9422-369a26f8043a", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9536), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 1500, null },
                    { "ccb358cd-57ef-424c-9ee7-f571acf7049d", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9672), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "d01258fa-9299-49e3-841d-c45032ea4da6", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9540), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 1500, null },
                    { "d21b2dfb-63dd-48dc-9239-232675caa114", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9366), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 1500, null },
                    { "d233d505-5eb5-464f-8b40-9d0dab285ee3", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9466), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 1500, null },
                    { "d2d816c3-94c9-4d01-a14d-2ee50f2581dc", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9849), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK PEMBE", "EGE", "ZEYBEK", 1500, null },
                    { "d45adedd-f23e-4870-94f2-973a3dc4ade6", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9589), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 0, 1500 },
                    { "ddf36716-6e3a-4852-8e78-3d0a0525c9aa", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9602), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 0, 1500 },
                    { "e11c5ada-e1ad-4549-922e-101504953b6d", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9480), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 1500, null },
                    { "e2a8a7f3-5d83-4d12-bea7-40d279c81b3f", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9954), null, null, true, false, "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", "4dans", "ÇİFTETELLİ BEYAZ", null, "ÇİFTETELLİ", 1500, null },
                    { "e375927c-1364-41c2-b0b6-942010a07fd5", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9375), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 1500, null },
                    { "e59ed879-c254-4f3c-bca9-bea1c1c7ff8e", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9922), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N3", null, null, 1500, null },
                    { "e5a0487f-494f-4076-b21b-30830dee45b2", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9501), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 1500, null },
                    { "e77943ce-db4e-4b80-ad2c-f6f0341ff9e6", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9875), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N3", null, null, 1500, null },
                    { "e7d08264-c708-483f-baec-f8a2222d5724", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9950), null, null, true, false, "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", "4dans", "AŞUK MAŞUK", null, null, 1500, null },
                    { "e8e9dffa-d4c1-467d-aaa6-1743962f78df", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9412), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "eb3e1aad-3afa-4342-af9d-3dfeeebf7d29", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9656), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpG", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 1500, null },
                    { "eb7df20e-fe62-4ff3-873e-60846f0e927a", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9802), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "ed64b962-17e7-4f16-b9ec-159c2ad3af8d", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9519), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 1500, null },
                    { "ee29dbe3-81a1-4237-8891-a35836c91b34", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9417), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 1500, null },
                    { "efdd945f-9fd5-416e-81aa-c3888612a7e7", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9300), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 1500, null },
                    { "f1e13408-3692-46d3-909d-6f4b42a6b934", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9532), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 1500, null },
                    { "f38c811d-97f0-4ee5-9b27-bc8ddbca4c27", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9665), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 1500, null },
                    { "f8818600-2a62-4264-943e-cdd6a84289a4", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9879), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MOR", null, null, 1500, null },
                    { "f9960463-af32-46dd-bb14-847319764196", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9617), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 0, 1500 },
                    { "fb795ad3-95b4-4503-95f3-a5c64f00d47e", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9929), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE", null, null, 1500, null },
                    { "fc6d8b4f-9e9a-406b-aa3e-ec09e74f15ef", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9462), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 1500, null },
                    { "fc784dd0-57e5-47ec-97ff-e708d3614903", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9725), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 1500, null },
                    { "fd155aa6-02e2-46cb-a006-ff36235dea03", 0, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9900), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ GRİ-SİYAH", null, null, 1500, null },
                    { "fd846410-e423-4c2c-9303-3b2cf4de23a5", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9360), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "fe1fa887-8335-4ae7-9c1b-30f35393d81f", 10, new DateTime(2024, 12, 16, 7, 13, 19, 296, DateTimeKind.Local).AddTicks(9574), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 16, 7, 13, 19, 297, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "f4ff1cc9-2d5d-405f-857f-3401d949264d", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 16, 7, 13, 19, 298, DateTimeKind.Local).AddTicks(822), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreatedAt", "SizeNumber" },
                values: new object[,]
                {
                    { "10be48c2-ba71-434c-ac54-2d4366d6a805", new DateTime(2024, 12, 16, 7, 13, 19, 298, DateTimeKind.Local).AddTicks(2703), 14 },
                    { "2d05f1d5-ca04-435c-9994-cc4049c73a35", new DateTime(2024, 12, 16, 7, 13, 19, 298, DateTimeKind.Local).AddTicks(2677), 8 },
                    { "614d209d-fc5a-49eb-bd78-e1c2c6eb43b6", new DateTime(2024, 12, 16, 7, 13, 19, 298, DateTimeKind.Local).AddTicks(2698), 12 },
                    { "f2bc7107-d7d1-4977-8a08-982332d6cfd5", new DateTime(2024, 12, 16, 7, 13, 19, 298, DateTimeKind.Local).AddTicks(2693), 10 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "a17ddc18-3198-4b77-8278-3e87cf5f37fc", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                keyValue: "03b2eb19-627e-4053-87e1-5cfa4ba21760");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "1a17b882-dc61-46e1-a36f-180bf3d9c525");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "263560f6-e9a2-4eb2-8b75-cb0102ba3130");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "28100e4f-ba98-43cc-b7bf-46e2d1bbc4bf");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "28816814-8c49-4566-9de0-af156abc67c7");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "2d7dcb31-19e9-4dfc-8af7-623122304598");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "3087c3de-b5d1-4b8a-b234-e25493fcf029");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "43d49876-bf10-413b-b507-83a391cf4fea");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "444c8681-1d2f-406d-9954-6e5a1ee52419");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "4a26a61a-8bc6-4a46-8c60-79f0adb4204a");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "58f06a1f-28b4-42f6-8041-b88b5eeeb6a7");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "64654e6a-c43d-43d1-82f3-6a586d837c11");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "778ede5d-3393-4953-9f8f-74b66585c463");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "8386c546-1fae-4b52-868f-0e39233f05ce");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "8c5a916a-73f8-4c10-ad73-a68953e96dce");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "be5c0453-f43c-4717-91c6-e75d42834c0e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "c33ed70c-0abc-489b-acdf-ff8b5d21c860");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "c471f9ee-1b2e-4490-8685-0fc1e55cd051");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "d4130f52-f778-4dfe-963a-7849ada223fe");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "ec6bfd04-7aef-450f-a1d4-6839afc39dbf");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "ec7610f9-6910-4563-be8d-6e286180bc6c");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f4dd8f84-f3e9-4fdf-9f3f-5f8fb440772e");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f5aaba68-f634-4cec-960b-157a8cfb3df8");

            migrationBuilder.DeleteData(
                table: "FotoGaleries",
                keyColumn: "Id",
                keyValue: "f68d6952-3edb-4e59-83cb-e2ec8851dfcc");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "08e1644b-2c6e-42c2-8841-9f5c5fbc22eb");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "27f27997-30ed-4eed-840d-723b79b9e6ed");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "55ce8a69-cf9b-4361-a7a6-d36f29dd786d");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "6c9933f0-b7ad-4c71-b093-8cdb0975d592");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "043d246d-95bd-45d8-98f9-b8dbc776b425");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "097911f7-00b3-4dba-9589-c37552b6ef71");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0b38a9b0-6a8b-49f9-9b91-4f1b219af5df");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0be3718d-0105-4cd6-91eb-c20711e744b5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e1926ce-ffa4-4a4e-9ced-271e271cbce3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "10e3dee7-2b07-4594-815f-d2fffbae1d9c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "13b10f43-1e1b-4022-95fb-9d661683b833");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "182c7858-16e0-4eb3-88ce-389791bdf4d7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "194c25ca-ad8d-4923-9163-41375a9be4fa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "196aa1d4-4553-4117-9c5b-97e1066b9fa0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a022a44-4924-488c-9b56-d715f641b086");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1ac7a097-1822-4e5b-85da-9af37fe15d6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c947b89-cb4d-4d6e-a4c9-6f109b1b5579");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f57786c-d0ff-4290-9bb9-f13645350040");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "22cdef43-5a12-4890-92eb-c03a084c9d6a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2315d382-69fb-43db-a439-0a5c591e828e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "24274ef7-7529-4855-ae8a-fb7da5ef21ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "26ab983b-0a24-45de-bc95-a37dd56a53cc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "281f5953-904a-41a0-8252-40e84a33e7b0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a3570de-f05e-46ab-87ab-b0b93fe8cdff");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2a8a7e65-49a3-4839-83dd-ac698a9265f4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2b4687c6-3ffb-4bf5-a0fa-c4e9399f74d0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2badb1e4-fd7c-492f-a18a-f65000eee97c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d6333dd-3e73-4630-b074-9ab49b7c25e0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2dbc66f3-6a95-444f-8caa-849d0e519555");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e484e1b-a51c-431d-bfbd-bf9113a11dd9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e7816a0-ca8f-485c-900c-13992437303c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2f8a4c5f-f7b8-4b28-8fb0-0854b582a382");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31a1beab-c730-4957-a576-42baf211be1c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31e2c058-c975-43aa-a4aa-c54c56960963");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "32d6458d-f14a-430a-b0b0-ec057896210f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "34095f77-594d-4ed7-9cf4-642f8db61bc4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3544e4e1-2057-47d9-a6b9-4b033c948086");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "35cb77c4-de21-462f-808a-5c7f555befcd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "37fd69c4-c05d-4e02-8f60-3c911c277e83");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3866d847-1071-4cb4-95a0-4763425a035b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "389300dc-1a50-43bf-94b5-410651a87b9b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3b3c8e50-c1d5-4eef-b4b1-15f7adb80d55");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3c129174-907e-4d54-8ab6-8fdb8e1e15b1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3fed8b0a-ef7a-4bbb-a0d4-756f626eeb96");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "41191d3c-1d31-4601-8421-c894d02a5841");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43d049e5-4d2f-4a7e-83a8-3c623f61e19b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4628ced0-96f1-405c-860c-b6aa3dbcc5b8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "486a51e3-7c74-4cbb-b788-b37f56cba354");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "494b8e0b-5dab-4f2c-80bc-f890e97ddeb6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c2477e4-f84b-4acc-b872-127ec91dbe65");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4d2295d7-1ff7-46cc-8960-3e69a5e79b16");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e022baa-00b3-46a4-ae45-32e7716784a9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "500a9162-aed6-4aa1-96f4-0012e40aa746");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "515a7e44-379f-4234-837f-97b510edb4b0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55ec2f90-de83-4df6-813b-a85336d9fc95");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "59bfac0b-c33a-4951-8970-0b7fd568ebe8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a95cbf6-0820-4f87-8527-54ff41c07d44");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5bdb0833-ca9e-49a6-8990-1e3d91f4209e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5f8b9429-a955-4fbd-9240-e7dca4b29c45");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6139eeab-60c8-42b3-a628-b8a34ec02971");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "628eb608-0364-41e4-abee-73faffc728e2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "63989f26-7305-4987-9a3f-9d4868cb5ceb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64b0aa04-9498-426a-8022-ae8fc4a7fb14");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64c246d3-4b44-43c6-b71e-e47381342570");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "67701588-788c-4c98-b62d-c923355e74f5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69444092-9650-4f4c-a59c-3c2aee10d1b7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6a0110b8-7792-447a-a70a-bfafcea1bbbb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6b09c8b0-b211-4ec1-89c2-f96a1e241697");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6b135c1f-6d5e-4202-a366-3f267bc39df9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c29954b-8aef-45aa-b742-b5ebfdd2d691");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f46232d-a2a4-4f03-a350-5998233db9e5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70ca9c78-3399-48d9-a9e8-705bba952306");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "71fd6ee1-fe8a-4f46-93c4-07924cc818ee");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "73ea72c0-f21e-405e-9491-7a54ecc41a08");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78097518-39af-4e5a-902f-08e496b44107");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "784313a4-7a89-4191-bc4a-7186b6caa3cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7ba76db2-edbb-42ad-9b30-f3c35a7e8d94");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7e0bdf70-bf00-422b-a9e4-2e5e33e6d44b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7eaba2f3-ba38-4d18-8f9c-181e1b4f2742");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7efd46f7-eaf5-4146-85c3-8b486cd9e86f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8038e8aa-f57a-4ae2-a077-87c8e429aefe");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8052af07-172e-41f4-be08-a2d7bea36c6f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "82e1aff5-4a7c-4f17-858d-51255775b1e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8391d565-085b-47ab-9f00-452c965741e2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "84d6948b-2ebd-45a4-9ab4-f96c1ef4e794");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8502496f-2a0e-4468-b084-ec1fef6fcbb4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "85f1e9ac-d10f-4075-83c6-d2567d9b9eff");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86536584-635e-4ae2-aed4-1439a4a98c1d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "86eec870-8510-47bf-b0a6-f331734f9a53");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "878e0d36-2e78-4a81-875a-fd5676c3d3d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "87a3d2a2-dfd9-437a-ae71-d1db5d7b8f9b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8cba63b9-86ac-4ebd-93bb-f5db69383221");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93dc3a2d-bf5d-41bc-acd6-2096b7a91c6f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "94759472-bb72-4f9a-bbf9-a0653748dbde");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "95dacc37-93e2-46f1-9fb1-b9dbdfe53413");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c95f54c-0a80-41f2-b3b0-02f3b739e484");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c972eb1-991b-4cb2-a6fc-b2a4218063ad");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9cd10786-95a8-4732-a69b-2377af94359f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a6c2062d-7a64-43c4-a1f0-93893ad720e1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a7afd8a1-d116-4a27-ae92-562046a33180");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a8d72f48-2084-40b9-b016-525aad9612be");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aa41a1bc-219e-4972-a2eb-e4932423eedd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aadb99d7-432b-4aa3-b1c7-4fbbdfa6ef47");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ab95e998-8399-4f6a-aac4-8ddc5749d291");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad8c2f6e-0871-4924-9cdd-ac80ce4965d6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "adf7c54b-4f74-4f36-8bb5-61690a1e987c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b029e603-3f28-4dfb-b23e-949283bd7883");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1624497-8fc7-4995-b199-3c26f5539b63");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b571a2e1-30ee-4e8f-a22c-b684a834a5f8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5953b8c-1e32-4ccd-be47-b2f9299b48ad");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b5abee89-67c1-46ef-8498-6379add24f48");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b990264f-8f6e-4783-b2f6-5f5bd9e2252f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ba745b46-4999-4725-b219-b0c4d0123bf7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "badd91db-79b7-4af5-81d4-65d6dc5f11e6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bc116330-2a06-41a9-a8be-6bd589faebe6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bc5ea138-f7bb-4a12-80b4-4bacc3c9bd45");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c3cebbbe-1edd-41ce-a843-248ef147be41");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c476963d-15f5-4a05-b123-d760ec96939d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c506c855-6934-4feb-9648-d0c1da2759f3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c64ff40e-7a6d-4e97-8ba3-f5f564e105ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c7e2051c-c91b-4e60-b91f-95611bd89fe4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cc003b66-1a33-4609-9422-369a26f8043a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ccb358cd-57ef-424c-9ee7-f571acf7049d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d01258fa-9299-49e3-841d-c45032ea4da6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d21b2dfb-63dd-48dc-9239-232675caa114");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d233d505-5eb5-464f-8b40-9d0dab285ee3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d2d816c3-94c9-4d01-a14d-2ee50f2581dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d45adedd-f23e-4870-94f2-973a3dc4ade6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ddf36716-6e3a-4852-8e78-3d0a0525c9aa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e11c5ada-e1ad-4549-922e-101504953b6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e2a8a7f3-5d83-4d12-bea7-40d279c81b3f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e375927c-1364-41c2-b0b6-942010a07fd5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e59ed879-c254-4f3c-bca9-bea1c1c7ff8e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e5a0487f-494f-4076-b21b-30830dee45b2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e77943ce-db4e-4b80-ad2c-f6f0341ff9e6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d08264-c708-483f-baec-f8a2222d5724");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e8e9dffa-d4c1-467d-aaa6-1743962f78df");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb3e1aad-3afa-4342-af9d-3dfeeebf7d29");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb7df20e-fe62-4ff3-873e-60846f0e927a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed64b962-17e7-4f16-b9ec-159c2ad3af8d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ee29dbe3-81a1-4237-8891-a35836c91b34");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "efdd945f-9fd5-416e-81aa-c3888612a7e7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f1e13408-3692-46d3-909d-6f4b42a6b934");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f38c811d-97f0-4ee5-9b27-bc8ddbca4c27");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f8818600-2a62-4264-943e-cdd6a84289a4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f9960463-af32-46dd-bb14-847319764196");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb795ad3-95b4-4503-95f3-a5c64f00d47e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc6d8b4f-9e9a-406b-aa3e-ec09e74f15ef");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc784dd0-57e5-47ec-97ff-e708d3614903");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fd155aa6-02e2-46cb-a006-ff36235dea03");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fd846410-e423-4c2c-9303-3b2cf4de23a5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fe1fa887-8335-4ae7-9c1b-30f35393d81f");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "f4ff1cc9-2d5d-405f-857f-3401d949264d");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "a17ddc18-3198-4b77-8278-3e87cf5f37fc");

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
