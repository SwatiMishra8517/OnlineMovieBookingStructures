using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Models
{
    public class MovieModel
    {
        public int MovieId { get; set; }
        [DisplayName("Movie Name")]
        public string Name { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public Nullable<DateTime> ReleaseDate { get; set; }

        public virtual ICollection<Show> Shows { get; set; }
    }
}