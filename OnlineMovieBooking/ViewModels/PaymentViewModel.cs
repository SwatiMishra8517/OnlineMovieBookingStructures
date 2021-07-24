using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.ViewModels
{
    public class PaymentViewModel
    {
        public int PaymentId { get; set; }
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        public DateTime Time { get; set; }
        public int UserId { get; set; }
        public int ShowId { get; set; }
        public int MovieId { get; set; }

        public virtual ShowViewModel Show { get; set; }
        public virtual MovieViewModel Movie { get; set; }
        public virtual UserViewModel User { get; set; }
        public virtual ICollection<ShowSeatViewModel> ShowSeats { get; set; }
    }
}