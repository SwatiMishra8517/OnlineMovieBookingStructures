using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.UserService.UserQueryService
{
    class UserQueryService : IUserQueryService
    {
        UserRepository ur = new UserRepository();
        public User GetByEmail(string email)
        {
            Repository.Entities.User user = ur.GetByEmail(email);
            return (User)user;
        }

        public User GetById(int id)
        {
            Repository.Entities.User user = ur.GetById(id);
            return (User)user;
        }

        public User GetByUserName(string username)
        {
            Repository.Entities.User user = ur.GetByUserName(username);
            return (User)user;
        }
    }
}
