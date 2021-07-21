using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ControllerService
{
    public class CinemaSeatControllerService
    {
        private CinemaSeatProxy seatProxy = new CinemaSeatProxy();
        public void Add(CinemaSeatModel cinemaSeat)
        {
            seatProxy.Add(cinemaSeat);
        }
        public void Delete(int id)
        {
            seatProxy.Delete(id);
        }
        public void Update(int id, CinemaSeatModel cinemaSeat)
        {
            seatProxy.Update(id, cinemaSeat);
        }
        public CinemaSeatModel GetById(int id)
        {
            return seatProxy.GetById(id);
        }
        public List<CinemaSeatModel> GetAll()
        {
            return seatProxy.GetAll();
        }
        public List<CinemaSeatModel> GetByCinemaHallId(int id)
        {
            return seatProxy.GetByCinemaHallId(id);
        }
        public CinemaSeatModel GetBySeatId(int id)
        {
            return seatProxy.GetBySeatId(id);
        }
        public CinemaSeatModel GetBySeatNumber(string number)
        {
            return seatProxy.GetBySeatNumber(number);
        }
    }
}