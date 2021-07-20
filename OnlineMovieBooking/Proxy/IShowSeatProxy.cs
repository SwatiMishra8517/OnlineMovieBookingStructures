using OnlineMovieBooking.Domain.Services.ShowSeatService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface IShowSeatProxy
    {
        void Add(ShowSeatModel showSeat);
        void Delete(int id);
        void Update(int id,ShowSeatModel showSeat);
        ShowSeatModel GetById(int id);
        List<ShowSeatModel> GetAll();
    }
}