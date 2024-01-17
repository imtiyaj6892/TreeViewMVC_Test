namespace TreeViewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Nodes", new[] { "ParentNodeId" });
            AlterColumn("dbo.Nodes", "ParentNodeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Nodes", "ParentNodeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Nodes", new[] { "ParentNodeId" });
            AlterColumn("dbo.Nodes", "ParentNodeId", c => c.Int());
            CreateIndex("dbo.Nodes", "ParentNodeId");
        }
    }
}
