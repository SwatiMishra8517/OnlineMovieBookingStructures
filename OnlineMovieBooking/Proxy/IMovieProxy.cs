using OnlineMovieBooking.Domain.Services.MovieService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface IMovieProxy
    {
        void Add(MovieModel movie);
        void Delete(int id);
        void Update(int id, MovieModel movie);
        MovieModel GetById(int id);
        List<MovieModel> GetAll();
    }
}