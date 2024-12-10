using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addedproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "6105e8f2-a089-4a35-9e62-469ce459590d");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "83612a90-58ba-49e5-8c88-1fa034473877");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "94de2dba-0199-464e-bdc0-40b4c2cd7804");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "e3a9b8d8-1479-45fe-8ba0-ed01cae6c0e5");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "2f532805-1d26-43de-be95-dc063ea45923");

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 881, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 881, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 881, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 881, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 881, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 881, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "24deb2ae-3741-4716-a672-ea00233f8fd8", new DateTime(2024, 12, 10, 17, 50, 46, 883, DateTimeKind.Local).AddTicks(2232), "Siparişiniz Kargoya verildi" },
                    { "74d03569-2a84-4072-b3df-b42e42c2178a", new DateTime(2024, 12, 10, 17, 50, 46, 883, DateTimeKind.Local).AddTicks(2210), "Siparişiniz Alındı" },
                    { "845d753a-67b6-4f43-a91b-28b5398abf3b", new DateTime(2024, 12, 10, 17, 50, 46, 883, DateTimeKind.Local).AddTicks(2237), "Siparişiniz Tamamlandı" },
                    { "9d7673d0-b858-417c-9e6b-b2440fc4039e", new DateTime(2024, 12, 10, 17, 50, 46, 883, DateTimeKind.Local).AddTicks(2226), "Siparişiniz Hazırlanıyor" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 883, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 883, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 883, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 883, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 883, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "Size", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "0550120b-c459-4973-a9cb-3396b74e1984", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1367), null, null, false, false, null, "4dans", "ROMAN FUŞYA", null, "ROMAN", 8, 1500, null },
                    { "1639776a-930d-4822-b6e2-d1f4c363671b", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1349), null, null, false, false, null, "4dans", "FRAK", null, null, 8, 1500, null },
                    { "1f5f20a5-a88b-4f81-a6bd-c21904103faf", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1344), null, null, false, false, null, "4dans", "ÇİFTETELLİ PEMBE", null, null, 8, 1500, null },
                    { "2bf19871-bc73-4e1d-8475-c89281e90628", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1358), null, null, false, false, null, "4dans", "HİNT", null, null, 8, 1500, null },
                    { "34a65b56-7b8a-4a66-adec-fa8fc6e2cd1c", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1281), null, null, false, false, null, "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "39665ec2-5c6d-4173-a346-e7ea3123fb24", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1322), null, null, false, false, null, "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 8, 1500, null },
                    { "3a8ae450-27eb-4148-a5dd-311d37cba966", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1403), null, null, true, false, null, "4dans", "STİLİZE MOR", "", null, 8, 0, 1500 },
                    { "3bdf4e34-7ec9-405b-82b4-340ffc0edb79", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1149), null, false, false, false, null, "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "48fb8d8c-3797-4179-be1b-99614e5daf0a", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1105), null, null, false, false, null, "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 8, 1500, null },
                    { "4b3d6592-b89b-4671-9fa2-90b1f68fb45e", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1333), null, null, false, false, null, "4dans", "ÇAÇA", null, null, 8, 1500, null },
                    { "4bfb9a1d-abf9-4f3c-afb7-1cb817bf7850", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1419), null, false, true, false, null, "4dans", "SALSA E", "", null, 8, 0, 1500 },
                    { "4f569def-1b6c-4aff-9037-3a187434cf5b", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1312), null, null, false, false, null, "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 8, 1500, null },
                    { "4f6f7e86-d2db-4bd4-8065-72ceb7de3b6a", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1297), null, null, false, false, null, "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 8, 1500, null },
                    { "4ff37020-0b94-4994-a43d-fdc27b37098a", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1271), null, false, false, false, null, "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "58dfd0bd-37fa-4663-a117-82e887be734d", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1414), null, null, true, false, null, "4dans", "SALSA", "", null, 8, 0, 1500 },
                    { "5a94cfd1-9529-42bc-9214-58d16cdb0b38", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1329), null, null, false, false, null, "2halkoyun", "ZEYBEK KIRMIZI", "EGE", "ZEYBEK", 8, 1500, null },
                    { "5c5781cf-5ca5-4955-9093-10e1e9b40a85", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1423), null, null, true, false, null, "2halkoyun", "AŞUK MAŞUK", "AKDENİZ", null, 14, 0, 1500 },
                    { "6e77a795-b148-4c1e-9185-2ac9006736c7", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1317), null, null, false, false, null, "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 8, 1500, null },
                    { "70842d8b-dc9d-4e1d-a35b-f853f49aedf7", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1373), null, null, false, false, null, "4dans", "ROMAN KIRMIZI", null, "ROMAN", 8, 1500, null },
                    { "791583dc-72b0-4323-bfa3-6e862b4ff198", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1192), null, null, false, false, null, "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 8, 1500, null },
                    { "7c8b35cd-1512-4986-ae67-61ab8f61825a", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1307), null, false, false, false, null, "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 8, 1500, null },
                    { "873ec8ad-6b74-449b-9ede-2becc0fa2e33", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1234), null, false, false, false, null, "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "923d56aa-fe39-4ba4-b341-81d5c4946c0e", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1136), null, null, false, false, null, "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "969cecec-d368-4cfc-972b-b92a31c8e81e", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1204), null, true, false, false, null, "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "98b048ba-ea90-4cf9-8a94-3dcf6e41d508", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1126), null, null, false, false, null, "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 8, 1500, null },
                    { "996729b1-17d7-4087-8df3-928540ec8d74", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1288), null, null, false, false, null, "2halkoyun", "TRAKYA", "TRAKYA", null, 8, 1500, null },
                    { "9b1997c6-e49b-49ae-a754-bcd68725d9cf", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1132), null, null, false, false, null, "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "9c49efa6-e739-41ec-a336-027cbfeecf28", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1378), null, null, false, false, null, "4dans", "ROMAN KIR(1)", null, "ROMAN", 8, 1500, null },
                    { "a0bd3512-8adc-4ee7-9afc-db65f9fd3772", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1209), null, null, false, false, null, "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 8, 1500, null },
                    { "a3693444-1be6-4b05-bdbc-657b76fd3701", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1362), null, null, false, false, null, "4dans", "İSPANYOL", null, null, 8, 1500, null },
                    { "aab9692b-8cb5-4926-a920-b1d3c2721d2b", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1407), null, null, true, false, null, "4dans", "STİLİZE PEMBE", "", null, 8, 0, 1500 },
                    { "aea5ee5e-0c7d-4ea0-b50e-6a7fc8a36a4d", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1266), null, null, false, false, null, "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 8, 1500, null },
                    { "b42e0f99-8df7-49c0-b84b-ca1b9c22778a", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1393), null, null, true, false, null, "4dans", "SALSA E", "", null, 8, 0, 1500 },
                    { "c03cdd8f-a635-4e35-8338-80446352320c", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1388), null, null, true, false, null, "", "SALSA", "", null, 8, 0, 1500 },
                    { "c3d53ae4-1ac7-456d-ac6e-14da623a65ac", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1239), null, null, false, false, null, "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 8, 1500, null },
                    { "c9a6edd3-e283-47d0-9fcf-009c13e17747", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1383), null, null, false, false, null, "4dans", "ROMAN MOR", null, "ROMAN", 8, 1500, null },
                    { "cc844487-0c7d-4f57-b0a9-9f5d1beced43", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1276), null, null, false, false, null, "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "da54332f-c84d-4701-978d-2de209ce9036", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1353), null, null, false, false, null, "4dans", "GREASE", null, null, 8, 1500, null },
                    { "dc0df92f-1d8a-4a9a-bbff-251a26c54677", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1262), null, null, false, false, null, "2halkoyun", "KAFKAS MOR", "KAFKAS", "KAFKAS", 8, 1500, null },
                    { "e547af44-7d1f-41ee-aad6-230c3b76e770", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1257), null, null, false, false, null, "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", "KAFKAS", 8, 1500, null },
                    { "e729f41b-7e55-4287-a82f-baf5b2a16c15", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1155), null, true, false, false, null, "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "e829c3d2-4050-48fd-935e-1ea9c082ef94", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1292), null, null, false, false, null, "2halkoyun", "TRAKYA BORDO", "TRAKYA", null, 8, 1500, null },
                    { "e834a373-6cc9-4d3c-8d55-cb69bfba5f7c", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1214), null, null, false, false, null, "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 8, 1500, null },
                    { "eba01a72-c89c-499d-bd65-9b6339df5653", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1197), null, null, false, false, null, "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 8, 1500, null },
                    { "f3b0d5e2-80d7-48b7-93c3-148d59bc37d5", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1142), null, null, false, false, null, "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 8, 1500, null },
                    { "f4b221c4-9169-4729-9697-8b435d72e026", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1229), null, true, false, false, null, "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "f562f631-864a-4ea4-ab2e-83a38e4a4493", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1302), null, null, false, false, null, "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 8, 1500, null },
                    { "f7495d59-4aae-40ff-afb3-4b23fa3bb5ac", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1251), null, null, false, false, null, "2halkoyun", "KARADENİZ", "KARADENİZ", null, 8, 1500, null },
                    { "f9675295-8162-4bd5-b77a-e8d128e82bb6", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1398), null, null, true, false, null, "4dans", "STİLİZE KIRMIZI", "", null, 8, 0, 1500 },
                    { "fccdee41-2dca-46d7-8dfe-4aeedaad769f", new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(1247), null, null, false, false, null, "2halkoyun", "HALAY SİYAH", null, "HALAY", 8, 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 46, 884, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "CreatedAt", "Email", "GSM", "Phone", "SocialMedias", "WorkingHours" },
                values: new object[] { "a3647365-62b9-4231-b7c3-9c6dc4488659", new DateTime(2024, 12, 10, 17, 50, 46, 885, DateTimeKind.Local).AddTicks(672), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı\r\n\r\n0530 909 11 34 – Erdem\r\n\r\nİmalat\r\n\r\n0532 321 64 97 – İsmail\r\n0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "Hafta içi: 09:00 – 17:30\r\n\r\nCumartesi: 09:00 – 13:00" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "24deb2ae-3741-4716-a672-ea00233f8fd8");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "74d03569-2a84-4072-b3df-b42e42c2178a");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "845d753a-67b6-4f43-a91b-28b5398abf3b");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "9d7673d0-b858-417c-9e6b-b2440fc4039e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0550120b-c459-4973-a9cb-3396b74e1984");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1639776a-930d-4822-b6e2-d1f4c363671b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1f5f20a5-a88b-4f81-a6bd-c21904103faf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2bf19871-bc73-4e1d-8475-c89281e90628");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "34a65b56-7b8a-4a66-adec-fa8fc6e2cd1c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "39665ec2-5c6d-4173-a346-e7ea3123fb24");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3a8ae450-27eb-4148-a5dd-311d37cba966");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3bdf4e34-7ec9-405b-82b4-340ffc0edb79");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "48fb8d8c-3797-4179-be1b-99614e5daf0a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4b3d6592-b89b-4671-9fa2-90b1f68fb45e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4bfb9a1d-abf9-4f3c-afb7-1cb817bf7850");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f569def-1b6c-4aff-9037-3a187434cf5b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4f6f7e86-d2db-4bd4-8065-72ceb7de3b6a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4ff37020-0b94-4994-a43d-fdc27b37098a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "58dfd0bd-37fa-4663-a117-82e887be734d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5a94cfd1-9529-42bc-9214-58d16cdb0b38");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5c5781cf-5ca5-4955-9093-10e1e9b40a85");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6e77a795-b148-4c1e-9185-2ac9006736c7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "70842d8b-dc9d-4e1d-a35b-f853f49aedf7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "791583dc-72b0-4323-bfa3-6e862b4ff198");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7c8b35cd-1512-4986-ae67-61ab8f61825a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "873ec8ad-6b74-449b-9ede-2becc0fa2e33");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "923d56aa-fe39-4ba4-b341-81d5c4946c0e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "969cecec-d368-4cfc-972b-b92a31c8e81e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "98b048ba-ea90-4cf9-8a94-3dcf6e41d508");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "996729b1-17d7-4087-8df3-928540ec8d74");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9b1997c6-e49b-49ae-a754-bcd68725d9cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c49efa6-e739-41ec-a336-027cbfeecf28");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a0bd3512-8adc-4ee7-9afc-db65f9fd3772");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a3693444-1be6-4b05-bdbc-657b76fd3701");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aab9692b-8cb5-4926-a920-b1d3c2721d2b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "aea5ee5e-0c7d-4ea0-b50e-6a7fc8a36a4d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b42e0f99-8df7-49c0-b84b-ca1b9c22778a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c03cdd8f-a635-4e35-8338-80446352320c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c3d53ae4-1ac7-456d-ac6e-14da623a65ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c9a6edd3-e283-47d0-9fcf-009c13e17747");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cc844487-0c7d-4f57-b0a9-9f5d1beced43");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "da54332f-c84d-4701-978d-2de209ce9036");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc0df92f-1d8a-4a9a-bbff-251a26c54677");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e547af44-7d1f-41ee-aad6-230c3b76e770");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e729f41b-7e55-4287-a82f-baf5b2a16c15");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e829c3d2-4050-48fd-935e-1ea9c082ef94");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e834a373-6cc9-4d3c-8d55-cb69bfba5f7c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eba01a72-c89c-499d-bd65-9b6339df5653");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f3b0d5e2-80d7-48b7-93c3-148d59bc37d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f4b221c4-9169-4729-9697-8b435d72e026");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f562f631-864a-4ea4-ab2e-83a38e4a4493");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f7495d59-4aae-40ff-afb3-4b23fa3bb5ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f9675295-8162-4bd5-b77a-e8d128e82bb6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fccdee41-2dca-46d7-8dfe-4aeedaad769f");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "a3647365-62b9-4231-b7c3-9c6dc4488659");

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "About",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "6105e8f2-a089-4a35-9e62-469ce459590d", new DateTime(2024, 12, 10, 17, 50, 12, 496, DateTimeKind.Local).AddTicks(8513), "Siparişiniz Alındı" },
                    { "83612a90-58ba-49e5-8c88-1fa034473877", new DateTime(2024, 12, 10, 17, 50, 12, 496, DateTimeKind.Local).AddTicks(8529), "Siparişiniz Hazırlanıyor" },
                    { "94de2dba-0199-464e-bdc0-40b4c2cd7804", new DateTime(2024, 12, 10, 17, 50, 12, 496, DateTimeKind.Local).AddTicks(8539), "Siparişiniz Kargoya verildi" },
                    { "e3a9b8d8-1479-45fe-8ba0-ed01cae6c0e5", new DateTime(2024, 12, 10, 17, 50, 12, 496, DateTimeKind.Local).AddTicks(8543), "Siparişiniz Tamamlandı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "CreatedAt", "Email", "GSM", "Phone", "SocialMedias", "WorkingHours" },
                values: new object[] { "2f532805-1d26-43de-be95-dc063ea45923", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(6182), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı\r\n\r\n0530 909 11 34 – Erdem\r\n\r\nİmalat\r\n\r\n0532 321 64 97 – İsmail\r\n0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "Hafta içi: 09:00 – 17:30\r\n\r\nCumartesi: 09:00 – 13:00" });
        }
    }
}
