using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ControllerService
{
    public class MovieControllerService
    {
        private MovieProxy movieProxy = new MovieProxy();
        public void Add(MovieModel movie)
        {
            movieProxy.Add(movie);
        }
        public void Delete(int id)
        {
            movieProxy.Delete(id);
        }
        public void Update(int id, MovieModel movie)
        {
            movieProxy.Update(id, movie);
        }
        public MovieModel GetById(int id)
        {
            return movieProxy.GetById(id);
        }
        public List<MovieModel> GetAll()
        {
            return movieProxy.GetAll();
        }
        public List<MovieModel> GetByLanguage(string language)
        {
            return movieProxy.GetByLanguage(language);
        }
        public List<MovieModel> GetByReleaseDate(DateTime date)
        {
            return movieProxy.GetByReleaseDate(date);
        }
    }
}