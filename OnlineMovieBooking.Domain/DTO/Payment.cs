using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Domain.DTO
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public double Amount { get; set; }
        public DateTime Time { get; set; }

        public int UserId { get; set; }
        public int ShowId { get; set; }
        public int MovieId { get; set; }

        public virtual Show Show { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ShowSeat> ShowSeats { get; set; }
    }
}