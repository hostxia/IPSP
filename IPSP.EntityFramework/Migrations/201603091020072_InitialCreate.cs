namespace IPSP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TCase_Base",
                c => new
                    {
                        n_CaseID = c.Int(nullable: false, identity: true),
                        n_ClientID = c.Int(nullable: false),
                        s_CaseName = c.String(),
                        s_CaseSerial = c.String(),
                    })
                .PrimaryKey(t => t.n_CaseID)
                .ForeignKey("dbo.TCstmr_Client", t => t.n_ClientID, cascadeDelete: true)
                .Index(t => t.n_ClientID);
            
            CreateTable(
                "dbo.TCstmr_Client",
                c => new
                    {
                        n_ClientID = c.Int(nullable: false, identity: true),
                        s_Name = c.String(),
                    })
                .PrimaryKey(t => t.n_ClientID);
            
            CreateTable(
                "dbo.TPCase_Patent",
                c => new
                    {
                        n_CaseID = c.Int(nullable: false),
                        n_PatentTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.n_CaseID)
                .ForeignKey("dbo.TCase_Base", t => t.n_CaseID)
                .Index(t => t.n_CaseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TPCase_Patent", "n_CaseID", "dbo.TCase_Base");
            DropForeignKey("dbo.TCase_Base", "n_ClientID", "dbo.TCstmr_Client");
            DropIndex("dbo.TPCase_Patent", new[] { "n_CaseID" });
            DropIndex("dbo.TCase_Base", new[] { "n_ClientID" });
            DropTable("dbo.TPCase_Patent");
            DropTable("dbo.TCstmr_Client");
            DropTable("dbo.TCase_Base");
        }
    }
}
