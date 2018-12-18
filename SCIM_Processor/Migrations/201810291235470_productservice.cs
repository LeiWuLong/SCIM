namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productservice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblProduct",
                c => new
                    {
                        ProductKey = c.Int(nullable: false, identity: true),
                        ProductName = c.String(unicode: false),
                        ProductDesc = c.String(unicode: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductKey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblProduct");
        }
    }
}
