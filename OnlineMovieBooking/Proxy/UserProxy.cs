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
        private UserCommandService ucs = new UserCommandService();
        private UserQueryService uqs = new UserQueryService();
        public UserProxy() { }
        public UserProxy(UserQueryService userQueryService,UserCommandService userCommandService)
        {
            this.ucs = userCommandService;
            this.uqs = userQueryService;
        }

        public void Add(UserModel user)
        {
            var u = new OnlineMovieBooking.Domain.DTO.User();
            u.UserId = user.UserId;
            u.Username = user.Username;
            u.Name = user.Name;
            u.MobileNo = user.MobileNo;
            u.Email = user.Email;
            u.Password = user.Password;
            u.Bookings = (ICollection<Domain.DTO.Booking>)user.Bookings;
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
            foreach(var user in users)
            {
                UserModel u = new UserModel();
                u.UserId = user.UserId;
                u.Username = user.Username;
                u.Name = user.Name;
                u.MobileNo = user.MobileNo;
                u.Email = user.Email;
                u.Password = user.Password;
                ums.Add(u);
            }
            return ums;
        }

        public UserModel GetById(int id)
        {
            var user = uqs.Get(id);
            UserModel u = new UserModel();

            u.UserId = user.UserId;
            u.Username = user.Username;
            u.Name = user.Name;
            u.MobileNo = user.MobileNo;
            u.Email = user.Email;
            u.Password = user.Password;
            return u;
        }

        public void Update(int id, UserModel user)
        {
            var u = new OnlineMovieBooking.Domain.DTO.User();
            u.UserId = user.UserId;
            u.Username = user.Username;
            u.Name = user.Name;
            u.MobileNo = user.MobileNo;
            u.Email = user.Email;
            u.Password = user.Password;
            ucs.Update(id,u);

        }
    }
}