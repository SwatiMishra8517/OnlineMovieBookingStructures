using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Models
{
    public class PaymentModel
    {
        public int PaymentId { get; set; }
        public double Amount { get; set; }
        public DateTime Time { get; set; }
        [DisplayName("Discout Coupon Id")]
        public string DiscountCouponId { get; set; }
        [DisplayName("Remote Transaction Id")]
        public string RemoteTransactionId { get; set; }
        [DisplayName("Payment Method")]
        public string PaymentMethod { get; set; }
        public int BookingId { get; set; }

        public virtual BookingModel Booking { get; set; }
    }
}