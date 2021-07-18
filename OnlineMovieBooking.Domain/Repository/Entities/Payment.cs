using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }
        [DisplayName("Discout Coupon Id")]
        public string DiscountCouponId { get; set; }
        [DisplayName("Remote Transaction Id")]
        public string RemoteTransactionId { get; set; }
        [DisplayName("Payment Method")]
        public string PaymentMethod { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}