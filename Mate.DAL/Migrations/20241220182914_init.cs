using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommUsers", x => x.Id);
                });

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
                name: "FotoGaleries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    GSM1 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    GSM2 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    GSM3 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Transportation = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    WorkingHours = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    SocialMedias = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteCommInfos", x => x.Id);
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    UnitPriceForSale = table.Column<int>(type: "int", maxLength: 100000, nullable: true),
                    UnitPriceForRent = table.Column<int>(type: "int", maxLength: 100000, nullable: false),
                    IsSale = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<bool>(type: "bit", maxLength: 20, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    ProductCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductRegionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductSubRegionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                name: "UsersRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UsersRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersRoles_UserInfos_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                table: "FotoDesign",
                columns: new[] { "Id", "CreatedAt", "Name", "PhotoPath" },
                values: new object[,]
                {
                    { "05e2b356-0ccf-4f79-b529-dffd3edb2c37", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5051), "AŞUK", "/databaseimg/tasarım/tasarımAŞUK.jpg" },
                    { "6fc0746e-91d9-4529-9b0f-0e29bbf5b232", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5031), "SALSA K", "/databaseimg/tasarım/tasarımSALSA-K.jpg" },
                    { "77679b49-24df-4e94-9c4c-f1024d64b299", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5007), "ÇİFTETELLİ MAVİ", "/databaseimg/tasarım/tasarımÇİFTETELLİ-MAVİ.jpg" },
                    { "965ba1ac-81b0-46c3-87e8-509987a127e5", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(4956), "STİLİZE E2", "/databaseimg/tasarım/tasarımSTİLİZE-E2.jpg" },
                    { "b0d9c708-00a7-4a67-b248-ca8948e51dd1", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5017), "İSPANYOL K", "/databaseimg/tasarım/tasarımİSPANYOL-K.jpg" },
                    { "b9e75693-4de5-494d-bdad-2e7dc6184a18", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5027), "MAŞUK", "/databaseimg/tasarım/tasarımMAŞUK.jpg" },
                    { "c194456b-4472-445b-a419-8e9b59c928e8", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5054), "FLAMENKO", "/databaseimg/tasarım/tasarımFLAMENKO.jpg" },
                    { "c78e69ef-cac0-4e39-9fb5-515c8b40ef4b", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5021), "YENİÇERİ", "/databaseimg/tasarım/tasarımYENİÇERİ-2.jpg" },
                    { "d367cf63-31d0-4703-ad55-759ab2b78e9f", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5046), "STİLİZE E", "/databaseimg/tasarım/tasarımSTİLİZE-E.jpg" },
                    { "dd1ac396-f503-4e70-826c-06be45570e50", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5035), "ŞAMAN", "/databaseimg/tasarım/tasarımŞAMAN.jpg" },
                    { "f0298a6e-708b-4ed7-aa0c-9a89bc5b16d5", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5041), "OSMANLI", "/databaseimg/tasarım/tasarımOSMANLI.jpg" },
                    { "f16a1fbb-ca54-4637-9548-560e9fe0f20c", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(5013), "ROMAN T", "/databaseimg/tasarım/tasarımROMAN-T.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FotoGaleries",
                columns: new[] { "Id", "CreatedAt", "PhotoPath" },
                values: new object[,]
                {
                    { "12f03b54-6302-47c2-be44-b1c6c4e61e67", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7241), "/databaseimg/galeri/galerigümüşhane-erk-bar.jpg" },
                    { "1cb9ecc2-dd89-4be0-aec3-2f28e8495280", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7248), "/databaseimg/galeri/galerigümüşhne-erk-horon.jpg" },
                    { "26a2d3cd-51a7-478e-b57d-4eb52d13704d", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7189), "/databaseimg/galeri/galeriGaziantep-Kostum.jpg" },
                    { "2b76a91c-318e-4b7f-ae15-3683fa322b9c", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7261), "/databaseimg/galeri/galerigiresun-2.jpg" },
                    { "3acabd4e-e129-4329-a62f-3faa11baaf07", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7289), "/databaseimg/galeri/galeriwimg_0201.jpeg" },
                    { "5462d384-5e1c-4ff5-b750-72058887228f", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7215), "/databaseimg/galeri/galeriIMG_4063.jpg" },
                    { "5c897d1f-112a-4fca-9b9c-c2bf8a3ef65d", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7206), "/databaseimg/galeri/galeriIMG_2356.jpg" },
                    { "5dc54f6a-f71f-4292-ab3a-177dd3c0d816", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7228), "/databaseimg/galeri/galeriIMG_1961.jpg" },
                    { "7cdc4c97-6632-4a7b-b287-b90aaa376f85", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7272), "/databaseimg/galeri/galeriIMG_1012.jpg" },
                    { "8571a957-66f4-4653-b433-1137ea7cc928", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7285), "/databaseimg/galeri/galeriIMG_8455.jpg" },
                    { "8906bca4-ee82-4184-a715-48550d9a39b7", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7219), "/databaseimg/galeri/galeriIMG_1964.jpg" },
                    { "8d6f03e7-5a39-4eeb-b253-a16bfa5acbdd", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7193), "/databaseimg/galeri/galeriyoresel-kostum.jpg" },
                    { "8e1d4f7d-021c-4a77-b4d5-e276ce497d72", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7256), "/databaseimg/galeri/galerizeyb.jpg" },
                    { "b0dfb812-e36a-4b82-a579-348ad84d1bbe", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7197), "/databaseimg/galeri/galerikaradeniz-kostumu.jpg" },
                    { "b5372270-9cb2-422c-acc5-e98843db8010", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7276), "/databaseimg/galeri/galeriIMG-8454.jpg" },
                    { "ba2f7456-beba-4665-8ad1-058520bdf625", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7281), "/databaseimg/galeri/galeriIMG_8456.jpg" },
                    { "c1854f9d-404b-47ed-9475-20ab53f9c90f", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7252), "/databaseimg/galeri/galeriDMID3671.jpg" },
                    { "ceb0ea7b-4f90-45a1-93b0-3a8a412721c1", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7293), "/databaseimg/galeri/galeriIMG_2688.jpg" },
                    { "d502c5c8-c39a-4a35-aa47-b4130270a453", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7223), "/databaseimg/galeri/galeriIMG_1962.jpg" },
                    { "d890a3ab-5c2f-438b-b86d-982f4866d942", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7212), "/databaseimg/galeri/galeriIMG_1958.jpg" },
                    { "d9a1549d-7166-4331-9f16-f4d38ff5fbcc", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7236), "/databaseimg/galeri/galerigümüşhane-kız.jpg" },
                    { "df196be2-a10f-410d-a443-eb8e3beb6b83", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7168), "/databaseimg/galeri/galeriburdur-kostumu.jpg" },
                    { "e05c586b-210a-4b91-82f3-e79eded27d2f", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7245), "/databaseimg/galeri/galeriIMG_0610.jpg" },
                    { "f086d01f-0adf-420b-b3d5-83a4c51f3c49", new DateTime(2024, 12, 20, 21, 29, 13, 768, DateTimeKind.Local).AddTicks(7232), "/databaseimg/galeri/galeriIMG_1140.jpg" }
                });

            migrationBuilder.InsertData(
                table: "MainMenu",
                columns: new[] { "Id", "ActionName", "AreaName", "ClassName", "ControllerName", "CreatedAt", "CssName", "IconName", "MenuName", "OrderNo", "ParentMenuId", "ParentMenuId1", "RoleId", "RolesId" },
                values: new object[,]
                {
                    { "About", "", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 20, 21, 29, 13, 778, DateTimeKind.Local).AddTicks(1895), "", null, "About", null, null, null, 1, null },
                    { "Comm", "Comm", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 20, 21, 29, 13, 778, DateTimeKind.Local).AddTicks(1915), "", null, "Comm", null, null, null, 1, null },
                    { "Galery", "Galery", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 20, 21, 29, 13, 778, DateTimeKind.Local).AddTicks(1912), "", null, "Galery", null, null, null, 1, null },
                    { "Home", "Index", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 20, 21, 29, 13, 778, DateTimeKind.Local).AddTicks(1884), "", null, "Home", null, null, null, 1, null },
                    { "ProductRent", "ProductRent", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 20, 21, 29, 13, 778, DateTimeKind.Local).AddTicks(1898), "", null, "ProductRent", null, null, null, 1, null },
                    { "ProductSale", "ProductSale", null, "far fa-circle nav-icon", "Home", new DateTime(2024, 12, 20, 21, 29, 13, 778, DateTimeKind.Local).AddTicks(1901), "", null, "ProductSale", null, null, null, 1, null }
                });

            migrationBuilder.InsertData(
                table: "OrdersSituation",
                columns: new[] { "Id", "CreatedAt", "Situation" },
                values: new object[,]
                {
                    { "9ed16fa7-63a8-43b9-9bf8-ad5b8e0b47cf", new DateTime(2024, 12, 20, 21, 29, 13, 779, DateTimeKind.Local).AddTicks(7189), "Siparişiniz Alındı" },
                    { "a0b0ea37-dd20-4a46-bba6-9b6bb1eed186", new DateTime(2024, 12, 20, 21, 29, 13, 779, DateTimeKind.Local).AddTicks(7212), "Siparişiniz Kargoya verildi" },
                    { "fb9ae08d-371f-479e-9364-67abb6b64678", new DateTime(2024, 12, 20, 21, 29, 13, 779, DateTimeKind.Local).AddTicks(7216), "Siparişiniz Tamamlandı" },
                    { "ff83e484-225e-499a-956a-9a17d4a7b4f3", new DateTime(2024, 12, 20, 21, 29, 13, 779, DateTimeKind.Local).AddTicks(7207), "Siparişiniz Hazırlanıyor" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { "1boş", new DateTime(2024, 12, 20, 21, 29, 13, 779, DateTimeKind.Local).AddTicks(9469), " " },
                    { "2halkoyun", new DateTime(2024, 12, 20, 21, 29, 13, 779, DateTimeKind.Local).AddTicks(9488), "HALK OYUNLARI KIYAFETLERİ" },
                    { "3kına", new DateTime(2024, 12, 20, 21, 29, 13, 779, DateTimeKind.Local).AddTicks(9498), "BİNDALLI VE KINA" },
                    { "4dans", new DateTime(2024, 12, 20, 21, 29, 13, 779, DateTimeKind.Local).AddTicks(9502), "STİLİZE DANS" },
                    { "5rond", new DateTime(2024, 12, 20, 21, 29, 13, 779, DateTimeKind.Local).AddTicks(9506), "ROND TÖREN" }
                });

            migrationBuilder.InsertData(
                table: "ProductRegions",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { "AKDENİZ", new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(8829), "AKDENİZ" },
                    { "DOGU ANADOLU", new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(8856), "DOGU ANADOLU" },
                    { "EGE", new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(8851), "EGE" },
                    { "GÜNEYDOGU ANADOLU", new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(8860), "GÜNEYDOGU ANADOLU" },
                    { "İÇ ANADOLU", new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(8864), "İÇ ANADOLU" },
                    { "KAFKAS", new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(8870), "KAFKAS" },
                    { "KARADENİZ", new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(8874), "KARADENİZ" },
                    { "MARMARA", new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(8878), "MARMARA" },
                    { "TRAKYA", new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(8882), "TRAKYA" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubRegions",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { "ADIYAMAN", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1157), "ADIYAMAN" },
                    { "ANKARA", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1176), "ANKARA" },
                    { "ARTVİN", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1180), "ARTVİN" },
                    { "BİLECİK", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1184), "BİLECİK" },
                    { "BİTLİS", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1188), "BİTLİS" },
                    { "BOLU", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1194), "BOLU" },
                    { "BURDUR", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1237), "BURDUR" },
                    { "ÇİFTETELLİ", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1232), "ÇİFTETELLİ" },
                    { "DİYARBAKIR", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1244), "DİYARBAKIR" },
                    { "ELAZIĞ", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1249), "ELAZIĞ" },
                    { "GAZİANTEP", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1253), "GAZİANTEP" },
                    { "GİRESUN", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1257), "GİRESUN" },
                    { "HAKKARİ", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1261), "HAKKARİ" },
                    { "HALAY", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1265), "HALAY" },
                    { "ROMAN", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1269), "ROMAN" },
                    { "SİLİFKE", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1273), "SİLİFKE" },
                    { "TEKE", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1279), "TEKE" },
                    { "TRABZON", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1283), "TRABZON" },
                    { "ÜSKÜP", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1287), "ÜSKÜP" },
                    { "VAN", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1291), "VAN" },
                    { "ZEYBEK", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(1295), "ZEYBEK" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "RoleName" },
                values: new object[,]
                {
                    { "9ddd0484-6af2-4681-a780-ea267785be25", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(3610), "User" },
                    { "cf257749-95fb-4537-bbe4-4eb0660e395b", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(3587), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "SiteCommInfos",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "GSM1", "GSM2", "GSM3", "Phone", "SocialMedias", "Transportation", "WorkingHours" },
                values: new object[] { "deafb06d-5a5b-4bfe-be91-157800e0e6c8", "İkitelli Organize Sanayi Bölgesi Giyim Sanatkarları İş ve Ticaret Merkezi (Deposite A.V.M.arkası) 4. Ada C Blok Kat:1 No:114\r\nBaşakşehir – İSTANBUL", new DateTime(2024, 12, 20, 21, 29, 13, 781, DateTimeKind.Local).AddTicks(9159), "matekostum@gmail.com", "Kiralama WhatsApp İletişim Hattı \r\n\r\n 0530 909 11 34 – Erdem", "İmalat \r\n\r\n 0532 321 64 97 – İsmail", "0532 267 23 86 – Ergun", "0212 549 77 34", "Facebook\r\nfacebook.com/mate.kostum\r\n\r\n\r\nInstagram\r\ninstagram.com/matekostum", "(Kirazlı-Metrokent hattı) İkitelli Sanayi Durağı", "Hafta içi: 09:00 – 17:30\r\n\r\n  Cumartesi: 09:00 – 13:00" });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreatedAt", "SizeNumber" },
                values: new object[,]
                {
                    { "2ae74e11-46f7-47d9-bd96-450b2da6d028", new DateTime(2024, 12, 20, 21, 29, 13, 782, DateTimeKind.Local).AddTicks(1127), 8 },
                    { "5b39b694-4411-4fa8-a80c-b5fd94d6524b", new DateTime(2024, 12, 20, 21, 29, 13, 782, DateTimeKind.Local).AddTicks(1153), 14 },
                    { "94f86f41-b970-461a-8f58-ed404d60a9a2", new DateTime(2024, 12, 20, 21, 29, 13, 782, DateTimeKind.Local).AddTicks(1148), 12 },
                    { "f86bcf34-d723-4415-a5d2-ba1f84221ed0", new DateTime(2024, 12, 20, 21, 29, 13, 782, DateTimeKind.Local).AddTicks(1144), 10 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "City", "District", "Email", "GSM", "Name", "Password", "SurName", "TcNo" },
                values: new object[] { "f9cd8367-eafa-4385-bf19-d60c2bbbdba6", " uxi sokak. Lola Apt. Paksim Caddesi, No:11", "İstanbul", "Maltepe", "idilerdogan@sabanciuniv.edu", "05391111111", "İdil", "qweasd", "Erdoğan", "12212212211" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "Description", "Gender", "IsAdult", "IsSale", "PhotoPath", "ProductCategoryId", "ProductName", "ProductRegionId", "ProductSubRegionId", "UnitPriceForRent", "UnitPriceForSale" },
                values: new object[,]
                {
                    { "0155ab55-4f0e-4a1e-ace0-dd694841f18b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5881), null, false, false, false, "/databaseimg/HALKOYUNGAZİANTEP-EÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "0666963f-30c7-4dcf-bb94-f6747ba6c047", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6204), null, true, true, false, "/databaseimg/HALKOYUN-BİTLİS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "07b9953c-4439-43e6-a257-0db216ef7d86", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5871), null, null, false, false, "/databaseimg/HALKOYUNELAZIĞÇOCUKKİRALIK.jpg", "2halkoyun", "ELAZIĞ", "DOGU ANADOLU", "ELAZIĞ", 1500, null },
                    { "09b4b7b0-0b5d-4205-beac-0829af21e521", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5979), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "4dans", "ÇAÇA", null, null, 1500, null },
                    { "0e220339-f0d8-4458-a68a-28d26a40a202", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6471), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE-N2", null, null, 1500, null },
                    { "0e32d48b-7e09-4ea1-9d78-4c9ee88027c0", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6165), null, null, false, false, "/databaseimg/RONDYENİÇERİÇOCUKKİRALIK.jpg", "5rond", "YENİÇERİ", null, null, 0, 1500 },
                    { "0efa1703-cf38-4ee0-ad03-b23070a1a849", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6126), null, null, false, false, "/databaseimg/RONDPALYAÇOÇOCUKKİRALIK.jpg", "5rond", "PALYAÇO", null, null, 0, 1500 },
                    { "10e8d432-e8fe-4dc0-84de-b57ea0f875de", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6494), null, null, true, false, "/databaseimg/STİLİZE-LİRİK-YETİŞKİNKİRALIK.jpg", "4dans", "LİRİK", null, null, 1500, null },
                    { "1321fe57-d872-4595-a65a-66978a6e51d3", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6337), null, false, true, false, "/databaseimg/HALKOYUN-ÜSKÜP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP E", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "16adfef0-aed1-4959-8ec4-894e54e6dd08", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6534), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI K", null, null, 1500, null },
                    { "186d26bd-4429-455f-9850-cea18997e3cc", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6485), null, null, true, false, "/databaseimg/STİLİZE-AŞUKMAŞUK-YETİŞKİNKİRALIK.jpg", "4dans", "AŞUK MAŞUK", null, null, 1500, null },
                    { "19264e9c-2817-45b7-9911-7b0fdbea7985", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6313), null, true, true, false, "/databaseimg/HALKOYUN-TRABZONİŞLİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON K İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "1b06bf9f-8425-4545-9489-1db04a57ea78", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6525), null, null, true, false, "/databaseimg/STİLİZE-ROMANYEŞİL-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN YEŞİL", null, "ROMAN", 1500, null },
                    { "1b72d5ca-5ae0-4a39-befb-c3b359db4058", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6425), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN YEŞİL", null, null, 1500, null },
                    { "1b9634d0-a012-4c81-af15-d5c3074b3a8b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6333), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONPEMBEYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON PEMBE YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "1c143def-1b58-4a0f-b8ff-48de0482e41e", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6394), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN BORDO", null, null, 1500, null },
                    { "1e0b35f9-6d3c-48eb-b077-ffc4a69a0ec2", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6429), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİBORDO-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ BORDO", null, null, 1500, null },
                    { "1e12fe40-55e8-4186-aec9-4506fe2e7c15", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5983), null, null, false, false, "/databaseimg/STİLİZEFRAKÇOCUKKİRALIK.jpg", "4dans", "FRAK", null, null, 1500, null },
                    { "2142b0a0-4163-42d1-804d-04e04407bff8", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6042), null, null, false, false, "/databaseimg/STİLİZESTİLİZEPEMBEÇOCUKKİRALIK.jpg", "4dans", "STİLİZE PEMBE", null, null, 1500, null },
                    { "217a73f8-bbfe-46df-a055-c35b04398ced", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6065), null, null, false, false, "/databaseimg/STİLİZEÇAÇAÇOCUKKİRALIK.jpg", "5rond", "ÇAÇA", null, null, 1500, null },
                    { "21e78eb4-8310-4f9f-b12f-f3409127cb3d", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6521), null, null, true, false, "/databaseimg/STİLİZE-ROMANTURUNCU-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN TURUNCU", null, "ROMAN", 1500, null },
                    { "229075ed-32f0-4bc0-87e2-aa58f0f91600", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6248), null, true, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "22f49a8c-b514-4f6e-9fe4-b1c4c5b75d0c", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6490), null, null, true, false, "/databaseimg/STİLİZE-ÇİFTETELLİBEYAZ-YETİŞKİNKİRALIK.jpg", "4dans", "ÇİFTETELLİ BEYAZ", null, "ÇİFTETELLİ", 1500, null },
                    { "24a4eb08-87be-4fa2-8bb7-171ec749326a", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5992), null, null, false, false, "/databaseimg/STİLİZEHİNTÇOCUKKİRALIK.jpg", "4dans", "HİNT", null, null, 1500, null },
                    { "27e6f672-ae25-47f6-b994-4a5966a79179", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6243), null, false, true, false, "/databaseimg/HALKOYUN-GAZİANTEP-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GAZİANTEP E", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "2848c69c-2a27-40dc-b50f-683f063fa53b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5988), null, null, false, false, "/databaseimg/STİLİZEGREASEÇOCUKKİRALIK.jpg", "4dans", "GREASE", null, null, 1500, null },
                    { "28a2eb33-d029-4d3f-a1b2-4180da181ab5", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5836), null, null, false, false, "/databaseimg/HALKOYUNBİLECİKÇOCUKKİRALIK.jpg", "2halkoyun", "BİLECİK", "MARMARA", "BİLECİK", 1500, null },
                    { "291cd8e3-d200-4c17-a4bf-c61e7cc32dac", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5892), null, null, false, false, "/databaseimg/HALKOYUNHALAY-SİYAHÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY SİYAH", null, "HALAY", 1500, null },
                    { "2b57f0e1-5f6f-478f-96c9-d7f4ed3e3d06", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5831), null, null, false, false, "/databaseimg/HALKOYUNARTVİN-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN İŞLİ", "KARADENİZ", "ARTVİN", 1500, null },
                    { "2b733028-838b-4c96-84d9-cd74e0173e6f", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6400), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI", null, null, 1500, null },
                    { "2bcef2a2-a907-4e8d-be27-9da0f3d6df0b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5954), null, null, false, false, "/databaseimg/HALKOYUNVANÇOCUKKİRALIK.jpg", "2halkoyun", "VAN", "DOGU ANADOLU", "VAN", 1500, null },
                    { "2c063755-30c8-42eb-8113-26e89725f470", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5969), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK İŞLİ", "EGE", "ZEYBEK", 1500, null },
                    { "2ee90544-fb38-406d-ac88-ef2bd5b74eba", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6529), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEKIRMIZI-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI E", null, null, 1500, null },
                    { "2f26f03d-b385-4ec2-bad8-62195347049f", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6324), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORYELEK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR YELEK", "KARADENİZ", "TRABZON", 1500, null },
                    { "2fba8f37-bf3b-403f-912a-48f6b3a09e9a", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6200), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSBEYAZ-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS BEYAZ E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "31c6be01-3855-456c-a40c-653a87dbde7f", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6351), null, true, true, false, "/databaseimg/HALKOYUN-VAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN K", "DOGU ANADOLU", "VAN", 1500, null },
                    { "37aa8336-4d1e-48f8-8dc9-2846a36096a7", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6061), null, null, false, false, "/databaseimg/RONDASKERÇOCUKKİRALIK.jpg", "5rond", "ASKER", null, null, 1500, null },
                    { "382cb05d-75f4-4c29-957f-b39befd474ac", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5936), null, null, false, false, "/databaseimg/HALKOYUNTRAKYAÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA", "TRAKYA", null, 1500, null },
                    { "38acaf48-0668-4eaa-9ea5-f5550d1db720", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6303), null, true, true, false, "/databaseimg/HALKOYUN-TRAKYAPEMBE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE K", "TRAKYA", null, 1500, null },
                    { "3a5bd6f6-53cd-4ac2-a0bd-92c3947f14e0", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5931), null, null, false, false, "/databaseimg/HALKOYUNTEKE-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE PEMBE", "AKDENİZ", "TEKE", 1500, null },
                    { "3d18e1b4-4867-40dd-b3fe-7bd0444941c6", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6299), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMORMONORAY-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MOR MONORAY", "TRAKYA", null, 1500, null },
                    { "3d88d5e9-af20-46f4-af5e-36b0b0004d16", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6477), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİÜSKÜP-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ ÜSKÜP-N2", null, null, 1500, null },
                    { "3e6d3a6d-5dce-4876-931d-7c168f69dff9", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6222), null, false, true, false, "/databaseimg/HALKOYUN-BURDUR-E2-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR E2", "AKDENİZ", "BURDUR", 1500, null },
                    { "3e830fdb-6868-410a-81dc-8313c98d7bde", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6025), null, null, false, false, "/databaseimg/STİLİZESALSAÇOCUKKİRALIK.jpg", "4dans", "SALSA", null, null, 1500, null },
                    { "3edf9eea-18f7-4fc2-aff8-bfb899e6fc96", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6142), null, null, false, false, "/databaseimg/RONDSEMAZENÇOCUKKİRALIK.jpg", "5rond", "SEMAZEN", null, null, 0, 1500 },
                    { "40eecd41-1eb2-4e1f-ad4e-8a8ba69615c1", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6091), null, null, false, false, "/databaseimg/RONDKIRMIZIBAŞLIKLIKIZÇOCUKKİRALIK.jpg", "5rond", "KIRMIZI BAŞLIKLI KIZ", null, null, 1500, null },
                    { "42e732b6-0862-46dd-bddd-650c8a1a1c37", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6099), null, null, false, false, "/databaseimg/RONDMEZUNİYETÇOCUKKİRALIK.jpg", "5rond", "MEZUNİYET", null, null, 1500, null },
                    { "4446e8f9-0075-48d3-b1aa-b88bc2206535", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5901), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS KIRMIZI", "KAFKAS", null, 1500, null },
                    { "4993ab34-96e3-4f01-b587-fd091c8efda5", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6308), null, false, true, false, "/databaseimg/HALKOYUN-TRABZON-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON E", "KARADENİZ", "TRABZON", 1500, null },
                    { "4b982c80-c393-4e7c-9a12-f3deac18f8a1", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6502), null, null, true, false, "/databaseimg/STİLİZE-ROMANKIRMIZI-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, "ROMAN", 1500, null },
                    { "4be4ee4b-4935-480c-a987-8f63b87519c9", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6108), null, null, false, false, "/databaseimg/RONDNOELBABAÇOCUKKİRALIK.jpg", "5rond", "NOEL BABA", null, null, 0, 1500 },
                    { "4c6637c4-93c8-4724-aea3-af20453e3f97", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6320), null, null, true, false, "/databaseimg/HALKOYUN-TRABZONMORİŞLİK-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRABZON MOR İŞLİK", "KARADENİZ", "TRABZON", 1500, null },
                    { "4d0e16ff-90f6-43fc-9f61-f9402082899a", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5853), null, true, false, false, "/databaseimg/HALKOYUNBİTLİS-KÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS K", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "4f2719ec-0241-40e1-90d3-3918abc9c43a", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6390), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMUĞLA-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MUĞLA", "EGE", "ZEYBEK", 1500, null },
                    { "55de3470-7f58-4462-a040-007f7fd16a04", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5801), null, null, false, false, "/databaseimg/HALKOYUNADIYAMANÇOCUKKİRALIK.jpg", "2halkoyun", "ADIYAMAN", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "565000d5-317e-4031-9789-7a673bca1df3", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6371), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKEŞKİYA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK EŞKİYA E", "EGE", "ZEYBEK", 1500, null },
                    { "597df21a-33ef-4ca3-99fd-94caa37ad060", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6376), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKKOYU-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK KOYU E", "EGE", "ZEYBEK", 1500, null },
                    { "5a49566d-8832-45fe-98b5-9f7be7edb369", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6227), null, true, true, false, "/databaseimg/HALKOYUN-BURDUR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BURDUR K", "AKDENİZ", "BURDUR", 1500, null },
                    { "5ac20b19-3aa2-478e-983d-63dcd515bf00", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6506), null, null, true, false, "/databaseimg/STİLİZE-ROMANPEMBE-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN PEMBE", null, "ROMAN", 1500, null },
                    { "5d4f3fd1-7e89-4d21-bfe2-87ec79a0e440", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6189), null, true, true, false, "/databaseimg/HALKOYUN-ARTVİN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ARTVİN K", "KARADENİZ", "ARTVİN", 1500, null },
                    { "5e8ba8cb-85a6-4f33-ad65-d6146eee4a70", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6282), null, true, true, false, "/databaseimg/HALKOYUN-SİLİFKE-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE K", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "600308e4-90de-46d1-9acf-72cf79ea9a59", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6087), null, null, false, false, "/databaseimg/RONDKATİBİMÇOCUKKİRALIK.jpg", "5rond", "KATİBİM", null, null, 1500, null },
                    { "610901a6-6e05-49b0-a014-0e126d7b9bfb", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6257), null, true, true, false, "/databaseimg/HALKOYUN-GİRESUN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN K", "KARADENİZ", "GİRESUN", 1500, null },
                    { "63283494-7d05-42d7-84b7-688f76a9f30a", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6104), null, null, false, false, "/databaseimg/RONDNASREDDİNHOCAÇOCUKKİRALIK.jpg", "5rond", "NASREDDİN HOCA", null, null, 1500, null },
                    { "632e8299-0ade-4805-869a-15c8f6ddc375", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6209), null, null, true, false, "/databaseimg/HALKOYUN-BİTLİSMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİTLİS MAVİ", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "65756f7c-eafd-4da8-a441-3a5a8732ecbc", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6408), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N3-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N3", null, null, 1500, null },
                    { "65a69ab1-996b-41e7-8cbf-46f3b3ab4141", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6135), null, true, false, false, "/databaseimg/RONDSALSAKÇOCUKKİRALIK.jpg", "5rond", "SALSA K", null, null, 0, 1500 },
                    { "693452ad-d89a-4c71-b332-6ef681dac8e4", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6275), null, false, true, false, "/databaseimg/HALKOYUN-SİLİFKE-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "SİLİFKE E", "AKDENİZ", "SİLİFKE", 1500, null },
                    { "695fe776-fd5c-4560-b01d-ef97c4167e6a", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5925), null, null, false, false, "/databaseimg/HALKOYUNTEKE-YEŞİLÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE YEŞİL", "AKDENİZ", "TEKE", 1500, null },
                    { "6e0ec97d-f797-4900-b8f8-3f3c9631918b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6056), null, null, false, false, "/databaseimg/RONDARIÇOCUKKİRALIK.jpg", "5rond", "ARI", null, null, 1500, null },
                    { "72d1276c-e69b-4c72-91d3-c696a61b2291", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5906), null, null, false, false, "/databaseimg/HALKOYUNKAFKAS-MORÇOCUKKİRALIK.jpg", "2halkoyun", "KAFKAS MOR", "KAFKAS", null, 1500, null },
                    { "73e207ea-3852-42d5-95ad-30bc9892314e", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6467), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ PEMBE", null, null, 1500, null },
                    { "743427a0-79de-4d87-8ca9-185cbb8d311b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5876), null, true, false, false, "/databaseimg/HALKOYUNGAZİANTEP-KÇOCUKKİRALIK.jpg", "2halkoyun", "GAZİANTEP K", "GÜNEYDOGU ANADOLU", "GAZİANTEP", 1500, null },
                    { "74479c9e-1176-44b1-89c1-9c779bb2699c", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5997), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "4dans", "İSPANYOL", null, null, 1500, null },
                    { "764e7137-158c-446d-b16f-9061c3554800", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5847), null, false, false, false, "/databaseimg/HALKOYUNBİTLİS-EÇOCUKKİRALIK.jpg", "2halkoyun", "BİTLİS E", "DOGU ANADOLU", "BİTLİS", 1500, null },
                    { "791bad40-9dbf-45e8-a55b-99643df714d1", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6030), null, null, false, false, "/databaseimg/STİLİZESALSAEÇOCUKKİRALIK.jpg", "4dans", "SALSA E", null, null, 1500, null },
                    { "7ac882a7-22ab-48d3-9a6e-1a6970ab3074", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6262), null, true, true, false, "/databaseimg/HALKOYUN-HAKKARİ-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "HAKKARİ K", "DOGU ANADOLU", "HAKKARİ", 1500, null },
                    { "7bf1c2a9-bc41-4166-93ad-9b7648a6e06e", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5975), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-MORÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "7bfc0ae9-2db5-4e5f-9b70-64785a33a56d", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6385), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKPEMBE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK PEMBE", "EGE", "ZEYBEK", 1500, null },
                    { "7ddd0c0e-a773-4686-852a-59ba0b7f6e49", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6131), null, null, false, false, "/databaseimg/RONDPAMUKPRENSESÇOCUKKİRALIK.jpg", "5rond", "PAMUK PRENSES", null, null, 0, 1500 },
                    { "80f0b466-4d61-42ce-b337-0ab478881500", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6146), null, null, false, false, "/databaseimg/RONDŞİRİNLERÇOCUKKİRALIK.jpg", "5rond", "ŞİRİNLER", null, null, 0, 1500 },
                    { "838006b8-fb01-40d8-9504-157a127f5e75", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6367), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKBORDO-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "87176a5f-2004-4bac-8d3e-ab78083f4941", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5963), null, false, false, false, "/databaseimg/HALKOYUNZEYBEK-EÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK E", "EGE", "ZEYBEK", 1500, null },
                    { "89e8bca8-89fa-49c6-be5d-2f02dd4da248", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6380), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKMOR-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK MOR", "EGE", "ZEYBEK", 1500, null },
                    { "8ecf47d7-4c2f-4d13-a211-ed6ef2a1850c", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6174), null, true, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN K", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "901c4fb9-69c0-4dfc-ad9c-04a7095ce9ca", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6118), null, null, false, false, "/databaseimg/RONDPADİŞAHÇOCUKKİRALIK.jpg", "5rond", "PADİŞAH", null, null, 0, 1500 },
                    { "90e2680d-11af-418b-bf00-52f7295fd19e", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6459), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N2", null, null, 1500, null },
                    { "9870fa88-18e6-4ca8-b047-e2325a48d7ec", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6412), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMOR-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MOR", null, null, 1500, null },
                    { "9a1280da-68d5-463d-811b-0a219c0b7de9", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6417), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANMÜRDÜM-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN MÜRDÜM", null, null, 1500, null },
                    { "9dfc9a24-3e8f-4447-8aac-0838468265a7", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5861), null, null, false, false, "/databaseimg/HALKOYUNBOLU-SADEÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU SADE", "MARMARA", "BOLU", 1500, null },
                    { "9dffddc7-aa49-487e-87a1-77d4450c4914", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6448), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI-N2", null, null, 1500, null },
                    { "9ef5836d-9550-4dd8-87b1-641b3a137d7c", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6444), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİKIRMIZI-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ KIRMIZI", null, null, 1500, null },
                    { "9f3a97a8-01c1-4d76-b3fe-3ac3855a204d", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6231), null, false, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR E", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "a262e1c1-c74c-44fb-bdf1-f9fdee0a50eb", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6069), null, null, false, false, "/databaseimg/RONDÇİÇEKÇOCUKKİRALIK.jpg", "5rond", "ÇİÇEK", null, null, 1500, null },
                    { "a26d9596-a5a7-4764-b520-41ddd4868547", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6077), null, null, false, false, "/databaseimg/RONDHACİVATKARAGÖZÇOCUKKİRALIK.jpg", "5rond", "HACİVAT KARAGÖZ", null, null, 1500, null },
                    { "a847cbd1-e1a0-453b-b01c-49f50d50605e", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5897), null, null, false, false, "/databaseimg/HALKOYUNKARADENİZÇOCUKKİRALIK.jpg", "2halkoyun", "KARADENİZ", "KARADENİZ", null, 1500, null },
                    { "a8530e3a-1227-4cb9-99c0-238650799f11", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6453), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT", null, null, 1500, null },
                    { "a9344b23-233c-47b7-b263-e1b96129b01b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6271), null, true, true, false, "/databaseimg/HALKOYUN-KAFKAS-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS K", "KAFKAS", null, 1500, null },
                    { "ab6439cc-b113-4772-8121-e047eff4f2bc", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6286), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKIRMIZIKADİFE-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KIRMIZI KADİFE", "TRAKYA", null, 1500, null },
                    { "b0a3f206-15d8-46d9-9bff-a144887b8a4b", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6463), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİLACİVERT-N3-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ LACİVERT-N3", null, null, 1500, null },
                    { "b249af59-4ad5-4368-b56d-b20155ff1a47", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5857), null, null, false, false, "/databaseimg/HALKOYUNBOLU-İŞLİÇOCUKKİRALIK.jpg", "2halkoyun", "BOLU İŞLİ", "MARMARA", "BOLU", 1500, null },
                    { "b311fec0-78c7-49eb-9b61-53cdec9ad2af", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6193), null, true, true, false, "/databaseimg/HALKOYUN-BİLECİK-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BİLECİK K", "MARMARA", "BİLECİK", 1500, null },
                    { "b51cd5a5-840b-4a9a-ad60-6a4402f054ec", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6404), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANKIRMIZI-N2-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN KIRMIZI-N2", null, null, 1500, null },
                    { "b59a9d88-1c3f-4cfd-b5f4-a994db00a4ca", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6213), null, true, true, false, "/databaseimg/HALKOYUN-BOLU-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "BOLU K", "KARADENİZ", "BOLU", 1500, null },
                    { "b8bb17b8-b238-412a-84d4-9203929ccf17", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5950), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-BEYAZÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA BEYAZ", "TRAKYA", null, 1500, null },
                    { "bb05c777-75c4-4b25-bda9-e839ad18c25c", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6290), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAKREM-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA KREM", "TRAKYA", null, 1500, null },
                    { "bb41480f-9db3-44a9-8d26-e8cab09dfef8", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6073), null, null, false, false, "/databaseimg/RONDFAREÇOCUKKİRALIK.jpg", "5rond", "FARE", null, null, 1500, null },
                    { "bd76d8e7-bf02-41a3-8085-cb03c498d893", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5826), null, null, false, false, "/databaseimg/HALKOYUNARTVİNÇOCUKKİRALIK.jpg", "2halkoyun", "ARTVİN", "KARADENİZ", "ARTVİN", 1500, null },
                    { "bffeed41-227b-4c26-ad9a-0a86a8408058", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6155), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE KIRMIZI", null, null, 0, 1500 },
                    { "c01111dc-cb76-433a-a880-b479eed5a549", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6346), null, null, true, false, "/databaseimg/HALKOYUN-VANBEYAZ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "VAN BEYAZ", "DOGU ANADOLU", "VAN", 1500, null },
                    { "c11b1877-4a43-400b-bd95-e454e3be7940", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6038), null, null, false, false, "/databaseimg/STİLİZESTİLİZEMORÇOCUKKİRALIK.jpg", "4dans", "STİLİZE MOR", null, null, 1500, null },
                    { "c848d84c-a20a-4e9a-882d-89e81e48381b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6517), null, null, true, false, "/databaseimg/STİLİZE-ROMANRENKLİETEK-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN RENKLİ ETEK", null, "ROMAN", 1500, null },
                    { "cb88596f-a1f3-4481-8f49-aca18947b18e", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6095), null, null, false, false, "/databaseimg/RONDMEHTERÇOCUKKİRALIK.jpg", "5rond", "MEHTER", null, null, 1500, null },
                    { "d37281f6-96bd-4836-8b58-a5cb3caad83f", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6052), null, null, false, false, "/databaseimg/STİLİZEÇİFTETELLİPEMBEÇOCUKKİRALIK.jpg", "4dans", "ÇİFTETELLİ PEMBE", null, null, 1500, null },
                    { "d6b894e9-5afe-466b-82fa-2b49b228978e", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6048), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE SARI", null, null, 1500, null },
                    { "d7478a88-4270-48ce-bc12-83cb76b68b7f", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6342), null, true, true, false, "/databaseimg/HALKOYUN-ÜSKÜPBORDO-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ÜSKÜP K BORDO", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "d8709cba-23be-4447-bb14-0efa737cf767", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6266), null, false, true, false, "/databaseimg/HALKOYUN-KAFKAS-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "KAFKAS E", "KAFKAS", null, 1500, null },
                    { "dda5e8a2-60fd-425d-a9f6-a1e47fd97866", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6184), null, false, true, false, "/databaseimg/HALKOYUN-ARTVİN-E2-YETİŞKİNKİRALIK.jpG", "2halkoyun", "ARTVİN E2", "KARADENİZ", "ARTVİN", 1500, null },
                    { "df26b31b-968d-4a6f-8455-a559626ea787", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5910), null, null, false, false, "/databaseimg/HALKOYUNSİLİFKEÇOCUKKİRALIK.jpg", "2halkoyun", "SİLİFKE", "MARMARA", "SİLİFKE", 1500, null },
                    { "e075a9e4-ed9f-48aa-9511-3de1680ed14c", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6295), null, null, true, false, "/databaseimg/HALKOYUN-TRAKYAMAVİ-YETİŞKİNKİRALIK.jpg", "2halkoyun", "TRAKYA MAVİ", "TRAKYA", null, 1500, null },
                    { "e1b650d4-d0e4-4e93-8e1c-5d9bef84e70f", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6481), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİYEŞİL-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ YEŞİL", null, null, 1500, null },
                    { "e243ea40-32d9-4ed7-9ed2-0cf3804421d3", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5888), null, null, false, false, "/databaseimg/HALKOYUNHALAY-KIRMIZIÇOCUKKİRALIK.jpg", "2halkoyun", "HALAY KIRMIZI", null, "HALAY", 1500, null },
                    { "e2e607e5-023e-4b01-9731-e12edb41b81b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5941), null, null, false, false, "/databaseimg/HALKOYUNÜSKÜPÇOCUKKİRALIK.jpg", "2halkoyun", "ÜSKÜP", "TRAKYA", "ÜSKÜP", 1500, null },
                    { "e318be9a-77be-4461-b04e-99a8220b1f65", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6012), null, null, false, false, "/databaseimg/STİLİZEROMANKIR1ÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIR (1)", null, null, 1500, null },
                    { "e494c128-2a30-48b3-b5b4-3093da19f91b", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6001), null, null, false, false, "/databaseimg/STİLİZEROMANFUŞYAÇOCUKKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, null, 1500, null },
                    { "e8ba9464-a40d-4b09-bb7d-c0341e96e5e6", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6083), null, null, false, false, "/databaseimg/STİLİZEİSPANYOLÇOCUKKİRALIK.jpg", "5rond", "İSPANYOL", null, "ROMAN", 1500, null },
                    { "e983891c-4438-4f93-a57d-e7b959f776ad", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6150), null, null, false, false, "/databaseimg/RONDTAVŞANÇOCUKKİRALIK.jpg", "5rond", "TAVŞAN", null, null, 0, 1500 },
                    { "ea194267-a525-4d93-a4e4-0d79cbce6196", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5915), null, false, false, false, "/databaseimg/HALKOYUNTEKE-EÇOCUKKİRALIK.jpg", "2halkoyun", "TEKE E", "AKDENİZ", "TEKE", 1500, null },
                    { "eb6a3773-0472-4365-a2d0-188f4d4b2774", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6538), null, false, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-E-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ E", null, null, 1500, null },
                    { "ec9884f7-b99d-4539-9558-9f01ec86cca7", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5958), null, null, false, false, "/databaseimg/HALKOYUNZEYBEK-BORDOÇOCUKKİRALIK.jpg", "2halkoyun", "ZEYBEK BORDO", "EGE", "ZEYBEK", 1500, null },
                    { "edf577e3-7e24-45bb-8330-a8c8ef91d622", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6237), null, true, true, false, "/databaseimg/HALKOYUN-DİYARBAKIR-K-YETİŞKİNKİRALIK.jpg", "2halkoyun", "DİYARBAKIR K", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "ee2fcd76-1333-4d35-bbfc-0f9259d9a726", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5820), null, null, false, false, "/databaseimg/HALKOYUNANKARAÇOCUKKİRALIK.jpg", "2halkoyun", "ANKARA", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "eedeff5a-7dbd-468a-927b-9f47011bc2bf", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5867), null, null, false, false, "/databaseimg/HALKOYUNDİYARBAKIRÇOCUKKİRALIK.jpg", "2halkoyun", "DİYARBAKIR", "GÜNEYDOGU ANADOLU", "DİYARBAKIR", 1500, null },
                    { "f0287c6c-3579-41d2-824a-fac09fc63f07", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6252), null, false, true, false, "/databaseimg/HALKOYUN-GİRESUN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "GİRESUN E", "KARADENİZ", "GİRESUN", 1500, null },
                    { "f0c71833-2863-4679-9b05-668471949e31", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6356), null, null, true, false, "/databaseimg/HALKOYUN-ZEYBEKAÇIK-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AÇIK E", "EGE", "ZEYBEK", 1500, null },
                    { "f27ed595-e372-4473-9eeb-54f4f5145ead", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6007), null, null, false, false, "/databaseimg/STİLİZEROMANKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "ROMAN KIRMIZI", null, null, 1500, null },
                    { "f29977b7-8b8d-46dd-b450-faf54897c417", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6180), null, false, true, false, "/databaseimg/HALKOYUN-ANKARA-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ANKARA E", "İÇ ANADOLU", "ANKARA", 1500, null },
                    { "f4d2fbf0-71bb-46cc-b1b0-a7e5fbff266e", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6161), null, null, false, false, "/databaseimg/STİLİZESTİLİZESARIÇOCUKKİRALIK.jpg", "5rond", "STİLİZE SARI", null, null, 0, 1500 },
                    { "f4e3bd85-975c-452a-80ea-63d53d56ba7a", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6034), null, null, false, false, "/databaseimg/STİLİZESTİLİZEKIRMIZIÇOCUKKİRALIK.jpg", "4dans", "STİLİZE KIRMIZI", null, null, 1500, null },
                    { "f4f2a174-bdc4-458e-a061-b67aadb938b5", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(5946), null, null, false, false, "/databaseimg/HALKOYUNTRAKYA-PEMBEÇOCUKKİRALIK.jpg", "2halkoyun", "TRAKYA PEMBE", "TRAKYA", null, 1500, null },
                    { "f4f3bb6b-6dcc-4975-b32f-e60a0e094534", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6498), null, null, true, false, "/databaseimg/STİLİZE-ROMANFUŞYA-YETİŞKİNKİRALIK.jpg", "4dans", "ROMAN FUŞYA", null, "ROMAN", 1500, null },
                    { "f5181900-e2da-4703-bac3-5ae4062b55c2", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6421), null, null, true, false, "/databaseimg/KINABİNDALLI-GELENEKSELKAFTANPEMBE-YETİŞKİNKİRALIK.jpg", "3kına", "GELENEKSEL KAFTAN PEMBE", null, null, 1500, null },
                    { "f688d7a2-97b7-4788-98f4-6546bb8c67c9", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6362), null, false, true, false, "/databaseimg/HALKOYUN-ZEYBEKAĞIR-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ZEYBEK AĞIR E", "EGE", "ZEYBEK", 1500, null },
                    { "f712ffe9-7ac1-46d1-b6b6-40ef7a9bf55d", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6016), null, null, false, false, "/databaseimg/STİLİZEROMANMORÇOCUKKİRALIK.jpg", "4dans", "ROMAN MOR", null, null, 1500, null },
                    { "fb083a3a-0618-458e-89f9-cdbc5e2d911e", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6169), null, false, true, false, "/databaseimg/HALKOYUN-ADIYAMAN-E-YETİŞKİNKİRALIK.jpg", "2halkoyun", "ADIYAMAN E", "GÜNEYDOGU ANADOLU", "ADIYAMAN", 1500, null },
                    { "fc780871-0759-4cd0-ae6c-184737cb0e08", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6542), null, true, true, false, "/databaseimg/STİLİZE-STİLİZEMAVİ-K-YETİŞKİNKİRALIK.jpg", "4dans", "STİLİZE MAVİ K", null, null, 1500, null },
                    { "fca6e389-c1a8-4147-a7ad-1970ae7aa22d", 10, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6112), null, null, false, false, "/databaseimg/RONDÖRDEKÇOCUKKİRALIK.jpg", "5rond", "ÖRDEK", null, null, 0, 1500 },
                    { "fec87765-656c-49b1-8fb4-dfca2cebcc6a", 0, new DateTime(2024, 12, 20, 21, 29, 13, 780, DateTimeKind.Local).AddTicks(6438), null, null, true, false, "/databaseimg/KINABİNDALLI-KINAKIYAFETİGRİSİYAH-YETİŞKİNKİRALIK.jpg", "3kına", "KINA KIYAFETİ GRİ-SİYAH", null, null, 1500, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_BasketId",
                table: "BasketDetails",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_Id",
                table: "BasketDetails",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_ProductId",
                table: "BasketDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_Id",
                table: "Baskets",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommUsers_Id",
                table: "CommUsers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FotoDesign_Id",
                table: "FotoDesign",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FotoGaleries_Id",
                table: "FotoGaleries",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainMenu_Id",
                table: "MainMenu",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainMenu_ParentMenuId1",
                table: "MainMenu",
                column: "ParentMenuId1");

            migrationBuilder.CreateIndex(
                name: "IX_MainMenu_RolesId",
                table: "MainMenu",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id",
                table: "Orders",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SituationName",
                table: "Orders",
                column: "SituationName");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetail_Id",
                table: "OrdersDetail",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetail_OrderId",
                table: "OrdersDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetail_ProductId",
                table: "OrdersDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersSituation_Id",
                table: "OrdersSituation",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_Id",
                table: "ProductCategories",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_Name",
                table: "ProductCategories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductRegions_Id",
                table: "ProductRegions",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductRegions_Name",
                table: "ProductRegions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id",
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
                name: "IX_ProductSize_SizesId",
                table: "ProductSize",
                column: "SizesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubRegions_Id",
                table: "ProductSubRegions",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubRegions_Name",
                table: "ProductSubRegions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Id",
                table: "Roles",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RoleName",
                table: "Roles",
                column: "RoleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiteCommInfos_Email",
                table: "SiteCommInfos",
                column: "Email",
                unique: true);

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
                name: "IX_SiteCommInfos_Id",
                table: "SiteCommInfos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiteCommInfos_Phone",
                table: "SiteCommInfos",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Size_Id",
                table: "Size",
                column: "Id",
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
                name: "IX_UserInfos_Id",
                table: "UserInfos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_TcNo",
                table: "UserInfos",
                column: "TcNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_RoleId",
                table: "UsersRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketDetails");

            migrationBuilder.DropTable(
                name: "CommUsers");

            migrationBuilder.DropTable(
                name: "FotoDesign");

            migrationBuilder.DropTable(
                name: "FotoGaleries");

            migrationBuilder.DropTable(
                name: "MainMenu");

            migrationBuilder.DropTable(
                name: "OrdersDetail");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "SiteCommInfos");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Size");

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
