using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.UserService
{
    public class UserCommandService : IUserCommandService
    {
        private readonly IUserRepository repository;
        private UserRepository ur;
        
        public UserCommandService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public void AddUser(User user)
        {
            Repository.Entities.User u = new Repository.Entities.User();
            u.UserId = user.UserId;
            u.Username = user.Username;
            u.Email = user.Email;
            u.MobileNo = user.MobileNo;
            u.Password = user.Password;
            ur.Add(u);
        }

        public void Delete(int id)
        {
            Repository.Entities.User u = new Repository.Entities.User();
            ur.Delete(id);
        }

        public void Edit(int id,User user)
        {
            Repository.Entities.User u = ur.GetById(id);

            u.UserId = user.UserId;
            u.Username = user.Username;
            u.Email = user.Email;
            u.MobileNo = user.MobileNo;
            u.Password = user.Password;
            ur.Add(u);
        }

        
    }
}
