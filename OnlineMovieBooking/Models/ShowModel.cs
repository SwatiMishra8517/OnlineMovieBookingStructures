using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Models
{
    public class ShowModel
    {
        public int ShowId { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CinemaHallId { get; set; }
        public int MovieId { get; set; }

        public virtual ICollection<BookingModel> Bookings { get; set; }
        public virtual CinemaHallModel CinemaHall { get; set; }
        public virtual MovieModel Movie { get; set; }
        public virtual ICollection<ShowSeatModel> ShowSeats { get; set; }
    }
}