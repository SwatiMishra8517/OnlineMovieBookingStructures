using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Cinema
{
    public class CinemaCommandService : ICinemaCommandService
    {
        private readonly ICinemaRepository repository;

        public CinemaCommandService(ICinemaRepository repository)
        {
            this.repository = repository;
        }
    }
}
