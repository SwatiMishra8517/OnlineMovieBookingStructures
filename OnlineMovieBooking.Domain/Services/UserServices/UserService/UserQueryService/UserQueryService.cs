using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.UserService.UserQueryService
{
    public class UserQueryService : IUserQueryService
    {
        UserRepository ur = new UserRepository();
        public User GetByEmail(string email)
        {
            Repository.Entities.User user = ur.GetByEmail(email);
            User u = new User
            {
                UserId = user.UserId,
                Name = user.Name,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                MobileNo = user.MobileNo,
            };
            return u;
        }

        public User GetById(int id)
        {
            Repository.Entities.User user = ur.GetById(id);
            User u = new User
            {
                UserId = user.UserId,
                Name = user.Name,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                MobileNo = user.MobileNo,
            };
            return u;
        }

        public User GetByUserName(string username)
        {
            Repository.Entities.User user = ur.GetByUserName(username);
            User u = new User
            {
                UserId = user.UserId,
                Name = user.Name,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                MobileNo = user.MobileNo,
            };
            return u;
        }
    }
}
