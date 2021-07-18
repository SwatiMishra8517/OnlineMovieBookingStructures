using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.City
{
    public class CityCommandService : ICityCommandService
    {
        private readonly ICityRepository repository;

        public CityCommandService(ICityRepository repository)
        {
            this.repository = repository;
        }
    }
}
