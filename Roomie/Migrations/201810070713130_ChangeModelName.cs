namespace Roomie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeModelName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Flats", newName: "FlatModels");
            RenameTable(name: "dbo.Roomies", newName: "RoomieModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.RoomieModels", newName: "Roomies");
            RenameTable(name: "dbo.FlatModels", newName: "Flats");
        }
    }
}
