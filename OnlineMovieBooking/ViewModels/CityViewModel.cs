using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ViewModels
{
    public class CityViewModel
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<CinemaViewModel> Cinemas { get; set; }
    }
}