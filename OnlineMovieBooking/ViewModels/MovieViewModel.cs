using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ViewModels
{
    public class MovieViewModel
    {
        public int MovieId { get; set; }
        [DisplayName("Movie Name")]
        public string Name { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public Nullable<DateTime> ReleaseDate { get; set; }

        public virtual ICollection<ShowViewModel> Shows { get; set; }
    }
}