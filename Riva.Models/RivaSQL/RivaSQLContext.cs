using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Riva.Models.RivaSQL
{
    public partial class RivaSQLContext : DbContext
    {
        public RivaSQLContext()
        {
        }

        public RivaSQLContext(DbContextOptions<RivaSQLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<RivaSqlorders> RivaSqlorders { get; set; }
        public virtual DbSet<TblInventoryBarCodeLog> TblInventoryBarCodeLog { get; set; }
        public virtual DbSet<TblInventoryFgLog> TblInventoryFgLog { get; set; }
        public virtual DbSet<TblInventorySaLog> TblInventorySaLog { get; set; }
        public virtual DbSet<VwTblWkoInOutQtyWeightVaultScanInOut> VwTblWkoInOutQtyWeightVaultScanInOut { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RivaSQL;User Id=sa;Password=pass123456;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderItem);

                entity.ToTable("Order_Details");

                entity.Property(e => e.OrderItem).HasColumnName("order_item");

                entity.Property(e => e.Agtacode)
                    .HasColumnName("AGTACode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyDate)
                    .HasColumnName("buy_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BuyGold).HasColumnName("Buy_Gold");

                entity.Property(e => e.COrderLineStatus)
                    .HasColumnName("cOrderLineStatus")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(40);

                entity.Property(e => e.DiamondNo).HasMaxLength(14);

                entity.Property(e => e.ForeCastId).HasColumnName("ForeCastID");

                entity.Property(e => e.Freeform1)
                    .HasColumnName("freeform1")
                    .HasMaxLength(100);

                entity.Property(e => e.Freeform2)
                    .HasColumnName("freeform2")
                    .HasMaxLength(50);

                entity.Property(e => e.GoldDwt).HasColumnName("gold_dwt");

                entity.Property(e => e.GramPrice)
                    .HasColumnName("Gram_Price")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.HofLabor)
                    .HasColumnName("HOF_Labor")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Karat).HasColumnName("karat");

                entity.Property(e => e.Mdate)
                    .HasColumnName("mdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MktpriceG)
                    .HasColumnName("MKTPrice_G")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MktpricePalladium)
                    .HasColumnName("MKTPrice_Palladium")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MktpricePt)
                    .HasColumnName("MKTPrice_PT")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MktpriceRuthenium)
                    .HasColumnName("MKTPrice_Ruthenium")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MktpriceSs)
                    .HasColumnName("MKTPrice_SS")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcGoldKt).HasColumnName("MTC_GoldKT");

                entity.Property(e => e.MtcGoldWtgrm)
                    .HasColumnName("MTC_GoldWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcPtwtgrm)
                    .HasColumnName("MTC_PTWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcSilverWtgrm)
                    .HasColumnName("MTC_SilverWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcStoneCost)
                    .HasColumnName("MTC_StoneCost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Muser)
                    .HasColumnName("muser")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.OrderType).HasColumnName("Order_Type");

                entity.Property(e => e.OrderedRm).HasColumnName("OrderedRM");

                entity.Property(e => e.PostedToWax).HasColumnName("posted_to_wax");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.ProductNo)
                    .HasColumnName("Product_No")
                    .HasMaxLength(20);

                entity.Property(e => e.QtyAllocated).HasColumnName("qty_allocated");

                entity.Property(e => e.QtyBo).HasColumnName("Qty_BO");

                entity.Property(e => e.QtyPacked).HasColumnName("qty_packed");

                entity.Property(e => e.ReqDateSku)
                    .HasColumnName("ReqDate_SKU")
                    .HasColumnType("datetime");

                entity.Property(e => e.RmorderNo).HasColumnName("RMorderNo");

                entity.Property(e => e.SalePosted).HasColumnName("Sale_Posted");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(10);

                entity.Property(e => e.So)
                    .HasColumnName("SO")
                    .HasMaxLength(20);

                entity.Property(e => e.SpCharges).HasColumnName("SP_Charges");

                entity.Property(e => e.StoneDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoneRecDate).HasColumnType("datetime");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit_Price")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UpdateCustomerPrice).HasColumnName("update_customer_price");
            });

            modelBuilder.Entity<RivaSqlorders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("RivaSQLorders");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasColumnName("company")
                    .HasMaxLength(1);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("Customer_ID")
                    .HasMaxLength(6);

                entity.Property(e => e.CustomerOrderNo)
                    .IsRequired()
                    .HasColumnName("Customer_Order_No")
                    .HasMaxLength(12);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Freight).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.GoldDate)
                    .HasColumnName("Gold_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GoldPrice)
                    .HasColumnName("Gold_Price")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.InvoiceComments)
                    .HasColumnName("Invoice_Comments")
                    .HasMaxLength(150);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderSource)
                    .HasColumnName("Order_Source")
                    .HasMaxLength(5);

                entity.Property(e => e.OrderType).HasColumnName("ORDER_TYPE");

                entity.Property(e => e.OriginalReqDateRo)
                    .HasColumnName("Original_ReqDate_RO")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequiredDate)
                    .HasColumnName("Required_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipAddress1)
                    .IsRequired()
                    .HasColumnName("Ship_Address1")
                    .HasMaxLength(60);

                entity.Property(e => e.ShipAddress2)
                    .HasColumnName("ship_address2")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipCity)
                    .IsRequired()
                    .HasColumnName("Ship_City")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipCountry)
                    .HasColumnName("Ship_Country")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasColumnName("Ship_Name")
                    .HasMaxLength(40);

                entity.Property(e => e.ShipPostalCode)
                    .IsRequired()
                    .HasColumnName("Ship_Postal_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipRegion)
                    .IsRequired()
                    .HasColumnName("Ship_Region")
                    .HasMaxLength(15);

                entity.Property(e => e.ShipVia)
                    .HasColumnName("Ship_Via")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippedDate)
                    .HasColumnName("Shipped_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SoftwareId)
                    .HasColumnName("SoftwareID")
                    .HasMaxLength(4);

                entity.Property(e => e.StoreNumber)
                    .IsRequired()
                    .HasColumnName("Store_Number")
                    .HasMaxLength(10);

                entity.Property(e => e.Uadyso)
                    .HasColumnName("UADYSO")
                    .HasMaxLength(12);

                entity.Property(e => e.Uapoid).HasColumnName("UAPOID");
            });

            modelBuilder.Entity<TblInventoryBarCodeLog>(entity =>
            {
                entity.ToTable("tbl_Inventory_BarCode_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.GramsPerUnit).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Item)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Iuom)
                    .HasColumnName("IUOM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Karat)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UserMachine)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInventoryFgLog>(entity =>
            {
                entity.HasKey(e => e.ITransId);

                entity.ToTable("tbl_Inventory_FG_Log");

                entity.Property(e => e.ITransId).HasColumnName("iTrans_ID");

                entity.Property(e => e.CInventoryNo)
                    .HasColumnName("cInventory_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSource)
                    .HasColumnName("cSource")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CStation)
                    .HasColumnName("cStation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CUom)
                    .HasColumnName("cUOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CUser)
                    .HasColumnName("cUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtDate)
                    .HasColumnName("dtDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IInventoryId).HasColumnName("iInventory_ID");

                entity.Property(e => e.ISourceDocId).HasColumnName("iSource_Doc_ID");

                entity.Property(e => e.ITransAmt)
                    .HasColumnName("iTrans_Amt")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ITransWt)
                    .HasColumnName("iTrans_Wt")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcGoldKt)
                    .HasColumnName("MTC_GoldKT")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcGoldWtgrm)
                    .HasColumnName("MTC_GoldWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcPtwtgrm)
                    .HasColumnName("MTC_PTWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcSilverWtgrm)
                    .HasColumnName("MTC_SilverWtgrm")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<TblInventorySaLog>(entity =>
            {
                entity.HasKey(e => e.ITransId);

                entity.ToTable("tbl_Inventory_SA_Log");

                entity.Property(e => e.ITransId).HasColumnName("iTrans_ID");

                entity.Property(e => e.CInventoryNo)
                    .HasColumnName("cInventory_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSource)
                    .HasColumnName("cSource")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CStation)
                    .HasColumnName("cStation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CUom)
                    .HasColumnName("cUOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CUser)
                    .HasColumnName("cUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtDate)
                    .HasColumnName("dtDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IInventoryId).HasColumnName("iInventory_ID");

                entity.Property(e => e.ISourceDocId).HasColumnName("iSource_Doc_ID");

                entity.Property(e => e.ITransAmt)
                    .HasColumnName("iTrans_Amt")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ITransWt)
                    .HasColumnName("iTrans_Wt")
                    .HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<VwTblWkoInOutQtyWeightVaultScanInOut>(entity =>
            {
                entity.HasKey(e => e.Wko);

                entity.ToTable("vw_tbl_WKO_IN_OUT_Qty_Weight_VaultScan_IN_OUT");

                entity.Property(e => e.Wko)
                    .HasColumnName("WKO")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductStyle)
                    .HasColumnName("Product_Style")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
