using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Riva.Models.RivaData
{
    public partial class RivaDataContext : DbContext
    {
        public RivaDataContext()
        {
        }

        public RivaDataContext(DbContextOptions<RivaDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RawMaterials> RawMaterials { get; set; }
        public virtual DbSet<RivaCustomers> RivaCustomers { get; set; }
        public virtual DbSet<RivaDataProducts> RivaDataProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Move this to secrets.json
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RivaData;User Id=sa;Password=pass123456;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RawMaterials>(entity =>
            {
                entity.HasKey(e => e.PartNo);

                entity.ToTable("Raw_materials");

                entity.Property(e => e.PartNo)
                    .HasColumnName("Part_No")
                    .HasMaxLength(20);

                entity.Property(e => e.Adjusted).HasColumnName("adjusted");

                entity.Property(e => e.BombyUser)
                    .HasColumnName("BOMByUser")
                    .HasMaxLength(50);

                entity.Property(e => e.Casting).HasColumnName("casting");

                entity.Property(e => e.Category).HasMaxLength(40);

                entity.Property(e => e.ClampPressure).HasColumnName("Clamp_Pressure");

                entity.Property(e => e.Comments1Rt).HasColumnName("Comments1RT");

                entity.Property(e => e.Cost).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Customer).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(65);

                entity.Property(e => e.Dewax).HasColumnName("DEWAX");

                entity.Property(e => e.GA).HasColumnName("G___A");

                entity.Property(e => e.GoldWeight).HasColumnName("gold_weight");

                entity.Property(e => e.ImageLocation)
                    .HasColumnName("Image_Location")
                    .HasMaxLength(200);

                entity.Property(e => e.InhouseCast).HasColumnName("inhouseCast");

                entity.Property(e => e.InspectedBom).HasColumnName("InspectedBOM");

                entity.Property(e => e.JewelrySa).HasColumnName("JewelrySA");

                entity.Property(e => e.Karat).HasColumnName("karat");

                entity.Property(e => e.Labor)
                    .HasColumnName("labor")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(10);

                entity.Property(e => e.MatelWeight).HasColumnName("Matel_Weight");

                entity.Property(e => e.MaterialCost)
                    .HasColumnName("material_cost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MaterialPressure).HasColumnName("Material_Pressure");

                entity.Property(e => e.MaterialTemp).HasColumnName("Material_Temp");

                entity.Property(e => e.MaterialType).HasMaxLength(12);

                entity.Property(e => e.MetalId)
                    .HasColumnName("Metal_ID")
                    .HasMaxLength(20);

                entity.Property(e => e.MoldType).HasMaxLength(15);

                entity.Property(e => e.MtcGoldKt).HasColumnName("MTC_GoldKT");

                entity.Property(e => e.MtcGoldWtgrm)
                    .HasColumnName("MTC_GoldWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcPldwtgrm)
                    .HasColumnName("MTC_PLDWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcPtwtgrm)
                    .HasColumnName("MTC_PTWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcSilverWtgrm)
                    .HasColumnName("MTC_SilverWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcStnwtgrm)
                    .HasColumnName("MTC_STNWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcinvInvalid).HasColumnName("MTCINV_Invalid");

                entity.Property(e => e.MtcinvInventory).HasColumnName("MTCINV_Inventory");

                entity.Property(e => e.MtcinvTrans).HasColumnName("MTCINV_Trans");

                entity.Property(e => e.OutSideVendorId).HasColumnName("OutSideVendorID");

                entity.Property(e => e.PartNoOld)
                    .HasColumnName("Part_NoOld")
                    .HasMaxLength(14);

                entity.Property(e => e.Pdapproved).HasColumnName("PDapproved");

                entity.Property(e => e.Pocategory)
                    .HasColumnName("POCategory")
                    .HasMaxLength(10);

                entity.Property(e => e.Pum)
                    .HasColumnName("PUM")
                    .HasMaxLength(10);

                entity.Property(e => e.Qaapproved).HasColumnName("QAapproved");

                entity.Property(e => e.QtyInStock).HasColumnName("Qty_in_Stock");

                entity.Property(e => e.QtyOnOrder).HasColumnName("Qty_on_Order");

                entity.Property(e => e.QtyReqd).HasColumnName("Qty_Reqd");

                entity.Property(e => e.QualityGuidelines).HasColumnName("Quality_guidelines");

                entity.Property(e => e.Rmcellno)
                    .HasColumnName("RMCellno")
                    .HasMaxLength(10);

                entity.Property(e => e.RmmetalColor)
                    .HasColumnName("RMMetalColor")
                    .HasMaxLength(2);

                entity.Property(e => e.RmpriceType)
                    .HasColumnName("RMPriceType")
                    .HasMaxLength(15);

                entity.Property(e => e.RmunitPrice)
                    .HasColumnName("RMUnit_Price")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SaId)
                    .HasColumnName("SA_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Sacategory)
                    .HasColumnName("SACategory")
                    .HasMaxLength(15);

                entity.Property(e => e.ShootingTime)
                    .HasColumnName("Shooting_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Shots).HasColumnName("shots");

                entity.Property(e => e.Size).HasMaxLength(10);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .HasColumnName("SSMA_TimeStamp")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.TakesRm).HasColumnName("TakesRM");

                entity.Property(e => e.TimeRequired).HasColumnType("datetime");

                entity.Property(e => e.ToolDie).HasColumnName("tool___Die");

                entity.Property(e => e.TreeType).HasMaxLength(15);

                entity.Property(e => e.UnitOfMes).HasMaxLength(10);

                entity.Property(e => e.Used).HasColumnName("used");

                entity.Property(e => e.VendorId).HasColumnName("Vendor_ID");

                entity.Property(e => e.VendorItemNo).HasMaxLength(18);

                entity.Property(e => e.WeightUom)
                    .HasColumnName("WeightUOM")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<RivaCustomers>(entity =>
            {
                entity.HasKey(e => e.StoreNumber);

                entity.Property(e => e.StoreNumber)
                    .HasColumnName("Store_Number")
                    .HasMaxLength(10);

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(30);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Comments1)
                    .HasColumnName("comments1")
                    .HasMaxLength(40);

                entity.Property(e => e.Comments2)
                    .HasColumnName("comments2")
                    .HasMaxLength(40);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company_Name")
                    .HasMaxLength(40);

                entity.Property(e => e.ContactName)
                    .HasColumnName("Contact_Name")
                    .HasMaxLength(30);

                entity.Property(e => e.Country).HasMaxLength(30);

                entity.Property(e => e.CustIdno)
                    .HasColumnName("CustIDNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("Customer_ID")
                    .HasMaxLength(8);

                entity.Property(e => e.Department).HasMaxLength(8);

                entity.Property(e => e.Fax).HasMaxLength(14);

                entity.Property(e => e.LastSaleAmount)
                    .HasColumnName("Last_Sale_Amount")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LastSaleDate)
                    .HasColumnName("Last_Sale_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentDiscountPercent).HasColumnName("Payment_discount_Percent");

                entity.Property(e => e.PaymentDiscountTerms).HasColumnName("Payment_discount_terms");

                entity.Property(e => e.Phone).HasMaxLength(14);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ProductCc)
                    .HasColumnName("ProductCC")
                    .HasMaxLength(8);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.SalesToDate)
                    .HasColumnName("Sales_to_Date")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Salesman).HasColumnName("salesman");

                entity.Property(e => e.ShipAddress1)
                    .IsRequired()
                    .HasColumnName("ship_address1")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipAddress2)
                    .HasColumnName("ship_address2")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipCity)
                    .IsRequired()
                    .HasColumnName("ship_city")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasColumnName("ship_name")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipState)
                    .IsRequired()
                    .HasColumnName("ship_state")
                    .HasMaxLength(2);

                entity.Property(e => e.ShipZip)
                    .IsRequired()
                    .HasColumnName("ship_zip")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingMethod)
                    .HasColumnName("shipping_method")
                    .HasMaxLength(10);

                entity.Property(e => e.SoftwareId)
                    .HasColumnName("SoftwareID")
                    .HasMaxLength(4);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .HasColumnName("SSMA_TimeStamp")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.Terms).HasColumnName("terms");
            });

            modelBuilder.Entity<RivaDataProducts>(entity =>
            {
                entity.HasKey(e => e.ProductNo);

                entity.Property(e => e.ProductNo)
                    .HasColumnName("Product_no")
                    .HasMaxLength(20);

                entity.Property(e => e.AdjustedQty).HasColumnName("adjusted_qty");

                entity.Property(e => e.Agtacode)
                    .HasColumnName("AGTACode")
                    .HasMaxLength(50);

                entity.Property(e => e.Allocated).HasColumnName("allocated");

                entity.Property(e => e.Approved1).HasColumnName("Approved_1");

                entity.Property(e => e.Approved2).HasColumnName("Approved_2");

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("Approved_By")
                    .HasMaxLength(50);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("Approved_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssemblyCost)
                    .HasColumnName("assembly_cost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AvgCost)
                    .HasColumnName("Avg_Cost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BombyUser)
                    .HasColumnName("BOMByUser")
                    .HasMaxLength(50);

                entity.Property(e => e.CellName).HasMaxLength(10);

                entity.Property(e => e.Cellno).HasMaxLength(10);

                entity.Property(e => e.Class).HasMaxLength(8);

                entity.Property(e => e.Comments1).HasColumnName("comments1");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CpNotes).HasColumnName("CP_Notes");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.CustomerCode).HasMaxLength(8);

                entity.Property(e => e.DateRangeString).HasMaxLength(255);

                entity.Property(e => e.Dcolor).HasMaxLength(50);

                entity.Property(e => e.Dquality)
                    .HasColumnName("DQuality")
                    .HasMaxLength(50);

                entity.Property(e => e.Dshape)
                    .HasColumnName("DShape")
                    .HasMaxLength(50);

                entity.Property(e => e.Fjeu).HasColumnName("FJEU");

                entity.Property(e => e.GA).HasColumnName("G_A");

                entity.Property(e => e.Gcolor)
                    .HasColumnName("GColor")
                    .HasMaxLength(1);

                entity.Property(e => e.GoldDwt).HasColumnName("gold_dwt");

                entity.Property(e => e.GroupCode).HasMaxLength(8);

                entity.Property(e => e.Hofcasting).HasColumnName("HOFCasting");

                entity.Property(e => e.HofcastingCarrera).HasColumnName("HOFCastingCarrera");

                entity.Property(e => e.HofcastingRiva).HasColumnName("HOFCastingRiva");

                entity.Property(e => e.ImageLastUpdated)
                    .HasColumnName("Image_LastUpdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImageLocation)
                    .HasColumnName("Image_Location")
                    .HasMaxLength(200);

                entity.Property(e => e.InhouseCast).HasColumnName("inhouseCast");

                entity.Property(e => e.InitialWeight).HasColumnName("Initial_Weight");

                entity.Property(e => e.InnerDiameter).HasColumnName("Inner_Diameter");

                entity.Property(e => e.InspectedBom).HasColumnName("InspectedBOM");

                entity.Property(e => e.ItemStatus).HasMaxLength(25);

                entity.Property(e => e.JewelryCategory).HasMaxLength(15);

                entity.Property(e => e.Karat).HasColumnName("karat");

                entity.Property(e => e.LastSaleDate)
                    .HasColumnName("Last_sale_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LastUpdated_By")
                    .HasMaxLength(50);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(10);

                entity.Property(e => e.MainNotes).HasColumnName("Main_Notes");

                entity.Property(e => e.ManufacturingCost)
                    .HasColumnName("manufacturing_cost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MarkUp).HasColumnName("mark_up");

                entity.Property(e => e.MaxCost)
                    .HasColumnName("Max_Cost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MaxStockAllowed).HasColumnName("Max_Stock_Allowed");

                entity.Property(e => e.MaxWoQtyAllowed).HasColumnName("Max_WO_Qty_Allowed");

                entity.Property(e => e.MetalColor).HasMaxLength(2);

                entity.Property(e => e.MetalType).HasMaxLength(4);

                entity.Property(e => e.MfgCategory).HasMaxLength(15);

                entity.Property(e => e.MfgGoldKt).HasColumnName("MFG_GoldKT");

                entity.Property(e => e.MfgGoldWtgrm)
                    .HasColumnName("MFG_GoldWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MfgPldwtgrm)
                    .HasColumnName("MFG_PLDWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MfgPtwtgrm)
                    .HasColumnName("MFG_PTWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MfgSilverWtgrm)
                    .HasColumnName("MFG_SilverWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MfgStnwtgrm)
                    .HasColumnName("MFG_STNWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MinCost)
                    .HasColumnName("Min_Cost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MinStockAllowed).HasColumnName("Min_Stock_Allowed");

                entity.Property(e => e.MktpriceGold)
                    .HasColumnName("MKTPrice_Gold")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MktpricePld)
                    .HasColumnName("MKTPrice_PLD")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MktpricePt)
                    .HasColumnName("MKTPrice_PT")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MktpriceSs)
                    .HasColumnName("MKTPrice_SS")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcGoldKt).HasColumnName("MTC_GoldKT");

                entity.Property(e => e.MtcGoldWtgrm)
                    .HasColumnName("MTC_GoldWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcPldwtgrm)
                    .HasColumnName("MTC_PLDWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcPtwtgrm)
                    .HasColumnName("MTC_PTWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcQcsswt)
                    .HasColumnName("MTC_QCsswt")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcSilverWtgrm)
                    .HasColumnName("MTC_SilverWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcStnwtgrm)
                    .HasColumnName("MTC_STNWtgrm")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcStoneCost)
                    .HasColumnName("MTC_StoneCost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MtcinvInvalid).HasColumnName("MTCINV_Invalid");

                entity.Property(e => e.MtcinvInventory).HasColumnName("MTCINV_Inventory");

                entity.Property(e => e.MtcinvTrans).HasColumnName("MTCINV_Trans");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasMaxLength(50);

                entity.Property(e => e.OuterDiameter).HasColumnName("Outer_Diameter");

                entity.Property(e => e.Pdapproved).HasColumnName("PDApproved");

                entity.Property(e => e.Pdcategory)
                    .HasColumnName("PDCategory")
                    .HasMaxLength(20);

                entity.Property(e => e.Picture).HasMaxLength(2);

                entity.Property(e => e.PriceScheme)
                    .HasColumnName("Price_Scheme")
                    .HasMaxLength(10);

                entity.Property(e => e.PriceType).HasMaxLength(15);

                entity.Property(e => e.ProductCode).HasColumnName("Product_Code");

                entity.Property(e => e.ProductCost)
                    .HasColumnName("Product_Cost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product_Name")
                    .HasMaxLength(40);

                entity.Property(e => e.ProductoldNo)
                    .HasColumnName("Productold_no")
                    .HasMaxLength(20);

                entity.Property(e => e.Pum)
                    .HasColumnName("PUM")
                    .HasMaxLength(20);

                entity.Property(e => e.Qaapproved).HasColumnName("QAapproved");

                entity.Property(e => e.Qccode)
                    .HasColumnName("QCCode")
                    .HasMaxLength(10);

                entity.Property(e => e.QfreqType)
                    .HasColumnName("QFReqType")
                    .HasMaxLength(1);

                entity.Property(e => e.QtyOnOrder).HasColumnName("qty_on_order");

                entity.Property(e => e.QtyRequired).HasColumnName("qty_required");

                entity.Property(e => e.QualityFunctionalRequirements).HasColumnName("Quality_Functional_requirements");

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RoutingApply).HasColumnName("Routing_Apply");

                entity.Property(e => e.SerialId)
                    .HasColumnName("SerialID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SettingCost)
                    .HasColumnName("Setting_Cost")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ShippingWtUom).HasColumnName("ShippingWtUOM");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(10);

                entity.Property(e => e.SkuApproval).HasColumnName("SKU_approval");

                entity.Property(e => e.SkucountryOrigin)
                    .HasColumnName("SKUCountryOrigin")
                    .HasMaxLength(12);

                entity.Property(e => e.Softness).HasMaxLength(50);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .HasColumnName("SSMA_TimeStamp")
                    .HasMaxLength(8)
                    .IsFixedLength();

                entity.Property(e => e.StoneDesc).HasMaxLength(100);

                entity.Property(e => e.StoneShap).HasMaxLength(50);

                entity.Property(e => e.StoneType).HasMaxLength(50);

                entity.Property(e => e.StoneWt).HasMaxLength(20);

                entity.Property(e => e.Stonequality).HasMaxLength(50);

                entity.Property(e => e.StorageHandling).HasMaxLength(20);

                entity.Property(e => e.StorageLocation).HasMaxLength(20);

                entity.Property(e => e.Style).HasMaxLength(20);

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.TagText1)
                    .HasColumnName("tag_text1")
                    .HasMaxLength(10);

                entity.Property(e => e.TagText2)
                    .HasColumnName("tag_text2")
                    .HasMaxLength(10);

                entity.Property(e => e.TagText3)
                    .HasColumnName("tag_text3")
                    .HasMaxLength(10);

                entity.Property(e => e.TagText4)
                    .HasColumnName("tag_text4")
                    .HasMaxLength(10);

                entity.Property(e => e.TakesRm).HasColumnName("TakesRM");

                entity.Property(e => e.TempWeight).HasColumnName("Temp_Weight");

                entity.Property(e => e.Thickness).HasMaxLength(50);

                entity.Property(e => e.TiffCategoryCode)
                    .HasColumnName("Tiff_Category_Code")
                    .HasMaxLength(5);

                entity.Property(e => e.TiffClass).HasColumnName("Tiff_Class");

                entity.Property(e => e.TiffColor).HasColumnName("Tiff_Color");

                entity.Property(e => e.TiffColorDesc)
                    .HasColumnName("Tiff_Color_Desc")
                    .HasMaxLength(25);

                entity.Property(e => e.TiffDept).HasColumnName("Tiff_Dept");

                entity.Property(e => e.TiffDescription)
                    .HasColumnName("Tiff_Description")
                    .HasMaxLength(50);

                entity.Property(e => e.TiffMaterial)
                    .HasColumnName("Tiff_Material")
                    .HasMaxLength(15);

                entity.Property(e => e.TiffMethodCode)
                    .HasColumnName("Tiff_Method_Code")
                    .HasMaxLength(5);

                entity.Property(e => e.TiffMfgNo)
                    .HasColumnName("Tiff_Mfg_No")
                    .HasMaxLength(20);

                entity.Property(e => e.TiffSize).HasColumnName("Tiff_Size");

                entity.Property(e => e.TiffSizeDesc)
                    .HasColumnName("Tiff_Size_Desc")
                    .HasMaxLength(5);

                entity.Property(e => e.TiffStatusCode)
                    .HasColumnName("Tiff_Status_Code")
                    .HasMaxLength(3);

                entity.Property(e => e.TiffStyle).HasColumnName("Tiff_Style");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TrayInsert).HasMaxLength(10);

                entity.Property(e => e.TrayType).HasMaxLength(10);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit_Price")
                    .HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UnitsInStock).HasColumnName("Units_in_Stock");

                entity.Property(e => e.UnitsSold).HasColumnName("Units_Sold");

                entity.Property(e => e.WashGroup).HasMaxLength(20);

                entity.Property(e => e.WholeSale).HasColumnType("decimal(19, 4)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
