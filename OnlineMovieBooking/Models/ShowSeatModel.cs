using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Models
{
    public class ShowSeatModel
    {
        public int ShowSeatId { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }
        public int CinemaSeatId { get; set; }
        public int ShowId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual CinemaSeat CinemaSeat { get; set; }
        public virtual Show Show { get; set; }
    }
}