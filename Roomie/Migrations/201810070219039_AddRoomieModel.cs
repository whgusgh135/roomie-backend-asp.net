namespace Roomie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoomieModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roomies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        MinPrice = c.Byte(nullable: false),
                        MaxPrice = c.Byte(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 255),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Roomies");
        }
    }
}
