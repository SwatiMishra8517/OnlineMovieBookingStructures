using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        [DisplayName("Movie Name")]
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Language")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public string Language { get; set; }
        public string Genre { get; set; }
        [DisplayName("Duration(in mins)")]
        [Required(ErrorMessage = "Please enter Duration")]
        [Range(0, 240, ErrorMessage = "Please enter duration in the range 0 and 240")]
        public int Duration { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter the Description")]
        public string Description { get; set; }
        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter the date")]
        public Nullable<DateTime> ReleaseDate { get; set; }

        public virtual ICollection<Show> Shows { get; set; }
    }
}