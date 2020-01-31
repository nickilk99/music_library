namespace Music_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "SongTitle", c => c.String());
            DropColumn("dbo.Songs", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "Title", c => c.String());
            DropColumn("dbo.Songs", "SongTitle");
        }
    }
}
