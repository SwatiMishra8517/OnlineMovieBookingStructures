using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ControllerService
{
    public class CinemaControllerService
    {
        private CinemaProxy cinemaProxy = new CinemaProxy();
        public void Add(CinemaModel cinema)
        {
            cinemaProxy.Add(cinema);
        }
        public void Delete(int id)
        {
            cinemaProxy.Delete(id);
        }
        public void Update(int id, CinemaModel cinema)
        {
            cinemaProxy.Update(id, cinema);
        }
        public CinemaModel GetById(int id)
        {
            return cinemaProxy.GetById(id);
        }
        public List<CinemaModel> GetAll()
        {
            return cinemaProxy.GetAll();
        }
        public List<CinemaModel> GetByCityId(int id)
        {
            return cinemaProxy.GetByCityId(id);
        }
        public CinemaModel GetByName(string name)
        {
            return cinemaProxy.GetByName(name);
        }
    }
}