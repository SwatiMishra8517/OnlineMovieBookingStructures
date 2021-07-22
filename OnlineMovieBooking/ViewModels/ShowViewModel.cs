using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.ViewModels
{
    public class ShowViewModel
    {
        public int ShowId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }
        [DisplayName("End Time")]
        public DateTime EndTime { get; set; }
        public int CinemaHallId { get; set; }
        public int MovieId { get; set; }

        public virtual ICollection<BookingViewModel> Bookings { get; set; }
        public virtual CinemaHallViewModel CinemaHall { get; set; }
        public virtual MovieViewModel Movie { get; set; }
        public virtual ICollection<ShowSeatViewModel> ShowSeats { get; set; }
    }
}