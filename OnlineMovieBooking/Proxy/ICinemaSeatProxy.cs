using OnlineMovieBooking.Domain.Services.CinemaSeatService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface ICinemaSeatProxy
    {
        void Add(CinemaSeatModel cinemaSeat);
        void Delete(int id);
        void Update(int id, CinemaSeatModel cinemaSeat);
        CinemaSeatModel GetById(int id);
        List<CinemaSeatModel> GetAll();
        List<CinemaSeatModel> GetByCinemaHallId(int id);
        CinemaSeatModel GetBySeatId(int id);
        CinemaSeatModel GetBySeatNumber(string number);
    }
}