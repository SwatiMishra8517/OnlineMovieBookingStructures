using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaHallService
{
    public interface ICinemaHallQueryService
    {
        CinemaHall Get(int id);
        List<CinemaHall> GetAll();
    }
}