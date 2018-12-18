namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product_qty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblProduct", "ProductQuantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblProduct", "ProductQuantity");
        }
    }
}
