using OnlineMovieBooking.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.ControllerService
{
    public class CinemaHallControllerService
    {
        private CinemaHallProxy cinemaHallProxy = new CinemaHallProxy();
        public void Add(CinemaHallModel cinemaHall)
        {
            cinemaHallProxy.Add(cinemaHall);
        }
        public void Delete(int id)
        {
            cinemaHallProxy.Delete(id);
        }
        public void Update(int id, CinemaHallModel cinemaHall)
        {
            cinemaHallProxy.Update(id, cinemaHall);
        }
        public CinemaHallModel GetById(int id)
        {
            return cinemaHallProxy.GetById(id);
        }
        public List<CinemaHallModel> GetAll()
        {
            return cinemaHallProxy.GetAll();
        }
        public CinemaHallModel GetByName(string name)
        {
            return cinemaHallProxy.GetByName(name);
        }
    }
}