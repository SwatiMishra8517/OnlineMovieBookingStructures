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

        public UserCommandService()
        {
        }

        public UserCommandService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public void Add(User user)
        {
            ur = new UserRepository();
            Repository.Entities.User u = new Repository.Entities.User
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                MobileNo = user.MobileNo,
                Password = user.Password
            };
            ur.Add(u);
        }

        public void Delete(int id)
        {
            ur = new UserRepository();
            Repository.Entities.User u = new Repository.Entities.User();
            ur.Delete(id);
        }

        public void Update(int id,User user)
        {
            ur = new UserRepository();
            Repository.Entities.User u = ur.GetById(id);
            u.UserId = user.UserId;
            u.Username = user.Username;
            u.Email = user.Email;
            u.MobileNo = user.MobileNo;
            u.Password = user.Password;
            ur.Update(id, u);
        }

        
    }
}
