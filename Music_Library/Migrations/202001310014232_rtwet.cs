namespace Music_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rtwet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "Path", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "Path");
        }
    }
}
