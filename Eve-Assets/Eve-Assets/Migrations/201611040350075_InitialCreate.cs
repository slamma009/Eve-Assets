namespace Eve_Assets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Minerals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MineralsRefineds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Mineral_Id = c.Int(),
                        Ore_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Minerals", t => t.Mineral_Id)
                .ForeignKey("dbo.Ores", t => t.Ore_Id)
                .Index(t => t.Mineral_Id)
                .Index(t => t.Ore_Id);
            
            CreateTable(
                "dbo.Ores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RefineAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MineralsRefineds", "Ore_Id", "dbo.Ores");
            DropForeignKey("dbo.MineralsRefineds", "Mineral_Id", "dbo.Minerals");
            DropIndex("dbo.MineralsRefineds", new[] { "Ore_Id" });
            DropIndex("dbo.MineralsRefineds", new[] { "Mineral_Id" });
            DropTable("dbo.Ores");
            DropTable("dbo.MineralsRefineds");
            DropTable("dbo.Minerals");
        }
    }
}
