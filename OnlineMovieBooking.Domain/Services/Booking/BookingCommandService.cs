using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Booking
{
    public class BookingCommandService : IBookingCommandService
    {
        private readonly IBookingRepository repository;

        public BookingCommandService(IBookingRepository repository)
        {
            this.repository = repository;
        }
    }
}
