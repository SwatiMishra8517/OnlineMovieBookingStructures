using OnlineMovieBooking.Domain.Services.CityService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface ICityProxy
    {
        void Add(CityModel user);
        void Delete(int id);
        void Update(int id, CityModel city);
        CityModel GetById(int id);
        List<CityModel> GetAll();
    }
}