namespace Pollyana.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Poll",
                c => new
                    {
                        PollID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Title = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        isOpen = c.Boolean(nullable: false),
                        AccessCode = c.String(),
                    })
                .PrimaryKey(t => t.PollID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Puid = c.String(),
                        Username = c.String(),
                        Fullname = c.String(),
                        LmsDomain = c.String(),
                        DbInstance = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        PollID = c.Int(nullable: false),
                        QuesType = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.QuestionID)
                .ForeignKey("dbo.Poll", t => t.PollID, cascadeDelete: true)
                .Index(t => t.PollID);
            
            CreateTable(
                "dbo.Response",
                c => new
                    {
                        ResponseID = c.Int(nullable: false, identity: true),
                        QuestionID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        Data = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ResponseID)
                .ForeignKey("dbo.Question", t => t.QuestionID, cascadeDelete: true)
                .Index(t => t.QuestionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Response", "QuestionID", "dbo.Question");
            DropForeignKey("dbo.Question", "PollID", "dbo.Poll");
            DropForeignKey("dbo.Poll", "UserID", "dbo.User");
            DropIndex("dbo.Response", new[] { "QuestionID" });
            DropIndex("dbo.Question", new[] { "PollID" });
            DropIndex("dbo.Poll", new[] { "UserID" });
            DropTable("dbo.Response");
            DropTable("dbo.Question");
            DropTable("dbo.User");
            DropTable("dbo.Poll");
        }
    }
}
