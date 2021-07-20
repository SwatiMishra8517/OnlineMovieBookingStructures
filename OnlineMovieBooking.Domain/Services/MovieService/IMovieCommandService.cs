using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.MovieService
{
    public interface IMovieCommandService
    {
        void Add(Movie movie);
        void Delete(int id);
        void Update(int id, Movie movie);
    }
}