using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Domain.Repository.Entities
{
    public class ShowSeat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShowSeatId { get; set; }
        [Required(ErrorMessage = "Please select the status")]
        public string Status { get; set; }
        public int ShowId { get; set; }

        
    }
}