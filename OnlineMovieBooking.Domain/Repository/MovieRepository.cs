using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private MovieContext db;
        public MovieRepository()
        {
            db = new MovieContext();
        }
        public MovieRepository(MovieContext context)
        {
            this.db = context;
        }
        public void Add(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }
        public Movie GetById(int id)
        {
            return db.Movies.Find(id);
        }
        public void Update(int id, Movie movie)
        {
            var s = GetById(id);
            s = movie;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var movie = GetById(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }
        public List<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public Movie GetByName(string name)
        {
            return (Movie)db.Movies.Where(m => m.Name == name);
        }

        public List<Movie> GetByLanguage(string language)
        {
            return db.Movies.Where(m => m.Language == language).ToList();
        }

        public List<Movie> GetByGenre(string genre)
        {
            return db.Movies.Where(m => m.Genre == genre).ToList();
        }

        public List<Movie> GetByReleaseDate(DateTime date)
        {
            return db.Movies.Where(m => m.ReleaseDate == date).ToList();
        }
    }
}
