using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public class ShowRepository : IShowRepository
    {
        private MovieContext db;
        public ShowRepository()
        {
            db = new MovieContext();
        }
        public ShowRepository(MovieContext context)
        {
            this.db = context;
        }
        public void Add(Show show)
        {
            db.Shows.Add(show);
            db.SaveChanges();
        }
        public Show GetById(int id)
        {
            return db.Shows.Find(id);
        }
        public void Update(int id, Show show)
        {
            var s = GetById(id);
            s = show;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var show = GetById(id);
            db.Shows.Remove(show);
            db.SaveChanges();
        }
        public List<Show> GetAll()
        {
            return db.Shows.ToList();
        }
    }
}
