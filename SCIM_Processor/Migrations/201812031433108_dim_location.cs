namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dim_location : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblLocation",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(unicode: false),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblLocation");
        }
    }
}
