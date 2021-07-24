using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OnlineMovieBooking.Domain.DTO
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public static explicit operator User(Repository.Entities.User v)
        {
            throw new NotImplementedException();
        }
    }
}