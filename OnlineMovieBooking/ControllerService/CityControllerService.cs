using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ControllerService
{
    public class CityControllerService
    {
        CityProxy cityProxy = new CityProxy();
        public void Add(CityModel user)
        {
            cityProxy.Add(user);
        }
        public void Delete(int id)
        {
            cityProxy.Delete(id);
        }
        public void Update(int id, CityModel city)
        {
            cityProxy.Update(id, city);
        }
        public CityModel GetById(int id)
        {
            return cityProxy.GetById(id);
        }
        public List<CityModel> GetAll()
        {
            return cityProxy.GetAll();
        }

    }
}