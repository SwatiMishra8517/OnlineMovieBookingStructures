using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.CinemaHallService.CinemaHallQueryService
{
    interface ICinemaHallQueryService
    {
        List<CinemaHall> GetAll();
        CinemaHall GetById(int id);
        CinemaHall GetByName(string name);
    }
}
