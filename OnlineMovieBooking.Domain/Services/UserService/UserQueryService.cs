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
        private UserRepository ur;

        public UserQueryService()
        {
        }

        public UserQueryService(IUserRepository repository)
        {
            this.repository = repository;
        }


        public User Get(int id)
        {
           ur = new UserRepository();
           Repository.Entities.User user = ur.GetById(id);
            User u = new User
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                MobileNo = user.MobileNo,
                Password = user.Password
            };
            return u;
        }

        public List<User> GetAll()
        {
            ur = new UserRepository();
            var retList = ur.GetAll()
            .Select(user => new User() {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                MobileNo = user.MobileNo,
                Password = user.Password
        })
            .ToList();
            return retList;
        }
    }
}
