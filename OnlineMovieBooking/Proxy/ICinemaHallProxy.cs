using OnlineMovieBooking.Domain.Services.CinemaHallService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface ICinemaHallProxy
    {
        void Add(CinemaHallModel cinemaHall);
        void Delete(int id);
        void Update(int id, CinemaHallModel cinemaHall);
        CinemaHallModel GetById(int id);
        List<CinemaHallModel> GetAll();
        CinemaHallModel GetByName(string name);
    }
}