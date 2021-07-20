using OnlineMovieBooking.Domain.Services.MovieService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class MovieProxy : IMovieProxy
    {
        private readonly MovieCommandService mcs = new MovieCommandService();
        private readonly MovieQueryService mqs = new MovieQueryService();
        public MovieProxy() { }
        public MovieProxy(MovieQueryService movieQueryService, MovieCommandService movieCommandService)
        {
            this.mcs = movieCommandService;
            this.mqs = movieQueryService;
        }

        public void Add(MovieModel movie)
        {
            var m = new OnlineMovieBooking.Domain.DTO.Movie
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                Duration = movie.Duration,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate,
            };
            mcs.Add(m);
        }

        public void Delete(int id)
        {
            mcs.Delete(id);
        }

        public List<MovieModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.Movie> movies = mqs.GetAll();
            List<MovieModel> mms = new List<MovieModel>();
            foreach (var movie in movies)
            {
                MovieModel m = new MovieModel
                {
                    MovieId = movie.MovieId,
                    Name = movie.Name,
                    Language = movie.Language,
                    Genre = movie.Genre,
                    Duration = movie.Duration,
                    Description = movie.Description,
                    ReleaseDate = movie.ReleaseDate,
                };
                mms.Add(m);
            }
            return mms;
        }

        public MovieModel GetById(int id)
        {
            var movie = mqs.Get(id);
            MovieModel m = new MovieModel
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                Duration = movie.Duration,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate,
            };
            return m;
        }

        public void Update(int id, MovieModel movie)
        {
            var m = new OnlineMovieBooking.Domain.DTO.Movie
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                Duration = movie.Duration,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate,
            };
            mcs.Update(id, m);

        }
    }
}