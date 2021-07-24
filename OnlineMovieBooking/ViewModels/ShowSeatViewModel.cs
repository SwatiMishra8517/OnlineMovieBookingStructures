using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.ViewModels
{
    public class ShowSeatViewModel
    {
        public ShowSeatViewModel() { }
        public int ShowSeatId { get; set; }
        [Required(ErrorMessage = "Please select the status")]
        public string Status { get; set; }
        public int ShowId { get; set; }

        public virtual ShowViewModel Show { get; set; }
    }
}