using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ViewModels
{
    public class CinemaViewModel
    {
        public int CinemaId { get; set; }
        public string Name { get; set; }
        public int TotalHalls { get; set; }
        public int CityId { get; set; }

        public virtual CityViewModel City { get; set; }
        public virtual ICollection<CinemaHallViewModel> CinemaHalls { get; set; }
    }
}