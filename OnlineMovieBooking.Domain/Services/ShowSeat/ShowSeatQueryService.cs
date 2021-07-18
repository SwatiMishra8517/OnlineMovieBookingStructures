using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowSeat
{
    public class ShowSeatQueryService : IShowSeatQueryService
    {
        private readonly IShowSeatRepository repository;
        
        public ShowSeatQueryService(IShowSeatRepository repository)
        {
            this.repository = repository;
        }
    }
}
