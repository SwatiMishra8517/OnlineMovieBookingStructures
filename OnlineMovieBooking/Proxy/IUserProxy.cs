using OnlineMovieBooking.Domain.Services.UserService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface IUserProxy
    {
        void Add(UserModel user);
        void Delete(int id);
        void Update(int id, UserModel user);
        UserModel GetById(int id);
        List<UserModel> GetAll();
        UserModel GetByUserName(string username);
        UserModel GetByEmail(string email);

    }
}