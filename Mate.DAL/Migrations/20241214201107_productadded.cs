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
                value: new DateTime(2024, 12, 14, 23, 11, 7, 346, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 346, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 346, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 346, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 346, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 346, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "1bc7e5cd-26d5-4c93-a6ae-d4df879b90ba", new DateTime(2024, 12, 14, 23, 11, 7, 348, DateTimeKind.Local).AddTicks(3748), "Siparişiniz Alındı" },
                    { "863fb516-f859-446d-a88c-f0581dc7d79d", new DateTime(2024, 12, 14, 23, 11, 7, 348, DateTimeKind.Local).AddTicks(3766), "Siparişiniz Hazırlanıyor" },
                    { "af293261-9b20-439d-b19d-057da64c4639", new DateTime(2024, 12, 14, 23, 11, 7, 348, DateTimeKind.Local).AddTicks(3780), "Siparişiniz Tamamlandı" },
                    { "d5b5cf74-3230-4ee2-a380-ffdc25d709b2", new DateTime(2024, 12, 14, 23, 11, 7, 348, DateTimeKind.Local).AddTicks(3771), "Siparişiniz Kargoya verildi" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 348, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 348, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 348, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 348, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 348, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "Size", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "0126b076-7c63-4d17-8c34-f526d128f4e4", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2812), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "141ec255-9b4a-4c06-8ce0-3008fcd0c399", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2868), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 8, 1500, null },
                    { "1d586bc4-f1d1-4d92-9001-8f5431cc0f3a", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2794), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 8, 1500, null },
                    { "1f743518-04cc-4ecc-b110-f3e679a44408", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2774), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 8, 1500, null },
                    { "2100a61f-ff55-4cd2-9d51-1d4c9ec042e0", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2651), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 8, 1500, null },
                    { "26d63e4d-6ea7-4439-b9ad-edd7e784f50a", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2872), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 8, 1500, null },
                    { "29dccf20-080b-4e8a-943e-9a008a95544d", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2982), null, null, true, false, null, "4dans", "STİLİZE PEMBE", null, null, 8, 1500, null },
                    { "302ff986-c581-49cb-8e3d-aa25052dc98f", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2669), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "308b01ba-a3c0-4f5c-b057-6303f1b0196e", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2662), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "31d2a508-bba0-445c-a155-ffee37269cb9", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2786), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 8, 1500, null },
                    { "38fcc66e-0076-4a9e-b17b-439f716c397c", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2877), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 8, 1500, null },
                    { "467e1918-7f06-428a-9f74-e4f23adf3d91", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2848), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "5439eaff-7bb1-44ea-acc9-2ed04e50945d", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2893), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 8, 1500, null },
                    { "60d88e97-c65d-41b3-8d23-3d363bc951a2", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2687), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "61ba1654-0b9c-42d0-9392-cb6f9563b622", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2830), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 8, 1500, null },
                    { "6ab4c655-77dc-4b3d-82d3-67d96fb6e40a", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2933), null, null, false, false, null, "4dans", "HİNT", null, null, 8, 1500, null },
                    { "6ac6f20a-a68f-49f3-b374-76baefc8d463", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2843), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 8, 1500, null },
                    { "6fb1bb2c-357b-4877-b75e-4790ac6428c4", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2836), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 8, 1500, null },
                    { "71776438-d1ae-442e-a4b8-ca475b980657", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2978), null, null, true, false, null, "4dans", "STİLİZE MOR", null, null, 8, 1500, null },
                    { "71db168a-2c5b-4bda-85c7-d62f960f1e0c", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2908), null, null, false, false, null, "4dans", "ÇAÇA", null, null, 8, 1500, null },
                    { "721c4062-43d9-4d39-85f7-6f0119e1558f", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2898), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 8, 1500, null },
                    { "75402948-27fa-4d13-ac8b-b4130310dd21", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2884), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 8, 1500, null },
                    { "788489cf-6df7-40fa-b876-ef539538dade", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2929), null, null, false, false, null, "4dans", "GREASE", null, null, 8, 1500, null },
                    { "84095e86-1265-42cd-8ea9-b314d8fb28cd", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2630), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 8, 1500, null },
                    { "8b47b45e-3093-4540-8869-f2c777a84683", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2826), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 8, 1500, null },
                    { "9146fada-301d-429c-879b-d4b0e6e7066f", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2858), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "955ac722-3362-416c-9e83-9e3ddb080080", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2952), null, null, false, false, null, "4dans", "ROMAN KIR(1)", null, "ROMAN", 8, 1500, null },
                    { "96aaab6c-9913-45e8-a779-be7fc0e9f7cd", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2967), null, null, true, false, null, "4dans", "SALSA E", null, null, 8, 1500, null },
                    { "a49e8a05-230d-4acc-9339-3c6343270a83", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2779), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 8, 1500, null },
                    { "a57a9fa5-37f1-4f33-b7a7-f30b1cf1f98e", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2821), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 8, 1500, null },
                    { "a6cf0ca7-4384-40f3-9b0e-4ce86a4847d5", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2995), null, null, true, false, null, "2halkoyun", "AŞUK MAŞUK", "AKDENİZ", null, 14, 0, 1500 },
                    { "ac4d428b-b873-4f72-9cac-c3cecf94bcaa", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2942), null, null, false, false, null, "4dans", "ROMAN FUŞYA", null, "ROMAN", 8, 1500, null },
                    { "b092d75c-8739-42b6-bc71-61802c03d6e8", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2912), null, null, false, false, null, "4dans", "ÇİFTETELLİ PEMBE", null, null, 8, 1500, null },
                    { "b1d34a68-59d7-467e-9829-4ce22aa98c07", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2938), null, null, false, false, null, "4dans", "İSPANYOL", null, null, 8, 1500, null },
                    { "b8053909-bcab-471d-a4ab-48efc03cc62f", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2947), null, null, false, false, null, "4dans", "ROMAN KIRMIZI", null, "ROMAN", 8, 1500, null },
                    { "c374267e-bdbb-41b6-819a-9635bd8bcf37", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2863), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 8, 1500, null },
                    { "c5480631-56d2-4645-a062-331814ca436b", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2923), null, null, false, false, null, "4dans", "FRAK", null, null, 8, 1500, null },
                    { "c87cb4a0-2aa4-4f21-94a9-ec2cd5728b13", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2799), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "d6124c5f-06d1-40f6-8e1f-09325b4de549", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2957), null, null, false, false, null, "4dans", "ROMAN MOR", null, "ROMAN", 8, 1500, null },
                    { "d73d28e4-e038-479f-8501-5cee8f4499c0", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2853), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "d9659c1b-1953-4316-9d2d-647e4a3c7e11", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2973), null, null, true, false, null, "4dans", "STİLİZE KIRMIZI", null, null, 8, 1500, null },
                    { "e4692bbf-7c97-4bcd-9fa5-630e441125d2", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2816), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 8, 1500, null },
                    { "e778e29c-2542-4764-8348-a07e26fad73b", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2674), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 8, 1500, null },
                    { "e81542f3-2584-4e73-90a3-e3f32606fdc5", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2986), null, null, true, false, null, "4dans", "SALSA", null, null, 8, 0, 1500 },
                    { "ec0f1112-6ee2-47b2-aaac-adef43fd43f3", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2990), null, false, true, false, null, "4dans", "SALSA E", null, null, 8, 0, 1500 },
                    { "f1228a75-250d-4ba9-a906-6add87cef18c", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2888), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 8, 1500, null },
                    { "fd21e70a-db7f-4bf4-8d89-968e47b7e207", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2903), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 8, 1500, null },
                    { "fd9ec548-edc0-4d04-adbf-56234c2716d4", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2681), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "fe0ab5ef-89fd-410b-beec-f8008a99e582", 10, new DateTime(2024, 12, 14, 23, 11, 7, 349, DateTimeKind.Local).AddTicks(2961), null, null, true, false, null, "1boş", "SALSA", null, null, 8, 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 350, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 14, 23, 11, 7, 350, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "850f6f2d-8cce-4ea6-b119-bc64f01f7749", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 14, 23, 11, 7, 350, DateTimeKind.Local).AddTicks(4889), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "5f2bfee4-6132-40b8-bbc2-7cc3271211c9", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                keyValue: "1bc7e5cd-26d5-4c93-a6ae-d4df879b90ba");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "863fb516-f859-446d-a88c-f0581dc7d79d");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "af293261-9b20-439d-b19d-057da64c4639");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "d5b5cf74-3230-4ee2-a380-ffdc25d709b2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0126b076-7c63-4d17-8c34-f526d128f4e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "141ec255-9b4a-4c06-8ce0-3008fcd0c399");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1d586bc4-f1d1-4d92-9001-8f5431cc0f3a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f743518-04cc-4ecc-b110-f3e679a44408");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2100a61f-ff55-4cd2-9d51-1d4c9ec042e0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "26d63e4d-6ea7-4439-b9ad-edd7e784f50a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "29dccf20-080b-4e8a-943e-9a008a95544d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "302ff986-c581-49cb-8e3d-aa25052dc98f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "308b01ba-a3c0-4f5c-b057-6303f1b0196e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "31d2a508-bba0-445c-a155-ffee37269cb9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38fcc66e-0076-4a9e-b17b-439f716c397c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "467e1918-7f06-428a-9f74-e4f23adf3d91");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5439eaff-7bb1-44ea-acc9-2ed04e50945d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "60d88e97-c65d-41b3-8d23-3d363bc951a2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61ba1654-0b9c-42d0-9392-cb6f9563b622");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6ab4c655-77dc-4b3d-82d3-67d96fb6e40a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6ac6f20a-a68f-49f3-b374-76baefc8d463");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6fb1bb2c-357b-4877-b75e-4790ac6428c4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "71776438-d1ae-442e-a4b8-ca475b980657");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "71db168a-2c5b-4bda-85c7-d62f960f1e0c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "721c4062-43d9-4d39-85f7-6f0119e1558f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75402948-27fa-4d13-ac8b-b4130310dd21");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "788489cf-6df7-40fa-b876-ef539538dade");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "84095e86-1265-42cd-8ea9-b314d8fb28cd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8b47b45e-3093-4540-8869-f2c777a84683");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9146fada-301d-429c-879b-d4b0e6e7066f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "955ac722-3362-416c-9e83-9e3ddb080080");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "96aaab6c-9913-45e8-a779-be7fc0e9f7cd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a49e8a05-230d-4acc-9339-3c6343270a83");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a57a9fa5-37f1-4f33-b7a7-f30b1cf1f98e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a6cf0ca7-4384-40f3-9b0e-4ce86a4847d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ac4d428b-b873-4f72-9cac-c3cecf94bcaa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b092d75c-8739-42b6-bc71-61802c03d6e8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b1d34a68-59d7-467e-9829-4ce22aa98c07");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8053909-bcab-471d-a4ab-48efc03cc62f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c374267e-bdbb-41b6-819a-9635bd8bcf37");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5480631-56d2-4645-a062-331814ca436b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c87cb4a0-2aa4-4f21-94a9-ec2cd5728b13");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d6124c5f-06d1-40f6-8e1f-09325b4de549");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d73d28e4-e038-479f-8501-5cee8f4499c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d9659c1b-1953-4316-9d2d-647e4a3c7e11");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e4692bbf-7c97-4bcd-9fa5-630e441125d2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e778e29c-2542-4764-8348-a07e26fad73b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e81542f3-2584-4e73-90a3-e3f32606fdc5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ec0f1112-6ee2-47b2-aaac-adef43fd43f3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f1228a75-250d-4ba9-a906-6add87cef18c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fd21e70a-db7f-4bf4-8d89-968e47b7e207");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fd9ec548-edc0-4d04-adbf-56234c2716d4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fe0ab5ef-89fd-410b-beec-f8008a99e582");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "850f6f2d-8cce-4ea6-b119-bc64f01f7749");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "5f2bfee4-6132-40b8-bbc2-7cc3271211c9");

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
