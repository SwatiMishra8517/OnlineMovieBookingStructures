namespace OnlineMovieBooking.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedShowIdInPayment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payments", "ShowId", "dbo.Shows");
            DropIndex("dbo.Payments", new[] { "ShowId" });
            DropColumn("dbo.Payments", "ShowId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "ShowId", c => c.Int(nullable: false));
            CreateIndex("dbo.Payments", "ShowId");
            AddForeignKey("dbo.Payments", "ShowId", "dbo.Shows", "ShowId", cascadeDelete: true);
        }
    }
}
