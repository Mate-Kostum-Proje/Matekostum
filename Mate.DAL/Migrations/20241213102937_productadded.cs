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

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "CommUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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
                value: new DateTime(2024, 12, 13, 13, 29, 36, 673, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 673, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 673, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 673, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 673, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 673, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "312351fb-b598-4d11-8c2e-f7d8020f4204", new DateTime(2024, 12, 13, 13, 29, 36, 675, DateTimeKind.Local).AddTicks(3659), "Siparişiniz Kargoya verildi" },
                    { "d16adadc-dd82-4bb4-882d-eb0c8a0aae8d", new DateTime(2024, 12, 13, 13, 29, 36, 675, DateTimeKind.Local).AddTicks(3663), "Siparişiniz Tamamlandı" },
                    { "e2b4a391-300a-4007-836a-a089f4643b93", new DateTime(2024, 12, 13, 13, 29, 36, 675, DateTimeKind.Local).AddTicks(3637), "Siparişiniz Alındı" },
                    { "faad7bbe-51e3-40b3-b89e-32f433d7f6dc", new DateTime(2024, 12, 13, 13, 29, 36, 675, DateTimeKind.Local).AddTicks(3654), "Siparişiniz Hazırlanıyor" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 675, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 675, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 675, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 675, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 675, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "Size", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "07b5cbb6-a8aa-4799-a998-2c9d429e611c", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2812), null, null, false, false, null, "2halkoyun", "ZEYBEK KIRMIZI", "EGE", "ZEYBEK", 8, 1500, null },
                    { "09c8da03-b3bb-43fd-a794-866597ddeeda", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2795), null, null, false, false, null, "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 8, 1500, null },
                    { "0bc9fee5-43a4-4be5-9507-72f255415c66", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2681), null, null, false, false, null, "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 8, 1500, null },
                    { "0d9e5682-0ea5-43d5-a039-e9c4d7a86e15", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2859), null, null, false, false, null, "4dans", "ROMAN KIR(1)", null, "ROMAN", 8, 1500, null },
                    { "14935d1a-463c-4909-a05c-0588d583274b", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2785), null, null, false, false, null, "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 8, 1500, null },
                    { "1e426275-e15f-4f17-b2e2-eb0ec44b2270", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2873), null, null, true, false, null, "4dans", "SALSA E", null, null, 8, 0, 1500 },
                    { "20626b29-37f8-4f35-8f17-83205d42baaa", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2759), null, null, false, false, null, "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "233cbec4-710a-40ee-9d1c-88bd25bfbfbd", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2790), null, false, false, false, null, "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 8, 1500, null },
                    { "2f6b2146-660d-4bba-9ddc-f1a0d6edbe72", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2827), null, null, false, false, null, "4dans", "FRAK", null, null, 8, 1500, null },
                    { "3410fa66-ce6c-4653-9d43-0bfc9f0126c6", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2753), null, null, false, false, null, "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "379717d5-e7fb-4e90-82e7-e6e363341680", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2675), null, null, false, false, null, "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 8, 1500, null },
                    { "46334fc7-4964-48b2-ac7b-d5cd09aede9d", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2889), null, null, true, false, null, "4dans", "STİLİZE PEMBE", null, null, 8, 0, 1500 },
                    { "468ecd73-a1e1-4ba5-9c83-df483fe916c3", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2624), null, true, false, false, null, "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "5266982f-a9b7-4c02-bd61-f6d0edb25946", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2877), null, null, true, false, null, "4dans", "STİLİZE KIRMIZI", null, null, 8, 0, 1500 },
                    { "571f30cc-a526-4961-a917-8e5907a87ffa", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2907), null, null, true, false, null, "2halkoyun", "AŞUK MAŞUK", "AKDENİZ", null, 14, 0, 1500 },
                    { "5ce23cf7-a6bb-42a5-80b6-739b26fc0aee", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2590), null, null, false, false, null, "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "5d4ad7e8-41df-4074-8f30-5f7774057f61", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2837), null, null, false, false, null, "4dans", "HİNT", null, null, 8, 1500, null },
                    { "64cc418d-e754-47d2-a593-671b2f1a110c", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2817), null, null, false, false, null, "4dans", "ÇAÇA", null, null, 8, 1500, null },
                    { "71d96ddc-8cc6-4fc5-a206-52339f4da7fb", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2864), null, null, false, false, null, "4dans", "ROMAN MOR", null, "ROMAN", 8, 1500, null },
                    { "7fd8b36e-ab94-4ffc-8a4d-8d2e679e5417", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2884), null, null, true, false, null, "4dans", "STİLİZE MOR", null, null, 8, 0, 1500 },
                    { "87df88a4-0841-4fa4-9914-c616e3a3853c", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2731), null, null, false, false, null, "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 8, 1500, null },
                    { "8f76b7d7-18af-4ff6-95c8-13c341912978", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2585), null, null, false, false, null, "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "90aee0b6-b934-4ffc-8ea1-096bc9b38ba9", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2844), null, null, false, false, null, "4dans", "İSPANYOL", null, null, 8, 1500, null },
                    { "9158d85a-1475-4694-8143-750f749440ef", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2765), null, null, false, false, null, "2halkoyun", "TRAKYA", "TRAKYA", null, 8, 1500, null },
                    { "92f42bfd-54d7-4488-8781-c332a9939c99", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2807), null, null, false, false, null, "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 8, 1500, null },
                    { "990815af-e318-4d9c-8ea7-6ffa231f4908", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2726), null, null, false, false, null, "2halkoyun", "KARADENİZ", "KARADENİZ", null, 8, 1500, null },
                    { "99b2a5a6-6eda-4e8d-b00e-c28a4bfa0b85", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2780), null, null, false, false, null, "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 8, 1500, null },
                    { "9a220289-6da1-4688-8166-cd6a417d05d3", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2721), null, null, false, false, null, "2halkoyun", "HALAY SİYAH", null, "HALAY", 8, 1500, null },
                    { "9bcac092-5b77-45c6-afbf-554621040dd2", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2855), null, null, false, false, null, "4dans", "ROMAN KIRMIZI", null, "ROMAN", 8, 1500, null },
                    { "a1cbb507-dc32-4d23-9188-b61ca6657bf6", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2736), null, null, false, false, null, "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 8, 1500, null },
                    { "a92264af-9198-4d5d-a55d-5dd1418dc3bb", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2560), null, null, false, false, null, "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 8, 1500, null },
                    { "acc753a4-9ddd-4ae2-9dbb-47491fc6e72e", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2898), null, null, true, false, null, "4dans", "SALSA", null, null, 8, 0, 1500 },
                    { "ad64b506-6fba-43fe-a770-9c6303cf1c1b", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2903), null, false, true, false, null, "4dans", "SALSA E", null, null, 8, 0, 1500 },
                    { "af8a1faa-4664-4117-a774-41e6c02a7c93", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2688), null, true, false, false, null, "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "b38cded1-deb6-4000-aec5-c25806e24143", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2711), null, false, false, false, null, "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "b444ffea-9a9b-43fc-8f6b-36fe52b69902", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2605), null, null, false, false, null, "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 8, 1500, null },
                    { "b6f67586-3c9b-4d31-9bc0-3db797858174", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2698), null, null, false, false, null, "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 8, 1500, null },
                    { "c6483eeb-2916-4292-81af-96ca7d7e3694", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2716), null, null, false, false, null, "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 8, 1500, null },
                    { "d24cad18-83f9-4294-a541-f1a15afd0a8e", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2619), null, false, false, false, null, "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "d60cabaf-2b96-4c0f-befd-22f85209c4ad", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2746), null, false, false, false, null, "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "d8a5ebd9-a1dc-437b-a1da-89d989644426", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2741), null, null, false, false, null, "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 8, 1500, null },
                    { "d9058b9a-00e4-41ef-8e55-35c67c5dbb9e", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2868), null, null, true, false, null, "1boş", "SALSA", null, null, 8, 0, 1500 },
                    { "dc66e16d-c830-4784-88fe-1cf8cca58c60", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2579), null, null, false, false, null, "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 8, 1500, null },
                    { "dd9a0e5b-164d-4ea8-8527-6b9f061bec6e", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2822), null, null, false, false, null, "4dans", "ÇİFTETELLİ PEMBE", null, null, 8, 1500, null },
                    { "dec8acff-778d-46b4-a7f4-cb384c58a219", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2833), null, null, false, false, null, "4dans", "GREASE", null, null, 8, 1500, null },
                    { "e86db530-ac7b-4e63-9ff5-13e7d6b07aec", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2693), null, null, false, false, null, "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 8, 1500, null },
                    { "eb324383-fa54-4f78-8c3b-5b9beb08df7f", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2704), null, true, false, false, null, "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "f8764619-c26d-4c08-a719-943cd27ced52", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2850), null, null, false, false, null, "4dans", "ROMAN FUŞYA", null, "ROMAN", 8, 1500, null },
                    { "fdb8b882-02ae-4198-b761-63bd06c024c2", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2769), null, null, false, false, null, "2halkoyun", "TRAKYA BORDO", "TRAKYA", null, 8, 1500, null },
                    { "ff849228-a57c-4613-8f32-b459c4392041", 10, new DateTime(2024, 12, 13, 13, 29, 36, 676, DateTimeKind.Local).AddTicks(2802), null, null, false, false, null, "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 8, 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 677, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 13, 29, 36, 677, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "085c1f0f-f921-4c04-bec3-0fcce58dd20c", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 13, 13, 29, 36, 677, DateTimeKind.Local).AddTicks(5304), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

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
                keyValue: "312351fb-b598-4d11-8c2e-f7d8020f4204");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "d16adadc-dd82-4bb4-882d-eb0c8a0aae8d");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "e2b4a391-300a-4007-836a-a089f4643b93");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "faad7bbe-51e3-40b3-b89e-32f433d7f6dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "07b5cbb6-a8aa-4799-a998-2c9d429e611c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09c8da03-b3bb-43fd-a794-866597ddeeda");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0bc9fee5-43a4-4be5-9507-72f255415c66");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0d9e5682-0ea5-43d5-a039-e9c4d7a86e15");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "14935d1a-463c-4909-a05c-0588d583274b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1e426275-e15f-4f17-b2e2-eb0ec44b2270");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "20626b29-37f8-4f35-8f17-83205d42baaa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "233cbec4-710a-40ee-9d1c-88bd25bfbfbd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2f6b2146-660d-4bba-9ddc-f1a0d6edbe72");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3410fa66-ce6c-4653-9d43-0bfc9f0126c6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "379717d5-e7fb-4e90-82e7-e6e363341680");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "46334fc7-4964-48b2-ac7b-d5cd09aede9d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "468ecd73-a1e1-4ba5-9c83-df483fe916c3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5266982f-a9b7-4c02-bd61-f6d0edb25946");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "571f30cc-a526-4961-a917-8e5907a87ffa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5ce23cf7-a6bb-42a5-80b6-739b26fc0aee");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5d4ad7e8-41df-4074-8f30-5f7774057f61");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64cc418d-e754-47d2-a593-671b2f1a110c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "71d96ddc-8cc6-4fc5-a206-52339f4da7fb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7fd8b36e-ab94-4ffc-8a4d-8d2e679e5417");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "87df88a4-0841-4fa4-9914-c616e3a3853c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f76b7d7-18af-4ff6-95c8-13c341912978");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "90aee0b6-b934-4ffc-8ea1-096bc9b38ba9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9158d85a-1475-4694-8143-750f749440ef");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "92f42bfd-54d7-4488-8781-c332a9939c99");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "990815af-e318-4d9c-8ea7-6ffa231f4908");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "99b2a5a6-6eda-4e8d-b00e-c28a4bfa0b85");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9a220289-6da1-4688-8166-cd6a417d05d3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9bcac092-5b77-45c6-afbf-554621040dd2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a1cbb507-dc32-4d23-9188-b61ca6657bf6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a92264af-9198-4d5d-a55d-5dd1418dc3bb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "acc753a4-9ddd-4ae2-9dbb-47491fc6e72e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ad64b506-6fba-43fe-a770-9c6303cf1c1b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "af8a1faa-4664-4117-a774-41e6c02a7c93");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b38cded1-deb6-4000-aec5-c25806e24143");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b444ffea-9a9b-43fc-8f6b-36fe52b69902");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6f67586-3c9b-4d31-9bc0-3db797858174");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c6483eeb-2916-4292-81af-96ca7d7e3694");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d24cad18-83f9-4294-a541-f1a15afd0a8e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d60cabaf-2b96-4c0f-befd-22f85209c4ad");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d8a5ebd9-a1dc-437b-a1da-89d989644426");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d9058b9a-00e4-41ef-8e55-35c67c5dbb9e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc66e16d-c830-4784-88fe-1cf8cca58c60");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dd9a0e5b-164d-4ea8-8527-6b9f061bec6e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dec8acff-778d-46b4-a7f4-cb384c58a219");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e86db530-ac7b-4e63-9ff5-13e7d6b07aec");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb324383-fa54-4f78-8c3b-5b9beb08df7f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f8764619-c26d-4c08-a719-943cd27ced52");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fdb8b882-02ae-4198-b761-63bd06c024c2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ff849228-a57c-4613-8f32-b459c4392041");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "085c1f0f-f921-4c04-bec3-0fcce58dd20c");

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
