using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface IShowSeatRepository
    {
        void Add(ShowSeat showSeat);
        ShowSeat GetById(int id);
        void Update(int id, ShowSeat showSeat);
        void Delete(int id);
        List<ShowSeat> GetAll();
        List<ShowSeat> GetByShowId(int id);
        string GetStatus(int id);


    }
}