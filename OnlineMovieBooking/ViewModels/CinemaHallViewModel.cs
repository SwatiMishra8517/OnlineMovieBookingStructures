using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using OnlineMovieBooking.ViewModels;

namespace OnlineMovieBooking.ViewModels
{
    public class CinemaHallViewModel
    {
        public int CinemaHallId { get; set; }
        [DisplayName("Cinema Hall")]
        public string Name { get; set; }
        public int TotalSeats { get; set; }
        public int CinemaId { get; set; }

        public virtual CinemaViewModel Cinema { get; set; }
        public virtual ICollection<CinemaSeatViewModel> CinemaSeats { get; set; }
        public virtual ICollection<ShowViewModel> Shows { get; set; }
    }
}