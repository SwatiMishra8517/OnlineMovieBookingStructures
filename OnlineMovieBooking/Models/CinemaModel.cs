using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Models
{
    public class CinemaModel
    {
        public int CinemaId { get; set; }
        public string Name { get; set; }
        public int TotalHalls { get; set; }
        public int CityId { get; set; }

        public virtual CityModel City { get; set; }
        public virtual ICollection<CinemaHallModel> CinemaHalls { get; set; }
    }
}