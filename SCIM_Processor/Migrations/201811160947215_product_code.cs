namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product_code : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblProduct", "ProductCode", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblProduct", "ProductCode");
        }
    }
}
