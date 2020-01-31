namespace Music_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class songtitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "Title", c => c.String());
            DropColumn("dbo.Songs", "SongTitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "SongTitle", c => c.String());
            DropColumn("dbo.Songs", "Title");
        }
    }
}
