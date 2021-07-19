using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetById(int id);
        void Delete(int id);
        void Update(int id,User user);
        List<User> GetAll();
    }
}
