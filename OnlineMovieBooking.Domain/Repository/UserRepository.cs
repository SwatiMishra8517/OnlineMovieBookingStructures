using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public class UserRepository : IUserRepository
    {
        private MovieContext db;
        public UserRepository()
        {
            db = new MovieContext();
        }
        public UserRepository(MovieContext context)
        {
            this.db = context;
        }
        public void Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public User GetById(int id)
        {
            return db.Users.Find(id);
        }
        public void Update(int id, User user)
        {
            var u = GetById(id);
            u = user;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var user = GetById(id);
            db.Users.Remove(user);
            db.SaveChanges();
        }
        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public User GetByUserName(string userName)
        {
            var user = db.Users.Where(m => m.Username == userName).FirstOrDefault();
            return user;
        }

        public User GetByEmail(string email)
        {
            var user = db.Users.Where(m => m.Email == email).FirstOrDefault();
            return user;
        }
    }
}
