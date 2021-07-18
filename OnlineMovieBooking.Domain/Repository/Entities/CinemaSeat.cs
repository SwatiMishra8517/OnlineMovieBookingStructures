using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class CinemaSeat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CinemaSeatId { get; set; }
        [RegularExpression(@"^[A-J]{1}[0-1]{1}[0-5]{1}", ErrorMessage = "Invalid Seat Number")]
        [DisplayName("Seat Number")]
        public string SeatNumber { get; set; }
        [Required(ErrorMessage = "Please enter Seat Type")]
        public int Type { get; set; }
        public int CinemaHallId { get; set; }

        public virtual CinemaHall CinemaHall { get; set; }
        public virtual ICollection<ShowSeat> Show_Seats { get; set; }
    }
    public enum Type
    {

    }
}