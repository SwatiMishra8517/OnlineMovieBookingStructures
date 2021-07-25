namespace OnlineMovieBooking.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDependencies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ShowSeats", "ShowId", "dbo.Shows");
            DropForeignKey("dbo.ShowSeats", "Payment_PaymentId", "dbo.Payments");
            DropIndex("dbo.ShowSeats", new[] { "ShowId" });
            DropIndex("dbo.ShowSeats", new[] { "Payment_PaymentId" });
            DropColumn("dbo.ShowSeats", "Payment_PaymentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ShowSeats", "Payment_PaymentId", c => c.Int());
            CreateIndex("dbo.ShowSeats", "Payment_PaymentId");
            CreateIndex("dbo.ShowSeats", "ShowId");
            AddForeignKey("dbo.ShowSeats", "Payment_PaymentId", "dbo.Payments", "PaymentId");
            AddForeignKey("dbo.ShowSeats", "ShowId", "dbo.Shows", "ShowId", cascadeDelete: true);
        }
    }
}
