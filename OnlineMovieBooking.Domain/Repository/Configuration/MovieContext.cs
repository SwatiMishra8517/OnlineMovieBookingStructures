using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace OnlineMovieBooking.Domain.Repository.Configuration
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base()
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }
        public DbSet<CinemaSeat> CinemaSeats { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ShowSeat> ShowSeats { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}