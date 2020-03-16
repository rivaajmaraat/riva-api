using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Riva.Models.HAYDEN
{
    public partial class HAYDENContext : DbContext
    {
        public HAYDENContext()
        {
        }

        public HAYDENContext(DbContextOptions<HAYDENContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<GemInventory> GemInventory { get; set; }
        public virtual DbSet<GemStatus> GemStatus { get; set; }
        public virtual DbSet<HistoryLogs> HistoryLogs { get; set; }
        public virtual DbSet<InventoryLog> InventoryLog { get; set; }
        public virtual DbSet<JewelryType> JewelryType { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<MaterialCodes> MaterialCodes { get; set; }
        public virtual DbSet<MetalMarket> MetalMarket { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersDetails> OrdersDetails { get; set; }
        public virtual DbSet<OrdersDetailsRgw> OrdersDetailsRgw { get; set; }
        public virtual DbSet<OrdersStatus> OrdersStatus { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsBom> ProductsBom { get; set; }
        public virtual DbSet<ProductsPrices> ProductsPrices { get; set; }
        public virtual DbSet<ProductsStatus> ProductsStatus { get; set; }
        public virtual DbSet<ProductsStock> ProductsStock { get; set; }
        public virtual DbSet<ProductsWtg> ProductsWtg { get; set; }
        public virtual DbSet<UnitsOfMeasure> UnitsOfMeasure { get; set; }
        public virtual DbSet<VwJsonFiles> VwJsonFiles { get; set; }
        public virtual DbSet<ZAspNetRoles> ZAspNetRoles { get; set; }
        public virtual DbSet<ZAspNetUserClaims> ZAspNetUserClaims { get; set; }
        public virtual DbSet<ZAspNetUserLogins> ZAspNetUserLogins { get; set; }
        public virtual DbSet<ZAspNetUserRoles> ZAspNetUserRoles { get; set; }
        public virtual DbSet<ZAspNetUsers> ZAspNetUsers { get; set; }
        public virtual DbSet<ZmapSpidApplicationUser> ZmapSpidApplicationUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.EnableSensitiveDataLogging(false);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_Customers_1");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustIdno)
                    .HasColumnName("CustIDNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GemInventory>(entity =>
            {
                entity.HasKey(e => e.GemId);

                entity.Property(e => e.GemId).HasColumnName("GemID");

                entity.Property(e => e.CurrentStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerSku)
                    .HasColumnName("CustomerSKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.DateUsed).HasColumnType("datetime");

                entity.Property(e => e.GemColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedOrderItem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shape)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SizeMm)
                    .HasColumnName("SizeMM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeightCarat)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GemStatus>(entity =>
            {
                entity.Property(e => e.GemStatusId).HasColumnName("GemStatusID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoryLogs>(entity =>
            {
                entity.HasKey(e => e.LogIdx)
                    .HasName("PK__HistoryL__D80CB562542E7F4B");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewFieldValue)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OldFieldValue)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Table)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryLog>(entity =>
            {
                entity.ToTable("Inventory_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BarcodeId).HasColumnName("BarcodeID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.GramWgtNew)
                    .HasColumnName("GramWGT_New")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GramWgtOld)
                    .HasColumnName("GramWGT_Old")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Karat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QtyNew)
                    .HasColumnName("QTY_New")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QtyOld)
                    .HasColumnName("QTY_Old")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.WebUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JewelryType>(entity =>
            {
                entity.Property(e => e.JewelryTypeId).HasColumnName("JewelryTypeID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("Last_login")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LoginId)
                    .HasColumnName("LoginID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<MaterialCodes>(entity =>
            {
                entity.HasKey(e => e.MaterialCodeId);

                entity.Property(e => e.MaterialCodeId).HasColumnName("MaterialCodeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Karat)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MetalMarket>(entity =>
            {
                entity.Property(e => e.MetalMarketId).HasColumnName("MetalMarketID");

                entity.Property(e => e.EnteredDate).HasColumnType("datetime");

                entity.Property(e => e.Gold).HasColumnType("money");

                entity.Property(e => e.MarketDate).HasColumnType("datetime");

                entity.Property(e => e.Palladium).HasColumnType("money");

                entity.Property(e => e.Platinum).HasColumnType("money");

                entity.Property(e => e.Rhodium).HasColumnType("money");

                entity.Property(e => e.Silver).HasColumnType("money");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.OrdersId).HasColumnName("OrdersID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("CustomerID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNoCustomer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNoInternal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrdersDetails>(entity =>
            {
                entity.Property(e => e.OrdersDetailsId).HasColumnName("OrdersDetailsID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrdersId).HasColumnName("OrdersID");

                entity.Property(e => e.ProductsId).HasColumnName("ProductsID");

                entity.Property(e => e.Qtyrequested).HasColumnName("QTYRequested");

                entity.Property(e => e.Qtyshipped).HasColumnName("QTYShipped");

                entity.Property(e => e.Size).HasColumnType("decimal(10, 3)");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.OrdersDetails)
                    .HasForeignKey(d => d.OrdersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersDetails_Orders");
            });

            modelBuilder.Entity<OrdersDetailsRgw>(entity =>
            {
                entity.ToTable("OrdersDetailsRGW");

                entity.Property(e => e.OrdersDetailsRgwid).HasColumnName("OrdersDetailsRGWID");

                entity.Property(e => e.MoldCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.RivaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrderDetails)
                    .WithMany(p => p.OrdersDetailsRgw)
                    .HasForeignKey(d => d.OrderDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersDetailsRGW_OrdersDetails");
            });

            modelBuilder.Entity<OrdersStatus>(entity =>
            {
                entity.Property(e => e.OrdersStatusId).HasColumnName("OrdersStatusID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.ProductsId).HasColumnName("ProductsID");

                entity.Property(e => e.CommentBox)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('RIVA')");

                entity.Property(e => e.CustomerSku)
                    .HasColumnName("CustomerSKU")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstProductionDate).HasColumnType("datetime");

                entity.Property(e => e.PicPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ProductsBom>(entity =>
            {
                entity.ToTable("ProductsBOM");

                entity.Property(e => e.ProductsBomid).HasColumnName("ProductsBOMID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductsId).HasColumnName("ProductsID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Products)
                    .WithMany(p => p.ProductsBom)
                    .HasForeignKey(d => d.ProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductsBOM_Products");
            });

            modelBuilder.Entity<ProductsPrices>(entity =>
            {
                entity.HasKey(e => e.ProductsWhslid)
                    .HasName("PK_ProductsPriceWHSL");

                entity.Property(e => e.ProductsWhslid).HasColumnName("ProductsWHSLID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductsId).HasColumnName("ProductsID");

                entity.Property(e => e.Size).HasColumnType("decimal(3, 2)");

                entity.HasOne(d => d.Products)
                    .WithMany(p => p.ProductsPrices)
                    .HasForeignKey(d => d.ProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductsPrices_Products");
            });

            modelBuilder.Entity<ProductsStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_ProductStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductsStock>(entity =>
            {
                entity.Property(e => e.ProductsStockId).HasColumnName("ProductsStockID");

                entity.Property(e => e.ProductsId).HasColumnName("ProductsID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Size).HasColumnType("decimal(5, 3)");

                entity.Property(e => e.Uom).HasColumnName("UOM");

                entity.HasOne(d => d.Products)
                    .WithMany(p => p.ProductsStock)
                    .HasForeignKey(d => d.ProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductsQTY_Products");
            });

            modelBuilder.Entity<ProductsWtg>(entity =>
            {
                entity.ToTable("ProductsWTG");

                entity.Property(e => e.ProductsWtgid)
                    .HasColumnName("ProductsWTGID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductsId).HasColumnName("ProductsID");

                entity.Property(e => e.Wtg)
                    .HasColumnName("WTG")
                    .HasColumnType("decimal(6, 3)");

                entity.HasOne(d => d.Products)
                    .WithMany(p => p.ProductsWtg)
                    .HasForeignKey(d => d.ProductsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductsWTG_Products");
            });

            modelBuilder.Entity<UnitsOfMeasure>(entity =>
            {
                entity.Property(e => e.UnitsOfMeasureId).HasColumnName("UnitsOfMeasureID");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasColumnName("UOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwJsonFiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_JsonFiles");

                entity.Property(e => e.CustomerOrderNo)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DateEntry).HasColumnType("smalldatetime");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Jsontext)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .HasColumnName("sku")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZAspNetRoles>(entity =>
            {
                entity.ToTable("zAspNetRoles");

                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ZAspNetUserClaims>(entity =>
            {
                entity.ToTable("zAspNetUserClaims");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ZAspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ZAspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.ToTable("zAspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ZAspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ZAspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.ToTable("zAspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ZAspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ZAspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<ZAspNetUsers>(entity =>
            {
                entity.ToTable("zAspNetUsers");

                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ZmapSpidApplicationUser>(entity =>
            {
                entity.HasKey(e => e.Spid)
                    .HasName("PK__map_spid__2DD52ACC019AD4A5");

                entity.ToTable("zmap_spid_application_user");

                entity.Property(e => e.Spid)
                    .HasColumnName("spid")
                    .ValueGeneratedNever();

                entity.Property(e => e.LogId)
                    .HasColumnName("LogID")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
