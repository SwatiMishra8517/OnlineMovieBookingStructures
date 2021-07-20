using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.MovieService.MovieQueryService
{
    interface IMovieQueryService
    {
        List<Movie> GetAll();
        Movie GetById(int id);
        Movie GetByName(string name);
        List<Movie> GetByLanguage(string language);
        List<Movie> GetByGenre(string genre);
        List<Movie> GetByReleaseDate(DateTime date);
    }
}
