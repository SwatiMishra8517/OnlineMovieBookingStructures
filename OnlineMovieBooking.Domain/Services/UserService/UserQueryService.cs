using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.UserService
{
    public class UserQueryService : IUserQueryService
    {
        private readonly IUserRepository repository;
        private UserRepository ur = new UserRepository(); 


        public UserQueryService(IUserRepository repository)
        {
            this.repository = repository;
        }


        public User Find(int id)
        {
           Repository.Entities.User user = ur.GetById(id);
            User u = new User();
            u.UserId = user.UserId;
            u.Username = user.Username;
            u.Email = user.Email;
            u.MobileNo = user.MobileNo;
            u.Password = user.Password;
            return u;
        }
    }
}
