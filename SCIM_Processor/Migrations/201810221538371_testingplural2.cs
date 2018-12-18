namespace SCIM_Processor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testingplural2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblTest",
                c => new
                    {
                        TestKey = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TestKey);
            
            CreateTable(
                "dbo.TblUser",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(unicode: false),
                        MiddleName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.TblUserAccess",
                c => new
                    {
                        UserAccessId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserName = c.String(maxLength: 15, storeType: "nvarchar"),
                        Password = c.String(maxLength: 15, storeType: "nvarchar"),
                        Attempts = c.Int(),
                        IsLocked = c.Boolean(),
                        IsActive = c.Boolean(),
                        CreatedDate = c.DateTime(precision: 0),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserAccessId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblUserAccess");
            DropTable("dbo.TblUser");
            DropTable("dbo.TblTest");
        }
    }
}
