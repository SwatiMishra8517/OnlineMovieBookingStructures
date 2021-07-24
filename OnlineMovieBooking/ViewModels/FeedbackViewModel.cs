using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.ViewModels
{
    public class FeedbackViewModel
    {
        public int FeedbackId { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Enter the review")]
        public string Review { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }
        public UserViewModel User { get; set; }
        public MovieViewModel Movie { get; set; }
    }
}