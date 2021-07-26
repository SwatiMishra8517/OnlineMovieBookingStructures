using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ControllerService
{
    public class ShowSeatControllerService
    {
        private ShowSeatProxy showSeatProxy = new ShowSeatProxy();
        public void Add(ShowSeatModel showSeat)
        {
            showSeatProxy.Add(showSeat);
        }
        public void Delete(int id)
        {
            showSeatProxy.Delete(id);
        }
        public void Update(int id, ShowSeatModel showSeat)
        {
            showSeatProxy.Update(id, showSeat);
        }
        public ShowSeatModel GetById(int id)
        {
            return showSeatProxy.GetById(id);
        }
        public List<ShowSeatModel> GetAll()
        {
            return showSeatProxy.GetAll();
        }
        public List<ShowSeatModel> GetByShowId(int id)
        {
            return showSeatProxy.GetByShowId(id);
        }
        public string GetStatus(int id)
        {
            return showSeatProxy.GetStatus(id);
        }
        public List<ShowSeatModel> GetNonReserved()
        {
            return showSeatProxy.GetNonReserved();
        }
    }
}