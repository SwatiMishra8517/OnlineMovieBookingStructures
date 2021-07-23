using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace OnlineMovieBooking.ControllerService
{
    public class UserControllerService
    {
        private UserProxy userProxy = new UserProxy();
        public void Add(UserModel user)
        {
            userProxy.Add(user);
        }
        public void Delete(int id)
        {
            userProxy.Delete(id);
        }
        public void Update(int id, UserModel user)
        {
            userProxy.Update(id, user);
        }
        public UserModel GetById(int id)
        {
            return userProxy.GetById(id);
        }
        public List<UserModel> GetAll()
        {
            return userProxy.GetAll();
        }
        public UserModel GetByUserName(string username)
        {
            return userProxy.GetByUserName(username);
        }
        public UserModel GetByEmail(string email)
        {
            return userProxy.GetByEmail(email);
        }
    }
}