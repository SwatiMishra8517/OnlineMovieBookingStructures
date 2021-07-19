using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Domain.Repository.Entities
{
    public class Show
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShowId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Time)]
        [DisplayName("End Time")]
        public DateTime EndTime { get; set; }
        public int CinemaHallId { get; set; }
        public int MovieId { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual CinemaHall CinemaHall { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual ICollection<ShowSeat> ShowSeats { get; set; }
    }
}