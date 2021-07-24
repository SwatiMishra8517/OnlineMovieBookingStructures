using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using OnlineMovieBooking.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.ViewModels
{
    public class CinemaHallViewModel
    {
        public int CinemaHallId { get; set; }
        [DisplayName("Cinema Hall")]
        [Required(ErrorMessage = "Please enter hall name"), MaxLength(30)]
        [RegularExpression("^[a-zA-Z0-9 ]*$", ErrorMessage = "Only Alphanumeric allowed")]
        public string Name { get; set; }

        public virtual ICollection<ShowViewModel> Shows { get; set; }
    }
}