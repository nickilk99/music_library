namespace Music_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class albumupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Cover", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "Cover");
        }
    }
}
