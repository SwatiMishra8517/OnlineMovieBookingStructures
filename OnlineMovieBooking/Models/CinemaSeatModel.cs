using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Models
{
    public class CinemaSeatModel
    {
        public int CinemaSeatId { get; set; }
        public string SeatNumber { get; set; }
        public int Type { get; set; }
        public int CinemaHallId { get; set; }

        public virtual CinemaHallModel CinemaHall { get; set; }
        public virtual ICollection<ShowSeatModel> Show_Seats { get; set; }
    }
}