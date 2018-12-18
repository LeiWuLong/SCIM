namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doublepriceproduct : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TblProduct", "ProductPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TblProduct", "ProductPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
