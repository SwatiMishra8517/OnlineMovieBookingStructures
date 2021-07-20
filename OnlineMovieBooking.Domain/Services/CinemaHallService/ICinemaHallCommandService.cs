using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaHallService
{
    public interface ICinemaHallCommandService
    {
        void Add(CinemaHall cinemaHall);
        void Delete(int id);
        void Update(int id, CinemaHall cinemaHall);
    }
}