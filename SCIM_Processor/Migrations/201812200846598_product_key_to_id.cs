namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product_key_to_id : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TblProduct");
            AddColumn("dbo.TblProduct", "ProductId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TblProduct", "ProductId");
            DropColumn("dbo.TblProduct", "ProductKey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblProduct", "ProductKey", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.TblProduct");
            DropColumn("dbo.TblProduct", "ProductId");
            AddPrimaryKey("dbo.TblProduct", "ProductKey");
        }
    }
}
