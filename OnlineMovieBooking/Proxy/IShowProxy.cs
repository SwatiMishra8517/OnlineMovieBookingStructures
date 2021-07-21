using OnlineMovieBooking.Domain.Services.ShowService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface IShowProxy
    {
        void Add(ShowModel showModel);
        void Delete(int id);
        void Update(int id, ShowModel showModel);
        ShowModel GetById(int id);
        List<ShowModel> GetAll();
        List<ShowModel> GetByDate(DateTime date);
        List<ShowModel> GetByStartTime(DateTime time);
        List<ShowModel> GetByCinemaHallId(int id);
        List<ShowModel> GetByMovieId(int id);
    }
}