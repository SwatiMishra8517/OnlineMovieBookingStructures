using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        Movie GetById(int id);
        void Update(int id, Movie movie);
        void Delete(int id);
        List<Movie> GetAll();
    }
}