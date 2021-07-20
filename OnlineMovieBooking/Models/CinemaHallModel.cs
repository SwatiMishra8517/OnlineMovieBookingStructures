using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Models
{
    public class CinemaHallModel
    {
        public int CinemaHallId { get; set; }
        [DisplayName("Cinema Hall")]
        public string Name { get; set; }
        public int TotalSeats { get; set; }
        public int CinemaId { get; set; }

        public virtual CinemaModel Cinema { get; set; }
        public virtual ICollection<CinemaSeatModel> CinemaSeats { get; set; }
        public virtual ICollection<ShowModel> Shows { get; set; }
    }
}