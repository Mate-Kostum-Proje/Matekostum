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

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 544, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 544, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 544, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 544, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 544, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 544, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "59dd9983-4b66-487f-be8b-9871f668ebf2", new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(194), "Siparişiniz Kargoya verildi" },
                    { "a39c7c36-da3b-4103-9280-289b0edff67f", new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(128), "Siparişiniz Alındı" },
                    { "bba9d853-99cd-497a-81c1-ad6912bb9744", new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(188), "Siparişiniz Hazırlanıyor" },
                    { "e60b2973-81bd-49e5-bb08-065dbe6a3117", new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(199), "Siparişiniz Tamamlandı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "Size", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "07135997-03a8-4905-a302-ffce7aa52124", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9783), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 8, 1500, null },
                    { "07592630-54b5-47ed-ae5e-167506bbb249", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9761), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 8, 1500, null },
                    { "0876435a-1955-4d80-86b4-f909290e0d73", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9567), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "08b1c42e-1426-449b-9c99-cb8356ca659e", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(204), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN YEŞİL", null, null, 14, 1500, null },
                    { "0b43c78b-f9ca-4bcc-bb96-b8895cff9506", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9524), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 8, 1500, null },
                    { "0b578341-a466-451a-a270-af2767f840e6", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9889), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 8, 0, 1500 },
                    { "0ce49c85-ccd3-4e3d-9a78-214bb9281499", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9503), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 8, 1500, null },
                    { "0fd73eed-c2e8-4577-a4df-04921b855569", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(179), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N2", null, null, 14, 1500, null },
                    { "1039a8d6-e92c-449a-b68e-18fa386a99f8", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(79), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "1336f01b-3817-43ae-baa5-083713cd960a", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9467), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 8, 1500, null },
                    { "13afc6ea-b129-4df9-82c9-d5a23186417f", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9633), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 8, 1500, null },
                    { "142a124f-2c29-4c53-b85e-f818857d32c2", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(31), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 14, 1500, null },
                    { "15eafa13-a7b9-4fbf-9747-da6358146c91", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9728), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 8, 1500, null },
                    { "16a2624d-6c70-41b5-8d88-9590cd66f933", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(213), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ GRİ-SİYAH", null, null, 14, 1500, null },
                    { "19704673-94df-4d22-88d6-7a7cf990ad73", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9842), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 8, 0, 1500 },
                    { "1b60a9c5-70fd-42f0-85b3-477e6f441d06", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(36), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 14, 1500, null },
                    { "1e58e940-54d2-4ece-bb37-51f5d50732b6", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(9), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 14, 1500, null },
                    { "1eaa8d38-532a-411a-af49-b46b1e7baeec", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9587), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 8, 1500, null },
                    { "204f3590-d183-4f22-847c-b46a65c543a7", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9793), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 8, 1500, null },
                    { "2465a6cd-43d3-455a-926b-1973d043e035", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9509), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "271586d5-e120-499d-a0b8-94bbfb85933c", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9942), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 14, 1500, null },
                    { "2794ec18-1c45-4f0e-bcee-009acccf5c3b", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9689), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 8, 1500, null },
                    { "2db72a3f-5f61-4050-b0e6-e4962707c21d", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(155), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 14, 1500, null },
                    { "2e275bfe-d5de-498a-a8fe-c945145e6382", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(309), null, null, true, false, "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN YEŞİL", null, "ROMAN", 14, 1500, null },
                    { "2ffcfcf9-ccfa-4b8f-aa99-794786b4f5ef", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9970), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 14, 1500, null },
                    { "3097b64a-945f-4aae-ad2d-bf9d694f2f85", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(337), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ K", null, null, 14, 1500, null },
                    { "32c86af0-b2d2-4ec7-bbf9-5e3619ae24da", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9616), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "33d09a1d-31d6-4757-87a5-a7e8c7067bfa", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9904), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 8, 0, 1500 },
                    { "34a8a2d5-76b8-44c9-8cda-1770b0d07806", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9802), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 8, 1500, null },
                    { "35d7e85f-5a07-430a-9634-14f1c0a519da", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(316), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI E", null, null, 14, 1500, null },
                    { "39237546-8e60-486b-ad56-2c1ab9e86e45", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9827), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 8, 1500, null },
                    { "39528fce-427b-4722-a0fa-f4d71931a114", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9883), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 8, 0, 1500 },
                    { "3982f475-3643-41b9-ac5d-b9f24fe79443", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9848), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 8, 0, 1500 },
                    { "39980ae6-0ff2-4c9b-8cf7-8a7237e7ca16", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(244), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N3", null, null, 14, 1500, null },
                    { "39bc48b4-2b87-43f8-a6eb-57f84f04dc99", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9777), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 8, 1500, null },
                    { "3a7be806-b6ac-4058-bb30-a7e093dfa81c", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9711), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 8, 1500, null },
                    { "3aa93045-457d-4160-af77-fa3c1977f169", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(170), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN BORDO", null, null, 14, 1500, null },
                    { "3b1daa12-101b-4eed-9429-e6622d1f513e", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(90), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "3d1c1493-0225-4d66-8dff-05e5abdd2d2f", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9739), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 8, 1500, null },
                    { "3d6cee80-9641-4a0f-b323-647d6c71ad11", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9671), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 8, 1500, null },
                    { "3e64f508-a183-4395-9f40-41f1c8238fd2", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9666), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 8, 1500, null },
                    { "3ed9baea-7d43-4447-818b-7817e67e5632", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(253), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE-N2", null, null, 14, 1500, null },
                    { "4106e5f5-6dae-4d12-9df2-5bc741576a3e", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(305), null, null, true, false, "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN TURUNCU", null, "ROMAN", 14, 1500, null },
                    { "4170408b-269d-49a7-a749-dd91554e7fa8", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9913), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 14, 1500, null },
                    { "4349427d-961e-48d7-81da-78a70528a657", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9766), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 8, 1500, null },
                    { "43c2bc93-57fa-4024-87bb-52ab9a61e0eb", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(183), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N3", null, null, 14, 1500, null },
                    { "45a1dea7-ea1a-465c-b3fa-7a9ec8f99126", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9639), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 8, 1500, null },
                    { "47348bc3-2cd6-4cb9-8c6b-88e9553321fb", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(124), null, true, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 14, 1500, null },
                    { "48162462-3537-4a76-984c-3aad213ae02b", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(15), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 14, 1500, null },
                    { "4ce34f16-2c2d-41fa-97b1-9b0b58925f9d", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(129), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "4e71d38d-c977-41ec-9863-8e8db397f82c", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(63), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 14, 1500, null },
                    { "4efc05d6-9c95-4cdd-ad1a-30e0f59382d8", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9893), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 8, 0, 1500 },
                    { "5069d177-7f97-484b-8ca1-5b5b97a5d1df", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9656), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 8, 1500, null },
                    { "52217f6b-d847-4c0d-9eb0-db79dcae2b12", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9681), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 8, 1500, null },
                    { "53215d59-28b5-41a8-95b6-37489cd5ce8f", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(107), null, true, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 14, 1500, null },
                    { "55153ae6-060a-4fd1-92d1-7745c9021df2", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(85), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "5780f3a0-b74e-4f5a-925d-3d6e9a2d8050", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(134), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "57bc3135-8336-4978-a6dc-b90bf2cc463e", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9661), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 8, 1500, null },
                    { "584f98d3-2c6b-429d-a276-5d2ed83bbf18", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(51), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 14, 1500, null },
                    { "593f9a16-69d6-46e4-a548-d79ee1aa92cd", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(262), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ YEŞİL", null, null, 14, 1500, null },
                    { "5b4673c0-a79d-4725-8c16-5d1498aebc69", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(258), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ ÜSKÜP-N2", null, null, 14, 1500, null },
                    { "5cc12295-4a1d-4b58-b6d7-39e89ea92b00", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(280), null, null, true, false, "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", "4dans", "LİRİK", null, null, 14, 1500, null },
                    { "5e0cfa64-0909-47ad-bbae-d862806287a1", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9717), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 8, 1500, null },
                    { "605e7192-7542-4a51-930e-6db23b9680e2", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(268), null, null, true, false, "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", "4dans", "AŞUK MAŞUK", null, null, 14, 1500, null },
                    { "6325741c-23fb-4f6d-87e2-f904305167e9", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9537), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "65c28d1c-d903-4282-94fc-3b17fe477363", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9518), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "696948f3-d481-435b-9c52-8a2ed1598a88", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9601), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 8, 1500, null },
                    { "6ac94c54-00a7-4358-9683-ef432070d140", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9676), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 8, 1500, null },
                    { "6c73e01e-e3d7-4759-a3fc-e30be661e2b9", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(227), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT", null, null, 14, 1500, null },
                    { "6f606cec-8dd7-48f6-93a6-ca6caa84d5fb", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(95), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "71bf7c25-e210-404e-a8f8-8f5371d3b4f5", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(321), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI K", null, null, 14, 1500, null },
                    { "72c3cd25-5321-41c8-ace8-79ef6e4a4ddd", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9549), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 8, 1500, null },
                    { "75101573-af84-4676-b872-dc60c5bd4e84", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(150), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "77520686-3daa-439e-b9a7-e93e143d6ec0", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9965), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 14, 1500, null },
                    { "7a098bda-11e4-44f2-99ff-ce709f3b3be8", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9832), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 8, 1500, null },
                    { "7c5c3476-9c9e-4bc0-8de4-6de21e50737f", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9899), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 8, 0, 1500 },
                    { "7cc68ace-4962-49f6-b42a-e1c37680b59e", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(160), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK PEMBE", "EGE", "ZEYBEK", 14, 1500, null },
                    { "7cc880b1-4b60-4489-bf56-ccf61bfa75b5", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(300), null, null, true, false, "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN RENKLİ ETEK", null, "ROMAN", 14, 1500, null },
                    { "7dacac9c-1a4d-4195-86e9-510e17d83965", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(3), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 14, 1500, null },
                    { "7f32f771-7236-445b-a97a-0fcc60e67c0a", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(165), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MUĞLA", "EGE", "ZEYBEK", 14, 1500, null },
                    { "852748b6-7fc7-400c-a111-54b7d8a67755", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(189), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MOR", null, null, 14, 1500, null },
                    { "88c73a5f-9fe3-42ba-8e8c-4a90bfdd66bb", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(143), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "8adf6cbd-b973-4791-bb5d-125463d08911", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(289), null, null, true, false, "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, "ROMAN", 14, 1500, null },
                    { "8db6ff56-9c61-4bf7-97bf-fd0f16708e53", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9853), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 8, 0, 1500 },
                    { "8fccd351-417a-407b-848a-decb8a3b6a5e", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(331), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ E", null, null, 14, 1500, null },
                    { "9213066d-6561-4e1e-b2a1-4050022d375a", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9646), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 8, 1500, null },
                    { "936f49cd-22fd-432c-9dcf-d9c1d9fd4125", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9572), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "941a9f93-5394-403c-b646-34dc2c6ef753", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9920), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 14, 1500, null },
                    { "9500f9a3-8fe8-4e01-82bc-0c9cb5a8a5ba", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9865), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 8, 0, 1500 },
                    { "95c1517e-88ec-411f-be4f-7356284330d5", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9651), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 8, 1500, null },
                    { "978ed23d-6a3f-4fea-9c86-c46442150db1", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9806), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 8, 1500, null },
                    { "97b8fd5f-c829-42b0-bb01-c509297ca7a4", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9935), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 14, 1500, null },
                    { "983b4ebf-d84c-4ac1-bf15-e8440e7b7638", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9756), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 8, 1500, null },
                    { "9a2b196f-880d-4e21-a597-3c7f954cb2c6", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9975), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 14, 1500, null },
                    { "9a7c00b5-4e95-4b4a-83af-d46996e5acf7", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(295), null, null, true, false, "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN PEMBE", null, "ROMAN", 14, 1500, null },
                    { "9acb50fc-9a8a-4723-aa25-c0654450e33d", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9985), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 14, 1500, null },
                    { "9d8287ec-5372-4aac-90fc-dcee426e831f", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9734), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 8, 1500, null },
                    { "9f241aae-5b1f-4876-96d7-e05770cdc083", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(275), null, null, true, false, "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", "4dans", "ÇİFTETELLİ BEYAZ", null, "ÇİFTETELLİ", 14, 1500, null },
                    { "9f5aae70-3667-4f4f-a309-2c611c295150", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9878), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 8, 0, 1500 },
                    { "a124deda-eb95-4c6f-91bf-c20f3a646f44", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9947), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ E", "DOGU ANADOLU", "BİTLİS", 14, 1500, null },
                    { "a4855ca5-9364-467f-9473-4dadc54862a6", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9788), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 8, 1500, null },
                    { "a951a76b-0158-4471-a907-dbda1a17fa40", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(102), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 14, 1500, null },
                    { "a9b6f357-b4b1-4570-9021-8bd5e472e9ce", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9797), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 8, 1500, null },
                    { "aa962db1-437d-4067-9177-0a2af10e7144", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9695), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 8, 1500, null },
                    { "ad3d7edb-f55d-40e7-9a8d-51806eb19a4d", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9611), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "ad7a502b-0baf-41d4-8a4c-07846fdab171", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9858), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 8, 0, 1500 },
                    { "ae25684f-24e8-4a74-96d8-3df55e2368c0", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9621), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "ae7805f6-221a-4f5b-bcd9-8f5d3ca1b086", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(208), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ BORDO", null, null, 14, 1500, null },
                    { "aed05443-b78b-4da3-b58d-4df5fec6643b", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(249), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE", null, null, 14, 1500, null },
                    { "af82ca6a-5e4b-4c2e-9000-8a5dd913618e", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9582), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 8, 1500, null },
                    { "b26cb6de-4832-49a4-95ca-c7d9c76799c1", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9837), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 8, 0, 1500 },
                    { "b503836c-5568-4cbf-a97f-2e545f130713", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9577), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 8, 1500, null },
                    { "b684874b-fc19-4263-af87-d30bbba50fd0", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(199), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN PEMBE", null, null, 14, 1500, null },
                    { "b74eb107-e283-4a7a-9a9c-4d564ac33723", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9723), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 8, 1500, null },
                    { "b983c4c0-5cbe-48c3-a9d3-6d997d7c9992", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9556), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 8, 1500, null },
                    { "ba438402-8347-41be-983f-61b172ab98ed", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(138), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 14, 1500, null },
                    { "bca7c527-82c6-460f-89ad-52a7255bddf1", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9816), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 8, 1500, null },
                    { "bcc47c0e-b9d7-42b0-90b5-6853a1ff0a26", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9930), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpG", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 14, 1500, null },
                    { "bd0caf38-d2e1-45ba-8638-35a9f9c71e10", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9531), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "c2a83380-c880-4c08-9c4f-0b177d22cc1e", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9772), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 8, 1500, null },
                    { "c3deed6f-7536-44ca-a82a-88bc36d85d51", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(26), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 14, 1500, null },
                    { "cb4a6268-cb4f-43d1-bf73-e57aa75ecfc0", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9980), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 14, 1500, null },
                    { "cfbe984e-7ea7-4b0c-b7a1-b3f3116b0e52", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9925), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 14, 1500, null },
                    { "d24317ee-a030-4919-ba31-3a4dd167e96b", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(240), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N2", null, null, 14, 1500, null },
                    { "d293ddc7-5452-4198-928d-f606ee085c85", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9701), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 8, 1500, null },
                    { "d947a56c-6dfc-4949-9171-8351b4a8c932", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9542), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 8, 1500, null },
                    { "dba82da7-3bcb-4cc7-ae7f-a3dd9e1a5720", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(74), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "dbb1e684-9b1b-4d44-96e8-057af98a7561", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9595), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 8, 1500, null },
                    { "dc014481-2b18-4aa7-8228-fa2c9d7bbf96", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(217), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI", null, null, 14, 1500, null },
                    { "ddf49cd0-7783-49e5-920f-53fc806b1559", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(221), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI-N2", null, null, 14, 1500, null },
                    { "dfbd7352-eea8-496a-9b81-b4bf30c0f16e", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(21), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 14, 1500, null },
                    { "e365b2fb-5c67-459c-882f-e3c6484ece27", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(69), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 14, 1500, null },
                    { "e4e126ed-9b1f-443e-80b5-0544413c4734", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9606), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 8, 1500, null },
                    { "e5422e4b-f34f-4020-b538-4062a9b0855f", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9822), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 8, 1500, null },
                    { "e695549b-062e-476a-855d-ea4638cac20b", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9706), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 8, 1500, null },
                    { "e6b3d021-eab7-40a1-86b3-9bdfbf759f54", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9811), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 8, 1500, null },
                    { "e86760a2-6b04-4486-8b4b-74f7ab7b2087", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9957), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 14, 1500, null },
                    { "ed5dd623-1e55-4e27-8790-46a271a19dcf", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(174), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI", null, null, 14, 1500, null },
                    { "edbfeb81-54ef-4936-849f-641519ce5dd7", 0, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(194), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MÜRDÜM", null, null, 14, 1500, null },
                    { "f17e886c-af62-455e-a6f5-38172bb2a278", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(58), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 14, 1500, null },
                    { "f41fe6ca-277e-477d-8242-133a039d703f", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9952), null, true, true, false, "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 14, 1500, null },
                    { "f8c9144d-3977-454e-93b6-b74dd042f3ac", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(284), null, null, true, false, "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, "ROMAN", 14, 1500, null },
                    { "f9ca3b5f-4f1c-409b-9481-1f4a7753da75", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9998), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 14, 1500, null },
                    { "fa6d5e8a-f401-4d45-a2ba-ee2487f15e88", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(113), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 14, 1500, null },
                    { "fb225afb-4344-4ab6-85ff-17d7cc89782f", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(41), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 14, 1500, null },
                    { "fbd21d5e-891d-4f97-8981-5ae55c4b402a", 10, new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(47), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 14, 1500, null },
                    { "fe82074a-4867-4e01-9f61-f79646779ed0", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9562), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 8, 1500, null },
                    { "ffdc6d8d-be1c-4080-9aa3-a9f438a02dad", 10, new DateTime(2024, 12, 15, 21, 5, 39, 546, DateTimeKind.Local).AddTicks(9744), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 8, 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 21, 5, 39, 547, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "efd9ccf6-ff5b-4400-b890-eb31b20c2098", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 15, 21, 5, 39, 548, DateTimeKind.Local).AddTicks(2527), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "5d2b875d-e3b7-4e80-af6c-427768902207", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "59dd9983-4b66-487f-be8b-9871f668ebf2");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "a39c7c36-da3b-4103-9280-289b0edff67f");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "bba9d853-99cd-497a-81c1-ad6912bb9744");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "e60b2973-81bd-49e5-bb08-065dbe6a3117");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "07135997-03a8-4905-a302-ffce7aa52124");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "07592630-54b5-47ed-ae5e-167506bbb249");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0876435a-1955-4d80-86b4-f909290e0d73");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "08b1c42e-1426-449b-9c99-cb8356ca659e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0b43c78b-f9ca-4bcc-bb96-b8895cff9506");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0b578341-a466-451a-a270-af2767f840e6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0ce49c85-ccd3-4e3d-9a78-214bb9281499");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0fd73eed-c2e8-4577-a4df-04921b855569");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1039a8d6-e92c-449a-b68e-18fa386a99f8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1336f01b-3817-43ae-baa5-083713cd960a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "13afc6ea-b129-4df9-82c9-d5a23186417f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "142a124f-2c29-4c53-b85e-f818857d32c2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "15eafa13-a7b9-4fbf-9747-da6358146c91");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16a2624d-6c70-41b5-8d88-9590cd66f933");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19704673-94df-4d22-88d6-7a7cf990ad73");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1b60a9c5-70fd-42f0-85b3-477e6f441d06");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1e58e940-54d2-4ece-bb37-51f5d50732b6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1eaa8d38-532a-411a-af49-b46b1e7baeec");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "204f3590-d183-4f22-847c-b46a65c543a7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2465a6cd-43d3-455a-926b-1973d043e035");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "271586d5-e120-499d-a0b8-94bbfb85933c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2794ec18-1c45-4f0e-bcee-009acccf5c3b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2db72a3f-5f61-4050-b0e6-e4962707c21d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2e275bfe-d5de-498a-a8fe-c945145e6382");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2ffcfcf9-ccfa-4b8f-aa99-794786b4f5ef");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3097b64a-945f-4aae-ad2d-bf9d694f2f85");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "32c86af0-b2d2-4ec7-bbf9-5e3619ae24da");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "33d09a1d-31d6-4757-87a5-a7e8c7067bfa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "34a8a2d5-76b8-44c9-8cda-1770b0d07806");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "35d7e85f-5a07-430a-9634-14f1c0a519da");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39237546-8e60-486b-ad56-2c1ab9e86e45");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39528fce-427b-4722-a0fa-f4d71931a114");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3982f475-3643-41b9-ac5d-b9f24fe79443");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39980ae6-0ff2-4c9b-8cf7-8a7237e7ca16");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39bc48b4-2b87-43f8-a6eb-57f84f04dc99");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a7be806-b6ac-4058-bb30-a7e093dfa81c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3aa93045-457d-4160-af77-fa3c1977f169");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3b1daa12-101b-4eed-9429-e6622d1f513e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d1c1493-0225-4d66-8dff-05e5abdd2d2f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d6cee80-9641-4a0f-b323-647d6c71ad11");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3e64f508-a183-4395-9f40-41f1c8238fd2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3ed9baea-7d43-4447-818b-7817e67e5632");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4106e5f5-6dae-4d12-9df2-5bc741576a3e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4170408b-269d-49a7-a749-dd91554e7fa8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4349427d-961e-48d7-81da-78a70528a657");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "43c2bc93-57fa-4024-87bb-52ab9a61e0eb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "45a1dea7-ea1a-465c-b3fa-7a9ec8f99126");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "47348bc3-2cd6-4cb9-8c6b-88e9553321fb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "48162462-3537-4a76-984c-3aad213ae02b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4ce34f16-2c2d-41fa-97b1-9b0b58925f9d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4e71d38d-c977-41ec-9863-8e8db397f82c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4efc05d6-9c95-4cdd-ad1a-30e0f59382d8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5069d177-7f97-484b-8ca1-5b5b97a5d1df");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "52217f6b-d847-4c0d-9eb0-db79dcae2b12");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "53215d59-28b5-41a8-95b6-37489cd5ce8f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55153ae6-060a-4fd1-92d1-7745c9021df2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5780f3a0-b74e-4f5a-925d-3d6e9a2d8050");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "57bc3135-8336-4978-a6dc-b90bf2cc463e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "584f98d3-2c6b-429d-a276-5d2ed83bbf18");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "593f9a16-69d6-46e4-a548-d79ee1aa92cd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5b4673c0-a79d-4725-8c16-5d1498aebc69");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cc12295-4a1d-4b58-b6d7-39e89ea92b00");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5e0cfa64-0909-47ad-bbae-d862806287a1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "605e7192-7542-4a51-930e-6db23b9680e2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6325741c-23fb-4f6d-87e2-f904305167e9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "65c28d1c-d903-4282-94fc-3b17fe477363");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "696948f3-d481-435b-9c52-8a2ed1598a88");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6ac94c54-00a7-4358-9683-ef432070d140");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6c73e01e-e3d7-4759-a3fc-e30be661e2b9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f606cec-8dd7-48f6-93a6-ca6caa84d5fb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "71bf7c25-e210-404e-a8f8-8f5371d3b4f5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72c3cd25-5321-41c8-ace8-79ef6e4a4ddd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75101573-af84-4676-b872-dc60c5bd4e84");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77520686-3daa-439e-b9a7-e93e143d6ec0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a098bda-11e4-44f2-99ff-ce709f3b3be8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7c5c3476-9c9e-4bc0-8de4-6de21e50737f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7cc68ace-4962-49f6-b42a-e1c37680b59e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7cc880b1-4b60-4489-bf56-ccf61bfa75b5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7dacac9c-1a4d-4195-86e9-510e17d83965");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7f32f771-7236-445b-a97a-0fcc60e67c0a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "852748b6-7fc7-400c-a111-54b7d8a67755");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "88c73a5f-9fe3-42ba-8e8c-4a90bfdd66bb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8adf6cbd-b973-4791-bb5d-125463d08911");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8db6ff56-9c61-4bf7-97bf-fd0f16708e53");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8fccd351-417a-407b-848a-decb8a3b6a5e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9213066d-6561-4e1e-b2a1-4050022d375a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "936f49cd-22fd-432c-9dcf-d9c1d9fd4125");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "941a9f93-5394-403c-b646-34dc2c6ef753");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9500f9a3-8fe8-4e01-82bc-0c9cb5a8a5ba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "95c1517e-88ec-411f-be4f-7356284330d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "978ed23d-6a3f-4fea-9c86-c46442150db1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "97b8fd5f-c829-42b0-bb01-c509297ca7a4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "983b4ebf-d84c-4ac1-bf15-e8440e7b7638");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9a2b196f-880d-4e21-a597-3c7f954cb2c6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9a7c00b5-4e95-4b4a-83af-d46996e5acf7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9acb50fc-9a8a-4723-aa25-c0654450e33d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9d8287ec-5372-4aac-90fc-dcee426e831f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f241aae-5b1f-4876-96d7-e05770cdc083");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9f5aae70-3667-4f4f-a309-2c611c295150");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a124deda-eb95-4c6f-91bf-c20f3a646f44");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a4855ca5-9364-467f-9473-4dadc54862a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a951a76b-0158-4471-a907-dbda1a17fa40");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9b6f357-b4b1-4570-9021-8bd5e472e9ce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aa962db1-437d-4067-9177-0a2af10e7144");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad3d7edb-f55d-40e7-9a8d-51806eb19a4d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad7a502b-0baf-41d4-8a4c-07846fdab171");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ae25684f-24e8-4a74-96d8-3df55e2368c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ae7805f6-221a-4f5b-bcd9-8f5d3ca1b086");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aed05443-b78b-4da3-b58d-4df5fec6643b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "af82ca6a-5e4b-4c2e-9000-8a5dd913618e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b26cb6de-4832-49a4-95ca-c7d9c76799c1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b503836c-5568-4cbf-a97f-2e545f130713");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b684874b-fc19-4263-af87-d30bbba50fd0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b74eb107-e283-4a7a-9a9c-4d564ac33723");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b983c4c0-5cbe-48c3-a9d3-6d997d7c9992");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ba438402-8347-41be-983f-61b172ab98ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bca7c527-82c6-460f-89ad-52a7255bddf1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bcc47c0e-b9d7-42b0-90b5-6853a1ff0a26");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd0caf38-d2e1-45ba-8638-35a9f9c71e10");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c2a83380-c880-4c08-9c4f-0b177d22cc1e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c3deed6f-7536-44ca-a82a-88bc36d85d51");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb4a6268-cb4f-43d1-bf73-e57aa75ecfc0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cfbe984e-7ea7-4b0c-b7a1-b3f3116b0e52");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d24317ee-a030-4919-ba31-3a4dd167e96b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d293ddc7-5452-4198-928d-f606ee085c85");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d947a56c-6dfc-4949-9171-8351b4a8c932");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dba82da7-3bcb-4cc7-ae7f-a3dd9e1a5720");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dbb1e684-9b1b-4d44-96e8-057af98a7561");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc014481-2b18-4aa7-8228-fa2c9d7bbf96");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ddf49cd0-7783-49e5-920f-53fc806b1559");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dfbd7352-eea8-496a-9b81-b4bf30c0f16e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e365b2fb-5c67-459c-882f-e3c6484ece27");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e4e126ed-9b1f-443e-80b5-0544413c4734");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e5422e4b-f34f-4020-b538-4062a9b0855f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e695549b-062e-476a-855d-ea4638cac20b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e6b3d021-eab7-40a1-86b3-9bdfbf759f54");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e86760a2-6b04-4486-8b4b-74f7ab7b2087");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ed5dd623-1e55-4e27-8790-46a271a19dcf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "edbfeb81-54ef-4936-849f-641519ce5dd7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f17e886c-af62-455e-a6f5-38172bb2a278");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f41fe6ca-277e-477d-8242-133a039d703f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f8c9144d-3977-454e-93b6-b74dd042f3ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f9ca3b5f-4f1c-409b-9481-1f4a7753da75");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fa6d5e8a-f401-4d45-a2ba-ee2487f15e88");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb225afb-4344-4ab6-85ff-17d7cc89782f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fbd21d5e-891d-4f97-8981-5ae55c4b402a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fe82074a-4867-4e01-9f61-f79646779ed0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ffdc6d8d-be1c-4080-9aa3-a9f438a02dad");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "efd9ccf6-ff5b-4400-b890-eb31b20c2098");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "5d2b875d-e3b7-4e80-af6c-427768902207");

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
                name: "Subject",
                table: "CommUsers");

            migrationBuilder.DropColumn(
                name: "Amount",
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
