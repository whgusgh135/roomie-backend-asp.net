namespace Roomie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFlatModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false, maxLength: 255),
                        NumberOfRooms = c.Byte(nullable: false),
                        PricePerPerson = c.Byte(nullable: false),
                        MaxNumberOfPeopleAllowed = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Flats");
        }
    }
}
