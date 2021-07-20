using OnlineMovieBooking.Domain.Services.CinemaService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface ICinemaProxy
    {
        void Add(CinemaModel cinema);
        void Delete(int id);
        void Update(int id, CinemaModel cinema);
        CinemaModel GetById(int id);
        List<CinemaModel> GetAll();
    }
}