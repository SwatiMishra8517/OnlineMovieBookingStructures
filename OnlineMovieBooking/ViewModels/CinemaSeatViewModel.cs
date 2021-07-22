using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.ViewModels
{
    public class CinemaSeatViewModel
    {
        public int CinemaSeatId { get; set; }
        [RegularExpression(@"^[A-J]{1}[0-1]{1}[0-5]{1}", ErrorMessage = "Invalid Seat Number")]
        [DisplayName("Seat Number")]
        public string SeatNumber { get; set; }
        [Required(ErrorMessage = "Please enter Seat Type")]
        public int Type { get; set; }
        public int CinemaHallId { get; set; }

        public virtual CinemaHallViewModel CinemaHall { get; set; }
        public virtual ICollection<ShowSeatViewModel> Show_Seats { get; set; }
    }
}