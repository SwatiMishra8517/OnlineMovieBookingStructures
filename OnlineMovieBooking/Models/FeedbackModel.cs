using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class FeedbackModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeedbackId { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Enter the review")]
        public string Review { get; set; }

        public int UserId { get; set; }
        public int MovieId { get; set; }
        public UserModel User { get; set; }
        public MovieModel Movie { get; set; }
    }
}