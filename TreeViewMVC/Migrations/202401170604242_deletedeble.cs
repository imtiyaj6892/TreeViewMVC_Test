namespace TreeViewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedeble : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Pid", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "Pid" });
            DropTable("dbo.Categories");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Categories", "Pid");
            AddForeignKey("dbo.Categories", "Pid", "dbo.Categories", "ID");
        }
    }
}
