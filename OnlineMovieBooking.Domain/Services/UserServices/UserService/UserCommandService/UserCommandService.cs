using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository;


namespace OnlineMovieBooking.Domain.Services.UserServices.UserService.UserCommandService
{
    class UserCommandService : IUserCommandService
    {

        public void AddUser(User user)
        {
            Repository.Entities.User u = new Repository.Entities.User();
            u.UserId = user.UserId;
            u.Username = user.Username;
            u.Email = user.Email;
            u.MobileNo = user.MobileNo;
            u.Password = user.Password;
            UserRepository ur = new UserRepository();
            ur.Add(u);
        }
    }
}
