using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Riva.Models.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    CustIDNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    ContactName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Address1 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address2 = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Region = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Country = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Fax = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ShippingMethod = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers_1", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "GemInventory",
                columns: table => new
                {
                    GemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CustomerSKU = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Location = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    GemName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    GemColor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SizeMM = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Shape = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    WeightCarat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Owner = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LinkedOrder = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LinkedOrderItem = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CurrentStatus = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    Used = table.Column<bool>(nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateUsed = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GemInventory", x => x.GemID);
                });

            migrationBuilder.CreateTable(
                name: "GemStatus",
                columns: table => new
                {
                    GemStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GemStatus", x => x.GemStatusID);
                });

            migrationBuilder.CreateTable(
                name: "HistoryLogs",
                columns: table => new
                {
                    LogIdx = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    Username = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Table = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    TableIdx = table.Column<int>(nullable: false),
                    Field = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    OldFieldValue = table.Column<string>(unicode: false, maxLength: 4000, nullable: false),
                    NewFieldValue = table.Column<string>(unicode: false, maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HistoryL__D80CB562542E7F4B", x => x.LogIdx);
                });

            migrationBuilder.CreateTable(
                name: "Inventory_Log",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarcodeID = table.Column<int>(nullable: false),
                    ItemType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ItemNo = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Karat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    QTY_Old = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    QTY_New = table.Column<decimal>(type: "decimal(18, 3)", nullable: false),
                    GramWGT_Old = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    GramWGT_New = table.Column<decimal>(type: "decimal(18, 3)", nullable: false),
                    WebUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory_Log", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JewelryType",
                columns: table => new
                {
                    JewelryTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JewelryType", x => x.JewelryTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LoginID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<byte[]>(maxLength: 128, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Last_login = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "MaterialCodes",
                columns: table => new
                {
                    MaterialCodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Karat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Color = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialCodes", x => x.MaterialCodeID);
                });

            migrationBuilder.CreateTable(
                name: "MetalMarket",
                columns: table => new
                {
                    MetalMarketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EnteredDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Silver = table.Column<decimal>(type: "money", nullable: true),
                    Gold = table.Column<decimal>(type: "money", nullable: true),
                    Platinum = table.Column<decimal>(type: "money", nullable: true),
                    Palladium = table.Column<decimal>(type: "money", nullable: true),
                    Rhodium = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetalMarket", x => x.MetalMarketID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrdersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNoInternal = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    OrderNoCustomer = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CustomerID = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    RequiredDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrdersID);
                });

            migrationBuilder.CreateTable(
                name: "OrdersStatus",
                columns: table => new
                {
                    OrdersStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersStatus", x => x.OrdersStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    SKU = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CustomerSKU = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ProductFlag = table.Column<bool>(nullable: false),
                    ProductDesc = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    CustomerCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true, defaultValueSql: "('RIVA')"),
                    CommentBox = table.Column<string>(unicode: false, maxLength: 4000, nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    PicPath = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    JewelryType = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FirstProductionDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductsID);
                });

            migrationBuilder.CreateTable(
                name: "ProductsStatus",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStatus", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "UnitsOfMeasure",
                columns: table => new
                {
                    UnitsOfMeasureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UOM = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitsOfMeasure", x => x.UnitsOfMeasureID);
                });

            migrationBuilder.CreateTable(
                name: "zAspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zAspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "zAspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Level = table.Column<byte>(nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zAspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "zmap_spid_application_user",
                columns: table => new
                {
                    spid = table.Column<long>(nullable: false),
                    LogID = table.Column<string>(unicode: false, maxLength: 128, nullable: true),
                    user = table.Column<string>(unicode: false, maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__map_spid__2DD52ACC019AD4A5", x => x.spid);
                });

            migrationBuilder.CreateTable(
                name: "OrdersDetails",
                columns: table => new
                {
                    OrdersDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersID = table.Column<int>(nullable: false),
                    ProductsID = table.Column<int>(nullable: false),
                    MaterialCode = table.Column<int>(nullable: false),
                    Size = table.Column<decimal>(type: "decimal(10, 3)", nullable: true),
                    QTYRequested = table.Column<int>(nullable: false),
                    QTYShipped = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetails", x => x.OrdersDetailsID);
                    table.ForeignKey(
                        name: "FK_OrdersDetails_Orders",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "OrdersID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsBOM",
                columns: table => new
                {
                    ProductsBOMID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsID = table.Column<int>(nullable: false),
                    QTY = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsBOM", x => x.ProductsBOMID);
                    table.ForeignKey(
                        name: "FK_ProductsBOM_Products",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ProductsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsPrices",
                columns: table => new
                {
                    ProductsWHSLID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsID = table.Column<int>(nullable: false),
                    WholeSale = table.Column<bool>(nullable: true),
                    MaterialCode = table.Column<int>(nullable: true),
                    Size = table.Column<decimal>(type: "decimal(3, 2)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsPriceWHSL", x => x.ProductsWHSLID);
                    table.ForeignKey(
                        name: "FK_ProductsPrices_Products",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ProductsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsStock",
                columns: table => new
                {
                    ProductsStockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsID = table.Column<int>(nullable: false),
                    Size = table.Column<decimal>(type: "decimal(5, 3)", nullable: true),
                    MaterialCode = table.Column<int>(nullable: false),
                    UOM = table.Column<int>(nullable: false),
                    QTY = table.Column<decimal>(type: "decimal(10, 3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsStock", x => x.ProductsStockID);
                    table.ForeignKey(
                        name: "FK_ProductsQTY_Products",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ProductsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsWTG",
                columns: table => new
                {
                    ProductsWTGID = table.Column<int>(nullable: false),
                    ProductsID = table.Column<int>(nullable: false),
                    Finished = table.Column<bool>(nullable: false),
                    WTG = table.Column<decimal>(type: "decimal(6, 3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsWTG", x => x.ProductsWTGID);
                    table.ForeignKey(
                        name: "FK_ProductsWTG_Products",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ProductsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "zAspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zAspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "zAspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "zAspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    UserId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey, x.UserId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "zAspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "zAspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "zAspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "zAspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersDetailsRGW",
                columns: table => new
                {
                    OrdersDetailsRGWID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDetailsID = table.Column<int>(nullable: false),
                    OrderCode = table.Column<int>(nullable: true),
                    MoldCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    RivaCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ResizeWax = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersDetailsRGW", x => x.OrdersDetailsRGWID);
                    table.ForeignKey(
                        name: "FK_OrdersDetailsRGW_OrdersDetails",
                        column: x => x.OrderDetailsID,
                        principalTable: "OrdersDetails",
                        principalColumn: "OrdersDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_OrdersID",
                table: "OrdersDetails",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetailsRGW_OrderDetailsID",
                table: "OrdersDetailsRGW",
                column: "OrderDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsBOM_ProductsID",
                table: "ProductsBOM",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsPrices_ProductsID",
                table: "ProductsPrices",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsStock_ProductsID",
                table: "ProductsStock",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsWTG_ProductsID",
                table: "ProductsWTG",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "zAspNetRoles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "zAspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "zAspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleId",
                table: "zAspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserId",
                table: "zAspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "zAspNetUsers",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "GemInventory");

            migrationBuilder.DropTable(
                name: "GemStatus");

            migrationBuilder.DropTable(
                name: "HistoryLogs");

            migrationBuilder.DropTable(
                name: "Inventory_Log");

            migrationBuilder.DropTable(
                name: "JewelryType");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "MaterialCodes");

            migrationBuilder.DropTable(
                name: "MetalMarket");

            migrationBuilder.DropTable(
                name: "OrdersDetailsRGW");

            migrationBuilder.DropTable(
                name: "OrdersStatus");

            migrationBuilder.DropTable(
                name: "ProductsBOM");

            migrationBuilder.DropTable(
                name: "ProductsPrices");

            migrationBuilder.DropTable(
                name: "ProductsStatus");

            migrationBuilder.DropTable(
                name: "ProductsStock");

            migrationBuilder.DropTable(
                name: "ProductsWTG");

            migrationBuilder.DropTable(
                name: "UnitsOfMeasure");

            migrationBuilder.DropTable(
                name: "zAspNetUserClaims");

            migrationBuilder.DropTable(
                name: "zAspNetUserLogins");

            migrationBuilder.DropTable(
                name: "zAspNetUserRoles");

            migrationBuilder.DropTable(
                name: "zmap_spid_application_user");

            migrationBuilder.DropTable(
                name: "OrdersDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "zAspNetRoles");

            migrationBuilder.DropTable(
                name: "zAspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
