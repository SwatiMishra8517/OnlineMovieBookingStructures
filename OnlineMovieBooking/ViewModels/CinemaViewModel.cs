﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineMovieBooking.ViewModels
{
    public class CinemaViewModel
    {
        public int CinemaId { get; set; }
        [DisplayName("Cinema Name")]
        [Required(ErrorMessage = "Please enter cinema name"), MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Cinema Halls")]
        [Required(ErrorMessage = "Please enter the Total Number of Halls")]
        public int TotalHalls { get; set; }
        [DisplayName("City Name")]
        [Required(ErrorMessage = "Please enter the Cty ID")]
        public int CityId { get; set; }

        public virtual CityViewModel City { get; set; }
        public virtual ICollection<CinemaHallViewModel> CinemaHalls { get; set; }
    }
}