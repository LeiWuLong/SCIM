namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class purchaseorder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblPurchaseOrder",
                c => new
                    {
                        PurchaseOrderId = c.Int(nullable: false, identity: true),
                        PurchaseOrderCode = c.String(unicode: false),
                        TotalSellingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PODate = c.DateTime(nullable: false, precision: 0),
                        CustomerName = c.String(unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseOrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblPurchaseOrder");
        }
    }
}
