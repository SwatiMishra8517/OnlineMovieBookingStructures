using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaSeat
{
    public class CinemaSeatQueryService : ICinemaSeatQueryService
    {
        private readonly ICinemaSeatRepository repository; 

        public CinemaSeatQueryService(ICinemaSeatRepository repository)
        {
            this.repository = repository;
        }
    }
}
