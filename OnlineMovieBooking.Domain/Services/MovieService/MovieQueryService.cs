using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.MovieService
{
    public class MovieQueryService : IMovieQueryService
    {
        private readonly IMovieRepository repository;
        private MovieRepository mr;
        public MovieQueryService() { }
        public MovieQueryService(IMovieRepository repository)
        {
            this.repository = repository;
        }
        public Movie Get(int id)
        {
            Repository.Entities.Movie movie = mr.GetById(id);
            Movie m = new Movie
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                Duration = movie.Duration,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate
            };
            return m;
        }

        public List<Movie> GetAll()
        {
            var retList = mr.GetAll()
            .Select(movie => new Movie()
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                Duration = movie.Duration,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate
            })
            .ToList();
            return retList;
        }
    }
}
