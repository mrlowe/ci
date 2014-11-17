namespace MyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Things", "Flag", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Things", "Flag");
        }
    }
}
