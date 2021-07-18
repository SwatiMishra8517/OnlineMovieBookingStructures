using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Movie
{
    public class MovieCommandService : IMovieCommandService
    {
        private readonly IMovieRepository repository;

        public MovieCommandService(IMovieRepository repository)
        {
            this.repository = repository;
        }
    }
}
