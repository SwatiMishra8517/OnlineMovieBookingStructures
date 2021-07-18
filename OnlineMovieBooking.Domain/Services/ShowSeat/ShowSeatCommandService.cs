using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowSeat
{
    public class ShowSeatCommandService : IShowSeatCommandService
    {
        private readonly IShowSeatRepository repository;
        
        public ShowSeatCommandService(IShowSeatRepository repository)
        {
            this.repository = repository;
        }
    }
}
