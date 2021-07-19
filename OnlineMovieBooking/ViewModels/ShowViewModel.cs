using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ViewModels
{
    public class ShowViewModel
    {
        public int ShowId { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CinemaHallId { get; set; }
        public int MovieId { get; set; }

        public virtual ICollection<BookingViewModel> Bookings { get; set; }
        public virtual CinemaHallViewModel CinemaHall { get; set; }
        public virtual MovieViewModel Movie { get; set; }
        public virtual ICollection<ShowSeatViewModel> ShowSeats { get; set; }
    }
}