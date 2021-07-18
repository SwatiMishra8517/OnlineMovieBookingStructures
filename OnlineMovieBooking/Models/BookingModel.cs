using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Models
{
    public class BookingModel
    {
        public int BookingId { get; set; }
        public int NumberOfSeats { get; set; }
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