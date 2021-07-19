using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Domain.Repository.Entities
{
    public class ShowSeat
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

        public virtual Booking Booking { get; set; }
        public virtual CinemaSeat CinemaSeat { get; set; }
        public virtual Show Show { get; set; }
    }
}