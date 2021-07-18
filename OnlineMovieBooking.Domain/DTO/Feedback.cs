using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Domain.DTO
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}