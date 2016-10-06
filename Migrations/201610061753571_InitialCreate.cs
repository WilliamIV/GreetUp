namespace GreetUp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 128),
                        Location = c.String(),
                        Time = c.DateTime(nullable: false),
                        Description = c.String(),
                        RSVP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Title);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
