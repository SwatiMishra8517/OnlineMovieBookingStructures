using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }
        [DisplayName("Number of Seats")]
        [Required(ErrorMessage = "Please enter the number of seats")]
        public int NumberOfSeats { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Please select the time")]
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public int ShowId { get; set; }

        public virtual Show Show { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<ShowSeat> ShowSeats { get; set; }
    }
}