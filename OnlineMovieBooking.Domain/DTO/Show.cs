using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Domain.DTO
{
    public class Show
    {
        public int ShowId { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CinemaHallId { get; set; }
        public int MovieId { get; set; }

        public virtual CinemaHall CinemaHall { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual ICollection<ShowSeat> ShowSeats { get; set; }
    }
}