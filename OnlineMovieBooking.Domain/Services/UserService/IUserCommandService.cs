using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain;
using OnlineMovieBooking.Domain.DTO;

namespace OnlineMovieBooking.Domain.Services.UserService
{
    public interface IUserCommandService
    {
        void Add(User user);
        void Delete(int id);
        void Update(int id, User user);
    }
}