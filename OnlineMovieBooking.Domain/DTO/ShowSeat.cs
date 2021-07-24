using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Domain.DTO
{
    public class ShowSeat
    {
        public int ShowSeatId { get; set; }
        public string Status { get; set; }
        public int ShowId { get; set; }

        public virtual Show Show { get; set; }
    }
}