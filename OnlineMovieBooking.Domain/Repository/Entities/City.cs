using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMovieBooking.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        [DisplayName("City Name")]
        [Required(ErrorMessage = "Please enter city name"), MaxLength(50)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter state name"), MaxLength(50)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only Alphabets are allowed.")]
        public string State { get; set; }
        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Invalid Zip code. Please enter valid Zipcode")]
        [DisplayName("Zip Code")]
        [MaxLength(6)]
        public string ZipCode { get; set; }

        public virtual ICollection<Cinema> Cinemas { get; set; }
    }
}