using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Models
{
    public class FeedbackModel
    {
        public int FeedbackId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }
        public UserModel User { get; set; }
        public MovieModel Movie { get; set; }
    }
}