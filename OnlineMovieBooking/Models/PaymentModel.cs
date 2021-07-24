using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class PaymentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentId { get; set; }
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }
        public int UserId { get; set; }
        public int ShowId { get; set; }
        public int MovieId { get; set; }

        public virtual ShowModel Show { get; set; }
        public virtual MovieModel Movie { get; set; }
        public virtual UserModel User { get; set; }
        public virtual ICollection<ShowSeatModel> ShowSeats { get; set; }
    }
}