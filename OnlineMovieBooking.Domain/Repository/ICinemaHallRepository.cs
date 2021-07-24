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
        List<CinemaHall> GetAll();
        CinemaHall GetByName(string name);
        CinemaHall GetById(int id);
        void Add(CinemaHall cinemaHall);
        void Update(int id,CinemaHall cinemaHall);
        void Delete(int id);
    }
}