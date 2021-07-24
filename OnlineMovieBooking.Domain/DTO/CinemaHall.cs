using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Domain.DTO
{
    public class CinemaHall
    {
   
        public int CinemaHallId { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Show> Shows { get; set; }
    }
}