using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.MovieService
{
    public interface IMovieQueryService
    {
        Movie Get(int id);
        List<Movie> GetAll();
    }
}