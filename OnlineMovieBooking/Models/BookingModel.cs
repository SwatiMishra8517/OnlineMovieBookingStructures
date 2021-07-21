using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class BookingModel
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

        public virtual ShowModel Show { get; set; }
        public virtual UserModel User { get; set; }
        public virtual ICollection<PaymentModel> Payments { get; set; }
        public virtual ICollection<ShowSeatModel> ShowSeats { get; set; }
    }
}