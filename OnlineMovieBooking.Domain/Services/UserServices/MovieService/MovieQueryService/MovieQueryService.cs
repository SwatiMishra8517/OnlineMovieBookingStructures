using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.MovieService.MovieQueryService
{
    public class MovieQueryService : IMovieQueryService
    {
        MovieRepository mr = new MovieRepository();
        public List<Movie> GetAll()
        {
            List<DTO.Movie> m = new List<Movie>();
            List<Repository.Entities.Movie> ms = mr.GetAll();
            foreach(var mov in ms)
            {
                DTO.Movie dm = new Movie();
                dm.MovieId = mov.MovieId;
                dm.Name = mov.Name;
                dm.Language = mov.Language;
                dm.Genre = mov.Genre;
                dm.Duration = mov.Duration;
                dm.Description = mov.Description;
                dm.ReleaseDate = mov.ReleaseDate;
                dm.Shows = (ICollection<Show>)mov.Shows;
                m.Add(dm);
            }
            return m;

        }

        public List<Movie> GetByGenre(string genre)
        {
            List<DTO.Movie> m = new List<Movie>();
            List<Repository.Entities.Movie> ms = mr.GetByGenre(genre);
            foreach (var mov in ms)
            {
                DTO.Movie dm = new Movie();
                dm.MovieId = mov.MovieId;
                dm.Name = mov.Name;
                dm.Language = mov.Language;
                dm.Genre = mov.Genre;
                dm.Duration = mov.Duration;
                dm.Description = mov.Description;
                dm.ReleaseDate = mov.ReleaseDate;
                dm.Shows = (ICollection<Show>)mov.Shows;
                m.Add(dm);
            }
            return m;
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetByLanguage(string language)
        {
            List<DTO.Movie> m = new List<Movie>();
            List<Repository.Entities.Movie> ms = mr.GetByLanguage(language);
            foreach (var mov in ms)
            {
                DTO.Movie dm = new Movie();
                dm.MovieId = mov.MovieId;
                dm.Name = mov.Name;
                dm.Language = mov.Language;
                dm.Genre = mov.Genre;
                dm.Duration = mov.Duration;
                dm.Description = mov.Description;
                dm.ReleaseDate = mov.ReleaseDate;
                dm.Shows = (ICollection<Show>)mov.Shows;
                m.Add(dm);
            }
            return m;
        }

        public Movie GetByName(string name)
        {
            DTO.Movie dm = new Movie();
            Repository.Entities.Movie mov = mr.GetByName(name);
            dm.MovieId = mov.MovieId;
            dm.Name = mov.Name;
            dm.Language = mov.Language;
            dm.Genre = mov.Genre;
            dm.Duration = mov.Duration;
            dm.Description = mov.Description;
            dm.ReleaseDate = mov.ReleaseDate;
            dm.Shows = (ICollection<Show>)mov.Shows;
            return dm;
        }

        public List<Movie> GetByReleaseDate(DateTime date)
        {
            List<DTO.Movie> m = new List<Movie>();
            List<Repository.Entities.Movie> ms = mr.GetByReleaseDate(date);
            foreach (var mov in ms)
            {
                DTO.Movie dm = new Movie();
                dm.MovieId = mov.MovieId;
                dm.Name = mov.Name;
                dm.Language = mov.Language;
                dm.Genre = mov.Genre;
                dm.Duration = mov.Duration;
                dm.Description = mov.Description;
                dm.ReleaseDate = mov.ReleaseDate;
                dm.Shows = (ICollection<Show>)mov.Shows;
                m.Add(dm);
            }
            return m;
        }
    }
}
