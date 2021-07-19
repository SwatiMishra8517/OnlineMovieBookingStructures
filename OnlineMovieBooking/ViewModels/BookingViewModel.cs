using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ViewModels
{
    public class BookingViewModel
    {
        public int BookingId { get; set; }
        public int NumberOfSeats { get; set; }
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