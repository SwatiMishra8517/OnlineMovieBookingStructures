using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.MovieService
{
    public class MovieCommandService : IMovieCommandService
    {
        private readonly IMovieRepository repository;
        private MovieRepository mr;
        public MovieCommandService() { }
        public MovieCommandService(IMovieRepository repository)
        {
            this.repository = repository;
        }
        public void Add(Movie movie)
        {
            Repository.Entities.Movie m = new Repository.Entities.Movie
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                Duration = movie.Duration,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate
            };
            mr.Add(m);
        }

        public void Delete(int id)
        {
            Repository.Entities.Movie u = new Repository.Entities.Movie();
            mr.Delete(id);
        }

        public void Update(int id, Movie movie)
        {
            Repository.Entities.Movie m = mr.GetById(id);
            m.MovieId = movie.MovieId;
            m.Name = movie.Name;
            m.Language = movie.Language;
            m.Genre = movie.Genre;
            m.Duration = movie.Duration;
            m.Description = movie.Description;
            m.ReleaseDate = movie.ReleaseDate;
            mr.Update(id, m);
        }
    }
}
