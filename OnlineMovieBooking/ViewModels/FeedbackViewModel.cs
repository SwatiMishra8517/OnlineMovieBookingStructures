using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ViewModels
{
    public class FeedbackViewModel
    {
        public int FeedbackId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }
        public UserViewModel User { get; set; }
        public MovieViewModel Movie { get; set; }
    }
}