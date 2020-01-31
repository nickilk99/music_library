namespace Music_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Songs", "Path", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Songs", "Path", c => c.Int(nullable: false));
        }
    }
}
