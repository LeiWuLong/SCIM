namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class purchase_orders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblPurchaseOrderDetails",
                c => new
                    {
                        PurchaseOrderDetailsId = c.Int(nullable: false, identity: true),
                        PurchaseOrderId = c.Int(nullable: false),
                        POCode = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ProductId = c.Int(nullable: false),
                        ProductName = c.String(unicode: false),
                        TotalPurchaseCost = c.Single(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Customer = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.PurchaseOrderDetailsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblPurchaseOrderDetails");
        }
    }
}
