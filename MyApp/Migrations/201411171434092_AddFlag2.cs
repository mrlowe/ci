namespace MyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFlag2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Things", "Flag2", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Things", "Flag2");
        }
    }
}
