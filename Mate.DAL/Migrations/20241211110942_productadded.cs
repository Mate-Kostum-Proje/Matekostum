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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 931, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 931, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 931, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 931, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 931, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 931, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "74042cda-161e-4c2d-9237-8235eed60b18", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(921), "Siparişiniz Kargoya verildi" },
                    { "8f56fdd8-8d3e-425f-b004-5154927c6111", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(926), "Siparişiniz Tamamlandı" },
                    { "a1825178-4c9b-4a1e-a1c2-7e13eee7b71c", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(910), "Siparişiniz Hazırlanıyor" },
                    { "c6285a1a-62de-46ca-ad43-4445e7b7e6ed", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(888), "Siparişiniz Alındı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "Size", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "0bd8e211-b5ef-4019-ae42-4e89ba21e968", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(191), null, null, true, false, null, "1boş", "SALSA", null, null, 8, 0, 1500 },
                    { "115682ff-f5db-4334-83ad-e84437b474b2", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(168), null, null, false, false, null, "4dans", "İSPANYOL", null, null, 8, 1500, null },
                    { "19510007-7044-4411-8d47-bdd0883068dc", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(71), null, null, false, false, null, "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 8, 1500, null },
                    { "19e2310f-0c07-4c2b-af77-643109ebdd31", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(173), null, null, false, false, null, "4dans", "ROMAN FUŞYA", null, "ROMAN", 8, 1500, null },
                    { "1a0f74c2-1e60-4033-83fa-3f601b010d48", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(100), null, null, false, false, null, "2halkoyun", "TRAKYA", "TRAKYA", null, 8, 1500, null },
                    { "1ca82c44-823b-4d58-aa3c-1c80b9667df7", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(61), null, null, false, false, null, "2halkoyun", "HALAY SİYAH", null, "HALAY", 8, 1500, null },
                    { "21af3091-ff9b-4073-9d90-f3e6ba57b55e", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(84), null, false, false, false, null, "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "229f51da-cfd8-40d1-934f-f32ae065a4a6", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(19), null, null, false, false, null, "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 8, 1500, null },
                    { "257fe55e-dbb6-4794-b4f2-4901fffacf75", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(205), null, null, true, false, null, "4dans", "STİLİZE MOR", null, null, 8, 0, 1500 },
                    { "2f4b7aa2-02c2-43bc-b0de-8bd107a0fea1", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(127), null, null, false, false, null, "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 8, 1500, null },
                    { "3128cd9a-cd27-42d1-992b-4d8b009a75a6", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(9965), null, true, false, false, null, "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "336e8ff5-71fb-4ba6-ab1c-17b05f3b8993", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(218), null, false, true, false, null, "4dans", "SALSA E", null, null, 8, 0, 1500 },
                    { "34673fa0-5433-438f-9b85-5c05673b9bae", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(161), null, null, false, false, null, "4dans", "HİNT", null, null, 8, 1500, null },
                    { "38ec02f8-3411-49bc-9570-1ccb3aac28b9", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(213), null, null, true, false, null, "4dans", "SALSA", null, null, 8, 0, 1500 },
                    { "3b5362e8-c0b3-41d1-9b1e-5e313825f507", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(9960), null, false, false, false, null, "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "3bdf5a7d-f0a7-482d-8699-e33df7c36e8f", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(80), null, null, false, false, null, "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 8, 1500, null },
                    { "429b725c-76b4-418a-b2a5-2b4ec899c402", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(107), null, null, false, false, null, "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 8, 1500, null },
                    { "4c6bfb73-3262-444a-9565-107bd1bdc7ab", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(66), null, null, false, false, null, "2halkoyun", "KARADENİZ", "KARADENİZ", null, 8, 1500, null },
                    { "547060b9-dcb1-418a-b979-07689f3b8525", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(147), null, null, false, false, null, "4dans", "ÇİFTETELLİ PEMBE", null, null, 8, 1500, null },
                    { "5cd70fa8-1da3-4212-b7ed-d158cab7baac", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(195), null, null, true, false, null, "4dans", "SALSA E", null, null, 8, 0, 1500 },
                    { "6119ff53-8830-4148-aa3a-7e0535a8d249", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(222), null, null, true, false, null, "2halkoyun", "AŞUK MAŞUK", "AKDENİZ", null, 14, 0, 1500 },
                    { "61d0afc9-d249-4010-a4a4-f1c705f24e09", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(135), null, null, false, false, null, "2halkoyun", "ZEYBEK KIRMIZI", "EGE", "ZEYBEK", 8, 1500, null },
                    { "63abd7d3-1db9-465b-9d60-543d9e85f06f", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(140), null, null, false, false, null, "4dans", "ÇAÇA", null, null, 8, 1500, null },
                    { "6407997f-2afe-49ca-8805-05a5355a47e9", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(187), null, null, false, false, null, "4dans", "ROMAN MOR", null, "ROMAN", 8, 1500, null },
                    { "65a3dced-0da3-4901-ab15-9214c85777cd", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(40), null, null, false, false, null, "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 8, 1500, null },
                    { "69d53b48-5ff0-4324-86e8-01e1ac6cbfda", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(9943), null, null, false, false, null, "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "798a0e9b-751e-4d10-bc2a-6a4f456107df", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(178), null, null, false, false, null, "4dans", "ROMAN KIRMIZI", null, "ROMAN", 8, 1500, null },
                    { "7a7ab6d2-be4c-414a-a610-1019395ad8b8", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(112), null, null, false, false, null, "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 8, 1500, null },
                    { "8d21a1d1-8c29-4e25-aa34-e94bc35a68e3", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(9948), null, null, false, false, null, "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 8, 1500, null },
                    { "8f0b4cd2-6570-4ddd-937a-5d68673bd304", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(210), null, null, true, false, null, "4dans", "STİLİZE PEMBE", null, null, 8, 0, 1500 },
                    { "91ac8a6c-fe15-4517-8f49-a1bdbf40c685", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(9939), null, null, false, false, null, "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "9641ced2-235e-4044-a30d-bf824b34e8ac", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(56), null, null, false, false, null, "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 8, 1500, null },
                    { "96dd2805-217e-42ec-a1b6-71c92fe8b778", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(157), null, null, false, false, null, "4dans", "GREASE", null, null, 8, 1500, null },
                    { "9c5f26ae-7727-44c2-adc7-883c42942980", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(52), null, false, false, false, null, "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "a9c0c692-d5b0-4fec-a97c-6750d72d0d3a", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(103), null, null, false, false, null, "2halkoyun", "TRAKYA BORDO", "TRAKYA", null, 8, 1500, null },
                    { "abd69acd-a9fa-4dae-8e4e-68d108fe6f72", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(131), null, null, false, false, null, "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 8, 1500, null },
                    { "aef5e643-9316-4f76-9d08-9c25bc0d25aa", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(25), null, true, false, false, null, "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "b4509563-43ab-40ce-a374-1eda570c5ee9", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(14), null, null, false, false, null, "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 8, 1500, null },
                    { "b7b37167-10aa-4135-b6ae-5c598c251e2e", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(116), null, false, false, false, null, "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 8, 1500, null },
                    { "ba6656e0-6c76-4e4b-9a4b-721ebf0b9e93", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(9933), null, null, false, false, null, "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 8, 1500, null },
                    { "ba8a77dc-920a-4f4a-b1d5-20517d78be6b", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(35), null, null, false, false, null, "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 8, 1500, null },
                    { "c9b880a0-09df-47f8-ab87-23fee61f8dcc", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(153), null, null, false, false, null, "4dans", "FRAK", null, null, 8, 1500, null },
                    { "d59bbe52-0111-4828-8b42-9688d6921059", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(182), null, null, false, false, null, "4dans", "ROMAN KIR(1)", null, "ROMAN", 8, 1500, null },
                    { "de02712e-934b-45bc-8cab-52d7d6da9643", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(121), null, null, false, false, null, "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 8, 1500, null },
                    { "dfd0e9dc-3f22-4f4b-b0a2-c5cea1bc6e72", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(95), null, null, false, false, null, "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "e3351366-c03e-4594-be56-9f23e35370cd", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(45), null, true, false, false, null, "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "e812641d-a6d4-486d-8ef1-30dcd6476969", new DateTime(2024, 12, 11, 14, 9, 41, 933, DateTimeKind.Local).AddTicks(9914), null, null, false, false, null, "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 8, 1500, null },
                    { "eead2db7-938a-4fbf-aad0-361d3dabecf1", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(200), null, null, true, false, null, "4dans", "STİLİZE KIRMIZI", null, null, 8, 0, 1500 },
                    { "f06ec824-6f70-4f37-91e2-e5db46016633", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(91), null, null, false, false, null, "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "f071099e-6ed1-4338-8fbc-93eeeb661a28", new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(75), null, null, false, false, null, "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 8, 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 11, 14, 9, 41, 934, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "CreatedAt", "Email", "GSM", "Phone", "SocialMedias", "WorkingHours" },
                values: new object[] { "091eb039-b38a-44a7-81e5-eb0b69594186", new DateTime(2024, 12, 11, 14, 9, 41, 935, DateTimeKind.Local).AddTicks(419), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı\r\n\r\n0530 909 11 34 – Erdem\r\n\r\nİmalat\r\n\r\n0532 321 64 97 – İsmail\r\n0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "Hafta içi: 09:00 – 17:30\r\n\r\nCumartesi: 09:00 – 13:00" });

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Id",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "74042cda-161e-4c2d-9237-8235eed60b18");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "8f56fdd8-8d3e-425f-b004-5154927c6111");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "a1825178-4c9b-4a1e-a1c2-7e13eee7b71c");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "c6285a1a-62de-46ca-ad43-4445e7b7e6ed");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0bd8e211-b5ef-4019-ae42-4e89ba21e968");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "115682ff-f5db-4334-83ad-e84437b474b2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19510007-7044-4411-8d47-bdd0883068dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "19e2310f-0c07-4c2b-af77-643109ebdd31");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a0f74c2-1e60-4033-83fa-3f601b010d48");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1ca82c44-823b-4d58-aa3c-1c80b9667df7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "21af3091-ff9b-4073-9d90-f3e6ba57b55e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "229f51da-cfd8-40d1-934f-f32ae065a4a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "257fe55e-dbb6-4794-b4f2-4901fffacf75");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2f4b7aa2-02c2-43bc-b0de-8bd107a0fea1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3128cd9a-cd27-42d1-992b-4d8b009a75a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "336e8ff5-71fb-4ba6-ab1c-17b05f3b8993");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "34673fa0-5433-438f-9b85-5c05673b9bae");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38ec02f8-3411-49bc-9570-1ccb3aac28b9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3b5362e8-c0b3-41d1-9b1e-5e313825f507");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3bdf5a7d-f0a7-482d-8699-e33df7c36e8f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "429b725c-76b4-418a-b2a5-2b4ec899c402");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c6bfb73-3262-444a-9565-107bd1bdc7ab");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "547060b9-dcb1-418a-b979-07689f3b8525");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5cd70fa8-1da3-4212-b7ed-d158cab7baac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6119ff53-8830-4148-aa3a-7e0535a8d249");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61d0afc9-d249-4010-a4a4-f1c705f24e09");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "63abd7d3-1db9-465b-9d60-543d9e85f06f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6407997f-2afe-49ca-8805-05a5355a47e9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "65a3dced-0da3-4901-ab15-9214c85777cd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69d53b48-5ff0-4324-86e8-01e1ac6cbfda");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "798a0e9b-751e-4d10-bc2a-6a4f456107df");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7a7ab6d2-be4c-414a-a610-1019395ad8b8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d21a1d1-8c29-4e25-aa34-e94bc35a68e3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f0b4cd2-6570-4ddd-937a-5d68673bd304");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91ac8a6c-fe15-4517-8f49-a1bdbf40c685");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9641ced2-235e-4044-a30d-bf824b34e8ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "96dd2805-217e-42ec-a1b6-71c92fe8b778");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c5f26ae-7727-44c2-adc7-883c42942980");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9c0c692-d5b0-4fec-a97c-6750d72d0d3a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "abd69acd-a9fa-4dae-8e4e-68d108fe6f72");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aef5e643-9316-4f76-9d08-9c25bc0d25aa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b4509563-43ab-40ce-a374-1eda570c5ee9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7b37167-10aa-4135-b6ae-5c598c251e2e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ba6656e0-6c76-4e4b-9a4b-721ebf0b9e93");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ba8a77dc-920a-4f4a-b1d5-20517d78be6b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c9b880a0-09df-47f8-ab87-23fee61f8dcc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d59bbe52-0111-4828-8b42-9688d6921059");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "de02712e-934b-45bc-8cab-52d7d6da9643");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dfd0e9dc-3f22-4f4b-b0a2-c5cea1bc6e72");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e3351366-c03e-4594-be56-9f23e35370cd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e812641d-a6d4-486d-8ef1-30dcd6476969");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eead2db7-938a-4fbf-aad0-361d3dabecf1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f06ec824-6f70-4f37-91e2-e5db46016633");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f071099e-6ed1-4338-8fbc-93eeeb661a28");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "091eb039-b38a-44a7-81e5-eb0b69594186");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

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
