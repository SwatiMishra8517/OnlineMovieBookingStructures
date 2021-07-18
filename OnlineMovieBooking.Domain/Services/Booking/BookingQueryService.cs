using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Booking
{
    public class BookingQueryService : IBookingQueryService
    {
        private readonly IBookingRepository repository;

        public BookingQueryService(IBookingRepository repository)
        {
            this.repository = repository;
        }
    }
}
