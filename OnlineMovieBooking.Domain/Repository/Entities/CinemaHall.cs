using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace OnlineMovieBooking.Domain.Repository.Entities
{
    public class CinemaHall
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CinemaHallId { get; set; }
        [Required(ErrorMessage = "Please enter hall name"), MaxLength(30)]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphanumeric allowed")]
        [DisplayName("Cinema Hall")]
        public string Name { get; set; }
        public int ShowId { get; set; }
        

        public virtual ICollection<Show> Shows { get; set; }
        public virtual ICollection<ShowSeat> ShowSeats { get; set; }
    }
}