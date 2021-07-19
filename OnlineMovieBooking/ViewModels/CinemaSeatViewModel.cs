using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ViewModels
{
    public class CinemaSeatViewModel
    {
        public int CinemaSeatId { get; set; }
        public string SeatNumber { get; set; }
        public int Type { get; set; }
        public int CinemaHallId { get; set; }

        public virtual CinemaHallViewModel CinemaHall { get; set; }
        public virtual ICollection<ShowSeatViewModel> Show_Seats { get; set; }
    }
}