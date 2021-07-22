using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ViewModels
{
    public class BookingViewModel
    {
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

        public virtual ShowViewModel Show { get; set; }
        public virtual UserViewModel User { get; set; }
        public virtual ICollection<PaymentViewModel> Payments { get; set; }
        public virtual ICollection<ShowSeatViewModel> ShowSeats { get; set; }
    }
}