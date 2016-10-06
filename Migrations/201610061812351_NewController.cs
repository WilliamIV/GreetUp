namespace GreetUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewController : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Events");
            AddColumn("dbo.Events", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Events", "Title", c => c.String());
            AddPrimaryKey("dbo.Events", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Events");
            AlterColumn("dbo.Events", "Title", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Events", "ID");
            AddPrimaryKey("dbo.Events", "Title");
        }
    }
}
