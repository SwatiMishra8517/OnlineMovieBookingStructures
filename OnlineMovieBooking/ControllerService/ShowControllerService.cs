using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ControllerService
{
    public class ShowControllerService
    {
        private ShowProxy showProxy = new ShowProxy();
        public void Add(ShowModel show)
        {
            showProxy.Add(show);
        }
        public void Delete(int id)
        {
            showProxy.Delete(id);
        }
        public void Update(int id, ShowModel show)
        {
            showProxy.Update(id, show);
        }
        public ShowModel GetById(int id)
        {
            return showProxy.GetById(id);
        }
        public List<ShowModel> GetAll()
        {
            return showProxy.GetAll();
        }
        public List<ShowModel> GetByCinemaHallId(int id)
        {
            return showProxy.GetByCinemaHallId(id);
        }
        public List<ShowModel> GetByDate(DateTime date)
        {
            return showProxy.GetByDate(date);
        }
        public List<ShowModel> GetByMovieId(int id)
        {
            return showProxy.GetByMovieId(id);
        }
        public List<ShowModel> GetByStartTime(DateTime time)
        {
            return showProxy.GetByStartTime(time);
        }
        public List<ShowModel> GetByCinemaId(int id)
        {
            return showProxy.GetByCinemaId(id);
        }
    }
}