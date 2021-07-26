using OnlineMovieBooking.Domain.Services.UserService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class UserProxy : IUserProxy
    {
        private readonly UserCommandService ucs = new UserCommandService();
        private readonly UserQueryService uqs = new UserQueryService();
        private readonly OnlineMovieBooking.Domain.Services.UserServices.UserService.UserQueryService.UserQueryService uss = new Domain.Services.UserServices.UserService.UserQueryService.UserQueryService();
        public UserProxy() { }
        public UserProxy(UserQueryService userQueryService, UserCommandService userCommandService, OnlineMovieBooking.Domain.Services.UserServices.UserService.UserQueryService.UserQueryService us)
        {
            this.ucs = userCommandService;
            this.uqs = userQueryService;
            this.uss = us;
        }

        public void Add(UserModel user)
        {
            var u = new OnlineMovieBooking.Domain.DTO.User
            {
                UserId = user.UserId,
                Username = user.Username,
                Name = user.Name,
                MobileNo = user.MobileNo,
                Email = user.Email,
                Password = user.Password
            };
            ucs.Add(u);
        }

        public void Delete(int id)
        {
            ucs.Delete(id);
        }

        public List<UserModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.User> users = uqs.GetAll();
            List<UserModel> ums = new List<UserModel>();
            foreach (var user in users)
            {
                UserModel u = new UserModel
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    Name = user.Name,
                    MobileNo = user.MobileNo,
                    Email = user.Email,
                    Password = user.Password
                };
                ums.Add(u);
            }
            return ums;
        }

        public UserModel GetByEmail(string email)
        {
            OnlineMovieBooking.Domain.DTO.User user = uss.GetByEmail(email);
            UserModel u = new UserModel
            {
                UserId = user.UserId,
                Username = user.Username,
                Name = user.Name,
                MobileNo = user.MobileNo,
                Email = user.Email,
                Password = user.Password
            };
            return u;
        }

        public UserModel GetById(int id)
        {
            var user = uqs.Get(id);
            UserModel u = new UserModel
            {
                UserId = user.UserId,
                Username = user.Username,
                Name = user.Name,
                MobileNo = user.MobileNo,
                Email = user.Email,
                Password = user.Password
            };
            return u;
        }

        public UserModel GetByUserName(string username)
        {
            OnlineMovieBooking.Domain.DTO.User user = uss.GetByUserName(username);
            UserModel u = new UserModel
            {
                UserId = user.UserId,
                Username = user.Username,
                Name = user.Name,
                MobileNo = user.MobileNo,
                Email = user.Email,
                Password = user.Password
            };
            return u;
        }

        public void Update(int id, UserModel user)
        {
            var u = new OnlineMovieBooking.Domain.DTO.User
            {
                UserId = user.UserId,
                Username = user.Username,
                Name = user.Name,
                MobileNo = user.MobileNo,
                Email = user.Email,
                Password = user.Password
            };
            ucs.Update(id, u);

        }
    }
}