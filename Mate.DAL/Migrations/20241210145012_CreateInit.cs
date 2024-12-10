using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FotoGaleries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotoGaleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdersSituation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Situation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersSituation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductRegions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubRegions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteCommInfos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    GSM = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkingHours = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    SocialMedias = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteCommInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GSM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    District = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsAdult = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    UnitPriceForSale = table.Column<int>(type: "int", maxLength: 100000, nullable: true),
                    UnitPriceForRent = table.Column<int>(type: "int", maxLength: 100000, nullable: false),
                    IsSale = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<bool>(type: "bit", maxLength: 20, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductRegionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductSubRegionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductRegions_ProductRegionId",
                        column: x => x.ProductRegionId,
                        principalTable: "ProductRegions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductSubRegions_ProductSubRegionId",
                        column: x => x.ProductSubRegionId,
                        principalTable: "ProductSubRegions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MainMenu",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CssName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    ParentMenuId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    RolesId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainMenu_MainMenu_ParentMenuId1",
                        column: x => x.ParentMenuId1,
                        principalTable: "MainMenu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MainMenu_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_UserInfos_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SituationName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_OrdersSituation_SituationName",
                        column: x => x.SituationName,
                        principalTable: "OrdersSituation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_UserInfos_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUserInfo",
                columns: table => new
                {
                    RolesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUserInfo", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUserInfo_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUserInfo_UserInfos_UsersId",
                        column: x => x.UsersId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BasketId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnitPriceForSale = table.Column<int>(type: "int", maxLength: 100000, nullable: false),
                    UnitPiceForRent = table.Column<int>(type: "int", maxLength: 100000, nullable: false),
                    ProductSize = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Amount = table.Column<int>(type: "int", maxLength: 500, nullable: false),
                    IsSale = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnitPriceForSale = table.Column<int>(type: "int", maxLength: 100000, nullable: false),
                    UnitPiceForRent = table.Column<int>(type: "int", maxLength: 100000, nullable: false),
                    ProductSize = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Amount = table.Column<int>(type: "int", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersDetail_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MainMenu",
                columns: new[] { "Id", "ActionName", "AreaName", "ClassName", "ControllerName", "CreatedAt", "CssName", "IconName", "MenuName", "OrderNo", "ParentMenuId", "ParentMenuId1", "RoleId", "RolesId" },
                values: new object[,]
                {
                    { "About", "", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2751), "", null, "About", null, null, null, 1, null },
                    { "Comm", "Comm", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2761), "", null, "Comm", null, null, null, 1, null },
                    { "Galery", "Galery", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2759), "", null, "Galery", null, null, null, 1, null },
                    { "Home", "Index", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2738), "", null, "Home", null, null, null, 1, null },
                    { "ProductRent", "ProductRent", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2754), "", null, "ProductRent", null, null, null, 1, null },
                    { "ProductSale", "ProductSale", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 10, 17, 50, 12, 495, DateTimeKind.Local).AddTicks(2756), "", null, "ProductSale", null, null, null, 1, null }
                });

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

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { "1boş", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(493), " " },
                    { "2halkoyun", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(512), "HALK OYUNLARI KIYAFETLERİ" },
                    { "3kına", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(518), "BİNDALLI VE KINA" },
                    { "4dans", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(522), "STİLİZE DANS" },
                    { "5rond", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(527), "ROND TÖREN" }
                });

            migrationBuilder.InsertData(
                table: "ProductRegions",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { "AKDENİZ", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8367), "AKDENİZ" },
                    { "DOGU ANADOLU", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8396), "DOGU ANADOLU" },
                    { "EGE", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8391), "EGE" },
                    { "GÜNEYDOGU ANADOLU", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8400), "GÜNEYDOGU ANADOLU" },
                    { "İÇ ANADOLU", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8404), "İÇ ANADOLU" },
                    { "KAFKAS", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8411), "KAFKAS" },
                    { "KARADENİZ", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8415), "KARADENİZ" },
                    { "MARMARA", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8419), "MARMARA" },
                    { "TRAKYA", new DateTime(2024, 12, 10, 17, 50, 12, 497, DateTimeKind.Local).AddTicks(8424), "TRAKYA" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubRegions",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { "ADIYAMAN", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(861), "ADIYAMAN" },
                    { "ANKARA", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(880), "ANKARA" },
                    { "ARTVİN", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(885), "ARTVİN" },
                    { "BİLECİK", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(889), "BİLECİK" },
                    { "BİTLİS", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(893), "BİTLİS" },
                    { "BOLU", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(899), "BOLU" },
                    { "BURDUR", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(907), "BURDUR" },
                    { "ÇİFTETELLİ", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(903), "ÇİFTETELLİ" },
                    { "DİYARBAKIR", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(913), "DİYARBAKIR" },
                    { "ELAZIĞ", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(917), "ELAZIĞ" },
                    { "GAZİANTEP", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(922), "GAZİANTEP" },
                    { "GİRESUN", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(927), "GİRESUN" },
                    { "HAKKARİ", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(931), "HAKKARİ" },
                    { "HALAY", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(935), "HALAY" },
                    { "ROMAN", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(939), "ROMAN" },
                    { "SİLİFKE", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(943), "SİLİFKE" },
                    { "TEKE", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(949), "TEKE" },
                    { "TRABZON", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(954), "TRABZON" },
                    { "ÜSKÜP", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(958), "ÜSKÜP" },
                    { "VAN", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(962), "VAN" },
                    { "ZEYBEK", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(966), "ZEYBEK" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "RoleName" },
                values: new object[,]
                {
                    { "ad", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(2981), "Admin" },
                    { "us", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(2999), "User" }
                });

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "CreatedAt", "Email", "GSM", "Phone", "SocialMedias", "WorkingHours" },
                values: new object[] { "2f532805-1d26-43de-be95-dc063ea45923", new DateTime(2024, 12, 10, 17, 50, 12, 498, DateTimeKind.Local).AddTicks(6182), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı\r\n\r\n0530 909 11 34 – Erdem\r\n\r\nİmalat\r\n\r\n0532 321 64 97 – İsmail\r\n0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "Hafta içi: 09:00 – 17:30\r\n\r\nCumartesi: 09:00 – 13:00" });

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_BasketId",
                table: "BasketDetails",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_ProductId",
                table: "BasketDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MainMenu_ParentMenuId1",
                table: "MainMenu",
                column: "ParentMenuId1");

            migrationBuilder.CreateIndex(
                name: "IX_MainMenu_RolesId",
                table: "MainMenu",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SituationName",
                table: "Orders",
                column: "SituationName");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetail_OrderId",
                table: "OrdersDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetail_ProductId",
                table: "OrdersDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_Name",
                table: "ProductCategories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductRegions_Name",
                table: "ProductRegions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductRegionId",
                table: "Products",
                column: "ProductRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSubRegionId",
                table: "Products",
                column: "ProductSubRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubRegions_Name",
                table: "ProductSubRegions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RoleName",
                table: "Roles",
                column: "RoleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleUserInfo_UsersId",
                table: "RoleUserInfo",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteCommInfos_Email",
                table: "SiteCommInfos",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiteCommInfos_GSM",
                table: "SiteCommInfos",
                column: "GSM",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiteCommInfos_Phone",
                table: "SiteCommInfos",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_Email",
                table: "UserInfos",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_GSM",
                table: "UserInfos",
                column: "GSM",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_TcNo",
                table: "UserInfos",
                column: "TcNo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketDetails");

            migrationBuilder.DropTable(
                name: "CommUsers");

            migrationBuilder.DropTable(
                name: "FotoGaleries");

            migrationBuilder.DropTable(
                name: "MainMenu");

            migrationBuilder.DropTable(
                name: "OrdersDetail");

            migrationBuilder.DropTable(
                name: "RoleUserInfo");

            migrationBuilder.DropTable(
                name: "SiteCommInfos");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "OrdersSituation");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductRegions");

            migrationBuilder.DropTable(
                name: "ProductSubRegions");
        }
    }
}
