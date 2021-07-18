using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeedbackId { get; set; }
        [Range(1,10)]
        [Required(ErrorMessage = "Enter the rating")]
        public int Rating { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Enter the review")]
        public string Review { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }
    }
}