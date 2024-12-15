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
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Comm",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Galery",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "Home",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductRent",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "MainMenu",
                keyColumn: "Id",
                keyValue: "ProductSale",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 509, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "0a581413-0c67-4ab8-8c75-9f9f2e48ff44", new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(7047), "Siparişiniz Kargoya verildi" },
                    { "0e20dd16-6655-4d7d-8942-77dc124b53ff", new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(7051), "Siparişiniz Tamamlandı" },
                    { "340b2c2d-ee3c-488e-b2de-88944cd574c2", new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(7042), "Siparişiniz Hazırlanıyor" },
                    { "3e779e25-0923-490f-81ab-df2c6b03832b", new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(6994), "Siparişiniz Alındı" }
                });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "1boş",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "2halkoyun",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "3kına",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "4dans",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: "5rond",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 511, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "AKDENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "DOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "EGE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "GÜNEYDOGU ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "İÇ ANADOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KAFKAS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "KARADENİZ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "MARMARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "ProductRegions",
                keyColumn: "Id",
                keyValue: "TRAKYA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ADIYAMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ANKARA",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ARTVİN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİLECİK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BİTLİS",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BOLU",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "BURDUR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÇİFTETELLİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "DİYARBAKIR",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ELAZIĞ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GAZİANTEP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "GİRESUN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HAKKARİ",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "HALAY",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ROMAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "SİLİFKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TEKE",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "TRABZON",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ÜSKÜP",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "VAN",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "ProductSubRegions",
                keyColumn: "Id",
                keyValue: "ZEYBEK",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "Size", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "00d1a858-1a3f-4fda-860a-45f9257b8cc2", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5839), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 8, 1500, null },
                    { "03529ba8-6948-445a-a8bf-d5a2b864b05b", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5824), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 8, 1500, null },
                    { "0396b6c5-af67-4ccf-a92f-9c9ea13319c0", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5813), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 8, 1500, null },
                    { "07011efa-6524-4edd-b91c-b7e14dd7ca81", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6230), null, false, true, false, "/databaseimg/HALKOYUN-VAN-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "0ce50e64-6a35-40ff-a274-2043b1581e45", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6004), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 8, 0, 1500 },
                    { "0e67b642-0c5a-440a-8a65-81f265de501c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6141), null, null, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 14, 1500, null },
                    { "0fc8197e-aef5-469d-a1ab-6e60955619d5", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5799), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 8, 1500, null },
                    { "150d3278-31be-42d8-94d2-d067b3ac9a4d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5970), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 8, 0, 1500 },
                    { "16fc0140-30b4-4cd3-be24-067820dbeb6c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6210), null, null, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "1c95f9d7-eeff-4aad-be05-2e56037a64cf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5665), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 8, 1500, null },
                    { "1ca0bcd3-86c9-4ee2-9084-f34019605346", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5885), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 8, 1500, null },
                    { "20143159-5369-4562-ba57-e369e9520b48", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5780), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 8, 1500, null },
                    { "21e92b44-6eb1-46e0-8d9b-e2b4c862819b", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6072), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 14, 1500, null },
                    { "231fb661-bbbe-4dac-bab7-4900ec51c6f4", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6245), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "24dec3f5-7988-48ba-9364-b1282efa7036", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5974), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 8, 0, 1500 },
                    { "25db851d-c05e-46ac-b90b-2c51c2d8253e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6158), null, true, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 14, 1500, null },
                    { "26fe5e28-1060-401a-a3c0-8a217dc91c06", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6095), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 14, 1500, null },
                    { "27829230-fa39-49f9-9aba-3d0d1d28594e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6106), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 14, 1500, null },
                    { "2d9d0dc9-37a4-45bd-a5dd-eb41d355f4f5", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5848), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 8, 1500, null },
                    { "329c0570-7598-4939-8f7a-1aac19d15975", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5709), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 8, 1500, null },
                    { "3cfddbb0-2663-4671-8ff3-712ac24b5889", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6047), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 14, 1500, null },
                    { "3d0a92bc-3106-44f4-b443-149c2fc895ba", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5980), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 8, 0, 1500 },
                    { "3d0f5b37-2d73-4db3-b6e9-35264b1601ac", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5804), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 8, 1500, null },
                    { "40483e35-48cf-4960-b51d-3548b0ec3eef", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5795), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 8, 1500, null },
                    { "411004ba-6ed7-4549-9dfe-f8605948765e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5914), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 8, 1500, null },
                    { "4156b015-5f67-4782-8263-9c69884d899d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6086), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 14, 1500, null },
                    { "444658cf-e84c-4b89-a625-2220d40cce86", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5890), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 8, 1500, null },
                    { "461b9443-2582-469d-b952-92f55bb6d00d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5689), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 8, 1500, null },
                    { "49eec1e2-af9b-4410-9e91-36f17b628851", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6185), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 14, 1500, null },
                    { "4c02c36b-b10c-4d66-97ff-f5aedd2d3358", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6042), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 14, 1500, null },
                    { "4cec16cd-f212-4ce3-a11e-20e713ab6ee9", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6196), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 14, 1500, null },
                    { "508e885c-3a4e-4a9b-8b19-d18dd0957468", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5844), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 8, 1500, null },
                    { "530fd436-ba4b-498c-bf8a-2d7df80417b1", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5739), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 8, 1500, null },
                    { "547c0c13-01f8-455d-aa99-ae478f22d4a9", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6117), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 14, 1500, null },
                    { "55d47038-0d47-433f-bddc-f3754ae11ddb", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5894), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 8, 1500, null },
                    { "5c005a5c-36e6-47b6-8fc0-d4ce9cc6da21", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6192), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 14, 1500, null },
                    { "5d422b5f-62da-44d2-8580-87c9aa6b4b4d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5937), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 8, 1500, null },
                    { "61cbc635-34f8-4b98-8f6c-6cfda91618bf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6056), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 14, 1500, null },
                    { "61d65e65-741b-4d37-ad55-524501038a7d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5654), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "62a2a7b9-f256-4c3a-98cd-eedbc02d4197", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5863), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 8, 1500, null },
                    { "6384c0bf-a202-4cba-8781-d5da88cbae6d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5852), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 8, 1500, null },
                    { "64645f17-f500-45dd-a34d-d2d73a639c6c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5774), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 8, 1500, null },
                    { "67ed74d9-da48-4e3c-badb-5b37db76b647", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6171), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "68447990-d592-4417-94d5-817dd9f345e8", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6167), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "6a84f992-8bce-4ff8-83cd-5cfd04a3b31b", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6126), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 14, 1500, null },
                    { "6a878e4f-03d0-43bc-b8b2-7db91a4401e5", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5809), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 8, 1500, null },
                    { "6aa220ed-3e43-4f64-9102-8a7eac1a4ef0", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5932), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 8, 1500, null },
                    { "6d546985-0380-442d-80ee-d3bdd3643684", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5995), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 8, 0, 1500 },
                    { "6f94be7a-0145-4d71-bbb6-e3431ba66ab9", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6000), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 8, 0, 1500 },
                    { "7266ed8d-bc61-4f9b-a340-e79f3168312c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6077), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 14, 1500, null },
                    { "727c9144-b957-451e-82a3-e0b5b00bc0f9", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5714), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "7310aafd-cafa-40ef-951f-28757cc89d15", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5943), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 8, 1500, null },
                    { "732b6177-a2a1-456f-9b93-59663384b2a6", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6260), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 14, 1500, null },
                    { "73e28867-1a9c-4716-aaec-fb7dcdad86ce", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6224), null, false, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "755db037-2139-47ce-9e55-4dd8930822fc", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6091), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 14, 1500, null },
                    { "75f46dc6-b1c4-42ff-8cff-d32ac1f20617", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5760), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "7805bd15-bda8-4916-9cc0-ee3add4a78aa", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5733), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 8, 1500, null },
                    { "7df91756-30eb-46ae-a4be-0b322ce38402", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5682), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 8, 1500, null },
                    { "809ce49d-3d66-42ea-9e3e-59f789fea71d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6146), null, null, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 14, 1500, null },
                    { "812422ff-9f1b-4ca6-9c46-994041fcfb8a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5881), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 8, 1500, null },
                    { "82c26033-7065-42da-b8ae-ebc84bd53cdc", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6032), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 14, 1500, null },
                    { "8d06b16a-c0af-4ff4-aa11-24856651fddf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5910), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 8, 1500, null },
                    { "959e6378-9efa-4b84-b7f6-80d1ad7589e7", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5764), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "9872f9de-1f03-4a97-abea-0a3fcf524d7b", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6027), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 14, 1500, null },
                    { "999efea5-3c4d-466b-8e01-76d5fc04969d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6176), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "9aecf701-8bdf-484e-8c67-4645d6b22d05", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6061), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 14, 1500, null },
                    { "9c71d876-d824-423d-8bd2-d4ca7e1497a5", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6241), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "9ef0d7b9-5535-4aa5-980c-d82359265a6d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5769), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 8, 1500, null },
                    { "a5f8a24c-d22d-417b-8552-b76c3fd11e30", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5785), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 8, 1500, null },
                    { "a74c926c-26b2-4af0-844e-46b9226c7224", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6219), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 14, 1500, null },
                    { "a7ff2ef8-49a6-4c1b-9ada-16f7140fa45f", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5671), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "ac5db831-3e1d-463e-a06f-1e951d5a0b97", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5877), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 8, 1500, null },
                    { "ac687d5f-fd30-43e0-bdb2-3220805b0e03", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5919), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 8, 1500, null },
                    { "acc7bf82-2056-45ef-bb02-b69712c7a822", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5696), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 8, 1500, null },
                    { "acca2e84-b6f7-40da-bf8e-2590b8350d4e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5830), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 8, 1500, null },
                    { "b0a00229-455e-47bf-b91f-4a2d600fb12d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6100), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 14, 1500, null },
                    { "b0c912a2-b5f7-4916-872b-ebcacdfb397e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6250), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "b132b9f3-ff1e-4c6d-8721-d249b6044758", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5872), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 8, 1500, null },
                    { "b4136ee7-d477-4561-b299-cf1fdc799f87", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5745), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 8, 1500, null },
                    { "b7589b08-c6de-462a-b1b9-8d2f7b11c5df", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6111), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 14, 1500, null },
                    { "b79659aa-0adf-40c1-94bb-475b8dee7d6a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6122), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 14, 1500, null },
                    { "b8dbf089-c937-47a9-941f-091f8cb216b0", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5659), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 8, 1500, null },
                    { "b9182a07-9242-4a8d-b002-16d10634ce23", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5990), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 8, 0, 1500 },
                    { "be716ac3-459e-4afe-b9c9-a66c2c4f0f17", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6181), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "c05a6568-c31b-42a1-8776-9181e0a5559c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5719), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 8, 1500, null },
                    { "c1e725b7-4e6c-4c95-9b23-8b9984a53f77", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5677), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 8, 1500, null },
                    { "c2472fcc-e49c-4ec7-bf31-4f6c1cf37849", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5900), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 8, 1500, null },
                    { "c3fb5f5e-5a49-4e21-8843-6d5efbce01cf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5965), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 8, 0, 1500 },
                    { "c57e52d2-7ede-4eaf-a8d3-f23d03085715", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6037), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpG", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 14, 1500, null },
                    { "c7ff0826-4134-4e47-b3ab-0464577f5991", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5627), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 8, 1500, null },
                    { "c88677ab-b32f-4313-8686-36215ca078ba", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5961), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 8, 0, 1500 },
                    { "c8bcebbc-585d-4c6a-865d-bc9b6e769398", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6215), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "c8f016cb-3072-4c2f-a867-88dbcb67bf3a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5728), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 8, 1500, null },
                    { "cb9a96e9-f216-49c6-9118-742bca8b1b7f", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6162), null, false, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 14, 1500, null },
                    { "cc1622c9-f670-4fd0-b43b-cfc791b74e7d", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6014), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 14, 1500, null },
                    { "cd6437ad-d6c9-4fd9-977c-8258a946ff35", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6236), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 14, 1500, null },
                    { "d0f91b9d-13db-41a0-ab96-93b8bb216b20", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6205), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 14, 1500, null },
                    { "d1052221-b786-44b7-909c-6a52138d28eb", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5857), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 8, 1500, null },
                    { "d21af49b-9255-4eef-9aad-2015be5eecbf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5647), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 8, 1500, null },
                    { "d3256ce4-8820-477b-9c23-f0473f30bbcf", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5986), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 8, 0, 1500 },
                    { "d584b540-aa55-4b68-95b7-709c0cb7feae", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5755), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 8, 1500, null },
                    { "d641c5c7-cd44-4812-a6a4-7ceeed270ae3", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5723), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 8, 1500, null },
                    { "e582de49-e65f-45cb-89fe-8f5450469b3a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6051), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ", "DOGU ANADOLU", "BİTLİS", 14, 1500, null },
                    { "e60f82b7-167c-48c3-a367-4a228ae78d3e", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6081), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 14, 1500, null },
                    { "e7d74b70-d72a-43f0-8fb5-81005dea146a", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6131), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 14, 1500, null },
                    { "ea8ca821-a085-497e-b0b1-645f963c1367", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5905), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 8, 1500, null },
                    { "eb47b780-813c-46d9-8be2-a912ee8aff37", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5834), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 8, 1500, null },
                    { "ecf00b7f-4a81-4dd6-81b0-ebb885ea9ce7", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5868), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 8, 1500, null },
                    { "ef924b3a-0a28-4340-9c55-49545db02952", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5948), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 8, 1500, null },
                    { "f75c301e-599c-4c64-a432-69890384d0d7", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6153), null, null, true, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 14, 1500, null },
                    { "f805d438-91a2-4225-86d6-fd4d3957430f", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5957), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 8, 0, 1500 },
                    { "f8e53933-48c8-49da-9864-b03792cacba6", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5928), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 8, 1500, null },
                    { "f9301541-c680-4451-a1a8-30cd8184162f", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6009), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 8, 0, 1500 },
                    { "fa606cc8-ae9a-4c81-ab99-c035a3fde49c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5749), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 8, 1500, null },
                    { "fb01ba02-5ec3-4583-9b52-c8c447ac5963", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5790), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 8, 1500, null },
                    { "fb7474f8-7a2f-476b-826b-a4c40f665077", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(5953), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 8, 1500, null },
                    { "fd28af3c-c1f7-40af-a2cb-9742b1b11006", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6067), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 14, 1500, null },
                    { "fe1ca323-a536-4a05-b563-bfa983ec396c", 10, new DateTime(2024, 12, 15, 13, 21, 44, 512, DateTimeKind.Local).AddTicks(6201), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 14, 1500, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "us",
                column: "CreatedAt",
                value: new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "ef3825da-f0af-44d3-9d45-2ecca7ec0ef9", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 15, 13, 21, 44, 513, DateTimeKind.Local).AddTicks(7549), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "b2c7931c-49a7-4830-a197-183547a13c25", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

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
                keyValue: "0a581413-0c67-4ab8-8c75-9f9f2e48ff44");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "0e20dd16-6655-4d7d-8942-77dc124b53ff");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "340b2c2d-ee3c-488e-b2de-88944cd574c2");

            migrationBuilder.DeleteData(
                table: "OrdersSituation",
                keyColumn: "Id",
                keyValue: "3e779e25-0923-490f-81ab-df2c6b03832b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "00d1a858-1a3f-4fda-860a-45f9257b8cc2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "03529ba8-6948-445a-a8bf-d5a2b864b05b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0396b6c5-af67-4ccf-a92f-9c9ea13319c0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "07011efa-6524-4edd-b91c-b7e14dd7ca81");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0ce50e64-6a35-40ff-a274-2043b1581e45");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0e67b642-0c5a-440a-8a65-81f265de501c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0fc8197e-aef5-469d-a1ab-6e60955619d5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "150d3278-31be-42d8-94d2-d067b3ac9a4d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "16fc0140-30b4-4cd3-be24-067820dbeb6c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1c95f9d7-eeff-4aad-be05-2e56037a64cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "1ca0bcd3-86c9-4ee2-9084-f34019605346");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "20143159-5369-4562-ba57-e369e9520b48");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "21e92b44-6eb1-46e0-8d9b-e2b4c862819b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "231fb661-bbbe-4dac-bab7-4900ec51c6f4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "24dec3f5-7988-48ba-9364-b1282efa7036");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "25db851d-c05e-46ac-b90b-2c51c2d8253e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "26fe5e28-1060-401a-a3c0-8a217dc91c06");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "27829230-fa39-49f9-9aba-3d0d1d28594e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2d9d0dc9-37a4-45bd-a5dd-eb41d355f4f5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "329c0570-7598-4939-8f7a-1aac19d15975");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3cfddbb0-2663-4671-8ff3-712ac24b5889");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d0a92bc-3106-44f4-b443-149c2fc895ba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3d0f5b37-2d73-4db3-b6e9-35264b1601ac");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40483e35-48cf-4960-b51d-3548b0ec3eef");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "411004ba-6ed7-4549-9dfe-f8605948765e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4156b015-5f67-4782-8263-9c69884d899d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "444658cf-e84c-4b89-a625-2220d40cce86");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "461b9443-2582-469d-b952-92f55bb6d00d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "49eec1e2-af9b-4410-9e91-36f17b628851");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4c02c36b-b10c-4d66-97ff-f5aedd2d3358");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4cec16cd-f212-4ce3-a11e-20e713ab6ee9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "508e885c-3a4e-4a9b-8b19-d18dd0957468");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "530fd436-ba4b-498c-bf8a-2d7df80417b1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "547c0c13-01f8-455d-aa99-ae478f22d4a9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "55d47038-0d47-433f-bddc-f3754ae11ddb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5c005a5c-36e6-47b6-8fc0-d4ce9cc6da21");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5d422b5f-62da-44d2-8580-87c9aa6b4b4d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61cbc635-34f8-4b98-8f6c-6cfda91618bf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "61d65e65-741b-4d37-ad55-524501038a7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "62a2a7b9-f256-4c3a-98cd-eedbc02d4197");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6384c0bf-a202-4cba-8781-d5da88cbae6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "64645f17-f500-45dd-a34d-d2d73a639c6c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "67ed74d9-da48-4e3c-badb-5b37db76b647");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "68447990-d592-4417-94d5-817dd9f345e8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6a84f992-8bce-4ff8-83cd-5cfd04a3b31b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6a878e4f-03d0-43bc-b8b2-7db91a4401e5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6aa220ed-3e43-4f64-9102-8a7eac1a4ef0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d546985-0380-442d-80ee-d3bdd3643684");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6f94be7a-0145-4d71-bbb6-e3431ba66ab9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7266ed8d-bc61-4f9b-a340-e79f3168312c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "727c9144-b957-451e-82a3-e0b5b00bc0f9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7310aafd-cafa-40ef-951f-28757cc89d15");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "732b6177-a2a1-456f-9b93-59663384b2a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "73e28867-1a9c-4716-aaec-fb7dcdad86ce");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "755db037-2139-47ce-9e55-4dd8930822fc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "75f46dc6-b1c4-42ff-8cff-d32ac1f20617");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7805bd15-bda8-4916-9cc0-ee3add4a78aa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7df91756-30eb-46ae-a4be-0b322ce38402");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "809ce49d-3d66-42ea-9e3e-59f789fea71d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "812422ff-9f1b-4ca6-9c46-994041fcfb8a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "82c26033-7065-42da-b8ae-ebc84bd53cdc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8d06b16a-c0af-4ff4-aa11-24856651fddf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "959e6378-9efa-4b84-b7f6-80d1ad7589e7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9872f9de-1f03-4a97-abea-0a3fcf524d7b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "999efea5-3c4d-466b-8e01-76d5fc04969d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9aecf701-8bdf-484e-8c67-4645d6b22d05");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9c71d876-d824-423d-8bd2-d4ca7e1497a5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9ef0d7b9-5535-4aa5-980c-d82359265a6d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a5f8a24c-d22d-417b-8552-b76c3fd11e30");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a74c926c-26b2-4af0-844e-46b9226c7224");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a7ff2ef8-49a6-4c1b-9ada-16f7140fa45f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ac5db831-3e1d-463e-a06f-1e951d5a0b97");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ac687d5f-fd30-43e0-bdb2-3220805b0e03");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "acc7bf82-2056-45ef-bb02-b69712c7a822");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "acca2e84-b6f7-40da-bf8e-2590b8350d4e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b0a00229-455e-47bf-b91f-4a2d600fb12d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b0c912a2-b5f7-4916-872b-ebcacdfb397e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b132b9f3-ff1e-4c6d-8721-d249b6044758");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b4136ee7-d477-4561-b299-cf1fdc799f87");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b7589b08-c6de-462a-b1b9-8d2f7b11c5df");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b79659aa-0adf-40c1-94bb-475b8dee7d6a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b8dbf089-c937-47a9-941f-091f8cb216b0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b9182a07-9242-4a8d-b002-16d10634ce23");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "be716ac3-459e-4afe-b9c9-a66c2c4f0f17");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c05a6568-c31b-42a1-8776-9181e0a5559c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c1e725b7-4e6c-4c95-9b23-8b9984a53f77");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c2472fcc-e49c-4ec7-bf31-4f6c1cf37849");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c3fb5f5e-5a49-4e21-8843-6d5efbce01cf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c57e52d2-7ede-4eaf-a8d3-f23d03085715");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c7ff0826-4134-4e47-b3ab-0464577f5991");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c88677ab-b32f-4313-8686-36215ca078ba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8bcebbc-585d-4c6a-865d-bc9b6e769398");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c8f016cb-3072-4c2f-a867-88dbcb67bf3a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cb9a96e9-f216-49c6-9118-742bca8b1b7f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cc1622c9-f670-4fd0-b43b-cfc791b74e7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "cd6437ad-d6c9-4fd9-977c-8258a946ff35");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d0f91b9d-13db-41a0-ab96-93b8bb216b20");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d1052221-b786-44b7-909c-6a52138d28eb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d21af49b-9255-4eef-9aad-2015be5eecbf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d3256ce4-8820-477b-9c23-f0473f30bbcf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d584b540-aa55-4b68-95b7-709c0cb7feae");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d641c5c7-cd44-4812-a6a4-7ceeed270ae3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e582de49-e65f-45cb-89fe-8f5450469b3a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e60f82b7-167c-48c3-a367-4a228ae78d3e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e7d74b70-d72a-43f0-8fb5-81005dea146a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ea8ca821-a085-497e-b0b1-645f963c1367");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "eb47b780-813c-46d9-8be2-a912ee8aff37");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ecf00b7f-4a81-4dd6-81b0-ebb885ea9ce7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef924b3a-0a28-4340-9c55-49545db02952");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f75c301e-599c-4c64-a432-69890384d0d7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f805d438-91a2-4225-86d6-fd4d3957430f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f8e53933-48c8-49da-9864-b03792cacba6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f9301541-c680-4451-a1a8-30cd8184162f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fa606cc8-ae9a-4c81-ab99-c035a3fde49c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb01ba02-5ec3-4583-9b52-c8c447ac5963");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fb7474f8-7a2f-476b-826b-a4c40f665077");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fd28af3c-c1f7-40af-a2cb-9742b1b11006");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fe1ca323-a536-4a05-b563-bfa983ec396c");

            migrationBuilder.DeleteData(
                table: "SiteCommInfos",
                keyColumn: "Id",
                keyValue: "ef3825da-f0af-44d3-9d45-2ecca7ec0ef9");

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: "b2c7931c-49a7-4830-a197-183547a13c25");

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
