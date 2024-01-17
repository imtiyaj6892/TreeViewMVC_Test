namespace TreeViewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Pid = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Pid)
                .Index(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Pid", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "Pid" });
            DropTable("dbo.Categories");
        }
    }
}
