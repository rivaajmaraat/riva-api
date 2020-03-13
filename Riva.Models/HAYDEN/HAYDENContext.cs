using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Riva.Models.Models
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

        public virtual DbSet<ComponentInventoryTry> ComponentInventoryTry { get; set; }
        public virtual DbSet<ComponentTypes> ComponentTypes { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<InventoryLog> InventoryLog { get; set; }
        public virtual DbSet<JsonFiles> JsonFiles { get; set; }
        public virtual DbSet<JsonFilesTests> JsonFilesTests { get; set; }
        public virtual DbSet<Logins> Logins { get; set; }
        public virtual DbSet<MapSpidApplicationUser> MapSpidApplicationUser { get; set; }
        public virtual DbSet<MaterialCodes> MaterialCodes { get; set; }
        public virtual DbSet<MetalKarats> MetalKarats { get; set; }
        public virtual DbSet<MetalTypes> MetalTypes { get; set; }
        public virtual DbSet<OrderDetailsTry> OrderDetailsTry { get; set; }
        public virtual DbSet<OrderDetailsTrytest> OrderDetailsTrytest { get; set; }
        public virtual DbSet<OrderStates> OrderStates { get; set; }
        public virtual DbSet<OrdersTestTry> OrdersTestTry { get; set; }
        public virtual DbSet<OrdersTry> OrdersTry { get; set; }
        public virtual DbSet<ProductBomTry> ProductBomTry { get; set; }
        public virtual DbSet<ProductTypes> ProductTypes { get; set; }
        public virtual DbSet<ProductsTry> ProductsTry { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Types> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.EnableSensitiveDataLogging(false);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComponentInventoryTry>(entity =>
            {
                entity.HasKey(e => e.ComponentId);

                entity.ToTable("ComponentInventory_TRY");

                entity.HasIndex(e => e.ComponentTypeId)
                    .HasName("IX_FK_Component_Type_1");

                entity.Property(e => e.ComponentId).HasColumnName("ComponentID");

                entity.Property(e => e.ComponentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentTypeId).HasColumnName("ComponentTypeID");

                entity.Property(e => e.DiaQty10).HasColumnName("Dia_QTY_1_0");

                entity.Property(e => e.DiaQty13).HasColumnName("Dia_QTY_1_3");

                entity.Property(e => e.DiaQty15).HasColumnName("Dia_QTY_1_5");

                entity.Property(e => e.DiaQty18).HasColumnName("Dia_QTY_1_8");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxStock14rg).HasColumnName("MaxStock_14RG");

                entity.Property(e => e.MaxStock14wg).HasColumnName("MaxStock_14WG");

                entity.Property(e => e.MaxStock14yg).HasColumnName("MaxStock_14YG");

                entity.Property(e => e.MaxStock18rg).HasColumnName("MaxStock_18RG");

                entity.Property(e => e.MaxStock18wg).HasColumnName("MaxStock_18WG");

                entity.Property(e => e.MaxStock18yg).HasColumnName("MaxStock_18YG");

                entity.Property(e => e.MaxStockSs).HasColumnName("MaxStock_SS");

                entity.Property(e => e.MinStock14rg).HasColumnName("MinStock_14RG");

                entity.Property(e => e.MinStock14wg).HasColumnName("MinStock_14WG");

                entity.Property(e => e.MinStock14yg).HasColumnName("MinStock_14YG");

                entity.Property(e => e.MinStock18rg).HasColumnName("MinStock_18RG");

                entity.Property(e => e.MinStock18wg).HasColumnName("MinStock_18WG");

                entity.Property(e => e.MinStock18yg).HasColumnName("MinStock_18YG");

                entity.Property(e => e.MinStockSs).HasColumnName("MinStock_SS");

                entity.Property(e => e.Series)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stock14rg).HasColumnName("Stock_14RG");

                entity.Property(e => e.Stock14wg).HasColumnName("Stock_14WG");

                entity.Property(e => e.Stock14yg).HasColumnName("Stock_14YG");

                entity.Property(e => e.Stock18rg).HasColumnName("Stock_18RG");

                entity.Property(e => e.Stock18wg).HasColumnName("Stock_18WG");

                entity.Property(e => e.Stock18yg).HasColumnName("Stock_18YG");

                entity.Property(e => e.StockSs).HasColumnName("Stock_SS");

                entity.HasOne(d => d.ComponentType)
                    .WithMany(p => p.ComponentInventoryTry)
                    .HasForeignKey(d => d.ComponentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Component_Type_1");
            });

            modelBuilder.Entity<ComponentTypes>(entity =>
            {
                entity.HasKey(e => e.ComponentTypeId);

                entity.Property(e => e.ComponentTypeId).HasColumnName("ComponentTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

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

            modelBuilder.Entity<JsonFiles>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.DateEntry).HasColumnType("datetime");

                entity.Property(e => e.Jsontext)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JsonFilesTests>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.DateEntry).HasColumnType("datetime");

                entity.Property(e => e.Jsontext)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Logins>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("Last_login")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoginId)
                    .HasColumnName("LoginID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MapSpidApplicationUser>(entity =>
            {
                entity.HasKey(e => e.Spid);

                entity.ToTable("map_spid_application_user");

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

            modelBuilder.Entity<MaterialCodes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

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

            modelBuilder.Entity<MetalKarats>(entity =>
            {
                entity.HasKey(e => e.KaratId);

                entity.HasIndex(e => e.StatusId)
                    .HasName("IX_FK_Karat_Status");

                entity.Property(e => e.KaratId).HasColumnName("KaratID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MetalKarats)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Karat_Status");
            });

            modelBuilder.Entity<MetalTypes>(entity =>
            {
                entity.HasKey(e => e.ColorId);

                entity.HasIndex(e => e.StatusId)
                    .HasName("IX_FK_Color_Status");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MetalTypes)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Color_Status");
            });

            modelBuilder.Entity<OrderDetailsTry>(entity =>
            {
                entity.HasKey(e => e.OrderIdx);

                entity.ToTable("OrderDetails_TRY");

                entity.HasIndex(e => e.ColorId)
                    .HasName("IX_FK_Order_TRY_Color");

                entity.HasIndex(e => e.KaratId)
                    .HasName("IX_FK_Order_TRY_Karat");

                entity.HasIndex(e => e.OrderStateId)
                    .HasName("IX_FK_Order_TRY_OrderState");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_FK_Order_TRY_Type");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ColorId2nd).HasColumnName("ColorID_2nd");

                entity.Property(e => e.Comments)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customizeable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSku)
                    .IsRequired()
                    .HasColumnName("ItemSKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jeweler)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.KaratId).HasColumnName("KaratID");

                entity.Property(e => e.KaratId2nd).HasColumnName("KaratID_2nd");

                entity.Property(e => e.OrderStateId).HasColumnName("OrderStateID");

                entity.Property(e => e.Size).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.OrderDetailsTry)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_TRY_Color");

                entity.HasOne(d => d.Karat)
                    .WithMany(p => p.OrderDetailsTry)
                    .HasForeignKey(d => d.KaratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_TRY_Karat");

                entity.HasOne(d => d.OrderState)
                    .WithMany(p => p.OrderDetailsTry)
                    .HasForeignKey(d => d.OrderStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_TRY_OrderState");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.OrderDetailsTry)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_TRY_Type");
            });

            modelBuilder.Entity<OrderDetailsTrytest>(entity =>
            {
                entity.HasKey(e => e.OrderIdx);

                entity.ToTable("OrderDetails_TRYTest");

                entity.HasIndex(e => e.ColorId)
                    .HasName("IX_FK_Order_TRY_ColorTest");

                entity.HasIndex(e => e.KaratId)
                    .HasName("IX_FK_Order_TRY_KaratTest");

                entity.HasIndex(e => e.OrderStateId)
                    .HasName("IX_FK_Order_TRY_OrderStateTest");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_FK_Order_TRY_TypeTest");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ColorId2nd).HasColumnName("ColorID_2nd");

                entity.Property(e => e.Comments)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customizeable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemSku)
                    .IsRequired()
                    .HasColumnName("ItemSKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jeweler)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.KaratId).HasColumnName("KaratID");

                entity.Property(e => e.KaratId2nd).HasColumnName("KaratID_2nd");

                entity.Property(e => e.OrderStateId).HasColumnName("OrderStateID");

                entity.Property(e => e.Size).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.OrderDetailsTrytest)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_TRY_ColorTest");

                entity.HasOne(d => d.Karat)
                    .WithMany(p => p.OrderDetailsTrytest)
                    .HasForeignKey(d => d.KaratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_TRY_KaratTest");

                entity.HasOne(d => d.OrderState)
                    .WithMany(p => p.OrderDetailsTrytest)
                    .HasForeignKey(d => d.OrderStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_TRY_OrderStateTest");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.OrderDetailsTrytest)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_TRY_TypeTest");
            });

            modelBuilder.Entity<OrderStates>(entity =>
            {
                entity.HasKey(e => e.OrderStateId);

                entity.Property(e => e.OrderStateId).HasColumnName("OrderStateID");

                entity.Property(e => e.StateDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<OrdersTestTry>(entity =>
            {
                entity.HasKey(e => e.CustomerOrderNo);

                entity.ToTable("OrdersTest_TRY");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_FK_Orders_CustomersTest1");

                entity.HasIndex(e => e.OrderStateId)
                    .HasName("IX_FK_Orders_OrderStateTest1");

                entity.Property(e => e.CustomerOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("CustomerID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStateId).HasColumnName("OrderStateID");

                entity.Property(e => e.RawPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPerson)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipVia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrdersTestTry)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_CustomersTest1");

                entity.HasOne(d => d.OrderState)
                    .WithMany(p => p.OrdersTestTry)
                    .HasForeignKey(d => d.OrderStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_OrderStateTest1");
            });

            modelBuilder.Entity<OrdersTry>(entity =>
            {
                entity.HasKey(e => e.CustomerOrderNo);

                entity.ToTable("Orders_TRY");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_FK_Orders_Customers1");

                entity.HasIndex(e => e.OrderStateId)
                    .HasName("IX_FK_Orders_OrderState1");

                entity.Property(e => e.CustomerOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("CustomerID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerOrderDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStateId).HasColumnName("OrderStateID");

                entity.Property(e => e.RawPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPerson)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPostalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipVia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrdersTry)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Customers1");

                entity.HasOne(d => d.OrderState)
                    .WithMany(p => p.OrdersTry)
                    .HasForeignKey(d => d.OrderStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_OrderState1");
            });

            modelBuilder.Entity<ProductBomTry>(entity =>
            {
                entity.HasKey(e => e.BomIdx);

                entity.ToTable("ProductBOM_TRY");

                entity.Property(e => e.ComponentName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSku)
                    .IsRequired()
                    .HasColumnName("ProductSKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductTypes>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId);

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ProductsTry>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Products_TRY");

                entity.HasIndex(e => e.StatusId)
                    .HasName("IX_FK_Products_TRY_Status");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CommentsPd)
                    .HasColumnName("CommentsPD")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CommentsRouting)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSku)
                    .IsRequired()
                    .HasColumnName("CustomerSKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEditted).HasColumnType("datetime");

                entity.Property(e => e.InternalSku)
                    .HasColumnName("InternalSKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PicturePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ProductsTry)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_TRY_Status");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Types>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
