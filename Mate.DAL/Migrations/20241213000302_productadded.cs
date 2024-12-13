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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 993, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 993, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 993, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 993, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 993, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 993, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "5c0fd4cf-6c91-4c0e-b2e8-7f9e20d45c83", new DateTime(2024, 12, 13, 3, 3, 1, 994, DateTimeKind.Local).AddTicks(5917), "Siparişiniz Kargoya verildi" },
                    { "a59c3c20-953a-413a-99a1-9e0b534697e3", new DateTime(2024, 12, 13, 3, 3, 1, 994, DateTimeKind.Local).AddTicks(5913), "Siparişiniz Hazırlanıyor" },
                    { "b577c300-44a3-4b35-9cbb-0d9cd1531bf4", new DateTime(2024, 12, 13, 3, 3, 1, 994, DateTimeKind.Local).AddTicks(5896), "Siparişiniz Alındı" },
                    { "cecb216d-2870-455d-b028-0d9919e6352d", new DateTime(2024, 12, 13, 3, 3, 1, 994, DateTimeKind.Local).AddTicks(5921), "Siparişiniz Tamamlandı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 994, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 994, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 994, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 994, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 994, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "Size", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "03904c37-ad39-4361-b76c-5e89dd415d85", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4744), null, null, true, false, null, "4dans", "SALSA", null, null, 8, 0, 1500 },
                    { "04d20f5f-6115-4a78-8a21-19e87a8ea2b9", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4718), null, null, false, false, null, "4dans", "ROMAN MOR", null, "ROMAN", 8, 1500, null },
                    { "0cb0eb95-89e9-4583-99c1-c9c64b71f76d", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4682), null, null, false, false, null, "4dans", "ÇİFTETELLİ PEMBE", null, null, 8, 1500, null },
                    { "10df88a6-9fba-4c9f-a1c7-b15c5496697d", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4632), null, null, false, false, null, "2halkoyun", "TRAKYA", "TRAKYA", null, 8, 1500, null },
                    { "1a0807aa-fa6e-45ec-91a1-04b1a2c132dc", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4653), null, false, false, false, null, "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 8, 1500, null },
                    { "1d4ade84-4814-42ec-8344-3f703fd5aa05", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4449), null, null, false, false, null, "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 8, 1500, null },
                    { "1e7f910a-e5a9-474c-80c6-9aa396daf47e", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4622), null, null, false, false, null, "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "1f061062-056c-4711-bc96-b01a6c3c3280", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4677), null, null, false, false, null, "4dans", "ÇAÇA", null, null, 8, 1500, null },
                    { "23c7348b-e0f5-41e0-91a7-1c8519ddd2de", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4493), null, false, false, false, null, "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "33d3151b-7fbd-42bd-a128-b13bbc8adc7c", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4722), null, null, true, false, null, "1boş", "SALSA", null, null, 8, 0, 1500 },
                    { "350ef8ec-1c38-41d9-a559-cbbf29be0a4d", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4662), null, null, false, false, null, "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 8, 1500, null },
                    { "36322e37-fe7f-4f62-8e53-fb32c239b76b", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4566), null, true, false, false, null, "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "38a2f730-4bbd-4e8a-aa79-dac1e89283e4", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4705), null, null, false, false, null, "4dans", "ROMAN FUŞYA", null, "ROMAN", 8, 1500, null },
                    { "38ac4ed3-70e7-4d9a-a99f-499872668294", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4641), null, null, false, false, null, "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 8, 1500, null },
                    { "38dcb4e9-7dda-415b-9cbd-3b6b95a0df92", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4645), null, null, false, false, null, "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 8, 1500, null },
                    { "417976ca-f9a1-406c-85f2-fde2dc62023b", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4555), null, null, false, false, null, "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 8, 1500, null },
                    { "4329f676-91cb-45f3-92e4-83e645f287e4", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4609), null, null, false, false, null, "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 8, 1500, null },
                    { "4f9f3268-581a-4674-bb53-44c8c6a0fa86", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4691), null, null, false, false, null, "4dans", "GREASE", null, null, 8, 1500, null },
                    { "5c5effb7-162c-4cf1-a264-b7a0a1015c1f", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4584), null, false, false, false, null, "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "5f465af2-364d-4d52-ae47-c2eff0c4acfa", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4481), null, null, false, false, null, "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 8, 1500, null },
                    { "5fe2bd49-216b-44a8-9ac5-d549936a6bcb", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4575), null, null, false, false, null, "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 8, 1500, null },
                    { "60679914-2ed1-4600-82cc-cdfa61699d71", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4595), null, null, false, false, null, "2halkoyun", "HALAY SİYAH", null, "HALAY", 8, 1500, null },
                    { "66156310-871d-490b-8e42-d82b4f7f7b90", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4473), null, null, false, false, null, "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "679eae65-bd83-4102-9e63-3d7c7bd1af82", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4599), null, null, false, false, null, "2halkoyun", "KARADENİZ", "KARADENİZ", null, 8, 1500, null },
                    { "67d3587f-c20f-4203-93e3-5c1bd23ce26c", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4628), null, null, false, false, null, "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "697d0e99-ec1e-4545-8e3c-9b283b4b9b28", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4477), null, null, false, false, null, "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "6be64b7c-7b1a-405d-af30-66efac6513ac", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4757), null, null, true, false, null, "2halkoyun", "AŞUK MAŞUK", "AKDENİZ", null, 14, 0, 1500 },
                    { "777b9e26-3088-4271-9a78-b825bdfcb448", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4740), null, null, true, false, null, "4dans", "STİLİZE PEMBE", null, null, 8, 0, 1500 },
                    { "833d7398-506c-4fea-b706-50c15c4bc7a5", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4570), null, null, false, false, null, "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 8, 1500, null },
                    { "83fa3ed4-75d5-4594-92b0-04dd3cd2e832", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4714), null, null, false, false, null, "4dans", "ROMAN KIR(1)", null, "ROMAN", 8, 1500, null },
                    { "84157f3c-a6af-406d-9bfd-707baa904409", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4617), null, false, false, false, null, "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "8594e570-7f25-4cfb-a045-1bd58c1210cb", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4560), null, null, false, false, null, "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 8, 1500, null },
                    { "91c217b3-1146-4a78-a41c-04c1a3ad0564", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4710), null, null, false, false, null, "4dans", "ROMAN KIRMIZI", null, "ROMAN", 8, 1500, null },
                    { "93f537d3-0d42-466f-9e99-11e6b4a649e6", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4591), null, null, false, false, null, "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 8, 1500, null },
                    { "9645fe52-bd1d-4c7f-a6f2-5796cf555f7b", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4467), null, null, false, false, null, "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 8, 1500, null },
                    { "9ef74cf6-2130-4b0e-9613-7359318a424b", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4668), null, null, false, false, null, "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 8, 1500, null },
                    { "a9e44f5f-c91d-4c83-b9fa-4f29fca84321", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4636), null, null, false, false, null, "2halkoyun", "TRAKYA BORDO", "TRAKYA", null, 8, 1500, null },
                    { "aaa94f8d-40f3-4735-bee4-cdb08c7781bb", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4734), null, null, true, false, null, "4dans", "STİLİZE MOR", null, null, 8, 0, 1500 },
                    { "af2d5053-a78f-4d5b-a829-fceff1fdcede", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4730), null, null, true, false, null, "4dans", "STİLİZE KIRMIZI", null, null, 8, 0, 1500 },
                    { "b6a9115d-e69f-41e0-9d15-db267d1d4440", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4503), null, true, false, false, null, "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "bd5cbbcc-68e1-423e-89dc-e87829d9e076", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4748), null, false, true, false, null, "4dans", "SALSA E", null, null, 8, 0, 1500 },
                    { "beb30351-35e9-4961-9f3d-483c68e0cb82", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4613), null, null, false, false, null, "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 8, 1500, null },
                    { "cbd0c9c6-8306-4a82-b10d-bd3876b07750", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4672), null, null, false, false, null, "2halkoyun", "ZEYBEK KIRMIZI", "EGE", "ZEYBEK", 8, 1500, null },
                    { "d1e92419-8b61-4372-ab33-df62c9ff8c9a", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4604), null, null, false, false, null, "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 8, 1500, null },
                    { "d28e3f10-c06b-406a-a21b-cacb0edf2f92", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4699), null, null, false, false, null, "4dans", "İSPANYOL", null, null, 8, 1500, null },
                    { "d4e42609-8cc0-4386-b225-8425bf22a2d7", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4694), null, null, false, false, null, "4dans", "HİNT", null, null, 8, 1500, null },
                    { "d60f4b7f-2735-4052-9a3f-1fe359b427dc", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4686), null, null, false, false, null, "4dans", "FRAK", null, null, 8, 1500, null },
                    { "ee4630af-f6ed-4571-b6a1-e644d62909e7", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4658), null, null, false, false, null, "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 8, 1500, null },
                    { "f493739f-076e-4812-8f71-24ece8b34bfd", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4579), null, true, false, false, null, "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "fc591b73-176c-4a90-a828-f0d1619bc336", new DateTime(2024, 12, 13, 3, 3, 1, 995, DateTimeKind.Local).AddTicks(4726), null, null, true, false, null, "4dans", "SALSA E", null, null, 8, 0, 1500 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 996, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 13, 3, 3, 1, 996, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "03d5160f-a374-44c6-99dc-d8d2264dae64", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 13, 3, 3, 1, 996, DateTimeKind.Local).AddTicks(5930), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

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
                keyValue: "5c0fd4cf-6c91-4c0e-b2e8-7f9e20d45c83");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "a59c3c20-953a-413a-99a1-9e0b534697e3");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "b577c300-44a3-4b35-9cbb-0d9cd1531bf4");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "cecb216d-2870-455d-b028-0d9919e6352d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "03904c37-ad39-4361-b76c-5e89dd415d85");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "04d20f5f-6115-4a78-8a21-19e87a8ea2b9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0cb0eb95-89e9-4583-99c1-c9c64b71f76d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "10df88a6-9fba-4c9f-a1c7-b15c5496697d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1a0807aa-fa6e-45ec-91a1-04b1a2c132dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1d4ade84-4814-42ec-8344-3f703fd5aa05");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1e7f910a-e5a9-474c-80c6-9aa396daf47e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f061062-056c-4711-bc96-b01a6c3c3280");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "23c7348b-e0f5-41e0-91a7-1c8519ddd2de");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "33d3151b-7fbd-42bd-a128-b13bbc8adc7c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "350ef8ec-1c38-41d9-a559-cbbf29be0a4d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "36322e37-fe7f-4f62-8e53-fb32c239b76b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38a2f730-4bbd-4e8a-aa79-dac1e89283e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38ac4ed3-70e7-4d9a-a99f-499872668294");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "38dcb4e9-7dda-415b-9cbd-3b6b95a0df92");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "417976ca-f9a1-406c-85f2-fde2dc62023b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4329f676-91cb-45f3-92e4-83e645f287e4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f9f3268-581a-4674-bb53-44c8c6a0fa86");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5c5effb7-162c-4cf1-a264-b7a0a1015c1f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5f465af2-364d-4d52-ae47-c2eff0c4acfa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5fe2bd49-216b-44a8-9ac5-d549936a6bcb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "60679914-2ed1-4600-82cc-cdfa61699d71");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "66156310-871d-490b-8e42-d82b4f7f7b90");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "679eae65-bd83-4102-9e63-3d7c7bd1af82");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "67d3587f-c20f-4203-93e3-5c1bd23ce26c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "697d0e99-ec1e-4545-8e3c-9b283b4b9b28");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6be64b7c-7b1a-405d-af30-66efac6513ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "777b9e26-3088-4271-9a78-b825bdfcb448");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "833d7398-506c-4fea-b706-50c15c4bc7a5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "83fa3ed4-75d5-4594-92b0-04dd3cd2e832");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "84157f3c-a6af-406d-9bfd-707baa904409");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8594e570-7f25-4cfb-a045-1bd58c1210cb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "91c217b3-1146-4a78-a41c-04c1a3ad0564");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "93f537d3-0d42-466f-9e99-11e6b4a649e6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9645fe52-bd1d-4c7f-a6f2-5796cf555f7b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9ef74cf6-2130-4b0e-9613-7359318a424b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a9e44f5f-c91d-4c83-b9fa-4f29fca84321");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aaa94f8d-40f3-4735-bee4-cdb08c7781bb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "af2d5053-a78f-4d5b-a829-fceff1fdcede");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b6a9115d-e69f-41e0-9d15-db267d1d4440");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd5cbbcc-68e1-423e-89dc-e87829d9e076");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "beb30351-35e9-4961-9f3d-483c68e0cb82");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cbd0c9c6-8306-4a82-b10d-bd3876b07750");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d1e92419-8b61-4372-ab33-df62c9ff8c9a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d28e3f10-c06b-406a-a21b-cacb0edf2f92");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d4e42609-8cc0-4386-b225-8425bf22a2d7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d60f4b7f-2735-4052-9a3f-1fe359b427dc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ee4630af-f6ed-4571-b6a1-e644d62909e7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f493739f-076e-4812-8f71-24ece8b34bfd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc591b73-176c-4a90-a828-f0d1619bc336");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "03d5160f-a374-44c6-99dc-d8d2264dae64");

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
