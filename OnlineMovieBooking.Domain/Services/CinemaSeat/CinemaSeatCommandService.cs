using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaSeat
{
    public class CinemaSeatCommandService : ICinemaSeatCommandService
    {
        private readonly ICinemaSeatRepository repository;
        
        public CinemaSeatCommandService(ICinemaSeatRepository repository)
        {
            this.repository = repository;
        }
    }
}
