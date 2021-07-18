using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaHall
{
    public class CinemaHallCommandService : ICinemaHallCommandService
    {
        private readonly ICinemaHallRepository repository; 
        
        public CinemaHallCommandService(ICinemaHallRepository repository)
        {
            this.repository = repository;
        }
    }
}
