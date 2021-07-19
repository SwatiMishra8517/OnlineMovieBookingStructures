using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface ICinemaHallRepository
    {
        List<CinemaHall> GetAllCinemaHalls();
        CinemaHall GetCinemaHallById(int id);
        void AddCinemaHall(CinemaHall cinemaHall);
        void EditCinemaHall(int id,CinemaHall cinemaHall);
        void DeleteCinemaHall(int id);
    }
}