using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.UserService.UserQueryService
{
    interface IUserQueryService
    {
        User GetByUserName(string username);
        User GetById(int id);
        User GetByEmail(string email);

    }
}
