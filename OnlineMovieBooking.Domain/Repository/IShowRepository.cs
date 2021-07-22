using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface IShowRepository
    {
        void Add(Show show);
        Show GetById(int id);
        void Update(int id,Show show);
        void Delete(int id);
        List<Show> GetAll();
        List<Show> GetByDate(DateTime date);
        List<Show> GetByStartTime(DateTime time);
        List<Show> GetByCinemaHallId(int id);
        List<Show> GetByMovieId(int id);
        List<Show> GetByCinemaId(int id);
    }
}