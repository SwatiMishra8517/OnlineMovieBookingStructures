using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ViewModels
{
    public class ShowSeatViewModel
    {
        public int ShowSeatId { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }
        public int CinemaSeatId { get; set; }
        public int ShowId { get; set; }
        public int BookingId { get; set; }

        public virtual BookingViewModel Booking { get; set; }
        public virtual CinemaSeatViewModel CinemaSeat { get; set; }
        public virtual ShowViewModel Show { get; set; }
    }
}