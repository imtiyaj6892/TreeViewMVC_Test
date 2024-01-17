namespace TreeViewMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nodes",
                c => new
                    {
                        NodeId = c.Int(nullable: false, identity: true),
                        NodeName = c.String(),
                        ParentNodeId = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NodeId)
                .ForeignKey("dbo.Nodes", t => t.ParentNodeId)
                .Index(t => t.ParentNodeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nodes", "ParentNodeId", "dbo.Nodes");
            DropIndex("dbo.Nodes", new[] { "ParentNodeId" });
            DropTable("dbo.Nodes");
        }
    }
}
