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
        private readonly OnlineMovieBooking.Domain.Services.UserServices.MovieService.MovieQueryService.MovieQueryService ums = new Domain.Services.UserServices.MovieService.MovieQueryService.MovieQueryService();
        public MovieProxy() { }
        public MovieProxy(MovieQueryService movieQueryService, MovieCommandService movieCommandService, OnlineMovieBooking.Domain.Services.UserServices.MovieService.MovieQueryService.MovieQueryService um)
        {
            this.mcs = movieCommandService;
            this.mqs = movieQueryService;
            this.ums = um;
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

        public List<MovieModel> GetByGenre(string genre)
        {
            List<MovieModel> m = new List<MovieModel>();
            List<OnlineMovieBooking.Domain.DTO.Movie> ms = ums.GetByGenre(genre);
            foreach (var mov in ms)
            {
                MovieModel dm = new MovieModel
                {
                    MovieId = mov.MovieId,
                    Name = mov.Name,
                    Language = mov.Language,
                    Genre = mov.Genre,
                    Duration = mov.Duration,
                    Description = mov.Description,
                    ReleaseDate = mov.ReleaseDate
                };
                m.Add(dm);
            }
            return m;
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

        public List<MovieModel> GetByLanguage(string language)
        {
            List<MovieModel> m = new List<MovieModel>();
            List<OnlineMovieBooking.Domain.DTO.Movie> ms = ums.GetByLanguage(language);
            foreach (var mov in ms)
            {
                MovieModel dm = new MovieModel
                {
                    MovieId = mov.MovieId,
                    Name = mov.Name,
                    Language = mov.Language,
                    Genre = mov.Genre,
                    Duration = mov.Duration,
                    Description = mov.Description,
                    ReleaseDate = mov.ReleaseDate
                };
                m.Add(dm);
            }
            return m;
        }

        public MovieModel GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<MovieModel> GetByReleaseDate(DateTime date)
        {
            List<MovieModel> m = new List<MovieModel>();
            List<OnlineMovieBooking.Domain.DTO.Movie> ms = ums.GetByReleaseDate(date);
            foreach (var mov in ms)
            {
                MovieModel dm = new MovieModel
                {
                    MovieId = mov.MovieId,
                    Name = mov.Name,
                    Language = mov.Language,
                    Genre = mov.Genre,
                    Duration = mov.Duration,
                    Description = mov.Description,
                    ReleaseDate = mov.ReleaseDate
                };
                m.Add(dm);
            }
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