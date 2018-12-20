namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class po_quantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblPurchaseOrderDetails", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblPurchaseOrderDetails", "Quantity");
        }
    }
}
