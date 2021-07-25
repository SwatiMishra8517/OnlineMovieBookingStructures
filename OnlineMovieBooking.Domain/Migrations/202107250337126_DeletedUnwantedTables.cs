namespace OnlineMovieBooking.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedUnwantedTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Feedbacks", "UserId", "dbo.Users");
            DropForeignKey("dbo.Payments", "UserId", "dbo.Users");
            DropForeignKey("dbo.ShowSeats", "Payment_PaymentId", "dbo.Payments");
            DropForeignKey("dbo.Payments", "ShowId", "dbo.Shows");
            DropForeignKey("dbo.Payments", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Feedbacks", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.ShowSeats", "ShowId", "dbo.Shows");
            DropForeignKey("dbo.Shows", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Shows", "CinemaHallId", "dbo.CinemaHalls");
            DropIndex("dbo.Payments", new[] { "MovieId" });
            DropIndex("dbo.Payments", new[] { "ShowId" });
            DropIndex("dbo.Payments", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "MobileNo" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Feedbacks", new[] { "MovieId" });
            DropIndex("dbo.Feedbacks", new[] { "UserId" });
            DropIndex("dbo.ShowSeats", new[] { "Payment_PaymentId" });
            DropIndex("dbo.ShowSeats", new[] { "ShowId" });
            DropIndex("dbo.Shows", new[] { "MovieId" });
            DropIndex("dbo.Shows", new[] { "CinemaHallId" });
            
            CreateTable(
                "dbo.CinemaHalls",
                c => new
                    {
                        CinemaHallId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.CinemaHallId);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        CinemaHallId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShowId)
                .ForeignKey("dbo.CinemaHalls", t => t.CinemaHallId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.CinemaHallId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Language = c.String(nullable: false),
                        Genre = c.String(),
                        Duration = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.ShowSeats",
                c => new
                    {
                        ShowSeatId = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false),
                        ShowId = c.Int(nullable: false),
                        Payment_PaymentId = c.Int(),
                    })
                .PrimaryKey(t => t.ShowSeatId)
                .ForeignKey("dbo.Shows", t => t.ShowId, cascadeDelete: true)
                .ForeignKey("dbo.Payments", t => t.Payment_PaymentId)
                .Index(t => t.ShowId)
                .Index(t => t.Payment_PaymentId);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        FeedbackId = c.Int(nullable: false, identity: true),
                        Review = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FeedbackId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Username = c.String(nullable: false, maxLength: 15),
                        MobileNo = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .Index(t => t.Username, unique: true)
                .Index(t => t.MobileNo, unique: true)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Time = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        ShowId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Shows", t => t.ShowId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ShowId)
                .Index(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CinemaHalls");
            DropTable("dbo.Payments");
            DropTable("dbo.Users");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.ShowSeats");
            DropTable("dbo.Movies");
            DropTable("dbo.Shows");

        }
    }
}
