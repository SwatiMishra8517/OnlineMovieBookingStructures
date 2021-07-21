using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class ShowSeatModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShowSeatId { get; set; }
        [Required(ErrorMessage = "Please select the status")]
        public string Status { get; set; }
        [Required(ErrorMessage = "Please enter the Price")]
        public double Price { get; set; }
        public int CinemaSeatId { get; set; }
        public int ShowId { get; set; }
        public int BookingId { get; set; }

        public virtual BookingModel Booking { get; set; }
        public virtual CinemaSeatModel CinemaSeat { get; set; }
        public virtual ShowModel Show { get; set; }
    }
}